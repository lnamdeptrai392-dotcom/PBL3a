
USE PBL3aDB
GO

-- Nếu bảng đã tồn tại thì xóa
IF OBJECT_ID('accountList', 'U') IS NOT NULL
    DROP TABLE accountList;
GO

-- Tạo bảng mới
CREATE TABLE accountList (
    Id NVARCHAR(20) PRIMARY KEY,
    username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    name NVARCHAR(100) NOT NULL,
    phone NVARCHAR(20),
    dateOfBirth DATE,
    sex NVARCHAR(10),
    Role NVARCHAR(20) NOT NULL
);
GO

-- Thêm dữ liệu test
INSERT INTO accountList
(Id, username, Password, name, phone, dateOfBirth, sex, Role)
VALUES
('A001','adminC','123456','Admin Chung','0900000001','1990-01-01','Male','AdminC'),
('A002','adminTC','123456','Admin Tai Chinh','0900000002','1991-02-02','Female','AdminTC'),
('A003','adminDD','123456','Admin Diem Danh','0900000003','1992-03-03','Male','AdminDD'),
('T001','teacher1','123456','Nguyen Van A','0900000004','1985-05-05','Male','Teacher'),
('S001','student1','123456','Tran Thi B','0900000005','2010-08-10','Female','Student');
GO

-- Kiểm tra dữ liệu
SELECT * FROM accountList;