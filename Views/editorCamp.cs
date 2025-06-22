using GranDnDDM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class editorCamp : Form
    {
        private const string filename = "listCampaign.json";

        public editorCamp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Leer o crear la lista existente
            List<Campaign> list;
            try
            {
                var txt = File.ReadAllText(filename);
                list = JsonConvert.DeserializeObject<List<Campaign>>(txt)
                       ?? new List<Campaign>();
            }
            catch
            {
                list = new List<Campaign>();
            }

            // 2. Obtener el nombre nuevo
            var nuevo = txtCamp.Text?.Trim();
            if (string.IsNullOrEmpty(nuevo))
            {
                MessageBox.Show("Escribe un nombre de campaña.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Evitar duplicados
            if (list.Any(c => c.Nombre.Equals(nuevo, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Ya existe esa campaña.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4. Agregar y guardar
            list.Add(new Campaign { Nombre = nuevo });
            File.WriteAllText(filename, JsonConvert.SerializeObject(list, Formatting.Indented));

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
