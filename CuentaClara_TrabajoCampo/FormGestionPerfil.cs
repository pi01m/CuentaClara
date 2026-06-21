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

        private void DesmarcarCheckedLists()
        {
            for (int i = 0; i < clbPermiso.Items.Count; i++) clbPermiso.SetItemChecked(i, false);
            for (int i = 0; i < clbFamilia.Items.Count; i++) clbFamilia.SetItemChecked(i, false);
        }

        private void FormGestionPerfil_Load(object sender, EventArgs e)
        {
            bllFamilia = new BLL_Familia();
            bllPermiso = new BLL_Permiso();
            bllRol = new BLL_Rol();

            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();

            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);

            lblUsuarioActivo.Text = $"Usuario: {usuarioActual.Login} - Rol: {nombreLegibleDelRol}";

            CargarCombos();
            MostrarArbol();

            btnAplicar.Enabled = false;
            clbFamilia.Enabled = false;
            clbPermiso.Enabled = false;
            cmbFamiliaHija.Enabled = false;
            cmbFamilia.Enabled = false;
            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
        }

        private void CargarCombos()
        {

            clbPermiso.DataSource = null;
            clbPermiso.Items.Clear();
            clbPermiso.DataSource = bllPermiso.ListarPermisos();
            clbPermiso.DisplayMember = "Nombre";
            clbPermiso.ValueMember = "IdPermiso";

            DataTable familias = bllFamilia.ObtenerFamilias();


            clbFamilia.DataSource = null;
            clbFamilia.Items.Clear();
            clbFamilia.DataSource = familias.Copy();
            clbFamilia.DisplayMember = "Nombre";
            clbFamilia.ValueMember = "IdFamilia";

            cmbFamiliaHija.DataSource = null;
            cmbFamiliaHija.DataSource = familias.Copy();
            cmbFamiliaHija.DisplayMember = "Nombre";
            cmbFamiliaHija.ValueMember = "IdFamilia";

            cmbFamilia.DataSource = null;
            cmbFamilia.DataSource = familias.Copy();
            cmbFamilia.DisplayMember = "Nombre";
            cmbFamilia.ValueMember = "IdFamilia";

            cmbRol.DataSource = null;
            cmbRol.DataSource = bllRol.ObtenerRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "IdRol";
        }

        private void MostrarVistaPreviaFamilia(string idFamilia)
        {
            treeViewVistaPrevia.Nodes.Clear();

            if (string.IsNullOrEmpty(idFamilia)) return;

            try
            {
                // Traemos la familia desarmada con todo su composite usando tu BLL
                Servicio_Familia familiaCompleta = bllFamilia.ObtenerFamiliaCompleta(idFamilia);

                if (familiaCompleta != null)
                {
                    // Creamos el nodo principal
                    TreeNode nodoRaiz = new TreeNode("[F] " + familiaCompleta.Nombre);
                    treeViewVistaPrevia.Nodes.Add(nodoRaiz);

                    // Reutilizamos tu método existente para llenar los hijos
                    DibujarComposite(nodoRaiz, familiaCompleta);

                    treeViewVistaPrevia.ExpandAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la vista previa: " + ex.Message);
            }
        }
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
                if (clbFamilia.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos una familia de la lista.");
                    return;
                }

                if (radioBtn_Rol.Checked)
                {
                    BLL_Rol bllRol = new BLL_Rol();
                    string idRol = cmbRol.SelectedValue.ToString();

                    foreach (DataRowView item in clbFamilia.CheckedItems)
                    {
                        string idFamilia = item["IdFamilia"].ToString();
                        string nombreFamilia = item["Nombre"].ToString();

                        string conflictos = bllRol.VerificarRedundanciasRol(idRol, idFamilia);
                        bool limpiar = false;


                        if (!string.IsNullOrEmpty(conflictos))
                        {
                            DialogResult r = MessageBox.Show(
                                $"La familia '{nombreFamilia}' contiene permisos que el Rol ya posee de forma directa: {conflictos}.\n\n¿Desea eliminar esos permisos sueltos para poder asignar la familia?", "Conflicto de Permisos",

                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (r == DialogResult.Yes)
                            {
                                limpiar = true;
                            }
                            else
                            {
                                continue;
                            }


                        }
                        bllRol.AsignarFamiliaARol(idRol, idFamilia, limpiar);
                    }


                    bllBitacora.RegistrarBitacora("Asignación de familias a rol", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);
                    MessageBox.Show("Familias asignadas al rol correctamente.");
                    LimpiarModo();
                }
                else if (radioBtn_Familia.Checked)
                {
                    BLL_Familia bllFamilia = new BLL_Familia();
                    string idPadre = cmbFamilia.SelectedValue.ToString();
                    string idHija = cmbFamiliaHija.SelectedValue.ToString();

                    bllFamilia.AsignarSubFamilia(idPadre, idHija);

                    bllBitacora.RegistrarBitacora("Asignación familia a familia", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);
                    MessageBox.Show("Familia asignada correctamente."); LimpiarModo();
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
                if (clbPermiso.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un permiso de la lista.");
                    return;
                }
                if (radioBtn_Rol.Checked)
                {
                    string idRol = cmbRol.SelectedValue.ToString();
                    BLL_Rol bllRol = new BLL_Rol();

                    int asignados = 0;
                    foreach (DataRowView item in clbPermiso.CheckedItems)
                    {
                        string idPermiso = item["IdPermiso"].ToString();


                        if (!bllRol.RolTienePermisoRecursivo(idRol, idPermiso))
                        {
                            bllRol.AsignarPermiso(idRol, idPermiso);
                            asignados++;
                        }
                        else
                        {
                            // Opcional: Avisarle al usuario que se omitió porque ya lo tiene heredado
                            MessageBox.Show($"El rol ya posee el permiso '{item["Nombre"].ToString()}' (de forma directa o a través de una familia). Se omitió esta asignación.", "Aviso de redundancia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    if (asignados > 0)
                    {
                        bllBitacora.RegistrarBitacora($"Asignación de {asignados} permisos a rol", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);
                        MessageBox.Show($"Se asignaron {asignados} permisos correctamente.");
                    }

                    LimpiarModo();

                }
                else if (radioBtn_Familia.Checked)
                {
                    string idFamilia = cmbFamilia.SelectedValue.ToString();

                    BLL_Familia bllFamilia = new BLL_Familia();
                    int asignados = 0;

                    foreach (DataRowView item in clbPermiso.CheckedItems)
                    {
                        string idPermiso = item["IdPermiso"].ToString();
                        if (!bllFamilia.TienePermiso(idFamilia, idPermiso))
                        {
                            bllFamilia.AsignarPermiso(idFamilia, idPermiso);
                            asignados++;
                        }
                        else
                        {
                            MessageBox.Show($"La familia ya posee el permiso '{item["Nombre"].ToString()}'. Se omitió asignar este permiso.");
                        }
                    }

                    bllBitacora.RegistrarBitacora("Asignación permiso a familia", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);
                    MessageBox.Show("Permiso asignado correctamente."); LimpiarModo();
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

                bllBitacora.RegistrarBitacora("Modificacion Familia: " + nuevoNombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
                MessageBox.Show("Familia modificada correctamente."); LimpiarModo();
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

                bllBitacora.RegistrarBitacora("Baja Familia: " + nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
                MessageBox.Show("Familia eliminada correctamente."); LimpiarModo();
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

                if ((clbPermiso.CheckedItems.Count + clbFamilia.CheckedItems.Count) < 2)
                {
                    MessageBox.Show("Una familia debe contener al menos 2 componentes desde su creación. Tilde más elementos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre de la familia", "Nueva Familia");
                if (string.IsNullOrWhiteSpace(nombre)) return;

                BLL_Familia bllFamilia = new BLL_Familia();
                if (bllFamilia.ExisteNombre(nombre))
                {
                    MessageBox.Show("Ya existe una familia con ese nombre.");
                    return;
                }


                string idNuevaFamilia = Guid.NewGuid().ToString();
                Servicio_Familia familia = new Servicio_Familia(idNuevaFamilia, nombre);
                bllFamilia.Guardar(familia);


                foreach (DataRowView itemChecked in clbPermiso.CheckedItems)
                {
                    string idPermiso = itemChecked["IdPermiso"].ToString();
                    bllFamilia.AsignarPermiso(idNuevaFamilia, idPermiso);
                }


                foreach (DataRowView itemChecked in clbFamilia.CheckedItems)
                {
                    string idSubFamilia = itemChecked["IdFamilia"].ToString();
                    bllFamilia.AsignarSubFamilia(idNuevaFamilia, idSubFamilia);
                }

                bllBitacora.RegistrarBitacora("Alta Familia Modular: " + nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);
                MessageBox.Show("Familia estructurada y guardada correctamente.");

                LimpiarModo();
                CargarCombos();
                MostrarArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DesasignarElemento()
        {
            try
            {
                TreeNode nodoSeleccionado = treeView1.SelectedNode;

                if (nodoSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un elemento del árbol para quitarlo.");
                    return;
                }

                if (nodoSeleccionado.Parent == null)
                {
                    MessageBox.Show("No se puede quitar un Rol principal desde aquí.");
                    return;
                }

                TreeNode nodoPadre = nodoSeleccionado.Parent;

                string idHijo = nodoSeleccionado.Tag.ToString();
                string idPadre = nodoPadre.Tag.ToString();

                string tipoHijo = nodoSeleccionado.Text.StartsWith("[F]") ? "FAMILIA" : "PERMISO";
                string tipoPadre = nodoPadre.Text.StartsWith("[ROL]") ? "ROL" : "FAMILIA";

                BLL_Rol bllRol = new BLL_Rol();
                BLL_Familia bllFamilia = new BLL_Familia();

                if (tipoPadre == "ROL" && tipoHijo == "PERMISO")
                {
                    bllRol.DesasignarPermiso(idPadre, idHijo);
                }
                else if (tipoPadre == "ROL" && tipoHijo == "FAMILIA")
                {
                    bllRol.DesasignarFamilia(idPadre, idHijo);
                }
                else if (tipoPadre == "FAMILIA" && tipoHijo == "PERMISO")
                {
                    bllFamilia.DesasignarPermiso(idPadre, idHijo);
                }
                else if (tipoPadre == "FAMILIA" && tipoHijo == "FAMILIA")
                {
                    bllFamilia.DesasignarSubFamilia(idPadre, idHijo);
                }

                bllBitacora.RegistrarBitacora("Desasignación en Perfiles", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);

                MessageBox.Show("Elemento desvinculado correctamente."); LimpiarModo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar desasignar: " + ex.Message);
            }
        }

        private void CrearRol()
        {
            try
            {

                if (clbPermiso.CheckedItems.Count == 0 && clbFamilia.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No se permiten Roles vacíos. Tilde al menos un Permiso o una Familia inicial antes de continuar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del Rol", "Nuevo Rol");
                if (string.IsNullOrWhiteSpace(nombre)) return;
                if (bllRol.ExisteNombre(nombre))
                {
                    MessageBox.Show("Ya existe un rol con ese nombre.");
                    return;
                }

                string idNuevoPerfil = Guid.NewGuid().ToString();
                Servicio_Familia perfil = new Servicio_Familia(idNuevoPerfil, nombre);
                bllRol.CrearRol(perfil);



                foreach (DataRowView itemChecked in clbFamilia.CheckedItems)
                {
                    string idFamilia = itemChecked["IdFamilia"].ToString();
                    bllRol.AsignarFamiliaARol(idNuevoPerfil, idFamilia, false);
                }

                foreach (DataRowView itemChecked in clbPermiso.CheckedItems)
                {
                    string idPermiso = itemChecked["IdPermiso"].ToString();


                    if (!bllRol.RolTienePermisoRecursivo(idNuevoPerfil, idPermiso))
                    {
                        bllRol.AsignarPermiso(idNuevoPerfil, idPermiso);
                    }
                }

                MessageBox.Show("Rol creado con éxito. El sistema omitió los permisos redundantes de forma automática.");
                LimpiarModo();
                CargarCombos();
                MostrarArbol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarPerfil()
        {
            try
            {
                if (tipoNodoSeleccionado != "ROL")
                {
                    MessageBox.Show("Seleccione un Perfil [ROL]");

                    return;
                }

                string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Nuevo nombre del Rol", "Modificar Rol", nombreNodoSeleccionado);


                if (string.IsNullOrWhiteSpace(nuevoNombre)) return;

                if (nuevoNombre.ToUpper() != nombreNodoSeleccionado.ToUpper() && bllRol.ExisteNombre(nuevoNombre))
                {
                    MessageBox.Show("Ya existe un Rol con ese nombre. Elija otro.");
                    return;
                }

                bllRol.ModificarPerfil(idNodoSeleccionado, nuevoNombre);

                MessageBox.Show("Rol modificado correctamente.");


                MostrarArbol();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarPerfil()
        {
            try
            {
                if (tipoNodoSeleccionado != "ROL")
                {
                    MessageBox.Show(
                        "Seleccione un Perfil [ROL]");
                    return;
                }

                DialogResult r =
                    MessageBox.Show(
                        "¿Eliminar perfil?",
                        "Confirmación",
                        MessageBoxButtons.YesNo);

                if (r == DialogResult.No)
                    return;

                bllRol.EliminarPerfil(
                    idNodoSeleccionado);

                MessageBox.Show(
                    "Perfil eliminado correctamente.");

                MostrarArbol();
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAsignarPermiso_Click_1(object sender, EventArgs e)
        {
            modoActual = "ASIGNAR_PERMISO";
            listBox1.Items.Clear();
            listBox1.Items.Add("1. Seleccione arriba si lo asignará a un ROL o a una FAMILIA.");
            listBox1.Items.Add("Modo asignar permiso a...");

            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            cmbRol.Enabled = false;
            clbFamilia.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbFamiliaHija.Enabled = false;
            btnAplicar.Enabled = true;
        }

        private void btnAsignarFamilia_Click(object sender, EventArgs e)
        {
            modoActual = "ASIGNAR_FAMILIA";
            listBox1.Items.Clear();
            listBox1.Items.Add("1. Seleccione arriba si la asignará a un ROL o a otra FAMILIA.");
            listBox1.Items.Add("Modo asignar familia a ...");

            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;


            btnAsignarPermiso.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            button1.Enabled = false;
            clbFamilia.Enabled = true;

            cmbRol.Enabled = false;
            clbFamilia.Enabled = false;
            cmbFamiliaHija.Enabled = false;

            btnAplicar.Enabled = true;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            modoActual = "MODIFICAR";
            listBox1.Items.Clear();
            listBox1.Items.Add("Modo modificar FAMILIA seleccionada\n");
            listBox1.Items.Add("1. Seleccione una Familia [F] en el árbol.");
            listBox1.Items.Add("2. Presione Aplicar.");
            listBox1.Items.Add("3. Ingrese el nuevo nombre en la ventana emergente.");


            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            btnAsignarFamilia.Enabled = false;
            btnAsignarPermiso.Enabled = false;
            btnEliminar.Enabled = false;

            button1.Enabled = false;

            clbFamilia.Enabled = true;
            cmbRol.Enabled = false;

            cmbFamiliaHija.Enabled = false;
            btnAplicar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            modoActual = "ELIMINAR";
            listBox1.Items.Clear();

            listBox1.Items.Add("Modo ELIMINAR FAMILIA (Baja completa)");
            listBox1.Items.Add("1. Seleccione una Familia [F] en el árbol.");
            listBox1.Items.Add("2. Presione Aplicar para destruirla del sistema.");

            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            btnAsignarFamilia.Enabled = false;
            btnAsignarPermiso.Enabled = false;
            btnCrear.Enabled = false;
            btnModificar.Enabled = false;
            button1.Enabled = false;

            clbFamilia.Enabled = true;
            cmbRol.Enabled = false;

            cmbFamiliaHija.Enabled = false;
            btnAplicar.Enabled = true;
        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            modoActual = "CREAR";
            listBox1.Items.Clear();
            listBox1.Items.Add("Modo CREAR");
            listBox1.Items.Add("1. Elegir Rol/Familia.");


            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;

            btnAsignarFamilia.Enabled = false;
            btnAsignarPermiso.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            button1.Enabled = false;

            radioBtn_Rol.Enabled = true;
            radioBtn_Familia.Enabled = true;

            cmbFamiliaHija.Enabled = false;
            btnAplicar.Enabled = true;

            CargarCombos();
        }

        private void radioBtn_Rol_CheckedChanged_1(object sender, EventArgs e)
        {
            if (modoActual == "CREAR" && radioBtn_Rol.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(">>> MODO: CREAR NUEVO PERFIL (ROL) <<<");
                listBox1.Items.Add("1. Seleccione en las listas todos los Permisos y/o Familias iniciales.");
                listBox1.Items.Add("2. Recuerde que NO puede quedar vacío (es obligatorio marcar al menos uno).");
                listBox1.Items.Add("3. Presione el botón 'Aplicar'.");
                listBox1.Items.Add("4. Ingrese el nombre del nuevo Perfil en la ventana emergente.");

                clbPermiso.Enabled = true;
                clbFamilia.Enabled = true;
                cmbFamiliaHija.Enabled = false;
                cmbRol.Enabled = false;

                DesmarcarCheckedLists();
            }
            if (modoActual == "ASIGNAR_PERMISO" && radioBtn_Rol.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Asignando permiso a ROL:");
                listBox1.Items.Add("1. Elija el ROL del ComboBox.");
                listBox1.Items.Add("2. Elija el PERMISO en la lista desplegable.");
                listBox1.Items.Add("3. Presione Aplicar.");

                cmbRol.Enabled = true;
                clbPermiso.Enabled = true;
                clbFamilia.Enabled = false;
                cmbFamiliaHija.Enabled = false;
            }
            if (modoActual == "ASIGNAR_FAMILIA" && radioBtn_Rol.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo asignar familia a ROL");
                listBox1.Items.Add("1. Elija el ROL del ComboBox.");
                listBox1.Items.Add("2. Elija la FAMILIA en la lista desplegable.");
                listBox1.Items.Add("3. Presione Aplicar.");
                cmbRol.Enabled = true;
                clbFamilia.Enabled = true;
                cmbFamiliaHija.Enabled = false;

            }
        }

        private void radioBtn_Familia_CheckedChanged(object sender, EventArgs e)
        {
            if (modoActual == "CREAR" && radioBtn_Familia.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(">>> MODO: CREAR NUEVA FAMILIA <<<");
                listBox1.Items.Add("1. Seleccione los Permisos y/o Subfamilias que compondrán esta familia.");
                listBox1.Items.Add("2. Es OBLIGATORIO tildar al menos un elemento.");
                listBox1.Items.Add("3. Presione 'Aplicar' e ingrese el nombre de la Familia.");

                clbPermiso.Enabled = true;
                cmbFamilia.Enabled = true;
                cmbFamiliaHija.Enabled = false;
                cmbRol.Enabled = false;

                DesmarcarCheckedLists();
            }
            if (modoActual == "ASIGNAR_PERMISO" && radioBtn_Familia.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo asignar permiso a FAMILIA");
                listBox1.Items.Add("1. Elija la FAMILIA en la lista desplegable determinada.");
                listBox1.Items.Add("2. Elija el PERMISO en la lista desplegable determinada.");
                listBox1.Items.Add("3. Presione Aplicar.");
                clbFamilia.Enabled = true;

                cmbRol.Enabled = false;
                cmbFamiliaHija.Enabled = false;
                cmbFamilia.Enabled = true;
                clbPermiso.Enabled = true;
                clbFamilia.Enabled = false;
            }
            if (modoActual == "ASIGNAR_FAMILIA" && radioBtn_Familia.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Modo asignar familia a FAMILIA");
                listBox1.Items.Add("1. Elija la Familia CONTENEDORA la lista desplegable determinada.");
                listBox1.Items.Add("2. Elija la Familia a INSERTAR la lista desplegable determinada.");
                listBox1.Items.Add("3. Presione Aplicar.");

                cmbFamilia.Enabled = true;
                cmbFamiliaHija.Enabled = true;
                cmbRol.Enabled = false;
                clbFamilia.Enabled = false;
                clbPermiso.Enabled = false;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            modoActual = "DESASIGNAR";

            listBox1.Items.Clear();
            listBox1.Items.Add("Modo DESASIGNAR seleccionado");
            listBox1.Items.Add("1. Seleccione un [P] o [F] del árbol.");
            listBox1.Items.Add("2. Presione Aplicar para quitarlo.");


            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;
            btnAsignarFamilia.Enabled = false;
            btnAsignarPermiso.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            cmbRol.Enabled = false;
            clbFamilia.Enabled = false;

            cmbFamiliaHija.Enabled = false;


            btnAplicar.Enabled = true;
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            switch (modoActual)
            {
                case "CREAR":
                    if (radioBtn_Rol.Checked)
                        CrearRol();
                    else
                        CrearFamilia();
                    break;
                case "MODIFICAR":
                    if (tipoNodoSeleccionado == "ROL")
                        ModificarPerfil();
                    else
                        ModificarFamilia();
                    break;
                case "ELIMINAR":
                    if (tipoNodoSeleccionado == "ROL")
                        EliminarPerfil();
                    else
                        EliminarFamilia();
                    break;
                case "ASIGNAR_PERMISO":
                    AsignarPermiso();
                    break;
                case "ASIGNAR_FAMILIA":
                    AsignarFamilia();
                    break;
                case "DESASIGNAR":
                    DesasignarElemento();
                    break;
            }

            CargarCombos();
            MostrarArbol();
        }
        private void LimpiarModo()
        {
            modoActual = "";
            listBox1.Items.Clear();
            radioBtn_Rol.Enabled = false;
            radioBtn_Familia.Enabled = false;
            radioBtn_Rol.Checked = false;
            radioBtn_Familia.Checked = false;
            clbPermiso.Enabled = false;
            clbFamilia.Enabled = false;
            DesmarcarCheckedLists();
            cmbRol.Enabled = false;
            btnCrear.Enabled = true;
            cmbFamiliaHija.Enabled = false;
            btnAsignarFamilia.Enabled = true;
            btnAsignarPermiso.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            button1.Enabled = true;
            btnAplicar.Enabled = false;
            treeView1.SelectedNode = null;
            treeViewVistaPrevia.Nodes.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarModo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbFamilia.SelectedItem != null)
            {
                
                DataRowView row = (DataRowView)clbFamilia.SelectedItem;
                string idFam = row["IdFamilia"].ToString();

                MostrarVistaPreviaFamilia(idFam);
            }
        }
    }
}
