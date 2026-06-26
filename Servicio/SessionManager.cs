using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class SessionManager
    {
        private static readonly SessionManager _instancia = new SessionManager();

        private Servicio_Usuario _usuarioActual;
        
   
        private SessionManager() { }

        public static SessionManager GetInstancia() => _instancia;

        
        public Servicio_Usuario GetUsuarioActual() => _usuarioActual;
        public void SetUsuarioActual(Servicio_Usuario u) => _usuarioActual = u;

       
       
        public  void CrearSesion(Servicio_Usuario usuario)
        {
           
         _usuarioActual = usuario;
            
        }
        public void CerrarSesion()
        {
            _usuarioActual = null;
        }

        

    }
}
