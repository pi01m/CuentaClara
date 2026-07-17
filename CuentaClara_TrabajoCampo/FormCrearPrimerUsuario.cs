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
            ActualizarIdioma();
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
                usuario.Id_Idioma = "1";
                BLL_Usuario bll = new BLL_Usuario();

                if (bll.CrearUsuario(usuario))
                {
                    MessageBox.Show(TraducirTexto("msg_UsuarioCreadoCorrectamente"));

                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        public void ActualizarIdioma()
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();

            // 2. Si es null (como ocurre al crear el primer usuario), salimos del método para que no explote
            if (usuarioActual == null)
            {
                return;
            }

            // 3. Si hay usuario, sigue tu lógica normal
            string idIdioma = usuarioActual.Id_Idioma;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string TraducirTexto(string clave)
        {
            var session = SessionManager.GetInstancia();
            var usuarioActual = session.GetUsuarioActual();

          
            if (usuarioActual == null)
            {
                return clave; // O retorna un texto genérico si prefieres
            }

            // 3. Si hay usuario, procedemos normalmente
            string idIdioma = usuarioActual.Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

            return etiqueta != null ? etiqueta.Texto : clave;
        }
    }
}
