using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL
{
    public class BLL_Familia
    {

        private DAL_Familia dal;
        private DAL_FamiliaRol dalFR;
        private DAL_FamiliaPermiso dalFP;
        private DAL_FamiliaFamilia dalFF;
        private DAL_Rol dalRol;
        private DAL_Permiso dalPermiso;

        public BLL_Familia()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            dal = new DAL_Familia(conn);
            dalFR = new DAL_FamiliaRol(conn);
            dalFP = new DAL_FamiliaPermiso(conn);
            dalFF = new DAL_FamiliaFamilia(conn);
            dalRol = new DAL_Rol(conn);
            dalPermiso = new DAL_Permiso(conn);
        }

        public void CrearFamilia(Servicio_Familia f)
        {
            if (string.IsNullOrWhiteSpace(f.Nombre))
                throw new Exception("Nombre requerido");

            dal.CrearFamilia(f);
        }
        public void ModificarFamilia(Servicio_Familia f)
        {
            if (string.IsNullOrWhiteSpace(f.Nombre))
                throw new Exception("Nombre requerido");

            dal.ModificarFamilia(f);
        }
        public void EliminarFamilia(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new Exception("ID requerido");

            dal.EliminarFamilia(id);
        }
        public void AsignarRol(string f, string r) => dalFR.AsignarRol(f, r);
        public void AsignarPermiso(string f, string p) => dalFP.AsignarPermiso(f, p);
        public void AsignarSubFamilia(string p, string h) => dalFF.AsignarSubFamilia(p, h);

        public DataTable ListarRoles() => dalRol.ListarRoles();
        public DataTable ListarPermisos() => dalPermiso.ListarPermisos();

        public Servicio_Familia ObtenerFamiliaCompleta(string id)
        {
            var fam = new Servicio_Familia(id, "Familia");

            // SUBFAMILIAS
            var sub = dalFF.ObtenerSubFamilias(id);
            foreach (DataRow s in sub.Rows)
            {
                fam.AgregarRol(
                    new Servicio_Familia(
                        s["IdFamilia"].ToString(),
                        s["Nombre"].ToString()
                    )
                );
            }

            return fam;
        }
        public DataTable ListarFamilias()
        {
            return dal.ListarFamilias();
        }
    }
}
