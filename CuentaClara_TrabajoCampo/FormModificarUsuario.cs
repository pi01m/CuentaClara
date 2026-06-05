using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormModificarUsuario : Form
    {
        private BLL_Usuario bllUsuario;
        public FormModificarUsuario()
        {
            InitializeComponent();
            bllUsuario = new BLL_Usuario();
            dgvUsuarios.MultiSelect= false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario");

                return;
            }

            string? dni = dgvUsuarios.SelectedRows[0].Cells["DNI"].Value.ToString();

            bool resultado = bllUsuario.ModificarUsuario(dni, txtNombre.Text, txtApellido.Text);

            if (resultado)
            {
                MessageBox.Show("Usuario modificado correctamente");

                dgvUsuarios.DataSource = bllUsuario.ListarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario");
            }
        }

        
        

        private void CargarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = bllUsuario.ListarUsuarios();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormModificarUsuario_Load_1(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        //cada vez q cambiamos la seleccion en el datagridview, se actualizan los
        //campos de texto con los datos del usuario seleccionado
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            }
        }
    }
}
