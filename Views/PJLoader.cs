using System;
using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;


namespace GranDnDDM.Views
{
    public partial class PJLoader : Form
    {
        public PJLoader()
        {
            InitializeComponent();
        }

        private void aloneButton1_Click(object sender, EventArgs e)
        {
            string pdfPath = @"C:\\Users\\ecarrizales\\edgar\\app\\tefeling_Picarov1.pdf"; // Ruta al archivo PDF

            string texto = LeerPdf(pdfPath);
            Console.WriteLine("Texto extraído del PDF:");
            Console.WriteLine(texto);

            // Aquí puedes procesar el texto extraído para obtener los datos específicos
            string nombre = ExtraerDato(texto, "Nombre:");
            string clase = ExtraerDato(texto, "Clase:");
            string raza = ExtraerDato(texto, "Raza:");

            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Clase: {clase}");
            Console.WriteLine($"Raza: {raza}");
        }




        public static string LeerPdf(string pdfPath)
        {
            StringBuilder textoExtraido = new StringBuilder();

            // Abrir el archivo PDF
            using (PdfReader lector = new PdfReader(pdfPath))
            {
                using (PdfDocument documento = new PdfDocument(lector))
                {
                    // Iterar sobre todas las páginas del PDF
                    for (int i = 1; i <= documento.GetNumberOfPages(); i++)
                    {
                        var pagina = documento.GetPage(i);
                        var estrategia = new LocationTextExtractionStrategy();  // Usar una estrategia que preserve la ubicación
                        string textoPagina = PdfTextExtractor.GetTextFromPage(pagina, estrategia);
                        textoExtraido.Append(textoPagina);
                    }
                }
            }

            return textoExtraido.ToString();
        }

        public static string ExtraerDato(string texto, string clave)
        {
            int index = texto.IndexOf(clave);
            if (index == -1)
                return "Dato no encontrado";

            int startIndex = index + clave.Length;
            int endIndex = texto.IndexOf("\n", startIndex);

            if (endIndex == -1)
                endIndex = texto.Length;

            string dato = texto.Substring(startIndex, endIndex - startIndex).Trim();
            return dato;
        }









    }
}
