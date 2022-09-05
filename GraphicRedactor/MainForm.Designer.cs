namespace GraphicRedactor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureNew = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.trackBarBorder = new System.Windows.Forms.TrackBar();
            this.pictureSave = new System.Windows.Forms.PictureBox();
            this.pictureEllipse = new System.Windows.Forms.PictureBox();
            this.pictureText = new System.Windows.Forms.PictureBox();
            this.pictureRectangle = new System.Windows.Forms.PictureBox();
            this.picturePen = new System.Windows.Forms.PictureBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pictureNew);
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.trackBarBorder);
            this.panel1.Controls.Add(this.pictureSave);
            this.panel1.Controls.Add(this.pictureEllipse);
            this.panel1.Controls.Add(this.pictureText);
            this.panel1.Controls.Add(this.pictureRectangle);
            this.panel1.Controls.Add(this.picturePen);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 655);
            this.panel1.TabIndex = 1;
            // 
            // pictureNew
            // 
            this.pictureNew.BackColor = System.Drawing.Color.White;
            this.pictureNew.Image = global::GraphicRedactor.Properties.Resources._new;
            this.pictureNew.Location = new System.Drawing.Point(110, 209);
            this.pictureNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureNew.Name = "pictureNew";
            this.pictureNew.Size = new System.Drawing.Size(63, 69);
            this.pictureNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNew.TabIndex = 9;
            this.pictureNew.TabStop = false;
            this.pictureNew.Click += new System.EventHandler(this.pictureNew_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(172, 131);
            this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(47, 33);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "10";
            // 
            // trackBarBorder
            // 
            this.trackBarBorder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBarBorder.Location = new System.Drawing.Point(16, 131);
            this.trackBarBorder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBarBorder.Name = "trackBarBorder";
            this.trackBarBorder.Size = new System.Drawing.Size(156, 69);
            this.trackBarBorder.TabIndex = 5;
            this.trackBarBorder.Scroll += new System.EventHandler(this.trackBarBorder_Scroll);
            // 
            // pictureSave
            // 
            this.pictureSave.BackColor = System.Drawing.Color.White;
            this.pictureSave.Image = global::GraphicRedactor.Properties.Resources.save;
            this.pictureSave.Location = new System.Drawing.Point(32, 209);
            this.pictureSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureSave.Name = "pictureSave";
            this.pictureSave.Size = new System.Drawing.Size(69, 69);
            this.pictureSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSave.TabIndex = 7;
            this.pictureSave.TabStop = false;
            this.pictureSave.Click += new System.EventHandler(this.pictureSave_Click);
            // 
            // pictureEllipse
            // 
            this.pictureEllipse.BackColor = System.Drawing.Color.White;
            this.pictureEllipse.Image = global::GraphicRedactor.Properties.Resources.ellipse;
            this.pictureEllipse.Location = new System.Drawing.Point(110, 366);
            this.pictureEllipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureEllipse.Name = "pictureEllipse";
            this.pictureEllipse.Size = new System.Drawing.Size(63, 69);
            this.pictureEllipse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureEllipse.TabIndex = 4;
            this.pictureEllipse.TabStop = false;
            this.pictureEllipse.Click += new System.EventHandler(this.pictureEllipse_Click);
            // 
            // pictureText
            // 
            this.pictureText.BackColor = System.Drawing.Color.White;
            this.pictureText.Image = global::GraphicRedactor.Properties.Resources.text;
            this.pictureText.Location = new System.Drawing.Point(32, 366);
            this.pictureText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureText.Name = "pictureText";
            this.pictureText.Size = new System.Drawing.Size(69, 69);
            this.pictureText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureText.TabIndex = 3;
            this.pictureText.TabStop = false;
            this.pictureText.Click += new System.EventHandler(this.pictureText_Click);
            // 
            // pictureRectangle
            // 
            this.pictureRectangle.BackColor = System.Drawing.Color.White;
            this.pictureRectangle.Image = ((System.Drawing.Image)(resources.GetObject("pictureRectangle.Image")));
            this.pictureRectangle.Location = new System.Drawing.Point(110, 288);
            this.pictureRectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureRectangle.Name = "pictureRectangle";
            this.pictureRectangle.Size = new System.Drawing.Size(63, 69);
            this.pictureRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRectangle.TabIndex = 2;
            this.pictureRectangle.TabStop = false;
            this.pictureRectangle.Click += new System.EventHandler(this.pictureRectangle_Click);
            // 
            // picturePen
            // 
            this.picturePen.BackColor = System.Drawing.Color.White;
            this.picturePen.Image = global::GraphicRedactor.Properties.Resources.pencil;
            this.picturePen.Location = new System.Drawing.Point(32, 288);
            this.picturePen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picturePen.Name = "picturePen";
            this.picturePen.Size = new System.Drawing.Size(69, 69);
            this.picturePen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePen.TabIndex = 1;
            this.picturePen.TabStop = false;
            this.picturePen.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.Color.Black;
            this.labelColor.Location = new System.Drawing.Point(27, 17);
            this.labelColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(190, 105);
            this.labelColor.TabIndex = 0;
            this.labelColor.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(274, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 655);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redactor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox picturePen;
        private System.Windows.Forms.PictureBox pictureRectangle;
        private System.Windows.Forms.PictureBox pictureText;
        private System.Windows.Forms.PictureBox pictureEllipse;
        private System.Windows.Forms.TrackBar trackBarBorder;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.PictureBox pictureSave;
        private System.Windows.Forms.PictureBox pictureNew;
    }
}

