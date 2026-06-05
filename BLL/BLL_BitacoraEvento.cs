using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BLL
{
    internal class BLL_BitacoraEvento
    {
        private readonly DAL_BitacoraEvento _dal;

        public BLL_BitacoraEvento(DAL_BitacoraEvento dal)
        {
            _dal = dal;
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
                Hora = DateTime.Now
            };

            return _dal.GuardarBitacora(bitacora);
        }
    }
}
