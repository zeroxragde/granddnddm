namespace GranDnDDM.Views
{
    partial class CreatureGen
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
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            pCard = new ReaLTaiizor.Controls.Panel();
            lblTiradasSalvacion = new ReaLTaiizor.Controls.NightLabel();
            nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblName = new ReaLTaiizor.Controls.NightLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblOtrosDatos = new ReaLTaiizor.Controls.NightLabel();
            lblInteligencia = new ReaLTaiizor.Controls.NightLabel();
            lblCarisma = new ReaLTaiizor.Controls.NightLabel();
            lblConstitucion = new ReaLTaiizor.Controls.NightLabel();
            lblDestreza = new ReaLTaiizor.Controls.NightLabel();
            lblFuerza = new ReaLTaiizor.Controls.NightLabel();
            lblSabiduria = new ReaLTaiizor.Controls.NightLabel();
            nightLabel14 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel13 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel12 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel10 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel11 = new ReaLTaiizor.Controls.NightLabel();
            lblCA = new ReaLTaiizor.Controls.NightLabel();
            lblPubtosGolpe = new ReaLTaiizor.Controls.NightLabel();
            nightLabel6 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel5 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel4 = new ReaLTaiizor.Controls.NightLabel();
            nightLabel3 = new ReaLTaiizor.Controls.NightLabel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            lblVelocidades = new ReaLTaiizor.Controls.NightLabel();
            nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            lblSkills = new ReaLTaiizor.Controls.NightLabel();
            formTheme1.SuspendLayout();
            nightPanel1.SuspendLayout();
            pCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(btnClose);
            formTheme1.Controls.Add(nightPanel1);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(687, 756);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.CenterScreen;
            formTheme1.TabIndex = 0;
            formTheme1.Text = "CreatureGenView";
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
            btnClose.Location = new Point(648, 0);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // nightPanel1
            // 
            nightPanel1.BackgroundImage = Properties.Resources.backEpicoNormalized;
            nightPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            nightPanel1.Controls.Add(pCard);
            nightPanel1.Dock = DockStyle.Fill;
            nightPanel1.ForeColor = Color.FromArgb(250, 250, 250);
            nightPanel1.LeftSideColor = Color.FromArgb(242, 93, 89);
            nightPanel1.Location = new Point(3, 28);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            nightPanel1.Size = new Size(681, 700);
            nightPanel1.TabIndex = 0;
            // 
            // pCard
            // 
            pCard.BackColor = Color.FromArgb(128, 64, 64);
            pCard.Controls.Add(lblSkills);
            pCard.Controls.Add(nightLabel2);
            pCard.Controls.Add(lblTiradasSalvacion);
            pCard.Controls.Add(nightLabel1);
            pCard.Controls.Add(pictureBox1);
            pCard.Controls.Add(flowLayoutPanel1);
            pCard.Controls.Add(flowLayoutPanel2);
            pCard.Controls.Add(lblInteligencia);
            pCard.Controls.Add(lblCarisma);
            pCard.Controls.Add(lblConstitucion);
            pCard.Controls.Add(lblDestreza);
            pCard.Controls.Add(lblFuerza);
            pCard.Controls.Add(lblSabiduria);
            pCard.Controls.Add(nightLabel14);
            pCard.Controls.Add(nightLabel13);
            pCard.Controls.Add(nightLabel12);
            pCard.Controls.Add(nightLabel10);
            pCard.Controls.Add(nightLabel11);
            pCard.Controls.Add(lblCA);
            pCard.Controls.Add(lblPubtosGolpe);
            pCard.Controls.Add(nightLabel6);
            pCard.Controls.Add(nightLabel5);
            pCard.Controls.Add(nightLabel4);
            pCard.Controls.Add(nightLabel3);
            pCard.Controls.Add(panel4);
            pCard.Controls.Add(panel3);
            pCard.Controls.Add(panel2);
            pCard.Controls.Add(lblVelocidades);
            pCard.EdgeColor = Color.FromArgb(32, 41, 50);
            pCard.Location = new Point(15, 16);
            pCard.Name = "pCard";
            pCard.Padding = new Padding(5);
            pCard.Size = new Size(654, 444);
            pCard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pCard.TabIndex = 4;
            pCard.Text = "panel1";
            // 
            // lblTiradasSalvacion
            // 
            lblTiradasSalvacion.AutoSize = true;
            lblTiradasSalvacion.BackColor = Color.Transparent;
            lblTiradasSalvacion.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiradasSalvacion.ForeColor = Color.FromArgb(255, 192, 128);
            lblTiradasSalvacion.Location = new Point(180, 351);
            lblTiradasSalvacion.Name = "lblTiradasSalvacion";
            lblTiradasSalvacion.Size = new Size(35, 20);
            lblTiradasSalvacion.TabIndex = 30;
            lblTiradasSalvacion.Text = "Des";
            // 
            // nightLabel1
            // 
            nightLabel1.AutoSize = true;
            nightLabel1.BackColor = Color.Transparent;
            nightLabel1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel1.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel1.Location = new Point(18, 349);
            nightLabel1.Name = "nightLabel1";
            nightLabel1.Size = new Size(169, 23);
            nightLabel1.TabIndex = 29;
            nightLabel1.Text = "Tiradas de Salvacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pencil;
            pictureBox1.Location = new Point(604, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblName);
            flowLayoutPanel1.Location = new Point(12, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(539, 51);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Cascadia Code", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(255, 128, 128);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(146, 46);
            lblName.TabIndex = 0;
            lblName.Text = "Ankheg";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lblOtrosDatos);
            flowLayoutPanel2.Location = new Point(15, 54);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(539, 32);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // lblOtrosDatos
            // 
            lblOtrosDatos.AutoSize = true;
            lblOtrosDatos.BackColor = Color.Transparent;
            lblOtrosDatos.Font = new Font("Candara", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOtrosDatos.ForeColor = Color.FromArgb(224, 224, 224);
            lblOtrosDatos.Location = new Point(3, 4);
            lblOtrosDatos.Margin = new Padding(3, 4, 3, 0);
            lblOtrosDatos.Name = "lblOtrosDatos";
            lblOtrosDatos.Size = new Size(182, 23);
            lblOtrosDatos.TabIndex = 2;
            lblOtrosDatos.Text = "Large fiend, unaligned";
            // 
            // lblInteligencia
            // 
            lblInteligencia.AutoSize = true;
            lblInteligencia.BackColor = Color.Transparent;
            lblInteligencia.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInteligencia.ForeColor = Color.FromArgb(255, 192, 128);
            lblInteligencia.Location = new Point(219, 231);
            lblInteligencia.Name = "lblInteligencia";
            lblInteligencia.Size = new Size(57, 20);
            lblInteligencia.TabIndex = 27;
            lblInteligencia.Text = "10 (+0)";
            // 
            // lblCarisma
            // 
            lblCarisma.AutoSize = true;
            lblCarisma.BackColor = Color.Transparent;
            lblCarisma.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCarisma.ForeColor = Color.FromArgb(255, 192, 128);
            lblCarisma.Location = new Point(219, 291);
            lblCarisma.Name = "lblCarisma";
            lblCarisma.Size = new Size(57, 20);
            lblCarisma.TabIndex = 26;
            lblCarisma.Text = "10 (+0)";
            // 
            // lblConstitucion
            // 
            lblConstitucion.AutoSize = true;
            lblConstitucion.BackColor = Color.Transparent;
            lblConstitucion.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConstitucion.ForeColor = Color.FromArgb(255, 192, 128);
            lblConstitucion.Location = new Point(51, 289);
            lblConstitucion.Name = "lblConstitucion";
            lblConstitucion.Size = new Size(57, 20);
            lblConstitucion.TabIndex = 25;
            lblConstitucion.Text = "10 (+0)";
            // 
            // lblDestreza
            // 
            lblDestreza.AutoSize = true;
            lblDestreza.BackColor = Color.Transparent;
            lblDestreza.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDestreza.ForeColor = Color.FromArgb(255, 192, 128);
            lblDestreza.Location = new Point(51, 261);
            lblDestreza.Name = "lblDestreza";
            lblDestreza.Size = new Size(57, 20);
            lblDestreza.TabIndex = 24;
            lblDestreza.Text = "10 (+0)";
            // 
            // lblFuerza
            // 
            lblFuerza.AutoSize = true;
            lblFuerza.BackColor = Color.Transparent;
            lblFuerza.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuerza.ForeColor = Color.FromArgb(255, 192, 128);
            lblFuerza.Location = new Point(51, 231);
            lblFuerza.Name = "lblFuerza";
            lblFuerza.Size = new Size(57, 20);
            lblFuerza.TabIndex = 23;
            lblFuerza.Text = "10 (+0)";
            // 
            // lblSabiduria
            // 
            lblSabiduria.AutoSize = true;
            lblSabiduria.BackColor = Color.Transparent;
            lblSabiduria.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSabiduria.ForeColor = Color.FromArgb(255, 192, 128);
            lblSabiduria.Location = new Point(219, 264);
            lblSabiduria.Name = "lblSabiduria";
            lblSabiduria.Size = new Size(57, 20);
            lblSabiduria.TabIndex = 22;
            lblSabiduria.Text = "10 (+0)";
            // 
            // nightLabel14
            // 
            nightLabel14.AutoSize = true;
            nightLabel14.BackColor = Color.Transparent;
            nightLabel14.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel14.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel14.Location = new Point(170, 262);
            nightLabel14.Name = "nightLabel14";
            nightLabel14.Size = new Size(43, 23);
            nightLabel14.TabIndex = 16;
            nightLabel14.Text = "SAB";
            // 
            // nightLabel13
            // 
            nightLabel13.AutoSize = true;
            nightLabel13.BackColor = Color.Transparent;
            nightLabel13.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel13.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel13.Location = new Point(170, 288);
            nightLabel13.Name = "nightLabel13";
            nightLabel13.Size = new Size(42, 23);
            nightLabel13.TabIndex = 15;
            nightLabel13.Text = "CAR";
            // 
            // nightLabel12
            // 
            nightLabel12.AutoSize = true;
            nightLabel12.BackColor = Color.Transparent;
            nightLabel12.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel12.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel12.Location = new Point(170, 229);
            nightLabel12.Name = "nightLabel12";
            nightLabel12.Size = new Size(43, 23);
            nightLabel12.TabIndex = 14;
            nightLabel12.Text = "INT";
            // 
            // nightLabel10
            // 
            nightLabel10.AutoSize = true;
            nightLabel10.BackColor = Color.Transparent;
            nightLabel10.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel10.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel10.Location = new Point(12, 286);
            nightLabel10.Name = "nightLabel10";
            nightLabel10.Size = new Size(46, 23);
            nightLabel10.TabIndex = 13;
            nightLabel10.Text = "CON";
            // 
            // nightLabel11
            // 
            nightLabel11.AutoSize = true;
            nightLabel11.BackColor = Color.Transparent;
            nightLabel11.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel11.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel11.Location = new Point(12, 258);
            nightLabel11.Name = "nightLabel11";
            nightLabel11.Size = new Size(43, 23);
            nightLabel11.TabIndex = 12;
            nightLabel11.Text = "DES";
            // 
            // lblCA
            // 
            lblCA.AutoSize = true;
            lblCA.BackColor = Color.Transparent;
            lblCA.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCA.ForeColor = Color.FromArgb(255, 192, 128);
            lblCA.Location = new Point(180, 109);
            lblCA.Name = "lblCA";
            lblCA.Size = new Size(27, 23);
            lblCA.TabIndex = 10;
            lblCA.Text = "12";
            // 
            // lblPubtosGolpe
            // 
            lblPubtosGolpe.AutoSize = true;
            lblPubtosGolpe.BackColor = Color.Transparent;
            lblPubtosGolpe.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPubtosGolpe.ForeColor = Color.FromArgb(255, 192, 128);
            lblPubtosGolpe.Location = new Point(170, 141);
            lblPubtosGolpe.Name = "lblPubtosGolpe";
            lblPubtosGolpe.Size = new Size(118, 23);
            lblPubtosGolpe.TabIndex = 9;
            lblPubtosGolpe.Text = "60 (8d10 + 16)";
            // 
            // nightLabel6
            // 
            nightLabel6.AutoSize = true;
            nightLabel6.BackColor = Color.Transparent;
            nightLabel6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            nightLabel6.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel6.Location = new Point(12, 165);
            nightLabel6.Name = "nightLabel6";
            nightLabel6.Size = new Size(109, 30);
            nightLabel6.TabIndex = 7;
            nightLabel6.Text = "Velocidad";
            // 
            // nightLabel5
            // 
            nightLabel5.AutoSize = true;
            nightLabel5.BackColor = Color.Transparent;
            nightLabel5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            nightLabel5.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel5.Location = new Point(11, 137);
            nightLabel5.Name = "nightLabel5";
            nightLabel5.Size = new Size(163, 30);
            nightLabel5.TabIndex = 6;
            nightLabel5.Text = "Punto de Golpe";
            // 
            // nightLabel4
            // 
            nightLabel4.AutoSize = true;
            nightLabel4.BackColor = Color.Transparent;
            nightLabel4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold);
            nightLabel4.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel4.Location = new Point(10, 104);
            nightLabel4.Name = "nightLabel4";
            nightLabel4.Size = new Size(173, 30);
            nightLabel4.TabIndex = 5;
            nightLabel4.Text = "Clase Armadura";
            // 
            // nightLabel3
            // 
            nightLabel3.AutoSize = true;
            nightLabel3.BackColor = Color.Transparent;
            nightLabel3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel3.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel3.Location = new Point(12, 229);
            nightLabel3.Name = "nightLabel3";
            nightLabel3.Size = new Size(42, 23);
            nightLabel3.TabIndex = 4;
            nightLabel3.Text = "FUE";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 128);
            panel4.Location = new Point(12, 321);
            panel4.Name = "panel4";
            panel4.Size = new Size(631, 14);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 192, 128);
            panel3.Location = new Point(8, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(635, 10);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Location = new Point(8, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 10);
            panel2.TabIndex = 1;
            // 
            // lblVelocidades
            // 
            lblVelocidades.AutoSize = true;
            lblVelocidades.BackColor = Color.Transparent;
            lblVelocidades.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVelocidades.ForeColor = Color.FromArgb(255, 192, 128);
            lblVelocidades.Location = new Point(117, 170);
            lblVelocidades.Name = "lblVelocidades";
            lblVelocidades.Size = new Size(64, 23);
            lblVelocidades.TabIndex = 8;
            lblVelocidades.Text = "30 pies";
            // 
            // nightLabel2
            // 
            nightLabel2.AutoSize = true;
            nightLabel2.BackColor = Color.Transparent;
            nightLabel2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nightLabel2.ForeColor = Color.FromArgb(255, 192, 128);
            nightLabel2.Location = new Point(18, 372);
            nightLabel2.Name = "nightLabel2";
            nightLabel2.Size = new Size(97, 23);
            nightLabel2.TabIndex = 31;
            nightLabel2.Text = "Habilidades";
            // 
            // lblSkills
            // 
            lblSkills.AutoSize = true;
            lblSkills.BackColor = Color.Transparent;
            lblSkills.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSkills.ForeColor = Color.FromArgb(255, 192, 128);
            lblSkills.Location = new Point(108, 374);
            lblSkills.Name = "lblSkills";
            lblSkills.Size = new Size(35, 20);
            lblSkills.TabIndex = 32;
            lblSkills.Text = "Des";
            // 
            // CreatureGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backEpicoNormalized;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(687, 756);
            Controls.Add(formTheme1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 2000);
            MinimumSize = new Size(126, 50);
            Name = "CreatureGen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatureGenView";
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            nightPanel1.ResumeLayout(false);
            pCard.ResumeLayout(false);
            pCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private ReaLTaiizor.Controls.Panel pCard;
        private ReaLTaiizor.Controls.NightLabel lblInteligencia;
        private ReaLTaiizor.Controls.NightLabel lblCarisma;
        private ReaLTaiizor.Controls.NightLabel lblConstitucion;
        private ReaLTaiizor.Controls.NightLabel lblDestreza;
        private ReaLTaiizor.Controls.NightLabel lblFuerza;
        private ReaLTaiizor.Controls.NightLabel lblSabiduria;
        private ReaLTaiizor.Controls.NightLabel nightLabel14;
        private ReaLTaiizor.Controls.NightLabel nightLabel13;
        private ReaLTaiizor.Controls.NightLabel nightLabel12;
        private ReaLTaiizor.Controls.NightLabel nightLabel10;
        private ReaLTaiizor.Controls.NightLabel nightLabel11;
        private ReaLTaiizor.Controls.NightLabel lblCA;
        private ReaLTaiizor.Controls.NightLabel lblPubtosGolpe;
        private ReaLTaiizor.Controls.NightLabel nightLabel6;
        private ReaLTaiizor.Controls.NightLabel nightLabel5;
        private ReaLTaiizor.Controls.NightLabel nightLabel4;
        private ReaLTaiizor.Controls.NightLabel nightLabel3;
        private Panel panel4;
        private Panel panel3;
        private ReaLTaiizor.Controls.NightLabel lblOtrosDatos;
        private Panel panel2;
        private ReaLTaiizor.Controls.NightLabel lblName;
        private ReaLTaiizor.Controls.NightLabel lblVelocidades;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.ForeverComboBox cbListType;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightLabel lblTiradasSalvacion;
        private ReaLTaiizor.Controls.NightLabel lblSkills;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
    }
}