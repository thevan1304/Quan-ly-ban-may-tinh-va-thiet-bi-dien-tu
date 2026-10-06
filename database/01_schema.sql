-- SQL Server schema for the computer and electronics sales application.
-- Run in SSMS connected to SQLEXPRESS, or with sqlcmd -S ".\SQLEXPRESS" -E -b -i database\01_schema.sql
IF DB_ID(N'QuanLyBanMayTinh') IS NULL
BEGIN
    EXEC(N'CREATE DATABASE QuanLyBanMayTinh');
END;
GO

USE QuanLyBanMayTinh;
GO

IF OBJECT_ID(N'dbo.DanhMuc', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DanhMuc (
        MaDanhMuc NVARCHAR(30) NOT NULL CONSTRAINT PK_DanhMuc PRIMARY KEY,
        TenDanhMuc NVARCHAR(150) NOT NULL,
        MoTa NVARCHAR(500) NULL,
        CONSTRAINT CK_DanhMuc_Ten CHECK (LEN(LTRIM(RTRIM(TenDanhMuc))) > 0)
    );
END;
GO

IF OBJECT_ID(N'dbo.SanPham', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SanPham (
        MaSanPham NVARCHAR(30) NOT NULL CONSTRAINT PK_SanPham PRIMARY KEY,
        TenSanPham NVARCHAR(200) NOT NULL,
        MaDanhMuc NVARCHAR(30) NOT NULL,
        GiaBan DECIMAL(18, 2) NOT NULL,
        SoLuong INT NOT NULL,
        CONSTRAINT FK_SanPham_DanhMuc FOREIGN KEY (MaDanhMuc) REFERENCES dbo.DanhMuc(MaDanhMuc),
        CONSTRAINT CK_SanPham_Ten CHECK (LEN(LTRIM(RTRIM(TenSanPham))) > 0),
        CONSTRAINT CK_SanPham_GiaBan CHECK (GiaBan >= 0),
        CONSTRAINT CK_SanPham_SoLuong CHECK (SoLuong >= 0)
    );
    CREATE INDEX IX_SanPham_MaDanhMuc ON dbo.SanPham(MaDanhMuc);
END;
GO

IF OBJECT_ID(N'dbo.MaGiamGia', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.MaGiamGia (
        MaGiamGia NVARCHAR(30) NOT NULL CONSTRAINT PK_MaGiamGia PRIMARY KEY,
        TenChuongTrinh NVARCHAR(200) NOT NULL,
        LoaiGiam NVARCHAR(20) NOT NULL,
        GiaTriGiam DECIMAL(18, 2) NOT NULL,
        DonToiThieu DECIMAL(18, 2) NOT NULL CONSTRAINT DF_MaGiamGia_DonToiThieu DEFAULT (0),
        GiamToiDa DECIMAL(18, 2) NULL,
        NgayBatDau DATE NOT NULL,
        NgayKetThuc DATE NOT NULL,
        SoLuong INT NOT NULL,
        TrangThai NVARCHAR(30) NOT NULL,
        GhiChu NVARCHAR(500) NULL,
        CONSTRAINT CK_MaGiamGia_Loai CHECK (LoaiGiam IN (N'Phần trăm', N'Số tiền')),
        CONSTRAINT CK_MaGiamGia_GiaTri CHECK (GiaTriGiam > 0 AND (LoaiGiam <> N'Phần trăm' OR GiaTriGiam <= 100)),
        CONSTRAINT CK_MaGiamGia_DonToiThieu CHECK (DonToiThieu >= 0),
        CONSTRAINT CK_MaGiamGia_GiamToiDa CHECK (GiamToiDa IS NULL OR GiamToiDa >= 0),
        CONSTRAINT CK_MaGiamGia_Ngay CHECK (NgayKetThuc >= NgayBatDau),
        CONSTRAINT CK_MaGiamGia_SoLuong CHECK (SoLuong >= 0),
        CONSTRAINT CK_MaGiamGia_TrangThai CHECK (TrangThai IN (N'Đang hoạt động', N'Chưa bắt đầu', N'Đã hết hạn', N'Tạm khóa'))
    );
END;
GO

IF OBJECT_ID(N'dbo.DonHang', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.DonHang (
        MaDonHang NVARCHAR(30) NOT NULL CONSTRAINT PK_DonHang PRIMARY KEY,
        KhachHang NVARCHAR(150) NOT NULL,
        SoDienThoai NVARCHAR(20) NULL,
        NgayDat DATE NOT NULL,
        TongTien DECIMAL(18, 2) NOT NULL,
        MaGiamGia NVARCHAR(30) NULL,
        GiamGia DECIMAL(18, 2) NOT NULL CONSTRAINT DF_DonHang_GiamGia DEFAULT (0),
        ThanhTien AS (TongTien - GiamGia) PERSISTED,
        TrangThai NVARCHAR(30) NOT NULL,
        GhiChu NVARCHAR(500) NULL,
        CONSTRAINT FK_DonHang_MaGiamGia FOREIGN KEY (MaGiamGia) REFERENCES dbo.MaGiamGia(MaGiamGia),
        CONSTRAINT CK_DonHang_TongTien CHECK (TongTien >= 0),
        CONSTRAINT CK_DonHang_GiamGia CHECK (GiamGia >= 0 AND GiamGia <= TongTien),
        CONSTRAINT CK_DonHang_TrangThai CHECK (TrangThai IN (N'Chờ xử lý', N'Đã xác nhận', N'Đang giao', N'Hoàn thành', N'Đã hủy'))
    );
    CREATE INDEX IX_DonHang_NgayDat_TrangThai ON dbo.DonHang(NgayDat, TrangThai);
END;
GO

-- One order can contain several products. The current order screen does not edit these rows yet.
IF OBJECT_ID(N'dbo.ChiTietDonHang', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.ChiTietDonHang (
        MaDonHang NVARCHAR(30) NOT NULL,
        MaSanPham NVARCHAR(30) NOT NULL,
        SoLuong INT NOT NULL,
        DonGia DECIMAL(18, 2) NOT NULL,
        ThanhTien AS (CONVERT(DECIMAL(18, 2), SoLuong * DonGia)) PERSISTED,
        CONSTRAINT PK_ChiTietDonHang PRIMARY KEY (MaDonHang, MaSanPham),
        CONSTRAINT FK_ChiTietDonHang_DonHang FOREIGN KEY (MaDonHang) REFERENCES dbo.DonHang(MaDonHang),
        CONSTRAINT FK_ChiTietDonHang_SanPham FOREIGN KEY (MaSanPham) REFERENCES dbo.SanPham(MaSanPham),
        CONSTRAINT CK_ChiTietDonHang_SoLuong CHECK (SoLuong > 0),
        CONSTRAINT CK_ChiTietDonHang_DonGia CHECK (DonGia >= 0)
    );
    CREATE INDEX IX_ChiTietDonHang_MaSanPham ON dbo.ChiTietDonHang(MaSanPham);
END;
GO

IF OBJECT_ID(N'dbo.BaoHanh', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.BaoHanh (
        MaPhieu NVARCHAR(30) NOT NULL CONSTRAINT PK_BaoHanh PRIMARY KEY,
        MaSanPham NVARCHAR(30) NOT NULL,
        TenKhachHang NVARCHAR(150) NOT NULL,
        SoDienThoai NVARCHAR(20) NULL,
        NgayMua DATE NOT NULL,
        ThoiHan INT NOT NULL,
        NgayHetHan DATE NOT NULL,
        GhiChu NVARCHAR(500) NULL,
        CONSTRAINT FK_BaoHanh_SanPham FOREIGN KEY (MaSanPham) REFERENCES dbo.SanPham(MaSanPham),
        CONSTRAINT CK_BaoHanh_ThoiHan CHECK (ThoiHan BETWEEN 1 AND 60),
        CONSTRAINT CK_BaoHanh_NgayHetHan CHECK (NgayHetHan = DATEADD(MONTH, ThoiHan, NgayMua))
    );
    CREATE INDEX IX_BaoHanh_MaSanPham ON dbo.BaoHanh(MaSanPham);
END;
GO

-- The warranty status changes with the date, so it is calculated when read.
CREATE OR ALTER VIEW dbo.vwBaoHanh AS
SELECT MaPhieu, MaSanPham, TenKhachHang, SoDienThoai, NgayMua, ThoiHan,
       NgayHetHan,
       CASE WHEN NgayHetHan >= CONVERT(DATE, GETDATE())
            THEN N'Còn bảo hành' ELSE N'Hết bảo hành' END AS TrangThai,
       GhiChu
FROM dbo.BaoHanh;
GO

-- Revenue counts completed orders only; canceled and pending orders contribute zero.
CREATE OR ALTER VIEW dbo.vwDoanhThuNgay AS
SELECT NgayDat AS Ngay,
       COUNT(*) AS SoDon,
       SUM(CASE WHEN TrangThai = N'Hoàn thành' THEN 1 ELSE 0 END) AS HoanThanh,
       SUM(CASE WHEN TrangThai = N'Đã hủy' THEN 1 ELSE 0 END) AS DaHuy,
       SUM(CASE WHEN TrangThai = N'Hoàn thành' THEN ThanhTien ELSE 0 END) AS DoanhThu
FROM dbo.DonHang
GROUP BY NgayDat;
GO
