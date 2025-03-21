﻿namespace GranDnDDM.Views
{
    partial class DMDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMDashboard));
            imageList1 = new ImageList(components);
            myForm = new ReaLTaiizor.Forms.NightForm();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnCreatures = new Button();
            btnMusicControl = new Button();
            btnMapEditor = new Button();
            btnOpenShop = new Button();
            btnIniciativa = new Button();
            btnCurrency = new Button();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            btnOtherInfo = new Button();
            myForm.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "add_img.png");
            imageList1.Images.SetKeyName(1, "btnMap.png");
            imageList1.Images.SetKeyName(2, "guitar.png");
            imageList1.Images.SetKeyName(3, "iconCreature.png");
            imageList1.Images.SetKeyName(4, "shopgen.png");
            imageList1.Images.SetKeyName(5, "microOn.png");
            imageList1.Images.SetKeyName(6, "microOff.png");
            imageList1.Images.SetKeyName(7, "voiceicon.png");
            imageList1.Images.SetKeyName(8, "iconIniciativa.png");
            imageList1.Images.SetKeyName(9, "conversorcurrency.png");
            imageList1.Images.SetKeyName(10, "otherinfo.png");
            // 
            // myForm
            // 
            myForm.BackColor = Color.FromArgb(40, 48, 51);
            myForm.Controls.Add(flowLayoutPanel1);
            myForm.Controls.Add(btnClose);
            myForm.Dock = DockStyle.Fill;
            myForm.DrawIcon = false;
            myForm.Font = new Font("Segoe UI", 9F);
            myForm.HeadColor = Color.FromArgb(50, 58, 61);
            myForm.Location = new Point(0, 0);
            myForm.MinimumSize = new Size(100, 42);
            myForm.Name = "myForm";
            myForm.Padding = new Padding(0, 31, 0, 0);
            myForm.Size = new Size(897, 100);
            myForm.TabIndex = 0;
            myForm.Text = "nightForm1";
            myForm.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            myForm.TitleBarTextColor = Color.Gainsboro;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnCreatures);
            flowLayoutPanel1.Controls.Add(btnMusicControl);
            flowLayoutPanel1.Controls.Add(btnMapEditor);
            flowLayoutPanel1.Controls.Add(btnOpenShop);
            flowLayoutPanel1.Controls.Add(btnIniciativa);
            flowLayoutPanel1.Controls.Add(btnCurrency);
            flowLayoutPanel1.Controls.Add(btnOtherInfo);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 31);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(897, 69);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnCreatures
            // 
            btnCreatures.ImageIndex = 3;
            btnCreatures.ImageList = imageList1;
            btnCreatures.Location = new Point(3, 3);
            btnCreatures.Name = "btnCreatures";
            btnCreatures.Size = new Size(59, 54);
            btnCreatures.TabIndex = 14;
            btnCreatures.UseVisualStyleBackColor = true;
            btnCreatures.Click += btnCreatures_Click;
            // 
            // btnMusicControl
            // 
            btnMusicControl.ImageIndex = 2;
            btnMusicControl.ImageList = imageList1;
            btnMusicControl.Location = new Point(68, 3);
            btnMusicControl.Name = "btnMusicControl";
            btnMusicControl.Size = new Size(60, 54);
            btnMusicControl.TabIndex = 13;
            btnMusicControl.UseVisualStyleBackColor = true;
            btnMusicControl.Click += btnMusicControl_Click;
            // 
            // btnMapEditor
            // 
            btnMapEditor.ImageIndex = 1;
            btnMapEditor.ImageList = imageList1;
            btnMapEditor.Location = new Point(134, 3);
            btnMapEditor.Name = "btnMapEditor";
            btnMapEditor.Size = new Size(58, 54);
            btnMapEditor.TabIndex = 12;
            btnMapEditor.UseVisualStyleBackColor = true;
            btnMapEditor.Click += btnMapEditor_Click;
            // 
            // btnOpenShop
            // 
            btnOpenShop.ImageIndex = 4;
            btnOpenShop.ImageList = imageList1;
            btnOpenShop.Location = new Point(198, 3);
            btnOpenShop.Name = "btnOpenShop";
            btnOpenShop.Size = new Size(58, 54);
            btnOpenShop.TabIndex = 15;
            btnOpenShop.UseVisualStyleBackColor = true;
            btnOpenShop.Click += btnOpenShop_Click;
            // 
            // btnIniciativa
            // 
            btnIniciativa.ImageIndex = 8;
            btnIniciativa.ImageList = imageList1;
            btnIniciativa.Location = new Point(262, 3);
            btnIniciativa.Name = "btnIniciativa";
            btnIniciativa.Size = new Size(58, 54);
            btnIniciativa.TabIndex = 19;
            btnIniciativa.UseVisualStyleBackColor = true;
            btnIniciativa.Click += btnIniciativa_Click;
            // 
            // btnCurrency
            // 
            btnCurrency.ImageIndex = 9;
            btnCurrency.ImageList = imageList1;
            btnCurrency.Location = new Point(326, 3);
            btnCurrency.Name = "btnCurrency";
            btnCurrency.Size = new Size(58, 54);
            btnCurrency.TabIndex = 20;
            btnCurrency.UseVisualStyleBackColor = true;
            btnCurrency.Click += btnCurrency_Click;
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
            btnClose.Location = new Point(865, 4);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 15;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // btnOtherInfo
            // 
            btnOtherInfo.ImageIndex = 10;
            btnOtherInfo.ImageList = imageList1;
            btnOtherInfo.Location = new Point(390, 3);
            btnOtherInfo.Name = "btnOtherInfo";
            btnOtherInfo.Size = new Size(58, 54);
            btnOtherInfo.TabIndex = 21;
            btnOtherInfo.UseVisualStyleBackColor = true;
            btnOtherInfo.Click += btnOtherInfo_Click;
            // 
            // DMDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(897, 100);
            Controls.Add(myForm);
            Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1600, 860);
            MinimumSize = new Size(261, 61);
            Name = "DMDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            FormClosed += DMDashboard_FormClosed;
            Load += DMDashboard_Load;
            myForm.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Forms.NightForm myForm;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCreatures;
        private Button btnMusicControl;
        private Button btnMapEditor;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
        private Button btnOpenShop;
        private Button btnIniciativa;
        private Button btnCurrency;
        private Button btnOtherInfo;
    }
}