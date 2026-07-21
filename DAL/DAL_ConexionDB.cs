using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ConexionDB
    {
        public static string ObtenerCadena()
        {
            
            string rutaConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servidor_config.txt");

            
            string servidor = ".";

            if (File.Exists(rutaConfig))
            {
                servidor = File.ReadAllText(rutaConfig).Trim();
            }

            return $"Data Source={servidor};Initial Catalog=BD_CuentaClara;Integrated Security=True;TrustServerCertificate=True;";
        }
        public static string ObtenerCadenaMaster()
        {
            string rutaConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servidor_config.txt");
            string servidor = ".";

            if (File.Exists(rutaConfig))
            {
                servidor = File.ReadAllText(rutaConfig).Trim();
            }

            // Es idéntica a la otra, pero cambia Initial Catalog por "master"
            return $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";
        }
    }
}
