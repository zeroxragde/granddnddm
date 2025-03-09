using GranDnDDM.Models;
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
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace GranDnDDM.Views
{
    public partial class ListSongs : Form
    {
        private List<string> musicCategories = new List<string>();
        private string categoriesFile = Path.Combine(Application.StartupPath, "cat_music.json");
        private List<MusicRecord> musicRecords = new List<MusicRecord>();
        private string musicFolder = Path.Combine(Application.StartupPath, "Musica");
        private string musicJsonFile = Path.Combine(Application.StartupPath, "musica.json");
        private WindowsMediaPlayer player;
        private MusicControl formControl;
        public ListSongs(MusicControl c)
        {
            InitializeComponent();
            player = c.player;
            formControl = c;
            categoriesFile = Path.Combine(Application.StartupPath, GlobalTools.DM + "_cat_music.json");
            musicJsonFile = Path.Combine(Application.StartupPath, GlobalTools.DM + "_musica.json");
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
            cbCatFilter.Items.Add("Todos"); // Agrega "Todos" al inicio
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
            // Crea la carpeta "Musica" si no existe
            if (!Directory.Exists(musicFolder))
                Directory.CreateDirectory(musicFolder);
            dvgMusica.RowHeadersVisible = false;

            // Carga registros existentes en el JSON
            LoadMusicRecords();
            // Muestra en el DataGridView
            UpdateMusicGrid();
            LoadCategories();
            UpdateComboBoxes();
        }
        private void UpdateMusicGrid()
        {
            dvgMusica.DataSource = null;  // Para forzar la recarga
            dvgMusica.DataSource = musicRecords;

            // Opcional: autoajustar columnas
            // dvgMusica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Si ya conoces las columnas (por ejemplo, "RealName" y "Category"), puedes ajustar su FillWeight
            if (dvgMusica.Columns.Contains("RealName"))
            {
                dvgMusica.Columns["RealName"].Width = 220; // 70% del espacio
            }
            if (dvgMusica.Columns.Contains("Category"))
            {
                dvgMusica.Columns["Category"].FillWeight = 30; // 30% del espacio
            }
            dvgMusica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMusica.MultiSelect = false; // (Opcional: para permitir solo una fila)
            // Oculta la columna "FileName"
            if (dvgMusica.Columns.Contains("FileName"))
            {
                dvgMusica.Columns["FileName"].Visible = false;
            }
        }

        private void SaveMusicRecords()
        {
            try
            {
                string json = JsonSerializer.Serialize(musicRecords, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(musicJsonFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la lista de música: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMusicRecords()
        {
            if (!File.Exists(musicJsonFile))
                return; // No hay nada que cargar si no existe el archivo

            try
            {
                string json = File.ReadAllText(musicJsonFile);
                List<MusicRecord> loaded = JsonSerializer.Deserialize<List<MusicRecord>>(json);
                if (loaded != null)
                {
                    musicRecords = loaded;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de música: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            // Verifica que haya una categoría seleccionada
            if (cbCatSelect.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una categoría antes de agregar música.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos MP3|*.mp3";
                ofd.Title = "Selecciona un archivo MP3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Nombre real (solo el nombre del archivo, sin ruta)
                        string realName = Path.GetFileName(ofd.FileName);
                        // Generar un nombre único con GUID
                        string extension = Path.GetExtension(ofd.FileName); // debería ser .mp3
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string destinationPath = Path.Combine(musicFolder, uniqueFileName);

                        // Copiar el archivo a la carpeta "Musica"
                        File.Copy(ofd.FileName, destinationPath);

                        // Crear un nuevo registro
                        var newRecord = new MusicRecord
                        {
                            FileName = uniqueFileName,
                            RealName = realName.Replace(".mp3", ""),
                            Category = cbCatSelect.SelectedItem.ToString()
                        };

                        // Agregarlo a la lista
                        musicRecords.Add(newRecord);

                        // Guardar en JSON
                        SaveMusicRecords();

                        // Refrescar el DataGridView
                        UpdateMusicGrid();

                        MessageBox.Show("Música agregada correctamente.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la música: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeletesong_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos una fila seleccionada
            if (dvgMusica.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ninguna canción seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tomamos la primera fila seleccionada
            DataGridViewRow selectedRow = dvgMusica.SelectedRows[0];

            // Obtenemos el objeto MusicRecord al que apunta esa fila
            MusicRecord recordToDelete = selectedRow.DataBoundItem as MusicRecord;
            if (recordToDelete == null)
            {
                MessageBox.Show("No se pudo obtener el registro de la canción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación opcional
            var confirm = MessageBox.Show($"¿Deseas eliminar la canción '{recordToDelete.RealName}'?",
                                          "Confirmar eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // 1. Remover de la lista en memoria
            musicRecords.Remove(recordToDelete);

            // 2. (Opcional) Eliminar el archivo físico en la carpeta, si así lo deseas
            string filePath = Path.Combine(musicFolder, recordToDelete.FileName);
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo eliminar el archivo físico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // 3. Guardar la lista de nuevo en el JSON
            SaveMusicRecords();

            // 4. Actualizar la grilla
            UpdateMusicGrid();

            MessageBox.Show("Canción eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dvgMusica_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que no sea clic en encabezado
            if (e.RowIndex < 0) return;

            // Obtiene la fila
            DataGridViewRow row = dvgMusica.Rows[e.RowIndex];
            // Obtiene el objeto enlazado a la fila
            MusicRecord selectedRecord = row.DataBoundItem as MusicRecord;
            if (selectedRecord != null)
            {
                // Asigna al objeto global
                GlobalTools.MusicaActual = selectedRecord;
                string filePath = Path.Combine(Application.StartupPath, "Musica", GlobalTools.MusicaActual.FileName);
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("El archivo de la canción no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (formControl.getIsPlaying())
                {
                    formControl.clickOnPlay();
                }

                player.URL = filePath;
                formControl.clickOnPlay();


                // (Opcional) notifica al usuario
                MessageBox.Show($"Se seleccionó: {selectedRecord.RealName} (Categoría: {selectedRecord.Category})",
                                "Selección de canción",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnAddToCola_Click(object sender, EventArgs e)
        {
            // Verificar que haya al menos una fila seleccionada
            if (dvgMusica.SelectedRows.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ninguna canción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la primera fila seleccionada
            DataGridViewRow row = dvgMusica.SelectedRows[0];
            // Convertir la fila a MusicRecord
            MusicRecord selectedRecord = row.DataBoundItem as MusicRecord;
            if (selectedRecord != null)
            {
                string filePath = Path.Combine(Application.StartupPath, "Musica", selectedRecord.FileName);
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("El archivo de la canción no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                IWMPMedia media = player.newMedia(filePath);

                // Intentamos castear a IWMPMedia2 para poder modificar las propiedades
                IWMPMedia2 media2 = media as IWMPMedia2;
                if (media2 != null)
                {
                    // Cambia "Title" por el título real de la canción (sin extensión, si así lo definiste)
                    media2.setItemInfo("Title", selectedRecord.RealName);
                }

                // Agregar el media a la playlist global
                GlobalTools.playlist.appendItem(media2);
                player.currentPlaylist = GlobalTools.playlist;
                formControl.clickOnPlay();

                MessageBox.Show("Canción agregada a la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbCatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedCategory = cbCatFilter.SelectedItem.ToString();

            // Si selecciona "Todos", mostrar toda la música
            if (selectedCategory == "Todos")
            {
                UpdateMusicGrid();
                return;
            }

            // Filtrar por categoría
            List<MusicRecord> filteredMusic = musicRecords
                .Where(m => m.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Actualizar DataGridView con los datos filtrados
            dvgMusica.DataSource = null;
            dvgMusica.DataSource = filteredMusic;
        }


        ///////////////
    }
}
