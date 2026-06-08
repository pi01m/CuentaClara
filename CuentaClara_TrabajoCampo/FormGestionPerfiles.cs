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
    public partial class FormGestionPerfiles : Form
    {
        private BLL_Familia bllFamilia = new BLL_Familia();

        public FormGestionPerfiles()
        {
            InitializeComponent();
        }

        private void FormGestionPerfiles_Load(object sender, EventArgs e)
        {
            CargarFamilias();
            CargarRoles();
            CargarPermisos();
        }

        #region CARGAS

        private void CargarFamilias()
        {
            cmbFamilia.DataSource = bllFamilia.ListarFamilias();
            cmbFamilia.DisplayMember = "Nombre";
            cmbFamilia.ValueMember = "IdFamilia";
        }

        private void CargarRoles()
        {
            cmbRol.DataSource = bllFamilia.ListarRoles();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.ValueMember = "IdRol";
        }

        private void CargarPermisos()
        {
            cmbPermiso.DataSource = bllFamilia.ListarPermisos();
            cmbPermiso.DisplayMember = "Nombre";
            cmbPermiso.ValueMember = "IdPermiso";
        }

        #endregion

        #region GRILLA

        private void CargarGrilla()
        {
            if (cmbFamilia.SelectedValue == null) return;

            Servicio_Familia fam =
                bllFamilia.ObtenerFamiliaCompleta(
                    cmbFamilia.SelectedValue.ToString()
                );

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Tipo");
            tabla.Columns.Add("Nombre");

            foreach (var item in fam.ListaPermisos)
            {
                DataRow row = tabla.NewRow();

                if (item is Servicio_Familia)
                    row["Tipo"] = "Familia";
                else if (item is Servicio_Permiso)
                    row["Tipo"] = "Permiso";
                else
                    row["Tipo"] = "Rol";

                row["Nombre"] = item.Nombre;

                tabla.Rows.Add(row);
            }

            dgvEstructura.DataSource = tabla;
        }

        #endregion

        #region BOTONES

        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = cmbFamilia.Text;

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("Ingrese nombre de familia");
                    return;
                }

                Servicio_Familia f =
                    new Servicio_Familia(
                        Guid.NewGuid().ToString(),
                        nombre
                    );

                bllFamilia.CrearFamilia(f);

                MessageBox.Show("Familia creada");

                CargarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFamilia.SelectedValue == null || cmbRol.SelectedValue == null)
                    return;

                bllFamilia.AsignarRol(
                    cmbFamilia.SelectedValue.ToString(),
                    cmbRol.SelectedValue.ToString()
                );

                MessageBox.Show("Rol asignado");

                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignarPermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFamilia.SelectedValue == null || cmbPermiso.SelectedValue == null)
                    return;

                bllFamilia.AsignarPermiso(
                    cmbFamilia.SelectedValue.ToString(),
                    cmbPermiso.SelectedValue.ToString()
                );

                MessageBox.Show("Permiso asignado");

                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Servicio_Familia f =
                    new Servicio_Familia(
                        cmbFamilia.SelectedValue.ToString(),
                        cmbFamilia.Text
                    );

                bllFamilia.ModificarFamilia(f);

                MessageBox.Show("Familia modificada");

                CargarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFamilia.SelectedValue == null) return;

                bllFamilia.EliminarFamilia(
                    cmbFamilia.SelectedValue.ToString()
                );

                MessageBox.Show("Familia eliminada");

                CargarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
