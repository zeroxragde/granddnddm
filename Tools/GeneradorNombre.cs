using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public class GeneradorNombre
    {
        private static readonly Random random = new Random();

        // Listas de palabras
        private readonly string[] adjetivos = { "Místico", "Antiguo", "Enigmático", "Sagrado", "Maldito", "Legendario", "Arcano", "Siniestro" };
        private readonly string[] sustantivos = { "Dragón", "Fénix", "Hechicero", "Guerrero", "Bruja", "Caballero", "Alquimista", "Forjador" };
        private readonly string[] tipos = { "Tienda", "Emporio", "Mercado", "Bazar", "Almacén", "Taberna", "Armería", "Librería" };

        // Plantillas para generar nombres
        private readonly List<string> plantillas = new List<string>
        {
            "{adjetivo} {sustantivo} {tipo}",
            "La {sustantivo} {tipo}",
            "El {sustantivo} del {adjetivo}",
            "{adjetivo} {tipo} de {sustantivo}",
            "{sustantivo} y {sustantivo}",
            "El {adjetivo} {sustantivo}"
        };

        // Método público que devuelve un nombre generado
        public string ObtenerNombre()
        {
            // Selecciona una plantilla aleatoria
            string plantilla = plantillas[random.Next(plantillas.Count)];

            // Reemplaza los marcadores por palabras aleatorias
            string nombre = plantilla
                .Replace("{adjetivo}", adjetivos[random.Next(adjetivos.Length)])
                .Replace("{tipo}", tipos[random.Next(tipos.Length)]);

            // Reemplaza todas las apariciones de {sustantivo} de forma iterativa
            while (nombre.Contains("{sustantivo}"))
            {
                nombre = nombre.Replace("{sustantivo}", sustantivos[random.Next(sustantivos.Length)]);
            }

            return nombre;
        }
    }
}
