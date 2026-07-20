using IU;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CuentaClara_TrabajoCampo
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            string carpetaPermitida = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configPath = Path.Combine(carpetaPermitida, "CuentaClara_conexion.txt");

            if (File.Exists(configPath))
            {
                Application.Run(new frmLogIn());
            }
            else
            {
                frmConfiguracionInicial frmSetup = new frmConfiguracionInicial();

                if (frmSetup.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmLogIn());
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }
    
        }
    }
