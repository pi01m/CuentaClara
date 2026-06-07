using BLL;
using Servicio;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormMenu : Form
    {

        private BLL_Usuario bllUsuario = new BLL_Usuario();
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios frm = new FormGestionUsuarios();

            this.Hide();

            frm.ShowDialog();

            this.Show();
        }

       

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            bllUsuario.CerrarSesion();

            this.Hide();

            frmLogIn login = new frmLogIn();
            login.ShowDialog();

            this.Close();
        }
    }
}
