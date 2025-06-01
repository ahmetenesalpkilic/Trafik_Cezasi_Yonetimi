namespace Trafik_Cezasi_Yonetimi
{
    //Giriş Formu
    //Bu sormda Sürücü ve Polis giriþi için butonlar bulunmakta, hangi butona týkladýgýnda göre bilgiler isteniyor!
    public partial class Form1 : Form
    {
        bool polis = false;
        bool sürücü = false;
        string polisKullaniciadi = "admin";
        string polisSifre = "1234";
        public string masaUstu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //masaüstüyolu
        string klasorad = "Trafik_Ceza_Yönetimi";
        string raporklasor = "Rapor_Klasor";
        string klasorYol;
        string klasorRapor;
        public Form1()
        {
            InitializeComponent();
            TumLabellariSaydamYap(this);

            label4.Visible = false; label3.Visible = false; label5.Visible = false;
            textBox1.Visible = false; textBox2.Visible = false; button3.Visible = false;
            button4.Visible = false;

   


            TCYklasorOlustur(); //TrafikCezaYonetımı klasoru olustur


        }



        private void TCYklasorOlustur()
        {
            klasorYol = Path.Combine(masaUstu, klasorad);// Trafik Ceza Yonetımı klasörünü yoksa olusturur

            if (!Directory.Exists(klasorYol))
            { //eger klasör yoksa olustur
                Directory.CreateDirectory(klasorYol);
            }

            klasorRapor = Path.Combine(klasorYol, raporklasor); //Rapor adlı klasör TCY klasöründe yoksa olustur
            if (!Directory.Exists(klasorRapor))
            { //eger klasör yoksa olustur
                Directory.CreateDirectory(klasorRapor);
            }
        }



        bool HepsiSayiMi(string veri) //string sayı mı kontrol
        {
            return veri.All(char.IsDigit);
        }


        bool tcKontrol(string tcNo) // TC 'yi gercekten kontrol edıyoruz
        {
            int[] tcDizi = tcNo.Select(c => int.Parse(c.ToString())).ToArray(); //Lınq mantıgı ıle cekıyorum

            if (tcDizi.Length != 11)
            {
                MessageBox.Show("Girdiğiniz TC no 11 haneli değil ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (tcDizi[0] == 0) {
                MessageBox.Show("Girdiğiniz TC no 0 ile başlayamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            int tekTop = 0, ciftTop = 0; // dizi 0 dan basladıgı ıcın tekToplam dızıdekı cıflerı cıfTop dizideki tek indislilerii toplayacak

            for(int i = 0; i < 9; i++)
            {
                if (i % 2 == 0){tekTop += tcDizi[i]; }

                else { ciftTop += tcDizi[i]; }
            }

            int onuncuHane = ((tekTop * 7) - ciftTop) % 10;
            if (onuncuHane < 0) onuncuHane += 10;

            if (tcDizi[9] != onuncuHane)
            {
                MessageBox.Show("Girdiğiniz TC no geçerli değil (10. hane hatalı).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int onhaneToplam = 0;
            for (int i = 0; i < 10; i++)
            {
                onhaneToplam += tcDizi[i]; //ilk 10 haneyi topluyoruz
            }

            if (tcDizi[10] != onhaneToplam % 10)
            {
                MessageBox.Show("Girdiğiniz TC no geçerli değil (11. hane hatalı).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }



        private void button1_Click(object sender, EventArgs e)// Polis Butonu
        {
            label4.Text = "Sifre:"; label4.Visible = true;
            polis = true;
            button1.Visible = false; button2.Visible = false;
            button4.Visible = true; //Geri al butonu aktiflestirildi
            label3.Visible = true;
            textBox1.Visible = true; textBox2.Visible = true; button3.Visible = true;// butonlari  aktif ediyorum
            label2.Visible = false; //surucu  label
            label5.Text = "Polis Girisi icin gerekli bilgileri giriniz.";
            label5.Visible = true; //polis label

            textBox2.UseSystemPasswordChar = true; //textboxa sifre  gizliligi(*****)
        }




        private void button2_Click(object sender, EventArgs e)// Sürücü butonu
        {
            sürücü = true;
            button1.Visible = false; button2.Visible = false;
            button4.Visible = true; //Geri al butonu aktiflestirildi
            textBox2.Visible = true; button3.Visible = true; label5.Visible = true;
            label4.Visible = true;
            label5.Text = "Sürücü Girisi icin gerekli bilgileri giriniz!";
            label4.Text = "TC kimlik no:";
        }




        private void button3_Click(object sender, EventArgs e)//Onayla butonu 
        {
            if (polis) // polis butonuna tiklandiysa eger
            {
                if (textBox1.Text == polisKullaniciadi && textBox2.Text == polisSifre) //eger polis kullanici sifre dogruysa ilerle
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanici adi yada Sifre yanlis", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //---------------------------

            if (sürücü) // sürücü butonuna tiklandiysa eger
            {

                string surucuDyol = Path.Combine(klasorYol, textBox2.Text + ".txt");
                string tcKimlik = textBox2.Text.Trim();

                if (!HepsiSayiMi(tcKimlik))
                {
                    MessageBox.Show("Girdiğiniz TC no sadece sayılardan oluşmalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!tcKontrol(tcKimlik))
                {
                    return; // Eğer TC hatalıysa buradan çık
                }


                if (!File.Exists(surucuDyol))//girdiği tc'ye ait metin belgesi yoksa message box donder
                {
                    MessageBox.Show("Girdiğiniz Tc Kimlik no'ya ait bir ceza gecmisi bulunamadi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

              
                Form3 f3 = new Form3(tcKimlik);
                this.Hide();
                f3.ShowDialog();
                this.Close();
            }
        }

        private void TumLabellariSaydamYap(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Label)
                {
                    c.BackColor = Color.Transparent;
                }
                else if (c.HasChildren)
                {
                    TumLabellariSaydamYap(c); // İç içe kontroller varsa onlara da uygula
                }
            }
        }



        private void button4_Click(object sender, EventArgs e)// Geri butonu
        {
            sürücü = false; polis = false;
            label2.Visible = true; //Buton seciniz label
            label4.Visible = false; label3.Visible = false; label5.Visible = false;
            textBox1.Visible = false; textBox2.Visible = false;
            button4.Visible = false; button3.Visible = false;
            textBox2.UseSystemPasswordChar = false;

            button1.Visible = true;
            button2.Visible = true;
            //Surucu butonu ve Polis butonu aktif

        }

       
       
        private void label6_Click(object sender, EventArgs e) // kapatma labeli X
        {
            this.Close();
        }
    }
    public class TransparentPanel : Panel //Panelın bozulmalarını engellemek ıcın
    {
        public TransparentPanel()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);

            this.BackColor = Color.Transparent;
        }
    }
}