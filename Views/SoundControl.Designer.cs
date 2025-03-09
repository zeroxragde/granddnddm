namespace GranDnDDM.Views
{
    partial class SoundControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundControl));
            imageList1 = new ImageList(components);
            foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            trackBarVolume = new ReaLTaiizor.Controls.TrackBar();
            lblVolumeValue = new Label();
            lblSound = new Label();
            btnDelete = new Button();
            btnLoadSound = new Button();
            txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            dgvSounds = new DataGridView();
            btnPlay = new Button();
            foreverForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSounds).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "btnPlay.png");
            imageList1.Images.SetKeyName(1, "btnMute.png");
            imageList1.Images.SetKeyName(2, "btnNext.png");
            imageList1.Images.SetKeyName(3, "btnPause.png");
            imageList1.Images.SetKeyName(4, "btnPrev.png");
            imageList1.Images.SetKeyName(5, "btnStop.png");
            imageList1.Images.SetKeyName(6, "btnVolumen.png");
            imageList1.Images.SetKeyName(7, "btnList.png");
            imageList1.Images.SetKeyName(8, "addMusic.png");
            imageList1.Images.SetKeyName(9, "trash.png");
            imageList1.Images.SetKeyName(10, "mitrash.png");
            // 
            // foreverForm1
            // 
            foreverForm1.BackColor = Color.White;
            foreverForm1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverForm1.BorderColor = Color.DodgerBlue;
            foreverForm1.Controls.Add(btnClose);
            foreverForm1.Controls.Add(trackBarVolume);
            foreverForm1.Controls.Add(lblVolumeValue);
            foreverForm1.Controls.Add(lblSound);
            foreverForm1.Controls.Add(btnDelete);
            foreverForm1.Controls.Add(btnLoadSound);
            foreverForm1.Controls.Add(txtSearch);
            foreverForm1.Controls.Add(dgvSounds);
            foreverForm1.Controls.Add(btnPlay);
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
            foreverForm1.Size = new Size(240, 593);
            foreverForm1.TabIndex = 0;
            foreverForm1.Text = "Control de Sonidos";
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
            btnClose.Location = new Point(201, 12);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 30;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // trackBarVolume
            // 
            trackBarVolume.BackColor = Color.FromArgb(64, 64, 64);
            trackBarVolume.JumpToMouse = true;
            trackBarVolume.Location = new Point(13, 113);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Minimum = 1;
            trackBarVolume.MinimumSize = new Size(47, 22);
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(121, 22);
            trackBarVolume.TabIndex = 29;
            trackBarVolume.Value = 1;
            trackBarVolume.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By10;
            trackBarVolume.ValueToSet = 0F;
            trackBarVolume.ValueChanged += trackBarVolume_ValueChanged;
            // 
            // lblVolumeValue
            // 
            lblVolumeValue.AutoSize = true;
            lblVolumeValue.BackColor = Color.Transparent;
            lblVolumeValue.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVolumeValue.ForeColor = Color.White;
            lblVolumeValue.Location = new Point(140, 115);
            lblVolumeValue.Name = "lblVolumeValue";
            lblVolumeValue.Size = new Size(27, 19);
            lblVolumeValue.TabIndex = 23;
            lblVolumeValue.Text = "20";
            // 
            // lblSound
            // 
            lblSound.BackColor = Color.Transparent;
            lblSound.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSound.ForeColor = Color.White;
            lblSound.Location = new Point(56, 65);
            lblSound.Name = "lblSound";
            lblSound.Size = new Size(168, 39);
            lblSound.TabIndex = 28;
            lblSound.Text = "No hay sonido cargado";
            // 
            // btnDelete
            // 
            btnDelete.ImageIndex = 10;
            btnDelete.ImageList = imageList1;
            btnDelete.Location = new Point(185, 540);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(39, 39);
            btnDelete.TabIndex = 27;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadSound
            // 
            btnLoadSound.ImageIndex = 8;
            btnLoadSound.ImageList = imageList1;
            btnLoadSound.Location = new Point(11, 541);
            btnLoadSound.Name = "btnLoadSound";
            btnLoadSound.Size = new Size(39, 39);
            btnLoadSound.TabIndex = 26;
            btnLoadSound.UseVisualStyleBackColor = true;
            btnLoadSound.Click += btnLoadSound_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BaseColor = Color.FromArgb(44, 55, 66);
            txtSearch.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSearch.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(48, 49, 51);
            txtSearch.Hint = "Buscar...";
            txtSearch.Location = new Point(11, 143);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.Size = new Size(213, 38);
            txtSearch.TabIndex = 25;
            txtSearch.TabStop = false;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.TextChanged += hopeTextBox1_TextChanged;
            // 
            // dgvSounds
            // 
            dgvSounds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSounds.Location = new Point(8, 184);
            dgvSounds.MultiSelect = false;
            dgvSounds.Name = "dgvSounds";
            dgvSounds.ReadOnly = true;
            dgvSounds.Size = new Size(216, 350);
            dgvSounds.TabIndex = 24;
            dgvSounds.CellDoubleClick += dgvSounds_CellDoubleClick;
            // 
            // btnPlay
            // 
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = imageList1;
            btnPlay.Location = new Point(11, 65);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(39, 39);
            btnPlay.TabIndex = 21;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // SoundControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(240, 593);
            Controls.Add(foreverForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SoundControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SoundControl";
            TransparencyKey = Color.Fuchsia;
            foreverForm1.ResumeLayout(false);
            foreverForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSounds).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private Label lblSound;
        private Button btnDelete;
        private Button btnLoadSound;
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private DataGridView dgvSounds;
        private Label lblVolumeValue;
        private Button btnPlay;
        private ReaLTaiizor.Controls.TrackBar trackBarVolume;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}