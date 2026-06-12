using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Rol
    {
        private DAL_Rol dal;
        private DAL_RolPermiso dalRP;
        private DAL_FamiliaRol dalFR;
        private DAL_FamiliaFamilia dalFF;
        public BLL_Rol()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            dal = new DAL_Rol(conn);
            dalRP = new DAL_RolPermiso(conn);
            dalFR = new DAL_FamiliaRol(conn);
        }

        public void CrearRol(Servicio_Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                throw new Exception("Nombre de rol requerido");

            dal.CrearRol(rol);
        }

        public DataTable ListarRoles()
        {
            return dal.ListarRoles();
        }

        #region nuevo
        public bool TienePermiso(string idRol,string idPermiso)
        {
            if (dalRP.ExistePermiso(idRol,idPermiso))
            {
                return true;
            }

            if (dalFR.TienePermisoPorFamilia(
                idRol,
                idPermiso))
            {
                return true;
            }

            return false;
        }

        public void AsignarPermiso( string idRol,string idPermiso)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idPermiso))
                throw new Exception("Seleccione un permiso.");

            if (dalRP.ExistePermiso(idRol,idPermiso))
            {
                throw new Exception( "El rol ya posee ese permiso.");
                   
            }

            dalRP.AsignarPermiso( idRol, idPermiso);
               
        }

        public void AsignarFamiliaARol(string idRol, string idFamilia)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idFamilia))
                throw new Exception("Seleccione una familia.");


            if (dalFR.ExisteFamiliaEnRol(idRol, idFamilia))
                throw new Exception("Este rol ya tiene asignada esta familia.");


            if (dalFF.FamiliaYaAsignadaIndirectamenteARol(idRol, idFamilia))
                throw new Exception("La familia ya está incluida indirectamente en el rol.");

            dalFR.AsignarRol(idFamilia, idRol);
        }

        public bool TieneFamilia(string idRol, string idFamilia)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idFamilia))
                throw new Exception("Seleccione una familia.");

            return dalFR.ExisteFamiliaEnRol(idRol, idFamilia);
        }

        public DataTable ObtenerRoles()
            {
                return dal.ListarRoles();
            }

        public DataTable ObtenerFamiliasPorRol(string idRol)
        {
            return dal.ObtenerFamiliasPorRol(idRol);
        }

        #endregion
    }
}
