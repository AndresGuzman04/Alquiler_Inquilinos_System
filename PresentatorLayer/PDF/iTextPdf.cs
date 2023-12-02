using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentatorLayer.PDF
{
    public class iTextPDF
    {

        public Document InitializePDF(string path)
        {
            PdfWriter pdfWriter = new PdfWriter(path);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);

            return document;
        }
       // Generando pdf y aqui se modifican el titulo del PDF
        public Paragraph GenerateHeaderPDF(string header)
        {
            Paragraph paragraph = new Paragraph(header);
            paragraph
                .SetFontSize(14)
                .SetFontColor(ColorConstants.BLUE)
                .SetTextAlignment(TextAlignment.CENTER);

            return paragraph;
        }

        // Generando pdf y aqui se modifican las letras del PDF
        public Table GenerateTablePDF(int columns, DataGridView dataGridView)
        {
            Table table = new Table(columns);

            // Agregar encabezados en una sola fila
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                Cell cell = new Cell()
                    .SetFontSize(12)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(column.HeaderText.ToUpper()));

                table.AddCell(cell);
            }

            // Agregar datos en una sola fila
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell dataGridViewCell in row.Cells)
                {
                    if (dataGridViewCell != null && dataGridViewCell.Value != null)
                    {
                        Cell cell = new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .Add(new Paragraph(dataGridViewCell.Value.ToString()));

                        table.AddCell(cell);
                    }
                }
            }

            return table;
        }

    }
}
