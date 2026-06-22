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

        public void ActualizarIdioma()
        {
            string idIdioma =
            SessionManager.GetInstancia()
            .GetUsuarioActual()
            .Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);

        }


        private void TraducirControles(Control.ControlCollection controles, Servicio_Idioma idioma)
        {
            foreach (Control c in controles)
            {
                if (c.Tag != null)
                {
                    string clave = c.Tag.ToString();

                    var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
                    if (etiqueta != null) c.Text = etiqueta.Texto;

                }

                if (c is DataGridView dgv)
                {
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        string clave = col.Name;

                        var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

                        if (etiqueta != null) col.HeaderText = etiqueta.Texto;

                    }
                }

                if (c.HasChildren)
                    TraducirControles(c.Controls, idioma);
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();


            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);

            lblUsuario.Text = $"Usuario:";
            lblUsuarioValor.Text = $"{usuarioActual.Login}-{nombreLegibleDelRol}";

            Bloquear(usuarioActual);
            ActualizarIdioma();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);

            base.OnFormClosed(e);
        }
    }
}

