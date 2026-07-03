using BLL;
using Servicio;
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
    public partial class FormGestionRespaldo : Form, IObserverIdioma
    {
        private BLL_Respaldo bllRespaldo = new BLL_Respaldo();
        public FormGestionRespaldo()
        {
            InitializeComponent();
            GestorIdioma.GetInstancia().Suscribir(this);
        }

        private void btnAplicar_Click(object sender, EventArgs e) //boton de restaurar
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
                        MessageBox.Show(
                        "La base de datos fue restaurada correctamente.\n\nLa aplicación se cerrará para aplicar los cambios.",
                        "Restauración",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

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
            ActualizarIdioma();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }

        }

        private void btn_RecalcularDv_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
        "Se recalcularán todos los Dígitos Verificadores.\n\n¿Desea continuar?",
        "Confirmación",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (r != DialogResult.Yes)
                return;

            try
            {
                bllRespaldo.RecalcularDigitos();

                MessageBox.Show(
                    "Los Dígitos Verificadores fueron recalculados correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);

        }


        private void TraducirControles(Control.ControlCollection controles, Servicio_Idioma idioma)
        {
            foreach (Control c in controles)
            {
                if (c.Tag != null)
                {
                    string clave = c.Tag.ToString();

                    var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
                    if (etiqueta != null) c.Text = etiqueta.Texto;

                }

                if (c is DataGridView dgv)
                {
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        string clave = col.Name;

                        var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

                        if (etiqueta != null) col.HeaderText = etiqueta.Texto;

                    }
                }

                if (c.HasChildren)
                    TraducirControles(c.Controls, idioma);
            }
        }

        private void FormGestionRespaldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}
