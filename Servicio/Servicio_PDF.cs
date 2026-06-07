using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Servicio_PDF
    {
        public void GenerarBitacoraPDF(DataTable tabla, string ruta)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);

                    page.Header()
                        .Text("Bitácora de Eventos")
                        .FontSize(20)
                        .Bold();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Cell().Text("Login").Bold();
                        table.Cell().Text("Fecha").Bold();
                        table.Cell().Text("Hora").Bold();
                        table.Cell().Text("Modulo").Bold();
                        table.Cell().Text("Evento").Bold();
                        table.Cell().Text("Criticidad").Bold();

                        foreach (DataRow fila in tabla.Rows)
                        {
                            table.Cell().Text(fila["Login"].ToString());

                            table.Cell().Text(
                                Convert.ToDateTime(fila["Fecha"])
                                .ToString("dd/MM/yyyy")
                            );

                            table.Cell().Text(fila["Hora"].ToString());
                            table.Cell().Text(fila["Modulo"].ToString());
                            table.Cell().Text(fila["Evento"].ToString());
                            table.Cell().Text(fila["Criticidad"].ToString());
                        }
                    });
                });
            })
            .GeneratePdf(ruta);
        }
    }
}

