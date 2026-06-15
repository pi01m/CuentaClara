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

        public void Guardar(
            Servicio_Familia familia)
        {
            if (string.IsNullOrWhiteSpace(
                familia.Nombre))
            {
                throw new Exception(
                    "Ingrese un nombre.");
            }

            if (dal.ExisteNombre(
                familia.Nombre))
            {
                throw new Exception(
                    "Ya existe una familia con ese nombre.");
            }

            dal.Guardar(
                familia.IdRol,
                familia.Nombre);
        }
        

        private void CargarHijosRecursivo(Servicio_Familia familia)
        {
            // 1. CARGAMOS LAS SUBFAMILIAS (Tu código original, intacto)
            DataTable subFamilias = dal.ObtenerSubFamilias(familia.IdRol);
            foreach (DataRow row in subFamilias.Rows)
            {
                Servicio_Familia hija = new Servicio_Familia(
                    row["IdFamilia"].ToString(),
                    row["Nombre"].ToString());

                familia.AgregarRol(hija);
                CargarHijosRecursivo(hija); // Recursividad para buscar más adentro
            }

            // 2. CARGAMOS LOS PERMISOS SIMPLES / PATENTES (¡Lo que faltaba!)
            // Vamos a la base de datos a buscar qué permisos tiene esta familia
            DataTable permisos = dalPermiso.ObtenerPermisosPorFamilia(familia.IdRol);

            if (permisos != null)
            {
                foreach (DataRow row in permisos.Rows)
                {
                    // Instanciamos el permiso como un Servicio_Permiso
                    Servicio_Permiso permiso = new Servicio_Permiso(
                        row["IdPermiso"].ToString(),
                        row["Nombre"].ToString());

                    // Lo agregamos al composite (como hereda de Servicio_Rol, entra perfecto)
                    familia.AgregarRol(permiso);
                }
            }
        }
        public void Modificar(Servicio_Familia familia)
            
        {
            if (string.IsNullOrWhiteSpace(
                familia.Nombre))
            {
                throw new Exception(
                    "Ingrese un nombre.");
            }

            dal.Modificar(familia);
                
        }

        public void Eliminar(string idFamilia)
            
        {
            if (string.IsNullOrWhiteSpace(
                idFamilia))
            {
                throw new Exception(
                    "Seleccione una familia.");
            }

            dal.Eliminar(idFamilia);
        }

        public void AsignarPermiso(
            string idFamilia,
            string idPermiso)
        {
            if (string.IsNullOrWhiteSpace(idFamilia))
                throw new Exception(
                    "Seleccione una familia.");

            if (string.IsNullOrWhiteSpace(idPermiso))
                throw new Exception(
                    "Seleccione un permiso.");

            dal.AsignarPermiso(
                idFamilia,
                idPermiso);
        }

        public void AsignarSubFamilia(
            string idPadre,
            string idHija)
        {
            if (string.IsNullOrWhiteSpace(idPadre))
                throw new Exception(
                    "Seleccione familia padre.");

            if (string.IsNullOrWhiteSpace(idHija))
                throw new Exception(
                    "Seleccione familia hija.");

            if (idPadre == idHija)
                throw new Exception(
                    "No puede asignarse a sí misma.");

            dal.AsignarSubFamilia(
                idPadre,
                idHija);
        }

        public DataTable ObtenerSubFamilias(
            string idFamilia)
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
 
        public bool TienePermiso(
    string idFamilia,
    string idPermiso)
        {
            Servicio_Familia familia =
                ObtenerFamiliaCompleta(idFamilia);

            return TienePermisoRecursivo(
                familia,
                idPermiso);
        }
        public bool TieneFamilia(
    string idPadre,
    string idHija)
        {
            Servicio_Familia familia =
                ObtenerFamiliaCompleta(idPadre);

            return BuscarFamiliaRecursiva(
                familia,
                idHija);
        }
        private bool BuscarFamiliaRecursiva(
    Servicio_Familia familia,
    string idBuscada)
        {
            foreach (Servicio_Rol item
                in familia.ObtenerHijos())
            {
                if (item is Servicio_Familia sub)
                {
                    if (sub.IdRol == idBuscada)
                        return true;

                    if (BuscarFamiliaRecursiva(
                        sub,
                        idBuscada))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private bool TienePermisoRecursivo(
    Servicio_Familia familia,
    string idPermiso)
        {
            foreach (Servicio_Rol item
                in familia.ObtenerHijos())
            {
                if (item is Servicio_Permiso)
                {
                    if (item.IdRol == idPermiso)
                        return true;
                }

                if (item is Servicio_Familia subFamilia)
                {
                    if (TienePermisoRecursivo(
                        subFamilia,
                        idPermiso))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public Servicio_Familia ObtenerFamiliaCompleta(string idFamilia)

        {
            Servicio_Familia familia =
        BuscarFamilia(idFamilia);

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
            dal.DesasignarPermiso(idFamilia, idPermiso);
        }

        public void DesasignarSubFamilia(string padre, string hija)
        {
            dal.DesasignarSubFamilia(padre, hija);
        }
    } }
   
    