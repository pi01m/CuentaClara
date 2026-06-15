using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_Familia
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_Familia(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool CrearFamilia(Servicio_Familia familia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Familia", conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Familia");

                DataRow fila = ds.Tables["Familia"].NewRow();

                fila["IdFamilia"] = familia.IdRol;
                fila["Nombre"] = familia.Nombre;

                ds.Tables["Familia"].Rows.Add(fila);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia");

                return true;
            }
        }


        public DataTable ListarFamilias()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Familia", conn);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }

        #region NUEVO


        public bool ExisteNombre(string nombre)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Familia",
                        conn);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                foreach (DataRow fila in tabla.Rows)
                {
                    if (fila["Nombre"].ToString()
                        .ToUpper() == nombre.ToUpper())
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public bool Guardar(
             string idFamilia,
             string nombre)
        {
            using (SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Familia",
                _connectionString))
            {
                DataSet ds = new DataSet();

                da.Fill(ds, "Familia");

                DataRow row =
                    ds.Tables["Familia"].NewRow();

                row["IdFamilia"] = idFamilia;
                row["Nombre"] = nombre;

                ds.Tables["Familia"]
                    .Rows.Add(row);

                SqlCommandBuilder cb =
                    new SqlCommandBuilder(da);

                da.Update(ds, "Familia");

                return true;
            }
        }

        public bool AsignarPermiso(
           string idFamilia,
           string idPermiso)
        {
            using (SqlDataAdapter da =
                new SqlDataAdapter(
                "SELECT * FROM Familia_Permiso",
                _connectionString))
            {
                DataSet ds = new DataSet();

                da.Fill(ds, "Familia_Permiso");

                DataRow row =
                    ds.Tables["Familia_Permiso"]
                    .NewRow();

                row["IdFamilia_Permiso"] =
                    Guid.NewGuid().ToString();

                row["IdFamilia"] = idFamilia;
                row["IdPermiso"] = idPermiso;

                ds.Tables["Familia_Permiso"]
                    .Rows.Add(row);

                SqlCommandBuilder cb =
                    new SqlCommandBuilder(da);

                da.Update(ds, "Familia_Permiso");

                return true;
            }
        }

        public bool AsignarSubFamilia(
            string padre,
            string hija)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Familia", _connectionString))
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Familia");

                DataRow row = ds.Tables["Familia_Familia"].NewRow();

                // Generamos un nuevo ID único para esta relación (La Clave Primaria)
                row["IdFamilia_Familia"] = Guid.NewGuid().ToString();

                // Usamos tus nuevas columnas
                row["IdFamiliaPadre"] = padre;
                row["IdFamiliaHija"] = hija;

                ds.Tables["Familia_Familia"].Rows.Add(row);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "Familia_Familia");

                return true;
            }
        }
        public DataTable ObtenerSubFamilias(
            string idFamilia)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(
        @"SELECT f.*
          FROM Familia f
          INNER JOIN Familia_Familia ff
             ON f.IdFamilia = ff.IdFamiliaHija
          WHERE ff.IdFamiliaPadre = @Familia",
        _connectionString))
            {
                da.SelectCommand.Parameters.AddWithValue("@Familia", idFamilia);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
        public void DesasignarPermiso(string idFamilia, string idPermiso)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Permiso WHERE IdFamilia = @IdFamilia AND IdPermiso = @IdPermiso", cn);
                da.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);
                da.SelectCommand.Parameters.AddWithValue("@IdPermiso", idPermiso);

                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Permiso");

                if (ds.Tables["Familia_Permiso"].Rows.Count > 0)
                {
                    ds.Tables["Familia_Permiso"].Rows[0].Delete();

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Familia_Permiso");
                }
            }
        }

        public void DesasignarSubFamilia(string idPadre, string idHija)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
              
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Familia WHERE IdFamiliaPadre = @IdPadre AND IdFamiliaHija = @IdHija", cn);
                da.SelectCommand.Parameters.AddWithValue("@IdPadre", idPadre);
                da.SelectCommand.Parameters.AddWithValue("@IdHija", idHija);

                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Familia");

                if (ds.Tables["Familia_Familia"].Rows.Count > 0)
                {
                    ds.Tables["Familia_Familia"].Rows[0].Delete();

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Familia_Familia");
                }
            }
        }

        public bool Eliminar(string idFamilia)
        {
            using (SqlConnection conn =
            new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                new SqlDataAdapter(
                "SELECT * FROM Familia WHERE IdFamilia = @IdFamilia",
                conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdFamilia",
                    idFamilia);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Familia");

                if (ds.Tables["Familia"].Rows.Count == 0)
                    return false;

                ds.Tables["Familia"].Rows[0].Delete();

                SqlCommandBuilder builder =
                    new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia");

                return true;
            }

        }

        public bool Modificar(Servicio_Familia familia)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Familia WHERE IdFamilia = @IdFamilia",
                        conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdFamilia",
                    familia.IdRol);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Familia");

                if (ds.Tables["Familia"].Rows.Count == 0)
                    return false;

                DataRow fila =
                    ds.Tables["Familia"].Rows[0];

                fila["Nombre"] = familia.Nombre;

                SqlCommandBuilder builder =
                    new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia");

                return true;
            }
        }

        #endregion

    }
}