using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Permiso
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_Permiso(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool CrearPermiso(string idPermiso,string nombre)
  
        {
            using (SqlDataAdapter da =new SqlDataAdapter("SELECT * FROM Permiso",_connectionString))
  
            {
                DataSet ds = new DataSet();

                da.Fill(ds, "Permiso");

                DataRow row =ds.Tables["Permiso"].NewRow();
                    

                row["IdPermiso"] = idPermiso;
                row["Nombre"] = nombre;

                ds.Tables["Permiso"].Rows.Add(row);
                    

                SqlCommandBuilder cb =new SqlCommandBuilder(da);

                da.Update(ds, "Permiso");

                return true;
            }
        }

        public List<Servicio_Permiso> ListarPermisos()
        {
            List<Servicio_Permiso> lista = new List<Servicio_Permiso>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Permiso", conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Servicio_Permiso(row["IdPermiso"].ToString(), row["Nombre"].ToString()));
                    }
                }
            }
            return lista;
        }

        public List<Servicio_Permiso> ObtenerPermisosPorFamilia(string idFamilia)
        {
            List<Servicio_Permiso> lista = new List<Servicio_Permiso>();
            using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT p.IdPermiso, p.Nombre FROM Permiso p INNER JOIN Familia_Permiso fp ON p.IdPermiso = fp.IdPermiso WHERE fp.IdFamilia = @IdFamilia", _connectionString))
            {
                da.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new Servicio_Permiso(row["IdPermiso"].ToString(), row["Nombre"].ToString()));
                }
            }
            return lista;
        }

        public List<Servicio_Permiso> ObtenerPermisosPorRol(string idRol)
        {
            List<Servicio_Permiso> lista = new List<Servicio_Permiso>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = @"SELECT p.IdPermiso, p.Nombre FROM Permiso p INNER JOIN Rol_Permiso rp ON p.IdPermiso = rp.IdPermiso WHERE rp.IdRol = @IdRol";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@IdRol", idRol);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Servicio_Permiso(row["IdPermiso"].ToString(), row["Nombre"].ToString()));
                    }
                }
            }
            return lista;
        }
    }
}
