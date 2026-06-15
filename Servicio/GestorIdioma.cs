using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class GestorIdioma:ISujetoIdioma
    {
        private static readonly GestorIdioma _instancia = new GestorIdioma();

        public static GestorIdioma GetInstancia() => _instancia;

        private List<IObserverIdioma> observadores = new List<IObserverIdioma>();

        public void Suscribir(IObserverIdioma obs)
        {
            observadores.Add(obs);
        }

        public void Desuscribir(IObserverIdioma obs)
        {
            observadores.Remove(obs);
        }

        public void Notificar()
        {
            foreach (IObserverIdioma obs in observadores)
            {
                obs.ActualizarIdioma();
            }
        }
    }
}
