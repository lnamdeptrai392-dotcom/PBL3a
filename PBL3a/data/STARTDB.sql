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
-- ================= ADMIN & TEACHER =================
('A001','adminC','123456','Admin Chung','0900000001','1990-01-01','Male','AdminC'),
('A002','adminTC','123456','Admin Tai Chinh','0900000002','1991-02-02','Female','AdminTC'),
('A003','adminDD','123456','Admin Diem Danh','0900000003','1992-03-03','Male','AdminDD'),
('T001','teacher1','123456','Nguyen Van A','0900000004','1985-05-05','Male','Teacher'),
('T002','teacher2','123456','Nguyen Van B','0900000005','1985-05-05','Male','Teacher'),
('T003','teacher3','123456','Nguyen Van C','0900000006','1985-05-05','Male','Teacher'),

-- ================= NỮ (MÃ 101) =================
-- Khóa 2009
('10109001','10109001','123456','Nguyen Thi Anh','0910109001','2009-01-10','Female','Student'),
('10109002','10109002','123456','Le Ngoc Bich','0910109002','2009-02-15','Female','Student'),
('10109003','10109003','123456','Tran Thu Chau','0910109003','2009-03-20','Female','Student'),
('10109004','10109004','123456','Pham Mai Dung','0910109004','2009-04-05','Female','Student'),
('10109005','10109005','123456','Vu Thanh Ha','0910109005','2009-05-12','Female','Student'),
('10109006','10109006','123456','Dang Bich Ngoc','0910109006','2009-06-25','Female','Student'),
('10109007','10109007','123456','Ho Truc Dao','0910109007','2009-07-08','Female','Student'),
('10109008','10109008','123456','Hoang Mai Lan','0910109008','2009-08-30','Female','Student'),
('10109009','10109009','123456','Phan Thi Mo','0910109009','2009-09-14','Female','Student'),
('10109010','10109010','123456','Do Thu Huong','0910109010','2009-10-18','Female','Student'),

-- Khóa 2010
('10110001','10110001','123456','Nguyen Tu Anh','0910110001','2010-01-11','Female','Student'),
('10110002','10110002','123456','Le Bao Binh','0910110002','2010-02-16','Female','Student'),
('10110003','10110003','123456','Tran Kim Chi','0910110003','2010-03-21','Female','Student'),
('10110004','10110004','123456','Pham My Duyen','0910110004','2010-04-06','Female','Student'),
('10110005','10110005','123456','Vu Thu Hien','0910110005','2010-05-13','Female','Student'),
('10110006','10110006','123456','Dang Ngoc Mai','0910110006','2010-06-26','Female','Student'),
('10110007','10110007','123456','Ho Yen Nhi','0910110007','2010-07-09','Female','Student'),
('10110008','10110008','123456','Hoang Kieu Oanh','0910110008','2010-08-31','Female','Student'),
('10110009','10110009','123456','Phan Diem Quynh','0910110009','2010-09-15','Female','Student'),
('10110010','10110010','123456','Do Thanh Thao','0910110010','2010-10-19','Female','Student'),

-- Khóa 2011
('10111001','10111001','123456','Nguyen Ngoc Anh','0910111001','2011-01-12','Female','Student'),
('10111002','10111002','123456','Le Nhu Binh','0910111002','2011-02-17','Female','Student'),
('10111003','10111003','123456','Tran Bao Chau','0910111003','2011-03-22','Female','Student'),
('10111004','10111004','123456','Pham Thuy Dung','0910111004','2011-04-07','Female','Student'),
('10111005','10111005','123456','Vu Thuy Hoa','0910111005','2011-05-14','Female','Student'),
('10111006','10111006','123456','Dang Thanh Ngoc','0910111006','2011-06-27','Female','Student'),
('10111007','10111007','123456','Ho Thao Nhi','0910111007','2011-07-10','Female','Student'),
('10111008','10111008','123456','Hoang Ngoc Oanh','0910111008','2011-08-01','Female','Student'),
('10111009','10111009','123456','Phan Truc Quynh','0910111009','2011-09-16','Female','Student'),
('10111010','10111010','123456','Do Phuong Thao','0910111010','2011-10-20','Female','Student'),

