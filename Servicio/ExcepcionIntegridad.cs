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

        public List<string> RegistrosModificados { get; }

        public List<string> RegistrosEliminados { get; }

        public bool ErrorDVV { get; }

        public List<ExcepcionIntegridad> Errores { get; }

        // Error de una sola tabla
        public ExcepcionIntegridad(
            string tabla,
            List<string> modificados,
            List<string> eliminados,
            bool errorDVV,
            string mensaje)
            : base(mensaje)
        {
            Tabla = tabla;
            RegistrosModificados = modificados ?? new List<string>();
            RegistrosEliminados = eliminados ?? new List<string>();
            ErrorDVV = errorDVV;
        }

        // Error acumulado de varias tablas
        public ExcepcionIntegridad(List<ExcepcionIntegridad> errores)
            : base("Se detectaron múltiples errores de integridad.")
        {
            Errores = errores ?? new List<ExcepcionIntegridad>();
        }

        public bool TieneMultiplesErrores =>
            Errores != null && Errores.Count > 0;
    }
}
