using GranDnDDM.Models;
using GranDnDDM.Tools;
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
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            Screen selectedScreen = GlobalTools.MONITOR.Screen;
            if (selectedScreen != null)
            {
                // Posicionar y ajustar el tamaño según el WorkingArea del monitor seleccionado
                Location = selectedScreen.WorkingArea.Location;
                Size = selectedScreen.WorkingArea.Size;
                WindowState = FormWindowState.Maximized;

            }
            else
            {
                // Si no se encontró, maximiza en el monitor principal
                WindowState = FormWindowState.Maximized;
            }
        }

      

        public void UpdateMap(Bitmap bmp)
        {
            if (pbFullScreen.Image != null)
            {
                pbFullScreen.Image.Dispose();
            }
            pbFullScreen.Image = bmp;
        }

    }
}
