using System;
using System.Collections.Generic;
using System.Text;

namespace Servicio
{
    public class Servicio_FamiliaRol : Servicio_Permiso
    {
        private readonly List<Servicio_Permiso> _listaPermisos = new List<Servicio_Permiso>();

        public List<Servicio_Permiso> ListaPermisos => _listaPermisos;

        public Servicio_FamiliaRol(string idFamilia, string nombre)
            : base(idFamilia, nombre) { }

        public void AgregarPermiso(Servicio_Permiso permiso) => _listaPermisos.Add(permiso);
        public void EliminarPermiso(Servicio_Permiso permiso) => _listaPermisos.Remove(permiso);
        public List<Servicio_Permiso> ObtenerHijos() => _listaPermisos;

        public Servicio_Permiso BuscarPermiso(string nombre) =>
            _listaPermisos.Find(p => string.Equals(p.Nombre, nombre, System.StringComparison.OrdinalIgnoreCase));

    }
}
