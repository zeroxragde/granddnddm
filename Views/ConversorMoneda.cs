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
            { "COBRE", 1 },    // Cobre
            { "PLATA", 10 },   // Plata
            { "ELECTRUM", 50 },   // Electrum
            { "ORO", 100 },  // Oro
            { "PLATINO", 1000 }  // Platino
        };

        public ConversorMoneda()
        {
            InitializeComponent();
            cmbTo.Items.AddRange(new object[] { "COBRE", "PLATA", "ELECTRUM", "ORO", "PLATINO" });
            cmbFrom.Items.AddRange(new object[] { "COBRE", "PLATA", "ELECTRUM", "ORO", "PLATINO" });
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
