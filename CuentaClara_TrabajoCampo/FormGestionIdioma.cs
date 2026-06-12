using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace IU
{
    public partial class FormGestionIdioma : Form
    {
        private string accion = ""; //nos ayuda a saber en que accion estamos 
        public FormGestionIdioma()
        {
            InitializeComponent();
        }

        private void FormGestionIdioma_Load(object sender, EventArgs e)
        {

        }


        #region nuevo idioma
        private void btnNuevoIdioma_Click(object sender, EventArgs e)
        {
            accion = "CREAR_IDIOMA";

            listBox1.Items.Clear();

            listBox1.Items.Add("Modo actual: CREAR IDIOMA");
            listBox1.Items.Add("Ingrese el nombre del idioma en el campo Texto.");
            listBox1.Items.Add("Presione Aplicar para confirmar.");

            txtClave.Clear();
            txtTexto.Clear();

            txtClave.Enabled = false;
            txtTexto.Enabled = true;

            txtTexto.Focus();
        }

        private void CrearIdioma()
        {
            throw new NotImplementedException();
        }


        #endregion
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(accion == "CREAR_IDIOMA")
            {
                CrearIdioma();
            }
        }

       
    }
}
