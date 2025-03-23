using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models
{
    public class Item
    {
        public string nombre { get; set; }
        public string imagen_url { get; set; }
        public string dado { get; set; }
        public string tipo_dano { get; set; }
        public string descripcion { get; set; }
        public List<string> propiedades { get; set; }
        public string costo { get; set; }
        public string precio { get; set; }
        public string peso { get; set; }
        public string origen { get; set; }
        public string tipo_objeto { get; set; }
        public string categoria { get; set; }
        // Nueva propiedad para almacenar la imagen descargada
        public Image Imagen
        {
            get
            {
                return ObtenerImagenDesdeURL(imagen_url);
            }
        }

        private Image ObtenerImagenDesdeURL(string url)
        {
            if (string.IsNullOrEmpty(url))
                return null;

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(url);
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message + "\nStackTrace: " + ex.StackTrace);
                try
                {
                    // Asegura que se utilice TLS 1.2
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                    using (WebClient webClient = new WebClient())
                    {
                        // Agrega un User-Agent para evitar respuestas Forbidden
                        webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");

                        byte[] data = webClient.DownloadData(url);
                        using (MemoryStream stream = new MemoryStream(data))
                        {
                            return Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Error: " + ex2.Message + "\nStackTrace: " + ex2.StackTrace);
                    return null;
                }

            }
        }
    }
}
