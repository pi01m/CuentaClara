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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IU
{
    public partial class FormGestionPerfil : Form
    {
        private string modoActual = "";
        private string idNodoSeleccionado = "";
        private string tipoNodoSeleccionado = "";
        private string nombreNodoSeleccionado = "";

        private BLL_BitacoraEvento bllBitacora = new BLL_BitacoraEvento();
        private BLL_Familia bllFamilia;
        private BLL_Permiso bllPermiso;
        private BLL_Rol bllRol;

        public FormGestionPerfil()
        {
            InitializeComponent();
        }

        private void FormGestionPerfil_Load(object sender, EventArgs e)
        {
            bllFamilia = new BLL_Familia();
            bllPermiso = new BLL_Permiso();
            bllRol = new BLL_Rol();

            CargarCombos();
            MostrarArbol();

            btnAplicar.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbFamiliaHija.Enabled = false;
            cmbPermiso.Enabled = false;
            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
        }

        private void CargarCombos()
        {
            // PERMISOS
            cmbPermiso.DataSource = bllPermiso.ListarPermisos();
            cmbPermiso.DisplayMember = "Nombre";
            cmbPermiso.ValueMember = "IdPermiso";

            // FAMILIAS
            DataTable familias = bllFamilia.ObtenerFamilias();

            cmbFamilia.DataSource = familias;
            cmbFamilia.DisplayMember = "Nombre";
            cmbFamilia.ValueMember = "IdFamilia";

            cmbFamiliaHija.DataSource = familias.Copy();
            cmbFamiliaHija.DisplayMember = "Nombre";
            cmbFamiliaHija.ValueMember = "IdFamilia";

            // ROLES
            cmbRol.DataSource = bllRol.ObtenerRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "IdRol";
        }

        // NUEVO MÉTODO DE DIBUJO RECURSIVO EN MEMORIA
        private void DibujarComposite(TreeNode nodoPadre, Servicio_Familia familiaArmada)
        {
            if (familiaArmada != null && familiaArmada.ObtenerHijos() != null)
            {
                foreach (Servicio_Rol item in familiaArmada.ObtenerHijos())
                {
                    string prefijo = (item is Servicio_Familia) ? "[F] " : "[P] ";
                    TreeNode nodoHijo = new TreeNode(prefijo + item.Nombre);
                    nodoHijo.Tag = item.IdRol;

                    nodoPadre.Nodes.Add(nodoHijo);

                    if (item is Servicio_Familia subFamilia)
                    {
                        DibujarComposite(nodoHijo, subFamilia);
                    }
                }
            }
        }

        // EL ÁRBOL MAESTRO
        private void MostrarArbol()
        {
            treeView1.Nodes.Clear();

            DataTable dtRoles = bllRol.ObtenerRoles();

            if (dtRoles != null)
            {
                foreach (DataRow rowRol in dtRoles.Rows)
                {
                    string idRol = rowRol["IdRol"].ToString();
                    string nombreRol = rowRol["Nombre"].ToString();

                    TreeNode nodoRol = new TreeNode("[ROL] " + nombreRol);
                    nodoRol.Tag = idRol;
                    treeView1.Nodes.Add(nodoRol);

                    DataTable dtFamiliasDelRol = bllRol.ObtenerFamiliasPorRol(idRol);
                    if (dtFamiliasDelRol != null)
                    {
                        foreach (DataRow rowFam in dtFamiliasDelRol.Rows)
                        {
                            string idFam = rowFam["IdFamilia"].ToString();
                            string nombreFam = rowFam["Nombre"].ToString();

                            TreeNode nodoFam = new TreeNode("[F] " + nombreFam);
                            nodoFam.Tag = idFam;
                            nodoRol.Nodes.Add(nodoFam);

                            Servicio_Familia familiaCompleta = bllFamilia.ObtenerFamiliaCompleta(idFam);
                            if (familiaCompleta != null)
                            {
                                DibujarComposite(nodoFam, familiaCompleta);
                            }
                        }
                    }

                    DataTable permisosRol = bllPermiso.ObtenerPermisosPorRol(idRol);
                    if (permisosRol != null)
                    {
                        foreach (DataRow rowPerm in permisosRol.Rows)
                        {
                            string idPermiso = rowPerm["IdPermiso"].ToString();
                            string nombrePermiso = rowPerm["Nombre"].ToString();

                            TreeNode nodoPermiso = new TreeNode("[P] " + nombrePermiso);
                            nodoPermiso.Tag = idPermiso;
                            nodoRol.Nodes.Add(nodoPermiso);
                        }
                    }
                }
            }

            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                idNodoSeleccionado = e.Node.Tag.ToString();
                string textoNodo = e.Node.Text;

                nombreNodoSeleccionado = textoNodo.Replace("[ROL] ", "").Replace("[F] ", "").Replace("[P] ", "");

                if (textoNodo.StartsWith("[ROL]"))
                {
                    tipoNodoSeleccionado = "ROL";
                }
                else if (textoNodo.StartsWith("[F]"))
                {
                    tipoNodoSeleccionado = "FAMILIA";
                }
                else if (textoNodo.StartsWith("[P]"))
                {
                    tipoNodoSeleccionado = "PERMISO";
                }
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

                    bllBitacora.RegistrarBitacora("Asignación familia a rol", SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 1);
                    MessageBox.Show("Familia asignada al rol correctamente.");
                }
                else if (radioBtn_Familia.Checked)
                {
                    BLL_Familia bllFamilia = new BLL_Familia();
                    string idPadre = cmbFamilia.SelectedValue.ToString();
                    string idHija = cmbFamiliaHija.SelectedValue.ToString();

                    bllFamilia.AsignarSubFamilia(idPadre, idHija);

                    bllBitacora.RegistrarBitacora("Asignación familia a familia", SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 1);
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
                    string idRol = cmbRol.SelectedValue.ToString();
                    string idPermiso = cmbPermiso.SelectedValue.ToString();
                    BLL_Rol bllRol = new BLL_Rol();

                    if (bllRol.TienePermiso(idRol, idPermiso))
                    {
                        MessageBox.Show("El rol ya posee ese permiso.");
                        return;
                    }

                    bllRol.AsignarPermiso(idRol, idPermiso);
                    bllBitacora.RegistrarBitacora("Asignación permiso a rol", SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 1);
                    MessageBox.Show("Permiso asignado correctamente.");
                }
                else if (radioBtn_Familia.Checked)
                {
                    string idFamilia = cmbFamilia.SelectedValue.ToString();
                    string idPermiso = cmbPermiso.SelectedValue.ToString();
                    BLL_Familia bllFamilia = new BLL_Familia();

                    if (bllFamilia.TienePermiso(idFamilia, idPermiso))
                    {
                        MessageBox.Show("La familia ya posee ese permiso.");
                        return;
                    }

                    bllFamilia.AsignarPermiso(idFamilia, idPermiso);
                    bllBitacora.RegistrarBitacora("Asignación permiso a familia", SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 1);
                    MessageBox.Show("Permiso asignado correctamente.");
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

        private void ModificarFamilia()
        {
            try
            {
                if (tipoNodoSeleccionado != "FAMILIA")
                {
                    MessageBox.Show("Por favor, seleccione una Familia [F] del árbol para modificar.");
                    return;
                }

                if (string.IsNullOrEmpty(idNodoSeleccionado))
                {
                    MessageBox.Show("Seleccione una familia del árbol.");
                    return;
                }

                string idFamilia = idNodoSeleccionado;
                string nombreActual = nombreNodoSeleccionado;

                string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre", "Modificar Familia", nombreActual);

                if (string.IsNullOrWhiteSpace(nuevoNombre)) return;

                BLL_Familia bllFamilia = new BLL_Familia();

                if (bllFamilia.ExisteNombre(nuevoNombre))
                {
                    MessageBox.Show("Ya existe una familia con ese nombre.");
                    return;
                }

                Servicio_Familia familia = new Servicio_Familia(idFamilia, nuevoNombre);
                bllFamilia.Modificar(familia);

                bllBitacora.RegistrarBitacora("Modificacion Familia: " + nuevoNombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 2);
                MessageBox.Show("Familia modificada correctamente.");
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
                if (tipoNodoSeleccionado != "FAMILIA")
                {
                    MessageBox.Show("Por favor, seleccione una Familia [F] del árbol para eliminar.");
                    return;
                }

                string idFamilia = idNodoSeleccionado;
                string nombre = nombreNodoSeleccionado;

                BLL_Familia bllFamilia = new BLL_Familia();
                bllFamilia.Eliminar(idFamilia);

                bllBitacora.RegistrarBitacora("Baja Familia: " + nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 2);
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

                if (string.IsNullOrWhiteSpace(nombre)) return;

                BLL_Familia bllFamilia = new BLL_Familia();

                if (bllFamilia.ExisteNombre(nombre))
                {
                    MessageBox.Show("Ya existe una familia con ese nombre.");
                    return;
                }

                Servicio_Familia familia = new Servicio_Familia(Guid.NewGuid().ToString(), nombre);
                bllFamilia.Guardar(familia);

                bllBitacora.RegistrarBitacora("Alta Familia: " + nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Gestion Perfiles", 1);
                MessageBox.Show("Familia creada correctamente.");

                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // EVENTOS DE BOTONES DE MODO
        private void btnAsignarPermiso_Click_1(object sender, EventArgs e)
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

            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            cmbRol.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbFamiliaHija.Enabled = false;
            cmbPermiso.Enabled = false;
            btnAplicar.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
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

        private void btnCrear_Click_1(object sender, EventArgs e)
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

            CargarCombos();
        }

        private void radioBtn_Rol_CheckedChanged_1(object sender, EventArgs e)
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
                listBox1.Items.Add("Modo asignar permiso a ROL");
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

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            switch (modoActual)
            {
                case "CREAR":
                    CrearFamilia();
                    break;
                case "MODIFICAR":
                    ModificarFamilia();
                    break;
                case "ELIMINAR":
                    EliminarFamilia();
                    break;
                case "ASIGNAR_PERMISO":
                    AsignarPermiso();
                    break;
                case "ASIGNAR_FAMILIA":
                    AsignarFamilia();
                    break;
            }

            CargarCombos();
            MostrarArbol(); // Refresca todo el árbol maestro al final
        }
    }
}
