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
            btnMapEditor = new Button();
            btnMusicControl = new Button();
            btnCreatures = new Button();
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
            // btnMapEditor
            // 
            btnMapEditor.ImageIndex = 1;
            btnMapEditor.ImageList = imageList1;
            btnMapEditor.Location = new Point(12, 12);
            btnMapEditor.Name = "btnMapEditor";
            btnMapEditor.Size = new Size(78, 83);
            btnMapEditor.TabIndex = 0;
            btnMapEditor.UseVisualStyleBackColor = true;
            btnMapEditor.Click += btnMapEditor_Click;
            // 
            // btnMusicControl
            // 
            btnMusicControl.ImageIndex = 2;
            btnMusicControl.ImageList = imageList1;
            btnMusicControl.Location = new Point(114, 12);
            btnMusicControl.Name = "btnMusicControl";
            btnMusicControl.Size = new Size(78, 83);
            btnMusicControl.TabIndex = 1;
            btnMusicControl.UseVisualStyleBackColor = true;
            btnMusicControl.Click += btnMusicControl_Click;
            // 
            // btnCreatures
            // 
            btnCreatures.ImageIndex = 3;
            btnCreatures.ImageList = imageList1;
            btnCreatures.Location = new Point(212, 12);
            btnCreatures.Name = "btnCreatures";
            btnCreatures.Size = new Size(78, 83);
            btnCreatures.TabIndex = 2;
            btnCreatures.UseVisualStyleBackColor = true;
            btnCreatures.Click += btnCreatures_Click;
            // 
            // DMDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1475, 107);
            Controls.Add(btnCreatures);
            Controls.Add(btnMusicControl);
            Controls.Add(btnMapEditor);
            Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "DMDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DMDashboard";
            FormClosed += DMDashboard_FormClosed;
            Load += DMDashboard_Load;
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private Button btnMapEditor;
        private Button btnMusicControl;
        private Button btnCreatures;
    }
}