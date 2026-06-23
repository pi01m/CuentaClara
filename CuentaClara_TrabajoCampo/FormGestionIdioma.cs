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
    public partial class FormGestionIdioma : Form, IObserverIdioma
    {
        private string accion = ""; //nos ayuda a saber en que accion estamos 
        BLL_Idioma bllIdioma;


        public FormGestionIdioma()
        {
            InitializeComponent();
            GestorIdioma.GetInstancia().Suscribir(this);
        }

        private void FormGestionIdioma_Load(object sender, EventArgs e)
        {
            bllIdioma = new BLL_Idioma();
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();


            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);

            lblUsuario.Text = $"Usuario:";
            lblUsuarioValor.Text = $"{usuarioActual.Login}-{nombreLegibleDelRol}";
            ActualizarIdioma();
            CargarIdiomas();
        }


        #region nuevo idioma
        private void btnNuevoIdioma_Click(object sender, EventArgs e)
        {
            accion = "CREAR_IDIOMA";
            txtClave.Enabled = false;
            listBox1.Items.Clear();

            //listBox1.Items.Add("Modo actual: CREAR IDIOMA");
            //listBox1.Items.Add("Ingrese el nombre del idioma en el campo Texto.");
            //listBox1.Items.Add("Presione Aplicar para confirmar.");

            listBox1.Items.Add(TraducirTexto("ModoCrearIdioma"));
            listBox1.Items.Add(TraducirTexto("IngreseNombreIdioma"));
            listBox1.Items.Add(TraducirTexto("PresioneAplicarConfirmar"));

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
                    //MessageBox.Show("Ingrese un nombre para el idioma");
                    MessageBox.Show(TraducirTexto("IngreseNombreParaIdioma"));
                    return;
                }

                Servicio_Idioma idioma = new Servicio_Idioma();


                idioma.Nombre = txtTexto.Text;

                bool resultado = bllIdioma.CrearIdioma(idioma);


                if (resultado)
                {
                    MessageBox.Show(TraducirTexto("IdiomaCreadoCorrectamente"));

                    CargarIdiomas();

                    txtTexto.Clear();

                    listBox1.Items.Clear();

                    accion = "";
                }
                else
                {
                    MessageBox.Show(TraducirTexto("IdiomaYaExiste"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto("ErrorCrearIdioma") + ": " + ex.Message, TraducirTexto("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    //MessageBox.Show("Seleccione un idioma");
                    MessageBox.Show(TraducirTexto("SeleccioneIdioma"));
                    return;
                }

                if (txtTexto.Text == "")
                {
                    //MessageBox.Show("Ingrese un texto");
                    MessageBox.Show(TraducirTexto("IngreseTexto"));
                    return;
                }

                bool resultado =
                    bllIdioma.ModificarEtiqueta(
                        cboIdiomas.Text,
                        txtClave.Text,
                        txtTexto.Text);

                if (resultado)
                {
                    //MessageBox.Show("Etiqueta modificada correctamente");
                    MessageBox.Show(TraducirTexto("EtiquetaModificadaCorrectamente"));
                    cboIdiomas_SelectedIndexChanged(null, null);

                    txtClave.Clear();
                    txtTexto.Clear();

                    accion = "";

                    listBox1.Items.Clear();
                }
                else
                {
                    // MessageBox.Show("No se pudo modificar la etiqueta");
                    MessageBox.Show(TraducirTexto("NoSePudoModificarEtiqueta"));
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
                    //MessageBox.Show("Seleccione un idioma");
                    MessageBox.Show(TraducirTexto("SeleccioneIdioma"));
                    return;
                }

                if (txtClave.Text == "")
                {
                    //MessageBox.Show("Ingrese una clave");
                    MessageBox.Show(TraducirTexto("IngreseClave"));
                    return;
                }

                if (txtTexto.Text == "")
                {
                    //MessageBox.Show("Ingrese un texto");
                    MessageBox.Show(TraducirTexto("IngreseTexto"));
                    return;
                }

                bool resultado =
                    bllIdioma.AgregarEtiqueta(
                        cboIdiomas.Text,
                        txtClave.Text,
                        txtTexto.Text);

                if (resultado)
                {
                    //MessageBox.Show("Etiqueta agregada correctamente");
                    MessageBox.Show(TraducirTexto("EtiquetaAgregadaCorrectamente"));
                    cboIdiomas_SelectedIndexChanged(null, null);

                    txtClave.Clear();
                    txtTexto.Clear();

                    accion = "";

                    listBox1.Items.Clear();
                }
                else
                {
                    //MessageBox.Show("La clave ya existe");
                    MessageBox.Show(TraducirTexto("ClaveYaExiste"));
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
            dgvEtiquetas.DataSource = idioma.Etiquetas;

            dgvEtiquetas.Columns["Clave"].HeaderText = TraducirTexto("Clave");
            dgvEtiquetas.Columns["Texto"].HeaderText = TraducirTexto("Texto");
        }

        private void btnAgregarEtiqueta_Click(object sender, EventArgs e)
        {
            accion = "CREAR_ETIQUETA";

            listBox1.Items.Clear();

            //listBox1.Items.Add("Modo actual: CREAR ETIQUETA");
            //listBox1.Items.Add("Ingrese la Clave.");
            //listBox1.Items.Add("Ingrese el Texto.");
            //listBox1.Items.Add("Presione Aplicar para confirmar.");

            listBox1.Items.Add(TraducirTexto("ModoCrearEtiqueta"));
            listBox1.Items.Add(TraducirTexto("IngreseLaClave"));
            listBox1.Items.Add(TraducirTexto("IngreseElTexto"));
            listBox1.Items.Add(TraducirTexto("PresioneAplicarConfirmar"));


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
                // MessageBox.Show("Seleccione una etiqueta");
                MessageBox.Show(TraducirTexto("SeleccioneEtiqueta"));
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

            //listBox1.Items.Add("Modo actual: MODIFICAR ETIQUETA");
            //listBox1.Items.Add("Modifique el texto.");
            //listBox1.Items.Add("La clave no puede cambiarse.");
            //listBox1.Items.Add("Presione Aplicar para confirmar.");

            listBox1.Items.Add(TraducirTexto("ModoModificarEtiqueta"));
            listBox1.Items.Add(TraducirTexto("ModifiqueTexto"));
            listBox1.Items.Add(TraducirTexto("ClaveNoPuedeCambiarse"));
            listBox1.Items.Add(TraducirTexto("PresioneAplicarConfirmar"));


            txtTexto.Focus();
        }

        private void FormGestionIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);

        }

        public void ActualizarIdioma()
        {
            string idIdioma =
           SessionManager.GetInstancia()
           .GetUsuarioActual()
           .Id_Idioma;

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

        private string TraducirTexto(string clave)
        {
            string idIdioma =
                SessionManager.GetInstancia()
                .GetUsuarioActual()
                .Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

            return etiqueta != null ? etiqueta.Texto : clave;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
