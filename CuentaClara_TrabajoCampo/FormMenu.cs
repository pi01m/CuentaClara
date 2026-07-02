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

        private void DeshabilitarTodosLosBotones()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            btnInicio.Enabled = false;
            btnCategorias.Enabled = false;
            btnGraficos.Enabled = false;
            btnNuevoEgreso.Enabled = false;
            btnNuevoIngreso.Enabled = false;
            btnVencimientos.Enabled = false;
            btnTransacciones.Enabled = false;
            btnSaldos.Enabled = false;
        }

        private bool ValidarPermisoEnArbol(Servicio_Rol componente, string idPermisoBuscado)
        {
            if (componente == null) return false;


            if (componente.IdRol == idPermisoBuscado)
                return true;


            if (componente is Servicio_Familia familia)
            {
                foreach (Servicio_Rol hijo in familia.ObtenerHijos())
                {

                    if (ValidarPermisoEnArbol(hijo, idPermisoBuscado))
                    {
                        return true;
                    }
                }
            }


            return false;
        }
        private void Bloquear(Servicio_Usuario usuarioActual)
        {
            if (usuarioActual == null || usuarioActual.Permisos == null)
            {
                DeshabilitarTodosLosBotones();
                return;
            }


            ////button1.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P1");
            ////button2.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P2");
            ////button3.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P3");

            ////btnInicio.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_INICIO");
            ////btnCategorias.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_CATEGORIAS");
            ////btnGraficos.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_GRAFICOS");
            ////btnNuevoEgreso.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_EGRESOS");
            ////btnNuevoIngreso.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_INGRESOS");
            ////btnVencimientos.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_VENCIMIENTOS");
            ////btnTransacciones.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_TRANSACCIONES");
            ////btnSaldos.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "PERMISO_SALDOS");

        }

        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;

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


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGestionIdioma frm = new FormGestionIdioma();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lblBD_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//cambiar idioma
        {
            FormConfiguracion frm = new FormConfiguracion();
            frm.ShowDialog();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {

        }

        private void panelUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

