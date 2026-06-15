using Servicio;
using System;
using System.Collections.Generic;
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
    }
}
