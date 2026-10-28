# MyPortfolio - ASP.NET Core 9.0 Dynamic Web Application

Bu proje, **ASP.NET Core 9.0 MVC** mimarisi kullanılarak geliştirilmiş dinamik bir kişisel portfolyo ve yönetim (admin) paneli uygulamasıdır. Ziyaretçilere yazılım geliştirici profilini, projelerini, yeteneklerini ve iletişim kanallarını sunarken; arka plandaki admin paneli sayesinde gelen mesajları, yapılacaklar listesini (To-Do List) ve dinamik verileri yönetme imkanı sağlar.

---

## Kullanılan Teknolojiler

* **Framework:** ASP.NET Core 9.0 (MVC Pattern)
* **ORM:** Entity Framework Core
* **Veritabanı:** MS SQL Server
* **Dil:** C# 13 / .NET 9.0
* **Veri Sorgulama:** LINQ (Language Integrated Query)
* **Frontend:** HTML5, CSS3, JavaScript, jQuery, Bootstrap
* **Tema / Template:** Ready Dashboard & Hola Master Template
* **Sürüm Kontrolü:** Git & GitHub

---

## Mimari Yapı & Tasarım Desenleri

* **Model-View-Controller (MVC):** Katmanlı ve sürdürülebilir kod mimarisi.
* **Data Access Layer (DAL):** Veri erişim süreçlerinin ve `DbContext` yönetiminin ayrı bir katmanda kapsüllenmesi.
* **ViewComponent Yapısı:** Modüler, tekrar kullanılabilir ve performanslı UI bileşenleri (`_AboutComponentPartial`, `_ExperienceComponentPartial`, `_SkillComponentPartial` vb.).
* **Code First & Migrations:** Veritabanı şemasının C# modelleri üzerinden yönetilmesi ve güncellenmesi.
* **Partial Views & Layouts:** Ortak arayüz parçalarının (`_Layout.cshtml`, `_LayoutSidebarComponentPartial`) merkezi yönetimi.
* **Dynamic Data Binding:** Controller tarafında hesaplanan 16 farklı istatistiksel verinin `ViewBag` ve `ViewData` ile görünümlere aktarılması.

---

## Proje Modülleri ve Özellikleri

### 1. Ziyaretçi Portalı (Main Site)
* **Hakkımda & Deneyimler:** Dinamik olarak veritabanından çekilen özgeçmiş ve yetenek bilgileri.
* **Portfolyo / Projeler:** Tamamlanan yazılım, veritabanı ve SDR projelerinin listelenmesi.
* **Referanslar (Testimonials):** Sektörel ve akademik değerlendirmelerin sunumu.
* **İletişim Formu:** Ziyaretçilerin doğrudan veritabanına (`Messages` tablosu) mesaj gönderebilmesini sağlayan form altyapısı.

### 2. Admin Yönetim Paneli
* **Gelen Kutusu (Inbox):** Form üzerinden gönderilen mesajların okunma durumuna (`IsRead`) göre filtrelenmesi, detaylandırılması ve silinmesi.
* **Yapılacaklar Listesi (To-Do List):** Görev ekleme, güncelleme ve tamamlandı/tamamlanmadı durum kontrolü.
* **İstatistik Paneli:** LINQ sorguları ile anlık olarak hesaplanan mesaj, yetenek ve sistem istatistik sayaçları.
* **İçerik Yönetimi:** Deneyim, yetenek ve proje bilgilerinin dinamik CRUD (Create, Read, Update, Delete) operasyonları.

---

## Kurulum ve Çalıştırma

1. Repoyu bilgisayarınıza klonlayın:
   ```bash
   git clone [https://github.com/EmreKaya34/MyPortfolioUdemy.git](https://github.com/EmreKaya34/MyPortfolioUdemy.git)
### RESİMLER  ###
<img width="1600" height="724" alt="WhatsApp Image 2026-10-28 at 18 30 15" src="https://github.com/user-attachments/assets/fc35853f-271c-4e85-bd09-b754b101d15b" />
<img width="1600" height="566" alt="WhatsApp Image 2026-10-28 at 18 29 53" src="https://github.com/user-attachments/assets/86388c13-1840-4078-9145-dda53c982164" />
<img width="1600" height="738" alt="WhatsApp Image 2026-10-28 at 18 25 13" src="https://github.com/user-attachments/assets/6365567d-044e-4749-8e75-a1205ea42bbe" />
<img width="1600" height="683" alt="WhatsApp Image 2026-10-28 at 18 29 13" src="https://github.com/user-attachments/assets/2e0bd4bc-f82e-4204-b46c-ce8584959cb6" />
<img width="1600" height="727" alt="WhatsApp Image 2026-10-28 at 18 31 14" src="https://github.com/user-attachments/assets/8fefbdc1-ec5f-4228-8dc0-783210ea52f1" />



   
