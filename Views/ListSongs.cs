using GranDnDDM.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GranDnDDM.Views
{
    public partial class ListSongs : Form
    {
        private List<string> musicCategories = new List<string>();
        private string categoriesFile = Path.Combine(Application.StartupPath, "cat_music.json");
        public ListSongs()
        {
            InitializeComponent();
            categoriesFile = Path.Combine(Application.StartupPath, GlobalTools.DM + "_cat_music.json");
        }
        private void LoadCategories()
        {
            // Si no existe el archivo, no hay nada que cargar
            if (!File.Exists(categoriesFile))
                return;

            try
            {
                string json = File.ReadAllText(categoriesFile);
                // Deserializa en una lista de strings
                List<string> loaded = JsonSerializer.Deserialize<List<string>>(json);
                if (loaded != null)
                {
                    musicCategories = loaded;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveCategories()
        {
            try
            {
                string json = JsonSerializer.Serialize(musicCategories, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(categoriesFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateComboBoxes()
        {
            // Limpia los ítems actuales
            cbCatFilter.Items.Clear();
            cbCatSelect.Items.Clear();

            // Vuelve a cargar la lista de categorías
            // (Asumiendo que musicCategories ya está actualizada)
            foreach (string cat in musicCategories)
            {
                cbCatFilter.Items.Add(cat);
                cbCatSelect.Items.Add(cat);
            }

            // Opcional: selecciona el primer ítem si quieres
            if (cbCatFilter.Items.Count > 0)
                cbCatFilter.SelectedIndex = 0;
            if (cbCatSelect.Items.Count > 0)
                cbCatSelect.SelectedIndex = 0;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCat = txtNewCategory.Text.Trim();
            if (string.IsNullOrEmpty(newCat))
            {
                MessageBox.Show("Ingrese un nombre de categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si ya existe
            if (musicCategories.Contains(newCat, StringComparer.OrdinalIgnoreCase))
            {
                MessageBox.Show("Esa categoría ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agrega la nueva categoría
            musicCategories.Add(newCat);

            // Guarda en JSON
            SaveCategories();

            // Actualiza combos
            UpdateComboBoxes();

            // Limpia el TextBox
            txtNewCategory.Text = "";
            MessageBox.Show("Categoría agregada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListSongs_Load(object sender, EventArgs e)
        {
            LoadCategories();
            UpdateComboBoxes();
        }


        ///////////////
    }
}
