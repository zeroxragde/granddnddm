namespace GranDnDDM.Views
{
    partial class ModVoice
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
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnStart = new ReaLTaiizor.Controls.AirButton();
            ptbPitch = new ReaLTaiizor.Controls.PoisonTrackBar();
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            lblGainValue = new ReaLTaiizor.Controls.BigLabel();
            trackBarGain = new ReaLTaiizor.Controls.PoisonTrackBar();
            lblLowModFreq = new ReaLTaiizor.Controls.BigLabel();
            lblLowModDepth = new ReaLTaiizor.Controls.BigLabel();
            lblTimbreShift = new ReaLTaiizor.Controls.BigLabel();
            lblTimbreStrength = new ReaLTaiizor.Controls.BigLabel();
            trackBarTimbreStrength = new ReaLTaiizor.Controls.PoisonTrackBar();
            trackBarTimbreShift = new ReaLTaiizor.Controls.PoisonTrackBar();
            tbLowModDepth = new ReaLTaiizor.Controls.PoisonTrackBar();
            tbLowModFreq = new ReaLTaiizor.Controls.PoisonTrackBar();
            lblPitchValue = new ReaLTaiizor.Controls.BigLabel();
            dreamForm1.SuspendLayout();
            SuspendLayout();
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
            btnClose.Location = new Point(213, 0);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // btnStart
            // 
            btnStart.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnStart.Font = new Font("Segoe UI", 9F);
            btnStart.Image = null;
            btnStart.Location = new Point(12, 65);
            btnStart.Name = "btnStart";
            btnStart.NoRounding = false;
            btnStart.Size = new Size(222, 45);
            btnStart.TabIndex = 17;
            btnStart.Text = "Iniciar";
            btnStart.Transparent = false;
            btnStart.Click += btnStart_Click;
            // 
            // ptbPitch
            // 
            ptbPitch.BackColor = Color.Transparent;
            ptbPitch.Location = new Point(15, 159);
            ptbPitch.Name = "ptbPitch";
            ptbPitch.Size = new Size(164, 28);
            ptbPitch.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            ptbPitch.TabIndex = 24;
            ptbPitch.Text = "poisonTrackBar1";
            ptbPitch.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            ptbPitch.UseCustomBackColor = true;
            ptbPitch.Value = 0;
            ptbPitch.Scroll += ptbPitch_Scroll;
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(lblGainValue);
            dreamForm1.Controls.Add(trackBarGain);
            dreamForm1.Controls.Add(lblLowModFreq);
            dreamForm1.Controls.Add(lblLowModDepth);
            dreamForm1.Controls.Add(lblTimbreShift);
            dreamForm1.Controls.Add(lblTimbreStrength);
            dreamForm1.Controls.Add(trackBarTimbreStrength);
            dreamForm1.Controls.Add(trackBarTimbreShift);
            dreamForm1.Controls.Add(tbLowModDepth);
            dreamForm1.Controls.Add(tbLowModFreq);
            dreamForm1.Controls.Add(lblPitchValue);
            dreamForm1.Controls.Add(ptbPitch);
            dreamForm1.Controls.Add(btnStart);
            dreamForm1.Controls.Add(btnClose);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(300, 572);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Modificador de VOZ";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // lblGainValue
            // 
            lblGainValue.AutoSize = true;
            lblGainValue.BackColor = Color.Transparent;
            lblGainValue.Font = new Font("Segoe UI", 25F);
            lblGainValue.ForeColor = Color.White;
            lblGainValue.Location = new Point(213, 509);
            lblGainValue.Name = "lblGainValue";
            lblGainValue.Size = new Size(38, 46);
            lblGainValue.TabIndex = 35;
            lblGainValue.Text = "0";
            // 
            // trackBarGain
            // 
            trackBarGain.BackColor = Color.Transparent;
            trackBarGain.Location = new Point(17, 509);
            trackBarGain.Name = "trackBarGain";
            trackBarGain.Size = new Size(164, 28);
            trackBarGain.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            trackBarGain.TabIndex = 34;
            trackBarGain.Text = "poisonTrackBar1";
            trackBarGain.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            trackBarGain.UseCustomBackColor = true;
            trackBarGain.Value = 0;
            trackBarGain.Scroll += trackBarGain_Scroll;
            // 
            // lblLowModFreq
            // 
            lblLowModFreq.AutoSize = true;
            lblLowModFreq.BackColor = Color.Transparent;
            lblLowModFreq.Font = new Font("Segoe UI", 25F);
            lblLowModFreq.ForeColor = Color.White;
            lblLowModFreq.Location = new Point(198, 272);
            lblLowModFreq.Name = "lblLowModFreq";
            lblLowModFreq.Size = new Size(38, 46);
            lblLowModFreq.TabIndex = 33;
            lblLowModFreq.Text = "0";
            // 
            // lblLowModDepth
            // 
            lblLowModDepth.AutoSize = true;
            lblLowModDepth.BackColor = Color.Transparent;
            lblLowModDepth.Font = new Font("Segoe UI", 25F);
            lblLowModDepth.ForeColor = Color.White;
            lblLowModDepth.Location = new Point(198, 226);
            lblLowModDepth.Name = "lblLowModDepth";
            lblLowModDepth.Size = new Size(38, 46);
            lblLowModDepth.TabIndex = 32;
            lblLowModDepth.Text = "0";
            // 
            // lblTimbreShift
            // 
            lblTimbreShift.AutoSize = true;
            lblTimbreShift.BackColor = Color.Transparent;
            lblTimbreShift.Font = new Font("Segoe UI", 25F);
            lblTimbreShift.ForeColor = Color.White;
            lblTimbreShift.Location = new Point(198, 365);
            lblTimbreShift.Name = "lblTimbreShift";
            lblTimbreShift.Size = new Size(38, 46);
            lblTimbreShift.TabIndex = 31;
            lblTimbreShift.Text = "0";
            // 
            // lblTimbreStrength
            // 
            lblTimbreStrength.AutoSize = true;
            lblTimbreStrength.BackColor = Color.Transparent;
            lblTimbreStrength.Font = new Font("Segoe UI", 25F);
            lblTimbreStrength.ForeColor = Color.White;
            lblTimbreStrength.Location = new Point(200, 440);
            lblTimbreStrength.Name = "lblTimbreStrength";
            lblTimbreStrength.Size = new Size(38, 46);
            lblTimbreStrength.TabIndex = 30;
            lblTimbreStrength.Text = "0";
            // 
            // trackBarTimbreStrength
            // 
            trackBarTimbreStrength.BackColor = Color.Transparent;
            trackBarTimbreStrength.Location = new Point(17, 452);
            trackBarTimbreStrength.Name = "trackBarTimbreStrength";
            trackBarTimbreStrength.Size = new Size(164, 28);
            trackBarTimbreStrength.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            trackBarTimbreStrength.TabIndex = 29;
            trackBarTimbreStrength.Text = "poisonTrackBar1";
            trackBarTimbreStrength.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            trackBarTimbreStrength.UseCustomBackColor = true;
            trackBarTimbreStrength.Value = 0;
            trackBarTimbreStrength.Scroll += trackBarTimbreStrength_Scroll;
            // 
            // trackBarTimbreShift
            // 
            trackBarTimbreShift.BackColor = Color.Transparent;
            trackBarTimbreShift.Location = new Point(15, 383);
            trackBarTimbreShift.Name = "trackBarTimbreShift";
            trackBarTimbreShift.Size = new Size(164, 28);
            trackBarTimbreShift.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            trackBarTimbreShift.TabIndex = 28;
            trackBarTimbreShift.Text = "poisonTrackBar1";
            trackBarTimbreShift.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            trackBarTimbreShift.UseCustomBackColor = true;
            trackBarTimbreShift.Value = 0;
            trackBarTimbreShift.Scroll += trackBarTimbreShift_Scroll;
            // 
            // tbLowModDepth
            // 
            tbLowModDepth.BackColor = Color.Transparent;
            tbLowModDepth.Location = new Point(15, 290);
            tbLowModDepth.Name = "tbLowModDepth";
            tbLowModDepth.Size = new Size(164, 28);
            tbLowModDepth.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            tbLowModDepth.TabIndex = 27;
            tbLowModDepth.Text = "poisonTrackBar1";
            tbLowModDepth.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            tbLowModDepth.UseCustomBackColor = true;
            tbLowModDepth.Value = 0;
            tbLowModDepth.Scroll += tbLowModDepth_Scroll;
            // 
            // tbLowModFreq
            // 
            tbLowModFreq.BackColor = Color.Transparent;
            tbLowModFreq.Location = new Point(17, 227);
            tbLowModFreq.Name = "tbLowModFreq";
            tbLowModFreq.Size = new Size(164, 28);
            tbLowModFreq.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            tbLowModFreq.TabIndex = 26;
            tbLowModFreq.Text = "poisonTrackBar1";
            tbLowModFreq.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            tbLowModFreq.UseCustomBackColor = true;
            tbLowModFreq.Value = 0;
            tbLowModFreq.Scroll += tbLowModFreq_Scroll;
            // 
            // lblPitchValue
            // 
            lblPitchValue.AutoSize = true;
            lblPitchValue.BackColor = Color.Transparent;
            lblPitchValue.Font = new Font("Segoe UI", 25F);
            lblPitchValue.ForeColor = Color.White;
            lblPitchValue.Location = new Point(198, 150);
            lblPitchValue.Name = "lblPitchValue";
            lblPitchValue.Size = new Size(38, 46);
            lblPitchValue.TabIndex = 25;
            lblPitchValue.Text = "0";
            // 
            // ModVoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 572);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModVoice";
            Text = "ModVoice";
            Load += ModVoice_Load;
            dreamForm1.ResumeLayout(false);
            dreamForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
        private ReaLTaiizor.Controls.AirButton btnStart;
        private ReaLTaiizor.Controls.PoisonTrackBar ptbPitch;
        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private ReaLTaiizor.Controls.BigLabel lblPitchValue;
        private ReaLTaiizor.Controls.PoisonTrackBar tbLowModFreq;
        private ReaLTaiizor.Controls.PoisonTrackBar tbLowModDepth;
        private ReaLTaiizor.Controls.PoisonTrackBar trackBarTimbreStrength;
        private ReaLTaiizor.Controls.PoisonTrackBar trackBarTimbreShift;
        private ReaLTaiizor.Controls.BigLabel lblTimbreStrength;
        private ReaLTaiizor.Controls.BigLabel lblTimbreShift;
        private ReaLTaiizor.Controls.BigLabel lblLowModFreq;
        private ReaLTaiizor.Controls.BigLabel lblLowModDepth;
        private ReaLTaiizor.Controls.BigLabel lblGainValue;
        private ReaLTaiizor.Controls.PoisonTrackBar poisonTrackBar1;
        private ReaLTaiizor.Controls.PoisonTrackBar trackBarGain;
    }
}