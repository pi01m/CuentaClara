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
    public partial class frmDesbloqueo : Form
    {
        private BLL_Usuario bll = new BLL_Usuario();
        public frmDesbloqueo()
        {
            InitializeComponent(); 
        }

        private void frmDesbloqueo_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataSource = bll.ListarUsuariosBloqueados();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
          
                
            //if (dataGridView1.SelectedRows.Count == 0) throw new Exception("Debe seleccionar un usuario para desbloquear.");

            //string? login = dataGridView1.SelectedRows[0].Cells["Login"].Value.ToString();
            //bool autorizado = bll.ValidarAdministrador(txtContrasena.Text);
       

            //if (!autorizado)
            //{
            //    MessageBox.Show(
            //        "Contraseña de administrador incorrecta.");

            //    return;
            //}

            //bll.DesbloquearUsuario(login);

            //MessageBox.Show( "Usuario desbloqueado correctamente.");
            //txtContrasena.Clear();
            //dataGridView1.DataSource = null;
            //dataGridView1   .DataSource = bll.ListarUsuariosBloqueados();

        }
    }
}
