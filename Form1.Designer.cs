namespace stajornek6
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
            btngiris = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btngiris
            // 
            btngiris.FlatStyle = FlatStyle.Popup;
            btngiris.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btngiris.Location = new Point(273, 251);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(146, 32);
            btngiris.TabIndex = 5;
            btngiris.Text = "Giriş Yap";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(243, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 26);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(243, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 26);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(90, 153);
            label1.Name = "label1";
            label1.Size = new Size(128, 24);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AntiqueWhite;
            label2.Font = new Font("Franklin Gothic Heavy", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(90, 200);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 7;
            label2.Text = "Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 454);
            label3.Name = "label3";
            label3.Size = new Size(182, 17);
            label3.TabIndex = 8;
            label3.Text = "*Kullanıcı adı: admin, Şifre: 1234";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(565, 480);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btngiris);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btngiris;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}