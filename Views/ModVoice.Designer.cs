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
            ptbPitch.Location = new Point(13, 248);
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
            dreamForm1.Controls.Add(lblPitchValue);
            dreamForm1.Controls.Add(ptbPitch);
            dreamForm1.Controls.Add(btnStart);
            dreamForm1.Controls.Add(btnClose);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(246, 450);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Modificador de VOZ";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // lblPitchValue
            // 
            lblPitchValue.AutoSize = true;
            lblPitchValue.BackColor = Color.Transparent;
            lblPitchValue.Font = new Font("Segoe UI", 25F);
            lblPitchValue.ForeColor = Color.White;
            lblPitchValue.Location = new Point(13, 199);
            lblPitchValue.Name = "lblPitchValue";
            lblPitchValue.Size = new Size(38, 46);
            lblPitchValue.TabIndex = 25;
            lblPitchValue.Text = "0";
            // 
            // ModVoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 450);
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
    }
}