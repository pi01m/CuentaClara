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
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private BLL_Rol bllRol = new BLL_Rol();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Servicio_Usuario usuario = new Servicio_Usuario();


            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.DNI = txtDNI.Text;
            usuario.email = txtCorreo.Text;
            txtLogin.Text = txtNombre.Text + txtDNI.Text;
            usuario.Login = txtLogin.Text;
            usuario.IdRol = cmbRol.SelectedValue.ToString();
            usuario.Activo = chkActivo.Checked ? 1 : 0;


            BLL_Usuario bll = new BLL_Usuario();


            if (bll.CrearUsuario(usuario))
            {
                MessageBox.Show("Usuario creado correctamente");


                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario ya existe");

            }
        }

        private void FormCrearUsuario_Load_1(object sender, EventArgs e)
        {
            cmbRol.DataSource = null;
            cmbRol.DataSource = bllRol.ObtenerRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "IdRol";
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
