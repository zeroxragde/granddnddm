using GranDnDDM.Models;
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
    public partial class FormDetalleItem : Form
    {
        public FormDetalleItem(Item i)
        {
            InitializeComponent();
            CargarDetalles(i);
        }

        private void CargarDetalles(Item item)
        {
            lblNombre.Text = $"Nombre: {item.nombre}";
            lblDescripcion.Text = $"Descripción: {item.descripcion}";
            lblPrecio.Text = $"Precio: {item.precio}";
            lblTipoObjeto.Text = $"Tipo: {item.tipo_objeto}";
            lblCategoria.Text = $"Categoría: {item.categoria}";

            // Cargar imagen si existe URL
            if (!string.IsNullOrEmpty(item.imagen_url))
            {
                try
                {
                    pictureBoxImagen.Load(item.imagen_url);
                }
                catch
                {
                    //  pictureBoxImagen.Image = Properties.Resources.imagen_default; // Imagen por defecto
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
