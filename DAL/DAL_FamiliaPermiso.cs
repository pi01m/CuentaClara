using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_FamiliaPermiso
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_FamiliaPermiso(string connectionString)
        {
            connectionString = _connectionString;
        }

        public bool AsignarPermiso(string idFam, string idPermiso)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Permiso", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Permiso");

                DataRow row = ds.Tables["Familia_Permiso"].NewRow();
                row["IdFamilia"] = idFam;
                row["IdPermiso"] = idPermiso;
                row["IdFamilia_Permiso"] = Guid.NewGuid().ToString();

                ds.Tables["Familia_Permiso"].Rows.Add(row);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "Familia_Permiso");

                return true;
            }
        }

        public DataTable ObtenerPermisosPorFamilia(string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql =
                @"SELECT p.IdPermiso, p.Nombre
          FROM Permiso p
          INNER JOIN Familia_Permiso fp ON fp.IdPermiso = p.IdPermiso
          WHERE fp.IdFamilia = @IdFamilia";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}
