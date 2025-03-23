using GranDnDDM.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace GranDnDDM.Tools
{
    public static class GlobalTools
    {
        public static MonitorItem MONITOR;
        public static string DM;
        public static MusicRecord MusicaActual;
        //public static List<MusicRecord> ListaReproduccion = new List<MusicRecord>();
        public static IWMPPlaylist playlist;
        public static Bitmap ConvertBase64ToBitmap(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image img = Image.FromStream(ms);
                    return new Bitmap(img); // Convierte a Bitmap
                }
            }
            catch
            {
                return null; // Devuelve null si hay un error
            }
        }
        public static string ConvertDictionaryToString(Dictionary<string, string> dict)
        {
            if (dict == null || dict.Count == 0)
                return string.Empty;

            return string.Join(" ", dict.Select(kv => $"{kv.Key}({kv.Value})"));
        }
        public static bool IsValidPath(string path)
        {
            // Verificar si la ruta es absoluta
            if (Path.IsPathRooted(path))
            {
                // Verificar si el archivo o directorio existe (opcional)
                return File.Exists(path) || Directory.Exists(path);
            }
            return false;
        }
        public static string ConvertImageToBase64()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Guardar como PNG comprimido en memoria
                            img.Save(ms, ImageFormat.Png);
                            byte[] imageBytes = ms.ToArray();
                            return Convert.ToBase64String(imageBytes);
                        }
                    }
                }
            }
            return null;
        }
        public static Image ConvertBase64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al convertir la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static int RollDice(string diceNotation)
        {
            // Elimina espacios y los corchetes, si están presentes
            diceNotation = diceNotation.Trim();
            if (diceNotation.StartsWith("[") && diceNotation.EndsWith("]"))
            {
                diceNotation = diceNotation.Substring(1, diceNotation.Length - 2);
            }

            // Se espera el formato "NdM", por ejemplo "3d6"
            string[] parts = diceNotation.Split(new char[] { 'd', 'D' });
            if (parts.Length != 2)
                return -1; // Error: Formato incorrecto

            // Parseamos el número de dados
            if (!int.TryParse(parts[0], out int numDice))
                return -2; // Error: Número de dados inválido

            // Parseamos el número de caras
            if (!int.TryParse(parts[1], out int sides))
                return -3; // Error: Número de caras inválido

            int total = 0;
            Random rnd = new Random();

            for (int i = 0; i < numDice; i++)
            {
                total += rnd.Next(1, sides + 1);
            }

            return total;
        }

        public static Bitmap ConvertirDGVABitmap(DataGridView dataGridView, string nombreTienda, float escala)
        {
            int ancho = dataGridView.Width;
            int alto = dataGridView.Height + 30; // Espacio extra para el título

            // Crear un bitmap con espacio extra para el título
            Bitmap bitmap = new Bitmap(ancho, alto);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Rellenar el fondo en blanco
                g.FillRectangle(Brushes.White, 0, 0, ancho, alto);

                // Dibujar el nombre de la tienda en la parte superior
                using (Font fuente = new Font("Arial", 14, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    g.DrawString(nombreTienda, fuente, brush, new PointF(10, 5));
                }

                // Dibujar el DataGridView dentro del bitmap
                dataGridView.DrawToBitmap(bitmap, new Rectangle(0, 30, dataGridView.Width, dataGridView.Height));
            }

            // **Si la escala es mayor a 1, agrandamos la imagen**
            if (escala > 1)
            {
                int nuevoAncho = (int)(bitmap.Width * escala);
                int nuevoAlto = (int)(bitmap.Height * escala);

                Bitmap imagenEscalada = new Bitmap(nuevoAncho, nuevoAlto);
                using (Graphics g = Graphics.FromImage(imagenEscalada))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(bitmap, new Rectangle(0, 0, nuevoAncho, nuevoAlto));
                }

                return imagenEscalada; // Devuelve la imagen escalada
            }

            return bitmap; // Devuelve la imagen sin cambios si la escala es 1
        }

////////////////////////
    }
}
