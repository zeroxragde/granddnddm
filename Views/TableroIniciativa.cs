using GranDnDDM.Models;
using GranDnDDM.Tools;
using Newtonsoft.Json;
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
    public partial class TableroIniciativa : Form
    {
        public string jsonFile = "";

        public TableroIniciativa()
        {
            InitializeComponent();
            jsonFile = GlobalTools.DM + "_iniciativa.json";
            // Carga los labels desde el JSON, si existe
            LoadLabelsFromJson();
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLabel.Text))
            {
                // Crea un nuevo control de label arrastrable y lo añade al FlowLayoutPanel
                DraggableLabelControl dlc = new DraggableLabelControl(txtLabel.Text);
                flowPanel.Controls.Add(dlc);
                txtLabel.Clear();
            }
        }

        private void flowPanel_DragEnter(object sender, DragEventArgs e)
        {
            // Recupera el control que se está arrastrando
            DraggableLabelControl draggedControl = (DraggableLabelControl)e.Data.GetData(typeof(DraggableLabelControl));
            Point pt = flowPanel.PointToClient(new Point(e.X, e.Y));
            Control destinationControl = flowPanel.GetChildAtPoint(pt);

            int index = destinationControl != null ? flowPanel.Controls.GetChildIndex(destinationControl) : flowPanel.Controls.Count - 1;

            // Reubica el control en el FlowLayoutPanel
            flowPanel.Controls.Remove(draggedControl);
            flowPanel.Controls.Add(draggedControl);
            flowPanel.Controls.SetChildIndex(draggedControl, index);
        }

        private void flowPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DraggableLabelControl)))
            {
                DraggableLabelControl draggedControl = (DraggableLabelControl)e.Data.GetData(typeof(DraggableLabelControl));
                // Remueve el control del panel para recalcular el índice
                flowPanel.Controls.Remove(draggedControl);

                // Calcula la posición de drop en relación al FlowLayoutPanel
                Point pt = flowPanel.PointToClient(new Point(e.X, e.Y));
                Control destinationControl = flowPanel.GetChildAtPoint(pt);
                int index = destinationControl != null ? flowPanel.Controls.GetChildIndex(destinationControl) : flowPanel.Controls.Count;

                // Reincorpora el control en la posición determinada
                flowPanel.Controls.Add(draggedControl);
                flowPanel.Controls.SetChildIndex(draggedControl, index);
            }
        }

        private void flowPanel_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DraggableLabelControl)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveLabelsToJson();
        }
        private void SaveLabelsToJson()
        {
            List<LabelData> labelsList = new List<LabelData>();
            foreach (Control control in flowPanel.Controls)
            {
                if (control is DraggableLabelControl dlc)
                {
                    labelsList.Add(new LabelData { Text = dlc.lbl.Text });
                }
            }
            string json = JsonConvert.SerializeObject(labelsList, Formatting.Indented);
            File.WriteAllText(jsonFile, json);
            MessageBox.Show("Labels guardados correctamente.");
        }
        private void LoadLabelsFromJson()
        {
            if (File.Exists(jsonFile))
            {
                try
                {
                    string json = File.ReadAllText(jsonFile);
                    var labelsList = JsonConvert.DeserializeObject<List<LabelData>>(json);
                    if (labelsList != null)
                    {
                        foreach (var item in labelsList)
                        {
                            DraggableLabelControl dlc = new DraggableLabelControl(item.Text);
                            flowPanel.Controls.Add(dlc);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el JSON: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
