namespace GranDnDDM.Views
{
    partial class EditorMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorMap));
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            ilCursores = new ImageList(components);
            ilTiles = new ImageList(components);
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            btnSpriteSheet = new Button();
            btnFillMap = new Button();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnRefresh = new Button();
            pGrid = new Panel();
            mapEditor = new GranDnDDM.Tools.MapEditor();
            btnLoadMap = new Button();
            btnSaveMap = new Button();
            pvPreview = new PictureBox();
            btnDeleteImg = new Button();
            listViewTiles = new ListView();
            btnNone = new Button();
            btnErase = new Button();
            btnDraw = new Button();
            btnAddLayer = new Button();
            cmbLayers = new ComboBox();
            CmbFilter = new ComboBox();
            btnAddImage = new Button();
            cmbCategory = new ComboBox();
            ToggleLayerButton = new Button();
            dreamForm1.SuspendLayout();
            pGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pvPreview).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add_img.png");
            imageList1.Images.SetKeyName(1, "add_layer.png");
            imageList1.Images.SetKeyName(2, "spritesheetsel.png");
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "add_layer.png");
            imageList2.Images.SetKeyName(1, "pencil.png");
            imageList2.Images.SetKeyName(2, "1331349.png");
            imageList2.Images.SetKeyName(3, "cursor.png");
            imageList2.Images.SetKeyName(4, "deleteImg.png");
            imageList2.Images.SetKeyName(5, "save.png");
            imageList2.Images.SetKeyName(6, "6385107.png");
            imageList2.Images.SetKeyName(7, "refresh_map.png");
            imageList2.Images.SetKeyName(8, "fullPaint.png");
            imageList2.Images.SetKeyName(9, "hidenlayer.png");
            // 
            // ilCursores
            // 
            ilCursores.ColorDepth = ColorDepth.Depth32Bit;
            ilCursores.ImageStream = (ImageListStreamer)resources.GetObject("ilCursores.ImageStream");
            ilCursores.TransparentColor = Color.Transparent;
            ilCursores.Images.SetKeyName(0, "penMouse.ico");
            // 
            // ilTiles
            // 
            ilTiles.ColorDepth = ColorDepth.Depth32Bit;
            ilTiles.ImageSize = new Size(64, 64);
            ilTiles.TransparentColor = Color.Transparent;
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(ToggleLayerButton);
            dreamForm1.Controls.Add(btnSpriteSheet);
            dreamForm1.Controls.Add(btnFillMap);
            dreamForm1.Controls.Add(btnClose);
            dreamForm1.Controls.Add(btnRefresh);
            dreamForm1.Controls.Add(pGrid);
            dreamForm1.Controls.Add(btnLoadMap);
            dreamForm1.Controls.Add(btnSaveMap);
            dreamForm1.Controls.Add(pvPreview);
            dreamForm1.Controls.Add(btnDeleteImg);
            dreamForm1.Controls.Add(listViewTiles);
            dreamForm1.Controls.Add(btnNone);
            dreamForm1.Controls.Add(btnErase);
            dreamForm1.Controls.Add(btnDraw);
            dreamForm1.Controls.Add(btnAddLayer);
            dreamForm1.Controls.Add(cmbLayers);
            dreamForm1.Controls.Add(CmbFilter);
            dreamForm1.Controls.Add(btnAddImage);
            dreamForm1.Controls.Add(cmbCategory);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Margin = new Padding(2);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(1412, 505);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Map Editor";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 20;
            // 
            // btnSpriteSheet
            // 
            btnSpriteSheet.ForeColor = Color.Black;
            btnSpriteSheet.ImageIndex = 2;
            btnSpriteSheet.ImageList = imageList1;
            btnSpriteSheet.Location = new Point(96, 24);
            btnSpriteSheet.Name = "btnSpriteSheet";
            btnSpriteSheet.Size = new Size(78, 69);
            btnSpriteSheet.TabIndex = 38;
            btnSpriteSheet.UseVisualStyleBackColor = true;
            btnSpriteSheet.Click += btnSpriteSheet_Click;
            // 
            // btnFillMap
            // 
            btnFillMap.ForeColor = Color.Black;
            btnFillMap.ImageIndex = 8;
            btnFillMap.ImageList = imageList2;
            btnFillMap.Location = new Point(469, 437);
            btnFillMap.Name = "btnFillMap";
            btnFillMap.Size = new Size(44, 41);
            btnFillMap.TabIndex = 37;
            btnFillMap.UseVisualStyleBackColor = true;
            btnFillMap.Click += btnFillMap_Click;
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
            btnClose.Location = new Point(1370, 1);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 36;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.ImageIndex = 7;
            btnRefresh.ImageList = imageList2;
            btnRefresh.Location = new Point(1256, 466);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(44, 41);
            btnRefresh.TabIndex = 35;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pGrid
            // 
            pGrid.AutoScroll = true;
            pGrid.BackgroundImage = Properties.Resources.backEpicoNormalized;
            pGrid.BackgroundImageLayout = ImageLayout.Stretch;
            pGrid.Controls.Add(mapEditor);
            pGrid.Location = new Point(371, 35);
            pGrid.Name = "pGrid";
            pGrid.Size = new Size(1029, 396);
            pGrid.TabIndex = 34;
            // 
            // mapEditor
            // 
            mapEditor.ActiveLayerIndex = 0;
            mapEditor.AllowDrop = true;
            mapEditor.BackColor = Color.Transparent;
            mapEditor.Columns = 64;
            mapEditor.CurrentToolMode = Enums.ToolMode.None;
            mapEditor.DrawingImage = null;
            mapEditor.DrawingItem = null;
            mapEditor.Location = new Point(1, 4);
            mapEditor.Name = "mapEditor";
            mapEditor.Rows = 64;
            mapEditor.Size = new Size(1023, 385);
            mapEditor.TabIndex = 1;
            mapEditor.TileSize = 32;
            // 
            // btnLoadMap
            // 
            btnLoadMap.ForeColor = Color.Black;
            btnLoadMap.ImageIndex = 6;
            btnLoadMap.ImageList = imageList2;
            btnLoadMap.Location = new Point(1306, 466);
            btnLoadMap.Name = "btnLoadMap";
            btnLoadMap.Size = new Size(44, 41);
            btnLoadMap.TabIndex = 33;
            btnLoadMap.UseVisualStyleBackColor = true;
            btnLoadMap.Click += btnLoadMap_Click;
            // 
            // btnSaveMap
            // 
            btnSaveMap.ForeColor = Color.Black;
            btnSaveMap.ImageIndex = 5;
            btnSaveMap.ImageList = imageList2;
            btnSaveMap.Location = new Point(1356, 466);
            btnSaveMap.Name = "btnSaveMap";
            btnSaveMap.Size = new Size(44, 41);
            btnSaveMap.TabIndex = 32;
            btnSaveMap.UseVisualStyleBackColor = true;
            btnSaveMap.Click += btnSaveMap_Click;
            // 
            // pvPreview
            // 
            pvPreview.Location = new Point(845, 442);
            pvPreview.Name = "pvPreview";
            pvPreview.Size = new Size(63, 56);
            pvPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            pvPreview.TabIndex = 31;
            pvPreview.TabStop = false;
            // 
            // btnDeleteImg
            // 
            btnDeleteImg.ForeColor = Color.Black;
            btnDeleteImg.ImageIndex = 4;
            btnDeleteImg.ImageList = imageList2;
            btnDeleteImg.Location = new Point(315, 82);
            btnDeleteImg.Name = "btnDeleteImg";
            btnDeleteImg.Size = new Size(44, 41);
            btnDeleteImg.TabIndex = 30;
            btnDeleteImg.UseVisualStyleBackColor = true;
            btnDeleteImg.Click += btnDeleteImg_Click;
            // 
            // listViewTiles
            // 
            listViewTiles.CheckBoxes = true;
            listViewTiles.LargeImageList = ilTiles;
            listViewTiles.Location = new Point(13, 130);
            listViewTiles.Name = "listViewTiles";
            listViewTiles.Size = new Size(346, 339);
            listViewTiles.TabIndex = 29;
            listViewTiles.UseCompatibleStateImageBehavior = false;
            listViewTiles.SelectedIndexChanged += listViewTiles_SelectedIndexChanged;
            listViewTiles.MouseDown += listViewTiles_MouseDown;
            // 
            // btnNone
            // 
            btnNone.ForeColor = Color.Black;
            btnNone.ImageIndex = 3;
            btnNone.ImageList = imageList2;
            btnNone.Location = new Point(569, 437);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(44, 41);
            btnNone.TabIndex = 28;
            btnNone.UseVisualStyleBackColor = true;
            btnNone.Click += btnNone_Click;
            // 
            // btnErase
            // 
            btnErase.ForeColor = Color.Black;
            btnErase.ImageIndex = 2;
            btnErase.ImageList = imageList2;
            btnErase.Location = new Point(519, 437);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(44, 41);
            btnErase.TabIndex = 27;
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnDraw
            // 
            btnDraw.ForeColor = Color.Black;
            btnDraw.ImageIndex = 1;
            btnDraw.ImageList = imageList2;
            btnDraw.Location = new Point(421, 437);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(44, 41);
            btnDraw.TabIndex = 26;
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnAddLayer
            // 
            btnAddLayer.ForeColor = Color.Black;
            btnAddLayer.ImageIndex = 0;
            btnAddLayer.ImageList = imageList2;
            btnAddLayer.Location = new Point(371, 437);
            btnAddLayer.Name = "btnAddLayer";
            btnAddLayer.Size = new Size(44, 41);
            btnAddLayer.TabIndex = 25;
            btnAddLayer.UseVisualStyleBackColor = true;
            btnAddLayer.Click += btnAddLayer_Click;
            // 
            // cmbLayers
            // 
            cmbLayers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLayers.FormattingEnabled = true;
            cmbLayers.Location = new Point(1017, 437);
            cmbLayers.Name = "cmbLayers";
            cmbLayers.Size = new Size(383, 23);
            cmbLayers.TabIndex = 24;
            cmbLayers.SelectedIndexChanged += cmbLayers_SelectedIndexChanged;
            // 
            // CmbFilter
            // 
            CmbFilter.FormattingEnabled = true;
            CmbFilter.Location = new Point(12, 475);
            CmbFilter.Name = "CmbFilter";
            CmbFilter.Size = new Size(347, 23);
            CmbFilter.TabIndex = 23;
            CmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;
            // 
            // btnAddImage
            // 
            btnAddImage.ForeColor = Color.Black;
            btnAddImage.ImageIndex = 0;
            btnAddImage.ImageList = imageList1;
            btnAddImage.Location = new Point(12, 24);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(78, 69);
            btnAddImage.TabIndex = 22;
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(13, 100);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(149, 23);
            cmbCategory.TabIndex = 21;
            // 
            // ToggleLayerButton
            // 
            ToggleLayerButton.ForeColor = Color.Black;
            ToggleLayerButton.ImageIndex = 9;
            ToggleLayerButton.ImageList = imageList2;
            ToggleLayerButton.Location = new Point(1018, 464);
            ToggleLayerButton.Name = "ToggleLayerButton";
            ToggleLayerButton.Size = new Size(44, 41);
            ToggleLayerButton.TabIndex = 39;
            ToggleLayerButton.UseVisualStyleBackColor = true;
            ToggleLayerButton.Click += ToggleLayerButton_Click;
            // 
            // EditorMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1412, 505);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditorMap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditorMap";
            FormClosing += EditorMap_FormClosing;
            Load += EditorMap_Load;
            dreamForm1.ResumeLayout(false);
            pGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pvPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList ilCursores;
        private ImageList ilTiles;
        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private Button btnRefresh;
        private Panel pGrid;
        private Tools.MapEditor mapEditor;
        private Button btnLoadMap;
        private Button btnSaveMap;
        private PictureBox pvPreview;
        private Button btnDeleteImg;
        private ListView listViewTiles;
        private Button btnNone;
        private Button btnErase;
        private Button btnDraw;
        private Button btnAddLayer;
        private ComboBox cmbLayers;
        private ComboBox CmbFilter;
        private Button btnAddImage;
        private ComboBox cmbCategory;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
        private Button btnFillMap;
        private Button btnSpriteSheet;
        private Button ToggleLayerButton;
    }
}