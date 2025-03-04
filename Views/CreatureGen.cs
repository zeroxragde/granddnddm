using ReaLTaiizor.Controls;
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
    public partial class CreatureGen : Form
    {
        private NightLabel lblActual;
        public CreatureGen()
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

            // Seleccionar por defecto el primer ítem (opcional)
            comboBoxAlineamiento.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem (opcional)
            cbListtypeM.SelectedIndex = 0;
            // Seleccionar por defecto el primer ítem (opcional)
            cbSizes.SelectedIndex = 0;
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            lblActual = lblName;
            editorOn();
        }



        private void foreverToggle1_CheckedChanged(object sender)
        {
            foreach (Control c in pCard.Controls)
            {
                if (c.GetType() == typeof(FlowLayoutPanel))
                {
                    foreach (Control pc in c.Controls)
                    {
                        if (pc.Tag == "editButton")
                        {
                            pc.Visible = !pc.Visible;
                        }
                    }
                }

            }
        }
        private void editorOn()
        {
            winEditor.Location = new Point((Width/2)-(winEditor.Width/2),( Height/2)-winEditor.Height);
            winEditor.Visible = true;
        }

        private void btnWinEditSasve_Click(object sender, EventArgs e)
        {
            lblActual.Text = txtWinEditorNuevoVal.Text;
            winEditor.Visible = false;
        }




        ////////////
    }
}
