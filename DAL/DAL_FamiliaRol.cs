using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_FamiliaRol
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";
        public DAL_FamiliaRol(string conn)
        {
            _connectionString = conn;
        }
        public bool AsignarRol(string idFam, string idRol)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Rol", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Rol");

                DataRow row = ds.Tables["Familia_Rol"].NewRow();
                row["IdFamilia"] = idFam;
                row["IdRol"] = idRol;
                row["IdFamilia_Rol"] = Guid.NewGuid().ToString();

                ds.Tables["Familia_Rol"].Rows.Add(row);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "Familia_Rol");

                return true;
            }
        }

        public DataTable ObtenerRolesPorFamilia(string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql =
                @"SELECT r.IdRol, r.Nombre
          FROM Rol r
          INNER JOIN Familia_Rol fr ON fr.IdRol = r.IdRol
          WHERE fr.IdFamilia = @IdFamilia";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}
