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
        private readonly DAL_Familia _dalFamiliaPermiso;
        private readonly Servicio_Cripto _encriptadorServicio;
        private readonly SessionManager _sm;

        public BLL_Usuario()
        {
            string connStr ="Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            _dalUsuario = new DAL_Usuario(connStr);

            //_dalFamiliaPermiso = new DAL_FamiliaRol(connStr);

            _encriptadorServicio = new Servicio_Cripto();

            _bitacoraServicio = new BLL_BitacoraEvento();
               
                    

            _sm = SessionManager.GetInstancia();
        }
        public DataTable ListarUsuarios()
        {
            return _dalUsuario.ListarUsuarios();
        }
        public DataTable ListarUsuariosActivos()
        {
            return _dalUsuario.ListarUsuariosActivos();
        }

        public void AsignarPermisos( List<Servicio_Rol> permisos,Servicio_Usuario usuario){
            foreach (Servicio_Rol permiso in permisos)
            {
                usuario.Permisos.AgregarRol(permiso);
            }
        }
        public bool AsignarRol(string dni, string idRol)
        {
            return _dalUsuario.AsignarRol(dni, idRol);
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

                _bitacoraServicio.RegistrarBitacora("Login Incorrecto",login,"Seguridad",1);
                 return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CrearUsuario(Servicio_Usuario usuario)
    
        {
            try
            {
                if (_dalUsuario.ExisteUsuario(usuario.Login))
                    return false;

                string contraseñaInicial = usuario.Apellido + usuario.DNI;
                   

                usuario.Password =_encriptadorServicio .CifrarContraseña( contraseñaInicial);
                       
                usuario.Bloqueo = 0;

                bool resultado = _dalUsuario.CrearUsuario(usuario);
                   

                if (resultado)
                {
                    _bitacoraServicio.RegistrarBitacora("Usuario Creado",usuario.Login,"Administracion",3);
     
                        
                }

                return resultado;
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

        public void DesbloquearUsuario(string login)
        {
            _dalUsuario.ReiniciarIntentos(login);

            _bitacoraServicio.RegistrarBitacora("Usuario Desbloqueado", login,"Administracion",1);
                     
        }

        public bool IniciarSesion(string nombreUsuario, string hash)
        {
      
            int intentos = _dalUsuario.ObtenerIntentos(nombreUsuario);
            if (intentos >= 3)
            {
                _bitacoraServicio.RegistrarBitacora( "Intento de login bloqueado",nombreUsuario,"Seguridad",1 );
                throw new Exception("Usuario bloqueado");
            }

      
            Servicio_Usuario usuario = _dalUsuario.AutenticarUsuario(nombreUsuario, hash);
               

            if (usuario == null)
            {
                IncrementarIntentos(nombreUsuario);
               
                int intentosActualizados = _dalUsuario.ObtenerIntentos(nombreUsuario);
                throw new Exception(
                    $"Contraseña incorrecta. Intentos restantes: {3 - intentosActualizados}"
                );
                
            }

            
            if (!VerificarEstadoUsuario(usuario))
            {
                _bitacoraServicio.RegistrarBitacora( "Usuario bloqueado o inactivo", nombreUsuario, "Seguridad",1);

                throw new Exception("Usuario bloqueado o inactivo");
            }

            
            _sm.CrearSesion(usuario);

           
            _bitacoraServicio.RegistrarBitacora("Login correcto", usuario.Login,"Seguridad",1);

            return true;
        }

        public void CerrarSesion()
        {
            Servicio_Usuario usuario = _sm.GetUsuarioActual();

            if (usuario != null)
            {
                
                _bitacoraServicio.RegistrarBitacora("Cerrar Sesión",usuario.Login,"Seguridad",1

                );

                
                _sm.CerrarSesion();
            }
        }
        public int ObtenerIntentos(string login)
        {
            return _dalUsuario.ObtenerIntentos(login);
        }

        public bool VerificarEstadoUsuario(Servicio_Usuario usuario)
        {
            if (usuario.Activo != 1) return false;

            if (usuario.Bloqueo >= 3) return false;

            return true;
        }

        public Servicio_Usuario ObtenerUsuario(string dni)
        {
            return _dalUsuario.ObtenerUsuario(dni);
        }
        public Servicio_Usuario ObtenerUsuarioPorLogin(string login)
        {
            return _dalUsuario.ObtenerUsuarioPorLogin(login);
        }
        public bool CambiarEstadoUsuario(string dni, int activo)
        {
            _dalUsuario.CambiarEstadoUsuario(dni, activo);

            _bitacoraServicio.RegistrarBitacora(activo == 1 ? "Activar Usuario" : "Desactivar Usuario",ObtenerUsuario(dni).Login, "Seguridad", 1); 

            return true;
        }

        public bool ModificarUsuario(string dni,string nuevoNombre,string nuevoApellido, string nuevoEmail)
        {
            try
            {
                Servicio_Usuario usuario = _dalUsuario.ObtenerUsuario(dni);

                if (usuario == null)return false;

                if (!VerificarEstadoUsuario(usuario))return false;

                usuario.Nombre = nuevoNombre;
                usuario.Apellido = nuevoApellido;
                usuario.email = nuevoEmail;

                _dalUsuario.ModificarUsuario(usuario);

                Servicio_Usuario admin =_sm.GetUsuarioActual();

                _bitacoraServicio.RegistrarBitacora("Usuario Modificado",admin.Login,"Administracion",3);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ValidarAdministrador(  string contraseñaIngresada)
  
        {
            Servicio_Usuario admin = SessionManager.GetInstancia() .GetUsuarioActual();

            string hash =_encriptadorServicio.CifrarContraseña( contraseñaIngresada);
            return string.Equals(hash,admin.Password, StringComparison.OrdinalIgnoreCase);  
  
        }
        public DataTable ListarLogins()
        {
            return _dalUsuario.ListarLogins();
        }

        public bool CambiarClave(string claveActual, string claveNueva)
        {
            
            SessionManager session = SessionManager.GetInstancia();
            Servicio_Usuario usuarioActual = session.GetUsuarioActual();

            if (usuarioActual == null) return false;
            string hashActual = _encriptadorServicio.CifrarContraseña(claveActual);

            Servicio_Usuario usuarioValidado = _dalUsuario.AutenticarUsuario(usuarioActual.Login, hashActual);
            if (usuarioValidado == null)
            {
                return false; 
            }
            string nuevoHash = _encriptadorServicio.CifrarContraseña(claveNueva);

            bool actualizacionExitosa = _dalUsuario.ActualizarClave(usuarioActual.Login, nuevoHash);
            _bitacoraServicio.RegistrarBitacora("Usuario Creado", usuarioActual.Login, "Administracion", 3);
            return actualizacionExitosa;
        }
    }
}
