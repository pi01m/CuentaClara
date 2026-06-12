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
    public class DAL_Rol
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_Rol(string connectionString)
        {
          _connectionString= connectionString;
        }

        public bool CrearRol(Servicio_Rol rol)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Rol", conn);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Rol");

                DataRow fila = ds.Tables["Rol"].NewRow();

                fila["IdRol"] = rol.IdRol;
                fila["Nombre"] = rol.Nombre;

                ds.Tables["Rol"].Rows.Add(fila);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Rol");

                return true;
            }
        }

        public DataTable ListarRoles()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Rol", conn);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }

        public DataTable ObtenerFamiliasPorRol(string idRol)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql = @"
            SELECT f.IdFamilia, f.Nombre
            FROM Familia f
            INNER JOIN Familia_Rol fr ON fr.IdFamilia = f.IdFamilia
            WHERE fr.IdRol = @IdRol";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@IdRol", idRol);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}
