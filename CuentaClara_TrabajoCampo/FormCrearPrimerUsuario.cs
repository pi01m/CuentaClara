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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IU
{
    public partial class FormCrearPrimerUsuario : Form
    {
        public FormCrearPrimerUsuario()
        {
            InitializeComponent();
        }

        private void FormCrearPrimerUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio_Usuario usuario = new Servicio_Usuario();
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.DNI = txtDNI.Text;
                usuario.email = txtCorreo.Text;
                usuario.Login = txtNombre.Text + txtDNI.Text;
                usuario.IdRol = "R1";
                usuario.Activo = 1;
              

                BLL_Usuario bll = new BLL_Usuario();

                if (bll.CrearUsuario(usuario))
                {
                    MessageBox.Show("Usuario Creado Correctamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
          
                MessageBox.Show(ex.Message);
            }
        }
     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
