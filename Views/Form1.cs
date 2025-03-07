using GranDnDDM.Models;
using GranDnDDM.Tools;
using GranDnDDM.Views;

namespace GranDnDDM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            // Obtiene el monitor actual donde se muestra la aplicación
            Screen currentScreen = Screen.FromControl(this);
            MonitorItem itemASeleccionar = null;


            int contador = 1;
            // Recorre todos los monitores y los agrega al ComboBox
            foreach (var screen in Screen.AllScreens)
            {
                if (screen.DeviceName == currentScreen.DeviceName)
                {
                    continue;
                }
                MonitorItem item = new MonitorItem
                {
                    Screen = screen,
                    NombreClave = $"Monitor {contador}" // Nombre clave amigable
                };
                contador++;

                comboBox1.Items.Add(item);

                // Selecciona el primer monitor que no sea el actual
                if (itemASeleccionar == null && screen.DeviceName != currentScreen.DeviceName)
                {
                    itemASeleccionar = item;
                }
            }

            // Si se encontró un monitor diferente, se selecciona; de lo contrario, se selecciona el primero
            if (itemASeleccionar != null)
            {
                comboBox1.SelectedItem = itemASeleccionar;
            }
            else if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

        }

        private void btnStasrt_Click(object sender, EventArgs e)
        {
            if (txtDMName.Text == "")
            {
                MessageBox.Show("Favor de ingresa el nombre de DM que usaras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Hide();
            // Supongamos que el ComboBox ya tiene items de tipo MonitorItem
            MonitorItem monitorSeleccionado = comboBox1.SelectedItem as MonitorItem;

            if (monitorSeleccionado != null)
            {
                // Aquí se obtiene el objeto Screen del monitor seleccionado
                GlobalTools.MONITOR = monitorSeleccionado;
            }

            GlobalTools.DM = txtDMName.Text;
            DMDashboard dm = new DMDashboard(this);
            dm.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
