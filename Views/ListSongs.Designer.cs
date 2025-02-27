namespace GranDnDDM.Views
{
    partial class ListSongs
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(264, 323);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 380);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(227, 380);
            button1.Name = "button1";
            button1.Size = new Size(47, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(227, 21);
            button2.Name = "button2";
            button2.Size = new Size(47, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(10, 409);
            button3.Name = "button3";
            button3.Size = new Size(59, 23);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(75, 409);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 23);
            comboBox2.TabIndex = 6;
            // 
            // ListSongs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(286, 449);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ListSongs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ListSongs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox2;
    }
}