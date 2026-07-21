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
           
            //if (!BaseDeDatosEstaConfigurada())
            //{
            //    string scriptPath = Path.Combine(Application.StartupPath, "SetupData.sql");

            //    if (File.Exists(scriptPath))
            //    {
            //        try
            //        {
            //            EjecutarScriptSQL(scriptPath);
            //            MessageBox.Show("Base de datos configurada con éxito por primera vez.", "Instalación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("Error al ejecutar el script de BD: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return; // Salimos para no abrir el login sin BD
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se encontró el archivo inicial (SetupData.sql).", "Error de Instalación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return; // Salimos de la aplicación si no hay BD ni script
            //    }
            //}


            ApplicationConfiguration.Initialize();
            string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CuentaClara");

            // 2. Buscamos el archivo bandera o el de configuración en esa subcarpeta
            string rutaBandera = Path.Combine(appDataFolder, "bandera.txt");

            // 3. Si NO existe la bandera en AppData, abrimos el instalador
            if (!File.Exists(rutaBandera))
            {
                FormPrimeraVez frmConfig = new FormPrimeraVez();

                if (frmConfig.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("La configuración inicial es obligatoria para iniciar el sistema.", "Instalación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Si la bandera existe (o el formulario terminó en OK), avanzamos al Login
            Application.Run(new frmLogIn());
        }
        //string rutaBandera = Path.Combine(Application.StartupPath, "bandera.txt");


        //if (!File.Exists(rutaBandera))
        //{
        //    FormPrimeraVez frmConfig = new FormPrimeraVez();


        //    if (frmConfig.ShowDialog() != DialogResult.OK)
        //    {
        //        MessageBox.Show("La configuración inicial es obligatoria para iniciar el sistema.", "Instalación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return; 
        //    }
        //}


        //Application.Run(new frmLogIn());
        }
        //static bool BaseDeDatosEstaConfigurada()
        //{

        //    string masterConnStr = "Data Source=.;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";

        //    // Consulta sencilla a la tabla de sistemas que guarda los nombres de las bases
        //    string consulta = "SELECT name FROM sys.databases WHERE name = 'BD_CuentaClara'";

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(masterConnStr))
        //        {
        //            // ¡Implementación de ADO Desconectado!
        //            SqlDataAdapter da = new SqlDataAdapter(consulta, conn);
        //            DataTable dt = new DataTable();

        //            da.Fill(dt); // Llenamos la tabla en memoria y cerramos la conexión

        //            // Si el DataTable tiene al menos una fila, la base de datos existe
        //            return dt.Rows.Count > 0;
        //        }
        //    }
        //    catch
        //    {
        //        // Si falla (ej. SQL Server apagado), asumimos que no está configurada
        //        return false;
        //    }
        //}

        //static void EjecutarScriptSQL(string path)
        //{
        //    try
        //    {
        //        string script = File.ReadAllText(path);
        //        string masterConnStr = "Data Source=.;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";

        //        using (SqlConnection conn = new SqlConnection(masterConnStr))
        //        {

        //            string[] comandos = script.Split(new[] { "GO\r\n", "GO\n", "GO " }, StringSplitOptions.RemoveEmptyEntries);

        //            conn.Open();

        //            foreach (string comando in comandos)
        //            {
        //                if (!string.IsNullOrWhiteSpace(comando))
        //                {
        //                    using (SqlCommand cmd = new SqlCommand(comando, conn))
        //                    {
        //                        cmd.ExecuteNonQuery(); // Ejecuta las creaciones y los INSERTS
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    catch (SqlException ex) // Capturamos el error específico de SQL
        //    {
        //        // Esto es lo que le salvó la vida a tu amiga: ver el número de error
        //        throw new Exception($"Error de SQL (Código {ex.Number}): {ex.Message}");
        //    }
        //}
    }
