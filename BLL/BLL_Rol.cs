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
     
        public BLL_Rol()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            dal = new DAL_Rol(conn);

        }

        public void CrearRol(Servicio_Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                throw new Exception("Ingrese un nombre.");

            dal.CrearRol(rol.IdRol,rol.Nombre);
  
        }

        public DataTable ObtenerRoles()
        {
            return dal.ListarRoles();
        }

        public void AsignarPermiso(
            string idRol,
            string idPermiso)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idPermiso))
                throw new Exception("Seleccione un permiso.");

            if (dal.ExistePermiso(idRol, idPermiso))
                throw new Exception(
                    "El rol ya posee ese permiso.");

            dal.AsignarPermiso(
                idRol,
                idPermiso);
        }

        public string ObtenerNombreRol(string idRol)
        {
            return dal.ObtenerNombreRol(idRol);
        }

        public bool TienePermiso(
            string idRol,
            string idPermiso)
        {
            return dal.ExistePermiso(
                idRol,
                idPermiso);
        }

        public void AsignarFamiliaARol(
            string idRol,
            string idFamilia)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idFamilia))
                throw new Exception("Seleccione una familia.");

            if (dal.ExisteFamilia(
                idRol,
                idFamilia))
            {
                throw new Exception(
                    "La familia ya está asignada.");
            }

            dal.AsignarFamilia(
                idRol,
                idFamilia);
        }

        public bool TieneFamilia(
            string idRol,
            string idFamilia)
        {
            return dal.ExisteFamilia(
                idRol,
                idFamilia);
        }

        public DataTable ObtenerFamiliasPorRol(string idRol)
            
        {
            return dal.ObtenerFamiliasPorRol(
                idRol);
        }
        public void DesasignarPermiso(string idRol, string idPermiso)
        {
            
            dal.DesasignarPermiso(idRol, idPermiso);
        }

        public void DesasignarFamilia(string idRol, string idFamilia)
        {
            dal.DesasignarFamilia(idRol, idFamilia);
        }

        public void ModificarPerfil(string idRol, string nombre)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un perfil.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Ingrese un nombre.");

            dal.ModificarRol(idRol, nombre);
        }

        public void EliminarPerfil(string idRol)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un perfil.");

            // Primero elimino relaciones
            dal.EliminarRelacionesRol(idRol);

            // Después elimino el perfil
            dal.EliminarRol(idRol);
        }

        public bool ExisteNombre(string nombre)
        {
            return dal.ExisteNombre(nombre);
        }


    }
}