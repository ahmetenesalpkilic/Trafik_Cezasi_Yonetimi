using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Trafik_Cezasi_Yonetimi
{
    public partial class Form3 : Form
    {
        public string sürücütc;
        public List<string> cezaInfos;
        public List<IOdenecek> odenecekLer;
        public string masaUstuYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string dosyaYol;

        public string secilenOdeme;
        public int ödenenBorc = 0;
        public int ödenecekBorc = 0;
        public Form3(string sürücütc)
        {
            InitializeComponent();

            this.sürücütc = sürücütc;
            cezaInfos = new List<string>();
            odenecekLer = new List<IOdenecek>();

            dosyaYol = Path.Combine(masaUstuYol, "Trafik_Ceza_Yönetimi", sürücütc + ".txt"); //TCY klasöründe kişinin metin belgesine ulaşıyoruz
            CezaListele();
            TumLabellariSaydamYap(this);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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




        
        private void CezaListele()
        { //Ceza Bilgilerini listeye atıcagız!

            StreamReader sr = new StreamReader(dosyaYol);

            string s;
            int j = 0; //Ceza No'ları belirliyor
            while ((s = sr.ReadLine()) != null) //metin belgesi null olana kadar
            {
                string[] temp = s.Trim().Split(':'); // iki nokta(:) gorunce ayır dızıye ata
                IOdenecek odenecek = new IOdenecek();

                odenecek.CezaNo = j;
                odenecek.cezaTuru = temp[0]; odenecek.surucuTc = temp[1]; odenecek.tarih = temp[2];
                odenecek.odendiMi = Convert.ToBoolean(temp[3]); odenecek.cezaTutar = Convert.ToInt32(temp[4]);

                comboBox1.Items.Add(j + "-) Ceza adı: " + temp[0] + " Tarihi: " + temp[2] + " Borç: " + temp[4]);
                //ComboBox'a ekledik cezayı

                odenecekLer.Add(odenecek); //odenecek nesneyi Listeye Ekledik
                j++; //ComboBoxa ve odenecek nesnesıne ekledık bu sayede eşleştirebileceğiz
            }


            sr.Close();

        }
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Ödenecek Borcu Seçme Combobox'u
        {
            secilenOdeme = comboBox1.SelectedItem.ToString();// Secılen Cezayı bir değişkene atadık
        }



        private void button1_Click(object sender, EventArgs e)//Ceza öde butonu
        {
            if (secilenOdeme == null)//Eger ceza secmeden ceza öde dediyse uyar
            {
                MessageBox.Show("Lütfen Ödemek İstediğiniz Bir Cezayı Seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int i = 0;
            string tempstring = "";

            while (secilenOdeme[i] != '-') { tempstring = tempstring + secilenOdeme[i]; i++; } //Ceza noyu string olarak aldık
            int temp = Convert.ToInt32(tempstring); // cezaNo yu temp'in icine attık 


            if (odenecekLer[temp].odendiMi)
            {
                MessageBox.Show("Bu borç ödenmiş! Farklı bir borç seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//True ise uyar
            odenecekLer[temp].odendiMi = true; // Eger ödenmediyse true yap
            MessageBox.Show("Borcunuz Ödenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Borc kontrol düzelidi

            //Okuma işleminde File.ReadAllLines(filePath) tüm satırları diziye atacagız, temp degiskenindeki satırdakı False degerini
            //hedef satır.Replace("false","true") degistirme metodu ile true yapıcağız.
            //File.WriteAllLines(filePath, satırlar); ile Değiştirilmiş tüm satırları geri yazICAGIZ
            string[] satırlar = File.ReadAllLines(dosyaYol);

            satırlar[temp] = satırlar[temp].Replace("False", "True");

            File.WriteAllLines(dosyaYol, satırlar);

        }

        private void button2_Click(object sender, EventArgs e)//Toplam Ceza görüntüle butonu
        {
            var odenenList = odenecekLer.Where(odenecekLer => odenecekLer.odendiMi).ToList(); ; //Odenen cezaları listeliyor
            var odenmeyenList = odenecekLer.Where(o => !o.odendiMi).ToList();//Odenmeyen cezaları listeliyor
            ödenecekBorc = 0; ödenenBorc = 0;
            for (int i = 0; i < odenenList.Count; i++)
           { ödenenBorc += Convert.ToInt32(odenenList[i].cezaTutar);}

            for (int i = 0; i < odenmeyenList.Count; i++)
            { ödenecekBorc += Convert.ToInt32(odenmeyenList[i].cezaTutar); }


            listBox1.Items.Clear(); //Oncekı eklenen itemleri kaldiriyoruz

            listBox1.Items.Add("Ödenmiş olan toplam borcunuz :" + ödenenBorc + " tl");
            listBox1.Items.Add("Ödenecek olan toplam borcunuz :" + ödenecekBorc + " tl");
            



        }

        private void button4_Click(object sender, EventArgs e) //Geri butonu
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e) // kapatma labeli X
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) //saydam azaltma
        {
            panel1.BackColor = Color.FromArgb(170, Color.Black); // 170 saydamlık değeri 
        }
    }



    public class IOdenecek
    {
        //Ceza yazılı metin belgesinde yazma sırası Türü-tc-tarih-ödenmedurumu-ÖdenecekTutar
        public int CezaNo { get; set; }
        public string cezaTuru { get; set; }
        public string surucuTc { get; set; }
        public string tarih { get; set; }
        public bool odendiMi { get; set; }  
        public int cezaTutar { get; set; }



    }






}

