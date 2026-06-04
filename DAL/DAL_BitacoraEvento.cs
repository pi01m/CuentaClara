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
    }
}