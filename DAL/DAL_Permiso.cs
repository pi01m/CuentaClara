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
            _connectionString = connectionString;
        }

        public bool CrearPermiso(
            string idPermiso,
            string nombre)
        {
            using (SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Permiso",
                _connectionString))
            {
                DataSet ds = new DataSet();

                da.Fill(ds, "Permiso");

                DataRow row =
                    ds.Tables["Permiso"].NewRow();

                row["IdPermiso"] = idPermiso;
                row["Nombre"] = nombre;

                ds.Tables["Permiso"]
                    .Rows.Add(row);

                SqlCommandBuilder cb =
                    new SqlCommandBuilder(da);

                da.Update(ds, "Permiso");

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
        public DataTable ObtenerPermisosPorFamilia(string idFamilia)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT p.IdPermiso, p.Nombre 
          FROM Permiso p
          INNER JOIN Familia_Permiso fp ON p.IdPermiso = fp.IdPermiso
          WHERE fp.IdFamilia = @IdFamilia", _connectionString))
            {
                da.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public DataTable ObtenerPermisosPorRol(string idRol)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // Trae los permisos unidos a la tabla intermedia del rol
                string query = @"
            SELECT p.IdPermiso, p.Nombre 
            FROM Permiso p
            INNER JOIN Rol_Permiso rp ON p.IdPermiso = rp.IdPermiso
            WHERE rp.IdRol = @IdRol";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@IdRol", idRol);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
