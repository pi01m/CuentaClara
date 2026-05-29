using DAL;
using Servicio;
using System;
using System.Collections.Generic;
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
        private Servicio_Bitacora _CrearBitacora(int criticidad, string descripcion, string evento,
                                                  DateTime fecha, DateTime hora, string idEvento,
                                                  string login, string modulo, string usuario)
        {
            return new Servicio_Bitacora
            {
                Criticidad = criticidad,

                Evento = evento,
                Fecha = fecha,
                Hora = hora,
                id_Evento = idEvento,
                Login = login,
                Modulo = modulo,
                Usuario = usuario
            };
        }


        public bool RegistrarBitacora(string evento, DateTime fechaHora)
        {
            Servicio_Usuario usuarioSesion = SessionManager.GetInstancia().GetUsuarioActual();

            Servicio_Bitacora bitacora = _CrearBitacora(
                criticidad: 1,
                descripcion: "Ingreso exitoso al sistema",
                evento: evento,
                fecha: fechaHora.Date,
                hora: fechaHora,
                idEvento: Guid.NewGuid().ToString(),
                login: usuarioSesion?.Login ?? string.Empty,
                modulo: "Seguridad",
                usuario: usuarioSesion?.Nombre ?? string.Empty
            );

            return _dal.GuardarBitacora(bitacora);

        }
    }
}
