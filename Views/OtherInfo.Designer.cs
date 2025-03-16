namespace GranDnDDM.Views
{
    partial class OtherInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherInfo));
            themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            themeForm1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // themeForm1
            // 
            themeForm1.BackColor = Color.FromArgb(32, 41, 50);
            themeForm1.Controls.Add(btnClose);
            themeForm1.Controls.Add(flowLayoutPanel1);
            themeForm1.Controls.Add(pictureBox1);
            themeForm1.Dock = DockStyle.Fill;
            themeForm1.Font = new Font("Microsoft Sans Serif", 9F);
            themeForm1.Image = (Image)resources.GetObject("themeForm1.Image");
            themeForm1.Location = new Point(0, 0);
            themeForm1.Name = "themeForm1";
            themeForm1.Padding = new Padding(10, 70, 10, 9);
            themeForm1.RoundCorners = true;
            themeForm1.Sizable = true;
            themeForm1.Size = new Size(800, 670);
            themeForm1.SmartBounds = true;
            themeForm1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            themeForm1.TabIndex = 0;
            themeForm1.Text = "Otra Informacion";
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
            btnClose.Location = new Point(760, 12);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(13, 274);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(774, 384);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.ESTADOS;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(747, 646);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.XP;
            pictureBox1.Location = new Point(12, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(468, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // OtherInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 670);
            Controls.Add(themeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "OtherInfo";
            Text = "Otra Informacion";
            TransparencyKey = Color.Fuchsia;
            themeForm1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}