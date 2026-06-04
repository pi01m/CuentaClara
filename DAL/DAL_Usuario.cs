using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_Usuario
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_Usuario(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public Servicio_Usuario AutenticarUsuario(string login, string hash)
        {
            const string sql =
                "SELECT Nombre, Apellido, DNI, email, Login, Password, " +
                "       Activo, Bloqueo " +
                "FROM   Usuario " +
                "WHERE  Login    = @Login " +
                "AND    Password = @Password";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 100) { Value = login });
                cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 256) { Value = hash });

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                conn.Open();
                adapter.Fill(ds, "Usuario");
                conn.Close();

                if (ds.Tables["Usuario"].Rows.Count != 1)
                    return null;

                DataRow row = ds.Tables["Usuario"].Rows[0];

                return new Servicio_Usuario
                {
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    DNI = row["DNI"].ToString(),
                    email = row["email"].ToString(),
                    Login = row["Login"].ToString(),
                    Password = row["Password"].ToString(),
                    
                    Activo = Convert.ToInt32(row["Activo"]),
                    Bloqueo = Convert.ToInt32(row["Bloqueo"]),
                    //IdFamiliaRol = new Servicio_FamiliaRol(row["IdFamiliaRol"].ToString(), "")
                };
            }
        }

        public void IncrementarIntentos(string login)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Usuario WHERE Login = @Login",
                        conn);

                adapter.SelectCommand.Parameters.Add(
                    new SqlParameter("@Login", SqlDbType.NVarChar, 100)
                    {
                        Value = login
                    });

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Usuario");

                if (ds.Tables["Usuario"].Rows.Count > 0)
                {
                    DataRow fila = ds.Tables["Usuario"].Rows[0];

                    fila["Bloqueo"] =
                        Convert.ToInt32(fila["Bloqueo"]) + 1;

                    SqlCommandBuilder builder =
                        new SqlCommandBuilder(adapter);

                    adapter.Update(ds, "Usuario");
                }
            }
        }

        public void ReiniciarIntentos(string login)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Usuario WHERE Login = @Login",
                        conn);

                adapter.SelectCommand.Parameters.Add(
                    new SqlParameter("@Login", SqlDbType.NVarChar, 100)
                    {
                        Value = login
                    });

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Usuario");

                if (ds.Tables["Usuario"].Rows.Count > 0)
                {
                    DataRow fila = ds.Tables["Usuario"].Rows[0];

                    fila["Bloqueo"] = 0;

                    SqlCommandBuilder builder =
                        new SqlCommandBuilder(adapter);

                    adapter.Update(ds, "Usuario");
                }
            }
        }
    }
}