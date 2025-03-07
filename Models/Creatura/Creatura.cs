using iText.Commons.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Models.Creatura
{
    public class Creatura
    {
        // --- Identificación básica ---
        public string Nombre { get; set; }          // Ej: "Goblin", "Dragón Rojo Adulto"
        public string Imagen { get; set; }          // Ej: "Goblin", "Dragón Rojo Adulto"
        public string Tamanio { get; set; }         // Ej: "Pequeño", "Mediano", "Grande"
        public string Tipo { get; set; }            // Ej: "Humanoide", "Dragón", "No muerto"
        public string Subtipo { get; set; }         // Opcional
        public string Alineamiento { get; set; }    // Ej: "Caótico Malvado", "Neutral Bueno"

        // --- Clase de Armadura, Puntos de Golpe y Velocidades ---
        public int ClaseArmadura { get; set; } = 10;      // Ej: 15
        public string DescripcionArmadura { get; set; } // Ej: "Cuero tachonado", "Natural"
        public int PuntosGolpe { get; set; }        // Ej: 45
        public string DadosGolpe { get; set; }      // Ej: "6d8 + 12"

        // Velocidades (puedes añadir más: nadar, volar, escalar, etc.)
        public int VelocidadCaminar { get; set; }   // Ej: 30 (pies)
        public int VelocidadVolar { get; set; }     // Ej: 60 (pies), 0 si no vuela
        public int VelocidadNadar { get; set; }     // Ej: 0 si no nada
        public int VelocidadCavar { get; set; }     // Ej: 0 si no nada
        public int VelocidadEscalado { get; set; }     // Ej: 0 si no nada

        // --- Características de habilidad (Ability Scores) ---
        public int Fuerza { get; set; }
        public int Destreza { get; set; }
        public int Constitucion { get; set; }
        public int Inteligencia { get; set; }
        public int Sabiduria { get; set; }
        public int Carisma { get; set; }
        public int BonificadorFuerza { get; set; }
        public int BonificadorDestreza { get; set; }
        public int BonificadorConstitucion { get; set; }
        public int BonificadorInteligencia { get; set; }
        public int BonificadorSabiduria { get; set; }
        public int BonificadorCarisma { get; set; }

        // Guardar tiradas de salvación si la criatura las tiene definidas
        public List<string> Salvacion { get; set; } = new List<string>();


        // Habilidades opcionales (ej: sigilo, percepción, etc.)
        public Dictionary<string, string> Habilidades { get; set; } = new Dictionary<string, string>();

        // --- Vulnerabilidades, resistencias, inmunidades ---
        public List<string> VulnerabilidadesDano { get; set; } = new List<string>();
        public List<string> ResistenciasDano { get; set; } = new List<string>();
        public List<string> InmunidadesDano { get; set; } = new List<string>();
        public List<string> InmunidadesCondicion { get; set; } = new List<string>();

        // --- Sentidos (ej: visión en la oscuridad, vista ciega, etc.) ---
        public List<string> Sentidos { get; set; } = new List<string>();// Ej: "Visión en la Oscuridad 60 ft., Percepción pasiva 14"

        // --- Idiomas ---
        public Dictionary<string, string> Idiomas { get; set; } = new Dictionary<string, string>();  // Ej: "Común, Dracónico"

        // --- Challenge Rating (CR) y experiencia ---
        public string CR { get; set; }       // Ej: "5"
        public int XP { get; set; }          // Ej: 1800

        // --- Acciones (básicas, bonus, reacciones) ---
        public List<Accion> Acciones { get; set; } = new List<Accion>();
        public List<Accion> AccionesHabilidad { get; set; } = new List<Accion>();
        public List<Accion> AccionesAdicionales { get; set; } = new List<Accion>(); // Bonus Actions
        public List<Accion> Reacciones { get; set; } = new List<Accion>();

        // --- Acciones especiales (Hechizos, etc.) ---
        public string HechizosOEspeciales { get; set; }
        // Aquí podrías guardar la descripción de la capacidad de conjurar (Spellcasting).

        // --- Legendaria ---
        public bool EsLegendaria { get; set; }              // Si la criatura es legendaria
        public int CantidadResistenciasLegendarias { get; set; } // Cuántas veces al día puede usar Legendary Resistance
        public List<AccionLegendaria> AccionesLegendarias { get; set; } = new List<AccionLegendaria>();

        // --- Mítica ---
        public bool EsMitica { get; set; }                  // Si la criatura tiene modo mítico
        public string DescripcionMitica { get; set; }       // Detalles de su modo mítico
        public List<Accion> AccionesMiticas { get; set; } = new List<Accion>();

        // --- Guarida ---
        public bool TieneGuarida { get; set; }              // Si la criatura tiene acciones de guarida
        public List<Accion> AccionesGuarida { get; set; } = new List<Accion>();
        public string DescripcionGuarida { get; set; }

        // --- Efectos Regionales ---
        public bool TieneEfectosRegionales { get; set; }
        public List<Accion> EfectosRegionales { get; set; } = new List<Accion>();
        public string DescripcionRegional { get; set; }

        // --- Cualquier campo adicional que quieras ---
        // Ej: notas, descripción, trasfondo, etc.
        public string Notas { get; set; }
    }
}
