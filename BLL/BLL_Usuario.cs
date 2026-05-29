using DAL;
using Microsoft.IdentityModel.Protocols;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace BLL
{
    public class BLL_Usuario
    {
        private readonly BLL_BitacoraEvento _bitacoraServicio;
        private readonly DAL_Usuario _dalUsuario;
        private readonly DAL_FamiliaRol _dalFamiliaPermiso;
        private readonly Servicio_Cripto _encriptadorServicio;
        private readonly SessionManager _sm;

        public BLL_Usuario()
        {
            string connStr = $"Data Source=.;Integrated Security=True;Trust Server Certificate=True";

            _dalUsuario = new DAL_Usuario(connStr);
            _dalFamiliaPermiso = new DAL_FamiliaRol(connStr);
            _encriptadorServicio = new Servicio_Cripto();
            _bitacoraServicio = new BLL_BitacoraEvento(new DAL_BitacoraEvento(connStr));
            _sm = SessionManager.GetInstancia();
        }


        public void AsignarPermisos(List<Servicio_Permiso> permisos, Servicio_Usuario usuario)
        {
            foreach (Servicio_Permiso p in permisos)
                usuario.Permisos.AgregarPermiso(p);
        }

        
        public bool CargarCredenciales(string nombreUsuario, string contraseña)
        {
            string hash = _encriptadorServicio.CifrarContraseña(contraseña);
            return IniciarSesion(nombreUsuario, hash);
        }

   
        public bool CompararHash(string hashIngresado, string hashBD) =>
            string.Equals(hashIngresado, hashBD, StringComparison.OrdinalIgnoreCase);


        public bool IncrementarIntentos(string login)
        {
            try
            {
                _dalUsuario.IncrementarIntentos(login);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // ============================================================
        //  Flujo principal de autenticación
        // ============================================================
        public bool IniciarSesion(string nombreUsuario, string hash)
        {
            // a) Autenticar contra BD → DAL_Usuario
            Servicio_Usuario usuario = _dalUsuario.AutenticarUsuario(nombreUsuario, hash);

            if (usuario == null)
            {
                // FA 5.1 – Credenciales incorrectas
                IncrementarIntentos(nombreUsuario);
                return false;
            }

            // b) Verificar estado / bloqueo → FA 5.2
            if (!VerificarEstadoUsuario(usuario))
                return false;

            // c) Reiniciar contador de fallos
            ReiniciarIntentos(nombreUsuario);

            // d) Cargar permisos → BLL_FamiliaRol → DAL_FamiliaPermiso
            BLL_FamiliaRol famRolBLL = new BLL_FamiliaRol(_dalFamiliaPermiso);
            List<Servicio_Permiso> permisos = famRolBLL.ListarPermisos(usuario);
            AsignarPermisos(permisos, usuario);

            // e) Crear sesión global
            _sm.CrearSesion(usuario);

            // f) Registrar evento en bitácora → BLL_BitacoraEvento → DAL_BitacoraEvento
            _bitacoraServicio.RegistrarBitacora("Login Correcto", DateTime.Now);

            return true;
        }

        // ============================================================
        //  Reiniciar intentos
        // ============================================================
        public void ReiniciarIntentos(string login) => _dalUsuario.ReiniciarIntentos(login);

        // ============================================================
        //  Verificar estado del usuario
        // ============================================================
        public bool VerificarEstadoUsuario(Servicio_Usuario usuario)
        {
            
            if (usuario.Activo != 1) return false;   // inactivo
            if (usuario.Bloqueo >= 3) return false;   // bloqueado por intentos
            return true;
        }
    }
}
