using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_FamiliaRol
    {
        private string _connectionString = $"Data Source=.;Integrated Security=True;Trust Server Certificate=True";

        public DAL_FamiliaRol(string connectionString)
        {
            _connectionString = connectionString;
        }

        
        public List<Servicio_Permiso> ListarPermisos(Servicio_Usuario usuario)
        {
            List<Servicio_Permiso> permisos = new List<Servicio_Permiso>();

            const string sql =
                "SELECT p.IdPermiso, p.Nombre " +
                "FROM   Permisos p " +
                "INNER JOIN FamiliaRolPermisos frp ON p.IdPermiso    = frp.IdPermiso " +
                "INNER JOIN Usuarios           u   ON u.IdFamiliaRol = frp.IdFamiliaRol " +
                "WHERE  u.Login = @Login";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 100) { Value = usuario.Login });

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                conn.Open();
                adapter.Fill(ds, "Permisos");
                conn.Close();

                foreach (DataRow row in ds.Tables["Permisos"].Rows)
                    permisos.Add(new Servicio_PermisoSimple(row["IdPermiso"].ToString(), row["Nombre"].ToString()));
            }

            return permisos;
        }
    }
}