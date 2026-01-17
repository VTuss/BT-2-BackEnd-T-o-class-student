# HƯỚNG DẪN TEST API - STUDENT MANAGEMENT SYSTEM

## 1. CHẠY ỨNG DỤNG

```bash
cd "c:\Users\THIS PC\Downloads\LT BackEnd\BT 2 BackEnd"
dotnet run
```

Ứng dụng chạy tại: **http://localhost:5000**

---

## 2. TEST VỚI SWAGGER UI

### Bước 1: Mở Swagger
Truy cập: **http://localhost:5000/swagger**

### Bước 2: Test các API

---

## 3. CLASSES API

### 3.1. Tạo lớp mới (POST /api/classes)

**Swagger:**
1. Click vào `POST /api/classes`
2. Click "Try it out"
3. Nhập dữ liệu:
```json
{
  "name": "Lớp IT01",
  "description": "Lớp công nghệ thông tin khóa 2024"
}
```
4. Click "Execute"
5. Kết quả trả về (201 Created):
```json
{
  "id": 1,
  "name": "Lớp IT01",
  "description": "Lớp công nghệ thông tin khóa 2024"
}
```

**Postman/cURL:**
```bash
curl -X POST "http://localhost:5000/api/classes" ^
  -H "Content-Type: application/json" ^
  -d "{\"name\":\"Lớp IT01\",\"description\":\"Lớp công nghệ thông tin khóa 2024\"}"
```

---

### 3.2. Lấy danh sách lớp (GET /api/classes)

**Swagger:**
1. Click vào `GET /api/classes`
2. Click "Try it out"
3. Click "Execute"
4. Kết quả trả về (200 OK):
```json
[
  {
    "id": 1,
    "name": "Lớp IT01",
    "description": "Lớp công nghệ thông tin khóa 2024"
  }
]
```

**Browser:** Mở trực tiếp: http://localhost:5000/api/classes

**Postman/cURL:**
```bash
curl -X GET "http://localhost:5000/api/classes"
```

---

### 3.3. Xem chi tiết lớp (GET /api/classes/{id})

**Swagger:**
1. Click vào `GET /api/classes/{id}`
2. Click "Try it out"
3. Nhập `id = 1`
4. Click "Execute"
5. Kết quả trả về (200 OK):
```json
{
  "id": 1,
  "name": "Lớp IT01",
  "description": "Lớp công nghệ thông tin khóa 2024"
}
```

**Browser:** Mở: http://localhost:5000/api/classes/1

**Postman/cURL:**
```bash
curl -X GET "http://localhost:5000/api/classes/1"
```

---

## 4. STUDENTS API

### 4.1. Thêm sinh viên (POST /api/students)

**Lưu ý:** Phải tạo Class trước (có ClassId)

**Swagger:**
1. Click vào `POST /api/students`
2. Click "Try it out"
3. Nhập dữ liệu:
```json
{
  "fullName": "Nguyễn Văn A",
  "email": "nguyenvana@gmail.com",
  "dateOfBirth": "2000-01-15",
  "classId": 1
}
```
4. Click "Execute"
5. Kết quả trả về (201 Created):
```json
{
  "id": 1,
  "fullName": "Nguyễn Văn A",
  "email": "nguyenvana@gmail.com",
  "dateOfBirth": "2000-01-15T00:00:00",
  "classId": 1
}
```

**Postman/cURL:**
```bash
curl -X POST "http://localhost:5000/api/students" ^
  -H "Content-Type: application/json" ^
  -d "{\"fullName\":\"Nguyễn Văn A\",\"email\":\"nguyenvana@gmail.com\",\"dateOfBirth\":\"2000-01-15\",\"classId\":1}"
```

---

### 4.2. Lấy danh sách sinh viên (GET /api/students)

**Swagger:**
1. Click vào `GET /api/students`
2. Click "Try it out"
3. Click "Execute"
4. Kết quả trả về (200 OK):
```json
[
  {
    "id": 1,
    "fullName": "Nguyễn Văn A",
    "email": "nguyenvana@gmail.com",
    "dateOfBirth": "2000-01-15T00:00:00",
    "classId": 1
  }
]
```

**Browser:** Mở: http://localhost:5000/api/students

**Postman/cURL:**
```bash
curl -X GET "http://localhost:5000/api/students"
```

---

### 4.3. Xem chi tiết sinh viên (GET /api/students/{id})

**Swagger:**
1. Click vào `GET /api/students/{id}`
2. Click "Try it out"
3. Nhập `id = 1`
4. Click "Execute"
5. Kết quả trả về (200 OK):
```json
{
  "id": 1,
  "fullName": "Nguyễn Văn A",
  "email": "nguyenvana@gmail.com",
  "dateOfBirth": "2000-01-15T00:00:00",
  "classId": 1
}
```

