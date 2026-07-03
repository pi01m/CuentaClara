using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ExcepcionIntegridad:Exception
    {
        public string Tabla { get; }
        public string Registro { get; }
        public bool EsDVV { get; }

        public ExcepcionIntegridad(string tabla,string registro,bool esDVV,string mensaje): base(mensaje)
        {
            Tabla = tabla;
            Registro = registro;
            EsDVV = esDVV;
        }  
            
            
            
            
       
    }
}
