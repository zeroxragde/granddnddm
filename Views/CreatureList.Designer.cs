namespace GranDnDDM.Views
{
    partial class CreatureList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatureList));
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            btnNueva = new ReaLTaiizor.Controls.DreamButton();
            crownListView1 = new ReaLTaiizor.Controls.CrownListView();
            imageList1 = new ImageList(components);
            dreamForm1.SuspendLayout();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.FromArgb(0, 0, 0, 0);
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(dreamButton1);
            dreamForm1.Controls.Add(btnNueva);
            dreamForm1.Controls.Add(crownListView1);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(385, 634);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "dreamForm1";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // dreamButton1
            // 
            dreamButton1.ColorA = Color.FromArgb(31, 31, 31);
            dreamButton1.ColorB = Color.FromArgb(41, 41, 41);
            dreamButton1.ColorC = Color.FromArgb(51, 51, 51);
            dreamButton1.ColorD = Color.FromArgb(0, 0, 0, 0);
            dreamButton1.ColorE = Color.FromArgb(25, 255, 255, 255);
            dreamButton1.ForeColor = Color.Red;
            dreamButton1.Location = new Point(253, 562);
            dreamButton1.Name = "dreamButton1";
            dreamButton1.Size = new Size(120, 40);
            dreamButton1.TabIndex = 2;
            dreamButton1.Text = "Salir";
            dreamButton1.UseVisualStyleBackColor = true;
            dreamButton1.Click += dreamButton1_Click;
            // 
            // btnNueva
            // 
            btnNueva.ColorA = Color.FromArgb(31, 31, 31);
            btnNueva.ColorB = Color.FromArgb(41, 41, 41);
            btnNueva.ColorC = Color.FromArgb(51, 51, 51);
            btnNueva.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnNueva.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnNueva.ForeColor = Color.FromArgb(40, 218, 255);
            btnNueva.Location = new Point(6, 562);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(120, 40);
            btnNueva.TabIndex = 1;
            btnNueva.Text = "Nueva Creatura";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // crownListView1
            // 
            crownListView1.Location = new Point(21, 40);
            crownListView1.Name = "crownListView1";
            crownListView1.Size = new Size(332, 501);
            crownListView1.TabIndex = 0;
            crownListView1.Text = "crownListView1";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "closewin.png");
            // 
            // CreatureList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 634);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatureList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatureList";
            dreamForm1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private ReaLTaiizor.Controls.DreamButton btnNueva;
        private ReaLTaiizor.Controls.CrownListView crownListView1;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
    }
}