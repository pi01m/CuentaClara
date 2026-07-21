using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ConexionDB
    {
        //public static string ObtenerCadena()
        //{

        //    string rutaConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servidor_config.txt");


        //    string servidor = ".";

        //    if (File.Exists(rutaConfig))
        //    {
        //        servidor = File.ReadAllText(rutaConfig).Trim();
        //    }

        //    return $"Data Source={servidor};Initial Catalog=BD_CuentaClara;Integrated Security=True;TrustServerCertificate=True;";
        //}
        //public static string ObtenerCadenaMaster()
        //{
        //    string rutaConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "servidor_config.txt");
        //    string servidor = ".";

        //    if (File.Exists(rutaConfig))
        //    {
        //        servidor = File.ReadAllText(rutaConfig).Trim();
        //    }

        //    // Es idéntica a la otra, pero cambia Initial Catalog por "master"
        //    return $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";
        //}

        private static string ObtenerServidor()
        {
            string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CuentaClara");
            string rutaConfig = Path.Combine(appDataFolder, "servidor_config.txt");

            if (File.Exists(rutaConfig))
            {
                return File.ReadAllText(rutaConfig).Trim();
            }
            return "."; // Por defecto, si el archivo no existe
        }

        // Cadena principal para usar en toda la app
        public static string ObtenerCadena()
        {
            string servidor = ObtenerServidor();
            return $"Data Source={servidor};Initial Catalog=BD_CuentaClara;Integrated Security=True;TrustServerCertificate=True;";
        }

        // Cadena específica para conectarse a "master" durante la instalación
        public static string ObtenerCadenaMaster(string servidorParam)
        {
            string servidor = servidorParam ?? ObtenerServidor();
            return $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";
        }

        // --- MÉTODOS DE INSTALACIÓN INCORPORADOS AQUÍ ---

        // Busca servidores en la red local
        public DataTable ObtenerServidoresRed()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            return instance.GetDataSources();
        }

        // Ejecuta el script de base de datos
        public void EjecutarScriptSQL(string script, string servidor)
        {
            string connString = ObtenerCadenaMaster(servidor);
            string[] comandos = script.Split(new[] { "GO\r\n", "GO\n", "GO " }, StringSplitOptions.RemoveEmptyEntries);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                foreach (string comando in comandos)
                {
                    if (!string.IsNullOrWhiteSpace(comando))
                    {
                        using (SqlCommand cmd = new SqlCommand(comando, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}

