using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_PermisoSimple : Servicio_Permiso
    {
        public Servicio_PermisoSimple(string idPermiso, string nombre)
        : base(idPermiso, nombre) { }
    }
}
