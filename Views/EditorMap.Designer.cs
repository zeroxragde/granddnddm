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
            dgvImages = new DataGridView();
            btnAddImage = new Button();
            imageList1 = new ImageList(components);
            cmbCategory = new ComboBox();
            gbMap = new GroupBox();
            mapEditor = new Tools.MapEditor();
            cmbLayers = new ComboBox();
            btnAddLayer = new Button();
            imageList2 = new ImageList(components);
            btnDraw = new Button();
            btnErase = new Button();
            ilCursores = new ImageList(components);
            btnNone = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
            gbMap.SuspendLayout();
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
            // dgvImages
            // 
            dgvImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImages.GridColor = Color.Green;
            dgvImages.Location = new Point(13, 122);
            dgvImages.Name = "dgvImages";
            dgvImages.Size = new Size(346, 335);
            dgvImages.TabIndex = 6;
            dgvImages.CellContentClick += dgvImages_CellContentClick;
            dgvImages.Click += dgvImages_CellClick;
            dgvImages.MouseDown += dgvImages_MouseDown_1;
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
            // gbMap
            // 
            gbMap.Controls.Add(mapEditor);
            gbMap.Location = new Point(365, 12);
            gbMap.Name = "gbMap";
            gbMap.Size = new Size(1035, 407);
            gbMap.TabIndex = 8;
            gbMap.TabStop = false;
            // 
            // mapEditor
            // 
            mapEditor.ActiveLayerIndex = 0;
            mapEditor.AllowDrop = true;
            mapEditor.Columns = 32;
            mapEditor.CurrentToolMode = Enums.ToolMode.None;
            mapEditor.DrawingImage = null;
            mapEditor.Location = new Point(6, 16);
            mapEditor.Name = "mapEditor";
            mapEditor.Rows = 15;
            mapEditor.Size = new Size(1023, 385);
            mapEditor.TabIndex = 0;
            mapEditor.TileSize = 32;
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
            // EditorMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1412, 505);
            Controls.Add(btnNone);
            Controls.Add(btnErase);
            Controls.Add(btnDraw);
            Controls.Add(btnAddLayer);
            Controls.Add(cmbLayers);
            Controls.Add(gbMap);
            Controls.Add(CmbFilter);
            Controls.Add(dgvImages);
            Controls.Add(btnAddImage);
            Controls.Add(cmbCategory);
            MaximizeBox = false;
            Name = "EditorMap";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditorMap";
            Load += EditorMap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImages).EndInit();
            gbMap.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CmbFilter;
        private DataGridView dgvImages;
        private Button btnAddImage;
        private ComboBox cmbCategory;
        private ImageList imageList1;
        private GroupBox gbMap;
        private Tools.MapEditor mapEditor;
        private ComboBox cmbLayers;
        private Button btnAddLayer;
        private ImageList imageList2;
        private Button btnDraw;
        private Button btnErase;
        private ImageList ilCursores;
        private Button btnNone;
    }
}