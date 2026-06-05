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
            
                adapter.Fill(ds, "Usuario");

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

        public int ObtenerIntentos(string login)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Usuario WHERE Login = @Login",
                        conn);

                adapter.SelectCommand.Parameters.Add(
                    new SqlParameter("@Login",
                        SqlDbType.NVarChar, 100)
                    {
                        Value = login
                    });

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Usuario");

                if (ds.Tables["Usuario"].Rows.Count > 0)
                {
                    return Convert.ToInt32(
                        ds.Tables["Usuario"]
                        .Rows[0]["Bloqueo"]);
                }

                return 0;
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
        public bool CrearUsuario(Servicio_Usuario usuario)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Usuario",conn);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Usuario");

                DataRow fila = ds.Tables["Usuario"].NewRow();
                   

                fila["Nombre"] = usuario.Nombre;
                fila["Apellido"] = usuario.Apellido;
                fila["DNI"] = usuario.DNI;
                fila["email"] = usuario.email;
                fila["Login"] = usuario.Login;
                fila["Password"] = usuario.Password;
                fila["Activo"] = usuario.Activo;
                fila["Bloqueo"] = usuario.Bloqueo;

                ds.Tables["Usuario"].Rows.Add(fila);

                SqlCommandBuilder builder =new SqlCommandBuilder(adapter);
                    

                adapter.Update(ds, "Usuario");

                return true;
            }
        }
        public void ModificarUsuario(Servicio_Usuario usuario)
    
        {
            using (SqlConnection conn =new SqlConnection(_connectionString))
                
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Usuario",conn);
   
                DataSet ds =new DataSet();
   
                adapter.Fill(ds, "Usuario");

                DataRow fila =ds.Tables["Usuario"].Select($"DNI = '{usuario.DNI}'")[0];


                fila["Nombre"] =usuario.Nombre;
  
                fila["Apellido"] = usuario.Apellido;

                //fila["email"] = usuario.email;
               

                //fila["Activo"] = usuario.Activo;
                   

                SqlCommandBuilder builder =new SqlCommandBuilder(adapter);
                 
                adapter.Update(ds, "Usuario");

                
            }
        }

        public DataTable ListarUsuariosBloqueados()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
               
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Usuario WHERE Bloqueo >= 3",conn);

                DataTable tabla =new DataTable();

                adapter.Fill(tabla);

                return tabla;
            }
        }


        public bool ExisteUsuario(string login)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Usuario",  conn);
                               

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Usuario");

                foreach (DataRow fila in ds.Tables["Usuario"].Rows)
                {
                    if (fila["Login"].ToString() == login)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
        public DataTable ListarUsuarios()
        {
            using (SqlConnection conn =new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Usuario",  conn);

                DataTable tabla = new DataTable();
                   

                adapter.Fill(tabla);

                return tabla;
            }
        }

        public void ReiniciarIntentos(string login)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Usuario WHERE Login = @Login",conn);
   
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

        public Servicio_Usuario ObtenerUsuario(string dni)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =new SqlDataAdapter("SELECT * FROM Usuario WHERE DNI = @DNI",conn);

                adapter.SelectCommand.Parameters.Add(new SqlParameter("@DNI",SqlDbType.NVarChar, 50){Value = dni});

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Usuario");

                if (ds.Tables["Usuario"].Rows.Count == 0) return null;

                DataRow fila = ds.Tables["Usuario"].Rows[0];

                Servicio_Usuario usuario = new Servicio_Usuario();

                usuario.Nombre = fila["Nombre"].ToString();
                usuario.Apellido = fila["Apellido"].ToString();
                usuario.DNI = fila["DNI"].ToString();
                usuario.email = fila["email"].ToString();
                usuario.Login = fila["Login"].ToString();
                usuario.Password = fila["Password"].ToString();
                usuario.Activo = Convert.ToInt32(fila["Activo"]);
                usuario.Bloqueo = Convert.ToInt32(fila["Bloqueo"]);

                return usuario;
            }
        }
    }
}