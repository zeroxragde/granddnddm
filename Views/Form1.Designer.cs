namespace GranDnDDM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtDMName = new TextBox();
            btnStasrt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 30);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 24);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Monitor de Mapa:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(339, 32);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 92);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 24);
            label2.TabIndex = 2;
            label2.Text = "Nombre del DM";
            // 
            // txtDMName
            // 
            txtDMName.Location = new Point(27, 130);
            txtDMName.Name = "txtDMName";
            txtDMName.Size = new Size(339, 29);
            txtDMName.TabIndex = 3;
            txtDMName.Text = "ED";
            // 
            // btnStasrt
            // 
            btnStasrt.ForeColor = SystemColors.ActiveCaptionText;
            btnStasrt.Location = new Point(114, 181);
            btnStasrt.Name = "btnStasrt";
            btnStasrt.Size = new Size(130, 49);
            btnStasrt.TabIndex = 4;
            btnStasrt.Text = "Iniciar";
            btnStasrt.UseVisualStyleBackColor = true;
            btnStasrt.Click += btnStasrt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(389, 250);
            ControlBox = false;
            Controls.Add(btnStasrt);
            Controls.Add(txtDMName);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GrandDnD/DM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtDMName;
        private Button btnStasrt;
    }
}
