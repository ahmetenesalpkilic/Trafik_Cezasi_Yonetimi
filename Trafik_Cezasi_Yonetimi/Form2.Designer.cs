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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(266, 73);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(444, 67);
            label1.TabIndex = 1;
            label1.Text = "POLİS EKRANI";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(176, 237);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 6;
            label3.Text = "Ceza Türü:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(407, 237);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 7;
            label2.Text = "Sürücü TC no:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(389, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 27);
            textBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(403, 357);
            button1.Name = "button1";
            button1.Size = new Size(165, 32);
            button1.TabIndex = 9;
            button1.Text = "Ceza Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(362, 488);
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
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(301, 455);
            label4.Name = "label4";
            label4.Size = new Size(367, 23);
            label4.TabIndex = 11;
            label4.Text = "TC'si girilen sürücünün cezalarını raporla";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(617, 276);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(703, 237);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 13;
            label5.Text = "Tarih:";
            // 
            // button4
            // 
            button4.Location = new Point(21, 24);
            button4.Name = "button4";
            button4.Size = new Size(148, 30);
            button4.TabIndex = 14;
            button4.Text = "Geri ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 673);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Polis Paneli";
            Load += Form2_Load;
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
    }
}