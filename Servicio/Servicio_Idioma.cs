using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Servicio_Idioma:IVerificable
    {
        public string Id_Idioma { get; set; }
        public string Nombre { get; set; }

        public List<Servicio_Etiqueta> Etiquetas { get; set; }

        public Servicio_Idioma()
        {
            Etiquetas = new List<Servicio_Etiqueta>();
        }

        public string ObtenerIdentificadorFila()
        {
            return Id_Idioma + Nombre;
        }

        public string ObtenerCadenaParaHash()
        {
            return this.Id_Idioma;
        }
    }
}
