using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Instalador
    {
      
        public static void ConfigurarEntorno(string servidor, string rutaScript)
        {
            bool baseYaExiste = DAL_Instalador.VerificarBaseDeDatos(servidor, "BD_CuentaClara");

            if (baseYaExiste)
            {
                return;
            }

            if (!File.Exists(rutaScript))
            {
                throw new Exception("No se encontró el archivo de base de datos (SetupData.sql).");
            }

            string contenidoScript = File.ReadAllText(rutaScript);
            DAL_Instalador.EjecutarScriptPrimeraVez(servidor, contenidoScript);
        }
    }
}
