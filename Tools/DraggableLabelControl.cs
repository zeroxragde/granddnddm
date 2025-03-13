using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GranDnDDM.Tools
{
    public class DraggableLabelControl : Panel
    {


        public Label lbl;
        public Button btnEdit;
        public Button btnDelete;
        private Point mouseDownLocation;

        public DraggableLabelControl(string text)
        {
            // Configuración del panel contenedor
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Width = 300;
            this.Height = 40;
            this.BackColor = Color.LightGray;
            this.Margin = new Padding(5);

            // Label que muestra el texto
            lbl = new Label();
            lbl.Text = text;
            lbl.Location = new Point(5, 10);
            lbl.AutoSize = true;
            lbl.Font = new Font("Comic San", 16, FontStyle.Bold);
            lbl.MouseDown += DraggableLabelControl_MouseDown;
            lbl.MouseMove += DraggableLabelControl_MouseMove;
            this.Controls.Add(lbl);

            // Botón para eliminar el label
            btnDelete = new Button();
            btnDelete.Text = "Eliminar";
            btnDelete.Size = new Size(60, 23);
            int x = 160;
            btnDelete.Location = new Point(x, 8);
            btnDelete.Click += BtnDelete_Click;
            this.Controls.Add(btnDelete);
            x = x + 70;
            // Botón para editar el label
            btnEdit = new Button();
            btnEdit.Text = "Editar";
            btnEdit.Size = new Size(60, 23);
            btnEdit.Location = new Point(x, 8);
            btnEdit.Click += BtnEdit_Click;
            this.Controls.Add(btnEdit);

            // Permitir iniciar el drag desde el panel también
            this.MouseDown += DraggableLabelControl_MouseDown;
            this.MouseMove += DraggableLabelControl_MouseMove;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Usamos InputBox para editar el texto del label
            string input = Interaction.InputBox("Edita el texto del label:", "Editar Label", lbl.Text);
            if (!string.IsNullOrEmpty(input))
            {
                lbl.Text = input;
            }
        }

        private void DraggableLabelControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void DraggableLabelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Inicia el drag si el movimiento es mayor a 5 píxeles
                if (Math.Abs(e.X - mouseDownLocation.X) > 5 || Math.Abs(e.Y - mouseDownLocation.Y) > 5)
                {
                    this.DoDragDrop(this, DragDropEffects.Move);
                }
            }
        }



    }
}
