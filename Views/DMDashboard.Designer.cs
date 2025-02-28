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
            btnLoadPJ = new Button();
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
            // btnLoadPJ
            // 
            btnLoadPJ.ImageIndex = 2;
            btnLoadPJ.ImageList = imageList1;
            btnLoadPJ.Location = new Point(218, 12);
            btnLoadPJ.Name = "btnLoadPJ";
            btnLoadPJ.Size = new Size(78, 83);
            btnLoadPJ.TabIndex = 2;
            btnLoadPJ.UseVisualStyleBackColor = true;
            btnLoadPJ.Click += btnLoadPJ_Click;
            // 
            // DMDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1475, 107);
            Controls.Add(btnLoadPJ);
            Controls.Add(btnMusicControl);
            Controls.Add(btnMapEditor);
            Font = new Font("Univia Pro", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
        private Button btnLoadPJ;
    }
}