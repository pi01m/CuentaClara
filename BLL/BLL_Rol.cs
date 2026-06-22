using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Rol
    {
        private DAL_Rol dal;
     
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
  
        }

        public DataTable ObtenerRoles()
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
               
                
        }

        public bool TieneFamilia( string idRol,string idFamilia)
  
        {
            return dal.ExisteFamilia( idRol, idFamilia);
               
               
        }

        public DataTable ObtenerFamiliasPorRol(string idRol)
            
        {
            return dal.ObtenerFamiliasPorRol(
                idRol);
        }
        public void DesasignarPermiso(string idRol, string idPermiso)
        {
            
            dal.DesasignarPermiso(idRol, idPermiso);
        }

        public void DesasignarFamilia(string idRol, string idFamilia)
        {
            dal.DesasignarFamilia(idRol, idFamilia);
        }

        public void ModificarPerfil(string idRol, string nombre)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un perfil.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("Ingrese un nombre.");

            dal.ModificarRol(idRol, nombre);
        }

        public void EliminarPerfil(string idRol)
        {
            if (string.IsNullOrWhiteSpace(idRol))
                throw new Exception("Seleccione un perfil.");

            // Primero elimino relaciones
            dal.EliminarRelacionesRol(idRol);

            // Después elimino el perfil
            dal.EliminarRol(idRol);
        }

        public bool ExisteNombre(string nombre)
        {
            return dal.ExisteNombre(nombre);
        }
        public bool RolTienePermisoRecursivo(string idRol, string idPermiso)
        {
            // 1. Verificamos si lo tiene asignado directamente de forma suelta
            if (TienePermiso(idRol, idPermiso)) return true;

            // 2. Verificamos si lo tiene heredado dentro de alguna de sus familias asignadas
            DataTable dtFamilias = ObtenerFamiliasPorRol(idRol);
            if (dtFamilias != null)
            {
                BLL_Familia bllFam = new BLL_Familia();
                foreach (DataRow row in dtFamilias.Rows)
                {
                    string idFamilia = row["IdFamilia"].ToString();
                    // Obtenemos la familia con toda su estructura interna
                    Servicio_Familia famCompleta = bllFam.ObtenerFamiliaCompleta(idFamilia);

                    if (FamiliaContienePermiso(famCompleta, idPermiso))
                    {
                        return true; // Lo encontró dentro de esta rama
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
                        // Si es familia, aplicamos recursividad para buscar más adentro
                        if (FamiliaContienePermiso(subFamilia, idPermisoBuscado)) return true;
                    }
                    else
                    {
                        // Si es un permiso (nodo hoja), verificamos si es el que buscamos
                        if (hijo.IdRol == idPermisoBuscado) return true;
                    }
                }
            }
            return false;
        }

    }
}