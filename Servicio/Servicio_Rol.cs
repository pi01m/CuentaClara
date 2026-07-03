using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public abstract class Servicio_Rol: IVerificable
    {
        public string IdRol { get; set; }
        public string Nombre { get; set; }

        public Servicio_Rol(string idRol, string nombre)
        {
            IdRol = idRol;
            Nombre = nombre;
        }
        public virtual string ObtenerIdentificadorFila() => this.IdRol;

        public virtual string ObtenerCadenaParaHash()
        {
            return $"{IdRol}|{Nombre}";
        }
    }
}
