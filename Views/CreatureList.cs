using GranDnDDM.Models;
using GranDnDDM.Models.Creatura;
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
    public partial class CreatureList : Form
    {
        CreatureEditor editor = new CreatureEditor();
        public CreatureList()
        {
            InitializeComponent();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            editor.Show();
        }

        private void dreamButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCreaturasFromFile()
        {
            string filePath = Path.Combine(Application.StartupPath, "Creaturas.json");
            if (!File.Exists(filePath))
            {
                return;
            }

            try
            {
                string json = File.ReadAllText(filePath);
                List<CreaturaRecord> registros = JsonConvert.DeserializeObject<List<CreaturaRecord>>(json);

                // Limpiar la lista antes de agregar nuevos elementos
                listCreature.Rows.Clear();

                // Agregar cada criatura a la tabla (guardamos FileName en una columna oculta)
                foreach (var reg in registros)
                {
                    listCreature.Rows.Add(reg.FileName, reg.Nombre, reg.CR);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo Creaturas.json: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CreatureList_Load(object sender, EventArgs e)
        {
            // Fondo del DataGridView
            listCreature.BackgroundColor = Color.Black; // Cambia a tu color preferido

            // Fondo de las celdas
            listCreature.DefaultCellStyle.BackColor = Color.Black;
            listCreature.DefaultCellStyle.ForeColor = Color.White; // Color del texto

            // Color de fondo para las filas seleccionadas
            listCreature.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
            listCreature.DefaultCellStyle.SelectionForeColor = Color.White;


            // Color del encabezado
            listCreature.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            listCreature.ColumnHeadersDefaultCellStyle.ForeColor = Color.Tan;
            //listCreature.EnableHeadersVisualStyles = false;

            // Quitar bordes si lo deseas
            listCreature.GridColor = Color.Black; // Color de la cuadrícula

            listCreature.RowHeadersVisible = false;
            listCreature.AllowUserToAddRows = false;

            listCreature.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular);

            listCreature.Columns.Clear();
            listCreature.Rows.Clear();

            // Agregar columnas

            listCreature.Columns.Add("FileName", "Archivo");
            listCreature.Columns.Add("Nombre", "Nombre");
            listCreature.Columns.Add("CR", "CR");
            listCreature.RowTemplate.Height = 35; // Ajusta la altura de cada fila
            // Ajustar el tamaño de las columnas
            listCreature.Columns["Nombre"].Width = 200;
            listCreature.Columns["CR"].Width = 100;

            // Evitar edición directa en celdas
            listCreature.ReadOnly = true;

            // Establecer el modo de selección completo de
            //
            listCreature.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Permite seleccionar filas completas
            listCreature.MultiSelect = false; // Evita múltiples selecciones si no lo necesitas
            listCreature.ReadOnly = false; // Asegura que no está en modo solo lectura
            listCreature.AllowUserToAddRows = false; // Evita filas vacías al final
            listCreature.AllowUserToResizeRows = false; // Evita cambios inesperados
            listCreature.EnableHeadersVisualStyles = false; // Evita que el estil
            listCreature.Columns[0].Visible = false;
            LoadCreaturasFromFile();
        }

        private void listCreature_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Verifica que no sea el encabezado
            {
                // Obtiene el FileName de la fila seleccionada (columna oculta)
                string fileName = listCreature.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Construye la ruta completa
                string filePath = Path.Combine(Application.StartupPath, fileName);

                // Verifica que el archivo existe antes de intentar abrirlo
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);

                    // Deserializa el JSON en la clase Creatura
                    Creatura creatura = JsonConvert.DeserializeObject<Creatura>(jsonContent);

                    if (creatura != null)
                    {
                        CreatureGen visor = new CreatureGen(creatura);
                        visor.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar la criatura desde el JSON.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe: " + filePath, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listCreature.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int selectedIndex = listCreature.SelectedRows[0].Index;

                // Obtener el nombre del archivo desde la fila seleccionada
                string fileName = listCreature.Rows[selectedIndex].Cells[0].Value.ToString();

                // Construir la ruta completa del archivo
                string filePath = Path.Combine(Application.StartupPath, fileName);

                // Confirmación antes de eliminar
                DialogResult result = MessageBox.Show($"¿Seguro que deseas eliminar la criatura '{fileName}'?",
                                                      "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Eliminar el archivo físico si existe
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }

                        // Eliminar el registro de `Creaturas.json`
                        string jsonPath = Path.Combine(Application.StartupPath, "Creaturas.json");
                        if (File.Exists(jsonPath))
                        {
                            string jsonContent = File.ReadAllText(jsonPath);
                            List<CreaturaRecord> registros = JsonConvert.DeserializeObject<List<CreaturaRecord>>(jsonContent);

                            // Remover la criatura del listado
                            registros.RemoveAll(c => c.FileName == fileName);

                            // Guardar nuevamente el archivo sin el registro eliminado
                            string updatedJson = JsonConvert.SerializeObject(registros, Formatting.Indented);
                            File.WriteAllText(jsonPath, updatedJson);
                        }

                        // Eliminar la fila del DataGridView
                        listCreature.Rows.RemoveAt(selectedIndex);

                        MessageBox.Show("Criatura eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la criatura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una criatura para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listCreature.SelectedRows.Count > 0)
            {
                // Obtiene el FileName de la fila seleccionada (columna oculta)
                string fileName = listCreature.SelectedRows[0].Cells[0].Value.ToString();

                // Construye la ruta completa
                string filePath = Path.Combine(Application.StartupPath, fileName);

                // Verifica que el archivo existe antes de intentar abrirlo
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);

                    // Deserializa el JSON en la clase Creatura
                    Creatura creatura = JsonConvert.DeserializeObject<Creatura>(jsonContent);

                    if (creatura != null)
                    {
                        CreatureEditor editor = new CreatureEditor(creatura);
                        editor.Show();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cargar la criatura desde el JSON.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe: " + filePath, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //////////////////////////////////////////
    }
}
