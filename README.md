# 🍏 NutriSync - Klinik Yönetim Sistemi

NutriSync, diyetisyenlerin ve hastaların kayıtlarını terminal üzerinden nesne yönelimli (OOP) kurallarına uygun şekilde yönetebilmek için geliştirilmiş bir B2B Klinik Yönetim Sistemi simülasyonudur.

## 🚀 Proje Hakkında

Bu proje, C# ve .NET Core kullanılarak geliştirilmiş bir Konsol Uygulamasıdır. Temel amacı, modern yazılım mimarisi standartlarını ve **Nesne Yönelimli Programlama (OOP)** prensiplerini gerçek dünya senaryolarıyla uygulamaktır.

## ⚙️ Özellikler

- **Diyetisyen Yönetimi:** Sisteme yeni diyetisyenler ve uzmanlık alanları eklenebilir.
- **Hasta Yönetimi:** Hastaların temel bilgileri, boy/kilo oranları ve hastalık geçmişleri kayıt altına alınır.
- **Otomatik BMI Hesaplama:** Girilen boy ve kilo verilerine göre Vücut Kitle İndeksi (BMI) otomatik hesaplanır.
- **Riskli Hasta Analizi:** BMI değeri 25'in üzerinde olan veya diyabet tanısı konmuş hastalar sistem tarafından filtrelenerek raporlanabilir.

## 🧠 Kullanılan Teknolojiler ve Mimari

Bu projede kod tekrarını önlemek ve sürdürülebilirliği artırmak için şu mimari yapılar kullanılmıştır:

* **C# & .NET 8.0**
* **Interface (Arayüzler):** `IReportable` sözleşmesi ile sistemdeki tüm varlıkların ortak bir raporlama formatına uyması sağlandı.
* **Inheritance (Kalıtım):** `Person` temel sınıfı (Base Class) oluşturularak, `Patient` ve `Dietitian` sınıfları bu temelden türetildi.
* **Polymorphism (Çok Biçimlilik):** Alt sınıflarda metot ezme (`override`) işlemi uygulanarak esnek bir yapı kuruldu.
* **Encapsulation (Kapsülleme):** Veri güvenliği için özellikler (Properties) doğru erişim belirleyicileri (`public`, `private`) ile korundu.
* **Generic Collections:** Veri yönetimi için bellek dostu `List<T>` yapısı kullanıldı.

## 🛠️ Nasıl Çalıştırılır?

Projeyi bilgisayarınızda çalıştırmak için .NET SDK'nın yüklü olduğundan emin olun.

1. Repoyu klonlayın:
   ```bash
   git clone [https://github.com/kzlckhuseyin/NutriSync.git](https://github.com/kzlckhuseyin/NutriSync.git)