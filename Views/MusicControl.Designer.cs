namespace GranDnDDM.Views
{
    partial class MusicControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicControl));
            btnPlay = new Button();
            imageList1 = new ImageList(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            trackBar1 = new TrackBar();
            btnOpenList = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.ImageIndex = 0;
            btnPlay.ImageList = imageList1;
            btnPlay.Location = new Point(57, 12);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(39, 39);
            btnPlay.TabIndex = 0;
            btnPlay.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "btnPlay.png");
            imageList1.Images.SetKeyName(1, "btnMute.png");
            imageList1.Images.SetKeyName(2, "btnNext.png");
            imageList1.Images.SetKeyName(3, "btnPause.png");
            imageList1.Images.SetKeyName(4, "btnPrev.png");
            imageList1.Images.SetKeyName(5, "btnStop.png");
            imageList1.Images.SetKeyName(6, "btnVolumen.png");
            imageList1.Images.SetKeyName(7, "btnList.png");
            // 
            // button1
            // 
            button1.ImageIndex = 4;
            button1.ImageList = imageList1;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(39, 39);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.ImageIndex = 2;
            button2.ImageList = imageList1;
            button2.Location = new Point(102, 12);
            button2.Name = "button2";
            button2.Size = new Size(39, 39);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.ImageIndex = 5;
            button3.ImageList = imageList1;
            button3.Location = new Point(147, 12);
            button3.Name = "button3";
            button3.Size = new Size(39, 39);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.ImageIndex = 6;
            button4.ImageList = imageList1;
            button4.Location = new Point(246, 12);
            button4.Name = "button4";
            button4.Size = new Size(39, 39);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(389, 23);
            label1.TabIndex = 5;
            label1.Text = "Nombre Cancion";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 89);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(512, 45);
            trackBar1.TabIndex = 6;
            // 
            // btnOpenList
            // 
            btnOpenList.ImageIndex = 7;
            btnOpenList.ImageList = imageList1;
            btnOpenList.Location = new Point(485, 12);
            btnOpenList.Name = "btnOpenList";
            btnOpenList.Size = new Size(39, 39);
            btnOpenList.TabIndex = 7;
            btnOpenList.UseVisualStyleBackColor = true;
            btnOpenList.Click += btnOpenList_Click;
         
            // 
            // MusicControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(536, 130);
            Controls.Add(btnOpenList);
            Controls.Add(trackBar1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MusicControl";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MusicControl";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlay;
        private ImageList imageList1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TrackBar trackBar1;
        private Button btnOpenList;
    }
}