using BLL;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU
{
    public partial class FormPrimeraVez : Form
    {
        private BLL_Instalador bllInstalador = new BLL_Instalador();
        public FormPrimeraVez()
        {
            InitializeComponent();
        }

        private void FormPrimeraVez_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //listaServidores.Items.Clear();

            //try
            //{

            //    SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //    DataTable table = instance.GetDataSources();

            //    foreach (DataRow row in table.Rows)
            //    {
            //        string serverName = row["ServerName"].ToString();
            //        string instanceName = row["InstanceName"].ToString();

            //        if (string.IsNullOrEmpty(instanceName))listaServidores.Items.Add(serverName);

            //        else listaServidores.Items.Add($"{serverName}\\{instanceName}");

            //    }


            //    if (listaServidores.Items.Count == 0)
            //    {
            //        listaServidores.Items.Add(".");
            //        listaServidores.Items.Add(".\\SQLEXPRESS");
            //        MessageBox.Show("No se detectaron servidores automáticamente en la red. Se agregaron las opciones locales por defecto ( . y .\\SQLEXPRESS ). También puedes escribir el nombre manualmente en la lista si lo deseas.", "Búsqueda finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al buscar servidores: " + ex.Message);
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}
            this.Cursor = Cursors.WaitCursor;
            listaServidores.Items.Clear();

            try
            {
                List<string> servidores = bllInstalador.ObtenerListaServidores();

                foreach (string srv in servidores)
                {
                    listaServidores.Items.Add(srv);
                }

                if (servidores.Count == 2 && servidores.Contains("."))
                {
                    MessageBox.Show("No se detectaron servidores automáticamente en la red. Se agregaron las opciones locales por defecto ( . y .\\SQLEXPRESS ). También puedes escribir el nombre manualmente en la lista si lo deseas.", "Búsqueda finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar servidores: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (listaServidores.SelectedItem == null && string.IsNullOrWhiteSpace(listaServidores.Text))
            //{
            //    MessageBox.Show("Por favor, selecciona o escribe el nombre de un servidor SQL.");
            //    return;
            //}

            //string servidorElegido = listaServidores.SelectedItem != null ? listaServidores.SelectedItem.ToString() : listaServidores.Text.Trim();

            //string scriptPath = Path.Combine(Application.StartupPath, "SetupData.sql");

            //if (!File.Exists(scriptPath))
            //{
            //    MessageBox.Show("No se encontró el archivo SetupData.sql en la carpeta de instalación.");
            //    return;
            //}

            //this.Cursor = Cursors.WaitCursor;
            //btnGuardar.Enabled = false;

            //try
            //{

            //    string masterConnStr = $"Data Source={servidorElegido};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";
            //    EjecutarScriptSQL(scriptPath, masterConnStr);

            //    // 2. Definimos una carpeta segura en AppData para guardar las configuraciones de la app sin problemas de permisos
            //    string appDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CuentaClara");
            //    Directory.CreateDirectory(appDataFolder); // Si no existe, la crea automáticamente

            //    // 3. Guardamos el servidor elegido
            //    string configPath = Path.Combine(appDataFolder, "servidor_config.txt");
            //    File.WriteAllText(configPath, servidorElegido);

            //    // 4. ¡CREAMOS LA BANDERA! En la misma ruta segura de AppData
            //    string banderaPath = Path.Combine(appDataFolder, "bandera.txt");
            //    File.WriteAllText(banderaPath, "INSTALADO OK - " + DateTime.Now.ToString());
            //    MessageBox.Show("¡Base de datos instalada y configurada con éxito!", "Configuración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    // Cerramos el formulario indicando que todo salió bien
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al configurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    btnGuardar.Enabled = true;
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}

            //Nuevo1
            //if (listaServidores.SelectedItem == null && string.IsNullOrWhiteSpace(listaServidores.Text))
            //{
            //    MessageBox.Show("Por favor, selecciona o escribe el nombre de un servidor SQL.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //string servidorElegido = listaServidores.SelectedItem != null ? listaServidores.SelectedItem.ToString() : listaServidores.Text.Trim();
            //string scriptPath = Path.Combine(Application.StartupPath, "SetupData.sql");

            //this.Cursor = Cursors.WaitCursor;
            //btnGuardar.Enabled = false;

            //try
            //{
            //    bllInstalador.InstalarBaseDeDatos(servidorElegido, scriptPath);

            //    MessageBox.Show("¡Base de datos instalada y configurada con éxito!", "Configuración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al configurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    btnGuardar.Enabled = true;
            //}
            //finally
            //{
            //    this.Cursor = Cursors.Default;
            //}

            //nuevo 2
            if (listaServidores.SelectedItem == null && string.IsNullOrWhiteSpace(listaServidores.Text))
            {
                MessageBox.Show("Por favor, selecciona o escribe el nombre de un servidor SQL.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string servidorElegido = listaServidores.SelectedItem != null ? listaServidores.SelectedItem.ToString() : listaServidores.Text.Trim();

            this.Cursor = Cursors.WaitCursor;
            btnGuardar.Enabled = false;

            try
            {
                // Ya no necesitamos pasarle ninguna ruta física
                bllInstalador.InstalarBaseDeDatos(servidorElegido);

                MessageBox.Show("¡Base de datos instalada y configurada con éxito!", "Configuración Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = true;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        //private void EjecutarScriptSQL(string path, string connString)
        //{
        //    string script = File.ReadAllText(path);
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        string[] comandos = script.Split(new[] { "GO\r\n", "GO\n", "GO " }, StringSplitOptions.RemoveEmptyEntries);
        //        conn.Open();

        //        foreach (string comando in comandos)
        //        {
        //            if (!string.IsNullOrWhiteSpace(comando))
        //            {
        //                using (SqlCommand cmd = new SqlCommand(comando, conn))
        //                {
        //                    cmd.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
