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
        public string masaUstu=Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //masaüstüyolu
        string klasorad = "Trafik_Ceza_Yönetimi";
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("Park"); comboBox1.Items.Add("Hız"); comboBox1.Items.Add("Kırmızı");
            TCYklasorOlustur(); //TrafikCezaYonetımı klasoru olustur
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        bool HepsiSayiMi(string veri) //string sayı mı kontrol
        {
            return veri.All(char.IsDigit);
        }


        private void TCYklasorOlustur()
        {
            string klasorYol=Path.Combine(masaUstu, klasorad);

            if (!Directory.Exists(klasorYol)){ //eger klasör yoksa olustur
                Directory.CreateDirectory(klasorYol);
            }
        }

        private void kisiBelgeOlustur(string Tc,Ceza ceza) //Kişiye belge olusturur
        {
            string tc = Tc + ".txt";
            string klasorYol = Path.Combine(masaUstu, klasorad);
            string metinYol = Path.Combine(klasorYol, tc); //metin belgesının yolu

            using (StreamWriter sw = File.AppendText(metinYol)) { // metin belgesi yoksa olusturur,varsa üstüne yazar

            sw.WriteLine(ceza.CezaTuru + ":" + ceza.SurucuTC + ":" + ceza.Tarih.ToString("dd.MM.yyyy") + ":" + ceza.CezaTutarı);
            }
            //kişinin MetinBelgesine ceza bilgileri yazıldı

        }

        public class Ceza // Ceza Class'ı
        {
            public string SurucuTC { get; set; }
            public DateTime Tarih { get; set; }
            public virtual int CezaTutarı { get; set; }
            public virtual string CezaTuru { get; set; }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))//tc no girilmediyse
            {
                MessageBox.Show("Lütfen Sürücü TC no girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox1.Text.Length!=11 || !HepsiSayiMi(textBox1.Text))
            {
                MessageBox.Show("Lütfen yalnızca rakamlardan oluşan 11 haneli bir değer girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(cezaAdı)) //Ceza türü secılmedıyse
            {
                MessageBox.Show("Lütfen bir ceza türü seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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




    }
}
