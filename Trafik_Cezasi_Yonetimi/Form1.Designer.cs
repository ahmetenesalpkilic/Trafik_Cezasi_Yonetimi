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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel1 = new Panel();
            button4 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(251, 35);
            label1.Name = "label1";
            label1.Size = new Size(341, 67);
            label1.TabIndex = 0;
            label1.Text = "Giriş Formu\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(297, 344);
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
            button1.Font = new Font("Candara", 12F, FontStyle.Bold);
            button1.Location = new Point(135, 227);
            button1.Name = "button1";
            button1.Size = new Size(236, 75);
            button1.TabIndex = 3;
            button1.Text = "Polis Girişi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Candara", 12F, FontStyle.Bold);
            button2.Location = new Point(429, 227);
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
            label3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(93, 265);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 5;
            label3.Text = "Kullanıcı adı:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 291);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 27);
            textBox2.TabIndex = 7;
            // 
            // button3
            // 
            button3.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(607, 279);
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
            label4.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(305, 265);
            label4.Name = "label4";
            label4.Size = new Size(55, 24);
            label4.TabIndex = 9;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(245, 347);
            label5.Name = "label5";
            label5.Size = new Size(328, 23);
            label5.TabIndex = 10;
            label5.Text = "Polis Girişi için gerekli bilgileri giriniz!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(81, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(837, 542);
            panel1.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.Font = new Font("Candara", 12F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(21, 24);
            button4.Name = "button4";
            button4.Size = new Size(148, 30);
            button4.TabIndex = 11;
            button4.Text = "Geri ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(944, 7);
            label6.Name = "label6";
            label6.Size = new Size(50, 57);
            label6.TabIndex = 11;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 673);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(checkedListBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Ekranı";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Button button4;
        private Label label6;
    }
}
