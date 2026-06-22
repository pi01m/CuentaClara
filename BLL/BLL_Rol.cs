using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BLL
{
    public class BLL_Rol
    {
        private DAL_Rol dal;
        private BLL_BitacoraEvento bllBitacora = new BLL_BitacoraEvento();
     
        public BLL_Rol()
        {
            string conn = "Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            dal = new DAL_Rol(conn);

        }

        public void CrearRol(Servicio_Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                throw new Exception("Ingrese un nombre.");

            dal.CrearRol(rol.IdRol,rol.Nombre);
            bllBitacora.RegistrarBitacora("Alta Perfil (Rol): " + rol.Nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);

        }

        public List<Servicio_Familia> ObtenerRoles()
        {
            return dal.ListarRoles();
        }

        public void AsignarPermiso(string idRol,string idPermiso)

        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idPermiso))
                throw new Exception("Seleccione un permiso.");

            if (dal.ExistePermiso(idRol, idPermiso))
                throw new Exception(
                    "El rol ya posee ese permiso.");

            dal.AsignarPermiso( idRol,idPermiso);
            bllBitacora.RegistrarBitacora("Permiso asignado al Rol ID: " + idRol, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);

        }

        public string ObtenerNombreRol(string idRol)
        {
            return dal.ObtenerNombreRol(idRol);
        }

        public bool TienePermiso( string idRol, string idPermiso)
        {
            return dal.ExistePermiso( idRol,idPermiso);       
        }
        public string VerificarRedundanciasRol(string idRol, string idFamilia)
        {
            BLL_Familia bllFam = new BLL_Familia();
            Servicio_Familia familiaCompleta = bllFam.ObtenerFamiliaCompleta(idFamilia);
            List<string> redundantes = new List<string>();

            if (familiaCompleta != null && familiaCompleta.ObtenerHijos() != null)
            {
                foreach (Servicio_Rol itemHijo in familiaCompleta.ObtenerHijos())
                {
                    if (!(itemHijo is Servicio_Familia))
                    {
                        if (this.TienePermiso(idRol, itemHijo.IdRol))
                        {
                            redundantes.Add(itemHijo.Nombre);
                        }
                    }
                }
            }
      
            return string.Join(", ", redundantes);      // Devuelve los nombres separados por coma (ej: "Crear Usuario, Editar Usuario")
        }
        public void AsignarFamiliaARol( string idRol,string idFamilia, bool limpiarRedundancias)
     
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un rol.");

            if (string.IsNullOrWhiteSpace(idFamilia))
                throw new Exception("Seleccione una familia.");

            if (dal.ExisteFamilia(idRol,idFamilia))
 
            {
                throw new Exception( "La familia ya está asignada.");
                   
            }

            BLL_Familia bllFam = new BLL_Familia();
            Servicio_Familia familiaCompleta = bllFam.ObtenerFamiliaCompleta(idFamilia);


            if (limpiarRedundancias)
            {
                

                if (familiaCompleta != null && familiaCompleta.ObtenerHijos() != null)
                {
                    foreach (Servicio_Rol itemHijo in familiaCompleta.ObtenerHijos())
                    {
                        if (!(itemHijo is Servicio_Familia))
                        {
                            if (this.TienePermiso(idRol, itemHijo.IdRol))
                            {
                               
                                this.DesasignarPermiso(idRol, itemHijo.IdRol);
                            }
                        }
                    }
                }
            }

            dal.AsignarFamilia( idRol,idFamilia);
            bllBitacora.RegistrarBitacora("Asignación de familias a rol", SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 1);
            


        }


        public List<Servicio_Familia> ObtenerFamiliasPorRol(string idRol)
            
        {
            return dal.ObtenerFamiliasPorRol(idRol);
                
        }
        public void DesasignarPermiso(string idRol, string idPermiso)
        {
            
            dal.DesasignarPermiso(idRol, idPermiso);
            bllBitacora.RegistrarBitacora("Permiso desasignado del Rol ID: " + idRol, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }

        public void DesasignarFamilia(string idRol, string idFamilia)
        {
            dal.DesasignarFamilia(idRol, idFamilia);
            bllBitacora.RegistrarBitacora("Familia desasignada del Rol ID: " + idRol, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }

        public void ModificarRol(string idRol, string nombre)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un perfil.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Ingrese un nombre.");

            dal.ModificarRol(idRol, nombre);
            bllBitacora.RegistrarBitacora("Modificación de Rol: " + nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }

        public void EliminarRol(string idRol)
        {
            if (string.IsNullOrWhiteSpace(idRol)) throw new Exception("Seleccione un Rol.");
               

            string nombre = ObtenerNombreRol(idRol);
            dal.EliminarRelacionesRol(idRol);

            dal.EliminarRol(idRol);
            bllBitacora.RegistrarBitacora("Baja de Rol: " + nombre, SessionManager.GetInstancia().GetUsuarioActual().Login, "Administración", 2);
        }

        public bool ExisteNombre(string nombre)
        {
            return dal.ExisteNombre(nombre);
        }
        public bool RolTienePermisoRecursivo(string idRol, string idPermiso)
        {
            
            if (TienePermiso(idRol, idPermiso)) return true;

            List<Servicio_Familia> familiasDelRol = ObtenerFamiliasPorRol(idRol);

            if (familiasDelRol != null)
            {
                BLL_Familia bllFam = new BLL_Familia();

                
                foreach (Servicio_Familia familia in familiasDelRol)
                {
                   
                    string idFamilia = familia.IdRol;

                    Servicio_Familia famCompleta = bllFam.ObtenerFamiliaCompleta(idFamilia);

                    if (FamiliaContienePermiso(famCompleta, idPermiso))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool FamiliaContienePermiso(Servicio_Familia familia, string idPermisoBuscado)
        {
            if (familia != null && familia.ObtenerHijos() != null)
            {
                foreach (Servicio_Rol hijo in familia.ObtenerHijos())
                {
                    if (hijo is Servicio_Familia subFamilia)
                    {
                        
                        if (FamiliaContienePermiso(subFamilia, idPermisoBuscado)) return true;
                    }
                    else
                    {
                        
                        if (hijo.IdRol == idPermisoBuscado) return true;
                    }
                }
            }
            return false;
        }

    }
}