using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL
{
    public class BLL_Familia
    {
        private DAL_Familia _dalFamilia;
        private BLL_BitacoraEvento _bitacora = new BLL_BitacoraEvento();
        
        public BLL_Familia()
        {
            string connStr = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            _dalFamilia = new DAL_Familia(connStr);
        }

  
        
    }
}

