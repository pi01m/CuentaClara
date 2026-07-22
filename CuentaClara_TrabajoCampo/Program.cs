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
            BLL.BLL_Instalador gestorInstalacion = new BLL.BLL_Instalador();

      
            if (gestorInstalacion.EsNecesarioInstalar())
            {
                FormPrimeraVez frmConfig = new FormPrimeraVez();

                if (frmConfig.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("La configuración inicial es obligatoria para iniciar el sistema.", "Instalación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            Application.Run(new frmLogIn());
        }
       
        }
       
    }
