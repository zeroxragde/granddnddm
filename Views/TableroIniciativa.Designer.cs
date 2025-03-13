namespace GranDnDDM.Views
{
    partial class TableroIniciativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableroIniciativa));
            themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnSave = new PictureBox();
            flowPanel = new FlowLayoutPanel();
            btnAddLabel = new PictureBox();
            txtLabel = new ReaLTaiizor.Controls.HopeTextBox();
            themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddLabel).BeginInit();
            SuspendLayout();
            // 
            // themeForm1
            // 
            themeForm1.BackColor = Color.FromArgb(32, 41, 50);
            themeForm1.Controls.Add(btnClose);
            themeForm1.Controls.Add(btnSave);
            themeForm1.Controls.Add(flowPanel);
            themeForm1.Controls.Add(btnAddLabel);
            themeForm1.Controls.Add(txtLabel);
            themeForm1.Dock = DockStyle.Fill;
            themeForm1.Font = new Font("Microsoft Sans Serif", 9F);
            themeForm1.Image = (Image)resources.GetObject("themeForm1.Image");
            themeForm1.Location = new Point(0, 0);
            themeForm1.Name = "themeForm1";
            themeForm1.Padding = new Padding(10, 70, 10, 9);
            themeForm1.RoundCorners = true;
            themeForm1.Sizable = true;
            themeForm1.Size = new Size(374, 684);
            themeForm1.SmartBounds = true;
            themeForm1.StartPosition = FormStartPosition.CenterScreen;
            themeForm1.TabIndex = 0;
            themeForm1.Text = "Iniciativa";
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
            btnClose.Location = new Point(335, 12);
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
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(292, 625);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 50);
            btnSave.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSave.TabIndex = 3;
            btnSave.TabStop = false;
            btnSave.Click += btnSave_Click;
            // 
            // flowPanel
            // 
            flowPanel.AllowDrop = true;
            flowPanel.FlowDirection = FlowDirection.TopDown;
            flowPanel.Location = new Point(13, 126);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(326, 490);
            flowPanel.TabIndex = 2;
            flowPanel.WrapContents = false;
            flowPanel.DragDrop += flowPanel_DragDrop;
            flowPanel.DragEnter += flowPanel_DragEnter;
            flowPanel.DragOver += flowPanel_DragOver;
            // 
            // btnAddLabel
            // 
            btnAddLabel.Image = Properties.Resources.plus;
            btnAddLabel.Location = new Point(302, 73);
            btnAddLabel.Name = "btnAddLabel";
            btnAddLabel.Size = new Size(37, 38);
            btnAddLabel.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddLabel.TabIndex = 1;
            btnAddLabel.TabStop = false;
            btnAddLabel.Click += btnAddLabel_Click;
            // 
            // txtLabel
            // 
            txtLabel.BackColor = Color.White;
            txtLabel.BaseColor = Color.FromArgb(44, 55, 66);
            txtLabel.BorderColorA = Color.FromArgb(64, 158, 255);
            txtLabel.BorderColorB = Color.FromArgb(220, 223, 230);
            txtLabel.Font = new Font("Segoe UI", 12F);
            txtLabel.ForeColor = Color.FromArgb(48, 49, 51);
            txtLabel.Hint = "NOMBRE";
            txtLabel.Location = new Point(13, 73);
            txtLabel.MaxLength = 32767;
            txtLabel.Multiline = false;
            txtLabel.Name = "txtLabel";
            txtLabel.PasswordChar = '\0';
            txtLabel.ScrollBars = ScrollBars.None;
            txtLabel.SelectedText = "";
            txtLabel.SelectionLength = 0;
            txtLabel.SelectionStart = 0;
            txtLabel.Size = new Size(283, 38);
            txtLabel.TabIndex = 0;
            txtLabel.TabStop = false;
            txtLabel.UseSystemPasswordChar = false;
            // 
            // TableroIniciativa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 684);
            Controls.Add(themeForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 61);
            Name = "TableroIniciativa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciativa";
            TransparencyKey = Color.Fuchsia;
            themeForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSave).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddLabel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private PictureBox btnAddLabel;
        private ReaLTaiizor.Controls.HopeTextBox txtLabel;
        private FlowLayoutPanel flowPanel;
        private PictureBox btnSave;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}