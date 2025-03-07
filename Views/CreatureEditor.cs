using GranDnDDM.Models;
using GranDnDDM.Models.Creatura;
using GranDnDDM.Tools;
using Newtonsoft.Json;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class CreatureEditor : Form
    {
        private Creatura creatura;

        public CreatureEditor(Creatura c)
        {
            creatura = c;
            init_app();
        }
        public CreatureEditor()
        {
            creatura = new Creatura();
            init_app();
        }
        private void init_app()
        {
            InitializeComponent();

            // Supongamos que tienes el JSON en un archivo "abilities.json" 
            string json = File.ReadAllText("statblockdata.json");

            // Deserializa al objeto Root
            StatBlockData root = JsonConvert.DeserializeObject<StatBlockData>(json);
            // Asigna la lista como DataSource del ComboBox
            cbPresents.DataSource = root.CommonAbilities;
            cbPresents.DisplayMember = "Name";
            if (cbPresents.Items.Count > 0)
            {
                cbPresents.SelectedIndex = 0;
            }
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
            cbCondiciones.Items.Add("Seleccionar Estado");         // Blinded
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
            if (txtFuerza.Text == "")
            {
                return;
            }
            string bonificador = CalcularBonificador(int.Parse(txtFuerza.Text));
            lblFuerza.Text = bonificador;
            creatura.Fuerza = int.Parse(txtFuerza.Text);
            creatura.BonificadorFuerza = int.Parse(bonificador);
        }

        private void txtDes_Leave(object sender, EventArgs e)
        {
            if (txtDes.Text == "")
            {
                return;
            }
            string bonificador = CalcularBonificador(int.Parse(txtDes.Text));
            lblDes.Text = bonificador;
            creatura.Destreza = int.Parse(txtDes.Text);
            creatura.BonificadorDestreza = int.Parse(bonificador);
        }

        private void ttCons_Leave(object sender, EventArgs e)
        {
            if (txtCons.Text == "")
            {
                return;
            }
            string bonificador = CalcularBonificador(int.Parse(txtCons.Text));
            lblCon.Text = bonificador;
            creatura.Constitucion = int.Parse(txtCons.Text);
            creatura.BonificadorConstitucion = int.Parse(bonificador);
        }

        private void txtInt_Leave(object sender, EventArgs e)
        {
            if (txtInt.Text == "")
            {
                return;
            }
            string bonificador = CalcularBonificador(int.Parse(txtInt.Text));
            lblInt.Text = bonificador;
            creatura.Inteligencia = int.Parse(txtInt.Text);
            creatura.BonificadorInteligencia = int.Parse(bonificador);
        }

        private void txtSab_Leave(object sender, EventArgs e)
        {
            if (txtSab.Text == "")
            {
                return;
            }
            string bonificador = CalcularBonificador(int.Parse(txtSab.Text));
            lblSab.Text = bonificador;
            creatura.Sabiduria = int.Parse(txtSab.Text);
            creatura.BonificadorSabiduria = int.Parse(bonificador);
        }

        private void txtCar_Leave(object sender, EventArgs e)
        {
            if (txtCar.Text == "")
            {
                return;
            }
            string bonificador = CalcularBonificador(int.Parse(txtCar.Text));
            lblCar.Text = bonificador;
            creatura.Carisma = int.Parse(txtCar.Text);
            creatura.BonificadorCarisma = int.Parse(bonificador);
        }

        private void cbArmaduras_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = cbArmaduras.SelectedItem.ToString();
            if (selectedValue == "Armadura Natural" || selectedValue == "Otra")
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
            int id = cbSavingThrows.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.Salvacion != null)
            {
                if (creatura.Salvacion.Contains(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
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
                creatura.Salvacion.RemoveAll(s => s == contenedor.Tag);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.Salvacion.Add(textoSeleccionado);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pTiradasSav.Controls.Add(contenedor);

        }

        private void tabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabPage1.SelectedIndex;
            if (selectedIndex == 4)
            {
                tabPage1.SelectedIndex = 0;
                //GUARDAR EN .cre
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivos CREA|*.crea|Todos los archivos|*.*";
                sfd.Title = "Guardar archivo de criatura";
                sfd.FileName = "mi_creatura.crea"; // Nombre sugerido
                sfd.OverwritePrompt = false;

                // Si el usuario selecciona un archivo...
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Serializa la criatura a JSON
                    string json = JsonConvert.SerializeObject(creatura, Formatting.Indented);
                    // Guarda el JSON en el archivo elegido
                    File.WriteAllText(sfd.FileName, json);

                    ActualizarRegistroCreatura(sfd.FileName);
                    CreatureGen creatureGen = new CreatureGen(creatura);
                    creatureGen.Show();
                    Hide();

                    MessageBox.Show("Archivo guardado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }



                return;
            }
            if (selectedIndex == 5)
            {
                Hide();
            }

        }
        private void ActualizarRegistroCreatura(string savedFilePath)
        {
            // Definir la ruta del archivo de registros
            string creaturasJsonFile = Path.Combine(Application.StartupPath, "Creaturas.json");
            List<CreaturaRecord> registros;

            // Si el archivo existe, lo deserializamos; de lo contrario, creamos una nueva lista
            if (File.Exists(creaturasJsonFile))
            {
                string jsonExistente = File.ReadAllText(creaturasJsonFile);
                registros = JsonConvert.DeserializeObject<List<CreaturaRecord>>(jsonExistente) ?? new List<CreaturaRecord>();
            }
            else
            {
                registros = new List<CreaturaRecord>();
            }

            // Creamos un nuevo registro usando el nombre del archivo (sin la ruta completa) y la propiedad Nombre
            var nuevoRegistro = new CreaturaRecord
            {
                FileName = Path.GetFileName(savedFilePath),
                Nombre = creatura.Nombre,
                CR = creatura.CR
            };

            registros.Add(nuevoRegistro);

            // Serializamos la lista actualizada y la escribimos en Creaturas.json
            string nuevoJson = JsonConvert.SerializeObject(registros, Formatting.Indented);
            File.WriteAllText(creaturasJsonFile, nuevoJson);
        }
        private void btnAddAbilityCom_Click(object sender, EventArgs e)
        {
            addAbility("COMPETENTE");
        }
        private void btnAddHabilidadExperto_Click(object sender, EventArgs e)
        {
            addAbility("EXPERTO");
        }
        private void addAbility(string tipo)
        {
            int id = cbHabilidades.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbHabilidades.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.Habilidades != null)
            {
                if (creatura.Habilidades.ContainsKey(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
            };

            // Creamos el Label con el texto
            Label lbl = new Label
            {
                Text = textoSeleccionado + " (" + tipo + ")",
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
                pHabilidades.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.Habilidades.Remove(textoSeleccionado);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.Habilidades.Add(textoSeleccionado, tipo);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pHabilidades.Controls.Add(contenedor);
        }

        private void btnAddCondiciones_Click(object sender, EventArgs e)
        {
            int id = cbCondiciones.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbCondiciones.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.InmunidadesCondicion != null)
            {
                if (creatura.InmunidadesCondicion.Contains(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
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
                pCondiciones.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.InmunidadesCondicion.RemoveAll(s => s == contenedor.Tag);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.InmunidadesCondicion.Add(textoSeleccionado);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pCondiciones.Controls.Add(contenedor);
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            creatura.Nombre = txtNombre.Text;
        }

        private void cbListtypeM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cbListtypeM.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbListtypeM.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (textoSeleccionado == "Otro")
            {
                txtOtraTipoCreatura.Text = "";
                txtOtraTipoCreatura.Visible = true;
            }
            else
            {
                txtOtraTipoCreatura.Visible = false;
                creatura.Tipo = textoSeleccionado;

            }
        }

        private void txtOtraTipoCreatura_Leave(object sender, EventArgs e)
        {
            creatura.Tipo = txtOtraTipoCreatura.Text;
        }

        private void txtDados_Leave(object sender, EventArgs e)
        {
            if (cbSizes.SelectedItem != null)
            {
                string sizeSeleccionado = cbSizes.SelectedItem.ToString();
                creatura.Tamanio = sizeSeleccionado;

                switch (sizeSeleccionado)
                {
                    case "Diminuto":
                        // Acción para "Diminuto" (valor 4)
                        creatura.DadosGolpe = "(" + txtDados.Text + "d4)";
                        creatura.PuntosGolpe = GlobalTools.RollDice($"[{txtDados.Text}d4]");
                        break;
                    case "Pequeño":
                        // Acción para "Pequeño" (valor 6)
                        creatura.DadosGolpe = "(" + txtDados.Text + "d6)";
                        creatura.PuntosGolpe = GlobalTools.RollDice($"[{txtDados.Text}d6]");
                        break;
                    case "Mediano":
                        // Acción para "Mediano" (valor 8)
                        creatura.DadosGolpe = "(" + txtDados.Text + "d8)";
                        creatura.PuntosGolpe = GlobalTools.RollDice($"[{txtDados.Text}d8]");
                        break;
                    case "Grande":
                        // Acción para "Grande" (valor 10)
                        creatura.DadosGolpe = "(" + txtDados.Text + "d10)";
                        creatura.PuntosGolpe = GlobalTools.RollDice($"[{txtDados.Text}d10]");
                        break;
                    case "Enorme":
                        // Acción para "Enorme" (valor 12)
                        creatura.DadosGolpe = "(" + txtDados.Text + "d12)";
                        creatura.PuntosGolpe = GlobalTools.RollDice($"[{txtDados.Text}d12]");
                        break;
                    case "Gargantuesco":
                        // Acción para "Gargantuesco" (valor 20)
                        creatura.DadosGolpe = "(" + txtDados.Text + "d20)";
                        creatura.PuntosGolpe = GlobalTools.RollDice($"[{txtDados.Text}d20]");
                        break;
                }
            }

        }

        private void cbArmaduras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbArmaduras.SelectedItem != null)
            {
                string armaduraSeleccionada = cbArmaduras.SelectedItem.ToString();
                creatura.ClaseArmadura = 10;
                creatura.DescripcionArmadura = armaduraSeleccionada;
                switch (armaduraSeleccionada)
                {

                    case "Armadura de Mago":
                        // Acción para "Armadura de Mago" (mage armor)
                        creatura.DescripcionArmadura = "13 " + armaduraSeleccionada;
                        break;
                    case "Acolchada":
                    case "Cuero":
                        // Acción para "Cuero" (leather)
                        creatura.ClaseArmadura = 11;
                        break;
                    case "Cuero Tachonado":
                    case "Oculta":
                        // Acción para "Oculta" (hide)
                        creatura.ClaseArmadura = 12;
                        break;
                    case "Camisa de Malla":
                        // Acción para "Camisa de Malla" (chain shirt)
                        creatura.ClaseArmadura = 13;
                        break;
                    case "Armadura de Escamas":
                    // Acción para "Armadura de Escamas" (scale mail)
                    case "Coraza":
                        // Acción para "Coraza" (breastplate)
                        creatura.ClaseArmadura = 14;
                        break;
                    case "Media Armadura":
                        // Acción para "Media Armadura" (half plate)
                        creatura.ClaseArmadura = 15;
                        break;
                    case "Armadura de Anillos":
                        // Acción para "Armadura de Anillos" (ring mail)
                        creatura.ClaseArmadura = 14;
                        break;
                    case "Cota de Malla":
                        // Acción para "Cota de Malla" (chain mail)
                        creatura.ClaseArmadura = 16;
                        break;
                    case "Armadura Laminada":
                        // Acción para "Armadura Laminada" (splint)
                        creatura.ClaseArmadura = 17;
                        break;
                    case "Armadura Completa":
                        // Acción para "Armadura Completa" (plate)
                        creatura.ClaseArmadura = 18;
                        break;
                    case "Otra":
                        // Acción para "Otra" (other)
                        Console.WriteLine("Se ha seleccionado 'Otra' (other)");
                        break;
                    default:
                        Console.WriteLine("Opción no reconocida");
                        break;
                }
            }
        }

        private void txtBonus_Leave(object sender, EventArgs e)
        {
            if (cbArmaduras.SelectedItem != null)
            {
                string armaduraSeleccionada = cbArmaduras.SelectedItem.ToString();
                if (armaduraSeleccionada == "Armadura Natural")
                {
                    creatura.ClaseArmadura = 10 + int.Parse(txtBonus.Text);
                }
                if (armaduraSeleccionada == "Otra")
                {
                    creatura.ClaseArmadura = -1;
                    creatura.DescripcionArmadura = txtBonus.Text;
                }
            }

        }


        private void txtVCavado_Leave(object sender, EventArgs e)
        {
            if (sender is Control ctrl)
            {
                string texto = ctrl.Text;  // si la propiedad Text está sobreescrita
                switch (ctrl.Tag.ToString())
                {
                    case "caminar":
                        if (!string.IsNullOrEmpty(txtVelocidad.Text))
                            creatura.VelocidadCaminar = int.Parse(txtVelocidad.Text);
                        break;
                    case "escalar":
                        if (!string.IsNullOrEmpty(txtVEscalado.Text))
                            creatura.VelocidadEscalado = int.Parse(txtVEscalado.Text);
                        break;
                    case "cavar":
                        if (!string.IsNullOrEmpty(txtVCavado.Text))
                            creatura.VelocidadCavar = int.Parse(txtVCavado.Text);
                        break;
                    case "volar":
                        if (!string.IsNullOrEmpty(txtVVuelo.Text))
                            creatura.VelocidadVolar = int.Parse(txtVVuelo.Text);
                        break;
                    case "nadar":
                        if (!string.IsNullOrEmpty(txtVNado.Text))
                            creatura.VelocidadNadar = int.Parse(txtVNado.Text);
                        break;
                }

            }
        }

        private void cbSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSizes.SelectedItem != null)
            {
                string sizeSeleccionada = cbSizes.SelectedItem.ToString();
                creatura.Tamanio = sizeSeleccionada;

            }
        }

        private void btnDemageTypesVul_Click(object sender, EventArgs e)
        {
            int id = cbDamageTypes.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbDamageTypes.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.VulnerabilidadesDano != null)
            {
                if (creatura.VulnerabilidadesDano.Contains(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
            };

            // Creamos el Label con el texto
            Label lbl = new Label
            {
                Text = textoSeleccionado + "(Vulnerable)",
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                BackColor = Color.DarkRed
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
                pDasmagesList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.VulnerabilidadesDano.RemoveAll(s => s == contenedor.Tag);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.VulnerabilidadesDano.Add(textoSeleccionado);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pDasmagesList.Controls.Add(contenedor);
        }

        private void btnDemageTypesRes_Click(object sender, EventArgs e)
        {
            int id = cbDamageTypes.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbDamageTypes.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.ResistenciasDano != null)
            {
                if (creatura.ResistenciasDano.Contains(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
            };

            // Creamos el Label con el texto
            Label lbl = new Label
            {
                Text = textoSeleccionado + "(Resistente)",
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                BackColor = Color.DarkOrange
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
                pDasmagesList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.ResistenciasDano.RemoveAll(s => s == contenedor.Tag);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.ResistenciasDano.Add(textoSeleccionado);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pDasmagesList.Controls.Add(contenedor);
        }

        private void btnDemageTypesInmu_Click(object sender, EventArgs e)
        {
            int id = cbDamageTypes.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbDamageTypes.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.InmunidadesDano != null)
            {
                if (creatura.InmunidadesDano.Contains(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
            };

            // Creamos el Label con el texto
            Label lbl = new Label
            {
                Text = textoSeleccionado + "(Inmune)",
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                BackColor = Color.DarkViolet
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
                pDasmagesList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.InmunidadesDano.RemoveAll(s => s == contenedor.Tag);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.InmunidadesDano.Add(textoSeleccionado);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pDasmagesList.Controls.Add(contenedor);
        }

        private void btnAddHabla_Click(object sender, EventArgs e)
        {
            string telepatia = txtTelepatia.Text != "" ? " Telepatia en " + txtTelepatia.Text : "";
            addIdioma("Habla" + telepatia);
        }
        private void btnAddEntiende_Click(object sender, EventArgs e)
        {
            string telepatia = txtTelepatia.Text != "" ? " Telepatia en " + txtTelepatia.Text : "";
            addIdioma("Entiende" + telepatia);
        }

        private void addIdioma(string tipo)
        {
            int id = cbIdiomas.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbIdiomas.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            if (creatura.Idiomas != null)
            {
                if (creatura.Idiomas.ContainsKey(textoSeleccionado))
                {
                    return;
                }
            }

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = textoSeleccionado
            };

            // Creamos el Label con el texto
            Label lbl = new Label
            {
                Text = textoSeleccionado + " (" + tipo + ")",
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                BackColor = Color.DarkViolet
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
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.Idiomas.Remove(textoSeleccionado);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            contenedor.Controls.Add(lbl);
            contenedor.Controls.Add(picRemove);
            creatura.Idiomas.Add(textoSeleccionado, tipo);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pIdiomasList.Controls.Add(contenedor);
        }

        private void cbShield_CheckedChanged(object sender, EventArgs e)
        {
            var combo = (System.Windows.Forms.CheckBox)sender;

            if (combo != null)
            {
                // Aquí puedes verificar el nuevo estado
                if (!combo.Checked)
                {
                    creatura.ClaseArmadura += 2;
                }
                else
                {
                    creatura.ClaseArmadura -= 2;
                }
            }
        }

        private void txtVistaCiega_Leave(object sender, EventArgs e)
        {
            if(txtVistaCiega.Text == "") { return; }
            string masalla = cbCiegoMasAlla.Checked ? "Ciego mas alla de " : "Ciego en ";
            creatura.Sentidos.Add(masalla + txtVistaCiega.Text + " pies");
        }

        private void txtVistaNocturna_Leave(object sender, EventArgs e)
        {
            if (txtVistaNocturna.Text == "") { return; }
            creatura.Sentidos.Add("Vision nocturna en " + txtVistaNocturna.Text + " pies");
        }

        private void txtSentidoSismico_Leave(object sender, EventArgs e)
        {
            if (txtSentidoSismico.Text == "") { return; }
            creatura.Sentidos.Add("Sntido sismico en " + txtSentidoSismico.Text + " pies");
        }

        private void txtVisionVerdadera_Leave(object sender, EventArgs e)
        {
            if (txtVisionVerdadera.Text == "") { return; }
            creatura.Sentidos.Add("Vision verdadera en " + txtVisionVerdadera.Text + " pies");
        }

        private void cbCR_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cbCR.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            string textoSeleccionado = cbCR.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(textoSeleccionado)) return;
            // Se espera el formato: "CR (XP XP)"
            // Ejemplo: "1/4 (50 XP)" o "0 (10 XP)"
            var regex = new System.Text.RegularExpressions.Regex(@"^(.+?)\s*\((\d+)\s*XP\)$");
            var match = regex.Match(textoSeleccionado);
            if (match.Success)
            {
                string cr = match.Groups[1].Value.Trim();
                int xp = int.Parse(match.Groups[2].Value.Trim());
                creatura.CR = cr;
                creatura.XP = xp;
            }


        }

        private void cbCreaturaLegendaria_CheckedChanged(object sender, EventArgs e)
        {
            // Aquí puedes verificar el nuevo estado
            if (cbCreaturaLegendaria.Checked)
            {
                creatura.EsLegendaria = true;
                lblLegendarioText.Visible = true;
                if (txtNombre.Text != "")
                {
                    lblLegendarioText.Text = lblLegendarioText.Text.Replace("[MON]", txtNombre.Text);
                }
                btnAddLegendaryAction.Visible = true;
            }
            else
            {
                creatura.EsLegendaria = false;
                lblLegendarioText.Visible = false;
                btnAddLegendaryAction.Visible = false;
            }

        }

        private void cbMitica_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMitica.Checked)
            {
                creatura.EsMitica = true;
                txtRasgoMitico.Visible = true;
                if (txtNombre.Text != "")
                {
                    txtRasgoMitico.Text = txtRasgoMitico.Text.Replace("[MON]", txtNombre.Text);
                }
                btnAddMistycAction.Visible = true;
            }
            else
            {
                creatura.EsLegendaria = false;
                txtRasgoMitico.Visible = false;
                btnAddMistycAction.Visible = false;

            }
        }

        private void cbGuarida_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGuarida.Checked)
            {
                creatura.TieneGuarida = true;
                txtRasgoGuarida.Visible = true;
                if (txtNombre.Text != "")
                {
                    txtRasgoGuarida.Text = txtRasgoGuarida.Text.Replace("[MON]", txtNombre.Text);
                }
                btnAddGuaridaAction.Visible = true;
            }
            else
            {
                creatura.TieneGuarida = false;
                txtRasgoGuarida.Visible = false;
                btnAddGuaridaAction.Visible = false;

            }
        }

        private void cbRegional_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRegional.Checked)
            {
                creatura.TieneEfectosRegionales = true;
                txtRasgoRegional.Visible = true;
                if (txtNombre.Text != "")
                {
                    txtRasgoRegional.Text = txtRasgoRegional.Text.Replace("[MON]", txtNombre.Text);
                }
                btnEfectoRegional.Visible = true;
            }
            else
            {
                creatura.TieneEfectosRegionales = false;
                txtRasgoRegional.Visible = false;
                btnEfectoRegional.Visible = false;

            }
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            creatura.DescripcionMitica = txtRasgoMitico.Text;
            creatura.DescripcionRegional = txtRasgoRegional.Text;
            creatura.DescripcionGuarida = txtRasgoGuarida.Text;
        }

        private void cbPresents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUsePresent_Click(object sender, EventArgs e)
        {
            int id = cbPresents.SelectedIndex;
            if (id == 0)
            {
                return;
            }
            // Obtenemos el texto seleccionado en el ComboBox
            CommonAbility itemSeleccionado = cbPresents.SelectedItem as CommonAbility;
            txtDesAction.Text = itemSeleccionado.Desc;
            txtNameAction.Text = itemSeleccionado.Name;
        }
        private string descriptionFilter(string des)
        {
            string res = des;

            if (txtNombre.Text != "")
            {
                res = res.Replace("[MON]", txtNombre.Text);
            }
            if (txtCar.Text != "")
            {
                res = res.Replace("[CHA]", txtCar.Text);
            }
            if (txtFuerza.Text != "")
            {
                res = res.Replace("[FUE]", txtFuerza.Text);
            }
            if (txtDes.Text != "")
            {
                res = res.Replace("[DES]", txtDes.Text);
            }
            if (txtCons.Text != "")
            {
                res = res.Replace("[CON]", txtCons.Text);
            }
            if (txtSab.Text != "")
            {
                res = res.Replace("[SAB]", txtSab.Text);
            }
            if (txtInt.Text != "")
            {
                res = res.Replace("[INT]", txtInt.Text);
            }
            string dados = ExtractDicePattern(res);
            if (dados != "") {
                int tirada = GlobalTools.RollDice(dados);
                res = Regex.Replace(res, @"\[\d+[dD]\d+\]", tirada + $"({dados})");
            }
        
           
            int saving = CalculateSavingThrow(res);
            if (saving != 0)
            {
                res = Regex.Replace(res, @"\[[A-Za-z]+\s+[A-Za-z]+\]", saving.ToString());
            }


            Regex regex = new Regex(@"\[\w+\s+\d+D\d+\]", RegexOptions.IgnoreCase);
            if (regex.IsMatch(res)) {
                var result = ExtraerStatYDado(res);
                if (result.HasValue)
                {
                    string stat = result.Value.stat;
                    string dado = result.Value.dado;
                    int tirada = GlobalTools.RollDice(dado);
                    switch (stat.ToUpper())
                    {
                        case "FUE":
                            stat = txtFuerza.Text;
                            break;
                        case "DES":
                            stat = txtDes.Text;
                            break;
                        case "INT":
                            stat = txtInt.Text;
                            break;
                        case "CAR":
                            stat = txtCar.Text;
                            break;
                        case "SAB":
                            stat = txtSab.Text;
                            break;
                        case "CON":
                            stat = txtCons.Text;
                            break;
                        default:
                            Console.WriteLine("Otro stat detectado.");
                            break;
                    }
                    string final = stat + "+" + tirada + $"({dado})";
                    res = Regex.Replace(res, @"\[\w+\s+\d+D\d+\]", final);
                }

            }


            res = res.Replace("[", "").Replace("]", "");
            return res;
        }
        private (string stat, string dado)? ExtraerStatYDado(string input)
        {
            // Expresión regular para detectar el patrón [STAT XDY]
            Regex regex = new Regex(@"\[(\w+)\s+(\d+D\d+)\]", RegexOptions.IgnoreCase);
            Match match = regex.Match(input);

            if (match.Success)
            {
                string stat = match.Groups[1].Value.ToUpper(); // FUE, DEX, etc.
                string dado = match.Groups[2].Value.ToUpper(); // 1D8, 2D6, etc.
                return (stat, dado);
            }

            return null; // Retorna null si no coincide el formato
        }
        public string ExtractDicePattern(string input)
        {
            // Patrón que busca [nDk], donde n y k son números
            var match = Regex.Match(input, @"\[\d+[dD]\d+\]");
            return match.Success ? match.Value : string.Empty;
        }
        // Método que calcula la tirada de salvación para una habilidad dada.
        public int CalculateSavingThrow(string input)
        {
            Regex regex = new Regex(@"\[[A-Z]+\s+SAVE\]", RegexOptions.IgnoreCase);
            Match match = regex.Match(input);
            // Extraemos la abreviatura de la habilidad del string
            // Ejemplo: "[INT SAVE]" se convierte en "INT"
            string modSave = match.Value; // Ejemplo: "[INT SAVE]"

            string ability = modSave.Replace("[", "")
                                    .Replace("]", "")
                                    .ToUpper()
                                    .Replace(" SAVE", "")
                                    .Trim();
            int abilityScore = 0;
            bool esCompetente = false;
            switch (ability)
            {
                case "FUE":
                case "FUERZA":
                    abilityScore = creatura.Fuerza;
                    esCompetente = creatura.Salvacion.Contains("Fuerza") ? true : false;
                    break;
                case "DES":
                case "DESTREZA":
                    abilityScore = creatura.Destreza;
                    esCompetente = creatura.Salvacion.Contains("Destreza") ? true : false;
                    break;
                case "CON":
                case "CONSTITUCION":
                    abilityScore = creatura.Constitucion;
                    esCompetente = creatura.Salvacion.Contains("Constitucion") ? true : false;
                    break;
                case "INT":
                case "INTELIGENCIA":
                    abilityScore = creatura.Inteligencia;
                    esCompetente = creatura.Salvacion.Contains("Inteligencia") ? true : false;
                    break;
                case "SAB":
                case "SABIDURIA":
                    abilityScore = creatura.Sabiduria;
                    esCompetente = creatura.Salvacion.Contains("Sabiduria") ? true : false;
                    break;
                case "CHA":
                case "CARISMA":
                    abilityScore = creatura.Carisma;
                    esCompetente = creatura.Salvacion.Contains("Carisma") ? true : false;
                    break;
                default:
                    abilityScore = 0;break;
            }
            
            int abilityModifier = (abilityScore - 10) / 2;
            
            int savingThrowBonus = abilityModifier + (esCompetente ? CalculateProficiencyBonus(creatura.CR) : 0);
            return abilityModifier;
        }

        /// <summary>
        /// Calcula el bono de competencia a partir de un string del CR.
        /// </summary>
        /// <param name="crItem">El string con el formato "CR (XP)", por ejemplo: "1/4 (50 XP)"</param>
        /// <returns>El bono de competencia correspondiente.</returns>
        public int CalculateProficiencyBonus(string crItem)
        {
            if (crItem == "") { return 0; }
            // Extrae la parte del CR, asumiendo que es la primera parte antes del espacio.
            string crPart = crItem.Split(' ')[0]; // Ejemplo: "1/4"
            double crValue = ParseCR(crPart);

            // Según el Manual de Monstruos:
            // CR 0 hasta 4 (incluyendo fracciones menores a 1) = +2
            // CR 5 a 8 = +3
            // CR 9 a 12 = +4
            // CR 13 a 16 = +5
            // CR 17 a 20 = +6
            // CR 21 a 24 = +7
            // CR 25 a 28 = +8
            // CR 29 a 30 = +9

            if (crValue < 5)
            {
                return 2;
            }
            else if (crValue >= 5 && crValue <= 8)
            {
                return 3;
            }
            else if (crValue >= 9 && crValue <= 12)
            {
                return 4;
            }
            else if (crValue >= 13 && crValue <= 16)
            {
                return 5;
            }
            else if (crValue >= 17 && crValue <= 20)
            {
                return 6;
            }
            else if (crValue >= 21 && crValue <= 24)
            {
                return 7;
            }
            else if (crValue >= 25 && crValue <= 28)
            {
                return 8;
            }
            else if (crValue >= 29 && crValue <= 30)
            {
                return 9;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Convierte una cadena que representa un CR a un valor double.
        /// Soporta formatos fraccionales (ej. "1/4") y enteros.
        /// </summary>
        private double ParseCR(string crString)
        {
            if (crString.Contains("/"))
            {
                // Si es fraccional, por ejemplo "1/4"
                string[] parts = crString.Split('/');
                if (parts.Length == 2 &&
                    double.TryParse(parts[0], out double numerator) &&
                    double.TryParse(parts[1], out double denominator) &&
                    denominator != 0)
                {
                    return numerator / denominator;
                }
            }
            else
            {
                if (double.TryParse(crString, out double value))
                {
                    return value;
                }
            }
            return -1;
        }
        private void btnAddAbility_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Habilidad): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.AccionesHabilidad.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.AccionesHabilidad.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);

        }

        private void btnAddAction_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Accion): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.Acciones.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.Acciones.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }

        private void btnAddReaction_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Reaccion): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.Reacciones.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.Reacciones.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }

        private void btnAddActonBonus_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Accion Bonus): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.AccionesAdicionales.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.AccionesAdicionales.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }

        private void btnAddLegendaryAction_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            AccionLegendaria accion = new AccionLegendaria();
            accion.Nombre = actionName;
            accion.Descripcion = description;
            accion.CostoAccion = 0;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Accion Legendaria): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.AccionesLegendarias.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.AccionesLegendarias.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }

        private void btnAddMistycAction_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Accion Mitica): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.AccionesMiticas.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.AccionesMiticas.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }

        private void btnAddGuaridaAction_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Accion Guarida): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.AccionesGuarida.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.AccionesGuarida.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }

        private void btnEfectoRegional_Click(object sender, EventArgs e)
        {
            string actionName = txtNameAction.Text;
            string description = descriptionFilter(txtDesAction.Text);
            Accion accion = new Accion();
            accion.Nombre = actionName;
            accion.Descripcion = description;

            // Creamos un contenedor (Panel) para el Label y el PictureBox
            FlowLayoutPanel contenedor = new FlowLayoutPanel
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(3),
                Tag = actionName
            };
            // Label para actionName en negrita
            Label lblAction = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //    BackColor = Color.DarkBlue,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold),
                Text = actionName + "(Accion Region): "
            };

            // Label para descripción en texto normal
            Label lblDesc = new Label
            {
                AutoSize = true,
                Margin = new Padding(3),
                ForeColor = Color.White,
                //  BackColor = Color.DarkViolet,
                Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold),
                Text = description
            };


            // Creamos el PictureBox como botón para eliminar
            PictureBox picRemove = new PictureBox
            {
                // Asigna aquí tu icono de eliminar; puede ser un recurso de tu proyecto o una imagen cargada
                Image = Properties.Resources.x_icon,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand,
                Size = new Size(16, 16),
                Margin = new Padding(3)
            };

            // Evento click del PictureBox para eliminar el panel
            picRemove.Click += (s, ev) =>
            {
                // Quitamos el contenedor del panel principal
                pIdiomasList.Controls.Remove(contenedor);
                // Liberamos recursos
                creatura.EfectosRegionales.RemoveAll(s => s == accion);
                contenedor.Dispose();
            };

            // Agregamos el Label y el PictureBox al contenedor
            // Luego, agrégales al contenedor (por ejemplo, a un Panel o al formulario)
            contenedor.Controls.Add(lblAction);
            contenedor.Controls.Add(lblDesc);
            contenedor.Controls.Add(picRemove);
            creatura.EfectosRegionales.Add(accion);
            // Agregamos el contenedor al FlowLayoutPanel principal
            pAcciones.Controls.Add(contenedor);
        }




















        //////////////////////////////
    }
}
