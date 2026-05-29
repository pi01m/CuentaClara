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
        public frmLogIn()
        {
            InitializeComponent(); _bllUsuario = new BLL_Usuario();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLogIn_Load_1(object sender, EventArgs e)
        {

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
                
                bool loginExitoso = _bllUsuario.CargarCredenciales(nombreUsuario, contrasena);

                if (loginExitoso)
                {
                    ConfigurarMenu();
                    MostrarPantallaPrincipal();
                }
                else
                {
                    MensajeErrorAutenticacion();
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error inesperado: " + ex.Message);
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

            foreach (Servicio_Permiso permiso in usuarioSesion.Permisos.ListaPermisos)
            {
               
                System.Diagnostics.Debug.WriteLine($"Permiso cargado: {permiso.IdPermiso} – {permiso.Nombre}");
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtContrasena.Text)) return false;
            return true;
        }

        private void MensajeErrorAutenticacion()
        {
            MostrarError("Usuario o contraseña incorrectos. Verifique sus credenciales.");
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        
        

        private void MostrarPantallaPrincipal()
        {
            FormMenu fr = new FormMenu();
            fr.ShowDialog();
            this.Close();
        }
    }
}
