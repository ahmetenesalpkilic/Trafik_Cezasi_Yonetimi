using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trafik_Cezasi_Yonetimi
{
    public partial class Form2 : Form
    {
        public string cezaAdı;
        public string masaUstu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //masaüstüyolu
        string klasorad = "Trafik_Ceza_Yönetimi";
        string raporklasor = "Rapor_Klasor";

        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Park"); comboBox1.Items.Add("Hız"); comboBox1.Items.Add("Kırmızı");
            TumLabellariSaydamYap(this);

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        bool HepsiSayiMi(string veri) //string sayı mı kontrol
        {
            return veri.All(char.IsDigit);
        }




        private void kisiBelgeOlustur(string Tc, Ceza ceza) //Kişiye belge olusturur
        {
            string tc = Tc + ".txt";
            string klasorYol = Path.Combine(masaUstu, klasorad);
            string metinYol = Path.Combine(klasorYol, tc); //metin belgesının yolu

            using (StreamWriter sw = File.AppendText(metinYol))
            { // metin belgesi yoksa olusturur,varsa üstüne yazar

                sw.WriteLine(ceza.CezaTuru + ":" + ceza.SurucuTC + ":" + ceza.Tarih.ToString("dd.MM.yyyy") + ":" +
                    ceza.odendiMi + ":" + ceza.CezaTutarı);
            }
            //kişinin MetinBelgesine ceza bilgileri yazıldı

        }

        public class Ceza // Ceza Class'ı
        {
            public string SurucuTC { get; set; }
            public DateTime Tarih { get; set; }
            public virtual int CezaTutarı { get; set; }
            public virtual string CezaTuru { get; set; }

            public bool odendiMi = false;

            public Ceza(string tc, DateTime tarih)
            {
                SurucuTC = tc;
                Tarih = tarih;
            }

        }
        public class ParkCeza : Ceza
        {
            public override int CezaTutarı => 993;
            public override string CezaTuru => "Park_Cezası";

            public ParkCeza(string tc, DateTime tarih) : base(tc, tarih) { }
        }

        public class HizCeza : Ceza
        {
            public override int CezaTutarı => 4552;
            public override string CezaTuru => "Hız_Cezası";
            public HizCeza(string tc, DateTime tarih) : base(tc, tarih) { }
        }

        public class KirmiziCeza : Ceza
        {
            public override int CezaTutarı => 2168;
            public override string CezaTuru => "Kırmızı_Cezası";

            public KirmiziCeza(string tc, DateTime tarih) : base(tc, tarih) { }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Ceza türü secme
        {
            cezaAdı = comboBox1.SelectedItem.ToString(); // 
        }



        private void button1_Click(object sender, EventArgs e) //Ceza Ekle Butonu
        {

            if (string.IsNullOrEmpty(cezaAdı)) //Ceza türü secılmedıyse
            {
                MessageBox.Show("Lütfen bir ceza türü seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))//tc no girilmediyse
            {
                MessageBox.Show("Lütfen Sürücü TC no girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text.Length != 11 || !HepsiSayiMi(textBox1.Text))
            {
                MessageBox.Show("Lütfen yalnızca rakamlardan oluşan 11 haneli bir değer girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (dateTimePicker1.Value > DateTime.Now)// tarih secilmediyse
            {
                MessageBox.Show("Tarih bugünden ileri olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //kontroller yapıldı
            Ceza yeniCeza = null;

            if (cezaAdı == "Park") { yeniCeza = new ParkCeza(textBox1.Text, dateTimePicker1.Value); }
            else if (cezaAdı == "Hız") { yeniCeza = new HizCeza(textBox1.Text, dateTimePicker1.Value); }
            else if (cezaAdı == "Kırmızı") { yeniCeza = new KirmiziCeza(textBox1.Text, dateTimePicker1.Value); }

            // nesne olusturup yeniCeza degıskenıne atandı

            kisiBelgeOlustur(yeniCeza.SurucuTC, yeniCeza);

            MessageBox.Show("Ceza başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void button2_Click(object sender, EventArgs e)// Raporla Butonu 
        {
            string klasorYol = Path.Combine(masaUstu, klasorad, textBox1.Text + ".txt");// TCY klasöründen kişinin bilgilerini çekiceğiz

            string raporKyol = Path.Combine(masaUstu, klasorad, raporklasor, textBox1.Text + "rapor" + ".txt");
            //Rapor klasörüne kişinin adına bir metin belgesi oluşturuyoruz


            StreamWriter sw = new StreamWriter(raporKyol);


            if (!File.Exists(klasorYol))
            {
                sw.WriteLine("Sürücü Daha Önce Ceza Almamış!");
                sw.Close();
                MessageBox.Show("Sürücünün daha önce cezası yok.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Rapor başarılı şekilde oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StreamReader sr = new StreamReader(klasorYol);
            string temp;
            while ((temp = sr.ReadLine()) != null)
            {
                string[] dizi = temp.Split(':');
                if (dizi[3] == "False") { dizi[3] = "Ödenmedi"; } else { dizi[3] = "Ödendi"; }
                //Cezanın ödenme bool değişkenine string atadık

                sw.WriteLine("--------------------------------------------------------");
                sw.WriteLine("Ceza türü :" + dizi[0] + "\nSürücü TC no :" + dizi[1] + "\nCeza tarihi :" + dizi[2]
                    + "\nCeza Ödeme Durumu :" + dizi[3] + "\nCezanın tutarı :" + dizi[4]);


            }
            sw.WriteLine("--------------------------------------------------------");
            MessageBox.Show("Rapor başarılı şekilde oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sw.Close();
            sr.Close();

            //sadece tc gırdııgnde eger yoksa rapor bulunamadı demesı gerekırken uygulama cokuyo onu duzlet

        }



        private void button4_Click(object sender, EventArgs e) // Geri Butonu
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(170, Color.Black); // 170 saydamlık değeri 
        }

        private void label6_Click(object sender, EventArgs e) // kapatma labeli X
        {
            this.Close();
        }
    }
}