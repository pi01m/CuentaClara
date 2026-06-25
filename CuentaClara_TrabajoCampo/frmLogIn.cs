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
    public partial class frmLogIn : Form, IObserverIdioma
    {
        private readonly BLL_Usuario _bllUsuario;
        private BLL_Idioma bllIdioma;
        public frmLogIn()
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            InitializeComponent();
            _bllUsuario = new BLL_Usuario();
        }

        private void frmLogIn_Load_1(object sender, EventArgs e)
        {
            bllIdioma = new BLL_Idioma();

            comboBox1.DataSource = bllIdioma.ListarIdiomasBD();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id_Idioma";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                //MostrarError("Debe completar todos los campos.");
                MostrarError(TraducirTexto("msg_DebeCompletarCampos"));
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
                    string idIdioma = comboBox1.SelectedValue.ToString();

                    SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma = idIdioma;

                    ConfigurarMenu();
                    MostrarPantallaPrincipal();
                    this.Close();
                }
                else
                {
                    //MessageBox.Show("Usuario o contraseña incorrectos.");
                    MessageBox.Show(TraducirTexto("msg_UsuarioContrasenaIncorrectos"));
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

        public void ActualizarIdioma()
        {
            string idIdioma = comboBox1.SelectedValue.ToString();

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma =
                bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);
        }
        private string TraducirTexto(string clave)
        {
            string idIdioma = comboBox1.SelectedValue.ToString();

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

            return etiqueta != null ? etiqueta.Texto : clave;
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }

        private void frmLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void frmLogIn_Resize(object sender, EventArgs e)
        {
            if (panelLogin != null)
            {
                
                panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
                panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
            }
        }
    }
}
