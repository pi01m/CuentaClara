using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class SessionManager
    {
        private static readonly SessionManager _instancia = new SessionManager();

        private Servicio_Usuario _usuarioActual;

        private Servicio_Idioma _idiomaActual;
        private SessionManager() { }

        public static SessionManager GetInstancia() => _instancia;

        
        public Servicio_Usuario GetUsuarioActual() => _usuarioActual;
        public void SetUsuarioActual(Servicio_Usuario u) => _usuarioActual = u;

        public Servicio_Idioma GetIdiomaActual() =>_idiomaActual;
        public void SetIdiomaActual(Servicio_Idioma idioma) => _idiomaActual = idioma;
       
        public bool CrearSesion(Servicio_Usuario usuario)
        {
            try
            {
                _usuarioActual = usuario;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void CerrarSesion()
        {
            _usuarioActual = null;
        }
    }
}
