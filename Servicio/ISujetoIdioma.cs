using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public interface ISujetoIdioma
    {
        void Suscribir(IObserverIdioma obs);
        void Desuscribir(IObserverIdioma obs);
        void Notificar();
    }
}
