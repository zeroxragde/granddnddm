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
            cbSavingThrows.Items.Add("Tirada de Salvacion");
            cbSavingThrows.Items.Add("Fuerza");
            cbSavingThrows.Items.Add("Destreza");
            cbSavingThrows.Items.Add("Constitución");
            cbSavingThrows.Items.Add("Inteligencia");
            cbSavingThrows.Items.Add("Sabiduría");
            cbSavingThrows.Items.Add("Carisma");

            // Agregar ítems en español con el nombre original en inglés entre paréntesis
            cbHabilidades.Items.Add("Habilidades");
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

            // Agregar ítems de tipos de daño en español
            cbDamageTypes.Items.Add("Tipo de daño");
            cbDamageTypes.Items.Add("Ácido");
            cbDamageTypes.Items.Add("Contundente");
            cbDamageTypes.Items.Add("Frío");
            cbDamageTypes.Items.Add("Fuego");
            cbDamageTypes.Items.Add("Fuerza");
            cbDamageTypes.Items.Add("Relámpago");
            cbDamageTypes.Items.Add("Necrótico");
            cbDamageTypes.Items.Add("Perforante");
            cbDamageTypes.Items.Add("Veneno");
            cbDamageTypes.Items.Add("Psíquico");
            cbDamageTypes.Items.Add("Radiante");
            cbDamageTypes.Items.Add("Cortante");
            cbDamageTypes.Items.Add("Trueno");
            cbDamageTypes.Items.Add("Ataques no mágicos");
            cbDamageTypes.Items.Add("Ataques no plateados");
            cbDamageTypes.Items.Add("Ataques no adamantinos");
            cbDamageTypes.Items.Add("Otro");
            // Agregar ítems de idiomas en español
            cbIdiomas.Items.Add("Todas");
            cbIdiomas.Items.Add("Abisal");
            cbIdiomas.Items.Add("Acuático");
            cbIdiomas.Items.Add("Áurico");
            cbIdiomas.Items.Add("Celestial");
            cbIdiomas.Items.Add("Común");
            cbIdiomas.Items.Add("Habla Profunda");
            cbIdiomas.Items.Add("Dracónico");
            cbIdiomas.Items.Add("Enano");
            cbIdiomas.Items.Add("Élfico");
            cbIdiomas.Items.Add("Gigante");
            cbIdiomas.Items.Add("Goblin");
            cbIdiomas.Items.Add("Gnómico");
            cbIdiomas.Items.Add("Mediano");
            cbIdiomas.Items.Add("Ígneo");
            cbIdiomas.Items.Add("Infernal");
            cbIdiomas.Items.Add("Orco");
            cbIdiomas.Items.Add("Primordial");
            cbIdiomas.Items.Add("Feérico");
            cbIdiomas.Items.Add("Telúrico");
            cbIdiomas.Items.Add("Subcomún");
            cbIdiomas.Items.Add("Otro");
            // Agrega la opción "CR Personalizado"
            cbCR.Items.Add("CR Personalizado");

            // Agregar las opciones de CR con XP hasta 30
            cbCR.Items.Add("0 (10 XP)");
            cbCR.Items.Add("1/8 (25 XP)");
            cbCR.Items.Add("1/4 (50 XP)");
            cbCR.Items.Add("1/2 (100 XP)");
            cbCR.Items.Add("1 (200 XP)");
            cbCR.Items.Add("2 (450 XP)");
            cbCR.Items.Add("3 (700 XP)");
            cbCR.Items.Add("4 (1,100 XP)");
            cbCR.Items.Add("5 (1,800 XP)");
            cbCR.Items.Add("6 (2,300 XP)");
            cbCR.Items.Add("7 (2,900 XP)");
            cbCR.Items.Add("8 (3,900 XP)");
            cbCR.Items.Add("9 (5,000 XP)");
            cbCR.Items.Add("10 (5,900 XP)");
            cbCR.Items.Add("11 (7,200 XP)");
            cbCR.Items.Add("12 (8,400 XP)");
            cbCR.Items.Add("13 (10,000 XP)");
            cbCR.Items.Add("14 (11,500 XP)");
            cbCR.Items.Add("15 (13,000 XP)");
            cbCR.Items.Add("16 (15,000 XP)");
            cbCR.Items.Add("17 (18,000 XP)");
            cbCR.Items.Add("18 (20,000 XP)");
            cbCR.Items.Add("19 (22,000 XP)");
            cbCR.Items.Add("20 (25,000 XP)");
            cbCR.Items.Add("21 (33,000 XP)");
            cbCR.Items.Add("22 (41,000 XP)");
            cbCR.Items.Add("23 (50,000 XP)");
            cbCR.Items.Add("24 (62,000 XP)");
            cbCR.Items.Add("25 (75,000 XP)");
            cbCR.Items.Add("26 (90,000 XP)");
            cbCR.Items.Add("27 (105,000 XP)");
            cbCR.Items.Add("28 (120,000 XP)");
            cbCR.Items.Add("29 (135,000 XP)");
            cbCR.Items.Add("30 (155,000 XP)");

            // Seleccionar por defecto el primer ítem
            cbCR.SelectedIndex = 0;

            // Seleccionar por defecto el primer ítem
            cbIdiomas.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem
            cbDamageTypes.SelectedIndex = 0;
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



        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla presionada no es de control ni un dígito, se descarta
                e.Handled = true;
            }
        }
        public static string CalcularBonificador(int valor)
        {
            // Se calcula el bonificador con la fórmula (valor - 10) / 2
            int bonificador = (valor - 10) / 2;

            // Se devuelve el resultado en formato string, agregando el signo "+" si es positivo
            return bonificador >= 0 ? $"+{bonificador}" : bonificador.ToString();
        }

        private void txtFuerza_Leave(object sender, EventArgs e)
        {
            string bonificador = CalcularBonificador(int.Parse(txtFuerza.Text));
            lblFuerza.Text = bonificador;
        }

        private void txtDes_Leave(object sender, EventArgs e)
        {
            string bonificador = CalcularBonificador(int.Parse(txtDes.Text));
            lblDes.Text = bonificador;
        }

        private void ttCons_Leave(object sender, EventArgs e)
        {
            string bonificador = CalcularBonificador(int.Parse(txtCons.Text));
            lblCon.Text = bonificador;
        }

        private void txtInt_Leave(object sender, EventArgs e)
        {
            string bonificador = CalcularBonificador(int.Parse(txtInt.Text));
            lblInt.Text = bonificador;
        }

        private void txtSab_Leave(object sender, EventArgs e)
        {
            string bonificador = CalcularBonificador(int.Parse(txtSab.Text));
            lblSab.Text = bonificador;
        }

        private void txtCar_Leave(object sender, EventArgs e)
        {
            string bonificador = CalcularBonificador(int.Parse(txtCar.Text));
            lblCar.Text = bonificador;
        }

        private void cbArmaduras_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = cbArmaduras.SelectedItem.ToString();
            if (selectedValue == "Armadura Natural")
            {
                txtBonus.Visible = true;
            }
            else
            {
                txtBonus.Visible = false;
            }
        }

        private void btnAddTiradaSave_Click(object sender, EventArgs e)
        {
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbSavingThrows.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3)
            };

            // Creamos el Label con el texto
            Label lbl = new Label
            {
                Text = textoSeleccionado,
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                BackColor = Color.DarkGreen
            };

            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(32, 32),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pTiradasSav.Controls.Remove(contenedor);
                // Liberamos recursos
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);

            // Agregamos el contenedor al FlowLayoutPanel principal
            pTiradasSav.Controls.Add(contenedor);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            Close();

        }










        //////////////////////////////
    }
}
