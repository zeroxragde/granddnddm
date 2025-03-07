namespace GranDnDDM.Views
{
    partial class CreatureList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatureList));
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            listCreature = new DataGridView();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            btnNueva = new ReaLTaiizor.Controls.DreamButton();
            imageList1 = new ImageList(components);
            btnDelete = new ReaLTaiizor.Controls.ParrotPictureBox();
            dreamForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listCreature).BeginInit();
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
            dreamForm1.Controls.Add(btnDelete);
            dreamForm1.Controls.Add(listCreature);
            dreamForm1.Controls.Add(dreamButton1);
            dreamForm1.Controls.Add(btnNueva);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(385, 603);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Lista de Creturas";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // listCreature
            // 
            listCreature.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listCreature.Location = new Point(21, 45);
            listCreature.Name = "listCreature";
            listCreature.Size = new Size(310, 496);
            listCreature.TabIndex = 3;
            listCreature.CellMouseDoubleClick += listCreature_CellMouseDoubleClick;
            // 
            // dreamButton1
            // 
            dreamButton1.ColorA = Color.FromArgb(31, 31, 31);
            dreamButton1.ColorB = Color.FromArgb(41, 41, 41);
            dreamButton1.ColorC = Color.FromArgb(51, 51, 51);
            dreamButton1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamButton1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamButton1.ForeColor = Color.Red;
            dreamButton1.Location = new Point(233, 547);
            dreamButton1.Name = "dreamButton1";
            dreamButton1.Size = new Size(120, 40);
            dreamButton1.TabIndex = 2;
            dreamButton1.Text = "Salir";
            dreamButton1.UseVisualStyleBackColor = true;
            dreamButton1.Click += dreamButton1_Click;
            // 
            // btnNueva
            // 
            btnNueva.ColorA = Color.FromArgb(31, 31, 31);
            btnNueva.ColorB = Color.FromArgb(41, 41, 41);
            btnNueva.ColorC = Color.FromArgb(51, 51, 51);
            btnNueva.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnNueva.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnNueva.ForeColor = Color.FromArgb(40, 218, 255);
            btnNueva.Location = new Point(21, 547);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(127, 40);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva Creatura";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "closewin.png");
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = Properties.Resources.deleteImg;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.ColorLeft = Color.DodgerBlue;
            btnDelete.ColorRight = Color.DodgerBlue;
            btnDelete.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnDelete.FilterAlpha = 200;
            btnDelete.FilterEnabled = true;
            btnDelete.Image = null;
            btnDelete.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnDelete.IsElipse = false;
            btnDelete.IsParallax = false;
            btnDelete.Location = new Point(334, 45);
            btnDelete.Name = "btnDelete";
            btnDelete.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnDelete.Size = new Size(48, 47);
            btnDelete.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnDelete.TabIndex = 16;
            btnDelete.Text = "btnClose";
            btnDelete.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDelete.Click += btnDelete_Click;
            // 
            // CreatureList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 603);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatureList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatureList";
            Load += CreatureList_Load;
            dreamForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listCreature).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private ReaLTaiizor.Controls.DreamButton btnNueva;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private DataGridView listCreature;
        private ReaLTaiizor.Controls.ParrotPictureBox btnDelete;
    }
}