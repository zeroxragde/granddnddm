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
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
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
            // EditorMap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1412, 505);
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
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CmbFilter;
        private DataGridView dgvImages;
        private Button btnAddImage;
        private ComboBox cmbCategory;
        private ImageList imageList1;
    }
}