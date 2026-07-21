using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Rol
    {
        private readonly string _connectionString = DAL_ConexionDB.ObtenerCadena();
        public DAL_Rol()
        { 
        }

        public bool CrearRol(string idRol, string nombre)
        {
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rol",_connectionString))
 
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "Rol");

                DataRow row = ds.Tables["Rol"].NewRow();
                   

                row["IdRol"] = idRol;
                row["Nombre"] = nombre;

                ds.Tables["Rol"].Rows.Add(row);

                SqlCommandBuilder cb =new SqlCommandBuilder(da);

                    
                da.Update(ds, "Rol");

                return true;
            }
        }


        public List<Servicio_Familia> ListarRoles()
        {
            List<Servicio_Familia> lista = new List<Servicio_Familia>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Rol", conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lista.Add(new Servicio_Familia(row["IdRol"].ToString(), row["Nombre"].ToString()));
                    }
                }
            }
            return lista;
        }

        public List<Servicio_Familia> ObtenerFamiliasPorRol(string idRol)
        {
            List<Servicio_Familia> lista = new List<Servicio_Familia>();
            using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT f.* FROM Familia f INNER JOIN Familia_Rol fr ON fr.IdFamilia=f.IdFamilia WHERE fr.IdRol=@Rol", _connectionString))
            {
                da.SelectCommand.Parameters.AddWithValue("@Rol", idRol);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lista.Add(new Servicio_Familia(row["IdFamilia"].ToString(), row["Nombre"].ToString()));
                }
            }
            return lista;
        }

        public string ObtenerNombreRol(string idRol)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre FROM Rol WHERE IdRol = @IdRol", cn);
                da.SelectCommand.Parameters.AddWithValue("@IdRol", idRol);

                DataTable dt = new DataTable();
                da.Fill(dt);

                
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0]["Nombre"].ToString();
                }

                return "Rol Sin Nombre";
            }
        }
        public bool ExisteFamilia(string idRol,string idFamilia)
    
        {
            using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT * FROM Familia_Rol WHERE IdRol=@Rol AND IdFamilia=@Familia",_connectionString))
  
            {
                da.SelectCommand.Parameters.AddWithValue("@Rol",idRol);

                da.SelectCommand.Parameters.AddWithValue("@Familia",idFamilia);

                DataTable dt =new DataTable();

                da.Fill(dt);

                return dt.Rows.Count > 0;
            }
        }



        public bool ExistePermiso(string idRol, string idPermiso)
        {
            using (SqlDataAdapter da =new SqlDataAdapter(  @"SELECT *FROM Rol_Permiso WHERE IdRol=@Rol AND IdPermiso=@Permiso",_connectionString))

                
            {
                da.SelectCommand.Parameters.AddWithValue("@Rol", idRol);
                    

                da.SelectCommand.Parameters.AddWithValue("@Permiso", idPermiso);
                    

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt.Rows.Count > 0;
            }
        }

        public void AsignarPermiso(string idRol,string idPermiso)
    
        {
            using (SqlConnection cn =new SqlConnection(_connectionString))
                
            {
                SqlDataAdapter da = new SqlDataAdapter( "SELECT * FROM Rol_Permiso",cn);

                DataSet ds = new DataSet();

                da.Fill(ds, "Rol_Permiso");

                DataRow fila =ds.Tables["Rol_Permiso"].NewRow();
                    

                fila["IdRol_Permiso"] =Guid.NewGuid().ToString();
                    

                fila["IdRol"] = idRol;
                fila["IdPermiso"] = idPermiso;

                ds.Tables["Rol_Permiso"].Rows.Add(fila);

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                   

                da.Update(ds, "Rol_Permiso");
            }
        }
        public void DesasignarPermiso(string idRol, string idPermiso)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Rol_Permiso WHERE IdRol = @IdRol AND IdPermiso = @IdPermiso", cn);
                da.SelectCommand.Parameters.AddWithValue("@IdRol", idRol);
                da.SelectCommand.Parameters.AddWithValue("@IdPermiso", idPermiso);

                DataSet ds = new DataSet();
                da.Fill(ds, "Rol_Permiso");

                if (ds.Tables["Rol_Permiso"].Rows.Count > 0)
                {
                    ds.Tables["Rol_Permiso"].Rows[0].Delete();

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Rol_Permiso");
                }
            }
        }

        // FAMILIA_ROL


        public void DesasignarFamilia(string idRol, string idFamilia)
        {
            using (SqlConnection cn = new SqlConnection(_connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Rol WHERE IdRol = @IdRol AND IdFamilia = @IdFamilia", cn);
                da.SelectCommand.Parameters.AddWithValue("@IdRol", idRol);
                da.SelectCommand.Parameters.AddWithValue("@IdFamilia", idFamilia);

                DataSet ds = new DataSet();
                da.Fill(ds, "Familia_Rol");

                if (ds.Tables["Familia_Rol"].Rows.Count > 0)
                {
                    ds.Tables["Familia_Rol"].Rows[0].Delete();

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "Familia_Rol");
                }
            }
        }
        public void AsignarFamilia( string idRol,string idFamilia)
  
        {
            using (SqlConnection cn =new SqlConnection(_connectionString))
                
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Rol",cn);

                DataSet ds = new DataSet();

                da.Fill(ds, "Familia_Rol");

                DataRow fila =ds.Tables["Familia_Rol"].NewRow();
                    

                fila["IdFamilia_Rol"] =Guid.NewGuid().ToString();
                    

                fila["IdRol"] = idRol;
                fila["IdFamilia"] = idFamilia;

                ds.Tables["Familia_Rol"].Rows.Add(fila);

                SqlCommandBuilder cb =new SqlCommandBuilder(da);

                da.Update(ds, "Familia_Rol");
            }
        }
        public bool ExisteNombre(string nombre)
        {
            using (SqlDataAdapter da =new SqlDataAdapter( "SELECT * FROM Rol",_connectionString))

            {
                DataTable dt = new DataTable();

                da.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    if (fila["Nombre"].ToString().ToUpper() ==nombre.ToUpper())    
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public bool ModificarRol( string idRol,string nuevoNombre)
   
    
        {
            using (SqlDataAdapter da =new SqlDataAdapter(  "SELECT * FROM Rol WHERE IdRol=@IdRol",_connectionString))

            {
                da.SelectCommand.Parameters.AddWithValue("@IdRol",idRol);
                    
                    

                DataSet ds = new DataSet();

                da.Fill(ds, "Rol");

                if (ds.Tables["Rol"].Rows.Count == 0)
                    return false;

                ds.Tables["Rol"].Rows[0]["Nombre"] =nuevoNombre;
                    

                SqlCommandBuilder cb =new SqlCommandBuilder(da);
                    

                da.Update(ds, "Rol");

                return true;
            }
        }

        public bool EliminarRol(string idRol)
        {
            EliminarRelacionesRol(idRol);using (SqlDataAdapter da =new SqlDataAdapter( "SELECT * FROM Rol WHERE IdRol=@IdRol",_connectionString))
  
            {
                da.SelectCommand.Parameters.AddWithValue( "@IdRol", idRol);

                DataSet ds = new DataSet();

                da.Fill(ds, "Rol");

                if (ds.Tables["Rol"].Rows.Count == 0)
                    return false;

                ds.Tables["Rol"].Rows[0].Delete();

                SqlCommandBuilder cb =new SqlCommandBuilder(da);
                    

                da.Update(ds, "Rol");

                return true;
            }
        }

        public void EliminarRelacionesRol(string idRol)
        {
            using (SqlDataAdapter da =new SqlDataAdapter("SELECT * FROM Rol_Permiso",_connectionString))

            {
                DataSet ds = new DataSet();

                da.Fill(ds, "Rol_Permiso");

                foreach (DataRow fila in ds.Tables["Rol_Permiso"].Rows)
                {
                    if (fila["IdRol"].ToString() == idRol)
                    {
                        fila.Delete();
                    }
                }

                SqlCommandBuilder cb =
                    new SqlCommandBuilder(da);

                da.Update(ds, "Rol_Permiso");
            }

            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Familia_Rol",_connectionString))
 
            {
                DataSet ds = new DataSet();

                da.Fill(ds, "Familia_Rol");

                foreach (DataRow fila in ds.Tables["Familia_Rol"].Rows)
                {
                    if (fila["IdRol"].ToString() == idRol)
                    {
                        fila.Delete();
                    }
                }

                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                   

                da.Update(ds, "Familia_Rol");
            }
        }
        public bool ExisteFamiliaEnRol( string idRol,string idFamilia)
   
        {
            using (SqlDataAdapter da = new SqlDataAdapter( @"SELECT *FROM Familia_Rol WHERE IdRol=@Rol AND IdFamilia=@Familia",_connectionString))

            {
                da.SelectCommand.Parameters.AddWithValue( "@Rol", idRol);

                da.SelectCommand.Parameters.AddWithValue("@Familia", idFamilia);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt.Rows.Count > 0;
            }
        }

        public List<Servicio_Permiso> ObtenerPermisosPorRol(string idRol)
        {
            List<Servicio_Permiso> lista = new List<Servicio_Permiso>();

            using (SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT P.IdPermiso, P.Nombre
                FROM Permiso P
                INNER JOIN Rol_Permiso RP
                    ON RP.IdPermiso = P.IdPermiso
                WHERE RP.IdRol = @Rol", _connectionString))
                    {
                da.SelectCommand.Parameters.AddWithValue("@Rol", idRol);

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    lista.Add(new Servicio_Permiso(
                        fila["IdPermiso"].ToString(),
                        fila["Nombre"].ToString()));
                }
            }

            return lista;
        }



    }
}
