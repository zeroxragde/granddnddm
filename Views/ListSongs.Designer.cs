namespace GranDnDDM.Views
{
    partial class ListSongs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSongs));
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnAddToCola = new Button();
            label2 = new Label();
            cbCatSelect = new ComboBox();
            btnDeletesong = new Button();
            btnAddMusic = new Button();
            label1 = new Label();
            btnDeleteCats = new Button();
            btnAddCategory = new Button();
            imageList3 = new ImageList(components);
            txtNewCategory = new TextBox();
            dvgMusica = new DataGridView();
            cbCatFilter = new ComboBox();
            foreverForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMusica).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "deleteImg.png");
            imageList1.Images.SetKeyName(1, "trash.png");
            imageList1.Images.SetKeyName(2, "addMusic.png");
            imageList1.Images.SetKeyName(3, "btnList.png");
            imageList1.Images.SetKeyName(4, "mitrash.png");
            imageList1.Images.SetKeyName(5, "trashSong.png");
            imageList1.Images.SetKeyName(6, "plus.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "addMusic.png");
            // 
            // foreverForm1
            // 
            foreverForm1.BackColor = Color.White;
            foreverForm1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverForm1.BorderColor = Color.DodgerBlue;
            foreverForm1.Controls.Add(btnClose);
            foreverForm1.Controls.Add(btnAddToCola);
            foreverForm1.Controls.Add(label2);
            foreverForm1.Controls.Add(cbCatSelect);
            foreverForm1.Controls.Add(btnDeletesong);
            foreverForm1.Controls.Add(btnAddMusic);
            foreverForm1.Controls.Add(label1);
            foreverForm1.Controls.Add(btnDeleteCats);
            foreverForm1.Controls.Add(btnAddCategory);
            foreverForm1.Controls.Add(txtNewCategory);
            foreverForm1.Controls.Add(dvgMusica);
            foreverForm1.Controls.Add(cbCatFilter);
            foreverForm1.Dock = DockStyle.Fill;
            foreverForm1.Font = new Font("Segoe UI", 12F);
            foreverForm1.ForeverColor = Color.FromArgb(35, 168, 109);
            foreverForm1.HeaderColor = Color.FromArgb(45, 47, 49);
            foreverForm1.HeaderMaximize = false;
            foreverForm1.HeaderTextFont = new Font("Segoe UI", 12F);
            foreverForm1.Image = null;
            foreverForm1.Location = new Point(0, 0);
            foreverForm1.MinimumSize = new Size(210, 50);
            foreverForm1.Name = "foreverForm1";
            foreverForm1.Padding = new Padding(1, 51, 1, 1);
            foreverForm1.Sizable = true;
            foreverForm1.Size = new Size(397, 598);
            foreverForm1.TabIndex = 0;
            foreverForm1.Text = "Lista de Canciones";
            foreverForm1.TextColor = Color.FromArgb(234, 234, 234);
            foreverForm1.TextLight = Color.SeaGreen;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.closewin;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.ColorLeft = Color.DodgerBlue;
            btnClose.ColorRight = Color.DodgerBlue;
            btnClose.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnClose.FilterAlpha = 200;
            btnClose.FilterEnabled = true;
            btnClose.Image = null;
            btnClose.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnClose.IsElipse = false;
            btnClose.IsParallax = false;
            btnClose.Location = new Point(360, 12);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 22;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddToCola
            // 
            btnAddToCola.ImageIndex = 3;
            btnAddToCola.ImageList = imageList1;
            btnAddToCola.Location = new Point(344, 150);
            btnAddToCola.Name = "btnAddToCola";
            btnAddToCola.Size = new Size(41, 45);
            btnAddToCola.TabIndex = 21;
            btnAddToCola.UseVisualStyleBackColor = true;
            btnAddToCola.Click += btnAddToCola_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 526);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 19;
            label2.Text = "Categoria";
            // 
            // cbCatSelect
            // 
            cbCatSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatSelect.FormattingEnabled = true;
            cbCatSelect.Location = new Point(80, 551);
            cbCatSelect.Name = "cbCatSelect";
            cbCatSelect.Size = new Size(199, 29);
            cbCatSelect.TabIndex = 17;
            // 
            // btnDeletesong
            // 
            btnDeletesong.ImageIndex = 5;
            btnDeletesong.ImageList = imageList1;
            btnDeletesong.Location = new Point(346, 99);
            btnDeletesong.Name = "btnDeletesong";
            btnDeletesong.Size = new Size(41, 45);
            btnDeletesong.TabIndex = 20;
            btnDeletesong.UseVisualStyleBackColor = true;
            btnDeletesong.Click += btnDeletesong_Click;
            // 
            // btnAddMusic
            // 
            btnAddMusic.ImageIndex = 0;
            btnAddMusic.ImageList = imageList2;
            btnAddMusic.Location = new Point(10, 515);
            btnAddMusic.Name = "btnAddMusic";
            btnAddMusic.Size = new Size(64, 59);
            btnAddMusic.TabIndex = 16;
            btnAddMusic.UseVisualStyleBackColor = true;
            btnAddMusic.Click += btnAddMusic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 452);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 18;
            label1.Text = "Agregar Categoria";
            // 
            // btnDeleteCats
            // 
            btnDeleteCats.ImageIndex = 4;
            btnDeleteCats.ImageList = imageList1;
            btnDeleteCats.Location = new Point(227, 62);
            btnDeleteCats.Name = "btnDeleteCats";
            btnDeleteCats.Size = new Size(47, 33);
            btnDeleteCats.TabIndex = 15;
            btnDeleteCats.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.ImageIndex = 0;
            btnAddCategory.ImageList = imageList3;
            btnAddCategory.Location = new Point(227, 477);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(34, 29);
            btnAddCategory.TabIndex = 14;
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageStream = (ImageListStreamer)resources.GetObject("imageList3.ImageStream");
            imageList3.TransparentColor = Color.Transparent;
            imageList3.Images.SetKeyName(0, "plus.png");
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(10, 477);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(211, 29);
            txtNewCategory.TabIndex = 13;
            // 
            // dvgMusica
            // 
            dvgMusica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMusica.Location = new Point(10, 99);
            dvgMusica.MultiSelect = false;
            dvgMusica.Name = "dvgMusica";
            dvgMusica.ReadOnly = true;
            dvgMusica.Size = new Size(330, 350);
            dvgMusica.TabIndex = 12;
            dvgMusica.CellDoubleClick += dvgMusica_CellDoubleClick;
            // 
            // cbCatFilter
            // 
            cbCatFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatFilter.FormattingEnabled = true;
            cbCatFilter.Location = new Point(10, 66);
            cbCatFilter.Name = "cbCatFilter";
            cbCatFilter.Size = new Size(211, 29);
            cbCatFilter.TabIndex = 11;
            cbCatFilter.SelectedIndexChanged += cbCatFilter_SelectedIndexChanged;
            // 
            // ListSongs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(397, 598);
            Controls.Add(foreverForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListSongs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListSongs";
            TransparencyKey = Color.Fuchsia;
            Load += ListSongs_Load;
            foreverForm1.ResumeLayout(false);
            foreverForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgMusica).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ImageList imageList2;
        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private Button btnAddToCola;
        private Label label2;
        private ComboBox cbCatSelect;
        private Button btnDeletesong;
        private Button btnAddMusic;
        private Label label1;
        private Button btnDeleteCats;
        private Button btnAddCategory;
        private TextBox txtNewCategory;
        private DataGridView dvgMusica;
        private ComboBox cbCatFilter;
        private ImageList imageList3;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}