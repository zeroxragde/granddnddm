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
    public partial class TileCutterForm : Form
    {

        private Image baseImage;
        private int tileWidth = 32;
        private int tileHeight = 32;
        private string imagesFolder = Path.Combine(Application.StartupPath, "imagenes");
        private string jsonDataFile = Path.Combine(Application.StartupPath, "data_img.json");

        public TileCutterForm()
        {
            InitializeComponent();
            string sinEspacios = Regex.Replace(GlobalTools.DM, @"\s+", "");
            jsonDataFile = Path.Combine(Application.StartupPath, "data_" + sinEspacios + "_img.json");
            txtTileWidth.Value = tileWidth;
            txtTileHeight.Value = tileHeight;
        }

        private void btnLoadTileset_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    baseImage = Image.FromFile(ofd.FileName);
                    pbTileset.Image = baseImage;
                    pbTileset.Refresh();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void pbTileset_Paint(object sender, PaintEventArgs e)
        {
            if (baseImage != null)
            {
                e.Graphics.DrawImage(baseImage, new Rectangle(0, 0, pbTileset.Width, pbTileset.Height));

                // Dibujar la cuadrícula
                int cols = baseImage.Width / tileWidth;
                int rows = baseImage.Height / tileHeight;
                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        e.Graphics.DrawRectangle(Pens.Red, i * tileWidth, j * tileHeight, tileWidth, tileHeight);
                    }
                }
            }
        }

        private void pbTileset_MouseClick(object sender, MouseEventArgs e)
        {
            if (baseImage == null) return;

            int col = e.X / tileWidth;
            int row = e.Y / tileHeight;
            Rectangle selectedRect = new Rectangle(col * tileWidth, row * tileHeight, tileWidth, tileHeight);

            Bitmap croppedTile = new Bitmap(tileWidth, tileHeight);
            using (Graphics g = Graphics.FromImage(croppedTile))
            {
                g.DrawImage(baseImage, new Rectangle(0, 0, tileWidth, tileHeight), selectedRect, GraphicsUnit.Pixel);
            }

            SaveTileImage(croppedTile);
        }



        private void SaveTileImage(Bitmap tile)
        {
            if (!Directory.Exists(imagesFolder))
                Directory.CreateDirectory(imagesFolder);

            string fileName = Guid.NewGuid().ToString() + ".png";
            string filePath = Path.Combine(imagesFolder, fileName);
            tile.Save(filePath);

            AddTileToJson(fileName);
            MessageBox.Show("Tile guardado y agregado al JSON.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddTileToJson(string fileName)
        {
            List<ImageRecord> records = new List<ImageRecord>();

            if (File.Exists(jsonDataFile))
            {
                string json = File.ReadAllText(jsonDataFile);
                records = JsonSerializer.Deserialize<List<ImageRecord>>(json) ?? new List<ImageRecord>();
            }

            records.Add(new ImageRecord { Category = "tiles", FileName = fileName });

            string updatedJson = JsonSerializer.Serialize(records, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonDataFile, updatedJson);
        }

        private void txtTileWidth_ValueChanged(object sender, EventArgs e)
        {
            if (txtTileWidth.Value > 0)
            {
                tileWidth = (int)txtTileWidth.Value;
                pbTileset.Refresh();
            }
        }

        private void txtTileHeight_ValueChanged(object sender, EventArgs e)
        {
            if (txtTileHeight.Value > 0)
            {
                tileHeight = (int)txtTileHeight.Value;
                pbTileset.Refresh();
            }
        }



        //////////////
    }
}
