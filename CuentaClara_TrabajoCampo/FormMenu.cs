using BLL;
using IU;
using Servicio;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormMenu : Form, IObserverIdioma
    {

        private BLL_Usuario bllUsuario = new BLL_Usuario();
        private BLL_Rol bllRol = new BLL_Rol();
        public FormMenu()
        {
            InitializeComponent();
            GestorIdioma.GetInstancia().Suscribir(this);
            ;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            FormGestionBitacora frm = new FormGestionBitacora();
            this.Hide();
            frm.ShowDialog();
            this.Show();
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
            if (usuarioActual == null) return;

            button1.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "P1");
            button2.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "P2");
            button3.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "P3");

            btnInicio.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_INICIO");
            btnCategorias.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_CATEGORIAS");
            btnGraficos.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_GRAFICOS");
            btnNuevoEgreso.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_EGRESOS");
            btnNuevoIngreso.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_INGRESOS");
            btnVencimientos.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_VENCIMIENTOS");
            btnTransacciones.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_TRANSACCIONES");
            btnSaldos.Enabled = bllRol.RolTienePermisoRecursivo(usuarioActual.IdRol, "PERMISO_SALDOS");


        }

        public void ActualizarIdioma()
        {
            AplicarIdioma();

        }

        private void AplicarIdioma()
        {
            var idioma = SessionManager.GetInstancia().GetIdiomaActual();
            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);

        }

        private void TraducirControles(Control.ControlCollection controles, Servicio_Idioma idioma)
        {
            foreach (Control c in controles)
            {
                if (c.Tag != null)
                {
                    string clave = c.Tag.ToString();

                    var etiqueta = idioma.Etiquetas
                        .FirstOrDefault(x => x.Clave == clave);

                    if (etiqueta != null)
                        c.Text = etiqueta.Texto;
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

            lblUsuario.Text = $"Usuario: {usuarioActual.Login} - Rol: {nombreLegibleDelRol}";

            Bloquear(usuarioActual);
        }

        private void FormMenu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (SessionManager.GetInstancia().GetUsuarioActual() != null)
            {
                bllUsuario.CerrarSesion();
            }
        }
    }
}