-- Khóa 2012
('10112001','10112001','123456','Nguyen Quynh Anh','0910112001','2012-01-13','Female','Student'),
('10112002','10112002','123456','Le Thanh Binh','0910112002','2012-02-18','Female','Student'),
('10112003','10112003','123456','Tran Minh Chau','0910112003','2012-03-23','Female','Student'),
('10112004','10112004','123456','Pham Ngoc Dung','0910112004','2012-04-08','Female','Student'),
('10112005','10112005','123456','Vu Ngoc Hoa','0910112005','2012-05-15','Female','Student'),
('10112006','10112006','123456','Dang Xuan Ngoc','0910112006','2012-06-28','Female','Student'),
('10112007','10112007','123456','Ho Tu Nhi','0910112007','2012-07-11','Female','Student'),
('10112008','10112008','123456','Hoang Tu Oanh','0910112008','2012-08-02','Female','Student'),
('10112009','10112009','123456','Phan Nhu Quynh','0910112009','2012-09-17','Female','Student'),
('10112010','10112010','123456','Do Thu Thao','0910112010','2012-10-21','Female','Student'),

-- Khóa 2013
('10113001','10113001','123456','Nguyen Lan Anh','0910113001','2013-01-14','Female','Student'),
('10113002','10113002','123456','Le Hoa Binh','0910113002','2013-02-19','Female','Student'),
('10113003','10113003','123456','Tran Quynh Chau','0910113003','2013-03-24','Female','Student'),
('10113004','10113004','123456','Pham Phuong Dung','0910113004','2013-04-09','Female','Student'),
('10113005','10113005','123456','Vu Mai Hoa','0910113005','2013-05-16','Female','Student'),
('10113006','10113006','123456','Dang Kieu Ngoc','0910113006','2013-06-29','Female','Student'),
('10113007','10113007','123456','Ho My Nhi','0910113007','2013-07-12','Female','Student'),
('10113008','10113008','123456','Hoang Cam Oanh','0910113008','2013-08-03','Female','Student'),
('10113009','10113009','123456','Phan Xuan Quynh','0910113009','2013-09-18','Female','Student'),
('10113010','10113010','123456','Do Huong Thao','0910113010','2013-10-22','Female','Student'),



-- ================= NAM (MÃ 102) =================
-- Khóa 2009
('10209001','10209001','123456','Nguyen Van An','0910209001','2009-01-15','Male','Student'),
('10209002','10209002','123456','Le Quoc Bao','0910209002','2009-02-20','Male','Student'),
('10209003','10209003','123456','Tran Dinh Chien','0910209003','2009-03-25','Male','Student'),
('10209004','10209004','123456','Pham Khac Cuong','0910209004','2009-04-10','Male','Student'),
('10209005','10209005','123456','Vu Hai Dang','0910209005','2009-05-17','Male','Student'),
('10209006','10209006','123456','Dang Minh Hoang','0910209006','2009-06-30','Male','Student'),
('10209007','10209007','123456','Ho Trong Hung','0910209007','2009-07-13','Male','Student'),
('10209008','10209008','123456','Hoang Tuan Kiet','0910209008','2009-08-04','Male','Student'),
('10209009','10209009','123456','Phan Thanh Long','0910209009','2009-09-19','Male','Student'),
('10209010','10209010','123456','Do Quang Minh','0910209010','2009-10-23','Male','Student'),

-- Khóa 2010
('10210001','10210001','123456','Nguyen Binh An','0910210001','2010-01-16','Male','Student'),
('10210002','10210002','123456','Le Gia Bao','0910210002','2010-02-21','Male','Student'),
('10210003','10210003','123456','Tran Quy Chien','0910210003','2010-03-26','Male','Student'),
('10210004','10210004','123456','Pham Hung Cuong','0910210004','2010-04-11','Male','Student'),
('10210005','10210005','123456','Vu Minh Dang','0910210005','2010-05-18','Male','Student'),
('10210006','10210006','123456','Dang Viet Hoang','0910210006','2010-07-01','Male','Student'),
('10210007','10210007','123456','Ho Viet Hung','0910210007','2010-07-14','Male','Student'),
('10210008','10210008','123456','Hoang Anh Kiet','0910210008','2010-08-05','Male','Student'),
('10210009','10210009','123456','Phan Hai Long','0910210009','2010-09-20','Male','Student'),
('10210010','10210010','123456','Do Nhat Minh','0910210010','2010-10-24','Male','Student'),

