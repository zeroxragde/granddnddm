namespace GranDnDDM.Views
{
    partial class MusicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicControl));
            btnPlay = new Button();
            imageList1 = new ImageList(components);
            btnPrevSong = new Button();
            btnNextSong = new Button();
            btnStop = new Button();
            btnMute = new Button();
            lblMusic = new Label();
            btnOpenList = new Button();
            trackBarVolume = new ReaLTaiizor.Controls.DungeonTrackBar();
            lblVolumeValue = new Label();
            lblFulltime = new Label();
            lblRestante = new Label();
            trackBarProgreso = new ReaLTaiizor.Controls.TrackBar();
            btnOpenSounds = new Button();
            btnLoopToggle = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = imageList1;
            btnPlay.Location = new Point(57, 12);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(39, 39);
            btnPlay.TabIndex = 0;
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
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
            imageList1.Images.SetKeyName(8, "loopOff.png");
            imageList1.Images.SetKeyName(9, "loopOn.png");
            imageList1.Images.SetKeyName(10, "soundIcon.png");
            // 
            // btnPrevSong
            // 
            btnPrevSong.ImageIndex = 4;
            btnPrevSong.ImageList = imageList1;
            btnPrevSong.Location = new Point(12, 12);
            btnPrevSong.Name = "btnPrevSong";
            btnPrevSong.Size = new Size(39, 39);
            btnPrevSong.TabIndex = 1;
            btnPrevSong.UseVisualStyleBackColor = true;
            btnPrevSong.Click += btnPrevSong_Click;
            // 
            // btnNextSong
            // 
            btnNextSong.ImageIndex = 2;
            btnNextSong.ImageList = imageList1;
            btnNextSong.Location = new Point(102, 12);
            btnNextSong.Name = "btnNextSong";
            btnNextSong.Size = new Size(39, 39);
            btnNextSong.TabIndex = 2;
            btnNextSong.UseVisualStyleBackColor = true;
            btnNextSong.Click += btnNextSong_Click;
            // 
            // btnStop
            // 
            btnStop.ImageIndex = 5;
            btnStop.ImageList = imageList1;
            btnStop.Location = new Point(147, 12);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(39, 39);
            btnStop.TabIndex = 3;
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnMute
            // 
            btnMute.ImageIndex = 6;
            btnMute.ImageList = imageList1;
            btnMute.Location = new Point(204, 10);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(39, 39);
            btnMute.TabIndex = 4;
            btnMute.UseVisualStyleBackColor = true;
            btnMute.Click += btnMute_Click;
            // 
            // lblMusic
            // 
            lblMusic.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMusic.ForeColor = Color.Cornsilk;
            lblMusic.Location = new Point(12, 58);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(298, 23);
            lblMusic.TabIndex = 5;
            lblMusic.Text = "Nombre Cancion";
            // 
            // btnOpenList
            // 
            btnOpenList.ImageIndex = 7;
            btnOpenList.ImageList = imageList1;
            btnOpenList.Location = new Point(437, 10);
            btnOpenList.Name = "btnOpenList";
            btnOpenList.Size = new Size(39, 39);
            btnOpenList.TabIndex = 7;
            btnOpenList.UseVisualStyleBackColor = true;
            btnOpenList.Click += btnOpenList_Click;
            // 
            // trackBarVolume
            // 
            trackBarVolume.BorderColor = Color.FromArgb(200, 200, 200);
            trackBarVolume.DrawValueString = false;
            trackBarVolume.EmptyBackColor = Color.FromArgb(221, 221, 221);
            trackBarVolume.FillBackColor = Color.FromArgb(217, 99, 50);
            trackBarVolume.JumpToMouse = false;
            trackBarVolume.Location = new Point(248, 19);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Minimum = 0;
            trackBarVolume.MinimumSize = new Size(47, 22);
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(142, 22);
            trackBarVolume.TabIndex = 10;
            trackBarVolume.Text = "dungeonTrackBar1";
            trackBarVolume.ThumbBackColor = Color.FromArgb(244, 244, 244);
            trackBarVolume.ThumbBorderColor = Color.FromArgb(180, 180, 180);
            trackBarVolume.Value = 0;
            trackBarVolume.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By10;
            trackBarVolume.ValueToSet = 0F;
            trackBarVolume.ValueChanged += trackBarVolume_ValueChanged;
            // 
            // lblVolumeValue
            // 
            lblVolumeValue.AutoSize = true;
            lblVolumeValue.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVolumeValue.ForeColor = SystemColors.AppWorkspace;
            lblVolumeValue.Location = new Point(396, 21);
            lblVolumeValue.Name = "lblVolumeValue";
            lblVolumeValue.Size = new Size(27, 19);
            lblVolumeValue.TabIndex = 11;
            lblVolumeValue.Text = "80";
            // 
            // lblFulltime
            // 
            lblFulltime.AutoSize = true;
            lblFulltime.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFulltime.ForeColor = SystemColors.AppWorkspace;
            lblFulltime.Location = new Point(458, 85);
            lblFulltime.Name = "lblFulltime";
            lblFulltime.Size = new Size(54, 19);
            lblFulltime.TabIndex = 13;
            lblFulltime.Text = "00:00";
            // 
            // lblRestante
            // 
            lblRestante.AutoSize = true;
            lblRestante.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRestante.ForeColor = SystemColors.AppWorkspace;
            lblRestante.Location = new Point(9, 85);
            lblRestante.Name = "lblRestante";
            lblRestante.Size = new Size(54, 19);
            lblRestante.TabIndex = 14;
            lblRestante.Text = "00:00";
            // 
            // trackBarProgreso
            // 
            trackBarProgreso.JumpToMouse = false;
            trackBarProgreso.Location = new Point(68, 85);
            trackBarProgreso.Maximum = 10;
            trackBarProgreso.Minimum = 0;
            trackBarProgreso.MinimumSize = new Size(47, 22);
            trackBarProgreso.Name = "trackBarProgreso";
            trackBarProgreso.Size = new Size(384, 22);
            trackBarProgreso.TabIndex = 15;
            trackBarProgreso.Text = "trackBar1";
            trackBarProgreso.Value = 0;
            trackBarProgreso.ValueDivison = ReaLTaiizor.Controls.TrackBar.ValueDivisor.By1;
            trackBarProgreso.ValueToSet = 0F;
            trackBarProgreso.ValueChanged += trackBarProgreso_ValueChanged;
            trackBarProgreso.MouseDown += trackBarProgreso_MouseDown;
            trackBarProgreso.MouseUp += trackBarProgreso_MouseUp;
            // 
            // btnOpenSounds
            // 
            btnOpenSounds.ImageIndex = 10;
            btnOpenSounds.ImageList = imageList1;
            btnOpenSounds.Location = new Point(485, 10);
            btnOpenSounds.Name = "btnOpenSounds";
            btnOpenSounds.Size = new Size(39, 39);
            btnOpenSounds.TabIndex = 16;
            btnOpenSounds.UseVisualStyleBackColor = true;
            btnOpenSounds.Click += btnOpenSounds_Click;
            // 
            // btnLoopToggle
            // 
            btnLoopToggle.ImageIndex = 8;
            btnLoopToggle.ImageList = imageList1;
            btnLoopToggle.Location = new Point(517, 72);
            btnLoopToggle.Name = "btnLoopToggle";
            btnLoopToggle.Size = new Size(39, 39);
            btnLoopToggle.TabIndex = 17;
            btnLoopToggle.UseVisualStyleBackColor = true;
            btnLoopToggle.Click += btnLoopToggle_Click;
            // 
            // MusicControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(562, 115);
            Controls.Add(btnLoopToggle);
            Controls.Add(btnOpenSounds);
            Controls.Add(trackBarProgreso);
            Controls.Add(lblRestante);
            Controls.Add(lblFulltime);
            Controls.Add(lblVolumeValue);
            Controls.Add(trackBarVolume);
            Controls.Add(btnOpenList);
            Controls.Add(lblMusic);
            Controls.Add(btnMute);
            Controls.Add(btnStop);
            Controls.Add(btnNextSong);
            Controls.Add(btnPrevSong);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MusicControl";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicControl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private ImageList imageList1;
        private Button btnPrevSong;
        private Button btnNextSong;
        private Button btnStop;
        private Button btnMute;
        private Label lblMusic;
        private Button btnOpenList;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarVolume;
        private Label lblVolumeValue;
        private Label lblFulltime;
        private Label lblRestante;
        private ReaLTaiizor.Controls.TrackBar trackBarProgreso;
        private Button btnOpenSounds;
        private Button btnLoopToggle;
    }
}