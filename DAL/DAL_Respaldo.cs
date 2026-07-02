using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Respaldo
    {
        private readonly string connStr = $"Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Trust Server Certificate=True";
        public DAL_Respaldo(string connectionString)
        {
            connStr = connectionString;
        }
        public void EjecutarBackup(string rutaCompleta)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // Usamos un parámetro @path para evitar inyección en la ruta
                string sql = "BACKUP DATABASE [BD_CuentaClara] TO DISK = @path";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@path", rutaCompleta);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void EjecutarRestore(string rutaCompleta)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                // El comando RESTORE no acepta parámetros para el DISK.
                // La seguridad aquí se garantiza porque la BLL ya validó que es un archivo real.
                string sql = $@"
                ALTER DATABASE [BD_CuentaClara] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [BD_CuentaClara] FROM DISK = '{rutaCompleta}' WITH REPLACE;
                ALTER DATABASE [BD_CuentaClara] SET MULTI_USER;";

                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
