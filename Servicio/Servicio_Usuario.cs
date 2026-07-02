using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_Usuario : IVerificable
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

        public string IdRol { get; set; } 
        public string Id_Idioma { get; set; }

        public bool ModoEmergencia { get; set; } = false;
        public string ObtenerIdentificadorFila()
        {
            return this.Login; // Usamos el Login como identificador de fila
        }

        public string ObtenerCadenaParaHash()
        {
            // Incluimos campos que afectan la seguridad y el estado del usuario
            return this.Login + this.Password + this.Nombre + this.Apellido + this.IdRol + this.Activo + this.email;
        }
    }
}
