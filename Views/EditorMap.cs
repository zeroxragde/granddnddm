using GranDnDDM.Enums;
using GranDnDDM.Models;
using GranDnDDM.Tools;
using Microsoft.VisualBasic;
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
        // Variable a nivel de formulario para almacenar todos los ítems
        private List<ListViewItem> allTilesItems = new List<ListViewItem>();



        //private MapEditor mapEditor;
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

            cmbLayers.Items.Clear();
            foreach (var layer in mapEditor.GetLayers())
            {
                cmbLayers.Items.Add(layer.Name);
            }
            cmbLayers.SelectedIndex = mapEditor.ActiveLayerIndex;




        }


        private void dgvImages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvImages.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && dgvImages.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var result = MessageBox.Show("¿Desea eliminar esta imagen?", "Confirmar",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


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


            // Obtenemos la celda de la imagen, asumiendo que su nombre es "ImageColumn"
            DataGridViewImageCell imageCell = row.Cells["ImageColumn"] as DataGridViewImageCell;
            if (imageCell != null && imageCell.Value is Image img)
            {
                // Asigna la imagen seleccionada al editor (puedes clonar la imagen para evitar conflictos)
                mapEditor.DrawingImage = (Image)img.Clone();

                // Extraemos la categoría, suponiendo que la columna se llama "Categoria"
                string categoria = row.Cells["Categoria"].Value?.ToString() ?? "";
                MessageBox.Show("Tile seleccionado: " + categoria, "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La celda seleccionada no contiene una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        // Carga la imagen completa desde el archivo seleccionado
                        Image fullImage = Image.FromFile(ofd.FileName);
                        string category = cmbCategory.SelectedItem.ToString();

                        if (!Directory.Exists(imagesFolder))
                            Directory.CreateDirectory(imagesFolder);

                        // Genera un nombre único para la imagen y cópiala a la carpeta "imagenes"
                        string extension = Path.GetExtension(ofd.FileName);
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string destinationPath = Path.Combine(imagesFolder, uniqueFileName);
                        File.Copy(ofd.FileName, destinationPath);

                        // Crea un preview pequeño de la imagen (por ejemplo, 64x64)
                        Image previewImage = new Bitmap(fullImage, new Size(64, 64));

                        // Agrega el preview al ImageList usando el nombre único como clave
                        if (!ilTiles.Images.ContainsKey(uniqueFileName))
                        {
                            ilTiles.Images.Add(uniqueFileName, previewImage);
                        }

                        // Crea un ListViewItem para el ListView de tiles.
                        // Usa el preview (a través de ImageKey) y almacena la imagen completa en Tag.
                        ListViewItem item = new ListViewItem
                        {
                            Text = category,         // O puedes poner otro texto informativo
                            ImageKey = uniqueFileName,
                            Tag = fullImage          // Aquí guardas la imagen en tamaño real
                        };

                        listViewTiles.Items.Add(item);

                        // Guarda los datos en JSON y aplica filtros, si es necesario
                        SaveGridData();
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
            // Obtener la categoría seleccionada del ComboBox
            string selectedCategory = CmbFilter.SelectedItem.ToString();

            // Limpiar los ítems actuales del ListView
            listViewTiles.Items.Clear();

            // Filtrar y agregar solo los ítems que cumplan la condición
            foreach (ListViewItem item in allTilesItems)
            {
                // Aquí, asumo que el Text del ítem representa la categoría;
                // si lo almacenas en Tag u otra propiedad, ajusta el código.
                string itemCategory = item.Text;

                if (selectedCategory == "Todas" || itemCategory == selectedCategory)
                {
                    listViewTiles.Items.Add(item);
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
                                // Cargar la imagen completa desde el archivo
                                Image fullImage = Image.FromFile(fullPath);
                                // Crear un preview pequeño (por ejemplo, 64x64)
                                Image previewImage = new Bitmap(fullImage, new Size(64, 64));

                                // Agregar el preview al ImageList, usando el nombre único como clave
                                if (!ilTiles.Images.ContainsKey(record.FileName))
                                {
                                    ilTiles.Images.Add(record.FileName, previewImage);
                                }

                                // Crear un ListViewItem para el ListView de tiles.
                                // Se usa el preview (a través de ImageKey) y se almacena la imagen completa en Tag.
                                ListViewItem item = new ListViewItem
                                {
                                    Text = record.Category,         // Muestra la categoría u otra información
                                    ImageKey = record.FileName,
                                    Tag = fullImage                   // Almacena la imagen en tamaño real
                                };

                                listViewTiles.Items.Add(item);
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

        private void dgvImages_MouseDown_1(object sender, MouseEventArgs e)
        {

            var hitTest = dgvImages.HitTest(e.X, e.Y);
            if (hitTest.Type == DataGridViewHitTestType.Cell &&
                hitTest.RowIndex >= 0 && hitTest.ColumnIndex >= 0)
            {
                var column = dgvImages.Columns[hitTest.ColumnIndex];
                if (column is DataGridViewImageColumn)
                {
                    var cell = dgvImages.Rows[hitTest.RowIndex].Cells[hitTest.ColumnIndex] as DataGridViewImageCell;
                    if (cell?.Value is Image img)
                    {
                        // Obtenemos la categoría desde la columna "Categoria"
                        string category = dgvImages.Rows[hitTest.RowIndex].Cells["Categoria"].Value.ToString();

                        // Creamos un objeto que transporta la información del ítem
                        var draggedItem = new DraggedMapItem
                        {
                            Image = img,
                            Category = category
                        };

                        // Configuramos el DataObject para incluir nuestro tipo y también el bitmap para compatibilidad
                        DataObject dataObject = new DataObject();
                        dataObject.SetData("DraggedMapItem", draggedItem);
                        dataObject.SetData(DataFormats.Bitmap, img);

                        dgvImages.DoDragDrop(dataObject, DragDropEffects.Copy);
                    }
                }
            }

        }

        private void cmbLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLayers.SelectedIndex >= 0)
            {
                mapEditor.ActiveLayerIndex = cmbLayers.SelectedIndex;
            }
        }

        private void btnAddLayer_Click(object sender, EventArgs e)
        {
            //revisar
            string respuesta = Interaction.InputBox(
            "Ingresa nombre de capa:",
            "Capa Nueva",
            "Nueva Capa " + mapEditor.GetLayers().Count
            );
            if (respuesta != null)
            {
                return;
            }
            // Puedes pedirle al usuario un nombre (aquí se usa uno automático)
            string newLayerName = respuesta;
            mapEditor.AddLayer(newLayerName);
            cmbLayers.Items.Add(newLayerName);
            cmbLayers.SelectedIndex = cmbLayers.Items.Count - 1; // Se activa la nueva capa
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {


            // Activa la herramienta de dibujo
            mapEditor.CurrentToolMode = ToolMode.Draw;
            // Cambia el cursor (puedes usar un cursor personalizado o uno predefinido)
            // Supongamos que la clave de la imagen en el ImageList es "penMouse"
            // (o un índice, si lo agregaste sin clave).
            Image img = ilCursores.Images["penMouse.ico"];
            // Convertimos la imagen a Bitmap
            Bitmap bmp = new Bitmap(img);

            // Creamos el cursor con el punto activo en la esquina superior izquierda (0,0)
            Cursor customCursor = CursorHelper.CreateCursorFromBitmap(bmp, 0, 0);

            // Asignamos el cursor al formulario o a un control específico
            Cursor = customCursor;
            // Actualiza la apariencia de los botones
            btnDraw.BackColor = Color.LightBlue;
            btnErase.BackColor = SystemColors.Control;
        }


        private void btnNone_Click(object sender, EventArgs e)
        {
            mapEditor.CurrentToolMode = ToolMode.None;
            mapEditor.Cursor = Cursors.Default;
            // Restablece los colores de los botones
            btnDraw.BackColor = SystemColors.Control;
            btnErase.BackColor = SystemColors.Control;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // Activa la herramienta de borrado
            mapEditor.CurrentToolMode = ToolMode.Erase;
            mapEditor.Cursor = Cursors.No; // O el cursor que prefieras para borrar
            btnErase.BackColor = Color.LightBlue;
            btnDraw.BackColor = SystemColors.Control;
        }


        private void listViewTiles_MouseDown(object sender, MouseEventArgs e)
        {
            // Realiza un hit test para saber qué ítem fue clickeado
            ListViewHitTestInfo hit = listViewTiles.HitTest(e.X, e.Y);
            if (hit.Item != null)
            {
                // Obtenemos la clave de la imagen (para el preview, pero no la usaremos para el drag)
                string imageKey = hit.Item.ImageKey;
                // En Tag se guardó la imagen completa
                Image fullImage = hit.Item.Tag as Image;
                if (fullImage != null)
                {
                    // Suponemos que el Text del ítem contiene la categoría
                    string category = hit.Item.Text;

                    // Creamos el objeto que transporta la información del tile
                    var draggedItem = new DraggedMapItem
                    {
                        Image = fullImage,
                        Category = category
                    };

                    // Configuramos el DataObject para el drag & drop
                    DataObject dataObject = new DataObject();
                    dataObject.SetData("DraggedMapItem", draggedItem);
                    dataObject.SetData(DataFormats.Bitmap, fullImage);

                    listViewTiles.DoDragDrop(dataObject, DragDropEffects.Copy);
                }
            }
        }

        private void listViewTiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTiles.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTiles.SelectedItems[0];
                // Asumimos que el Text del ítem contiene la categoría del tile.
                string category = selectedItem.Text;

                Image tileImage = null;
                // Si la categoría es "imagenes generales", usamos la imagen completa que se guardó en Tag.
                if (category.Equals("imagenes generales", StringComparison.OrdinalIgnoreCase))
                {
                    tileImage = selectedItem.Tag as Image;
                }
                else
                {
                    // Para un tile normal, usamos la imagen del ImageList.
                    string imageKey = selectedItem.ImageKey;
                    if (ilTiles.Images.ContainsKey(imageKey))
                    {
                        tileImage = ilTiles.Images[imageKey];
                    }
                }

                if (tileImage != null)
                {
                    // Asigna la imagen (clonada) al editor para que se use al pintar.
                    mapEditor.DrawingImage = (Image)tileImage.Clone();
                    MessageBox.Show("Tile seleccionado (" + category + ")", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró la imagen para el tile seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }





        ///////////
    }
}
