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
            cbCatFilter = new ComboBox();
            dvgMusica = new DataGridView();
            txtNewCategory = new TextBox();
            btnAddCategory = new Button();
            btnDeleteCats = new Button();
            imageList1 = new ImageList(components);
            btnAddMusic = new Button();
            imageList2 = new ImageList(components);
            cbCatSelect = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnDeletesong = new Button();
            btnAddToCola = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgMusica).BeginInit();
            SuspendLayout();
            // 
            // cbCatFilter
            // 
            cbCatFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatFilter.FormattingEnabled = true;
            cbCatFilter.Location = new Point(10, 18);
            cbCatFilter.Name = "cbCatFilter";
            cbCatFilter.Size = new Size(211, 23);
            cbCatFilter.TabIndex = 0;
            // 
            // dvgMusica
            // 
            dvgMusica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgMusica.Location = new Point(10, 51);
            dvgMusica.MultiSelect = false;
            dvgMusica.Name = "dvgMusica";
            dvgMusica.ReadOnly = true;
            dvgMusica.Size = new Size(330, 350);
            dvgMusica.TabIndex = 1;
            dvgMusica.CellDoubleClick += dvgMusica_CellDoubleClick;
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(10, 429);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(211, 23);
            txtNewCategory.TabIndex = 2;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.Location = new Point(227, 429);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(27, 23);
            btnAddCategory.TabIndex = 3;
            btnAddCategory.Text = "+";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnDeleteCats
            // 
            btnDeleteCats.ImageIndex = 0;
            btnDeleteCats.ImageList = imageList1;
            btnDeleteCats.Location = new Point(227, 14);
            btnDeleteCats.Name = "btnDeleteCats";
            btnDeleteCats.Size = new Size(47, 31);
            btnDeleteCats.TabIndex = 4;
            btnDeleteCats.UseVisualStyleBackColor = true;
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
            // 
            // btnAddMusic
            // 
            btnAddMusic.ImageIndex = 0;
            btnAddMusic.ImageList = imageList2;
            btnAddMusic.Location = new Point(10, 467);
            btnAddMusic.Name = "btnAddMusic";
            btnAddMusic.Size = new Size(64, 59);
            btnAddMusic.TabIndex = 5;
            btnAddMusic.UseVisualStyleBackColor = true;
            btnAddMusic.Click += btnAddMusic_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "addMusic.png");
            // 
            // cbCatSelect
            // 
            cbCatSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCatSelect.FormattingEnabled = true;
            cbCatSelect.Location = new Point(80, 503);
            cbCatSelect.Name = "cbCatSelect";
            cbCatSelect.Size = new Size(199, 23);
            cbCatSelect.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 404);
            label1.Name = "label1";
            label1.Size = new Size(130, 22);
            label1.TabIndex = 7;
            label1.Text = "Agregar Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 478);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 8;
            label2.Text = "Categoria";
            // 
            // btnDeletesong
            // 
            btnDeletesong.ImageIndex = 1;
            btnDeletesong.ImageList = imageList1;
            btnDeletesong.Location = new Point(346, 51);
            btnDeletesong.Name = "btnDeletesong";
            btnDeletesong.Size = new Size(41, 45);
            btnDeletesong.TabIndex = 9;
            btnDeletesong.UseVisualStyleBackColor = true;
            btnDeletesong.Click += btnDeletesong_Click;
            // 
            // btnAddToCola
            // 
            btnAddToCola.ImageIndex = 3;
            btnAddToCola.ImageList = imageList1;
            btnAddToCola.Location = new Point(344, 102);
            btnAddToCola.Name = "btnAddToCola";
            btnAddToCola.Size = new Size(41, 45);
            btnAddToCola.TabIndex = 10;
            btnAddToCola.UseVisualStyleBackColor = true;
            btnAddToCola.Click += btnAddToCola_Click;
            // 
            // ListSongs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            BackgroundImage = Properties.Resources.fondo1;
            ClientSize = new Size(397, 538);
            Controls.Add(btnAddToCola);
            Controls.Add(label2);
            Controls.Add(cbCatSelect);
            Controls.Add(btnDeletesong);
            Controls.Add(btnAddMusic);
            Controls.Add(label1);
            Controls.Add(btnDeleteCats);
            Controls.Add(btnAddCategory);
            Controls.Add(txtNewCategory);
            Controls.Add(dvgMusica);
            Controls.Add(cbCatFilter);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ListSongs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListSongs";
            Load += ListSongs_Load;
            ((System.ComponentModel.ISupportInitialize)dvgMusica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCatFilter;
        private DataGridView dvgMusica;
        private TextBox txtNewCategory;
        private Button btnAddCategory;
        private Button btnDeleteCats;
        private Button btnAddMusic;
        private ComboBox cbCatSelect;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private Button btnDeletesong;
        private ImageList imageList2;
        private Button btnAddToCola;
    }
}