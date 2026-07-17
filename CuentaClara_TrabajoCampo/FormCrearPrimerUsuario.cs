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
                MessageBox.Show("Usuario creado correctamente");


                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario ya existe");

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
    }
}
