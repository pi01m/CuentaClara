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
                throw new Exception("Nombre de permiso requerido");

            dal.CrearPermiso(permiso);
        }

        public DataTable ListarPermisos()
        {
            return dal.ListarPermisos();
        }
    }
}
