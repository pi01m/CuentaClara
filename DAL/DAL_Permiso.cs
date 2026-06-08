using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Permiso
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_Permiso(string connectionString)
        {
            connectionString = _connectionString;
        }

        public bool CrearPermiso(Servicio_Permiso permiso)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Permiso", conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Permiso");

                DataRow fila = ds.Tables["Permiso"].NewRow();

                fila["IdRol"] = permiso.IdRol; 
                fila["Nombre"] = permiso.Nombre;

                ds.Tables["Permiso"].Rows.Add(fila);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Permiso");

                return true;
            }
        }

        public DataTable ListarPermisos()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Permiso", conn);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}
