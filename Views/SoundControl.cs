using GranDnDDM.Models;
using GranDnDDM.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GranDnDDM.Views
{
    public partial class SoundControl : Form
    {
        private WindowsMediaPlayer player;
        private List<SoundRecord> soundRecords = new List<SoundRecord>();
        private string soundsFolder = Path.Combine(Application.StartupPath, "Sounds");
        private string soundsJsonFile = Path.Combine(Application.StartupPath, "sounds.json");

        public SoundControl()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
            player.settings.volume = 20; // Ajuste inicial

            // Crea la carpeta "Sounds" si no existe
            if (!Directory.Exists(soundsFolder))
                Directory.CreateDirectory(soundsFolder);

            soundsJsonFile = Path.Combine(Application.StartupPath, GlobalTools.DM + "_sounds.json");
            // Carga registros existentes en el JSON
            LoadSoundRecords();
            // Muestra en el DataGridView
            UpdateSoundGrid();
            dgvSounds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSounds.MultiSelect = false; // (Opcional: para permitir solo una fila)
            dgvSounds.RowHeadersVisible = false;
            player.StatusChange += Player_StatusChange;

        }

        private void Player_StatusChange()
        {
            if (player.playState == WMPPlayState.wmppsStopped)
            {
                btnPlay.ImageIndex = 0;
            }
        }

        private void LoadSoundRecords()
        {
            if (!File.Exists(soundsJsonFile))
                return; // No hay nada que cargar

            try
            {
                string json = File.ReadAllText(soundsJsonFile);
                List<SoundRecord> loaded = JsonSerializer.Deserialize<List<SoundRecord>>(json);
                if (loaded != null)
                {
                    soundRecords = loaded;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de sonidos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSoundRecords()
        {
            try
            {
                string json = JsonSerializer.Serialize(soundRecords, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(soundsJsonFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la lista de sonidos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSoundGrid()
        {
            dgvSounds.DataSource = null;  // Asumamos que tu DataGridView se llama dgvSounds
            dgvSounds.DataSource = soundRecords;

            // Opcional: autoajustar columnas y ocultar la columna FileName si no la quieres ver
            dgvSounds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvSounds.Columns.Contains("FileName"))
            {
                dgvSounds.Columns["FileName"].Visible = false;
            }
        }
        private void btnLoadSound_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de sonido (*.wav, *.mp3)|*.wav;*.mp3";
                ofd.Title = "Selecciona un archivo WAV";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Nombre real (sin extensión si prefieres)
                        string realName = Path.GetFileNameWithoutExtension(ofd.FileName);

                        // Generar un nombre único con GUID
                        string extension = Path.GetExtension(ofd.FileName); // será .wav
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string destinationPath = Path.Combine(soundsFolder, uniqueFileName);

                        // Copiar el archivo
                        File.Copy(ofd.FileName, destinationPath);

                        // Crear un nuevo registro
                        var newRecord = new SoundRecord
                        {
                            FileName = uniqueFileName,
                            RealName = realName
                        };

                        // Agregarlo a la lista
                        soundRecords.Add(newRecord);

                        // Guardar en JSON
                        SaveSoundRecords();

                        // Refrescar el DataGridView
                        UpdateSoundGrid();

                        MessageBox.Show("Sonido agregado correctamente.",
                                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el sonido: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvSounds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que no sea encabezado ni columna de encabezados
            if (e.RowIndex < 0)
                return;

            // Obtén la fila
            DataGridViewRow row = dgvSounds.Rows[e.RowIndex];
            // Toma el objeto SoundRecord enlazado
            SoundRecord record = row.DataBoundItem as SoundRecord;
            if (record == null)
                return;

            // Construye la ruta al WAV
            string filePath = Path.Combine(soundsFolder, record.FileName);
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Archivo de sonido no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblSound.Text = record.RealName;
            // Reproducimos con Windows Media Player
            player.URL = filePath;
            player.controls.play();
            btnPlay.ImageIndex = 5;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (player.URL == "")
            {
                return;
            }
            if (btnPlay.ImageIndex == 5)
            {
                btnPlay.ImageIndex = 0;
                player.controls.stop();
            }
            else
            {
                btnPlay.ImageIndex = 5;
                player.controls.play();
            }
        }

        private void trackBarVolume_ValueChanged()
        {
            player.settings.volume = trackBarVolume.Value;
            lblVolumeValue.Text = trackBarVolume.Value.ToString();
        }

        private void hopeTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            // Si no hay nada escrito, mostramos la lista completa
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvSounds.DataSource = null;
                dgvSounds.DataSource = soundRecords;
            }
            else
            {
                // Filtra la lista en memoria basándonos en coincidencias en RealName (o la propiedad que desees)
                var filtered = soundRecords
                    .Where(s => s.RealName.ToLower().Contains(searchTerm))
                    .ToList();

                dgvSounds.DataSource = null;
                dgvSounds.DataSource = filtered;
            }

            // Opcional: Ajustar columnas, ocultar FileName, etc.
            dgvSounds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvSounds.Columns.Contains("FileName"))
                dgvSounds.Columns["FileName"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Verifica que haya al menos una fila seleccionada en el DataGridView de sonidos
            if (dgvSounds.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay ningún sonido seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtén la primera fila seleccionada
            DataGridViewRow selectedRow = dgvSounds.SelectedRows[0];

            // Obtén el objeto SoundRecord enlazado a esa fila
            SoundRecord recordToDelete = selectedRow.DataBoundItem as SoundRecord;
            if (recordToDelete == null)
            {
                MessageBox.Show("No se pudo obtener el registro del sonido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Solicita confirmación para eliminar el sonido
            var confirm = MessageBox.Show($"¿Deseas eliminar el sonido '{recordToDelete.RealName}'?",
                                          "Confirmar eliminación",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            // Remueve el registro de la lista en memoria
            soundRecords.Remove(recordToDelete);

            // Elimina el archivo físico del sonido
            string fullPath = Path.Combine(soundsFolder, recordToDelete.FileName);
            if (File.Exists(fullPath))
            {
                try
                {
                    File.Delete(fullPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Guarda la lista actualizada en el JSON
            SaveSoundRecords();

            // Actualiza el DataGridView
            UpdateSoundGrid();

            MessageBox.Show("Sonido eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
