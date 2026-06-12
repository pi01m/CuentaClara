using BLL;
using IU;
using Servicio;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormMenu : Form
    {

        private BLL_Usuario bllUsuario = new BLL_Usuario();
        public FormMenu()
        {
            InitializeComponent();
            if (SessionManager.GetInstancia().GetUsuarioActual().Rol == "Admin")
            {
                btnInicio.Enabled = false;
                btnCategorias.Enabled = false;
                btnGraficos.Enabled = false;
                btnNuevoEgreso.Enabled = false;
                btnNuevoIngreso.Enabled = false;
                btnVencimientos.Enabled = false;
                btnTransacciones.Enabled = false;
                btnSaldos.Enabled = false;

                btnInicio.Visible = false;
                btnCategorias.Visible = false;
                btnGraficos.Visible = false;
                btnNuevoEgreso.Visible = false;
                btnNuevoIngreso.Visible = false;
                btnVencimientos.Visible = false;
                btnTransacciones.Visible = false;
                btnSaldos.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGestionBitacora frm = new FormGestionBitacora();
            this.Hide();
            frm.ShowDialog();
            frm.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            FormGestionPerfiles frm = new FormGestionPerfiles();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCambiarClave frm = new FormCambiarClave();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();

            if (usuarioActual != null && usuarioActual.Rol == "Admin")
            {
                btnInicio.Enabled = false;
                btnCategorias.Enabled = false;
                btnGraficos.Enabled = false;
                btnNuevoEgreso.Enabled = false;
                btnNuevoIngreso.Enabled = false;
                btnVencimientos.Enabled = false;
                btnTransacciones.Enabled = false;
                btnSaldos.Enabled = false;

                btnInicio.Visible = false;
                btnCategorias.Visible = false;
                btnGraficos.Visible = false;
                btnNuevoEgreso.Visible = false;
                btnNuevoIngreso.Visible = false;
                btnVencimientos.Visible = false;
                btnTransacciones.Visible = false;
                btnSaldos.Visible = false;
            }
    }
    }
  }

