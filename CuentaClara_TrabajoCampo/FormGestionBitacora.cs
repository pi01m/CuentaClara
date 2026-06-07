using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace CuentaClara_TrabajoCampo
{
    public partial class FormGestionBitacora : Form
    {
        private BLL_BitacoraEvento bll = new BLL_BitacoraEvento();
        private BLL_Usuario bllUsuario = new BLL_Usuario();
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

            if (dgvBitacora.Rows.Count > 0)
                dgvBitacora.Rows[0].Selected = true;
        }



        private void FormGestionBitacora_Load_1(object sender, EventArgs e)
        {
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
            string criticidad = dgvBitacora.CurrentRow.Cells["Criticidad"].Value.ToString();
            cboLogin.Text = login;
            cboCriticidad.Text = criticidad;
            cboEvento.Text = dgvBitacora.CurrentRow.Cells["Evento"].Value.ToString();
            cboModulo.Text = dgvBitacora.CurrentRow.Cells["Modulo"].Value.ToString();

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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargarUltimos3Dias();
            
        }
    }
}
