namespace GranDnDDM.Views
{
    partial class ShopCreeator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopCreeator));
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            btnShow = new ReaLTaiizor.Controls.ParrotPictureBox();
            cbCat = new ReaLTaiizor.Controls.HopeComboBox();
            parrotPictureBox4 = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnNuevo = new ReaLTaiizor.Controls.ParrotPictureBox();
            parrotPictureBox3 = new ReaLTaiizor.Controls.ParrotPictureBox();
            numItems = new ReaLTaiizor.Controls.HopeNumeric();
            txtShopName = new ReaLTaiizor.Controls.HopeTextBox();
            parrotPictureBox2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnFiltroBusca = new ReaLTaiizor.Controls.HopeTextBox();
            cbTiendas = new ReaLTaiizor.Controls.HopeComboBox();
            dgvTienda = new DataGridView();
            dgvLisstaItems = new DataGridView();
            imageList1 = new ImageList(components);
            dreamForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTienda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLisstaItems).BeginInit();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(btnShow);
            dreamForm1.Controls.Add(cbCat);
            dreamForm1.Controls.Add(parrotPictureBox4);
            dreamForm1.Controls.Add(btnNuevo);
            dreamForm1.Controls.Add(parrotPictureBox3);
            dreamForm1.Controls.Add(numItems);
            dreamForm1.Controls.Add(txtShopName);
            dreamForm1.Controls.Add(parrotPictureBox2);
            dreamForm1.Controls.Add(parrotPictureBox1);
            dreamForm1.Controls.Add(btnFiltroBusca);
            dreamForm1.Controls.Add(cbTiendas);
            dreamForm1.Controls.Add(dgvTienda);
            dreamForm1.Controls.Add(dgvLisstaItems);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(1028, 506);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Generador de Tiendas";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Transparent;
            btnShow.ColorLeft = Color.Transparent;
            btnShow.ColorRight = Color.Turquoise;
            btnShow.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnShow.FilterAlpha = 200;
            btnShow.FilterEnabled = false;
            btnShow.Image = Properties.Resources.seeicon;
            btnShow.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnShow.IsElipse = false;
            btnShow.IsParallax = false;
            btnShow.Location = new Point(903, 428);
            btnShow.Name = "btnShow";
            btnShow.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnShow.Size = new Size(42, 43);
            btnShow.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnShow.TabIndex = 18;
            btnShow.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnShow.Click += btnShow_Click;
            // 
            // cbCat
            // 
            cbCat.DrawMode = DrawMode.OwnerDrawFixed;
            cbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCat.FlatStyle = FlatStyle.Flat;
            cbCat.Font = new Font("Segoe UI", 12F);
            cbCat.FormattingEnabled = true;
            cbCat.ItemHeight = 30;
            cbCat.Location = new Point(12, 450);
            cbCat.Name = "cbCat";
            cbCat.Size = new Size(314, 36);
            cbCat.TabIndex = 17;
            cbCat.SelectedIndexChanged += cbCat_SelectedIndexChanged;
            // 
            // parrotPictureBox4
            // 
            parrotPictureBox4.BackColor = Color.Transparent;
            parrotPictureBox4.BackgroundImage = Properties.Resources.closewin;
            parrotPictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            parrotPictureBox4.ColorLeft = Color.DodgerBlue;
            parrotPictureBox4.ColorRight = Color.DodgerBlue;
            parrotPictureBox4.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox4.FilterAlpha = 200;
            parrotPictureBox4.FilterEnabled = true;
            parrotPictureBox4.Image = null;
            parrotPictureBox4.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox4.IsElipse = false;
            parrotPictureBox4.IsParallax = false;
            parrotPictureBox4.Location = new Point(989, 6);
            parrotPictureBox4.Name = "parrotPictureBox4";
            parrotPictureBox4.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox4.Size = new Size(27, 26);
            parrotPictureBox4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox4.TabIndex = 16;
            parrotPictureBox4.Text = "parrotPictureBox4";
            parrotPictureBox4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPictureBox4.Click += parrotPictureBox4_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Transparent;
            btnNuevo.ColorLeft = Color.Transparent;
            btnNuevo.ColorRight = Color.Turquoise;
            btnNuevo.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnNuevo.FilterAlpha = 200;
            btnNuevo.FilterEnabled = false;
            btnNuevo.Image = Properties.Resources.newicon_removebg_preview;
            btnNuevo.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnNuevo.IsElipse = false;
            btnNuevo.IsParallax = false;
            btnNuevo.Location = new Point(860, 433);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnNuevo.Size = new Size(37, 34);
            btnNuevo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnNuevo.TabIndex = 11;
            btnNuevo.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // parrotPictureBox3
            // 
            parrotPictureBox3.BackColor = Color.Transparent;
            parrotPictureBox3.ColorLeft = Color.Transparent;
            parrotPictureBox3.ColorRight = Color.Turquoise;
            parrotPictureBox3.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox3.FilterAlpha = 200;
            parrotPictureBox3.FilterEnabled = false;
            parrotPictureBox3.Image = Properties.Resources.myRandom;
            parrotPictureBox3.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox3.IsElipse = false;
            parrotPictureBox3.IsParallax = false;
            parrotPictureBox3.Location = new Point(138, 22);
            parrotPictureBox3.Name = "parrotPictureBox3";
            parrotPictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox3.Size = new Size(42, 43);
            parrotPictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox3.TabIndex = 10;
            parrotPictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPictureBox3.Click += parrotPictureBox3_Click;
            // 
            // numItems
            // 
            numItems.BackColor = Color.White;
            numItems.BaseColor = Color.FromArgb(242, 246, 252);
            numItems.BorderColorA = Color.FromArgb(192, 196, 204);
            numItems.BorderColorB = Color.FromArgb(192, 196, 204);
            numItems.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            numItems.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            numItems.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            numItems.EnterKey = true;
            numItems.Font = new Font("Segoe UI", 12F);
            numItems.ForeColor = Color.Black;
            numItems.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            numItems.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            numItems.Location = new Point(12, 29);
            numItems.MaxNum = 10F;
            numItems.MinNum = 0F;
            numItems.Name = "numItems";
            numItems.Precision = 0;
            numItems.Size = new Size(120, 32);
            numItems.Step = 1F;
            numItems.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            numItems.TabIndex = 9;
            numItems.Text = "hopeNumeric1";
            numItems.ValueNumber = 5F;
            // 
            // txtShopName
            // 
            txtShopName.BackColor = Color.White;
            txtShopName.BaseColor = Color.FromArgb(44, 55, 66);
            txtShopName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtShopName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtShopName.Font = new Font("Segoe UI", 12F);
            txtShopName.ForeColor = Color.FromArgb(48, 49, 51);
            txtShopName.Hint = "Nombre de Tienda";
            txtShopName.Location = new Point(396, 38);
            txtShopName.MaxLength = 32767;
            txtShopName.Multiline = false;
            txtShopName.Name = "txtShopName";
            txtShopName.PasswordChar = '\0';
            txtShopName.ScrollBars = ScrollBars.None;
            txtShopName.SelectedText = "";
            txtShopName.SelectionLength = 0;
            txtShopName.SelectionStart = 0;
            txtShopName.Size = new Size(604, 38);
            txtShopName.TabIndex = 7;
            txtShopName.TabStop = false;
            txtShopName.UseSystemPasswordChar = false;
            // 
            // parrotPictureBox2
            // 
            parrotPictureBox2.BackColor = Color.Transparent;
            parrotPictureBox2.ColorLeft = Color.Transparent;
            parrotPictureBox2.ColorRight = Color.Turquoise;
            parrotPictureBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox2.FilterAlpha = 200;
            parrotPictureBox2.FilterEnabled = false;
            parrotPictureBox2.Image = Properties.Resources.save;
            parrotPictureBox2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox2.IsElipse = false;
            parrotPictureBox2.IsParallax = false;
            parrotPictureBox2.Location = new Point(815, 432);
            parrotPictureBox2.Name = "parrotPictureBox2";
            parrotPictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox2.Size = new Size(37, 34);
            parrotPictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox2.TabIndex = 6;
            parrotPictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotPictureBox2.Click += parrotPictureBox2_Click;
            // 
            // parrotPictureBox1
            // 
            parrotPictureBox1.BackColor = Color.Transparent;
            parrotPictureBox1.ColorLeft = Color.Transparent;
            parrotPictureBox1.ColorRight = Color.Turquoise;
            parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            parrotPictureBox1.FilterAlpha = 200;
            parrotPictureBox1.FilterEnabled = false;
            parrotPictureBox1.Image = Properties.Resources.mitrash;
            parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            parrotPictureBox1.IsElipse = false;
            parrotPictureBox1.IsParallax = false;
            parrotPictureBox1.Location = new Point(768, 426);
            parrotPictureBox1.Name = "parrotPictureBox1";
            parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotPictureBox1.Size = new Size(41, 43);
            parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            parrotPictureBox1.TabIndex = 5;
            parrotPictureBox1.Text = "parrotPictureBox1";
            parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnFiltroBusca
            // 
            btnFiltroBusca.BackColor = Color.White;
            btnFiltroBusca.BaseColor = Color.FromArgb(44, 55, 66);
            btnFiltroBusca.BorderColorA = Color.FromArgb(64, 158, 255);
            btnFiltroBusca.BorderColorB = Color.FromArgb(220, 223, 230);
            btnFiltroBusca.Font = new Font("Segoe UI", 12F);
            btnFiltroBusca.ForeColor = Color.FromArgb(48, 49, 51);
            btnFiltroBusca.Hint = "Buscar Objeto";
            btnFiltroBusca.Location = new Point(12, 406);
            btnFiltroBusca.MaxLength = 32767;
            btnFiltroBusca.Multiline = false;
            btnFiltroBusca.Name = "btnFiltroBusca";
            btnFiltroBusca.PasswordChar = '\0';
            btnFiltroBusca.ScrollBars = ScrollBars.None;
            btnFiltroBusca.SelectedText = "";
            btnFiltroBusca.SelectionLength = 0;
            btnFiltroBusca.SelectionStart = 0;
            btnFiltroBusca.Size = new Size(314, 38);
            btnFiltroBusca.TabIndex = 4;
            btnFiltroBusca.TabStop = false;
            btnFiltroBusca.UseSystemPasswordChar = false;
            btnFiltroBusca.TextChanged += btnFiltroBusca_TextChanged;
            // 
            // cbTiendas
            // 
            cbTiendas.DrawMode = DrawMode.OwnerDrawFixed;
            cbTiendas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTiendas.FlatStyle = FlatStyle.Flat;
            cbTiendas.Font = new Font("Segoe UI", 12F);
            cbTiendas.FormattingEnabled = true;
            cbTiendas.ItemHeight = 30;
            cbTiendas.Location = new Point(396, 428);
            cbTiendas.Name = "cbTiendas";
            cbTiendas.Size = new Size(366, 36);
            cbTiendas.TabIndex = 3;
            cbTiendas.SelectedIndexChanged += cbTiendas_SelectedIndexChanged;
            // 
            // dgvTienda
            // 
            dgvTienda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTienda.GridColor = Color.Black;
            dgvTienda.Location = new Point(396, 78);
            dgvTienda.Name = "dgvTienda";
            dgvTienda.ReadOnly = true;
            dgvTienda.ScrollBars = ScrollBars.Horizontal;
            dgvTienda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTienda.ShowCellErrors = false;
            dgvTienda.ShowEditingIcon = false;
            dgvTienda.Size = new Size(604, 344);
            dgvTienda.TabIndex = 1;
            dgvTienda.CellDoubleClick += dgvTienda_CellDoubleClick;
            dgvTienda.DragDrop += dgvTienda_DragDrop;
            dgvTienda.DragEnter += dgvTienda_DragEnter;
            // 
            // dgvLisstaItems
            // 
            dgvLisstaItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLisstaItems.Location = new Point(12, 67);
            dgvLisstaItems.Name = "dgvLisstaItems";
            dgvLisstaItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLisstaItems.Size = new Size(314, 333);
            dgvLisstaItems.TabIndex = 0;
            dgvLisstaItems.MouseDown += dgvLisstaItems_MouseDown;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "mitrash.png");
            imageList1.Images.SetKeyName(1, "save.png");
            // 
            // ShopCreeator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 506);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShopCreeator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShopCreeator";
            FormClosed += ShopCreeator_FormClosed;
            dreamForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTienda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLisstaItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private DataGridView dgvLisstaItems;
        private ReaLTaiizor.Controls.HopeTextBox btnFiltroBusca;
        private ReaLTaiizor.Controls.HopeComboBox cbTiendas;
        private DataGridView dgvTienda;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtShopName;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox2;
        private ReaLTaiizor.Controls.HopeNumeric numItems;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox3;
        private ReaLTaiizor.Controls.ParrotPictureBox btnNuevo;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox4;
        private ReaLTaiizor.Controls.HopeComboBox cbCat;
        private ReaLTaiizor.Controls.ParrotPictureBox btnShow;
    }
}