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
                throw new Exception("Nombre de rol requerido");

            dal.CrearRol(rol);
        }

        public DataTable ListarRoles()
        {
            return dal.ListarRoles();
        }
    }
}
