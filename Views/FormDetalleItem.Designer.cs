namespace GranDnDDM.Views
{
    partial class FormDetalleItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalleItem));
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDescripcion = new Label();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            lblNombre = new Label();
            pictureBoxImagen = new PictureBox();
            lblPrecio = new Label();
            lblTipoObjeto = new Label();
            lblCategoria = new Label();
            dreamForm1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).BeginInit();
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
            dreamForm1.Controls.Add(flowLayoutPanel1);
            dreamForm1.Controls.Add(btnClose);
            dreamForm1.Controls.Add(lblNombre);
            dreamForm1.Controls.Add(pictureBoxImagen);
            dreamForm1.Controls.Add(lblPrecio);
            dreamForm1.Controls.Add(lblTipoObjeto);
            dreamForm1.Controls.Add(lblCategoria);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(540, 296);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Objeto";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(lblDescripcion);
            flowLayoutPanel1.Location = new Point(192, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(336, 146);
            flowLayoutPanel1.TabIndex = 17;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Dock = DockStyle.Fill;
            lblDescripcion.ForeColor = Color.White;
            lblDescripcion.Location = new Point(3, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(41, 15);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "DITEM";
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
            btnClose.Location = new Point(507, 0);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(12, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(300, 30);
            lblNombre.TabIndex = 6;
            // 
            // pictureBoxImagen
            // 
            pictureBoxImagen.BackColor = Color.FromArgb(0, 0, 64);
            pictureBoxImagen.Location = new Point(12, 78);
            pictureBoxImagen.Name = "pictureBoxImagen";
            pictureBoxImagen.Size = new Size(150, 150);
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImagen.TabIndex = 7;
            pictureBoxImagen.TabStop = false;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(192, 148);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(150, 30);
            lblPrecio.TabIndex = 9;
            // 
            // lblTipoObjeto
            // 
            lblTipoObjeto.BackColor = Color.Transparent;
            lblTipoObjeto.ForeColor = Color.White;
            lblTipoObjeto.Location = new Point(192, 227);
            lblTipoObjeto.Name = "lblTipoObjeto";
            lblTipoObjeto.Size = new Size(150, 30);
            lblTipoObjeto.TabIndex = 10;
            // 
            // lblCategoria
            // 
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(192, 257);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(150, 30);
            lblCategoria.TabIndex = 11;
            // 
            // FormDetalleItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 296);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDetalleItem";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalles del Item";
            dreamForm1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private Label lblNombre;
        private PictureBox pictureBoxImagen;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblTipoObjeto;
        private Label lblCategoria;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}