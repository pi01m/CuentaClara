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
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IU
{
    public partial class FormGestionPerfil : Form
    {
        private string modoActual = "";
        private BLL_BitacoraEvento bllBitacora = new BLL_BitacoraEvento();
        public FormGestionPerfil()
        {
            InitializeComponent();
        }

        private void FormGestionPerfil_Load(object sender, EventArgs e)
        {
            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;

            cmbRol.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbPermiso.Enabled = false;
            cmbFamiliaHija.Enabled = false;

            btnAplicar.Enabled = false;

            CargarCombos();
        }

        private void CargarCombos()
        {
            BLL_Rol bllRol = new BLL_Rol();
            BLL_Familia bllFamilia = new BLL_Familia();
            BLL_Permiso bllPermiso = new BLL_Permiso();

            // ROLES
            cmbRol.DataSource = bllRol.ObtenerRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "IdRol";

            // PERMISOS
            cmbPermiso.DataSource = bllPermiso.ListarPermisos();
            cmbPermiso.DisplayMember = "Nombre";
            cmbPermiso.ValueMember = "IdPermiso";

            // FAMILIAS
            RecargarFamilias();
        }

        private void RecargarFamilias()
        {
            BLL_Familia bllFamilia = new BLL_Familia();

            DataTable familias = bllFamilia.ObtenerFamilias();

            cmbFamilia.DataSource = familias;
            cmbFamilia.DisplayMember = "Nombre";
            cmbFamilia.ValueMember = "IdFamilia";

            cmbFamiliaHija.DataSource = familias.Copy();
            cmbFamiliaHija.DisplayMember = "Nombre";
            cmbFamiliaHija.ValueMember = "IdFamilia";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            modoActual = "CREAR";

            listBox1.Items.Clear();
            listBox1.Items.Add("Modo crear...");

            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;


            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;


            cmbRol.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbPermiso.Enabled = false;
            cmbFamiliaHija.Enabled = false;

            btnAplicar.Enabled = true;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (modoActual == "CREAR")
            {

                CrearFamilia();

            }
            else if (modoActual == "ELIMINAR")
            {
                EliminarFamilia();
            }
            else if (modoActual == "MODIFICAR")
            {
                ModificarFamilia();
            }
            else if (modoActual == "ASIGNAR_PERMISO")
            {
                AsignarPermiso();
            }
            else if (modoActual == "ASIGNAR_FAMILIA")
            {
                AsignarFamilia();
            }

        }

        private void AsignarFamilia()
        {
            try
            {


                if (radioBtn_Rol.Checked)
                {
                    BLL_Rol bllRol = new BLL_Rol();
                    string idRol = cmbRol.SelectedValue.ToString();
                    string idFamilia = cmbFamilia.SelectedValue.ToString();

                    bllRol.AsignarFamiliaARol(idRol, idFamilia);

                    bllBitacora.RegistrarBitacora(
                        "Asignación familia a rol",
                        SessionManager.GetInstancia().GetUsuarioActual().Login,
                        "Gestion Perfiles",
                        1);

                    MessageBox.Show("Familia asignada al rol correctamente.");
                }
                else if (radioBtn_Familia.Checked)
                {
                    BLL_Familia bllFamilia = new BLL_Familia();
                    string idPadre = cmbFamilia.SelectedValue.ToString();
                    string idHija = cmbFamiliaHija.SelectedValue.ToString();

                    bllFamilia.AsignarSubFamilia(idPadre, idHija);

                    bllBitacora.RegistrarBitacora(
                        "Asignación familia a familia",
                        SessionManager.GetInstancia().GetUsuarioActual().Login,
                        "Gestion Perfiles",
                        1);

                    MessageBox.Show("Familia asignada correctamente.");
                }
                else
                {
                    MessageBox.Show("Seleccione Rol o Familia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AsignarPermiso()
        {
            try
            {
                if (radioBtn_Rol.Checked)
                {
                    string idRol =
                        cmbRol.SelectedValue.ToString();

                    string idPermiso =
                        cmbPermiso.SelectedValue.ToString();

                    BLL_Rol bllRol = new BLL_Rol();

                    if (bllRol.TienePermiso(idRol, idPermiso))
                    {
                        MessageBox.Show(
                            "El rol ya posee ese permiso.");
                        return;
                    }

                    bllRol.AsignarPermiso(
                        idRol,
                        idPermiso);

                    bllBitacora.RegistrarBitacora(
                        "Asignación permiso a rol",
                        SessionManager.GetInstancia()
                        .GetUsuarioActual()
                        .Login,
                        "Gestion Perfiles",
                        1);

                    MessageBox.Show(
                        "Permiso asignado correctamente.");
                }


                else if (radioBtn_Familia.Checked)
                {
                    string idFamilia =
                        cmbFamilia.SelectedValue.ToString();

                    string idPermiso =
                        cmbPermiso.SelectedValue.ToString();

                    BLL_Familia bllFamilia =
                        new BLL_Familia();

                    if (bllFamilia.TienePermiso(
                        idFamilia,
                        idPermiso))
                    {
                        MessageBox.Show(
                            "La familia ya posee ese permiso.");
                        return;
                    }

                    bllFamilia.AsignarPermiso(
                        idFamilia,
                        idPermiso);

                    bllBitacora.RegistrarBitacora(
                        "Asignación permiso a familia",
                        SessionManager.GetInstancia()
                        .GetUsuarioActual()
                        .Login,
                        "Gestion Perfiles",
                        1);

                    MessageBox.Show(
                        "Permiso asignado correctamente.");
                }
                else
                {
                    MessageBox.Show(
                        "Seleccione Rol o Familia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarFamilia()
        {
            try
            {
                if (cmbFamilia.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una familia.");
                    return;
                }

                string idFamilia =
                    cmbFamilia.SelectedValue.ToString();

                string nombreActual =
                    cmbFamilia.Text;

                string nuevoNombre =
                    Microsoft.VisualBasic.Interaction.InputBox(
                        "Ingrese el nuevo nombre",
                        "Modificar Familia",
                        nombreActual);

                if (string.IsNullOrWhiteSpace(nuevoNombre))
                    return;

                BLL_Familia bllFamilia =
                    new BLL_Familia();

                if (bllFamilia.ExisteNombre(nuevoNombre))
                {
                    MessageBox.Show(
                        "Ya existe una familia con ese nombre.");
                    return;
                }

                Servicio_Familia familia =
                    new Servicio_Familia(
                        idFamilia,
                        nuevoNombre);

                bllFamilia.Modificar(familia);

                bllBitacora.RegistrarBitacora(
                    "Modificacion Familia: " + nuevoNombre,
                    SessionManager.GetInstancia()
                        .GetUsuarioActual()
                        .Login,
                    "Gestion Perfiles",
                    2);

                MessageBox.Show(
                    "Familia modificada correctamente.");

                //CargarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void EliminarFamilia()
        {
            try
            {
                if (cmbFamilia.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una familia.");
                    return;
                }

                string idFamilia = cmbFamilia.SelectedValue.ToString();
                string nombre = cmbFamilia.Text;

                BLL_Familia bllFamilia = new BLL_Familia();

                bllFamilia.Eliminar(idFamilia);

                bllBitacora.RegistrarBitacora(
                    "Baja Familia: " + nombre,
                    SessionManager.GetInstancia().GetUsuarioActual().Login,
                    "Gestion Perfiles",
                    2);

                MessageBox.Show("Familia eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrearFamilia()
        {
            try
            {
                string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre de la familia", "Nueva Familia");

                if (string.IsNullOrWhiteSpace(nombre))
                    return;

                BLL_Familia bllFamilia = new BLL_Familia();

                if (bllFamilia.ExisteNombre(nombre))
                {
                    MessageBox.Show("Ya existe una familia con ese nombre.");
                    return;
                }

                Servicio_Familia familia =
                    new Servicio_Familia(Guid.NewGuid().ToString(), nombre);

                bllFamilia.Guardar(familia);

                bllBitacora.RegistrarBitacora(
                    "Alta Familia: " + nombre,
                    SessionManager.GetInstancia().GetUsuarioActual().Login,
                    "Gestion Perfiles",
                    1);

                MessageBox.Show("Familia creada correctamente.");

                RecargarFamilias();
            }
            catch (Exception ex)
            {

            }

        }



        private void radioBtn_Rol_CheckedChanged(object sender, EventArgs e)
        {
            if (modoActual == "CREAR" && radioBtn_Rol.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo crear ROL");
                listBox1.Items.Add("Los roles son predefinidos.");
            }
            if (modoActual == "ASIGNAR_PERMISO" && radioBtn_Rol.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(
                    "Modo asignar permiso a ROL");

                cmbRol.Enabled = true;
                cmbPermiso.Enabled = true;

                cmbFamilia.Enabled = false;
                cmbFamiliaHija.Enabled = false;
            }
            if (modoActual == "ASIGNAR_FAMILIA" && radioBtn_Rol.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo asignar familia a ROL");

                cmbRol.Enabled = true;
                cmbFamilia.Enabled = true;

                cmbFamiliaHija.Enabled = false;
                cmbPermiso.Enabled = false;
            }
        }

        private void radioBtn_Familia_CheckedChanged(object sender, EventArgs e)
        {
            if (modoActual == "CREAR" && radioBtn_Familia.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo crear FAMILIA");
            }

            if (modoActual == "ASIGNAR_PERMISO" && radioBtn_Familia.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo asignar permiso a FAMILIA");
                cmbFamilia.Enabled = true;
                cmbPermiso.Enabled = true;

                cmbRol.Enabled = false;
                cmbFamiliaHija.Enabled = false;
            }
            if (modoActual == "ASIGNAR_FAMILIA" && radioBtn_Familia.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo asignar familia a FAMILIA");

                cmbFamilia.Enabled = true;
                cmbFamiliaHija.Enabled = true;

                cmbRol.Enabled = false;
                cmbPermiso.Enabled = false;
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            modoActual = "ELIMINAR";

            listBox1.Items.Clear();
            listBox1.Items.Add("Modo eliminar FAMILIA seleccionado");


            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;

            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;


            cmbFamilia.Enabled = true;

            cmbRol.Enabled = false;
            cmbPermiso.Enabled = false;
            cmbFamiliaHija.Enabled = false;

            btnAplicar.Enabled = true;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modoActual = "MODIFICAR";

            listBox1.Items.Clear();
            listBox1.Items.Add("Modo modificar FAMILIA seleccionada");

            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;

            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            cmbFamilia.Enabled = true;

            cmbRol.Enabled = false;
            cmbPermiso.Enabled = false;
            cmbFamiliaHija.Enabled = false;

            btnAplicar.Enabled = true;
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            modoActual = "ASIGNAR_PERMISO";

            listBox1.Items.Clear();
            listBox1.Items.Add("Modo asignar permiso a...");

            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;

            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            cmbRol.Enabled = false;
            cmbFamilia.Enabled = false;

            cmbPermiso.Enabled = false;
            cmbFamiliaHija.Enabled = false;

            btnAplicar.Enabled = true;

        }

        private void btnAsignarFamilia_Click(object sender, EventArgs e)
        {
            modoActual = "ASIGNAR_FAMILIA";

            listBox1.Items.Clear();
            listBox1.Items.Add("Modo asignar familia a ...");

            // habilito solo radios necesarios
            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;

            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            // desactivo todo hasta elegir
            cmbRol.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbFamiliaHija.Enabled = false;
            cmbPermiso.Enabled = false;

            btnAplicar.Enabled = true;
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedValue == null) return;
            CargarArbolRol();
        }

        private void CargarArbolRol()
        {
            if (cmbRol.SelectedValue == null) return;

            string idRol = cmbRol.SelectedValue.ToString();

            treeView1.Nodes.Clear();

            BLL_Rol bllRol = new BLL_Rol();
            BLL_Familia bllFamilia = new BLL_Familia();

            DataTable familiasRol = bllRol.ObtenerFamiliasPorRol(idRol);

            TreeNode raiz = new TreeNode("ROL: " + cmbRol.Text);
            treeView1.Nodes.Add(raiz);

            foreach (DataRow row in familiasRol.Rows)
            {
                string idFam = row["IdFamilia"].ToString();
                string nombre = row["Nombre"].ToString();

                TreeNode nodoFam = new TreeNode("Familia: " + nombre);
                raiz.Nodes.Add(nodoFam);

                CargarSubFamilias(nodoFam, idFam, bllFamilia);
            }

            raiz.ExpandAll(); 
        }
         
        private void CargarSubFamilias(TreeNode nodoPadre, string? idFam, BLL_Familia bllFamilia)
        {
            DataTable sub = bllFamilia.ObtenerSubFamilias(idFam);

            foreach (DataRow row in sub.Rows)
            {
                string idHija = row["IdFamilia"].ToString();
                string nombre = row["Nombre"].ToString();

                TreeNode nodoHijo = new TreeNode("SubFamilia: " + nombre);

                nodoPadre.Nodes.Add(nodoHijo);

                CargarSubFamilias(nodoHijo, idHija, bllFamilia);
            }
        }
    }
}
