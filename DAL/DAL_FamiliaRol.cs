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

        #region nuevo
         
        public void EliminarPorFamilia(string idFamilia)
        {
            using (SqlConnection conn =
            new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                new SqlDataAdapter(
                "SELECT * FROM Familia_Rol WHERE IdFamilia=@IdFamilia",
                conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdFamilia",
                    idFamilia);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Familia_Rol");

                foreach (DataRow fila in ds.Tables["Familia_Rol"].Rows)
                {
                    fila.Delete();
                }

                SqlCommandBuilder builder =
                    new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia_Rol");
            }

        }

        public bool TienePermisoPorFamilia( string idRol, string idPermiso)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                    @"SELECT *
              FROM Familia_Rol fr
              INNER JOIN Familia_Permiso fp
              ON fr.IdFamilia = fp.IdFamilia
              WHERE fr.IdRol = @IdRol
              AND fp.IdPermiso = @IdPermiso",
                    conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdRol",
                    idRol);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdPermiso",
                    idPermiso);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                return tabla.Rows.Count > 0;
            }
        }

        public bool ExisteFamiliaEnRol(string idRol, string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT *
              FROM Familia_Rol
              WHERE IdRol = @Rol
              AND IdFamilia = @Fam",
                    conn);

                da.SelectCommand.Parameters.AddWithValue("@Rol", idRol);
                da.SelectCommand.Parameters.AddWithValue("@Fam", idFamilia);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0;
            }
        }

       
        #endregion
    }
}
