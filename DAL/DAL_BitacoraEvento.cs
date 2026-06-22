using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class DAL_BitacoraEvento
    {
        private readonly string _connectionString = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";

        public DAL_BitacoraEvento(string connectionString)
        {
            _connectionString = connectionString;
        }


        public bool GuardarBitacora(Servicio_Bitacora bitacora)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    SqlDataAdapter adapter =
                        new SqlDataAdapter("SELECT * FROM Bitacora WHERE 1 = 0", conn);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Bitacora");

                    DataTable tabla = ds.Tables["Bitacora"];

                    DataRow fila = tabla.NewRow();

                    fila["idEvento"] = bitacora.id_Evento;
                    fila["Evento"] = bitacora.Evento;
                    fila["Login"] = bitacora.Login;
                    fila["Modulo"] = bitacora.Modulo;
                    fila["Fecha"] = bitacora.Fecha.Date;
                    fila["Hora"] = bitacora.Hora;
                    fila["Criticidad"] = bitacora.Criticidad;

                    tabla.Rows.Add(fila);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    adapter.Update(ds, "Bitacora");

                    return true;
                }
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }

        public DataTable ListarBitacora()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter adapter =
                    new SqlDataAdapter("SELECT * FROM Bitacora ORDER BY Fecha DESC, Hora DESC", conn);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
        public DataTable ListarUltimos3Dias()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string sql = @"SELECT * FROM Bitacora WHERE Fecha >= DATEADD(DAY, -3, GETDATE())  ORDER BY Fecha DESC, Hora DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }

        public DataTable FiltrarBitacora(string login, DateTime desde, DateTime hasta, string modulo, string evento, int? criticidad)

        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM Bitacora WHERE 1=1 ");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                if (!string.IsNullOrEmpty(login))
                {
                    sql.Append("AND Login = @Login ");
                    cmd.Parameters.AddWithValue("@Login", login);
                }

                if (!string.IsNullOrEmpty(modulo))
                {
                    sql.Append("AND Modulo = @Modulo ");
                    cmd.Parameters.AddWithValue("@Modulo", modulo);
                }

                if (!string.IsNullOrEmpty(evento))
                {
                    sql.Append("AND Evento LIKE @Evento ");
                    cmd.Parameters.AddWithValue("@Evento", "%" + evento + "%");
                }

                if (criticidad.HasValue)
                {
                    sql.Append("AND Criticidad = @Criticidad ");
                    cmd.Parameters.AddWithValue("@Criticidad", criticidad.Value);
                }

                sql.Append("AND Fecha BETWEEN @Desde AND @Hasta ");

                cmd.Parameters.AddWithValue("@Desde", desde.Date);
                cmd.Parameters.AddWithValue("@Hasta", hasta.Date);

                cmd.CommandText = sql.ToString();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adapter.Fill(tabla);

                return tabla;
            }
        }
    }
}