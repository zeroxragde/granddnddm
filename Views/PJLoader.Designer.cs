namespace GranDnDDM.Views
{
    partial class PJLoader
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
            aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            SuspendLayout();
            // 
            // aloneButton1
            // 
            aloneButton1.BackColor = Color.Transparent;
            aloneButton1.EnabledCalc = true;
            aloneButton1.Font = new Font("Segoe UI", 9F);
            aloneButton1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton1.Location = new Point(26, 38);
            aloneButton1.Name = "aloneButton1";
            aloneButton1.Size = new Size(120, 40);
            aloneButton1.TabIndex = 0;
            aloneButton1.Text = "aloneButton1";
            aloneButton1.Click += aloneButton1_Click;
            // 
            // PJLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(188, 450);
            Controls.Add(aloneButton1);
            Name = "PJLoader";
            Text = "PJLoader";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AloneButton aloneButton1;
    }
}