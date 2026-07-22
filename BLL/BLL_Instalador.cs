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
            DataTable table = dalConexion.ObtenerServidoresRed(); 

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

        public void InstalarBaseDeDatos(string servidorElegido, string scriptPath)
        {
        
            bool baseYaExiste = DAL_ConexionDB.VerificarBaseDatosExistente(servidorElegido);

        
            if (!baseYaExiste)
            {
                if (!File.Exists(scriptPath))
                {
                    throw new Exception("No se encontró el archivo SetupData.sql en la carpeta de instalación.");
                }

                string script = File.ReadAllText(scriptPath);
                dalConexion.EjecutarScriptSQL(script, servidorElegido);
            }

            
            string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CuentaClara");
            Directory.CreateDirectory(appDataFolder);

            string configPath = Path.Combine(appDataFolder, "servidor_config.txt");
            File.WriteAllText(configPath, servidorElegido);

            string banderaPath = Path.Combine(appDataFolder, "bandera.txt");
            File.WriteAllText(banderaPath, "INSTALADO OK - " + DateTime.Now.ToString());
        }
    }
}
