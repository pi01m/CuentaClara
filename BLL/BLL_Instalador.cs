using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Instalador
    {

        private DAL_ConexionDB dalConexion = new DAL_ConexionDB();

        public List<string> ObtenerListaServidores()
        {
            List<string> lista = new List<string>();
            DataTable table = dalConexion.ObtenerServidoresRed(); // Llamada a la nueva ubicación

            foreach (DataRow row in table.Rows)
            {
                string serverName = row["ServerName"].ToString();
                string instanceName = row["InstanceName"].ToString();

                if (string.IsNullOrEmpty(instanceName))
                    lista.Add(serverName);
                else
                    lista.Add($"{serverName}\\{instanceName}");
            }

            if (lista.Count == 0)
            {
                lista.Add(".");
                lista.Add(".\\SQLEXPRESS");
            }

            return lista;
        }

        public void InstalarBaseDeDatos(string servidorElegido, string scriptPathIgnorado = "")
        {
            //if (!File.Exists(scriptPath))
            //{
            //    throw new Exception("No se encontró el archivo SetupData.sql en la carpeta de instalación.");
            //}

            //string script = File.ReadAllText(scriptPath);

            //// Llamamos al método que ahora está en DAL_ConexionDB
            //dalConexion.EjecutarScriptSQL(script, servidorElegido);

            //// Guardamos las configuraciones en AppData
            //string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CuentaClara");
            //Directory.CreateDirectory(appDataFolder);

            //string configPath = Path.Combine(appDataFolder, "servidor_config.txt");
            //File.WriteAllText(configPath, servidorElegido);

            //string banderaPath = Path.Combine(appDataFolder, "bandera.txt");
            //File.WriteAllText(banderaPath, "INSTALADO OK - " + DateTime.Now.ToString());
            // 1. Leemos el script directamente desde los recursos incrustados del proyecto (DAL o BLL, según dónde lo hayas metido)
            var assembly = Assembly.GetExecutingAssembly();

            // Ojo con el nombre exacto de tu namespace y el archivo. 
            // Si tu proyecto BLL se llama BLL, el recurso suele llamarse "BLL.SetupData.sql" (o "IU.SetupData.sql" si está en la UI).
            string resourceName = "BLL.SetupData.sql";

            string script = "";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new Exception("No se encontró el recurso incrustado SetupData.sql dentro del ensamblado.");
                }
                using (StreamReader reader = new StreamReader(stream))
                {
                    script = reader.ReadToEnd();
                }
            }

            // 2. Ejecutamos el script contra el servidor
            dalConexion.EjecutarScriptSQL(script, servidorElegido);

            // 3. Guardamos las configuraciones en AppData (¡Esto ya lo tenías perfecto!)
            string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CuentaClara");
            Directory.CreateDirectory(appDataFolder);

            string configPath = Path.Combine(appDataFolder, "servidor_config.txt");
            File.WriteAllText(configPath, servidorElegido);

            string banderaPath = Path.Combine(appDataFolder, "bandera.txt");
            File.WriteAllText(banderaPath, "INSTALADO OK - " + DateTime.Now.ToString());
        }
    }
}
