CREATE DATABASE QuanLyNhaHang;
GO
USE QuanLyNhaHang;
GO

-- Bảng tài khoản
CREATE TABLE tblTaiKhoan (
    Ten_TKhoan VARCHAR(50) PRIMARY KEY,
    Mat_Khau VARCHAR(100) NOT NULL,
    Loai_TKhoan INT NOT NULL CHECK (Loai_TKhoan IN (0, 1)) -- 0: Admin, 1: Người dùng
);

-- Bảng phòng ban
CREATE TABLE tblPhongBan (
    ID_PhongBan INT PRIMARY KEY IDENTITY(1,1),
    Ma_PhongBan VARCHAR(50) NOT NULL,
    Ten_PhongBan VARCHAR(150) NOT NULL,
    Dia_Chi VARCHAR(200),
    So_DienThoai VARCHAR(12),
    Ghi_Chu VARCHAR(300)
);

-- Bảng chức vụ
CREATE TABLE tblChucVu (
    ID_ChucVu INT PRIMARY KEY IDENTITY(1,1),
    Ma_ChucVu VARCHAR(50) NOT NULL,
    Ten_ChucVu VARCHAR(150) NOT NULL,
    Ghi_Chu VARCHAR(300)
);

-- Bảng nhân viên
CREATE TABLE tblNhanVien (
    ID_NhanVien INT PRIMARY KEY IDENTITY(1,1),
    Ten_TKhoan VARCHAR(50),
    Ho_Ten VARCHAR(100) NOT NULL,
    Ngay_Sinh DATETIME,
    Gioi_Tinh VARCHAR(10),
    Que_Quan VARCHAR(200),
    So_CMT VARCHAR(12) UNIQUE,
    Ngay_Cap DATETIME,
    Noi_Cap VARCHAR(100),
    So_DienThoai VARCHAR(12),
    Email VARCHAR(100),
    Dia_Chi VARCHAR(300),
    Duong_Dan_Anh VARCHAR(300),
    ID_ChucVu INT,
    ID_PhongBan INT,
    FOREIGN KEY (Ten_TKhoan) REFERENCES tblTaiKhoan(Ten_TKhoan) ON DELETE SET NULL,
    FOREIGN KEY (ID_ChucVu) REFERENCES tblChucVu(ID_ChucVu) ON DELETE SET NULL,
    FOREIGN KEY (ID_PhongBan) REFERENCES tblPhongBan(ID_PhongBan) ON DELETE SET NULL
);

-- Bảng bàn ăn (TableFood)
CREATE TABLE TableFood (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    status VARCHAR(100) NOT NULL
);

-- Bảng danh mục món ăn (FoodCategory)
CREATE TABLE FoodCategory (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL
);

-- Bảng món ăn (Food)
CREATE TABLE Food (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10,2) NOT NULL,
    idCategory INT,
    FOREIGN KEY (idCategory) REFERENCES FoodCategory(id) ON DELETE CASCADE
);

-- Bảng hóa đơn (Bill)
CREATE TABLE Bill (
    id INT PRIMARY KEY IDENTITY(1,1),
    date DATETIME NOT NULL DEFAULT GETDATE(),
    idTable INT,
    status INT NOT NULL CHECK (status IN (0, 1)), -- 0: Chưa thanh toán, 1: Đã thanh toán
    FOREIGN KEY (idTable) REFERENCES TableFood(id) ON DELETE SET NULL
);

-- Bảng chi tiết hóa đơn (BillInfo)
CREATE TABLE BillInfo (
    id INT PRIMARY KEY IDENTITY(1,1),
    idBill INT,
    idFood INT,
    count INT NOT NULL CHECK (count > 0),
    FOREIGN KEY (idBill) REFERENCES Bill(id) ON DELETE CASCADE,
    FOREIGN KEY (idFood) REFERENCES Food(id) ON DELETE CASCADE
);


