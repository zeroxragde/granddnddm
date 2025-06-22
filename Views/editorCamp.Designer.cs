namespace GranDnDDM.Views
{
    partial class editorCamp
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
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnSave = new ReaLTaiizor.Controls.ParrotPictureBox();
            txtCamp = new ReaLTaiizor.Controls.HopeTextBox();
            nightForm1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(40, 48, 51);
            nightForm1.Controls.Add(btnClose);
            nightForm1.Controls.Add(btnSave);
            nightForm1.Controls.Add(txtCamp);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.FromArgb(50, 58, 61);
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(314, 120);
            nightForm1.TabIndex = 0;
            nightForm1.Text = "Campaña";
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
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
            btnClose.Location = new Point(287, 4);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.ColorLeft = Color.DodgerBlue;
            btnSave.ColorRight = Color.DodgerBlue;
            btnSave.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            btnSave.FilterAlpha = 200;
            btnSave.FilterEnabled = false;
            btnSave.Image = Properties.Resources.save;
            btnSave.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            btnSave.IsElipse = false;
            btnSave.IsParallax = false;
            btnSave.Location = new Point(256, 52);
            btnSave.Name = "btnSave";
            btnSave.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnSave.Size = new Size(46, 47);
            btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnSave.TabIndex = 1;
            btnSave.Text = "parrotPictureBox1";
            btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Click += btnSave_Click;
            // 
            // txtCamp
            // 
            txtCamp.BackColor = Color.White;
            txtCamp.BaseColor = Color.FromArgb(44, 55, 66);
            txtCamp.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCamp.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCamp.Font = new Font("Segoe UI", 12F);
            txtCamp.ForeColor = Color.FromArgb(48, 49, 51);
            txtCamp.Hint = "Nombre de Campaña";
            txtCamp.Location = new Point(12, 55);
            txtCamp.MaxLength = 32767;
            txtCamp.Multiline = false;
            txtCamp.Name = "txtCamp";
            txtCamp.PasswordChar = '\0';
            txtCamp.ScrollBars = ScrollBars.None;
            txtCamp.SelectedText = "";
            txtCamp.SelectionLength = 0;
            txtCamp.SelectionStart = 0;
            txtCamp.Size = new Size(234, 38);
            txtCamp.TabIndex = 0;
            txtCamp.TabStop = false;
            txtCamp.UseSystemPasswordChar = false;
            // 
            // editorCamp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 120);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1040);
            Name = "editorCamp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "editorCamp";
            TransparencyKey = Color.Fuchsia;
            nightForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.ParrotPictureBox btnSave;
        private ReaLTaiizor.Controls.HopeTextBox txtCamp;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}