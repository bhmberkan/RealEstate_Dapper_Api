# 🏠 RealEstate Dapper - Fullstack Emlak Uygulaması

**RealEstate Dapper**, modern web teknolojileri kullanılarak geliştirilen bir tam yığın (fullstack) **emlak ilan yönetim sistemidir**.  
Proje; veri erişimi için **Dapper**, arayüz tarafında ise **ASP.NET Core 8.0 MVC** mimarisi kullanılarak geliştirilmiştir.

---

## 📁 Proje Yapısı

```
RealEstate_Dapper_Api/
├── RealEstate_Dapper_Api/       # ASP.NET Core Web API
│   ├── Controllers/             # API uç noktaları
│   ├── Repositories/            # Dapper tabanlı veri erişim katmanı
│   ├── DTOs/                    # Veri transfer nesneleri
│   ├── Models/                  # Veritabanı modelleri
│   ├── Enums/                   # Enum tanımlamaları
│   ├── Tools/                   # Yardımcı sınıflar (örneğin token oluşturma)
│   ├── Containers/              # IOC servis kayıtları
│   ├── Hubs/                    # SignalR gerçek zamanlı iletişim
│   └── Program.cs / Startup.cs # Uygulama konfigürasyonu
│
└── RealEstate_Dapper_UI/        # ASP.NET Core MVC UI
    ├── Area/                    #Satıcılar için oluşturulmuş Sayfaların Tasarımları
    ├── Controllers/             # HttpClient ile API'ye istek gönderen controller'lar
    ├── Views/                   # Razor sayfaları (cshtml)
    ├── Dtos/                    # API'den gelen verilerin tutulduğu sınıflar
    ├── wwwroot/                 # Statik dosyalar (CSS, JS, görseller)
    └── Program.cs / Startup.cs # Arayüz konfigürasyonu
```

---

## 🛠️ Kullanılan Teknolojiler

| Katman | Teknolojiler |
|--------|--------------|
| API    | ASP.NET Core Web API, Dapper, SignalR, AutoMapper, Swagger |
| UI     | ASP.NET Core MVC, Razor Pages, Bootstrap, Pagging |
| Veritabanı | Microsoft SQL Server |
| Genel  | Katmanlı mimari, RESTful servisler, DTO  |

---



## 🧪 UI Özellikleri

- Kullanıcı Girişi / Yetkilendirme
- Admin Paneli (Kullanıcı / İlan / İletişim yönetimi)
- Dinamik Sayfalar: Anasayfa, Hakkımızda, İletişim, İlanlar
- API ile iletişim: HttpClient kullanımı
- Görsel yükleme, dropdown listeler, sayfalama (X.PagedList)
- Gerçek zamanlı bildirimler (SignalR)

---

## 📸 **Proje Görselleri**
---
Görseller bu alanda yer alacaktır. Eklicem

---

## 🎯 Geliştirme Aşamaları

- [x] Dapper ile veri işlemleri
- [x] Swagger entegrasyonu
- [x] DTO mapping yapısı
- [x] UI → API veri bağlantısı
- [x] SignalR bildirim sistemi
- [x] Kullanıcı rolleri ve oturum yönetimi
- [ ] JWT 

---

## ⚙️ Kurulum Talimatları

### 1. Reponun Klonlanması
```bash
git clone https://github.com/bhmberkan/RealEstate_Dapper_Api.git
```

### 2. Veritabanı Ayarları
`appsettings.json` dosyasını açarak kendi SQL Server bağlantınızı girin:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=RealEstateDb;Trusted_Connection=True;"
}
```

> ❗ Not: Eğer `RealEstateDb` veritabanınız yoksa SQL script dosyası ile oluşturmanız gerekebilir.

### 3. Projeyi Çalıştırma

#### API tarafı için:
```bash
cd RealEstate_Dapper_Api/RealEstate_Dapper_Api
dotnet restore
dotnet run
```

#### UI tarafı için:
```bash
cd RealEstate_Dapper_Api/RealEstate_Dapper_UI
dotnet restore
dotnet run
```

### 4. Swagger ile API Testi
Aşağıdaki adresi tarayıcınızda açarak API uç noktalarını test edebilirsiniz:
```
https://localhost:5001/swagger
```

---

## 🔐 Örnek API Endpoint'leri

| Yöntem | URL | Açıklama |
|--------|-----|----------|
| `GET`  | `/api/property`         | Tüm emlakları getirir |
| `POST` | `/api/property`         | Yeni emlak ekler |
| `GET`  | `/api/property/{id}`    | ID'ye göre emlak getir |
| `PUT`  | `/api/property/{id}`    | Emlak bilgisini günceller |
| `DELETE` | `/api/property/{id}`  | Emlak bilgisini siler |

---



## 👨‍💻 Geliştirici Bilgisi

- **👤 Adı**: Berkan Burak Turgut  
- 💼 **LinkedIn**: [linkedin.com/in/berkanburakturgut](https://linkedin.com/in/berkanburakturgut)  
- 💻 **GitHub**: [github.com/bhmberkan](https://github.com/bhmberkan)  
- 📧 **E-posta**: berkanburakturgut@gmail.com  

---

## 📄 Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına göz atabilirsiniz.

---

## 🤝 Katkı Sağla

Her türlü katkıya açığız!

1. Fork'la ⭐  
2. Yeni bir branch oluştur  
3. Değişikliklerini commit et  
4. Pull Request gönder  
5. Kodu birlikte büyütelim!

---

## 📌 Notlar

- Bu proje **öğrenme odaklı** bir tam yığın uygulamadır.
- UI ile API arasındaki iletişim tamamen `HttpClient` üzerinden gerçekleşir.
- Swagger dokümantasyonu otomatik olarak oluşturulmuştur.
