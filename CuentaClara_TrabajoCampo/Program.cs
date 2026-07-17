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
            if (!BaseDeDatosEstaConfigurada())
            {
                string scriptPath = Path.Combine(Application.StartupPath, "SetupData.sql");

                if (File.Exists(scriptPath))
                {
                    try
                    {
                        EjecutarScriptSQL(scriptPath);
                        MessageBox.Show("Base de datos configurada con éxito por primera vez.", "Instalación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar el script de BD: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Salimos para no abrir el login sin BD
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo inicial (SetupData.sql).", "Error de Instalación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salimos de la aplicación si no hay BD ni script
                }
            }
            Application.Run(new frmLogIn());
        }
        static bool BaseDeDatosEstaConfigurada()
        {

            string masterConnStr = "Data Source=.;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";

            // Consulta sencilla a la tabla de sistemas que guarda los nombres de las bases
            string consulta = "SELECT name FROM sys.databases WHERE name = 'BD_CuentaClara'";

            try
            {
                using (SqlConnection conn = new SqlConnection(masterConnStr))
                {
                    // ¡Implementación de ADO Desconectado!
                    SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();

                    da.Fill(dt); // Llenamos la tabla en memoria y cerramos la conexión

                    // Si el DataTable tiene al menos una fila, la base de datos existe
                    return dt.Rows.Count > 0;
                }
            }
            catch
            {
                // Si falla (ej. SQL Server apagado), asumimos que no está configurada
                return false;
            }
        }

        static void EjecutarScriptSQL(string path)
        {
            string script = File.ReadAllText(path);
            string masterConnStr = "Data Source=.;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                
                string[] comandos = script.Split(new[] { "GO\r\n", "GO\n", "GO " }, StringSplitOptions.RemoveEmptyEntries);

                conn.Open();

                foreach (string comando in comandos)
                {
                    if (!string.IsNullOrWhiteSpace(comando))
                    {
                        using (SqlCommand cmd = new SqlCommand(comando, conn))
                        {
                            cmd.ExecuteNonQuery(); // Ejecuta las creaciones y los INSERTS
                        }
                    }
                }
            }
        }
    }
}