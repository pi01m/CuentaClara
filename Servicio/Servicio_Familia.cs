using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_Familia : Servicio_Rol, IVerificable
    {
        private readonly List<Servicio_Rol> _listaPermisos = new List<Servicio_Rol>();

        public List<Servicio_Rol> ListaPermisos => _listaPermisos;

        public Servicio_Familia(string idFamilia, string nombre): base(idFamilia, nombre) { }

        public void AgregarRol(Servicio_Rol item)
        {
            if (_listaPermisos.Any(x => x.IdRol == item.IdRol))
                return;

            _listaPermisos.Add(item);
        }

        public void EliminarRol(Servicio_Rol permiso) => _listaPermisos.Remove(permiso);
        public List<Servicio_Rol> ObtenerHijos() => _listaPermisos;

        public Servicio_Rol BuscarPermiso(string nombre) =>_listaPermisos.Find(p => string.Equals(p.Nombre, nombre, System.StringComparison.OrdinalIgnoreCase));

        public string ObtenerIdentificadorFila()
        {
            return this.IdRol; // Acá usamos el ID porque las familias no tienen Login
        }

        public string ObtenerCadenaParaHash()
        {
            // Si alguien le cambia el nombre a la familia por base de datos, salta el error
            return this.IdRol + this.Nombre;
        }
    }
}
