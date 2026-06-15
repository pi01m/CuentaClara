using BLL;
using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuentaClara_TrabajoCampo
{
    public partial class frmLogIn : Form
    {
        private readonly BLL_Usuario _bllUsuario;
        private BLL_Idioma bllIdioma;
        public frmLogIn()
        {
            InitializeComponent(); _bllUsuario = new BLL_Usuario();
        }

        private void frmLogIn_Load_1(object sender, EventArgs e)
        {
            bllIdioma = new BLL_Idioma();

            comboBox1.DataSource = bllIdioma.ListarIdiomas();
            comboBox1.DisplayMember = "Nombre";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MostrarError("Debe completar todos los campos.");
                return;
            }

            string nombreUsuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text;

            btnIngresar.Enabled = false;


            try
            {
                bool loginExitoso =_bllUsuario.CargarCredenciales(nombreUsuario, contrasena);

                if (loginExitoso)
                {
                    bllIdioma.CambiarIdioma(comboBox1.Text);
                    ConfigurarMenu();
                    MostrarPantallaPrincipal();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // acá cae "usuario bloqueado"
            }
            finally
            {
                btnIngresar.Enabled = true;
            }
        }

        private void ConfigurarMenu()
        {
            Servicio_Usuario usuarioSesion = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuarioSesion == null) return;

            foreach (Servicio_Rol permiso in usuarioSesion.Permisos.ListaPermisos)
            {

                System.Diagnostics.Debug.WriteLine($"Permiso cargado: {permiso.IdRol} – {permiso.Nombre}");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtContrasena.Text)) return false;
            return true;
        }

      

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void MostrarPantallaPrincipal()
        {
            FormMenu fr = new FormMenu();

            this.Hide();

            fr.ShowDialog();

            this.Show();
        }

    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