-- Khóa 2011
('10211001','10211001','123456','Nguyen Hoang An','0910211001','2011-01-17','Male','Student'),
('10211002','10211002','123456','Le Chi Bao','0910211002','2011-02-22','Male','Student'),
('10211003','10211003','123456','Tran Ngoc Chien','0910211003','2011-03-27','Male','Student'),
('10211004','10211004','123456','Pham Manh Cuong','0910211004','2011-04-12','Male','Student'),
('10211005','10211005','123456','Vu Tien Dang','0910211005','2011-05-19','Male','Student'),
('10211006','10211006','123456','Dang Huy Hoang','0910211006','2011-07-02','Male','Student'),
('10211007','10211007','123456','Ho Quoc Hung','0910211007','2011-07-15','Male','Student'),
('10211008','10211008','123456','Hoang Tuan Kiet','0910211008','2011-08-06','Male','Student'),
('10211009','10211009','123456','Phan Hoang Long','0910211009','2011-09-21','Male','Student'),
('10211010','10211010','123456','Do Tuan Minh','0910211010','2011-10-25','Male','Student'),

-- Khóa 2012
('10212001','10212001','123456','Nguyen Thien An','0910212001','2012-01-18','Male','Student'),
('10212002','10212002','123456','Le Duc Bao','0910212002','2012-02-23','Male','Student'),
('10212003','10212003','123456','Tran Duc Chien','0910212003','2012-03-28','Male','Student'),
('10212004','10212004','123456','Pham Quoc Cuong','0910212004','2012-04-13','Male','Student'),
('10212005','10212005','123456','Vu Dang Khoa','0910212005','2012-05-20','Male','Student'),
('10212006','10212006','123456','Dang Bao Hoang','0910212006','2012-07-03','Male','Student'),
('10212007','10212007','123456','Ho Tuan Hung','0910212007','2012-07-16','Male','Student'),
('10212008','10212008','123456','Hoang Minh Kiet','0910212008','2012-08-07','Male','Student'),
('10212009','10212009','123456','Phan Tien Long','0910212009','2012-09-22','Male','Student'),
('10212010','10212010','123456','Do Binh Minh','0910212010','2012-10-26','Male','Student'),

-- Khóa 2013
('10213001','10213001','123456','Nguyen Truong An','0910213001','2013-01-19','Male','Student'),
('10213002','10213002','123456','Le Tuan Bao','0910213002','2013-02-24','Male','Student'),
('10213003','10213003','123456','Tran Huu Chien','0910213003','2013-03-29','Male','Student'),
('10213004','10213004','123456','Pham Tien Cuong','0910213004','2013-04-14','Male','Student'),
('10213005','10213005','123456','Vu Tuan Dang','0910213005','2013-05-21','Male','Student'),
('10213006','10213006','123456','Dang Tuan Hoang','0910213006','2013-07-04','Male','Student'),
('10213007','10213007','123456','Ho Manh Hung','0910213007','2013-07-17','Male','Student'),
('10213008','10213008','123456','Hoang Quoc Kiet','0910213008','2013-08-08','Male','Student'),
('10213009','10213009','123456','Phan Duc Long','0910213009','2013-09-23','Male','Student'),
('10213010','10213010','123456','Do Hai Minh','0910213010','2013-10-27','Male','Student');

GO


-- Tạo bảng Class
CREATE TABLE Class (
    classID NVARCHAR(20) PRIMARY KEY,
    class_name NVARCHAR(100) NOT NULL,
    courseID NVARCHAR(20) NOT NULL,
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
    classID NVARCHAR(20) NOT NULL,
    PRIMARY KEY (AccountID, classID),
    CONSTRAINT FK_JoinClass_Account FOREIGN KEY (AccountID) REFERENCES accountList(Id),
    CONSTRAINT FK_JoinClass_Class FOREIGN KEY (classID) REFERENCES Class(classID)
);
GO

