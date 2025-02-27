namespace GranDnDDM.Views
{
    partial class Mapa
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
            pbFullScreen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFullScreen).BeginInit();
            SuspendLayout();
            // 
            // pbFullScreen
            // 
            pbFullScreen.BackColor = Color.Transparent;
            pbFullScreen.Dock = DockStyle.Fill;
            pbFullScreen.Location = new Point(0, 0);
            pbFullScreen.Name = "pbFullScreen";
            pbFullScreen.Size = new Size(998, 529);
            pbFullScreen.TabIndex = 0;
            pbFullScreen.TabStop = false;
            // 
            // Mapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.FondoEpico;
            ClientSize = new Size(998, 529);
            ControlBox = false;
            Controls.Add(pbFullScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mapa";
            Text = "Mapa";
            TopMost = true;
            Load += Mapa_Load;
            ((System.ComponentModel.ISupportInitialize)pbFullScreen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbFullScreen;
    }
}