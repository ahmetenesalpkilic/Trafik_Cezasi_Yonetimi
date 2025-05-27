namespace Trafik_Cezasi_Yonetimi
{
    //Giri� Formu
    //Bu formda S�r�c� ve Polis giri�i i�in butonlar bulunmakta, hangi butona t�klad�g�nda g�re bilgiler isteniyor!
    public partial class Form1 : Form
    {
        bool polis = false;
        bool s�r�c� = false;
        string polisKullan�c�ad� = "admin";
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
            label5.Visible = true; //butonlar� aktif ediyorum

            textBox2.UseSystemPasswordChar = true; //textboxa �ifre gizlili�i(*****)



        }


        private void button2_Click(object sender, EventArgs e)// S�r�c� butonu
        {
            s�r�c� = true;
            button1.Visible = false; button2.Visible = false;
            textBox2.Visible = true; button3.Visible = true; label5.Visible = true;
            label4.Visible = true; 
            label5.Text = "S�r�c� Giri�i i�in gerekli bilgileri giriniz!";
            label4.Text = "TC kimlik no:";
        }

        private void button3_Click(object sender, EventArgs e)//Onayla butonu
        {
            if (polis) // polis butonuna t�kland�ysa eger
            {
                if (textBox1.Text == polisKullan�c�ad� && textBox2.Text == polisSifre) //eger polis kullan�c� sifre dogruysa ilerle
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� yada �ifre yanl��", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
         

             if (s�r�c�) // s�r�c� butonuna t�kland�ysa eger
                {
                    Form3 f3=new Form3(textBox2.Text.Trim());
                    this.Hide();
                    f3.ShowDialog();
                    this.Close()   ;
                    }


        }

        
    }
}
