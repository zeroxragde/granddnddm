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
            btnReload = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnImportCrea = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnEditar = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnDelete = new ReaLTaiizor.Controls.ParrotPictureBox();
            listCreature = new DataGridView();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            btnNueva = new ReaLTaiizor.Controls.DreamButton();
            imageList1 = new ImageList(components);
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
            dreamForm1.Controls.Add(btnReload);
            dreamForm1.Controls.Add(btnImportCrea);
            dreamForm1.Controls.Add(btnEditar);
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
            dreamForm1.Text = "Lista de Creaturas";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Transparent;
            btnReload.BackgroundImage = Properties.Resources.reload;
            btnReload.BackgroundImageLayout = ImageLayout.Stretch;
            btnReload.ColorLeft = Color.DodgerBlue;
            btnReload.ColorRight = Color.DodgerBlue;
            btnReload.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnReload.FilterAlpha = 200;
            btnReload.FilterEnabled = true;
            btnReload.Image = null;
            btnReload.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnReload.IsElipse = false;
            btnReload.IsParallax = false;
            btnReload.Location = new Point(337, 205);
            btnReload.Name = "btnReload";
            btnReload.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnReload.Size = new Size(39, 38);
            btnReload.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnReload.TabIndex = 19;
            btnReload.Text = "btnClose";
            btnReload.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnReload.Click += btnReload_Click;
            // 
            // btnImportCrea
            // 
            btnImportCrea.BackColor = Color.Transparent;
            btnImportCrea.BackgroundImage = Properties.Resources.import;
            btnImportCrea.BackgroundImageLayout = ImageLayout.Stretch;
            btnImportCrea.ColorLeft = Color.DodgerBlue;
            btnImportCrea.ColorRight = Color.DodgerBlue;
            btnImportCrea.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnImportCrea.FilterAlpha = 200;
            btnImportCrea.FilterEnabled = true;
            btnImportCrea.Image = null;
            btnImportCrea.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnImportCrea.IsElipse = false;
            btnImportCrea.IsParallax = false;
            btnImportCrea.Location = new Point(340, 152);
            btnImportCrea.Name = "btnImportCrea";
            btnImportCrea.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnImportCrea.Size = new Size(33, 38);
            btnImportCrea.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnImportCrea.TabIndex = 18;
            btnImportCrea.Text = "btnClose";
            btnImportCrea.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnImportCrea.Click += btnImportCrea_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Transparent;
            btnEditar.BackgroundImage = Properties.Resources.pencil1;
            btnEditar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEditar.ColorLeft = Color.DodgerBlue;
            btnEditar.ColorRight = Color.DodgerBlue;
            btnEditar.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnEditar.FilterAlpha = 200;
            btnEditar.FilterEnabled = true;
            btnEditar.Image = null;
            btnEditar.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnEditar.IsElipse = false;
            btnEditar.IsParallax = false;
            btnEditar.Location = new Point(337, 98);
            btnEditar.Name = "btnEditar";
            btnEditar.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnEditar.Size = new Size(39, 38);
            btnEditar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnEditar.TabIndex = 17;
            btnEditar.Text = "btnClose";
            btnEditar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEditar.Click += btnEditar_Click;
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
            // listCreature
            // 
            listCreature.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listCreature.EditMode = DataGridViewEditMode.EditProgrammatically;
            listCreature.Location = new Point(21, 45);
            listCreature.MultiSelect = false;
            listCreature.Name = "listCreature";
            listCreature.ReadOnly = true;
            listCreature.ScrollBars = ScrollBars.Vertical;
            listCreature.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listCreature.ShowCellErrors = false;
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
            // CreatureList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 603);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private ReaLTaiizor.Controls.ParrotPictureBox btnEditar;
        private ReaLTaiizor.Controls.ParrotPictureBox btnImportCrea;
        private ReaLTaiizor.Controls.ParrotPictureBox btnReload;
    }
}