-- Dữ liệu mẫu Class
INSERT INTO Class (classID, class_name, courseID, teacherID, start_date, end_date, capacity)
VALUES
-- ================= TOÁN (T01) =================
(N'T01.0426', N'Lớp Toán 10A1', 'T01', 'T001', '2026-04-01', '2026-08-01', 30),
(N'T01.0726', N'Lớp Toán 10A2', 'T01', 'T001', '2026-07-01', '2026-11-01', 30),
(N'T01.0125', N'Lớp Toán 10A3', 'T01', 'T001', '2025-01-05', '2025-05-05', 30),
(N'T01.0825', N'Lớp Toán 11A1', 'T01', 'T001', '2025-08-10', '2025-12-10', 35),
(N'T01.0126', N'Lớp Toán 12A1', 'T01', 'T001', '2026-01-15', '2026-05-15', 30),
(N'T01.0926', N'Lớp Toán 10B1', 'T01', 'T001', '2026-09-01', '2027-01-01', 25),
-- ================= VĂN (V01) =================
(N'V01.0225', N'Lớp Văn 10A1', 'V01', 'T001', '2025-02-01', '2025-06-01', 35),
(N'V01.0925', N'Lớp Văn 11A1', 'V01', 'T001', '2025-09-05', '2026-01-05', 30),
(N'V01.0326', N'Lớp Văn 12A1', 'V01', 'T001', '2026-03-10', '2026-07-10', 30),
(N'V01.1026', N'Lớp Văn 10B1', 'V01', 'T001', '2026-10-01', '2027-02-01', 25),
-- ================= HÓA (H01) =================
(N'H01.0325', N'Lớp Hóa 10A1', 'H01', 'T001', '2025-03-01', '2025-07-01', 25),
(N'H01.1025', N'Lớp Hóa 11A1', 'H01', 'T001', '2025-10-15', '2026-02-15', 30),
(N'H01.0426', N'Lớp Hóa 12A1', 'H01', 'T001', '2026-04-05', '2026-08-05', 30),
(N'H01.1126', N'Lớp Hóa 10B1', 'H01', 'T001', '2026-11-01', '2027-03-01', 25),
-- ================= LÝ (L01) =================
(N'L01.0425', N'Lớp Lý 10A1', 'L01', 'T001', '2025-04-10', '2025-08-10', 30),
(N'L01.0526', N'Lớp Lý 11A1', 'L01', 'T001', '2026-05-01', '2026-09-01', 25),
(N'L01.1125', N'Lớp Lý 11A2', 'L01', 'T001', '2025-11-01', '2026-03-01', 25),
(N'L01.0626', N'Lớp Lý 12A1', 'L01', 'T001', '2026-06-15', '2026-10-15', 30),
(N'L01.1226', N'Lớp Lý 10B1', 'L01', 'T001', '2026-12-01', '2027-04-01', 25),
-- ================= SINH (S01) =================
(N'S01.0525', N'Lớp Sinh 10A1', 'S01', 'T001', '2025-05-01', '2025-09-01', 25),
(N'S01.1225', N'Lớp Sinh 11A1', 'S01', 'T001', '2025-12-10', '2026-04-10', 30),
(N'S01.0726', N'Lớp Sinh 12A1', 'S01', 'T001', '2026-07-05', '2026-11-05', 30),
-- ================= TIẾNG ANH (NN01) =================
(N'NN01.0226', N'Lớp Tiếng Anh 9A1','NN01', 'T001', '2026-02-01', '2026-06-01', 35),
(N'NN01.0125', N'Lớp Tiếng Anh 10A1', 'NN01', 'T001', '2025-01-15', '2025-05-15', 35),
(N'NN01.0625', N'Lớp Tiếng Anh IELTS 1', 'NN01', 'T001', '2025-06-01', '2025-10-01', 20),
(N'NN01.0526', N'Lớp Tiếng Anh 11A1', 'NN01', 'T001', '2026-05-10', '2026-09-10', 35),
(N'NN01.0826', N'Lớp Tiếng Anh Giao Tiếp', 'NN01', 'T001', '2026-08-15', '2026-12-15', 25),
-- ================= TIẾNG NHẬT (NN02) =================
(N'NN02.0225', N'Lớp Tiếng Nhật N5', 'NN02', 'T001', '2025-02-10', '2025-06-10', 25),
(N'NN02.0725', N'Lớp Tiếng Nhật N4', 'NN02', 'T001', '2025-07-15', '2025-11-15', 20),
(N'NN02.0326', N'Lớp Tiếng Nhật N5 - K2', 'NN02', 'T001', '2026-03-01', '2026-07-01', 25),
(N'NN02.0926', N'Lớp Tiếng Nhật N3', 'NN02', 'T001', '2026-09-10', '2027-01-10', 20),
-- ================= TIẾNG TRUNG (NN03) =================
(N'NN03.0325', N'Lớp Tiếng Trung HSK1', 'NN03', 'T001', '2025-03-20', '2025-07-20', 30),
(N'NN03.0825', N'Lớp Tiếng Trung HSK2', 'NN03', 'T001', '2025-08-05', '2025-12-05', 25),
(N'NN03.0426', N'Lớp Tiếng Trung HSK3', 'NN03', 'T001', '2026-04-15', '2026-08-15', 25),
(N'NN03.1026', N'Lớp Tiếng Trung Giao Tiếp', 'NN03', 'T001', '2026-10-20', '2027-02-20', 30);
GO

