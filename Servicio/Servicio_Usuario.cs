using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_Usuario
    {
        public int Activo { get; set; }
        public string Apellido { get; set; }
        public int Bloqueo { get; set; }
        public string DNI { get; set; }
        public string email { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public Servicio_Familia Permisos { get; set; } = new Servicio_Familia(string.Empty, string.Empty);

        public string Rol { get; set; }
    }
}
