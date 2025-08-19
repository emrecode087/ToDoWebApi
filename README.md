# ToDoWebApi

## .NET 8.0 Web API projesi — Dependency Injection ve Docker desteği ile.

Bu proje, basit bir ToDo (yapılacaklar) listesi yönetimi için geliştirilmiş modern bir Web API uygulamasıdır. ASP.NET Core 8.0, Dependency Injection pattern'i ve Docker containerization teknolojilerini kullanır.

### 🚀 Hızlı Başlangıç

#### Klonla ve çalıştır:
```bash
git clone https://github.com/emrecode087/ToDoWebApi.git
cd ToDoWebApi
dotnet restore
dotnet run
```

#### Docker ile çalıştır:
```bash
docker build -t todowebapi .
docker run -p 8080:8080 todowebapi
```

#### Docker Compose ile çalıştır:
```bash
docker-compose up --build
```
### 📌 API Endpoints

| Yöntem | Yol            | Açıklama                                                       |
| ------ | -------------- | -------------------------------------------------------------- |
| GET    | `/Todo`        | Tüm görevleri listeler (string array olarak)                  |
| POST   | `/Todo`        | Yeni görev ekler (JSON body'de string değer)                  |

#### JSON Örnekleri

**Tüm görevleri listele:**
```bash
curl -X GET http://localhost:8080/Todo
```
**Yanıt:**
```json
[
  "İlk görev",
  "İkinci görev",
  "Üçüncü görev"
]
```

**Yeni görev ekle:**
```bash
curl -X POST http://localhost:8080/Todo \
  -H "Content-Type: application/json" \
  -d '"Yeni görev başlığı"'
```

### 🌐 Swagger UI
Uygulama çalışırken Swagger UI'ye aşağıdaki adresten erişebilirsiniz:
- **Development:** http://localhost:8080 (Swagger UI ana sayfada açılır)
- **API Dokümantasyonu:** http://localhost:8080/swagger/v1/swagger.json

### 📁 Proje Yapısı
```bash
ToDoWebApi/
├── Controllers/             # API controller'ları
│   └── TodoController.cs   # Todo işlemleri için REST endpoint'leri
├── Services/               # Servis katmanı (business logic)
│   ├── ITodoService.cs     # Todo servis interface'i
│   └── TodoService .cs     # Todo servis implementasyonu
├── Properties/             # Proje ayarları
│   └── launchSettings.json # Development server ayarları  
├── Program.cs              # Uygulama giriş noktası ve DI konfigürasyonu
├── ToDoWebApi.csproj       # .NET proje dosyası
├── ToDoWebApi.sln          # Visual Studio solution dosyası
├── Dockerfile              # Docker container yapılandırması
├── docker-compose.yml      # Docker Compose konfigürasyonu
├── docker-run.bat         # Windows için Docker çalıştırma script'i
├── docker-run.sh          # Linux/macOS için Docker çalıştırma script'i
├── appsettings.json        # Uygulama ayarları (Production)
├── appsettings.Development.json # Development ayarları
└── README.md              # Bu dokümantasyon dosyası
```

### ⚙️ Kullanılan Teknolojiler
- **.NET 8.0 Web API** - Modern, cross-platform web API framework'ü
- **C# 12** - En güncel C# dil özellikleri
- **Dependency Injection** - Loosely coupled ve test edilebilir kod yapısı
- **Swagger/OpenAPI** - API dokümantasyonu ve test arayüzü
- **Docker & Docker Compose** - Container tabanlı deployment
- **RESTful API Design** - HTTP standartlarına uygun API tasarımı

### 🏗️ Mimari Özellikler
- **Service Layer Pattern:** Business logic'i controller'dan ayırır
- **Interface Segregation:** ITodoService interface'i ile abstraction
- **Singleton Lifetime:** TodoService tek instance olarak çalışır (in-memory)
- **Controller-based Routing:** Attribute-based routing kullanır
- **JSON Serialization:** Otomatik JSON dönüşüm desteği

### ✅ Gereksinimler
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download) _(zorunlu)_
- [Docker](https://www.docker.com/) _(opsiyonel - containerized deployment için)_
- [Visual Studio 2022](https://visualstudio.microsoft.com/) veya [Visual Studio Code](https://code.visualstudio.com/) _(opsiyonel - development için)_

### 🔍 Önemli Notlar
- **Veri Saklama:** Şu anda in-memory List<string> kullanılıyor (production için uygun değil)
- **Güvenlik:** Authentication/Authorization implementasyonu yok
- **Validation:** Input validation mevcut değil
- **Error Handling:** Gelişmiş hata yönetimi eksik
- **Logging:** Varsayılan ASP.NET Core logging kullanılıyor

### 🚀 Geliştirme Önerileri
Projeyi production-ready hale getirmek için:
- [ ] Database integration (Entity Framework Core)
- [ ] Authentication & Authorization (JWT)
- [ ] Input validation ve model binding
- [ ] Comprehensive error handling
- [ ] Structured logging (Serilog)
- [ ] Unit tests
- [ ] Health checks
- [ ] Rate limiting
- [ ] CORS policy

### 📝 Proje Hakkında Detaylar

Bu ToDoWebApi projesi, basit bir ToDo listesi yönetimi için geliştirilmiş minimal bir Web API uygulamasıdır. Proje, modern .NET geliştirme pratiklerini göstermek ve öğrenme amaçlı tasarlanmıştır.

**Ana Özellikler:**
- Basit CRUD operasyonları (şu anda sadece Create ve Read)
- In-memory veri saklama
- RESTful API endpoint'leri
- Swagger UI entegrasyonu
- Docker containerization desteği
- Dependency Injection pattern kullanımı

**Kod Yapısı:**
- `TodoController`: HTTP isteklerini yöneten controller sınıfı
- `ITodoService`: Business logic için interface tanımı
- `TodoService`: Business logic implementasyonu
- `Program.cs`: Uygulama başlangıç konfigürasyonu

Bu proje, .NET Web API geliştirmenin temellerini öğrenmek isteyen geliştiriciler için iyi bir başlangıç noktasıdır.

---

**Geliştirici:** [emrecode087](https://github.com/emrecode087)  
**Lisans:** Bu proje açık kaynak olarak paylaşılmıştır  
**Katkı:** Pull request'ler ve issue'lar memnuniyetle karşılanır
