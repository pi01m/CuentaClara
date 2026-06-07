using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace BLL
{
    public class BLL_BitacoraEvento
    {
        private  DAL_BitacoraEvento _dal;

        public BLL_BitacoraEvento()
        {
            string connStr = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            _dal = new DAL_BitacoraEvento(connStr);
        }

        public bool RegistrarBitacora(string evento,string login,string modulo,int criticidad){
            Servicio_Bitacora bitacora = new Servicio_Bitacora
            {
                id_Evento = Guid.NewGuid().ToString(), //aleatorioo
                Evento = evento,
                Login = login,
                Modulo = modulo,
                Criticidad = criticidad,
                Fecha = DateTime.Now.Date,
                Hora = DateTime.Now.ToString("HH:mm:ss")
            };

            return _dal.GuardarBitacora(bitacora);
        }

        public DataTable ListarBitacora()
        {
            return _dal.ListarBitacora();
        }

        public DataTable ListarUltimos3Dias()
        {
            return _dal.ListarUltimos3Dias();
        }

        public DataTable FiltrarBitacora(string login, DateTime desde, DateTime hasta,string modulo, string evento, int? criticidad)
                                 
        {
            return _dal.FiltrarBitacora(login, desde, hasta, modulo, evento, criticidad);
        }


    }
}
