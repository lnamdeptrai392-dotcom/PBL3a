CREATE DATABASE PBL3aDB;
GO

USE PBL3aDB;
GO

CREATE TABLE accountList (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL
);

INSERT INTO accountList (Username, Password, Role)
VALUES
('adminc', '123', 'AdminC'),
('admindd', '123', 'AdminDD'),
('admintc', '123', 'AdminTC');