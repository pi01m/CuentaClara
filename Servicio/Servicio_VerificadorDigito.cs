using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Servicio_VerificadorDigito
    {
        public Servicio_VerificadorDigito()
        {
        }
        public bool EsValido(string hashCalculado, string hashGuardado)
        {
            return hashCalculado == hashGuardado;
        }
    }
}
