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
    public partial class ConversorMoneda : Form
    {

        // Diccionario para convertir cada moneda a Copper Pieces (cp)
        private Dictionary<string, double> toCopper = new Dictionary<string, double>()
        {
            { "cp", 1 },    // Copper
            { "sp", 10 },   // Silver
            { "ep", 50 },   // Electrum
            { "gp", 100 },  // Gold
            { "pp", 1000 }  // Platinum
        };

        public ConversorMoneda()
        {
            InitializeComponent();
            cmbTo.Items.AddRange(new object[] { "cp", "sp", "ep", "gp", "pp" });
            cmbFrom.Items.AddRange(new object[] { "cp", "sp", "ep", "gp", "pp" });
            cmbFrom.SelectedIndex = 0; // Seleccionar por defecto "gp"
            cmbTo.SelectedIndex = 3; // Seleccionar por defecto "gp"
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            // Intentar parsear la cantidad ingresada
            if (txtAmount.ValueNumber > 0)
            {
                string fromCurrency = cmbFrom.SelectedItem.ToString();
                string toCurrency = cmbTo.SelectedItem.ToString();

                // Convertir la cantidad a copper (cp)
                double amountInCopper = txtAmount.ValueNumber * toCopper[fromCurrency];

                // Convertir de copper (cp) a la moneda de destino
                double convertedAmount = amountInCopper / toCopper[toCurrency];

                // Mostrar el resultado
                lblResult.Text = $"{convertedAmount} {toCurrency}";
            }
            else
            {
                MessageBox.Show("Ingresa una cantidad valida",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
