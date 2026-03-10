USE master;
GO

-- Nếu DB tồn tại thì mới đưa về SINGLE_USER và DROP
IF DB_ID('PBL3aDB') IS NOT NULL
BEGIN
    ALTER DATABASE PBL3aDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE PBL3aDB;
END
GO

-- Tạo lại DB
CREATE DATABASE PBL3aDB;
GO

USE PBL3aDB;
GO

-- Xóa bảng theo đúng thứ tự quan hệ khóa ngoại
IF OBJECT_ID('JoinClass', 'U') IS NOT NULL
    DROP TABLE JoinClass;
GO

IF OBJECT_ID('Class', 'U') IS NOT NULL
    DROP TABLE Class;
GO

IF OBJECT_ID('accountList', 'U') IS NOT NULL
    DROP TABLE accountList;
GO

-- Tạo bảng accountList
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

-- Dữ liệu mẫu accountList
INSERT INTO accountList
(Id, username, Password, name, phone, dateOfBirth, sex, Role)
VALUES
('A001','adminC','123456','Admin Chung','0900000001','1990-01-01','Male','AdminC'),
('A002','adminTC','123456','Admin Tai Chinh','0900000002','1991-02-02','Female','AdminTC'),
('A003','adminDD','123456','Admin Diem Danh','0900000003','1992-03-03','Male','AdminDD'),
('T001','teacher1','123456','Nguyen Van A','0900000004','1985-05-05','Male','Teacher'),
('S001','student1','123456','Tran Thi B','0900000005','2010-08-10','Female','Student'),
('S002','student2','123456','Le Van C','0900000006','2011-09-15','Male','Student'),
('S003','student3','123456','Pham Thi D','0900000007','2010-12-20','Female','Student');
GO

-- Tạo bảng Class
CREATE TABLE Class (
    classID INT IDENTITY(1,1) PRIMARY KEY,
    class_name NVARCHAR(100) NOT NULL,
    courseID INT NOT NULL,
    teacherID NVARCHAR(20) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    capacity INT NOT NULL,
    CONSTRAINT FK_Class_Teacher FOREIGN KEY (teacherID) REFERENCES accountList(Id)
);
GO

-- Tạo bảng JoinClass
CREATE TABLE JoinClass (
    AccountID NVARCHAR(20) NOT NULL,
    classID INT NOT NULL,
    PRIMARY KEY (AccountID, classID),
    CONSTRAINT FK_JoinClass_Account FOREIGN KEY (AccountID) REFERENCES accountList(Id),
    CONSTRAINT FK_JoinClass_Class FOREIGN KEY (classID) REFERENCES Class(classID)
);
GO

-- Dữ liệu mẫu Class
INSERT INTO Class (class_name, courseID, teacherID, start_date, end_date, capacity)
VALUES
(N'Lớp Toán 10A', 101, 'T001', '2026-04-01', '2026-06-30', 30),
(N'Lớp Lý 11A',   102, 'T001', '2026-04-05', '2026-07-05', 25),
(N'Lớp Anh văn 9A',103, 'T001', '2026-04-10', '2026-07-20', 35);
GO

-- Dữ liệu mẫu JoinClass
INSERT INTO JoinClass (AccountID, classID)
VALUES
('S001', 1),
('S002', 1),
('S003', 2),
('S001', 3);
GO

-- Kiểm tra
SELECT * FROM accountList;
SELECT * FROM Class;
SELECT * FROM JoinClass;
GO

-- Xem học sinh học lớp nào
SELECT 
    a.Id,
    a.name AS StudentName,
    a.username,
    c.classID,
    c.class_name,
    c.courseID,
    c.start_date,
    c.end_date
FROM JoinClass jc
JOIN accountList a ON jc.AccountID = a.Id
JOIN Class c ON jc.classID = c.classID
ORDER BY a.Id, c.classID;
GO