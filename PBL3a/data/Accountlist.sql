-- Tạo bảng accountlist
CREATE TABLE accountlist (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

-- Dữ liệu mẫu để test login
INSERT INTO accountlist (Username, Password, Role)
VALUES 
('admin', '123', 'AdminC'),
('teacher1', '123', 'Teacher'),
('student1', '123', 'Student');