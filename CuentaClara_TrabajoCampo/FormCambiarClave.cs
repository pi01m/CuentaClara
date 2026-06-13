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
    public partial class FormCambiarClave : Form
    {
        BLL_Usuario _bllUsuario;
        BLL_BitacoraEvento _bllBitacoraEvento;
        public FormCambiarClave()
        {
            InitializeComponent();
        }

        private void FormCambiarClave_Load_1(object sender, EventArgs e)
        {
            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            lblUsuarioActivo.Text = $"Usuario: {usuarioActual.Login} - Rol: {usuarioActual.IdRol}";
            _bllUsuario = new BLL_Usuario();
            _bllBitacoraEvento = new BLL_BitacoraEvento();
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
    }
}
