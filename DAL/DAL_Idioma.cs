using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_Idioma
    {
        private readonly string carpetaIdiomas = "Idiomas";

        public DAL_Idioma()
        {
            if (!Directory.Exists(carpetaIdiomas))
            {
                Directory.CreateDirectory(carpetaIdiomas);
            }
        }

        public bool ExisteIdioma(string nombre)
        {
            string archivo = Path.Combine(carpetaIdiomas,nombre + ".json");
            
            return File.Exists(archivo);
        }

        public bool CrearIdioma(Servicio_Idioma idioma)
        {
            try
            {
                string archivo = Path.Combine(carpetaIdiomas, idioma.Nombre + ".json");
                string json =JsonSerializer.Serialize(idioma);
                File.WriteAllText(archivo, json);
                AgregarIdiomaBD(idioma.Nombre);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Servicio_Idioma> ListarIdiomas()
        {
            List<Servicio_Idioma> lista =new List<Servicio_Idioma>();
             string[] archivos =Directory.GetFiles(carpetaIdiomas, "*.json");
            foreach (string archivo in archivos)
            {
                string json =File.ReadAllText(archivo);
                 
                Servicio_Idioma idioma = JsonSerializer.Deserialize<Servicio_Idioma>(json);
                 
                lista.Add(idioma);
            }

            return lista;
        }

        public Servicio_Idioma ObtenerIdioma(string nombre)
        {
            string ruta = carpetaIdiomas + "\\" + nombre + ".json";

            if (!File.Exists(ruta))
            {
                return null;
            }

            string json = File.ReadAllText(ruta);

            Servicio_Idioma idioma =JsonSerializer.Deserialize<Servicio_Idioma>(json);
                

            return idioma;
        } 

        public bool GuardarIdiomaActualizado(Servicio_Idioma idioma)
        {
            try
            {
                string archivo =
                    Path.Combine(
                        carpetaIdiomas,
                        idioma.Nombre + ".json");

                string json =
                    JsonSerializer.Serialize(idioma);

                File.WriteAllText(archivo, json);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AgregarIdiomaBD(string nombre)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT Id_Idioma, Nombre FROM Idioma",
                        conexion);

                    SqlCommandBuilder cb = new SqlCommandBuilder(da);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                
                    DataRow fila = dt.NewRow();

                    int nuevoId = 1;

                    if (dt.Rows.Count > 0)
                    {
                        nuevoId = Convert.ToInt32(dt.Compute("MAX(Id_Idioma)", "")) + 1;
                    }
                        
                    fila["Id_Idioma"] = nuevoId;
                    fila["Nombre"] = nombre;

                    dt.Rows.Add(fila);

                    da.Update(dt);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Servicio_Idioma> DameIdiomasBD()
        {
            List<Servicio_Idioma> lista = new List<Servicio_Idioma>();

            try
            {
                using (SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT Id_Idioma, Nombre FROM Idioma",
                        conexion);

                    conexion.Open(); 

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Servicio_Idioma idioma = new Servicio_Idioma();

                        idioma.Id_Idioma = reader["Id_Idioma"].ToString();

                        idioma.Nombre = reader["Nombre"].ToString();

                        lista.Add(idioma);
                    }
                }
            }
            catch
            {
                
            }

            return lista;
        }
    }
    
}

