using BLL;
using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormCambiarClave : Form, IObserverIdioma
    {
        BLL_Usuario _bllUsuario;
        BLL_BitacoraEvento _bllBitacoraEvento;
        public FormCambiarClave()
        {
            InitializeComponent();
            GestorIdioma.GetInstancia().Suscribir(this);
        }

        private void FormCambiarClave_Load_1(object sender, EventArgs e)
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();


            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);

            lblUsuarioActivo.Text = $"Usuario:";
            lblUsuarioValor.Text = $"{usuarioActual.Login}-{nombreLegibleDelRol}";
            _bllUsuario = new BLL_Usuario();
            _bllBitacoraEvento = new BLL_BitacoraEvento();
            ActualizarIdioma();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtClaveActual.Text) || string.IsNullOrWhiteSpace(txtNuevaClave.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string ClaveVieja = txtClaveActual.Text;
                string ClaveNueva = txtNuevaClave.Text;
                bool resultado = _bllUsuario.CambiarClave(ClaveVieja, ClaveNueva);

                _bllBitacoraEvento.RegistrarBitacora(
                        "Cambio Clave",
                        SessionManager.GetInstancia().GetUsuarioActual().Login,
                        "Administracion",
                        3);

                if (resultado)
                {
                    MessageBox.Show("Contraseña modificada de forma permanente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el cambio de clave. Verifique que su clave actual sea correcta o reintente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCambiarClave_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);

            base.OnFormClosed(e);
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
    }
}
