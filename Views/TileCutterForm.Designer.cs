namespace GranDnDDM.Views
{
    partial class TileCutterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileCutterForm));
            thunderForm1 = new ReaLTaiizor.Forms.ThunderForm();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnLoadTileset = new ReaLTaiizor.Controls.CyberButton();
            txtTileWidth = new ReaLTaiizor.Controls.CrownNumeric();
            txtTileHeight = new ReaLTaiizor.Controls.CrownNumeric();
            pContainerPicture = new Panel();
            pbTileset = new PictureBox();
            thunderForm1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTileWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTileHeight).BeginInit();
            pContainerPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTileset).BeginInit();
            SuspendLayout();
            // 
            // thunderForm1
            // 
            thunderForm1.BodyColorA = Color.FromArgb(25, 25, 25);
            thunderForm1.BodyColorB = Color.FromArgb(30, 35, 48);
            thunderForm1.BodyColorC = Color.FromArgb(46, 46, 46);
            thunderForm1.BodyColorD = Color.FromArgb(50, 55, 58);
            thunderForm1.Controls.Add(btnClose);
            thunderForm1.Controls.Add(tableLayoutPanel1);
            thunderForm1.Dock = DockStyle.Fill;
            thunderForm1.ForeColor = Color.WhiteSmoke;
            thunderForm1.Image = (Image)resources.GetObject("thunderForm1.Image");
            thunderForm1.Location = new Point(0, 0);
            thunderForm1.MinimumSize = new Size(270, 50);
            thunderForm1.Name = "thunderForm1";
            thunderForm1.Padding = new Padding(11, 29, 11, 6);
            thunderForm1.Size = new Size(800, 450);
            thunderForm1.TabIndex = 0;
            thunderForm1.Text = "thunderForm1";
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
            btnClose.Location = new Point(683, 6);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pContainerPicture, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(11, 29);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.3855419F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.6144562F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(778, 415);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(btnLoadTileset);
            flowLayoutPanel1.Controls.Add(txtTileWidth);
            flowLayoutPanel1.Controls.Add(txtTileHeight);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(772, 62);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnLoadTileset
            // 
            btnLoadTileset.Alpha = 20;
            btnLoadTileset.BackColor = Color.Transparent;
            btnLoadTileset.Background = true;
            btnLoadTileset.Background_WidthPen = 4F;
            btnLoadTileset.BackgroundPen = true;
            btnLoadTileset.ColorBackground = Color.FromArgb(37, 52, 68);
            btnLoadTileset.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnLoadTileset.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnLoadTileset.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnLoadTileset.ColorLighting = Color.FromArgb(29, 200, 238);
            btnLoadTileset.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnLoadTileset.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnLoadTileset.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLoadTileset.Effect_1 = true;
            btnLoadTileset.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLoadTileset.Effect_1_Transparency = 25;
            btnLoadTileset.Effect_2 = true;
            btnLoadTileset.Effect_2_ColorBackground = Color.White;
            btnLoadTileset.Effect_2_Transparency = 20;
            btnLoadTileset.Font = new Font("Arial", 11F);
            btnLoadTileset.ForeColor = Color.FromArgb(245, 245, 245);
            btnLoadTileset.Lighting = false;
            btnLoadTileset.LinearGradient_Background = false;
            btnLoadTileset.LinearGradientPen = false;
            btnLoadTileset.Location = new Point(3, 3);
            btnLoadTileset.Name = "btnLoadTileset";
            btnLoadTileset.PenWidth = 15;
            btnLoadTileset.Rounding = true;
            btnLoadTileset.RoundingInt = 70;
            btnLoadTileset.Size = new Size(130, 50);
            btnLoadTileset.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLoadTileset.TabIndex = 2;
            btnLoadTileset.Tag = "Cyber";
            btnLoadTileset.TextButton = "Cargar";
            btnLoadTileset.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLoadTileset.Timer_Effect_1 = 5;
            btnLoadTileset.Timer_RGB = 300;
            btnLoadTileset.Click += btnLoadTileset_Click;
            // 
            // txtTileWidth
            // 
            txtTileWidth.Location = new Point(152, 16);
            txtTileWidth.Margin = new Padding(16, 16, 3, 3);
            txtTileWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtTileWidth.Name = "txtTileWidth";
            txtTileWidth.Size = new Size(120, 23);
            txtTileWidth.TabIndex = 3;
            txtTileWidth.Value = new decimal(new int[] { 32, 0, 0, 0 });
            txtTileWidth.ValueChanged += txtTileWidth_ValueChanged;
            // 
            // txtTileHeight
            // 
            txtTileHeight.Location = new Point(291, 16);
            txtTileHeight.Margin = new Padding(16, 16, 3, 3);
            txtTileHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtTileHeight.Name = "txtTileHeight";
            txtTileHeight.Size = new Size(120, 23);
            txtTileHeight.TabIndex = 4;
            txtTileHeight.Value = new decimal(new int[] { 32, 0, 0, 0 });
            txtTileHeight.ValueChanged += txtTileHeight_ValueChanged;
            // 
            // pContainerPicture
            // 
            pContainerPicture.AutoScroll = true;
            pContainerPicture.Controls.Add(pbTileset);
            pContainerPicture.Dock = DockStyle.Fill;
            pContainerPicture.Location = new Point(3, 71);
            pContainerPicture.Name = "pContainerPicture";
            pContainerPicture.Size = new Size(772, 341);
            pContainerPicture.TabIndex = 4;
            // 
            // pbTileset
            // 
            pbTileset.BackColor = Color.Gray;
            pbTileset.Location = new Point(3, 3);
            pbTileset.Name = "pbTileset";
            pbTileset.Size = new Size(512, 512);
            pbTileset.SizeMode = PictureBoxSizeMode.AutoSize;
            pbTileset.TabIndex = 3;
            pbTileset.TabStop = false;
            pbTileset.Paint += pbTileset_Paint;
            pbTileset.MouseClick += pbTileset_MouseClick;
            // 
            // TileCutterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(thunderForm1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(261, 65);
            Name = "TileCutterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            thunderForm1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtTileWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTileHeight).EndInit();
            pContainerPicture.ResumeLayout(false);
            pContainerPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTileset).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ThunderForm thunderForm1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.CyberButton btnLoadTileset;
        private ReaLTaiizor.Controls.CrownNumeric txtTileWidth;
        private ReaLTaiizor.Controls.CrownNumeric txtTileHeight;
        private Panel pContainerPicture;
        private PictureBox pbTileset;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}