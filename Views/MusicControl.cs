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
    public partial class MusicControl : Form
    {
        public MusicControl()
        {
            InitializeComponent();
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            ListSongs listSongs = new ListSongs();
            listSongs.ShowDialog();
        }
    }
}
