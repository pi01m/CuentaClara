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
        public bool ModificarFamilia(Servicio_Familia familia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Familia WHERE IdFamilia = @IdFamilia", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@IdFamilia", familia.IdRol);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Familia");

                if (ds.Tables["Familia"].Rows.Count == 0)
                    return false;

                DataRow fila = ds.Tables["Familia"].Rows[0];

                fila["Nombre"] = familia.Nombre;

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Familia");

                return true;
            }
        }
        public bool EliminarFamilia(string idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Familia WHERE IdFamilia = @IdFamilia", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Id", idFamilia);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Familia");

                if (ds.Tables["Familia"].Rows.Count == 0)
                    return false;

                DataRow fila = ds.Tables["Familia"].Rows[0];
                fila.Delete();

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

    }
}