namespace Lab_6
{
    partial class Form1
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
            this.FiguresBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.textBoxY4 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelX3 = new System.Windows.Forms.Label();
            this.labelY3 = new System.Windows.Forms.Label();
            this.labelX4 = new System.Windows.Forms.Label();
            this.labelY4 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FiguresBox
            // 
            this.FiguresBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FiguresBox.FormattingEnabled = true;
            this.FiguresBox.ItemHeight = 20;
            this.FiguresBox.Location = new System.Drawing.Point(12, 12);
            this.FiguresBox.Name = "FiguresBox";
            this.FiguresBox.ScrollAlwaysVisible = true;
            this.FiguresBox.Size = new System.Drawing.Size(406, 664);
            this.FiguresBox.TabIndex = 0;
            this.FiguresBox.SelectedIndexChanged += new System.EventHandler(this.FiguresBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(424, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 358);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Location = new System.Drawing.Point(778, 376);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(158, 51);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.Location = new System.Drawing.Point(778, 433);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(158, 51);
            this.ButtonDelete.TabIndex = 4;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX1.Location = new System.Drawing.Point(451, 376);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 26);
            this.textBoxX1.TabIndex = 5;
            this.textBoxX1.Visible = false;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY1.Location = new System.Drawing.Point(557, 376);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 26);
            this.textBoxY1.TabIndex = 6;
            this.textBoxY1.Visible = false;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX2.Location = new System.Drawing.Point(451, 408);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 26);
            this.textBoxX2.TabIndex = 7;
            this.textBoxX2.Visible = false;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY2.Location = new System.Drawing.Point(557, 408);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 26);
            this.textBoxY2.TabIndex = 8;
            this.textBoxY2.Visible = false;
            // 
            // textBoxX3
            // 
            this.textBoxX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX3.Location = new System.Drawing.Point(451, 440);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(100, 26);
            this.textBoxX3.TabIndex = 9;
            this.textBoxX3.Visible = false;
            // 
            // textBoxY3
            // 
            this.textBoxY3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY3.Location = new System.Drawing.Point(557, 440);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(100, 26);
            this.textBoxY3.TabIndex = 10;
            this.textBoxY3.Visible = false;
            // 
            // textBoxX4
            // 
            this.textBoxX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX4.Location = new System.Drawing.Point(451, 472);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(100, 26);
            this.textBoxX4.TabIndex = 11;
            this.textBoxX4.Visible = false;
            // 
            // textBoxY4
            // 
            this.textBoxY4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY4.Location = new System.Drawing.Point(557, 472);
            this.textBoxY4.Name = "textBoxY4";
            this.textBoxY4.Size = new System.Drawing.Size(100, 26);
            this.textBoxY4.TabIndex = 12;
            this.textBoxY4.Visible = false;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(420, 378);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(29, 20);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "X1";
            this.labelX1.Visible = false;
            // 
            // labelY1
            // 
            this.labelY1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(663, 378);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(29, 20);
            this.labelY1.TabIndex = 14;
            this.labelY1.Text = "Y1";
            this.labelY1.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(420, 408);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(29, 20);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "X2";
            this.labelX2.Visible = false;
            // 
            // labelY2
            // 
            this.labelY2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(663, 411);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(29, 20);
            this.labelY2.TabIndex = 16;
            this.labelY2.Text = "Y2";
            this.labelY2.Visible = false;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(420, 442);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(29, 20);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "X3";
            this.labelX3.Visible = false;
            // 
            // labelY3
            // 
            this.labelY3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY3.AutoSize = true;
            this.labelY3.Location = new System.Drawing.Point(663, 443);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(29, 20);
            this.labelY3.TabIndex = 18;
            this.labelY3.Text = "Y3";
            this.labelY3.Visible = false;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelX4.AutoSize = true;
            this.labelX4.Location = new System.Drawing.Point(420, 473);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(29, 20);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "X4";
            this.labelX4.Visible = false;
            // 
            // labelY4
            // 
            this.labelY4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelY4.AutoSize = true;
            this.labelY4.Location = new System.Drawing.Point(663, 476);
            this.labelY4.Name = "labelY4";
            this.labelY4.Size = new System.Drawing.Size(29, 20);
            this.labelY4.TabIndex = 20;
            this.labelY4.Text = "Y4";
            this.labelY4.Visible = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Location = new System.Drawing.Point(451, 505);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(206, 57);
            this.buttonSubmit.TabIndex = 21;
            this.buttonSubmit.Text = "Подтвердить \r\nввод";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Location = new System.Drawing.Point(778, 555);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(158, 57);
            this.buttonDown.TabIndex = 22;
            this.buttonDown.Text = "Переместить\r\nниже\r\n";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Location = new System.Drawing.Point(778, 490);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(158, 59);
            this.buttonUp.TabIndex = 23;
            this.buttonUp.Text = "Переместить \r\nвыше";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 687);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelY4);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxY4);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxY3);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FiguresBox);
            this.Name = "Form1";
            this.Text = "Добавить фигуру";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FiguresBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        public System.Windows.Forms.TextBox textBoxX1;
        public System.Windows.Forms.TextBox textBoxY1;
        public System.Windows.Forms.TextBox textBoxX2;
        public System.Windows.Forms.TextBox textBoxY2;
        public System.Windows.Forms.TextBox textBoxX3;
        public System.Windows.Forms.TextBox textBoxY3;
        public System.Windows.Forms.TextBox textBoxX4;
        public System.Windows.Forms.TextBox textBoxY4;
        public System.Windows.Forms.Label labelX1;
        public System.Windows.Forms.Label labelY1;
        public System.Windows.Forms.Label labelX2;
        public System.Windows.Forms.Label labelY2;
        public System.Windows.Forms.Label labelX3;
        public System.Windows.Forms.Label labelY3;
        public System.Windows.Forms.Label labelX4;
        public System.Windows.Forms.Label labelY4;
        public System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
    }
}

