using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_Familia : Servicio_Perfil
    {
        private readonly List<Servicio_Perfil> _listaPermisos = new List<Servicio_Perfil>();

        public List<Servicio_Perfil> ListaPermisos => _listaPermisos;

        public Servicio_Familia(string idFamilia, string nombre): base(idFamilia, nombre) { }

        public void AgregarPermiso(Servicio_Perfil permiso) => _listaPermisos.Add(permiso);
        public void EliminarPermiso(Servicio_Perfil permiso) => _listaPermisos.Remove(permiso);
        public List<Servicio_Perfil> ObtenerHijos() => _listaPermisos;

        public Servicio_Perfil BuscarPermiso(string nombre) =>_listaPermisos.Find(p => string.Equals(p.Nombre, nombre, System.StringComparison.OrdinalIgnoreCase));

    }
}
