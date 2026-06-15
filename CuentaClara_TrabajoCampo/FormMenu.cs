using BLL;
using IU;
using Servicio;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormMenu : Form, IObserverIdioma
    {

        private BLL_Usuario bllUsuario = new BLL_Usuario();
        public FormMenu()
        {
            InitializeComponent();
            GestorIdioma.GetInstancia().Suscribir(this);

            if (SessionManager.GetInstancia().GetUsuarioActual().IdRol == "Admin")
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
            FormGestionPerfil frm = new FormGestionPerfil();
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
        private void Bloquear(Servicio_Usuario usuarioActual)
        {
            if (usuarioActual != null && usuarioActual.IdRol == "Admin")
            {
                btnInicio.Enabled = false;
                btnCategorias.Enabled = false;
                btnGraficos.Enabled = false;
                btnNuevoEgreso.Enabled = false;
                btnNuevoIngreso.Enabled = false;
                btnVencimientos.Enabled = false;
                btnTransacciones.Enabled = false;
                btnSaldos.Enabled = false;

                btnInicio.Visible = true;
                btnCategorias.Visible = true;
                btnGraficos.Visible = true;
                btnNuevoEgreso.Visible = true;
                btnNuevoIngreso.Visible = true;
                btnVencimientos.Visible = true;
                btnTransacciones.Visible = true;
                btnSaldos.Visible = true;
            }
            else if (usuarioActual.IdRol != "Admin")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;

                button3.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }

        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();

            
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);
           
            lblUsuario.Text = $"Usuario: {usuarioActual.Login} - Rol: {nombreLegibleDelRol}";

            Bloquear(usuarioActual);
        }

       
    }
}

