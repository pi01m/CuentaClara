using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_Bitacora
    {
        public int Criticidad { get; set; }
        public string Evento { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string id_Evento { get; set; }
        public string Login { get; set; }
        public string Modulo { get; set; }
        
    }
}
