using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class CreatureEditor : Form
    {
        public CreatureEditor()
        {
            InitializeComponent();
            // Agregar los ítems en español
            cbSizes.Items.Add("Seleccionar Tamaño");     // Tiny
            cbSizes.Items.Add("Diminuto");     // Tiny
            cbSizes.Items.Add("Pequeño");      // Small
            cbSizes.Items.Add("Mediano");      // Medium
            cbSizes.Items.Add("Grande");       // Large
            cbSizes.Items.Add("Enorme");       // Huge
            cbSizes.Items.Add("Gargantuesco"); // Gargantuan


            // Agregar los ítems en español
            cbListtypeM.Items.Add("Seleccionar Tipo");
            cbListtypeM.Items.Add("Aberración");
            cbListtypeM.Items.Add("Bestia");
            cbListtypeM.Items.Add("Celestial");
            cbListtypeM.Items.Add("Constructo");
            cbListtypeM.Items.Add("Dragón");
            cbListtypeM.Items.Add("Elemental");
            cbListtypeM.Items.Add("Feérico");
            cbListtypeM.Items.Add("Engendro");       // Fiend
            cbListtypeM.Items.Add("Gigante");
            cbListtypeM.Items.Add("Humanoide");
            cbListtypeM.Items.Add("Monstruosidad");
            cbListtypeM.Items.Add("Limo");           // Ooze
            cbListtypeM.Items.Add("Planta");
            cbListtypeM.Items.Add("No muerto");      // Undead
            cbListtypeM.Items.Add("Otro");
            //Alineamientos
            comboBoxAlineamiento.Items.Add("Seleccionar alineamiento");
            comboBoxAlineamiento.Items.Add("Legal Bueno");
            comboBoxAlineamiento.Items.Add("Neutral Bueno");
            comboBoxAlineamiento.Items.Add("Caótico Bueno");
            comboBoxAlineamiento.Items.Add("Legal Neutral");
            comboBoxAlineamiento.Items.Add("Neutral");
            comboBoxAlineamiento.Items.Add("Caótico Neutral");
            comboBoxAlineamiento.Items.Add("Legal Malvado");
            comboBoxAlineamiento.Items.Add("Neutral Malvado");
            comboBoxAlineamiento.Items.Add("Caótico Malvado");

            // Agregar los ítems de armaduras (basados en tu JSON)
            cbArmaduras.Items.Add("Seleccionar Armadura");
            cbArmaduras.Items.Add("Ninguna");          // none
            cbArmaduras.Items.Add("Armadura Natural"); // natural armor
            cbArmaduras.Items.Add("Armadura de Mago"); // mage armor
            cbArmaduras.Items.Add("Acolchada");        // padded
            cbArmaduras.Items.Add("Cuero");            // leather
            cbArmaduras.Items.Add("Cuero Tachonado");  // studded leather
            cbArmaduras.Items.Add("Oculta");           // hide
            cbArmaduras.Items.Add("Camisa de Malla");  // chain shirt
            cbArmaduras.Items.Add("Armadura de Escamas");  // scale mail
            cbArmaduras.Items.Add("Coraza");               // breastplate
            cbArmaduras.Items.Add("Media Armadura");       // half plate
            cbArmaduras.Items.Add("Armadura de Anillos");  // ring mail
            cbArmaduras.Items.Add("Cota de Malla");        // chain mail
            cbArmaduras.Items.Add("Armadura Laminada");    // splint
            cbArmaduras.Items.Add("Armadura Completa");    // plate
            cbArmaduras.Items.Add("Otra");                 // other
                                                           // Agregar ítems en español con el nombre original entre paréntesis
            cbSavingThrows.Items.Add("Fuerza");
            cbSavingThrows.Items.Add("Destreza");
            cbSavingThrows.Items.Add("Constitución");
            cbSavingThrows.Items.Add("Inteligencia");
            cbSavingThrows.Items.Add("Sabiduría");
            cbSavingThrows.Items.Add("Carisma");

            // Agregar ítems en español con el nombre original en inglés entre paréntesis
            cbHabilidades.Items.Add("Acrobacias");
            cbHabilidades.Items.Add("Trato con Animales");
            cbHabilidades.Items.Add("Arcanos");
            cbHabilidades.Items.Add("Atletismo");
            cbHabilidades.Items.Add("Engaño");
            cbHabilidades.Items.Add("Historia");
            cbHabilidades.Items.Add("Perspicacia");
            cbHabilidades.Items.Add("Intimidación");
            cbHabilidades.Items.Add("Investigación");
            cbHabilidades.Items.Add("Medicina");
            cbHabilidades.Items.Add("Naturaleza");
            cbHabilidades.Items.Add("Percepción");
            cbHabilidades.Items.Add("Interpretación");
            cbHabilidades.Items.Add("Persuasión");
            cbHabilidades.Items.Add("Religión");
            cbHabilidades.Items.Add("Juego de Manos");
            cbHabilidades.Items.Add("Sigilo");
            cbHabilidades.Items.Add("Supervivencia");
            // Agregar ítems solo en español
            cbCondiciones.Items.Add("Cegado");         // Blinded
            cbCondiciones.Items.Add("Hechizado");      // Charmed
            cbCondiciones.Items.Add("Ensordecido");    // Deafened
            cbCondiciones.Items.Add("Agotamiento");    // Exhaustion
            cbCondiciones.Items.Add("Aterrorizado");   // Frightened
            cbCondiciones.Items.Add("Agarrado");       // Grappled
            cbCondiciones.Items.Add("Incapacitado");   // Incapacitated
            cbCondiciones.Items.Add("Invisible");      // Invisible
            cbCondiciones.Items.Add("Paralizado");     // Paralyzed
            cbCondiciones.Items.Add("Petrificado");    // Petrified
            cbCondiciones.Items.Add("Envenenado");     // Poisoned
            cbCondiciones.Items.Add("Derribado");      // Prone
            cbCondiciones.Items.Add("Restringido");    // Restrained
            cbCondiciones.Items.Add("Aturdido");       // Stunned
            cbCondiciones.Items.Add("Inconsciente");   // Unconscious

            // Seleccionar por defecto la primera opción
            cbCondiciones.SelectedIndex = 0;
            // Seleccionar por defecto la primera opción
            cbHabilidades.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem
            cbSavingThrows.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem
            cbArmaduras.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem (opcional)
            comboBoxAlineamiento.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem (opcional)
            cbListtypeM.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem (opcional)
            cbSizes.SelectedIndex = 0;
        }



        private void txtDados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla presionada no es de control ni un dígito, se descarta
                e.Handled = true;
            }
        }

        //////////////////////////////
    }
}
