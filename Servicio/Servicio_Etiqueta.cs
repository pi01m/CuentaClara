using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Servicio_Etiqueta
    {
        public string Clave { get; set; }

        public string Texto { get; set; }

        public Servicio_Etiqueta()
        {

        }

        public Servicio_Etiqueta(string clave, string texto)
        {
            Clave = clave;
            Texto = texto;
        }
    }
}
