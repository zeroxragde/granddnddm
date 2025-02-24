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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class EditorMap : Form
    {
 
        private string imagesFolder = Path.Combine(Application.StartupPath, "imagenes");
        private string jsonDataFile = Path.Combine(Application.StartupPath, "data_img.json");

        public EditorMap()
        {
            InitializeComponent();
        }

        private void EditorMap_Load(object sender, EventArgs e)
        {
            // ComboBox para seleccionar la categoría
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new string[] { "personajes", "objetos", "tiles", "imagenes generales" });
            cmbCategory.SelectedIndex = 0;
            // Configuración del DataGridView
            dgvImages.AllowUserToAddRows = false;

            dgvImages.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvImages.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvImages.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            CmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbFilter.Items.Add("Todas");
            CmbFilter.Items.AddRange(new string[] { "personajes", "objetos", "tiles", "imagenes generales" });
            CmbFilter.SelectedIndex = 0;
            // Configuración de columnas:
            // Columna de categoría
            var colCategory = new DataGridViewTextBoxColumn();
            colCategory.HeaderText = "Categoría";
            colCategory.Name = "Categoria";
            dgvImages.Columns.Add(colCategory);

            // Columna para mostrar la imagen (se muestra en modo Zoom)
            var colImage = new DataGridViewImageColumn();
            colImage.HeaderText = "Imagen";
            colImage.Name = "ImageColumn";
            colImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvImages.Columns.Add(colImage);

            // Columna con el botón para eliminar
            var colDelete = new DataGridViewButtonColumn();
            colDelete.HeaderText = "Acción";
            colDelete.Text = "Eliminar";
            colDelete.UseColumnTextForButtonValue = true;
            dgvImages.Columns.Add(colDelete);

            string sinEspacios = Regex.Replace(GlobalTools.DM, @"\s+", "");
            jsonDataFile = Path.Combine(Application.StartupPath, "data_" + sinEspacios + "_img.json");
            LoadGridData();
        }


        private void dgvImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvImages.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var result = MessageBox.Show("¿Desea eliminar esta imagen?", "Confirmar",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvImages.Rows[e.RowIndex];

                    // 1) Libera el objeto Image
                    var cellImg = row.Cells["ImageColumn"] as DataGridViewImageCell;
                    if (cellImg != null && cellImg.Value is Image imgValue)
                    {
                        imgValue.Dispose();  // Libera el lock sobre el archivo
                    }

                    // 2) Borra el archivo físico
                    if (row.Tag is string fileName)
                    {
                        string fullPath = Path.Combine(imagesFolder, fileName);
                        if (File.Exists(fullPath))
                        {
                            File.Delete(fullPath);
                        }
                    }

                    // 3) Quita la fila del DataGridView
                    dgvImages.Rows.RemoveAt(e.RowIndex);

                    // 4) Actualiza el JSON si procede
                    SaveGridData();
                }
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar la imagen desde el archivo seleccionado
                        Image img = Image.FromFile(ofd.FileName);
                        string category = cmbCategory.SelectedItem.ToString();

                        if (!Directory.Exists(imagesFolder))
                            Directory.CreateDirectory(imagesFolder);

                        // Generar un nombre único para la imagen y copiarla a la carpeta "imagenes"
                        string extension = Path.GetExtension(ofd.FileName);
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string destinationPath = Path.Combine(imagesFolder, uniqueFileName);
                        File.Copy(ofd.FileName, destinationPath);

                        // Agregar la imagen al DataGridView y almacenar el nombre del archivo en la propiedad Tag
                        int rowIndex = dgvImages.Rows.Add(category, img);
                        dgvImages.Rows[rowIndex].Tag = uniqueFileName;

                        // Guardar datos en JSON
                        SaveGridData();

                        // Aplicar filtro actual
                        ApplyFilter();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }
            }
        }

        
        // Método para aplicar el filtro por categoría
        private void ApplyFilter()
        {
            if (!dgvImages.Columns.Contains("Categoria"))
            {
                return;
            }

            string selectedCategory = CmbFilter.SelectedItem.ToString();
            foreach (DataGridViewRow row in dgvImages.Rows)
            {
                if (row.Cells["Categoria"].Value != null)
                {
                    string rowCategory = row.Cells["Categoria"].Value.ToString();
                    row.Visible = (selectedCategory == "Todas" || rowCategory == selectedCategory);
                }
            }
        }
        // Guardar los datos del DataGridView en un archivo JSON
        private void SaveGridData()
        {
            List<ImageRecord> records = new List<ImageRecord>();
            foreach (DataGridViewRow row in dgvImages.Rows)
            {
                if (row.Cells["Categoria"].Value != null && row.Tag is string fileName)
                {
                    string category = row.Cells["Categoria"].Value.ToString();
                    records.Add(new ImageRecord { Category = category, FileName = fileName });
                }
            }
            string json = JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonDataFile, json);
        }

        // Cargar los datos del archivo JSON y recargar el DataGridView
        private void LoadGridData()
        {
            if (File.Exists(jsonDataFile))
            {
                try
                {
                    string json = File.ReadAllText(jsonDataFile);
                    List<ImageRecord> records = JsonSerializer.Deserialize<List<ImageRecord>>(json);
                    if (records != null)
                    {
                        foreach (var record in records)
                        {
                            string fullPath = Path.Combine(imagesFolder, record.FileName);
                            if (File.Exists(fullPath))
                            {
                                Image img = Image.FromFile(fullPath);
                                int index = dgvImages.Rows.Add(record.Category, img);
                                dgvImages.Rows[index].Tag = record.FileName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }
        }
        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
