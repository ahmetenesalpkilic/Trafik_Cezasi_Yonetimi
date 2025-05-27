namespace Trafik_Cezasi_Yonetimi
{
    //Giriþ Formu
    //Bu formda Sürücü ve Polis giriþi için butonlar bulunmakta, hangi butona týkladýgýnda göre bilgiler isteniyor!
    public partial class Form1 : Form
    {
        bool polis = false;
        bool sürücü = false;
        string polisKullanýcýadý = "admin";
        string polisSifre = "1234";

        public Form1()
        {
            InitializeComponent();
            label4.Visible = false; label3.Visible = false; label5.Visible = false;
            textBox1.Visible = false; textBox2.Visible = false; button3.Visible = false;
        }



        private void button1_Click(object sender, EventArgs e)// Polis Butonu
        {
            button1.Visible = false; button2.Visible = false;
            polis = true;
            label4.Visible = true; label3.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true; button3.Visible = true; 
            label5.Visible = true; //butonlarý aktif ediyorum

            textBox2.UseSystemPasswordChar = true; //textboxa þifre gizliliði(*****)



        }


        private void button2_Click(object sender, EventArgs e)// Sürücü butonu
        {
            sürücü = true;
            button1.Visible = false; button2.Visible = false;
            textBox2.Visible = true; button3.Visible = true; label5.Visible = true;
            label4.Visible = true; 
            label5.Text = "Sürücü Giriþi için gerekli bilgileri giriniz!";
            label4.Text = "TC kimlik no:";
        }

        private void button3_Click(object sender, EventArgs e)//Onayla butonu
        {
            if (polis) // polis butonuna týklandýysa eger
            {
                if (textBox1.Text == polisKullanýcýadý && textBox2.Text == polisSifre) //eger polis kullanýcý sifre dogruysa ilerle
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanýcý adý yada þifre yanlýþ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
         

             if (sürücü) // sürücü butonuna týklandýysa eger
                {
                    Form3 f3=new Form3(textBox2.Text.Trim());
                    this.Hide();
                    f3.ShowDialog();
                    this.Close()   ;
                    }


        }

        
    }
}
