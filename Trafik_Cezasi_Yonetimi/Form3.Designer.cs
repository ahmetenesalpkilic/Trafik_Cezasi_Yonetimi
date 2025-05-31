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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            listBox1 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            button4 = new Button();
            label6 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(204, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(409, 67);
            label1.TabIndex = 2;
            label1.Text = "Sürücü Ekranı";
            // 
            // button1
            // 
            button1.Font = new Font("Candara", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(548, 165);
            button1.Name = "button1";
            button1.Size = new Size(228, 29);
            button1.TabIndex = 3;
            button1.Text = "Ceza Öde";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 166);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(446, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Candara", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(235, 121);
            label5.Name = "label5";
            label5.Size = new Size(287, 24);
            label5.TabIndex = 11;
            label5.Text = "Ödemek İstediğiniz Cezayı Seçin!";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Candara", 12F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 24;
            listBox1.Location = new Point(57, 381);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(690, 124);
            listBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Candara", 12F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(183, 329);
            button2.Name = "button2";
            button2.Size = new Size(434, 29);
            button2.TabIndex = 13;
            button2.Text = "Görüntüle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(241, 268);
            label2.Name = "label2";
            label2.Size = new Size(310, 48);
            label2.TabIndex = 14;
            label2.Text = "Toplam Ceza Miktarını Görmek için \r\n     görüntüle butonuna tıklayın!";
            // 
            // button4
            // 
            button4.Font = new Font("Candara", 12F, FontStyle.Bold);
            button4.Location = new Point(21, 24);
            button4.Name = "button4";
            button4.Size = new Size(148, 30);
            button4.TabIndex = 15;
            button4.Text = "Geri ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(81, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 562);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1006, 673);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sürücü Paneli";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button4;
        private Label label6;
        private Panel panel1;
    }
}