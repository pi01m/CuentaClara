using BLL;
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
    public partial class frmConfiguracionInicial : Form
    {
        public frmConfiguracionInicial()
        {
            InitializeComponent();
        }


        private void frmConfiguracionInicial_Load(object sender, EventArgs e)
        {

        }

        private async void btnInstalar_Click_1(object sender, EventArgs e)
        {

            string servidor = txtServidor.Text.Trim();

            if (string.IsNullOrEmpty(servidor))
            {
                MessageBox.Show("Por favor, ingresa el nombre del servidor SQL.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string scriptPath = Path.Combine(Application.StartupPath, "SetupData.sql");
            string carpetaPermitida = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string configPath = Path.Combine(carpetaPermitida, "CuentaClara_conexion.txt");

            try
            {
                btnInstalar.Enabled = false;

                await Task.Run(() => BLL.BLL_Instalador.ConfigurarEntorno(servidor, scriptPath));
                File.WriteAllText(configPath, servidor);

                MessageBox.Show("Base de datos creada y configurada con éxito.", "Instalación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                btnInstalar.Enabled = true;
                MessageBox.Show(ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
