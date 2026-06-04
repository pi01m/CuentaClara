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
            string connStr ="Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            _dalUsuario = new DAL_Usuario(connStr);

            //_dalFamiliaPermiso = new DAL_FamiliaRol(connStr);

            _encriptadorServicio = new Servicio_Cripto();

            _bitacoraServicio =
                new BLL_BitacoraEvento(
                    new DAL_BitacoraEvento(connStr));

            _sm = SessionManager.GetInstancia();
        }

        public void AsignarPermisos( List<Servicio_Permiso> permisos,Servicio_Usuario usuario){
            foreach (Servicio_Permiso permiso in permisos)
            {
                usuario.Permisos.AgregarPermiso(permiso);
            }
        }

        public bool CargarCredenciales(string nombreUsuario,string contraseña){
            
            string hash =_encriptadorServicio.CifrarContraseña(contraseña);
            return IniciarSesion(nombreUsuario, hash);
        }

        public bool CompararHash(string hashIngresado,string hashBD) {

            return string.Equals(hashIngresado,hashBD,StringComparison.OrdinalIgnoreCase);
        }

        public bool IncrementarIntentos(string login)
        {
            try
            {
                _dalUsuario.IncrementarIntentos(login);

                _bitacoraServicio.RegistrarBitacora("Login Incorrecto",login,"Seguridad",2);
                 return true;
            }
            catch
            {
                return false;
            }
        }

        public void ReiniciarIntentos(string login)
        {
            _dalUsuario.ReiniciarIntentos(login);
        }

        public bool IniciarSesion(string nombreUsuario, string hash)
        {
            Servicio_Usuario usuario =_dalUsuario.AutenticarUsuario(nombreUsuario,hash);

            if (usuario == null)
            {
                IncrementarIntentos(nombreUsuario);
                return false;
            }

            if (!VerificarEstadoUsuario(usuario))
            {
                _bitacoraServicio.RegistrarBitacora("Usuario Bloqueado o Inactivo",nombreUsuario,"Seguridad",3);
                return false;
            }

            ReiniciarIntentos(nombreUsuario);

            //BLL_FamiliaRol famRolBLL =
            //    new BLL_FamiliaRol(_dalFamiliaPermiso);

            //List<Servicio_Permiso> permisos =
            //    famRolBLL.ListarPermisos(usuario);

            //AsignarPermisos(permisos, usuario);

            _sm.CrearSesion(usuario);

            _bitacoraServicio.RegistrarBitacora("Login Correcto",usuario.Login,"Seguridad", 1); return true;
        }

        public bool VerificarEstadoUsuario(Servicio_Usuario usuario)
        {
            if (usuario.Activo != 1) return false;

            if (usuario.Bloqueo >= 3) return false;

            return true;
        }
    }
}
