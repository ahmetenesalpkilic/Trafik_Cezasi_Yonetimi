using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Trafik_Cezasi_Yonetimi
{
    public partial class Form3 : Form
    {
        public string sürücütc;
        public List<string> cezaInfos;
        public List<IOdenecek> odenecekLer;
        public string masaUstuYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string dosyaYol;
        public int odenecekToplam = 0;
        public string secilenOdeme;
        public Form3(string sürücütc)
        {
            InitializeComponent();

            this.sürücütc = sürücütc;
            cezaInfos = new List<string>();
            odenecekLer = new List<IOdenecek>();

            dosyaYol = Path.Combine(masaUstuYol, "Trafik_Ceza_Yönetimi", sürücütc+".txt"); //TCY klasöründe kişinin metin belgesine ulaşıyoruz
            CezaListele();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

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
                //odenecek adında bir nesne oluşturup içine atıyoruz

                comboBox1.Items.Add(j + "-) Ceza adı: " + temp[0] + " Tarihi: " + temp[2] + " Borç: " + temp[4]);
                //ComboBox'a ekledik cezayı



                odenecekToplam += Convert.ToInt32(temp[4]);//OdenecekToplam ıcın tutarları topluyoruz

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

            int temp = Convert.ToInt32(secilenOdeme[0]); // cezaNo yu temp'in icine attık 

            if (odenecekLer[temp].odendiMi) {
                MessageBox.Show("Bu borç ödenmiş! Farklı bir borç seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//True ise uyar
            odenecekLer[temp].odendiMi = true; // Eger ödenmediyse true yap
            
        }
    }

    public class IOdenecek
        {
            //Ceza yazılı metin belgesinde yazma sırası Türü-tc-tarih-ödenmedurumu-ÖdenecekTutar
            public int CezaNo { get; set; }
            public string cezaTuru { get; set; }
            public string surucuTc { get; set; }
            public string tarih    { get; set; }
            public bool odendiMi { get; set; }
            public int cezaTutar   { get; set; }

            

        }

    }

