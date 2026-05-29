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
        public Servicio_FamiliaRol Permisos { get; set; } = new Servicio_FamiliaRol(string.Empty, string.Empty);

        public Servicio_Permiso IdFamiliaRol { get; set; }
    }
}
