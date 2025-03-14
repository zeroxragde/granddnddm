namespace GranDnDDM.Views
{
    partial class ConversorMoneda
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
            dreamForm1 = new ReaLTaiizor.Forms.DreamForm();
            lblResult = new Label();
            cmbFrom = new ReaLTaiizor.Controls.HopeComboBox();
            BtnConvert = new ReaLTaiizor.Controls.ParrotPictureBox();
            cmbTo = new ReaLTaiizor.Controls.HopeComboBox();
            txtAmount = new ReaLTaiizor.Controls.HopeNumeric();
            btnClose = new ReaLTaiizor.Controls.ParrotPictureBox();
            dreamForm1.SuspendLayout();
            SuspendLayout();
            // 
            // dreamForm1
            // 
            dreamForm1.ColorA = Color.FromArgb(40, 218, 255);
            dreamForm1.ColorB = Color.FromArgb(63, 63, 63);
            dreamForm1.ColorC = Color.FromArgb(41, 41, 41);
            dreamForm1.ColorD = Color.FromArgb(27, 27, 27);
            dreamForm1.ColorE = Color.Silver;
            dreamForm1.ColorF = Color.FromArgb(25, 255, 255, 255);
            dreamForm1.Controls.Add(btnClose);
            dreamForm1.Controls.Add(lblResult);
            dreamForm1.Controls.Add(cmbFrom);
            dreamForm1.Controls.Add(BtnConvert);
            dreamForm1.Controls.Add(cmbTo);
            dreamForm1.Controls.Add(txtAmount);
            dreamForm1.Dock = DockStyle.Fill;
            dreamForm1.Location = new Point(0, 0);
            dreamForm1.Name = "dreamForm1";
            dreamForm1.Size = new Size(714, 97);
            dreamForm1.TabIndex = 0;
            dreamForm1.TabStop = false;
            dreamForm1.Text = "Conversor de Monedas";
            dreamForm1.TitleAlign = HorizontalAlignment.Center;
            dreamForm1.TitleHeight = 25;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(224, 224, 224);
            lblResult.Location = new Point(395, 43);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(54, 29);
            lblResult.TabIndex = 5;
            lblResult.Text = "0 pc";
            // 
            // cmbFrom
            // 
            cmbFrom.DrawMode = DrawMode.OwnerDrawFixed;
            cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFrom.FlatStyle = FlatStyle.Flat;
            cmbFrom.Font = new Font("Segoe UI", 12F);
            cmbFrom.FormattingEnabled = true;
            cmbFrom.ItemHeight = 30;
            cmbFrom.Location = new Point(12, 35);
            cmbFrom.Name = "cmbFrom";
            cmbFrom.Size = new Size(121, 36);
            cmbFrom.TabIndex = 4;
            // 
            // BtnConvert
            // 
            BtnConvert.BackColor = Color.Transparent;
            BtnConvert.ColorLeft = Color.DodgerBlue;
            BtnConvert.ColorRight = Color.DodgerBlue;
            BtnConvert.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            BtnConvert.FilterAlpha = 200;
            BtnConvert.FilterEnabled = false;
            BtnConvert.Image = Properties.Resources.currencyChange;
            BtnConvert.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            BtnConvert.IsElipse = false;
            BtnConvert.IsParallax = false;
            BtnConvert.Location = new Point(657, 35);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            BtnConvert.Size = new Size(45, 40);
            BtnConvert.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            BtnConvert.TabIndex = 3;
            BtnConvert.Text = "parrotPictureBox1";
            BtnConvert.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // cmbTo
            // 
            cmbTo.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTo.FlatStyle = FlatStyle.Flat;
            cmbTo.Font = new Font("Segoe UI", 12F);
            cmbTo.FormattingEnabled = true;
            cmbTo.ItemHeight = 30;
            cmbTo.Location = new Point(266, 36);
            cmbTo.Name = "cmbTo";
            cmbTo.Size = new Size(121, 36);
            cmbTo.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.White;
            txtAmount.BaseColor = Color.FromArgb(242, 246, 252);
            txtAmount.BorderColorA = Color.FromArgb(192, 196, 204);
            txtAmount.BorderColorB = Color.FromArgb(192, 196, 204);
            txtAmount.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            txtAmount.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            txtAmount.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            txtAmount.EnterKey = true;
            txtAmount.Font = new Font("Segoe UI", 12F);
            txtAmount.ForeColor = Color.Black;
            txtAmount.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            txtAmount.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            txtAmount.Location = new Point(139, 39);
            txtAmount.MaxNum = 999F;
            txtAmount.MinNum = 0F;
            txtAmount.Name = "txtAmount";
            txtAmount.Precision = 0;
            txtAmount.Size = new Size(120, 32);
            txtAmount.Step = 1F;
            txtAmount.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            txtAmount.TabIndex = 0;
            txtAmount.Text = "hopeNumeric1";
            txtAmount.ValueNumber = 0F;
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
            btnClose.Location = new Point(687, 0);
            btnClose.Name = "btnClose";
            btnClose.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnClose.Size = new Size(27, 26);
            btnClose.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            btnClose.TabIndex = 16;
            btnClose.Text = "btnClose";
            btnClose.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnClose.Click += btnClose_Click;
            // 
            // ConversorMoneda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 97);
            Controls.Add(dreamForm1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConversorMoneda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConversorMoneda";
            dreamForm1.ResumeLayout(false);
            dreamForm1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.DreamForm dreamForm1;
        private ReaLTaiizor.Controls.HopeComboBox cmbTo;
        private ReaLTaiizor.Controls.HopeNumeric txtAmount;
        private ReaLTaiizor.Controls.ParrotPictureBox BtnConvert;
        private ReaLTaiizor.Controls.HopeComboBox cmbFrom;
        private Label lblResult;
        private ReaLTaiizor.Controls.ParrotPictureBox btnClose;
    }
}