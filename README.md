# 🚨 Basit Trafik Cezası Yönetimi Sistemi

## 📌 Proje Amacı

Bu uygulama, sürücülere kesilen trafik cezalarının eklenmesi, ödenmesi ve takibinin yapılmasını sağlayan basit bir ceza yönetimi sistemidir. Uygulama, nesne yönelimli programlama (OOP) prensiplerine göre geliştirilmiştir.

---

## 🔧 Kullanılan Teknolojiler

- **C#**
- **Windows Forms (WinForms)**
- **.NET Framework**
  

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
  

---

## 🧪 Modüller ve Özellikler

- [x] Giriş ekranı (Kullanıcı türü seçimi: Sürücü / Polis)
- [x] Ceza ekleme (Polis paneli üzerinden)
- [x] Ceza ödeme (Sürücü paneli üzerinden)
- [x] Toplam borç görüntüleme
- [x] Ceza raporlama 
- [x] Ceza silme (opsiyonel)

---

