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
        
        private DAL_Rol dalRol;
        private DAL_Permiso dalPermiso;

        public BLL_Familia()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            dal = new DAL_Familia(conn);
            
            dalRol = new DAL_Rol(conn);
            dalPermiso = new DAL_Permiso(conn);
        }

        public void Guardar(Servicio_Familia familia)
            
        {
            if (string.IsNullOrWhiteSpace(familia.Nombre))

            {
               
                throw new Exception("Ingrese un nombre.");
            }
                    

            if (dal.ExisteNombre( familia.Nombre))
               
            {
                throw new Exception("Ya existe una familia con ese nombre.");
                    
            }

            dal.Guardar( familia.IdRol,familia.Nombre);
               
                
        }
        

        private void CargarHijosRecursivo(Servicio_Familia familia)
        {
            
            DataTable subFamilias = dal.ObtenerSubFamilias(familia.IdRol);
            foreach (DataRow row in subFamilias.Rows)
            {
                Servicio_Familia hija = new Servicio_Familia(
                    row["IdFamilia"].ToString(),
                    row["Nombre"].ToString());

                familia.AgregarRol(hija);
                CargarHijosRecursivo(hija); 
            }

            
            DataTable permisos = dalPermiso.ObtenerPermisosPorFamilia(familia.IdRol);

            if (permisos != null)
            {
                foreach (DataRow row in permisos.Rows)
                {
                    
                    Servicio_Permiso permiso = new Servicio_Permiso(row["IdPermiso"].ToString(),row["Nombre"].ToString());

                    familia.AgregarRol(permiso);
                }
            }
        }
        public void Modificar(Servicio_Familia familia)
            
        {
            if (string.IsNullOrWhiteSpace(familia.Nombre))
                
            {
                throw new Exception("Ingrese un nombre.");
                    
            }

            dal.Modificar(familia);
                
        }

        public void Eliminar(string idFamilia)
            
        {
            if (string.IsNullOrWhiteSpace( idFamilia))
               
            {
                throw new Exception( "Seleccione una familia.");
            }
                   

            dal.Eliminar(idFamilia);
        }

        public void AsignarPermiso( string idFamilia,string idPermiso)
 
        {
            if (string.IsNullOrWhiteSpace(idFamilia))throw new Exception("Seleccione una familia.");

            if (string.IsNullOrWhiteSpace(idPermiso))
                throw new Exception("Seleccione un permiso.");
                    

            dal.AsignarPermiso(idFamilia,idPermiso);
                
                
        }

        public void AsignarSubFamilia(string idPadre,string idHija)
 
        {
            if (string.IsNullOrWhiteSpace(idPadre))
                throw new Exception("Seleccione familia padre.");
                    

            if (string.IsNullOrWhiteSpace(idHija))
                throw new Exception( "Seleccione familia hija.");
                   

            if (idPadre == idHija)
                throw new Exception( "No puede asignarse a sí misma.");
                   
           

    
           Servicio_Familia familiaHijaCompleta = this.ObtenerFamiliaCompleta(idHija);

    
           if (familiaHijaCompleta != null && familiaHijaCompleta.ObtenerHijos() != null)
           {

              foreach (Servicio_Rol itemHijo in familiaHijaCompleta.ObtenerHijos())
              {
            
               if (!(itemHijo is Servicio_Familia))
               {
                
                  if (this.TienePermiso(idPadre, itemHijo.IdRol))
                  {
                    
                    this.DesasignarPermiso(idPadre, itemHijo.IdRol);
                  }
                }
              }
           }  

            dal.AsignarSubFamilia(idPadre, idHija); 
     
        }

        public DataTable ObtenerSubFamilias( string idFamilia)
           
        {
            return dal.ObtenerSubFamilias(
                idFamilia);
        }
        private Servicio_Familia BuscarFamilia(string idFamilia)

        {
            DataTable familias =
                dal.ListarFamilias();

            foreach (DataRow row in familias.Rows)
            {
                if (row["IdFamilia"].ToString() == idFamilia)
                {
                    return new Servicio_Familia(
                        row["IdFamilia"].ToString(),
                        row["Nombre"].ToString());
                }
            }

            return null;
        }
 
        public bool TienePermiso(string idFamilia, string idPermiso)

        {
            Servicio_Familia familia =ObtenerFamiliaCompleta(idFamilia);
                

            return TienePermisoRecursivo( familia,idPermiso);
               
                
        }

        public bool TieneFamilia(string idPadre, string idHija)
        {
            Servicio_Familia familia =ObtenerFamiliaCompleta(idPadre);


            return BuscarFamiliaRecursiva(familia,idHija);
                     
        }

        private bool BuscarFamiliaRecursiva(Servicio_Familia familia,string idBuscada)

        {
            foreach (Servicio_Rol item in familia.ObtenerHijos())
                
            {
                if (item is Servicio_Familia sub)
                {
                    if (sub.IdRol == idBuscada)
                        return true;

                    if (BuscarFamiliaRecursiva(sub,idBuscada))
   
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private bool TienePermisoRecursivo( Servicio_Familia familia,string idPermiso)
   
    
        {
            foreach (Servicio_Rol item in familia.ObtenerHijos())
                
            {
                if (item is Servicio_Permiso)
                {
                    if (item.IdRol == idPermiso)
                        return true;
                }

                if (item is Servicio_Familia subFamilia)
                {
                    if (TienePermisoRecursivo(subFamilia,idPermiso))

                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public Servicio_Familia ObtenerFamiliaCompleta(string idFamilia)

        {
            Servicio_Familia familia =BuscarFamilia(idFamilia);

            CargarHijosRecursivo(familia);

            return familia;
        }

        public DataTable ObtenerFamilias()
        {
            return dal.ListarFamilias();
        } 
        
        public bool ExisteNombre(string nombre)
        {
            return dal.ExisteNombre(nombre);
        }

        public void DesasignarPermiso(string idFamilia, string idPermiso)
        {
            
            Servicio_Familia familiaCompleta = ObtenerFamiliaCompleta(idFamilia);

            if (familiaCompleta.ObtenerHijos().Count <= 2)
            {
                throw new Exception("Una familia no puede quedar con un solo elemento. Si desea desarmarla, debe eliminar la familia por completo.");
            }

            
            dal.DesasignarPermiso(idFamilia, idPermiso);
        }

        public void DesasignarSubFamilia(string padre, string hija)
        {
           
            Servicio_Familia familiaCompleta = ObtenerFamiliaCompleta(padre);
            
            if (familiaCompleta.ObtenerHijos().Count <= 2)
            {
                throw new Exception("Una familia no puede quedar con un solo elemento. Si desea desarmarla, debe eliminar la familia por completo.");
            }

            dal.DesasignarSubFamilia(padre, hija);
        }
    } 
}
   
    