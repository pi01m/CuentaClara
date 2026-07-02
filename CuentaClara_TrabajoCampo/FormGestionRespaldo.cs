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
    public partial class FormGestionRespaldo : Form
    {
        private BLL_Respaldo bllRespaldo = new BLL_Respaldo();
        public FormGestionRespaldo()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de Backup (*.bak)|*.bak";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var confirmacion = MessageBox.Show("¿Seguro? Esto sobreescribirá los datos.", "Atención", MessageBoxButtons.YesNo);
                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        bllRespaldo.HacerRestore(ofd.FileName);
                        MessageBox.Show("Restauración completa. El sistema se cerrará.");
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la restauración: " + ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;

            // Mostramos progreso
            progresoBackup.Style = ProgressBarStyle.Marquee;

            try
            {
                bllRespaldo.HacerBackup(textBox1.Text);
                MessageBox.Show("Backup generado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                progresoBackup.Style = ProgressBarStyle.Blocks;
            }
        }



        private void FormGestionRespaldo_Load(object sender, EventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }

        }
    }
}
