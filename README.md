# 🚨 Basit Trafik Cezası Yönetimi Sistemi

## 📌 Proje Amacı

Bu uygulama, sürücülere kesilen trafik cezalarının kayıt altına alınması, görüntülenmesi ve raporlanmasını sağlayan basit bir trafik cezası yönetimi sistemidir. Uygulama, nesne yönelimli programlama (OOP) ilkeleri kullanılarak Windows Forms (WinForms) arayüzü ile geliştirilmiştir.

---

## 🔧 Kullanılan Teknolojiler

- **C#**
- **Windows Forms (WinForms)**
- **.NET Framework**
- **System.IO** (Dosya işlemleri için)

---

## 🧱 OOP Yapısı

### 🏷️ Sınıflar

- **Ceza (Abstract Class)**  
  - Ceza ID, Tutar, Tarih gibi ortak özellikleri içerir.  
  - `IOdenecek` arayüzünü uygular.

- **HizCeza, ParkCeza, IsikCeza**  
  - `Ceza` sınıfından türeyen ceza türleri.  
  - Her biri farklı ceza türünü temsil eder.

- **Surucu**  
  - TC Kimlik No, Ad, Soyad gibi bilgiler içerir.  
  - Kendi cezalarını tutar ve ödeme işlemlerini yapabilir.

- **Polis**  
  - TC Kimlik No, Sicil No gibi bilgiler içerir.  
  - Ceza ekleme ve ceza raporlama işlemlerini yapar.

- **CezaYonetimi**  
  - Ceza listesini tutar, cezaları dosyaya kaydeder ve raporlama yapar.

---

### 💬 Arayüz

- `IOdenecek`  
  - `double TutarHesapla();` metodunu içerir.  
  - Tüm ceza türlerinde ödeme tutarının hesaplanmasını sağlar.

---

## 🧪 Modüller ve Özellikler

- [x] Giriş ekranı (Kullanıcı türü seçimi: Sürücü / Polis)
- [x] Sürücü girişi (TC Kimlik ve ad bilgisiyle)
- [x] Polis girişi (Sicil No ile)
- [x] Ceza ekleme (Polis paneli üzerinden)
- [x] Ceza listeleme (Tüm cezalar)
- [x] Ceza ödeme (Sürücü panelinden)
- [x] Ceza silme (Seçilen cezayı kaldırma)
- [x] Ceza raporlama (Dosyaya yazdırma)
- [x] Veri kalıcılığı (cezalar.txt dosyası ile)
- [x] OOP prensiplerine tam uygunluk

---

## 📂 Dosya Yapısı

- `Ceza.cs`  
- `HizCeza.cs`, `ParkCeza.cs`, `IsikCeza.cs`  
- `Surucu.cs`  
- `Polis.cs`  
- `CezaYonetimi.cs`  
- `Form1.cs` (Giriş Formu)  
- `PolisForm.cs`  
- `SurucuForm.cs`

---

## 🚀 Nasıl Çalıştırılır?

1. Projeyi Visual Studio ile aç.
2. Gerekli NuGet paketleri otomatik yüklenecektir.
3. `Form1.cs`'i başlangıç formu olarak ayarla.
4. Derle (F5) ve çalıştır.

---
