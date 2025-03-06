namespace GranDnDDM.Views
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
            foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            btnCreatures = new Button();
            btnMusicControl = new Button();
            btnMapEditor = new Button();
            foreverForm1.SuspendLayout();
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
            // 
            // foreverForm1
            // 
            foreverForm1.BackColor = Color.White;
            foreverForm1.BaseColor = Color.FromArgb(60, 70, 73);
            foreverForm1.BorderColor = Color.DodgerBlue;
            foreverForm1.Controls.Add(btnCreatures);
            foreverForm1.Controls.Add(btnMusicControl);
            foreverForm1.Controls.Add(btnMapEditor);
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
            foreverForm1.Size = new Size(1475, 150);
            foreverForm1.TabIndex = 0;
            foreverForm1.Text = "Dashboard";
            foreverForm1.TextColor = Color.FromArgb(234, 234, 234);
            foreverForm1.TextLight = Color.SeaGreen;
            // 
            // btnCreatures
            // 
            btnCreatures.ImageIndex = 3;
            btnCreatures.ImageList = imageList1;
            btnCreatures.Location = new Point(211, 55);
            btnCreatures.Name = "btnCreatures";
            btnCreatures.Size = new Size(78, 83);
            btnCreatures.TabIndex = 8;
            btnCreatures.UseVisualStyleBackColor = true;
            btnCreatures.Click += btnCreatures_Click;
            // 
            // btnMusicControl
            // 
            btnMusicControl.ImageIndex = 2;
            btnMusicControl.ImageList = imageList1;
            btnMusicControl.Location = new Point(114, 54);
            btnMusicControl.Name = "btnMusicControl";
            btnMusicControl.Size = new Size(78, 83);
            btnMusicControl.TabIndex = 7;
            btnMusicControl.UseVisualStyleBackColor = true;
            // 
            // btnMapEditor
            // 
            btnMapEditor.ImageIndex = 1;
            btnMapEditor.ImageList = imageList1;
            btnMapEditor.Location = new Point(12, 54);
            btnMapEditor.Name = "btnMapEditor";
            btnMapEditor.Size = new Size(78, 83);
            btnMapEditor.TabIndex = 6;
            btnMapEditor.UseVisualStyleBackColor = true;
            // 
            // DMDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 241, 243);
            ClientSize = new Size(1475, 150);
            Controls.Add(foreverForm1);
            Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1040);
            MinimumSize = new Size(261, 65);
            Name = "DMDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dungeonForm1";
            TransparencyKey = Color.Fuchsia;
            FormClosed += DMDashboard_FormClosed;
            Load += DMDashboard_Load;
            foreverForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private Button btnCreatures;
        private Button btnMusicControl;
        private Button btnMapEditor;
    }
}