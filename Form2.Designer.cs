namespace stajornek6
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtad = new TextBox();
            txtno = new TextBox();
            txtvize = new TextBox();
            txtfinal = new TextBox();
            lstad = new ListBox();
            lstno = new ListBox();
            lstvize = new ListBox();
            lstfinal = new ListBox();
            lstsonuc = new ListBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 126);
            label2.Name = "label2";
            label2.Size = new Size(96, 29);
            label2.TabIndex = 1;
            label2.Text = "Numara:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 217);
            label3.Name = "label3";
            label3.Size = new Size(56, 29);
            label3.TabIndex = 2;
            label3.Text = "Vize:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 259);
            label4.Name = "label4";
            label4.Size = new Size(65, 29);
            label4.TabIndex = 3;
            label4.Text = "Final:";
            // 
            // txtad
            // 
            txtad.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtad.Location = new Point(173, 84);
            txtad.Name = "txtad";
            txtad.Size = new Size(238, 26);
            txtad.TabIndex = 4;
            // 
            // txtno
            // 
            txtno.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtno.Location = new Point(173, 133);
            txtno.Name = "txtno";
            txtno.Size = new Size(238, 26);
            txtno.TabIndex = 5;
            // 
            // txtvize
            // 
            txtvize.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtvize.Location = new Point(173, 224);
            txtvize.Name = "txtvize";
            txtvize.Size = new Size(238, 26);
            txtvize.TabIndex = 6;
            // 
            // txtfinal
            // 
            txtfinal.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfinal.Location = new Point(173, 266);
            txtfinal.Name = "txtfinal";
            txtfinal.Size = new Size(238, 26);
            txtfinal.TabIndex = 7;
            // 
            // lstad
            // 
            lstad.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstad.FormattingEnabled = true;
            lstad.ItemHeight = 20;
            lstad.Location = new Point(25, 410);
            lstad.Name = "lstad";
            lstad.Size = new Size(215, 224);
            lstad.TabIndex = 8;
            // 
            // lstno
            // 
            lstno.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstno.FormattingEnabled = true;
            lstno.ItemHeight = 20;
            lstno.Location = new Point(306, 410);
            lstno.Name = "lstno";
            lstno.Size = new Size(215, 224);
            lstno.TabIndex = 9;
            // 
            // lstvize
            // 
            lstvize.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstvize.FormattingEnabled = true;
            lstvize.ItemHeight = 20;
            lstvize.Location = new Point(607, 410);
            lstvize.Name = "lstvize";
            lstvize.Size = new Size(215, 224);
            lstvize.TabIndex = 10;
            // 
            // lstfinal
            // 
            lstfinal.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstfinal.FormattingEnabled = true;
            lstfinal.ItemHeight = 20;
            lstfinal.Location = new Point(897, 410);
            lstfinal.Name = "lstfinal";
            lstfinal.Size = new Size(215, 224);
            lstfinal.TabIndex = 11;
            // 
            // lstsonuc
            // 
            lstsonuc.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstsonuc.FormattingEnabled = true;
            lstsonuc.HorizontalScrollbar = true;
            lstsonuc.ItemHeight = 20;
            lstsonuc.Location = new Point(437, 84);
            lstsonuc.Name = "lstsonuc";
            lstsonuc.Size = new Size(675, 264);
            lstsonuc.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(173, 306);
            button1.Name = "button1";
            button1.Size = new Size(105, 48);
            button1.TabIndex = 13;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(982, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(306, 306);
            button2.Name = "button2";
            button2.Size = new Size(105, 48);
            button2.TabIndex = 15;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(95, 387);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 16;
            label5.Text = "Ad-Soyad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(373, 387);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 17;
            label6.Text = "Numara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(677, 387);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 18;
            label7.Text = "Vize Notu";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(964, 387);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 19;
            label8.Text = "Final Notu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(437, 64);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 20;
            label9.Text = "Sonuç:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1137, 661);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lstsonuc);
            Controls.Add(lstfinal);
            Controls.Add(lstvize);
            Controls.Add(lstno);
            Controls.Add(lstad);
            Controls.Add(txtfinal);
            Controls.Add(txtvize);
            Controls.Add(txtno);
            Controls.Add(txtad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtad;
        private TextBox txtno;
        private TextBox txtvize;
        private TextBox txtfinal;
        private ListBox lstad;
        private ListBox lstno;
        private ListBox lstvize;
        private ListBox lstfinal;
        private ListBox lstsonuc;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}