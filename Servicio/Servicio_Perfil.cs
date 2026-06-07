using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public abstract class Servicio_Perfil
    {
        public string IdPerfil { get; set; }
        public string Nombre { get; set; }

        protected Servicio_Perfil(string idPermiso, string nombre)
        {
            IdPerfil = idPermiso;
            Nombre = nombre;
        }

    }
}
