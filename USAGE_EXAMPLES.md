# ToDoWebApi Kullanım Örnekleri

Bu dokümanda ToDoWebApi uygulamasının nasıl kullanılacağına dair detaylı örnekler bulabilirsiniz.

## API Endpoint'leri

### 1. Tüm Todo İtemlerini Listele (GET)

**HTTP İsteği:**
```http
GET /Todo HTTP/1.1
Host: localhost:8080
Accept: application/json
```

**cURL Örneği:**
```bash
curl -X GET "http://localhost:8080/Todo" -H "accept: application/json"
```

**Yanıt Örneği:**
```json
[
  "İlk görev",
  "İkinci görev", 
  "Alışveriş yap"
]
```

**Boş Liste (İlk Çalıştırmada):**
```json
[]
```

### 2. Yeni Todo İtemi Ekle (POST)

**HTTP İsteği:**
```http
POST /Todo HTTP/1.1
Host: localhost:8080
Content-Type: application/json

"Yeni görev başlığı"
```

**cURL Örneği:**
```bash
curl -X POST "http://localhost:8080/Todo" \
  -H "Content-Type: application/json" \
  -d '"Yeni todo item"'
```

**JavaScript Fetch API Örneği:**
```javascript
fetch('http://localhost:8080/Todo', {
  method: 'POST',
  headers: {
    'Content-Type': 'application/json',
  },
  body: JSON.stringify('Yeni görev başlığı')
})
.then(response => {
  if (response.ok) {
    console.log('Todo başarıyla eklendi');
  }
});
```

**Python Requests Örneği:**
```python
import requests

url = "http://localhost:8080/Todo"
data = "Yeni Python görevi"

response = requests.post(url, json=data)
if response.status_code == 201:
    print("Todo başarıyla eklendi")
```

## Swagger UI Kullanımı

1. Uygulamayı başlatın: `dotnet run`
2. Tarayıcınızda http://localhost:8080 adresine gidin
3. Swagger UI arayüzü otomatik olarak açılacaktır

### Swagger UI ile Test Etme:

1. **GET /Todo endpoint'ini test etmek için:**
   - GET /Todo butonuna tıklayın
   - "Try it out" butonuna tıklayın  
   - "Execute" butonuna tıklayın
   - Sonuç kısmında mevcut todo listesini göreceksiniz

2. **POST /Todo endpoint'ini test etmek için:**
   - POST /Todo butonuna tıklayın
   - "Try it out" butonuna tıklayın
   - Request body kısmına todo metnini girin (örnek: "Test görevi")
   - "Execute" butonuna tıklayın

## Docker ile Kullanım

### 1. Docker Build ve Run
```bash
# Önce image'ı build edin
docker build -t todowebapi .

# Container'ı başlatın
docker run -p 8080:8080 todowebapi
```

### 2. Docker Compose ile
```bash
# Uygulamayı başlatın
docker-compose up --build

# Arka planda çalıştırın
docker-compose up -d --build

# Durdurun
docker-compose down
```

### 3. Hazır Script'ler
**Windows:**
```batch
.\docker-run.bat
```

**Linux/macOS:**
```bash
chmod +x docker-run.sh
./docker-run.sh
```

## Uygulama Test Senaryosu

Aşağıdaki adımları takip ederek uygulamanın tam fonksiyonalitesini test edebilirsiniz:

```bash
# 1. Uygulamayı başlatın
dotnet run

# 2. Yeni terminal açın ve ilk durumu kontrol edin
curl http://localhost:8080/Todo
# Beklenen: []

# 3. İlk todo'yu ekleyin
curl -X POST http://localhost:8080/Todo \
  -H "Content-Type: application/json" \
  -d '"İlk görev"'

# 4. İkinci todo'yu ekleyin
curl -X POST http://localhost:8080/Todo \
  -H "Content-Type: application/json" \
  -d '"İkinci görev"'

# 5. Tüm todo'ları listeleyin
curl http://localhost:8080/Todo
# Beklenen: ["İlk görev","İkinci görev"]
```

## Önemli Notlar

- **Veri Persistence:** Uygulama in-memory çalıştığı için restart edildiğinde tüm veriler kaybolur
- **Content-Type:** POST isteklerinde mutlaka `Content-Type: application/json` header'ı kullanın
- **String Format:** POST body'de direkt string gönderin, obje wrapper'a gerek yok
- **Port:** Uygulama varsayılan olarak 8080 portunda çalışır
- **HTTPS:** Development modda HTTPS yönlendirmesi kapatılmıştır

## Hata Durumları

### 400 Bad Request
```bash
# Yanlış content-type
curl -X POST http://localhost:8080/Todo \
  -H "Content-Type: text/plain" \
  -d 'test'
```

### 404 Not Found
```bash
# Yanlış endpoint
curl http://localhost:8080/WrongEndpoint
```

### 405 Method Not Allowed
```bash
# PUT veya DELETE gibi desteklenmeyen HTTP methodları
curl -X DELETE http://localhost:8080/Todo
```