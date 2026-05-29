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
        private string _connectionString = $"Data Source=.;Integrated Security=True;Trust Server Certificate=True";

        public DAL_Usuario(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public Servicio_Usuario AutenticarUsuario(string login, string hash)
        {
            const string sql =
                "SELECT Nombre, Apellido, DNI, Email, Login, Password, " +
                "       Estado, Activo, Bloqueo, IdFamiliaRol " +
                "FROM   Usuarios " +
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
                adapter.Fill(ds, "Usuarios");
                conn.Close();

                if (ds.Tables["Usuarios"].Rows.Count != 1)
                    return null;

                DataRow row = ds.Tables["Usuarios"].Rows[0];

                return new Servicio_Usuario
                {
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    DNI = row["DNI"].ToString(),
                    email = row["Email"].ToString(),
                    Login = row["Login"].ToString(),
                    Password = row["Password"].ToString(),
                    
                    Activo = Convert.ToInt32(row["Activo"]),
                    Bloqueo = Convert.ToInt32(row["Bloqueo"]),
                    IdFamiliaRol = new Servicio_FamiliaRol(row["IdFamiliaRol"].ToString(), "")
                };
            }
        }

        public void IncrementarIntentos(string login)
        {
            const string sql = "UPDATE Usuarios SET Bloqueo = Bloqueo + 1 WHERE Login = @Login";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 100) { Value = login });
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void ReiniciarIntentos(string login)
        {
            const string sql = "UPDATE Usuarios SET Bloqueo = 0 WHERE Login = @Login";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 100) { Value = login });
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}