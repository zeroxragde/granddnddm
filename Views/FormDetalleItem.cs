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
        private Item objeto;
        public FormDetalleItem(Item i)
        {
            InitializeComponent();
            objeto = i;
            CargarDetalles(i);
        }

        private void CargarDetalles(Item item)
        {
            lblNombre.Text = $"Nombre: {item.nombre}";
            lblDescripcion.Text = $"Descripción: {item.descripcion}";
            lblPrecio.Text = $"Precio: {item.precio}";
            lblTipoObjeto.Text = $"Tipo: {item.tipo_objeto}";
            lblCategoria.Text = $"Categoría: {item.categoria}";
            string damage = item.dado != "Desconocido" && item.tipo_dano  != "Desconocido" ? $"{item.dado}{item.tipo_dano}":"N/A";
            lblDano.Text = damage;

            // Cargar imagen si existe URL
            if (!string.IsNullOrEmpty(item.imagen_url))
            {
                try
                {
                    pictureBoxImagen.Image = objeto.Imagen;
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(objeto.imagen_url))
            {
                try
                {
                    pictureBoxImagen.Image = objeto.Imagen;
                }
                catch
                {
                    //  pictureBoxImagen.Image = Properties.Resources.imagen_default; // Imagen por defecto
                }
            }
        }

        private void dreamForm1_Enter(object sender, EventArgs e)
        {

        }
    }
}
