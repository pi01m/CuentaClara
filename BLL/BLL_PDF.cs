using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BLL
{
    public class BLL_PDF
    {
        private Servicio_PDF servicioPdf = new Servicio_PDF();
        private BLL_BitacoraEvento bllBitacora = new BLL_BitacoraEvento();
        public void ExportarBitacora(DataTable tabla, string ruta, string login)
        {
            servicioPdf.GenerarBitacoraPDF(tabla, ruta);


            bllBitacora.RegistrarBitacora("Imprimir Bitacora",login,"Auditoria",5);  
                
        }
    }
}

