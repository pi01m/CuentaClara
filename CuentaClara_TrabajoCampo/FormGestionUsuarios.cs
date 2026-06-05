using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormGestionUsuarios : Form
    {
        private BLL_Usuario bll = new BLL_Usuario();

        public FormGestionUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearUsuario frm = new FormCrearUsuario();

            frm.ShowDialog(); CargarUsuarios();

        }

        private void FormGestionUsuarios_Load_1(object sender, EventArgs e)
        {
            CargarUsuarios();
        }


        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = bll.ListarUsuarios();

            lblTotalUsuarios.Text = dgvUsuarios.Rows.Count.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormModificarUsuario frm = new FormModificarUsuario();

            this.Hide();

            frm.ShowDialog();

            this.Show();
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            frmDesbloqueo frm = new frmDesbloqueo();

            this.Hide();

            frm.ShowDialog();

            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
