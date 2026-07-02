using DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Respaldo
    {
        private DAL_Respaldo dal;
        private BLL_BitacoraEvento _bitacora;
        public  BLL_Respaldo()
        {
            string connStr = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            dal = new DAL_Respaldo(connStr);
            _bitacora = new BLL_BitacoraEvento();
        }


        public void HacerBackup(string carpetaDestino)
        {
            string nombreArchivo = $"Backup_CuentaClara_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
            string rutaCompleta = System.IO.Path.Combine(carpetaDestino, nombreArchivo);

        
            dal.EjecutarBackup(rutaCompleta);
            _bitacora.RegistrarBitacora("Backup exitoso", "Sistema", "Administración", 2);
        }

        public void HacerRestore(string rutaArchivo)
        {
     
            if (!System.IO.File.Exists(rutaArchivo)) throw new Exception("Archivo no encontrado.");

            dal.EjecutarRestore(rutaArchivo);
            _bitacora.RegistrarBitacora("Restauración de base de datos realizada", "Sistema", "Seguridad", 3);
        }

        public void EjecutarRestore(string rutaCompleta)
        {
            string connStrMaster = "Data Source=.;Initial Catalog=master;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection cn = new SqlConnection(connStrMaster))
            {
                cn.Open();

                
                string sqlSetSingleUser = @"ALTER DATABASE [BD_CuentaClara] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                new SqlCommand(sqlSetSingleUser, cn).ExecuteNonQuery();

                
                string sqlRestore = $@"RESTORE DATABASE [BD_CuentaClara] FROM DISK = '{rutaCompleta}' WITH REPLACE";
                new SqlCommand(sqlRestore, cn).ExecuteNonQuery();

                
                string sqlSetMultiUser = @"ALTER DATABASE [BD_CuentaClara] SET MULTI_USER";
                new SqlCommand(sqlSetMultiUser, cn).ExecuteNonQuery();
            }
        }
    }
}
