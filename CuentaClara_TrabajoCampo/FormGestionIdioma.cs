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
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace IU
{
    public partial class FormGestionIdioma : Form
    {
        private string accion = ""; //nos ayuda a saber en que accion estamos 
        BLL_Idioma bllIdioma;


        public FormGestionIdioma()
        {
            InitializeComponent();
        }

        private void FormGestionIdioma_Load(object sender, EventArgs e)
        {
            bllIdioma = new BLL_Idioma();
            CargarIdiomas();
        }


        #region nuevo idioma
        private void btnNuevoIdioma_Click(object sender, EventArgs e)
        {
            accion = "CREAR_IDIOMA";
            txtClave.Enabled = false;
            listBox1.Items.Clear();

            listBox1.Items.Add("Modo actual: CREAR IDIOMA");
            listBox1.Items.Add("Ingrese el nombre del idioma en el campo Texto.");
            listBox1.Items.Add("Presione Aplicar para confirmar.");

            txtClave.Clear();
            txtTexto.Clear();

            txtClave.Enabled = false;
            txtTexto.Enabled = true;

            txtTexto.Focus();
        }

        private void CrearIdioma()
        {
            try
            {
                if (txtTexto.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre para el idioma");

                    return;
                }

                Servicio_Idioma idioma = new Servicio_Idioma();


                idioma.Nombre = txtTexto.Text;

                bool resultado = bllIdioma.CrearIdioma(idioma);


                if (resultado)
                {
                    MessageBox.Show("Idioma creado correctamente");

                    CargarIdiomas();

                    txtTexto.Clear();

                    listBox1.Items.Clear();

                    accion = "";
                }
                else
                {
                    MessageBox.Show("El idioma ya existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el idioma: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (accion == "CREAR_IDIOMA")
            {
                CrearIdioma();
            }
            if (accion == "CREAR_ETIQUETA")
            {
                CrearEtiqueta();
            }
            if (accion == "MODIFICAR_ETIQUETA")
            {
                ModificarEtiqueta();
            }
        }

        private void ModificarEtiqueta()
        {
            try
            {
                if (cboIdiomas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un idioma");
                    return;
                }

                if (txtTexto.Text == "")
                {
                    MessageBox.Show("Ingrese un texto");
                    return;
                }

                bool resultado =
                    bllIdioma.ModificarEtiqueta(
                        cboIdiomas.Text,
                        txtClave.Text,
                        txtTexto.Text);

                if (resultado)
                {
                    MessageBox.Show("Etiqueta modificada correctamente");

                    cboIdiomas_SelectedIndexChanged(null, null);

                    txtClave.Clear();
                    txtTexto.Clear();

                    accion = "";

                    listBox1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la etiqueta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrearEtiqueta()
        {
            try
            {
                if (cboIdiomas.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un idioma");

                    return;
                }

                if (txtClave.Text == "")
                {
                    MessageBox.Show("Ingrese una clave");

                    return;
                }

                if (txtTexto.Text == "")
                {
                    MessageBox.Show("Ingrese un texto");

                    return;
                }

                bool resultado =
                    bllIdioma.AgregarEtiqueta(
                        cboIdiomas.Text,
                        txtClave.Text,
                        txtTexto.Text);

                if (resultado)
                {
                    MessageBox.Show("Etiqueta agregada correctamente");

                    cboIdiomas_SelectedIndexChanged(null, null);

                    txtClave.Clear();
                    txtTexto.Clear();

                    accion = "";

                    listBox1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("La clave ya existe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarIdiomas()
        {
            cboIdiomas.DataSource = null;

            cboIdiomas.DataSource = bllIdioma.ListarIdiomas();

            cboIdiomas.DisplayMember = "Nombre";
        }

        private void cboIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIdiomas.SelectedItem == null)
                return;

            Servicio_Idioma idioma = bllIdioma.ObtenerIdioma(cboIdiomas.Text);



            dgvEtiquetas.DataSource = null;
            dgvEtiquetas.DataSource =
                idioma.Etiquetas;
        }

        private void btnAgregarEtiqueta_Click(object sender, EventArgs e)
        {
            accion = "CREAR_ETIQUETA";

            listBox1.Items.Clear();

            listBox1.Items.Add("Modo actual: CREAR ETIQUETA");
            listBox1.Items.Add("Ingrese la Clave.");
            listBox1.Items.Add("Ingrese el Texto.");
            listBox1.Items.Add("Presione Aplicar para confirmar.");

            txtClave.Enabled = true;
            txtTexto.Enabled = true;

            txtClave.Clear();
            txtTexto.Clear();

            txtClave.Focus();
        }

        private void btnModificarEtiqueta_Click(object sender, EventArgs e)
        {
            if (dgvEtiquetas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una etiqueta");
                return;
            }

            accion = "MODIFICAR_ETIQUETA";

            txtClave.Text =
                dgvEtiquetas.CurrentRow.Cells["Clave"].Value.ToString();

            txtTexto.Text =
                dgvEtiquetas.CurrentRow.Cells["Texto"].Value.ToString();

            txtClave.Enabled = false;
            txtTexto.Enabled = true;

            listBox1.Items.Clear();

            listBox1.Items.Add("Modo actual: MODIFICAR ETIQUETA");
            listBox1.Items.Add("Modifique el texto.");
            listBox1.Items.Add("La clave no puede cambiarse.");
            listBox1.Items.Add("Presione Aplicar para confirmar.");

            txtTexto.Focus();
        }
    }
}
