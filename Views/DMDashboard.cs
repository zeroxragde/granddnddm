using GranDnDDM.Tools;
using ReaLTaiizor.Forms;
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
    public partial class DMDashboard : Form
    {
        private Form1 principal;
        private MusicControl music = new MusicControl();
        private EditorMap empa = new EditorMap();
        private CreatureList cl = new CreatureList();
        private ShopCreeator sh = new ShopCreeator();
        
        public DMDashboard(Form1 f)
        {
            InitializeComponent();
            principal = f;
        }

        private void DMDashboard_Load(object sender, EventArgs e)
        {
            myForm.Text = "Tablero de " + GlobalTools.DM;
            // Configura el inicio en posición manual
            StartPosition = FormStartPosition.Manual;
            TopMost = true;

            // Obtiene el área de trabajo de la pantalla principal
            Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;

            // Calcula la posición X centrada
            int centerX = screenArea.Left + (screenArea.Width - Width) / 2;

            // Establece la ubicación en el centro arriba
            Location = new Point(centerX, screenArea.Top);

        }

        private void DMDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Close();
        }



        private void btnMapEditor_Click(object sender, EventArgs e)
        {
            if (empa.IsDisposed)
            {
                empa = new EditorMap();
            }
            empa.Show();
        }

        private void btnMusicControl_Click(object sender, EventArgs e)
        {
            if (music.IsDisposed)
            {
                music = new MusicControl();
            }
            music.Show();
        }

        private void btnCreatures_Click(object sender, EventArgs e)
        {
            if (cl.IsDisposed)
            {
                cl = new CreatureList();
            }
            cl.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOpenShop_Click(object sender, EventArgs e)
        {
            if (sh.IsDisposed)
            {
                sh = new ShopCreeator();
            }
            sh.Show();
        }
    }
}
