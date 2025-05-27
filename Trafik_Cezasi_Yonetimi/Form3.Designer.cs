namespace Trafik_Cezasi_Yonetimi
{
    partial class Form3
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(250, 74);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(523, 67);
            label1.TabIndex = 2;
            label1.Text = "SÜRÜCÜ EKRANI";
            // 
            // button1
            // 
            button1.Location = new Point(644, 207);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 3;
            button1.Text = "Ceza Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(103, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(453, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(331, 163);
            label5.Name = "label5";
            label5.Size = new Size(304, 23);
            label5.TabIndex = 11;
            label5.Text = "Ödemek İstediğiniz Cezayı Seçin!";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(583, 407);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(326, 144);
            listBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(220, 460);
            button2.Name = "button2";
            button2.Size = new Size(177, 29);
            button2.TabIndex = 13;
            button2.Text = "Görüntüle";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(331, 351);
            label2.Name = "label2";
            label2.Size = new Size(324, 46);
            label2.TabIndex = 14;
            label2.Text = "Toplam Ceza Miktarını Görmek için \r\n     görüntüle butonuna tıklayın!";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 666);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Sürücü Paneli";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
        private ListBox listBox1;
        private Button button2;
        private Label label2;
    }
}