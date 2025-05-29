🚨 Basit Trafik Cezası Yönetimi Sistemi
📌 Proje Amacı
Bu uygulama, sürücülere kesilen trafik cezalarının kayıt altına alınması, görüntülenmesi ve raporlanmasını sağlayan basit bir trafik cezası yönetimi sistemidir. Uygulama, nesne yönelimli programlama (OOP) ilkeleri kullanılarak Windows Forms (WinForms) arayüzü ile geliştirilmiştir.

🔧 Kullanılan Teknolojiler
C#

Windows Forms (WinForms)

.NET Framework

System.IO (Dosya işlemleri için)

🧱 OOP Yapısı
🏷️ Sınıflar
Ceza (Abstract Class)

Ceza ID, Tutar, Tarih gibi ortak özellikleri içerir.

IOdenecek arayüzünü uygular.

HızCeza, ParkCeza, IsikCeza

Ceza sınıfından türeyen ceza türleri.

Her biri farklı ceza türünü temsil eder.

Surucu

TC Kimlik No, Ad, Soyad gibi bilgiler içerir.

Kendi cezalarını tutar ve ödeme işlemlerini yapabilir.

Polis

TC Kimlik No, Sicil No gibi bilgiler içerir.

Ceza ekleme ve ceza raporlama işlemlerini yapar.

CezaYonetimi

Ceza listesini tutar, cezaları dosyaya kaydeder ve raporlama yapar.

💬 Arayüz
IOdenecek

double TutarHesapla(); metodunu içerir.

Tüm ceza türlerinde ödeme tutarının hesaplanmasını sağlar.

🧪 Modüller ve Özellikler
 Giriş ekranı (Kullanıcı türü seçimi: Sürücü / Polis)

 Sürücü girişi (TC Kimlik ve ad bilgisiyle)

 Polis girişi (Sicil No ile)

 Ceza ekleme (Polis paneli üzerinden)

 Ceza listeleme (Tüm cezalar)

 Ceza ödeme (Sürücü panelinden)

 Ceza silme (Seçilen cezayı kaldırma)

 Ceza raporlama (Dosyaya yazdırma)

 Veri kalıcılığı (cezalar.txt dosyası ile)

 OOP prensiplerine tam uygunluk

📂 Dosya Yapısı
