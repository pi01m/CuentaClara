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
            _connectionString = connectionString;
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

        #region

        public bool EliminarPorFamilia(string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT * 
              FROM Familia_Familia
              WHERE IdFamiliaPadre = @IdFamilia
                 OR IdFamiliaHija = @IdFamilia",
                    conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdFamilia",
                    idFamilia);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Familia_Familia");

                foreach (DataRow fila in ds.Tables["Familia_Familia"].Rows)
                {
                    fila.Delete();
                }

                SqlCommandBuilder builder =
                    new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia_Familia");

                return true;
            }
        }

        public bool TienePermisoEnSubFamilias(
    string idFamilia,
    string idPermiso)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                    @"SELECT *
              FROM Familia_Familia ff
              INNER JOIN Familia_Permiso fp
              ON ff.IdFamiliaHija = fp.IdFamilia
              WHERE ff.IdFamiliaPadre = @IdFamilia
              AND fp.IdPermiso = @IdPermiso",
                    conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdFamilia",
                    idFamilia);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdPermiso",
                    idPermiso);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                return tabla.Rows.Count > 0;
            }
        }

        public bool ExisteRelacion(string idPadre, string idHija)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT *
              FROM Familia_Familia
              WHERE IdFamiliaPadre = @Padre
              AND IdFamiliaHija = @Hija",
                    conn);

                da.SelectCommand.Parameters.AddWithValue("@Padre", idPadre);
                da.SelectCommand.Parameters.AddWithValue("@Hija", idHija);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt.Rows.Count > 0;
            }
        }

        public bool CreaCiclo(string idPadre, string idHija)
        {
            // Caso base: no puede ser la misma
            if (idPadre == idHija)
                return true;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT IdFamiliaPadre, IdFamiliaHija
              FROM Familia_Familia",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // DFS simple en memoria
                return TieneCamino(dt, idHija, idPadre);
            }
        }

        private bool TieneCamino(DataTable dt, string actual, string objetivo)
        {
            foreach (DataRow row in dt.Rows)
            {
                string padre = row["IdFamiliaPadre"].ToString();
                string hija = row["IdFamiliaHija"].ToString();

                if (padre == actual)
                {
                    if (hija == objetivo)
                        return true;

                    if (TieneCamino(dt, hija, objetivo))
                        return true;
                }
            }

            return false;
        }

        public bool FamiliaYaAsignadaIndirectamenteARol(string idRol, string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                // 1. familias directas del rol
                SqlDataAdapter daRol = new SqlDataAdapter(
                    @"SELECT IdFamilia
              FROM Familia_Rol
              WHERE IdRol = @Rol",
                    conn);

                daRol.SelectCommand.Parameters.AddWithValue("@Rol", idRol);

                DataTable familiasRol = new DataTable();
                daRol.Fill(familiasRol);

                // 2. todas las relaciones familia-familia
                SqlDataAdapter daRel = new SqlDataAdapter(
                    @"SELECT IdFamiliaPadre, IdFamiliaHija
              FROM Familia_Familia",
                    conn);

                DataTable relaciones = new DataTable();
                daRel.Fill(relaciones);

                // 3. por cada familia del rol, ver si contiene la nueva
                foreach (DataRow f in familiasRol.Rows)
                {
                    string idFamRol = f["IdFamilia"].ToString();

                    if (EsDescendiente(relaciones, idFamRol, idFamilia))
                        return true;
                }

                return false;
            }
        }

        private bool EsDescendiente(DataTable relaciones, string actual, string objetivo)
        {
            foreach (DataRow row in relaciones.Rows)
            {
                string padre = row["IdFamiliaPadre"].ToString();
                string hija = row["IdFamiliaHija"].ToString();

                if (padre == actual)
                {
                    if (hija == objetivo)
                        return true;

                    if (EsDescendiente(relaciones, hija, objetivo))
                        return true;
                }
            }

            return false;
        }
        #endregion
    }
}