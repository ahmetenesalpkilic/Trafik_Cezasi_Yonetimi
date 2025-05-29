namespace Trafik_Cezasi_Yonetimi
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
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(274, 81);
            label1.Name = "label1";
            label1.Size = new Size(430, 67);
            label1.TabIndex = 0;
            label1.Text = "GİRİŞ EKRANI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(377, 417);
            label2.Name = "label2";
            label2.Size = new Size(233, 23);
            label2.TabIndex = 1;
            label2.Text = "Lütfen giris türünü seciniz";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(1031, 203);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(215, 300);
            button1.Name = "button1";
            button1.Size = new Size(236, 75);
            button1.TabIndex = 3;
            button1.Text = "Polis Girişi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(509, 300);
            button2.Name = "button2";
            button2.Size = new Size(236, 75);
            button2.TabIndex = 4;
            button2.Text = "Sürücü Girişi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(173, 338);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 5;
            label3.Text = "Kullanıcı adı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 364);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 364);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(690, 352);
            button3.Name = "button3";
            button3.Size = new Size(169, 51);
            button3.TabIndex = 8;
            button3.Text = "Onayla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(385, 338);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 9;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(324, 417);
            label5.Name = "label5";
            label5.Size = new Size(328, 23);
            label5.TabIndex = 10;
            label5.Text = "Polis Girişi için gerekli bilgileri giriniz!";
            // 
            // button4
            // 
            button4.Location = new Point(21, 24);
            button4.Name = "button4";
            button4.Size = new Size(148, 30);
            button4.TabIndex = 11;
            button4.Text = "Geri ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 673);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Button button4;
    }
}
