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
            CmbFilter = new ComboBox();
            btnAddImage = new Button();
            imageList1 = new ImageList(components);
            cmbCategory = new ComboBox();
            cmbLayers = new ComboBox();
            btnAddLayer = new Button();
            imageList2 = new ImageList(components);
            btnDraw = new Button();
            btnErase = new Button();
            ilCursores = new ImageList(components);
            btnNone = new Button();
            listViewTiles = new ListView();
            ilTiles = new ImageList(components);
            btnDeleteImg = new Button();
            pvPreview = new PictureBox();
            btnSaveMap = new Button();
            btnLoadMap = new Button();
            pGrid = new Panel();
            mapEditor = new Tools.MapEditor();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)pvPreview).BeginInit();
            pGrid.SuspendLayout();
            SuspendLayout();
            // 
            // CmbFilter
            // 
            CmbFilter.FormattingEnabled = true;
            CmbFilter.Location = new Point(12, 463);
            CmbFilter.Name = "CmbFilter";
            CmbFilter.Size = new Size(347, 23);
            CmbFilter.TabIndex = 7;
            CmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;
            // 
            // btnAddImage
            // 
            btnAddImage.ForeColor = Color.Black;
            btnAddImage.ImageIndex = 0;
            btnAddImage.ImageList = imageList1;
            btnAddImage.Location = new Point(12, 12);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(78, 69);
            btnAddImage.TabIndex = 5;
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add_img.png");
            imageList1.Images.SetKeyName(1, "add_layer.png");
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(13, 88);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(149, 23);
            cmbCategory.TabIndex = 4;
            // 
            // cmbLayers
            // 
            cmbLayers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLayers.FormattingEnabled = true;
            cmbLayers.Location = new Point(1017, 425);
            cmbLayers.Name = "cmbLayers";
            cmbLayers.Size = new Size(383, 23);
            cmbLayers.TabIndex = 9;
            cmbLayers.SelectedIndexChanged += cmbLayers_SelectedIndexChanged;
            // 
            // btnAddLayer
            // 
            btnAddLayer.ForeColor = Color.Black;
            btnAddLayer.ImageIndex = 0;
            btnAddLayer.ImageList = imageList2;
            btnAddLayer.Location = new Point(371, 425);
            btnAddLayer.Name = "btnAddLayer";
            btnAddLayer.Size = new Size(44, 41);
            btnAddLayer.TabIndex = 10;
            btnAddLayer.UseVisualStyleBackColor = true;
            btnAddLayer.Click += btnAddLayer_Click;
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
            // 
            // btnDraw
            // 
            btnDraw.ForeColor = Color.Black;
            btnDraw.ImageIndex = 1;
            btnDraw.ImageList = imageList2;
            btnDraw.Location = new Point(421, 425);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(44, 41);
            btnDraw.TabIndex = 11;
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // btnErase
            // 
            btnErase.ForeColor = Color.Black;
            btnErase.ImageIndex = 2;
            btnErase.ImageList = imageList2;
            btnErase.Location = new Point(471, 425);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(44, 41);
            btnErase.TabIndex = 12;
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // ilCursores
            // 
            ilCursores.ColorDepth = ColorDepth.Depth32Bit;
            ilCursores.ImageStream = (ImageListStreamer)resources.GetObject("ilCursores.ImageStream");
            ilCursores.TransparentColor = Color.Transparent;
            ilCursores.Images.SetKeyName(0, "penMouse.ico");
            // 
            // btnNone
            // 
            btnNone.ForeColor = Color.Black;
            btnNone.ImageIndex = 3;
            btnNone.ImageList = imageList2;
            btnNone.Location = new Point(521, 425);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(44, 41);
            btnNone.TabIndex = 13;
            btnNone.UseVisualStyleBackColor = true;
            btnNone.Click += btnNone_Click;
            // 
            // listViewTiles
            // 
            listViewTiles.CheckBoxes = true;
            listViewTiles.LargeImageList = ilTiles;
            listViewTiles.Location = new Point(13, 118);
            listViewTiles.Name = "listViewTiles";
            listViewTiles.Size = new Size(346, 339);
            listViewTiles.TabIndex = 14;
            listViewTiles.UseCompatibleStateImageBehavior = false;
            listViewTiles.SelectedIndexChanged += listViewTiles_SelectedIndexChanged;
            listViewTiles.MouseDown += listViewTiles_MouseDown;
            // 
            // ilTiles
            // 
            ilTiles.ColorDepth = ColorDepth.Depth32Bit;
            ilTiles.ImageSize = new Size(64, 64);
            ilTiles.TransparentColor = Color.Transparent;
            // 
            // btnDeleteImg
            // 
            btnDeleteImg.ForeColor = Color.Black;
            btnDeleteImg.ImageIndex = 4;
            btnDeleteImg.ImageList = imageList2;
            btnDeleteImg.Location = new Point(315, 70);
            btnDeleteImg.Name = "btnDeleteImg";
            btnDeleteImg.Size = new Size(44, 41);
            btnDeleteImg.TabIndex = 15;
            btnDeleteImg.UseVisualStyleBackColor = true;
            btnDeleteImg.Click += btnDeleteImg_Click;
            // 
            // pvPreview
            // 
            pvPreview.Location = new Point(893, 425);
            pvPreview.Name = "pvPreview";
            pvPreview.Size = new Size(100, 68);
            pvPreview.TabIndex = 16;
            pvPreview.TabStop = false;
            // 
            // btnSaveMap
            // 
            btnSaveMap.ForeColor = Color.Black;
            btnSaveMap.ImageIndex = 5;
            btnSaveMap.ImageList = imageList2;
            btnSaveMap.Location = new Point(1356, 454);
            btnSaveMap.Name = "btnSaveMap";
            btnSaveMap.Size = new Size(44, 41);
            btnSaveMap.TabIndex = 17;
            btnSaveMap.UseVisualStyleBackColor = true;
            btnSaveMap.Click += btnSaveMap_Click;
            // 
            // btnLoadMap
            // 
            btnLoadMap.ForeColor = Color.Black;
            btnLoadMap.ImageIndex = 6;
            btnLoadMap.ImageList = imageList2;
            btnLoadMap.Location = new Point(1306, 454);
            btnLoadMap.Name = "btnLoadMap";
            btnLoadMap.Size = new Size(44, 41);
            btnLoadMap.TabIndex = 18;
            btnLoadMap.UseVisualStyleBackColor = true;
            btnLoadMap.Click += btnLoadMap_Click;
            // 
            // pGrid
            // 
            pGrid.AutoScroll = true;
            pGrid.BackgroundImage = Properties.Resources.FondoEpico;
            pGrid.Controls.Add(mapEditor);
            pGrid.Location = new Point(371, 23);
            pGrid.Name = "pGrid";
            pGrid.Size = new Size(1029, 396);
            pGrid.TabIndex = 19;
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
            // btnRefresh
            // 
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.ImageIndex = 3;
            btnRefresh.ImageList = imageList2;
            btnRefresh.Location = new Point(673, 436);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(44, 41);
            btnRefresh.TabIndex = 20;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // EditorMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1412, 505);
            Controls.Add(btnRefresh);
            Controls.Add(pGrid);
            Controls.Add(btnLoadMap);
            Controls.Add(btnSaveMap);
            Controls.Add(pvPreview);
            Controls.Add(btnDeleteImg);
            Controls.Add(listViewTiles);
            Controls.Add(btnNone);
            Controls.Add(btnErase);
            Controls.Add(btnDraw);
            Controls.Add(btnAddLayer);
            Controls.Add(cmbLayers);
            Controls.Add(CmbFilter);
            Controls.Add(btnAddImage);
            Controls.Add(cmbCategory);
            MaximizeBox = false;
            Name = "EditorMap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditorMap";
            FormClosing += EditorMap_FormClosing;
            Load += EditorMap_Load;
            ((System.ComponentModel.ISupportInitialize)pvPreview).EndInit();
            pGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CmbFilter;
        private Button btnAddImage;
        private ComboBox cmbCategory;
        private ImageList imageList1;
        private ComboBox cmbLayers;
        private Button btnAddLayer;
        private ImageList imageList2;
        private Button btnDraw;
        private Button btnErase;
        private ImageList ilCursores;
        private Button btnNone;
        private ListView listViewTiles;
        private ImageList ilTiles;
        private Button btnDeleteImg;
        private PictureBox pvPreview;
        private Button btnSaveMap;
        private Button btnLoadMap;
        private Panel pGrid;
        private Tools.MapEditor mapEditor;
        private Button btnRefresh;
    }
}