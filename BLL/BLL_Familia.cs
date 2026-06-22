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
        private BLL_BitacoraEvento bllBitacora = new BLL_BitacoraEvento();
        private DAL_Rol dalRol;
        private BLL_Permiso bllPermiso
            ;

        public BLL_Familia()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            dal = new DAL_Familia(conn);
            
            dalRol = new DAL_Rol(conn);
            bllPermiso = new BLL_Permiso();
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
            bllBitacora.RegistrarBitacora("Alta Familia: " + familia.Nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);


        }
        

        private void CargarHijosRecursivo(Servicio_Familia familia)
        {

            List<Servicio_Familia> subFamilias = dal.ObtenerSubFamilias(familia.IdRol);

            if (subFamilias != null)
            {
                foreach (Servicio_Familia hija in subFamilias)
                {
                  
                    familia.AgregarRol(hija);
                    CargarHijosRecursivo(hija);
                }
            }

            List<Servicio_Permiso> permisos = bllPermiso.ObtenerPermisosPorFamilia(familia.IdRol);

            if (permisos != null)
            {
                foreach (Servicio_Permiso permiso in permisos)
                {
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
            bllBitacora.RegistrarBitacora("Modificación Familia: " + familia.Nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);

        }

        public void Eliminar(string idFamilia)
            
        {
            if (string.IsNullOrWhiteSpace( idFamilia))
               
            {
                throw new Exception( "Seleccione una familia.");
            }
                   

            dal.Eliminar(idFamilia);
            bllBitacora.RegistrarBitacora("Baja Familia ID: " + idFamilia, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }

        public void AsignarPermiso( string idFamilia,string idPermiso)
 
        {
            if (string.IsNullOrWhiteSpace(idFamilia))throw new Exception("Seleccione una familia.");

            if (string.IsNullOrWhiteSpace(idPermiso))
                throw new Exception("Seleccione un permiso.");
                    

            dal.AsignarPermiso(idFamilia,idPermiso);
            bllBitacora.RegistrarBitacora("Permiso asignado a Familia ID: " + idFamilia, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);

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
            bllBitacora.RegistrarBitacora("Asignación familia a familia", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);

        }

        public List<Servicio_Familia> ObtenerSubFamilias( string idFamilia)
           
        {
            return dal.ObtenerSubFamilias(idFamilia);
               
        }
        private Servicio_Familia BuscarFamilia(string idFamilia)
        {
            List<Servicio_Familia> familias = dal.ListarFamilias();

            if (familias != null)
            {
                foreach (Servicio_Familia fam in familias)
                {
                    if (fam.IdRol == idFamilia)
                    {
                        return fam;
                    }
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

        public List<Servicio_Familia> ObtenerFamilias()
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
            bllBitacora.RegistrarBitacora("Permiso desasignado de Familia ID: " + idFamilia, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }

        public void DesasignarSubFamilia(string padre, string hija)
        {
           
            Servicio_Familia familiaCompleta = ObtenerFamiliaCompleta(padre);
            
            if (familiaCompleta.ObtenerHijos().Count <= 2)
            {
                throw new Exception("Una familia no puede quedar con un solo elemento. Si desea desarmarla, debe eliminar la familia por completo.");
            }

            dal.DesasignarSubFamilia(padre, hija);
            bllBitacora.RegistrarBitacora("Subfamilia desasignada de Familia ID: " + padre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }
    } 
}
   
    