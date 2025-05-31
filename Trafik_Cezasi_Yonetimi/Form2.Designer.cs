namespace Trafik_Cezasi_Yonetimi
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            button4 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(230, 28);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(349, 67);
            label1.TabIndex = 1;
            label1.Text = "Polis Ekranı";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(95, 183);
            label3.Name = "label3";
            label3.Size = new Size(99, 24);
            label3.TabIndex = 6;
            label3.Text = "Ceza Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(329, 183);
            label2.Name = "label2";
            label2.Size = new Size(127, 24);
            label2.TabIndex = 7;
            label2.Text = "Sürücü TC no:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(308, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Candara", 12F, FontStyle.Bold);
            button1.Location = new Point(178, 278);
            button1.Name = "button1";
            button1.Size = new Size(463, 66);
            button1.TabIndex = 9;
            button1.Text = "Ceza Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Candara", 12F, FontStyle.Bold);
            button2.Location = new Point(288, 434);
            button2.Name = "button2";
            button2.Size = new Size(222, 60);
            button2.TabIndex = 10;
            button2.Text = "Raporla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(227, 401);
            label4.Name = "label4";
            label4.Size = new Size(357, 24);
            label4.TabIndex = 11;
            label4.Text = "TC'si girilen sürücünün cezalarını raporla";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(536, 222);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(622, 183);
            label5.Name = "label5";
            label5.Size = new Size(59, 24);
            label5.TabIndex = 13;
            label5.Text = "Tarih:";
            // 
            // button4
            // 
            button4.Font = new Font("Candara", 12F, FontStyle.Bold);
            button4.Location = new Point(21, 24);
            button4.Name = "button4";
            button4.Size = new Size(148, 30);
            button4.TabIndex = 14;
            button4.Text = "Geri ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(81, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 562);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(944, 9);
            label6.Name = "label6";
            label6.Size = new Size(50, 57);
            label6.TabIndex = 16;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 673);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polis Paneli";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Button button4;
        private Panel panel1;
        private Label label6;
    }
}