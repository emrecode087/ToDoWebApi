# ToDoWebApi

## .NET 8.0 Web API projesi — Dependency Injection ve Docker desteği ile.

### 🚀 Hızlı Başlangıç

#### Klonla ve çalıştır:
```bash
git clone https://github.com/<kullaniciAdi>/TodoApp.git
cd TodoApp
dotnet run
```
#### Docker ile çalıştır:
```bash
docker build -t todoapp .
docker run -p 8080:80 todoapp
```
### 📌 API Endpoints

| Yöntem | Yol            | Açıklama                                                       |
| ------ | -------------- | -------------------------------------------------------------- |
| GET    | `/Todo`        | Tüm görevleri listeler                                         |
| POST   | `/Todo`        | Yeni görev ekler (JSON gövde: `title`)                         |
| PUT    | `/Todo/{id}`   | Görevi günceller (JSON: `title`, `isCompleted`)                |
| DELETE | `/Todo/{id}`   | Görevi siler                                                   |

#### JSON Örnekleri
~~~json
// POST /Todo
{
  "title": "Görev başlığı"
}

~~~

### 📁 Proje Yapısı
~~~bash
TodoApp/
├── Controllers/         # API controller'ları
│   └── TodoController.cs
├── Services/            # Servis katmanı (iş mantığı)
│   └── TodoService.cs
├── Models/              # Veri modelleri
│   └── Todo.cs
├── Program.cs           # Uygulama giriş noktası
├── Dockerfile           # Docker yapılandırma dosyası
└── TodoApp.csproj       # .NET proje dosyası
~~~

### ⚙️ Kullanılan Teknolojiler
- .NET 8.0 Web API  
- C# 12  
- Dependency Injection  
- Docker  
- RESTful API Tasarımı  

### ✅ Gereksinimler
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download)  
- [Docker](https://www.docker.com/) _(opsiyonel)_
