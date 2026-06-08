using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_Permiso : Servicio_Rol
    {
        public Servicio_Permiso(string idPermiso, string nombre): base(idPermiso, nombre) { }
    }
}
