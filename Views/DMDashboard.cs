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
        public DMDashboard(Form1 f)
        {
            InitializeComponent();
            principal = f;
        }

        private void DMDashboard_Load(object sender, EventArgs e)
        {
            Text = "Tablero de " + GlobalTools.DM;

        }

        private void DMDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            principal.Close();
        }



        private void btnMapEditor_Click(object sender, EventArgs e)
        {
            EditorMap empa = new EditorMap();
            empa.Show();
        }

        private void btnMusicControl_Click(object sender, EventArgs e)
        {
            MusicControl music = new MusicControl();
            music.Show();
        }

        private void btnLoadPJ_Click(object sender, EventArgs e)
        {
            PJLoader pJLoader = new PJLoader();
            pJLoader.Show();
        }
    }
}
