using Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;

namespace BLL
{
    public class BLL_FamiliaRol
    {
        private readonly DAL_FamiliaRol _dalFamiliaPermiso;
        private List<Servicio_Permiso> _permisos = new List<Servicio_Permiso>();

        public BLL_FamiliaRol(DAL_FamiliaRol dalFamiliaPermiso)
        {
            _dalFamiliaPermiso = dalFamiliaPermiso;
        }

        
        public List<Servicio_Permiso> ListarPermisos(Servicio_Usuario usuario)
        {
            _permisos = _dalFamiliaPermiso.ListarPermisos(usuario);
            return _permisos;
        }
    }
}
