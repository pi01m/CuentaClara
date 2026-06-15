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
    public partial class FormGestionUsuarios : Form
    {
        private BLL_Usuario bll = new BLL_Usuario();

        public FormGestionUsuarios()
        {
            InitializeComponent();
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ReadOnly = true;

            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            CargarUsuarios();
        }


        private void CargarUsuarios()
        {
            if (radioBtnTodosUser.Checked)
            {
                dgvUsuarios.DataSource = bll.ListarUsuarios();
            }
            else if (radioBtnUserActivos.Checked)
            {
                dgvUsuarios.DataSource = bll.ListarUsuariosActivos();
            }

            dgvUsuarios.Refresh();

        }
        private void FormGestionUsuarios_Load_1(object sender, EventArgs e)
        {
            radioBtnTodosUser.Checked = true;
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();


            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);

            lblUsuarioActivo.Text = $"Usuario: {usuarioActual.Login} - Rol: {nombreLegibleDelRol}";
            CargarUsuarios();

            btnAplicar.Enabled = false;
            btnCancelar.Enabled = false;
            lblTotalUsuarios.Text = dgvUsuarios.Rows.Count.ToString();
            BloquearCampos();

            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Modo Consulta");
        }

        private void HabilitarCamposEdicion()
        {
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtCorreo.ReadOnly = false;
        }
        private void RestaurarModoConsulta()
        {
            BloquearCampos();

            btnAplicar.Enabled = false;
            btnCancelar.Enabled = false;

            btnCrear.Enabled = true;
            btnModificar.Enabled = true;
            btnDesbloquear.Enabled = true;
            btnActivarDesactivar.Enabled = true;

            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Modo Consulta");
        }

        private void BloquearCampos()
        {
            txtDNI.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtCorreo.ReadOnly = true;

            txtLogin.ReadOnly = true;
            chkActivo.Enabled = false;
            txtRol.ReadOnly = true;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearUsuario frm = new FormCrearUsuario();

            frm.ShowDialog(); CargarUsuarios();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            HabilitarCamposEdicion();

            btnAplicar.Enabled = true;
            btnCancelar.Enabled = true;

            btnCrear.Enabled = false;
            btnDesbloquear.Enabled = false;
            btnActivarDesactivar.Enabled = false;

            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Modo Modificar");
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            btnAplicar.Enabled = true;
            btnCancelar.Enabled = true;

            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            btnActivarDesactivar.Enabled = false;

            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Modo Desbloquear");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RestaurarModoConsulta();

            CargarUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;

            txtDNI.Text = dgvUsuarios.CurrentRow.Cells["DNI"].Value.ToString();
            txtApellido.Text = dgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            txtCorreo.Text = dgvUsuarios.CurrentRow.Cells["email"].Value.ToString();
            txtLogin.Text = dgvUsuarios.CurrentRow.Cells["Login"].Value.ToString();
            txtRol.Text = dgvUsuarios.CurrentRow.Cells["IdRol"].Value.ToString();
            chkActivo.Checked = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Activo"].Value) == 1;



        }


        private void btnActivarDesactivar_Click(object sender, EventArgs e)
        {
            chkActivo.Enabled = true;

            btnAplicar.Enabled = true;
            btnCancelar.Enabled = true;

            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            btnDesbloquear.Enabled = false;

            lstMensajes.Items.Clear();
            lstMensajes.Items.Add("Modo Activar / Desactivar");
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string modo = lstMensajes.Items[0].ToString();

            if (modo == "Modo Modificar")
            {
                bool resultado = bll.ModificarUsuario(txtDNI.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text);

                MessageBox.Show(resultado ? "Usuario modificado" : "No se pudo modificar");


            }

            else if (modo == "Modo Desbloquear")
            {
                int intentos = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Bloqueo"].Value);


                if (intentos < 3)
                {
                    MessageBox.Show("El usuario seleccionado no se encuentra bloqueado.");

                    return;
                }

                bll.DesbloquearUsuario(txtLogin.Text);

                MessageBox.Show("Usuario desbloqueado correctamente.");

                CargarUsuarios();

                RestaurarModoConsulta();
            }

            else if (modo == "Modo Activar / Desactivar")
            {
                int activo = chkActivo.Checked ? 1 : 0;

                bll.CambiarEstadoUsuario(txtDNI.Text, activo);

                MessageBox.Show("Estado actualizado correctamente.");

            }

            CargarUsuarios();

            RestaurarModoConsulta();

        }



        private void radioBtnUserActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void radioBtnTodosUser_CheckedChanged(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

