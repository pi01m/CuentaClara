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
        private BLL_Usuario bll =new BLL_Usuario();
     
        public FormGestionUsuarios()
        {
            InitializeComponent();
        }

        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearUsuario frm = new FormCrearUsuario();

            frm.ShowDialog(); CargarUsuarios();
           
        }

        private void FormGestionUsuarios_Load_1(object sender, EventArgs e)
        {
            
        }


        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = bll.ListarUsuarios();

            lblTotalUsuarios.Text =dgvUsuarios.Rows.Count.ToString();
                
        }
    }
}
