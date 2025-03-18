using GranDnDDM.Models;
using GranDnDDM.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GranDnDDM.Views
{
    public partial class ShopCreeator : Form
    {
        private List<Item> itemsDisponibles;
        private List<Item> itemsSeleccionados;
        private List<ShopData> tiendas = new List<ShopData>();


        public ShopCreeator()
        {
            InitializeComponent();
            dgvTienda.AllowDrop = true;
            dgvLisstaItems.RowHeadersVisible = false;

            itemsSeleccionados = new List<Item>();
            // Deshabilita la fila adicional al final
            dgvLisstaItems.AllowUserToAddRows = false;

            // Oculta la columna de selección de fila
            dgvTienda.RowHeadersVisible = false;
            dgvTienda.AllowUserToAddRows = false;
            CargarDataGridView();
            CargarTiendasEnComboBox();
            if (cbTiendas.Items.Count > 0)
            {
                cbTiendas.SelectedIndex = 0;
            }

            // Llenar el ComboBox
            CargarCategoriasEnComboBox();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
    null, dgvTienda, new object[] { true });
            dgvTienda.VirtualMode = true;
            dgvTienda.CellValueNeeded += dgvTienda_CellValueNeeded;
        }
        private void dgvTienda_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < itemsSeleccionados.Count)
            {
                var item = itemsSeleccionados[e.RowIndex];
                switch (dgvTienda.Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "nombre": e.Value = item.nombre; break;
                    case "precio": e.Value = item.precio; break;
                    case "tipo_objeto": e.Value = item.tipo_objeto; break;
                    case "Imagen":
                        if (!string.IsNullOrEmpty(item.imagen_url))
                        {
                            e.Value = DescargarImagen(item.imagen_url);
                        }
                        break;
                }
            }
        }
        private Image DescargarImagen(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    byte[] imageData = client.DownloadData(url);
                    using (MemoryStream stream = new MemoryStream(imageData))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                return null;
            }
        }
        private void CargarCategoriasEnComboBox()
        {
            // Obtener categorías únicas y agregarlas a la lista
            var categoriasUnicas = itemsDisponibles.Select(o => o.tipo_objeto).Distinct().ToList();

            // Agregar la opción "Todos" al inicio de la lista
            categoriasUnicas.Insert(0, "Todos");

            // Llenar el ComboBox
            cbCat.Items.Clear();
            cbCat.Items.AddRange(categoriasUnicas.ToArray());

            // Seleccionar "Todos" por defecto
            cbCat.SelectedIndex = 0;
        }
        private void CargarDataGridView()
        {
            List<Item> listaItems = CargarItemsDesdeJson();

            // Configurar columnas
            dgvLisstaItems.DataSource = null;
            dgvLisstaItems.AutoGenerateColumns = false;
            dgvLisstaItems.Columns.Clear();

            // Agregar columnas

            dgvLisstaItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "nombre" });
            dgvLisstaItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "precio" });
            dgvLisstaItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tipo de Objeto", DataPropertyName = "tipo_objeto" });



            // Agregar una columna de imagen manualmente
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "Imagen";
            imgColumn.Name = "Imagen";
            imgColumn.DataPropertyName = "Imagen";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta la imagen al tamaño de la celda
            dgvTienda.Columns.Add(imgColumn);

            // Asignar el DataSource
            dgvTienda.DataSource = new BindingList<Item>(itemsSeleccionados);

            // Ocultar la columna de URL para que no se muestre
            if (dgvTienda.Columns["imagen_url"] != null)
            {
                dgvTienda.Columns["imagen_url"].Visible = false;
            }
            dgvTienda.Columns["costo"].Visible = false;
            dgvTienda.Columns["dado"].Visible = false;
            dgvTienda.Columns["tipo_dano"].Visible = false;
            dgvTienda.Columns["peso"].Visible = false;
            dgvTienda.Columns["origen"].Visible = false;

            // Cargar los datos en el DataGridView
            dgvLisstaItems.DataSource = listaItems;
        }
        private List<Item> CargarItemsDesdeJson()
        {
            if (!File.Exists("items.json"))
            {
                MessageBox.Show("El archivo JSON no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Item>();
            }

            try
            {
                string json = File.ReadAllText("items.json");
                itemsDisponibles = JsonConvert.DeserializeObject<List<Item>>(json);
                return itemsDisponibles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo JSON: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Item>();
            }
        }

        private void dgvLisstaItems_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvLisstaItems.CurrentRow == null) return;

            // Obtener el objeto de la fila seleccionada
            Item itemSeleccionado = dgvLisstaItems.CurrentRow.DataBoundItem as Item;
            if (itemSeleccionado != null)
            {
                dgvLisstaItems.DoDragDrop(itemSeleccionado, DragDropEffects.Move);
            }
        }

        private void dgvTienda_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Item)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void dgvTienda_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Item)))
            {
                Item itemMovido = (Item)e.Data.GetData(typeof(Item));

                if (itemMovido != null)
                {
                    // Mover de DataGridView1 a DataGridView2
                    // itemsDisponibles.Remove(itemMovido);
                    itemsSeleccionados.Add(itemMovido);

                    // Refrescar DataGridViews
                    dgvLisstaItems.DataSource = new BindingList<Item>(itemsDisponibles);
                    dgvTienda.DataSource = new BindingList<Item>(itemsSeleccionados);
                }
            }
        }

        private void CargarTiendasEnComboBox()
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, GlobalTools.DM + "_shops.json");

                if (!File.Exists(filePath))
                {

                    return;
                }

                // Leer el JSON
                string json = File.ReadAllText(filePath);
                if (string.IsNullOrWhiteSpace(json))
                {

                    return;
                }

                // Deserializar y llenar la lista de tiendas
                tiendas = JsonConvert.DeserializeObject<List<ShopData>>(json);

                if (tiendas == null || tiendas.Count == 0)
                {
                    MessageBox.Show("No hay tiendas guardadas en el archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llenar ComboBox con los nombres de tiendas
                cbTiendas.DataSource = tiendas.Select(t => t.NombreTienda).ToList();
                cbTiendas.SelectedIndex = -1; // No seleccionar ninguna por defecto
            }
            catch (Exception ex)
            {
                return;
            }
        }
        private void GuardarTiendaEnJSON()
        {
            try
            {
                // Verificar si el nombre de la tienda está vacío
                if (string.IsNullOrWhiteSpace(txtShopName.Text))
                {
                    MessageBox.Show("El nombre de la tienda no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener los ítems desde el DataGridView
                var bindingList = dgvTienda.DataSource as BindingList<Item>;
                if (bindingList == null || bindingList.Count == 0)
                {
                    MessageBox.Show("No hay ítems en la tienda para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir BindingList a List
                List<Item> itemsEnTienda = bindingList.ToList();

                // Ruta del archivo JSON
                string filePath = Path.Combine(Application.StartupPath, GlobalTools.DM + "_shops.json");

                // Lista de tiendas (si el archivo ya existe, cargarlo)
                List<ShopData> listaTiendas = new List<ShopData>();

                if (File.Exists(filePath))
                {
                    string jsonExistente = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(jsonExistente))
                    {
                        listaTiendas = JsonConvert.DeserializeObject<List<ShopData>>(jsonExistente);
                    }
                }

                // Crear la tienda nueva
                ShopData nuevaTienda = new ShopData
                {
                    NombreTienda = txtShopName.Text,
                    Items = itemsEnTienda // Usamos la lista convertida
                };

                // Agregar la nueva tienda a la lista
                listaTiendas.Add(nuevaTienda);

                // Convertir a JSON
                string jsonFinal = JsonConvert.SerializeObject(listaTiendas, Formatting.Indented);

                // Guardar en el archivo
                File.WriteAllText(filePath, jsonFinal);
                CargarTiendasEnComboBox();
                MessageBox.Show("Tienda guardada correctamente en 'shops.json'", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la tienda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void AgregarItemsAleatorios(int cantidad)
        {
            if (itemsDisponibles.Count == 0) return;

            Random random = new Random();

            // Mezclar la lista y tomar 'cantidad' de elementos
            var seleccionados = itemsDisponibles.OrderBy(x => random.Next()).Take(cantidad).ToList();

            // Agregar a la lista de seleccionados
            itemsSeleccionados.AddRange(seleccionados);

            // Eliminar de la lista de disponibles
            /*foreach (var item in seleccionados)
            {
                itemsDisponibles.Remove(item);
            }*/

            // Refrescar los DataGridViews
            dgvLisstaItems.DataSource = new BindingList<Item>(itemsDisponibles);
            dgvTienda.DataSource = new BindingList<Item>(itemsSeleccionados);
        }


        private void parrotPictureBox3_Click(object sender, EventArgs e)
        {
            AgregarItemsAleatorios((int)numItems.ValueNumber);
        }

        private void parrotPictureBox2_Click(object sender, EventArgs e)
        {
            GuardarTiendaEnJSON();
        }

        private void cbTiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTiendas.SelectedIndex != -1)
            {
                // Obtener el nombre de la tienda seleccionada
                string tiendaSeleccionada = cbTiendas.SelectedItem.ToString();

                // Buscar la tienda en la lista
                ShopData tienda = tiendas.FirstOrDefault(t => t.NombreTienda == tiendaSeleccionada);
                txtShopName.Text = tiendaSeleccionada;
                if (tienda != null)
                {
                    // Cargar los ítems en dgvTienda
                    dgvTienda.DataSource = new BindingList<Item>(tienda.Items);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Verificar si la lista de ítems seleccionados está inicializada
            if (itemsSeleccionados != null)
            {
                itemsSeleccionados.Clear(); // Vaciar la lista
            }

            // Asignar una nueva lista vacía al DataGridView
            dgvTienda.DataSource = new BindingList<Item>();

            // Refrescar la vista para que se actualice
            dgvTienda.Refresh();
        }

        private void btnFiltroBusca_TextChanged(object sender, EventArgs e)
        {
            string filtro = btnFiltroBusca.Text.Trim().ToLower();

            // Si el filtro está vacío, mostrar todos los ítems
            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvLisstaItems.DataSource = new BindingList<Item>(itemsDisponibles);
                return;
            }

            // Filtrar la lista de ítems
            var itemsFiltrados = itemsDisponibles
                .Where(item => item.nombre.ToLower().Contains(filtro))
                .ToList();

            // Actualizar el DataGridView con los resultados filtrados
            dgvLisstaItems.DataSource = new BindingList<Item>(itemsFiltrados);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTienda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Item itemSeleccionado = dgvTienda.Rows[e.RowIndex].DataBoundItem as Item;
                if (itemSeleccionado != null)
                {
                    FormDetalleItem formDetalle = new FormDetalleItem(itemSeleccionado);
                    formDetalle.ShowDialog();
                }
            }
        }

        private void parrotPictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat.SelectedItem == null) return;

            string categoriaSeleccionada = cbCat.SelectedItem.ToString();

            // Si se selecciona "Todos", mostrar todos los ítems
            List<Item> itemsFiltrados = (categoriaSeleccionada == "Todos")
                ? itemsDisponibles
                : itemsDisponibles.Where(item => item.tipo_objeto == categoriaSeleccionada).ToList();

            // Actualizar el DataGridView con los elementos filtrados
            dgvLisstaItems.DataSource = new BindingList<Item>(itemsFiltrados);
        }

        ///////////////////////
    }
}
