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
        private Mapa fullScreenForm;
        private System.Windows.Forms.Timer updateTimer;
        private string mapaName = "";

        //private MapEditor mapEditor;
        public EditorMap()
        {
            InitializeComponent();
        }

        private void EditorMap_Load(object sender, EventArgs e)
        {
            int wm = GlobalTools.MONITOR.Screen.Bounds.Width;

            int hm = GlobalTools.MONITOR.Screen.Bounds.Height;
            int tw = wm / 32;
            int th = hm / 32;
            mapEditor.Columns = tw;
            mapEditor.Rows = th;
            // ComboBox para seleccionar la categoría
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new string[] { "personajes", "objetos", "tiles", "imagenes generales" });
            CmbFilter.Items.AddRange(new string[] { "Todas", "personajes", "objetos", "tiles", "imagenes generales" });
            cmbCategory.SelectedIndex = 0;

            CmbFilter.SelectedIndex = 0;

            string sinEspacios = Regex.Replace(GlobalTools.DM, @"\s+", "");
            jsonDataFile = Path.Combine(Application.StartupPath, "data_" + sinEspacios + "_img.json");
            LoadGridData();

            cmbLayers.Items.Clear();
            foreach (var layer in mapEditor.GetLayers())
            {
                cmbLayers.Items.Add(layer.Name);
            }
            cmbLayers.SelectedIndex = mapEditor.ActiveLayerIndex;

            fullScreenForm = new Mapa();
            fullScreenForm.Show();
            // Configurar un Timer para actualizar la imagen del full screen cada cierto tiempo (por ejemplo, cada 100 ms)
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Interval = 100;
            updateTimer.Tick += UpdateTimer_Tick;
            // updateTimer.Start();
            mapEditor.Size = new Size(mapEditor.Columns * mapEditor.TileSize, mapEditor.Rows * mapEditor.TileSize);
        }
        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (fullScreenForm != null && mapEditor != null)
            {
                // Capturamos el contenido actual del MapEditor
                Bitmap bmp = mapEditor.GetSnapshot();
                // Actualizamos la imagen en el formulario full screen
                fullScreenForm.UpdateMap(bmp);
            }
        }
        public Bitmap GetVisibleSnapshot()
        {
            // Asumiendo que 'panelMap' es el contenedor con AutoScroll que muestra el MapEditor
            // y que el MapEditor se encuentra dentro de ese panel.
            Rectangle visibleRect = new Rectangle(
                -pGrid.AutoScrollPosition.X,
                -pGrid.AutoScrollPosition.Y,
                pGrid.ClientSize.Width,
                pGrid.ClientSize.Height
            );

            Bitmap bmp = new Bitmap(visibleRect.Width, visibleRect.Height);
            // Dibuja en el bitmap únicamente la parte visible del MapEditor
            mapEditor.DrawToBitmap(bmp, visibleRect);
            return bmp;
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
                        Image fullImage = Image.FromFile(ofd.FileName);
                        string category = cmbCategory.SelectedItem.ToString();

                        if (!Directory.Exists(imagesFolder))
                            Directory.CreateDirectory(imagesFolder);

                        string extension = Path.GetExtension(ofd.FileName);
                        string uniqueFileName = Guid.NewGuid().ToString() + extension;
                        string destinationPath = Path.Combine(imagesFolder, uniqueFileName);
                        File.Copy(ofd.FileName, destinationPath);

                        Image previewImage = new Bitmap(fullImage, new Size(64, 64));

                        if (!ilTiles.Images.ContainsKey(uniqueFileName))
                        {
                            ilTiles.Images.Add(uniqueFileName, previewImage);
                        }

                        ListViewItem item = new ListViewItem
                        {
                            Text = category,
                            ImageKey = uniqueFileName, // Aquí se guarda correctamente el nombre del archivo
                            Tag = fullImage
                        };

                        listViewTiles.Items.Add(item);
                        allTilesItems.Add(item);

                        SaveGridData(); // Guardar en JSON inmediatamente
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
            foreach (ListViewItem item in listViewTiles.Items)
            {
                if (!string.IsNullOrEmpty(item.Text) && !string.IsNullOrEmpty(item.ImageKey))
                {
                    string category = item.Text;
                    string fileName = item.ImageKey; // Aquí obtenemos el nombre del archivo correctamente
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
                        listViewTiles.Items.Clear(); // Evitar duplicados
                        allTilesItems.Clear();

                        foreach (var record in records)
                        {
                            string fullPath = Path.Combine(imagesFolder, record.FileName);
                            if (File.Exists(fullPath))
                            {
                                Image fullImage = Image.FromFile(fullPath);
                                Image previewImage = new Bitmap(fullImage, new Size(64, 64));

                                if (!ilTiles.Images.ContainsKey(record.FileName))
                                {
                                    ilTiles.Images.Add(record.FileName, previewImage);
                                }

                                ListViewItem item = new ListViewItem
                                {
                                    Text = record.Category,
                                    ImageKey = record.FileName,
                                    Tag = fullImage
                                };

                                listViewTiles.Items.Add(item);
                                allTilesItems.Add(item);
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
            if (respuesta == null)
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
            btnFillMap.BackColor = SystemColors.Control;
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            mapEditor.CurrentToolMode = ToolMode.None;
            mapEditor.Cursor = Cursors.Default;
            // Restablece los colores de los botones
            btnDraw.BackColor = SystemColors.Control;
            btnErase.BackColor = SystemColors.Control;
            btnFillMap.BackColor = SystemColors.Control;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            // Activa la herramienta de borrado
            mapEditor.CurrentToolMode = ToolMode.Erase;
            mapEditor.Cursor = Cursors.No; // O el cursor que prefieras para borrar
            btnErase.BackColor = Color.LightBlue;
            btnDraw.BackColor = SystemColors.Control;
            btnFillMap.BackColor = SystemColors.Control;
        }

        private void listViewTiles_MouseDown(object sender, MouseEventArgs e)
        {
            // Realiza un hit test para saber qué ítem fue clickeado
            ListViewHitTestInfo hit = listViewTiles.HitTest(e.X, e.Y);
            if (hit.Item != null)
            {
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
                        Category = category,
                        FileName = hit.Item.ImageKey
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
                    mapEditor.DrawingItem = new DraggedMapItem
                    {
                        FileName = selectedItem.ImageKey,
                        Category = selectedItem.Text,
                        Image = tileImage
                    };
                    /*  MessageBox.Show("Tile seleccionado (" + category + ")", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    pvPreview.Image = (Image)tileImage.Clone();
                }
                else
                {
                    MessageBox.Show("No se encontró la imagen para el tile seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            // Crear una lista para almacenar los ítems a eliminar, ya que no se debe modificar la colección mientras se itera
            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            foreach (ListViewItem item in listViewTiles.Items)
            {
                // Verifica si el ítem está marcado (checkbox activado)
                if (item.Checked)
                {
                    itemsToRemove.Add(item);
                }
            }

            // Iterar sobre los ítems seleccionados para borrarlos
            foreach (ListViewItem item in itemsToRemove)
            {
                // Si en el Tag se almacenó el nombre del archivo, se procede a eliminarlo del disco
                if (item.Tag is string fileName)
                {
                    string fullPath = Path.Combine(imagesFolder, fileName);
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
                }

                // Remover el ítem del ListView
                listViewTiles.Items.Remove(item);
            }

            // Actualiza el archivo JSON con los datos actuales
            SaveGridData();

            MessageBox.Show("Se han eliminado las imágenes seleccionadas.", "Eliminación completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSaveMap_Click(object sender, EventArgs e)
        {
            string respuesta = Interaction.InputBox(
            "Ingresa nombre de mapa:",
            "",
            "Guardar Mapa "
            );
            if (respuesta == null || respuesta == "")
            {
                return;
            }
            mapaName = respuesta;
            mapEditor.SaveMap(respuesta);
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            mapaName = mapEditor.LoadMap();
            Text = Text + "- Mapa: " + mapaName;
        }

        private void EditorMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mapaName == "")
            {
                string respuesta = Interaction.InputBox(
                "Ingresa nombre de mapa:",
                "",
                "Guardar Mapa "
                );
                if (respuesta != null || respuesta != "")
                {
                    mapEditor.SaveMap(Path.GetFileNameWithoutExtension(respuesta));
                }

            }
            else
            {
                mapEditor.SaveMap(mapaName);
            }

            fullScreenForm.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (fullScreenForm != null && mapEditor != null)
            {
                // Capturamos el contenido actual del MapEditor
                Bitmap bmp = mapEditor.GetSnapshot();
                // Actualizamos la imagen en el formulario full screen
                fullScreenForm.UpdateMap(bmp);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFillMap_Click(object sender, EventArgs e)
        {
            mapEditor.CurrentToolMode = ToolMode.Fill;
            btnFillMap.BackColor = Color.LightBlue; // Indicar que está activado
            btnDraw.BackColor = SystemColors.Control;
            btnErase.BackColor = SystemColors.Control;
        }





        ///////////
    }
}
