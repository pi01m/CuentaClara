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

        public bool CrearFamilia(string nombre)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT * FROM Familia WHERE 1 = 0", conn);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Familia");

                DataTable tabla = ds.Tables["Familia"];

                DataRow fila = tabla.NewRow();

                fila["Nombre"] = nombre;

                tabla.Rows.Add(fila);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia");

                return true;
            }
        }

        public bool EliminarFamilia(int idFamilia)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Familia WHERE IdFamilia = @Id",conn);

                adapter.SelectCommand.Parameters.AddWithValue("@Id", idFamilia);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Familia");

                if (ds.Tables["Familia"].Rows.Count == 0) return false;
                   

                ds.Tables["Familia"].Rows[0].Delete();

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Familia");

                return true;
            }
        }
        public DataTable ListarFamilias()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Familia",
                        conn);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                return tabla;
            }
        }

    }
}