using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public abstract class Servicio_Permiso
    {
        public string IdPermiso { get; set; }
        public string Nombre { get; set; }

        protected Servicio_Permiso(string idPermiso, string nombre)
        {
            IdPermiso = idPermiso;
            Nombre = nombre;
        }

    }
}