-- Dữ liệu mẫu JoinClass
INSERT INTO JoinClass (AccountID, classID)
VALUES
('10109001', 'T01.0426'),
('10109002', 'T01.0426'),
('10209001', 'V01.0225'),
('10109001', 'NN01.0226');
GO


IF OBJECT_ID('dbo.Attendance', 'U') IS NOT NULL DROP TABLE dbo.Attendance;
GO
CREATE TABLE Attendance
(
    AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID NVARCHAR(20) NOT NULL,
    ClassID NVARCHAR(20) NOT NULL,
    AttendanceDate DATE NOT NULL,
    Status NVARCHAR(20) NOT NULL,
    Note NVARCHAR(255) NULL,
    CONSTRAINT FK_Attendance_Account FOREIGN KEY (AccountID) REFERENCES accountList(Id),
    CONSTRAINT FK_Attendance_Class FOREIGN KEY (ClassID) REFERENCES Class(classID),
    CONSTRAINT UQ_Attendance UNIQUE (AccountID, ClassID, AttendanceDate)
);
GO
-- Dữ liệu mẫu Attendance
INSERT INTO Attendance (AccountID, ClassID, AttendanceDate, Status, Note)
VALUES
('10109001', 'T01.0426', '2026-03-10', N'Có mặt', N''),
('10109002', 'T01.0426', '2026-03-10', N'Vắng', N'Nghỉ có phép'),
('10209001', 'V01.0225', '2026-03-10', N'Muộn', N'Đến trễ 10 phút'),
('10109001', 'NN01.0226', '2026-03-10', N'Có mặt', N'');
GO

IF OBJECT_ID('dbo.HocPhi', 'U') IS NOT NULL DROP TABLE dbo.HocPhi;
GO
CREATE TABLE HocPhi
(
    HocPhiID INT IDENTITY(1,1) PRIMARY KEY,
    AccountID NVARCHAR(20) NOT NULL,
    ClassID NVARCHAR(20) NOT NULL,
    TuitionMonth INT NOT NULL,
    TuitionYear INT NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa đóng',
    NgayDong DATE NULL,
    GhiChu NVARCHAR(255) NULL,
    CONSTRAINT FK_HocPhi_Account FOREIGN KEY (AccountID) REFERENCES accountList(Id),
    CONSTRAINT FK_HocPhi_Class FOREIGN KEY (ClassID) REFERENCES Class(classID),
    CONSTRAINT UQ_HocPhi UNIQUE (AccountID, ClassID, TuitionMonth, TuitionYear)
);
GO
-- Dữ liệu mẫu Học phí
INSERT INTO HocPhi (AccountID, ClassID, TuitionMonth, TuitionYear, SoTien, TrangThai, NgayDong, GhiChu)
VALUES
('10109001', 'T01.0426', 3, 2026, 500000, N'Đã đóng', '2026-03-05', N'Đóng đủ'),
('10109002', 'T01.0426', 3, 2026, 500000, N'Chưa đóng', NULL, NULL),
('10209001', 'V01.0225', 3, 2026, 600000, N'Đã đóng', '2026-03-07', N''),
('10109001', 'NN01.0226', 3, 2026, 550000, N'Chưa đóng', NULL, N'');
GO

