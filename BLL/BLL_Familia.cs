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

        private DAL_Familia dal;
        private DAL_FamiliaRol dalFR;
        private DAL_FamiliaPermiso dalFP;
        private DAL_FamiliaFamilia dalFF;
        private DAL_Rol dalRol;
        private DAL_Permiso dalPermiso;

        public BLL_Familia()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            dal = new DAL_Familia(conn);
            dalFR = new DAL_FamiliaRol(conn);
            dalFP = new DAL_FamiliaPermiso(conn);
            dalFF = new DAL_FamiliaFamilia(conn);
            dalRol = new DAL_Rol(conn);
            dalPermiso = new DAL_Permiso(conn);
        }

        public void CrearFamilia(Servicio_Familia f)
        {
            if (string.IsNullOrWhiteSpace(f.Nombre))
                throw new Exception("Nombre requerido");

            dal.CrearFamilia(f);
        }
        public void ModificarFamilia(Servicio_Familia f)
        {
            if (string.IsNullOrWhiteSpace(f.Nombre))
                throw new Exception("Nombre requerido");

            dal.ModificarFamilia(f);
        }
        public void EliminarFamilia(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new Exception("ID requerido");

            dal.EliminarFamilia(id);
        }
        public void AsignarRol(string f, string r) => dalFR.AsignarRol(f, r);
        //public void AsignarPermiso(string f, string p) => dalFP.AsignarPermiso(f, p);
        //public void AsignarSubFamilia(string p, string h) => dalFF.AsignarSubFamilia(p, h);

        public DataTable ListarRoles() => dalRol.ListarRoles();
        public DataTable ListarPermisos() => dalPermiso.ListarPermisos();

        public Servicio_Familia ObtenerFamiliaCompleta(string id)
        {
            var fam = new Servicio_Familia(id, "Familia");

            // SUBFAMILIAS
            var sub = dalFF.ObtenerSubFamilias(id);
            foreach (DataRow s in sub.Rows)
            {
                fam.AgregarRol(
                    new Servicio_Familia(
                        s["IdFamilia"].ToString(),
                        s["Nombre"].ToString()
                    )
                );
            }

            return fam;
        }
        public DataTable ListarFamilias()
        {
            return dal.ListarFamilias();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////7
        #region nuevo 

        public bool ExisteNombre(string nombre)
        {
            return dal.ExisteNombre(nombre);
        }

        public void Guardar(Servicio_Familia familia)
        {
            if (string.IsNullOrWhiteSpace(familia.Nombre))
                throw new Exception("Nombre requerido");

            dal.Guardar(familia);
        }

        public void Eliminar(string idFamilia)
        {
            if (string.IsNullOrWhiteSpace(idFamilia))
                throw new Exception("Debe seleccionar una familia.");

            dalFR.EliminarPorFamilia(idFamilia);

            dalFP.EliminarPorFamilia(idFamilia);

            dalFF.EliminarPorFamilia(idFamilia);

            bool resultado = dal.Eliminar(idFamilia);

            if (!resultado)
                throw new Exception("No se encontró la familia.");
        }
        public void Modificar(Servicio_Familia familia)
        {
            if (string.IsNullOrWhiteSpace(familia.Nombre))
                throw new Exception("Nombre requerido.");

            dal.Modificar(familia);
        }

        public bool TienePermiso( string idFamilia,string idPermiso)
        {
            if (dalFP.ExistePermiso(
        idFamilia,
        idPermiso))
            {
                return true;
            }

            if (dalFF.TienePermisoEnSubFamilias(
                idFamilia,
                idPermiso))
            {
                return true;
            }

            return false;
        }

        public void AsignarPermiso(string idFamilia,string idPermiso)
        {   
            if (string.IsNullOrWhiteSpace(idFamilia))throw new Exception("Seleccione una familia.");
                

            if (string.IsNullOrWhiteSpace(idPermiso))  throw new Exception("Seleccione un permiso.");
              

            if (dalFP.ExistePermiso(idFamilia,idPermiso))
            {
                throw new Exception( "La familia ya posee ese permiso.");
                   
            }

            dalFP.AsignarPermiso(idFamilia,idPermiso);
        }

        

    
        public void AsignarSubFamilia(string idPadre, string idHija)
        {
            if (string.IsNullOrWhiteSpace(idPadre))
                throw new Exception("Seleccione familia padre.");

            if (string.IsNullOrWhiteSpace(idHija))
                throw new Exception("Seleccione familia hija.");

            if (idPadre == idHija)
                throw new Exception("Una familia no puede asignarse a sí misma.");

           

            // evitar duplicado
            if (dalFF.ExisteRelacion(idPadre, idHija))
                throw new Exception("Esta relación ya existe.");

            // evitar ciclos (muy importante)
            if (dalFF.CreaCiclo(idPadre, idHija))
                throw new Exception("No se puede crear una relación circular.");

            dalFF.AsignarSubFamilia(idPadre, idHija);
        }


        public DataTable ObtenerSubFamilias(string idFamilia)
        {
            return dalFF.ObtenerSubFamilias(idFamilia);
        }
        public DataTable ObtenerFamilias()
        {
            return dal.ListarFamilias();
        }
        #endregion
    }
}
