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
            const string sql =
                "INSERT INTO Bitacora " +
                "       (IdEvento, Evento, Descripcion, Usuario, Login, Modulo, Fecha, Hora, Criticidad) " +
                "VALUES (@IdEvento, @Evento, @Descripcion, @Usuario, @Login, @Modulo, @Fecha, @Hora, @Criticidad)";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new SqlParameter("@IdEvento", SqlDbType.NVarChar, 50) { Value = bitacora.id_Evento });
                cmd.Parameters.Add(new SqlParameter("@Evento", SqlDbType.NVarChar, 100) { Value = bitacora.Evento });
         
                cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.NVarChar, 100) { Value = bitacora.Usuario });
                cmd.Parameters.Add(new SqlParameter("@Login", SqlDbType.NVarChar, 100) { Value = bitacora.Login });
                cmd.Parameters.Add(new SqlParameter("@Modulo", SqlDbType.NVarChar, 100) { Value = bitacora.Modulo });
                cmd.Parameters.Add(new SqlParameter("@Fecha", SqlDbType.Date) { Value = bitacora.Fecha.Date });
                cmd.Parameters.Add(new SqlParameter("@Hora", SqlDbType.DateTime) { Value = bitacora.Hora });
                cmd.Parameters.Add(new SqlParameter("@Criticidad", SqlDbType.Int) { Value = bitacora.Criticidad });

                conn.Open();
                int filas = cmd.ExecuteNonQuery();
                conn.Close();

                return filas > 0;
            }
        }
    }
}