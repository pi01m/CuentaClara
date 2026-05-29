using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DAL;
using Servicio;
namespace BLL
{
    public class BLL_Usuario
    {
        private readonly BLL_BitacoraEvento _bitacoraServicio;
        private readonly DAL_Usuario _dalUsuario;
        private readonly DAL_FamiliaRol _dalFamiliaPermiso;
        private readonly DAL_BitacoraEvento _dalBitacora;
        private readonly Servicio_Cripto _encriptadorServicio;
        private readonly SessionManager _sm;

        public BLL_Usuario(DAL_Usuario dalUsuario, DAL_FamiliaRol dalFamiliaPermiso, DAL_BitacoraEvento dalBitacora)
        {
            _dalUsuario = dalUsuario;
            _dalFamiliaPermiso = dalFamiliaPermiso;
            _dalBitacora = dalBitacora;
            _encriptadorServicio = new Servicio_Cripto();
            _bitacoraServicio = new BLL_BitacoraEvento(_dalBitacora);
            _sm = SessionManager.GetInstancia();
        }

        // ============================================================
        //  Asignar permisos al objeto usuario
        // ============================================================
        public void AsignarPermisos(List<Servicio_Permiso> permisos, Servicio_Usuario usuario)
        {
            foreach (Servicio_Permiso p in permisos)
                usuario.Permisos.AgregarPermiso(p);
        }

        // ============================================================
        //  Punto de entrada desde la GUI
        // ============================================================
        /// <summary>
        /// Recibe credenciales en texto plano, cifra la contraseña
        /// y ejecuta el flujo completo del CU02.
        /// Devuelve true si el login fue exitoso.
        /// </summary>
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

        
        public bool IniciarSesion(string nombreUsuario, string hash)
        {
            
            Servicio_Usuario usuario = _dalUsuario.AutenticarUsuario(nombreUsuario, hash);

            if (usuario == null)
            {
                
                IncrementarIntentos(nombreUsuario);
                return false;
            }

    
            if (!VerificarEstadoUsuario(usuario))
                return false;

       
            ReiniciarIntentos(nombreUsuario);

     
            BLL_FamiliaRol famRolBLL = new BLL_FamiliaRol(_dalFamiliaPermiso);
            List<Servicio_Permiso> permisos = famRolBLL.ListarPermisos(usuario);
            AsignarPermisos(permisos, usuario);

     
            _sm.CrearSesion(usuario);

       
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
        /// <summary>
        /// Devuelve true si el usuario está habilitado, activo y no bloqueado.
        /// Bloqueo >= 3 se considera cuenta bloqueada.
        /// </summary>
        public bool VerificarEstadoUsuario(Servicio_Usuario usuario)
        {
            if (!usuario.Estado) return false;   // suspendido
            if (usuario.Activo != 1) return false;   // inactivo
            if (usuario.Bloqueo >= 3) return false;   // bloqueado por intentos
            return true;
        }
    }
}
