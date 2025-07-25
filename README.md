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


## 🎯 Geliştirme Aşamaları

- [x] Dapper ile veri işlemleri
- [x] Swagger entegrasyonu
- [x] DTO mapping yapısı
- [x] UI → API veri bağlantısı
- [x] SignalR bildirim sistemi
- [x] Kullanıcı rolleri ve oturum yönetimi
- [x] JWT 
- [x] Pagging
---


## 📸 **Proje Görselleri**
---

![localhost_44332_Default_Index (1)](https://github.com/user-attachments/assets/a4d3f383-9666-410a-b38b-df92e1bbbd87)
<br/>
<img width="1899" height="986" alt="image" src="https://github.com/user-attachments/assets/4732fcba-ecf1-4529-87a9-4bcb8eddd0b8" />
<br/>
<img width="1074" height="269" alt="image" src="https://github.com/user-attachments/assets/d68c043a-62c2-4e45-8441-d4d524d7d016" />
<br/>
<img width="1637" height="561" alt="image" src="https://github.com/user-attachments/assets/fb970ff1-965c-4adf-8d4f-da41df869d70" />
<br/>
<img width="2518" height="6386" alt="localhost_44332_Property_deniz-manzarali-villa_1" src="https://github.com/user-attachments/assets/f79eff8d-17a2-4a3d-95c8-b44de7b01433" />
<br/>
<img width="1892" height="980" alt="image" src="https://github.com/user-attachments/assets/26d272a0-e058-4353-8e8a-f59e183ebcaa" />
<br/>
<img width="2518" height="6198" alt="localhost_44332_AboutUs_Index_" src="https://github.com/user-attachments/assets/a5a46c5d-fdf9-46a8-861d-da68db93dc83" />
<br/>
<img width="1506" height="994" alt="image" src="https://github.com/user-attachments/assets/27c1779e-f5a3-44e6-8508-c133e0d17e5b" />
<br/>
<img width="760" height="722" alt="image" src="https://github.com/user-attachments/assets/366e7364-23eb-47ba-843b-a6cdb8321088" />
<br/>
<img width="1699" height="971" alt="image" src="https://github.com/user-attachments/assets/c20ba9f0-9a55-4213-b5f1-184acc522995" />
<br/>
<img width="1469" height="481" alt="image" src="https://github.com/user-attachments/assets/e9ac8235-3dc6-4bc0-8007-77c85b3bf33f" />
<br/>
<img width="2518" height="3078" alt="localhost_44332_Dashboard_Index" src="https://github.com/user-attachments/assets/2973ccd0-5207-413c-8bb9-cc5d9926f5c7" />
<br/>
<img width="1296" height="824" alt="image" src="https://github.com/user-attachments/assets/8e29ef6d-19d2-48ff-8b44-0a8a3adbe19f" />
<br/>
<img width="1879" height="976" alt="image" src="https://github.com/user-attachments/assets/f4475433-bf79-4925-9128-fdea6c6c4617" />
<br/>
<img width="1491" height="266" alt="image" src="https://github.com/user-attachments/assets/0cba2ac6-7c41-41c9-806f-77bccfb8d000" />
<br/>
<img width="1076" height="688" alt="image" src="https://github.com/user-attachments/assets/edaa9bb9-853c-4b7e-b253-bb512bd7ec6b" />
<br/>
<img width="1165" height="791" alt="image" src="https://github.com/user-attachments/assets/0663be3e-d953-4967-b95f-c0edc6c61338" />
<br/>
<img width="1123" height="449" alt="image" src="https://github.com/user-attachments/assets/148b8af8-a7f1-4fa3-9d6b-a9ec4339699f" />
<br/>
<img width="1016" height="850" alt="image" src="https://github.com/user-attachments/assets/d6673273-2b96-48f4-b597-f383b043ab74" />
<br/>
<img width="1015" height="617" alt="image" src="https://github.com/user-attachments/assets/f5e61c64-bdd0-4093-8df1-8433b1578480" />
<br/>
<img width="1008" height="639" alt="image" src="https://github.com/user-attachments/assets/1b4cee1b-a6bd-4646-a63f-abdd3c7ba038" />
<br/>
<img width="672" height="667" alt="image" src="https://github.com/user-attachments/assets/5e6b0f4b-618a-4688-9eea-cca2b47fe041" />
<br/>
<img width="333" height="318" alt="image" src="https://github.com/user-attachments/assets/273f74ab-0cbd-4291-a710-40d5d2dee12d" />
<br/>
<img width="1488" height="877" alt="image" src="https://github.com/user-attachments/assets/4e7de6a2-2862-4379-aea1-30dc328b013b" />
<br/>
<img width="1549" height="899" alt="image" src="https://github.com/user-attachments/assets/b4a8f6b5-0dd0-4ff9-8581-f0aba94edb6f" />
<br/>
<img width="1582" height="786" alt="image" src="https://github.com/user-attachments/assets/e73e67bb-8698-4ec8-9dbf-c5f2f4f76a9b" />
<br/>
<img width="1581" height="705" alt="image" src="https://github.com/user-attachments/assets/e87b9278-9655-4ddf-98c2-acec51c98dc5" />
<br/>
<img width="1571" height="864" alt="image" src="https://github.com/user-attachments/assets/ccb203a5-1aed-477f-8003-c5409abe7b0a" />

<br/>
<img width="1333" height="796" alt="image" src="https://github.com/user-attachments/assets/7ae5c667-9db8-4882-85e8-cbb138cd6d91" />
<br/>
<img width="245" height="454" alt="image" src="https://github.com/user-attachments/assets/6bb224c7-fb6f-4326-bb18-3c0c049af6c3" />
<br/>
<img width="449" height="840" alt="image" src="https://github.com/user-attachments/assets/ef2fab62-c31d-4090-85fb-b6857f06f8cd" />
<br/>

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
