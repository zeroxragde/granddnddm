using GranDnDDM.Models;
using System;
using System.Collections.Generic;
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
    }
}