-- Các bảng Lương GV, Khoản Thu, Khoản Chi
IF OBJECT_ID('dbo.LuongGV', 'U') IS NOT NULL DROP TABLE dbo.LuongGV;
GO
CREATE TABLE LuongGV
(
    LuongID INT IDENTITY(1,1) PRIMARY KEY,
    TeacherID NVARCHAR(20) NOT NULL,
    SalaryMonth INT NOT NULL,
    SalaryYear INT NOT NULL,
    SoLopDay INT NOT NULL DEFAULT 0,
    SoBuoiDay INT NOT NULL DEFAULT 0,
    LuongCoBan DECIMAL(18,0) NOT NULL DEFAULT 0,
    Thuong DECIMAL(18,0) NOT NULL DEFAULT 0,
    Phat DECIMAL(18,0) NOT NULL DEFAULT 0,
    TongLuong DECIMAL(18,0) NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Chưa thanh toán',
    NgayThanhToan DATE NULL,
    GhiChu NVARCHAR(255) NULL,
    CONSTRAINT FK_LuongGV_Account FOREIGN KEY (TeacherID) REFERENCES accountList(Id),
    CONSTRAINT UQ_LuongGV UNIQUE (TeacherID, SalaryMonth, SalaryYear)
);
GO
INSERT INTO LuongGV (TeacherID, SalaryMonth, SalaryYear, SoLopDay, SoBuoiDay, LuongCoBan, Thuong, Phat, TongLuong, TrangThai, NgayThanhToan, GhiChu)
VALUES ('T001', 3, 2026, 3, 20, 8000000, 500000, 0, 8500000, N'Chưa thanh toán', NULL, N'Lương tháng 3'),
('T002', 4, 2026, 3, 20, 8000000, 500000, 0, 8500000, N'Chưa thanh toán', NULL, N'Lương tháng 3'),
('T003', 5, 2026, 3, 20, 8000000, 500000, 0, 8500000, N'Chưa thanh toán', NULL, N'Lương tháng 3');
GO

IF OBJECT_ID('dbo.KhoanThu', 'U') IS NOT NULL DROP TABLE dbo.KhoanThu;
GO
CREATE TABLE KhoanThu
(
    ThuID INT IDENTITY(1,1) PRIMARY KEY,
    ThuMonth INT NOT NULL,
    ThuYear INT NOT NULL,
    LoaiThu NVARCHAR(100) NOT NULL,
    NoiDung NVARCHAR(255) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    NgayThu DATE NOT NULL,
    GhiChu NVARCHAR(255) NULL
);
GO
INSERT INTO KhoanThu (ThuMonth, ThuYear, LoaiThu, NoiDung, SoTien, NgayThu, GhiChu)
VALUES
(3, 2026, N'Học phí', N'Thu học phí lớp Toán 10A', 1000000, '2026-03-05', N'Từ học sinh 10109001, 10109002'),
(3, 2026, N'Học phí', N'Thu học phí lớp Anh văn', 550000, '2026-03-06', NULL),
(3, 2026, N'Thu khác', N'Phí tài liệu', 200000, '2026-03-08', N'');
GO

IF OBJECT_ID('dbo.KhoanChi', 'U') IS NOT NULL DROP TABLE dbo.KhoanChi;
GO
CREATE TABLE KhoanChi
(
    ChiID INT IDENTITY(1,1) PRIMARY KEY,
    ChiMonth INT NOT NULL,
    ChiYear INT NOT NULL,
    LoaiChi NVARCHAR(100) NOT NULL,
    NoiDung NVARCHAR(255) NOT NULL,
    SoTien DECIMAL(18,0) NOT NULL,
    NgayChi DATE NOT NULL,
    GhiChu NVARCHAR(255) NULL
);
GO
INSERT INTO KhoanChi (ChiMonth, ChiYear, LoaiChi, NoiDung, SoTien, NgayChi, GhiChu)
VALUES
(3, 2026, N'Lương GV', N'Thanh toán lương giáo viên T001', 8500000, '2026-03-25', N'Tháng 3'),
(3, 2026, N'Điện nước', N'Tiền điện nước trung tâm', 1200000, '2026-03-20', NULL),
(3, 2026, N'Văn phòng phẩm', N'Mua bút, giấy, sổ', 350000, '2026-03-12', N'');
GO
IF OBJECT_ID('teacherInfo', 'U') IS NOT NULL
    DROP TABLE teacherInfo;
GO

CREATE TABLE teacherInfo (
    Id NVARCHAR(20) PRIMARY KEY,
    subject NVARCHAR(100) NOT NULL,
    CONSTRAINT FK_teacherInfo_accountList
        FOREIGN KEY (Id) REFERENCES accountList(Id)
);
GO
INSERT INTO teacherInfo (Id, subject)
VALUES
('T001', N'Toán'),
('T002', N'Văn'),
('T003', N'Anh');
GO