**Browser:** Mở: http://localhost:5000/api/students/1

---

### 4.4. Cập nhật sinh viên (PUT /api/students/{id})

**Swagger:**
1. Click vào `PUT /api/students/{id}`
2. Click "Try it out"
3. Nhập `id = 1`
4. Nhập dữ liệu cập nhật:
```json
{
  "fullName": "Nguyễn Văn A (Đã cập nhật)",
  "email": "nguyenvana.updated@gmail.com",
  "dateOfBirth": "2000-01-15",
  "classId": 1
}
```
5. Click "Execute"
6. Kết quả trả về (200 OK):
```json
{
  "id": 1,
  "fullName": "Nguyễn Văn A (Đã cập nhật)",
  "email": "nguyenvana.updated@gmail.com",
  "dateOfBirth": "2000-01-15T00:00:00",
  "classId": 1
}
```

**Postman/cURL:**
```bash
curl -X PUT "http://localhost:5000/api/students/1" ^
  -H "Content-Type: application/json" ^
  -d "{\"fullName\":\"Nguyễn Văn A (Đã cập nhật)\",\"email\":\"nguyenvana.updated@gmail.com\",\"dateOfBirth\":\"2000-01-15\",\"classId\":1}"
```

---

### 4.5. Xóa sinh viên (DELETE /api/students/{id})

**Swagger:**
1. Click vào `DELETE /api/students/{id}`
2. Click "Try it out"
3. Nhập `id = 1`
4. Click "Execute"
5. Kết quả trả về (204 No Content) - Xóa thành công

**Postman/cURL:**
```bash
curl -X DELETE "http://localhost:5000/api/students/1"
```

---

## 5. KỊCH BẢN TEST ĐẦY ĐỦ

### Bước 1: Tạo 2 lớp học
```json
POST /api/classes
{
  "name": "Lớp IT01",
  "description": "Công nghệ thông tin"
}

POST /api/classes
{
  "name": "Lớp BA01",
  "description": "Quản trị kinh doanh"
}
```

### Bước 2: Xem danh sách lớp
```
GET /api/classes
```

### Bước 3: Thêm sinh viên vào lớp IT01 (classId = 1)
```json
POST /api/students
{
  "fullName": "Nguyễn Văn A",
  "email": "nguyenvana@gmail.com",
  "dateOfBirth": "2000-01-15",
  "classId": 1
}

POST /api/students
{
  "fullName": "Trần Thị B",
  "email": "tranthib@gmail.com",
  "dateOfBirth": "2000-05-20",
  "classId": 1
}
```

### Bước 4: Thêm sinh viên vào lớp BA01 (classId = 2)
```json
POST /api/students
{
  "fullName": "Lê Văn C",
  "email": "levanc@gmail.com",
  "dateOfBirth": "1999-12-10",
  "classId": 2
}
```

### Bước 5: Xem danh sách tất cả sinh viên
```
GET /api/students
```

### Bước 6: Xem chi tiết sinh viên ID = 1
```
GET /api/students/1
```

### Bước 7: Cập nhật thông tin sinh viên ID = 1
```json
PUT /api/students/1
{
  "fullName": "Nguyễn Văn A (Updated)",
  "email": "nguyenvana.new@gmail.com",
  "dateOfBirth": "2000-01-15",
  "classId": 2
}
```

### Bước 8: Xóa sinh viên ID = 3
```
DELETE /api/students/3
```

### Bước 9: Kiểm tra lại danh sách
```
GET /api/students
```

---

## 6. XỬ LÝ LỖI

### 6.1. Không tìm thấy (404 Not Found)
```
GET /api/classes/999
GET /api/students/999
PUT /api/students/999
DELETE /api/students/999
```
Kết quả: Status Code 404

### 6.2. Dữ liệu không hợp lệ (400 Bad Request)
```json
POST /api/students
{
  "fullName": "",
  "email": "invalid-email",
  "classId": 999
}
```

---

## 7. KIỂM TRA DATABASE

### Mở SQL Server Management Studio (SSMS)
- Server: `(localdb)\mssqllocaldb`
- Database: `StudentManagementDB`

### Xem dữ liệu:
```sql
-- Xem tất cả lớp
SELECT * FROM Classes

-- Xem tất cả sinh viên
SELECT * FROM Students

-- Xem sinh viên kèm tên lớp
SELECT s.Id, s.FullName, s.Email, s.DateOfBirth, c.Name as ClassName
FROM Students s
INNER JOIN Classes c ON s.ClassId = c.Id
```

---

## 8. DỪNG ỨNG DỤNG

Trong terminal PowerShell, nhấn: **Ctrl + C**

Hoặc chạy lệnh:
```bash
Stop-Process -Name "BT 2 BackEnd" -Force
```
