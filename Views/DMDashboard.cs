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
    public partial class DMDashboard : Form
    {
        private Form1 principal;
        private MusicControl music = new MusicControl();
        private EditorMap empa = new EditorMap();
        private CreatureList cl = new CreatureList();
        public DMDashboard(Form1 f)
        {
            InitializeComponent();
            principal = f;
        }

        private void DMDashboard_Load(object sender, EventArgs e)
        {
            foreverForm1.Text = "Tablero de " + GlobalTools.DM;
            // Configura el inicio en posición manual
            StartPosition = FormStartPosition.Manual;

            // Posiciona el formulario en la esquina superior izquierda de la pantalla principal
            Rectangle screenArea = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(screenArea.Left, screenArea.Top);

        }

        private void DMDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Close();
        }



        private void btnMapEditor_Click(object sender, EventArgs e)
        {
            empa.Show();
        }

        private void btnMusicControl_Click(object sender, EventArgs e)
        {

            music.Show();
        }

        private void btnCreatures_Click(object sender, EventArgs e)
        {
            if (cl.IsDisposed) {
                cl = new CreatureList();
            }
            cl.Show();
        }

        private void poisonButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
