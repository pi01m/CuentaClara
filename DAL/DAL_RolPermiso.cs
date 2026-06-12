using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_RolPermiso
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";


        public DAL_RolPermiso(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region
        public bool AsignarPermiso(
            string idRol,
            string idPermiso)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "SELECT * FROM Rol_Permiso",
                        conn);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "Rol_Permiso");

                DataRow fila =
                    ds.Tables["Rol_Permiso"].NewRow();

                fila["IdRol_Permiso"] =
                    Guid.NewGuid().ToString();

                fila["IdRol"] = idRol;
                fila["IdPermiso"] = idPermiso;

                ds.Tables["Rol_Permiso"].Rows.Add(fila);

                SqlCommandBuilder builder =
                    new SqlCommandBuilder(adapter);

                adapter.Update(ds, "Rol_Permiso");

                return true;
            }
        }

        public bool ExistePermiso(
            string idRol,
            string idPermiso)
        {
            using (SqlConnection conn =
                new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        @"SELECT *
                          FROM Rol_Permiso
                          WHERE IdRol=@IdRol
                          AND IdPermiso=@IdPermiso",
                        conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdRol",
                    idRol);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@IdPermiso",
                    idPermiso);

                DataTable tabla = new DataTable();

                adapter.Fill(tabla);

                return tabla.Rows.Count > 0;
            }
        }
        #endregion
    }
}
