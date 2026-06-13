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
    public class BLL_Permiso
    {
        private DAL_Permiso dal;

        public BLL_Permiso()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            dal = new DAL_Permiso(conn);
        }

        public void CrearPermiso(Servicio_Permiso permiso)
        {
            if (string.IsNullOrWhiteSpace(permiso.Nombre))
                throw new Exception("Ingrese un nombre.");

            dal.CrearPermiso( permiso.IdRol,permiso.Nombre);
                
               
        }
        
        public DataTable ObtenerPermisosPorRol(string idUsuario)
        {
            return dal.ObtenerPermisosPorRol(idUsuario);
        }
        public DataTable ListarPermisos()
        {
            return dal.ListarPermisos();
        }
    }
}
