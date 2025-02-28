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
            lblVolumeValue = new Label();
            trackBarVolume = new ReaLTaiizor.Controls.DungeonTrackBar();
            imageList1 = new ImageList(components);
            btnPlay = new Button();
            dgvSounds = new DataGridView();
            txtSearch = new ReaLTaiizor.Controls.HopeTextBox();
            btnLoadSound = new Button();
            btnDelete = new Button();
            lblSound = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSounds).BeginInit();
            SuspendLayout();
            // 
            // lblVolumeValue
            // 
            lblVolumeValue.AutoSize = true;
            lblVolumeValue.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVolumeValue.ForeColor = SystemColors.AppWorkspace;
            lblVolumeValue.Location = new Point(160, 60);
            lblVolumeValue.Name = "lblVolumeValue";
            lblVolumeValue.Size = new Size(27, 19);
            lblVolumeValue.TabIndex = 15;
            lblVolumeValue.Text = "20";
            // 
            // trackBarVolume
            // 
            trackBarVolume.BorderColor = Color.FromArgb(200, 200, 200);
            trackBarVolume.DrawValueString = false;
            trackBarVolume.EmptyBackColor = Color.FromArgb(221, 221, 221);
            trackBarVolume.FillBackColor = Color.FromArgb(217, 99, 50);
            trackBarVolume.JumpToMouse = false;
            trackBarVolume.Location = new Point(12, 57);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Minimum = 0;
            trackBarVolume.MinimumSize = new Size(47, 22);
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(142, 22);
            trackBarVolume.TabIndex = 14;
            trackBarVolume.Text = "dungeonTrackBar1";
            trackBarVolume.ThumbBackColor = Color.FromArgb(244, 244, 244);
            trackBarVolume.ThumbBorderColor = Color.FromArgb(180, 180, 180);
            trackBarVolume.Value = 20;
            trackBarVolume.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By10;
            trackBarVolume.ValueToSet = 2F;
            trackBarVolume.ValueChanged += trackBarVolume_ValueChanged;
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
            // 
            // btnPlay
            // 
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = imageList1;
            btnPlay.Location = new Point(15, 12);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(39, 39);
            btnPlay.TabIndex = 12;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // dgvSounds
            // 
            dgvSounds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSounds.Location = new Point(12, 131);
            dgvSounds.MultiSelect = false;
            dgvSounds.Name = "dgvSounds";
            dgvSounds.ReadOnly = true;
            dgvSounds.Size = new Size(216, 350);
            dgvSounds.TabIndex = 16;
            dgvSounds.CellDoubleClick += dgvSounds_CellDoubleClick;
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
            txtSearch.Location = new Point(15, 90);
            txtSearch.MaxLength = 32767;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.ScrollBars = ScrollBars.None;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.Size = new Size(213, 38);
            txtSearch.TabIndex = 17;
            txtSearch.TabStop = false;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.TextChanged += hopeTextBox1_TextChanged;
            // 
            // btnLoadSound
            // 
            btnLoadSound.ImageIndex = 8;
            btnLoadSound.ImageList = imageList1;
            btnLoadSound.Location = new Point(15, 488);
            btnLoadSound.Name = "btnLoadSound";
            btnLoadSound.Size = new Size(39, 39);
            btnLoadSound.TabIndex = 18;
            btnLoadSound.UseVisualStyleBackColor = true;
            btnLoadSound.Click += btnLoadSound_Click;
            // 
            // btnDelete
            // 
            btnDelete.ImageIndex = 9;
            btnDelete.ImageList = imageList1;
            btnDelete.Location = new Point(189, 487);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(39, 39);
            btnDelete.TabIndex = 19;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSound
            // 
            lblSound.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSound.ForeColor = Color.White;
            lblSound.Location = new Point(60, 12);
            lblSound.Name = "lblSound";
            lblSound.Size = new Size(168, 39);
            lblSound.TabIndex = 20;
            lblSound.Text = "No hay sonido cargado";
            // 
            // SoundControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(240, 539);
            Controls.Add(lblSound);
            Controls.Add(btnDelete);
            Controls.Add(btnLoadSound);
            Controls.Add(txtSearch);
            Controls.Add(dgvSounds);
            Controls.Add(lblVolumeValue);
            Controls.Add(trackBarVolume);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SoundControl";
            Text = "SoundControl";
            ((System.ComponentModel.ISupportInitialize)dgvSounds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVolumeValue;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarVolume;
        private ImageList imageList1;
        private Button btnPlay;
        private DataGridView dgvSounds;
        private ReaLTaiizor.Controls.HopeTextBox txtSearch;
        private Button btnLoadSound;
        private Button btnDelete;
        private Label lblSound;
    }
}