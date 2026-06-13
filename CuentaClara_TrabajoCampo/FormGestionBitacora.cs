using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormGestionBitacora : Form
    {
        private BLL_BitacoraEvento bll = new BLL_BitacoraEvento();
        private BLL_Usuario bllUsuario = new BLL_Usuario();
        private BLL_PDF bllPdf = new BLL_PDF();
        public FormGestionBitacora()
        {
            InitializeComponent();
        }
        private void CargarLogins()
        {
            cboLogin.DataSource = bllUsuario.ListarLogins();
            cboLogin.DisplayMember = "Login";
            cboLogin.ValueMember = "Login";

            cboLogin.SelectedIndex = -1;
        }
        private void CargarUltimos3Dias()
        {
            dgvBitacora.DataSource = bll.ListarUltimos3Dias();
            lblTotalEventos.Text = dgvBitacora.Rows.Count.ToString();
            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Se cargaron los eventos de los últimos 3 días.");
            if (dgvBitacora.Rows.Count > 0)
                dgvBitacora.Rows[0].Selected = true;
        }



        private void FormGestionBitacora_Load_1(object sender, EventArgs e)
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            lblUsuarioActivo.Text = $"Usuario: {usuarioActual.Login} - Rol: {usuarioActual.IdRol}";
            CargarUltimos3Dias();
            CargarLogins();


        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBitacora_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBitacora.CurrentRow == null) return;

            string login = dgvBitacora.CurrentRow.Cells["Login"].Value.ToString();

            Servicio_Usuario user = bllUsuario.ObtenerUsuarioPorLogin(login);

            if (user != null)
            {
                txtNombre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            dgvBitacora.DataSource = bll.FiltrarBitacora(cboLogin.Text, dtpFechaInicio.Value, dtpFechaFin.Value, cboModulo.Text, cboEvento.Text,

            string.IsNullOrEmpty(cboCriticidad.Text) ? (int?)null : Convert.ToInt32(cboCriticidad.Text)
    );
            lblTotalEventos.Text = dgvBitacora.Rows.Count.ToString();

            lstMensajes.Items.Clear();

            if (dgvBitacora.Rows.Count > 0)
                lstMensajes.Items.Add("Filtro aplicado correctamente. Registros encontrados: " + dgvBitacora.Rows.Count);
            else
                lstMensajes.Items.Add("No se encontraron registros para los filtros seleccionados.");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cboLogin.SelectedIndex = -1;
            cboModulo.SelectedIndex = -1;
            cboEvento.SelectedIndex = -1;
            cboCriticidad.SelectedIndex = -1;

            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;

            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Filtros restablecidos.");

            CargarUltimos3Dias();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "PDF (*.pdf)|*.pdf";
            save.FileName = "Bitacora.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string login =dgvBitacora.CurrentRow.Cells["Login"].Value.ToString();

                DataTable tabla =(DataTable)dgvBitacora.DataSource;

                bllPdf.ExportarBitacora(tabla, save.FileName, login);

                MessageBox.Show("PDF generado correctamente.");
            }
        }

        



    }
}
