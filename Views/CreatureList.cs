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
    public partial class CreatureList : Form
    {
        CreatureEditor editor = new CreatureEditor();
        public CreatureList()
        {
            InitializeComponent();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            editor.Show();
        }

        private void dreamButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
