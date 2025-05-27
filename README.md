# 🚨 Basit Trafik Cezası Yönetimi Sistemi

## 📌 Proje Amacı

Bu uygulama, sürücülere kesilen trafik cezalarının eklenmesi, ödenmesi ve takibinin yapılmasını sağlayan basit bir ceza yönetimi sistemidir. Uygulama, nesne yönelimli programlama (OOP) prensiplerine göre geliştirilmiştir.

---

## 🔧 Kullanılan Teknolojiler

- **C#**
- **Windows Forms (WinForms)**
- **.NET Framework**
- **LINQ**

---

## 🧱 OOP Yapısı

### 🏷️ Sınıflar

- **Ceza (Abstract Base Class)**
  - Ortak özellikleri ve `IOdenecek` arayüzünü içerir.
- **Hız, Park, KırmızıIşık** (Ceza'dan kalıtım alır)
  - Ceza türlerine göre özelleştirilmiş sınıflar.
- **Sürücü**
  - TC Kimlik, Ad Soyad gibi bilgileri tutar.
- **Polis**
  - Ceza ekleme işlemleri için kullanılır.

### 💬 Arayüz

- `IOdenecek`
  - `void Ode();` metodunu içerir.

---

## 🧪 Modüller ve Özellikler

- [x] Giriş ekranı (Kullanıcı türü seçimi: Sürücü / Polis)
- [x] Ceza ekleme (Polis paneli üzerinden)
- [x] Ceza ödeme (Sürücü paneli üzerinden)
- [x] Toplam borç görüntüleme
- [x] Ceza raporlama (LINQ ile filtreleme)
- [x] Ceza silme (opsiyonel)

---

## 🔍 LINQ ile Filtreleme

```csharp
// TC'ye göre kişinin tüm cezalarını al
var cezalar = tumCezalar.Where(c => c.TC == "12345678900").ToList();

// Sadece ödenmemiş olanları al
var odenmemisler = cezalar.Where(c => !c.OdendiMi).ToList();

// Toplam borcu hesapla
int toplamBorc = odenmemisler.Sum(c => c.Tutar);
