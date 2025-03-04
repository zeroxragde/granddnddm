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

        }






        ////////////
    }
}
