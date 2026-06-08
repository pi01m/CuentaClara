using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_FamiliaFamilia
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";
        public DAL_FamiliaFamilia(string connectionString)
        {
            connectionString = _connectionString;
        }
        public bool AsignarSubFamilia(string padre, string hijo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Familia", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Familia");

                DataRow row = ds.Tables["Familia_Familia"].NewRow();
                row["IdFamilia_Familia"] =
                row["IdFamilia"] = hijo;

                ds.Tables["Familia_Familia"].Rows.Add(row);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "Familia_Familia");

                return true;
            }
        }

        public DataTable ObtenerSubFamilias(string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql =
                @"SELECT f.IdFamilia, f.Nombre
          FROM Familia f
          INNER JOIN Familia_Familia ff ON ff.IdFamilia = f.IdFamilia
          WHERE ff.IdFamilia = @IdFamilia";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}