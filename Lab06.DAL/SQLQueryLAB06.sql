USE QLSach;
GO

-- KHẮC PHỤC LỖI 1: Bật chế độ cho phép tự điền ID vào bảng LoaiSachs
SET IDENTITY_INSERT [dbo].[LoaiSachs] ON; 

-- 1. Thêm vài Loại sách mới (Giờ thì OK rồi)
IF NOT EXISTS (SELECT * FROM LoaiSachs WHERE MaLoai = 4)
    INSERT INTO LoaiSachs(MaLoai, TenLoai) VALUES (4, N'Kinh Tế - Tài Chính');

IF NOT EXISTS (SELECT * FROM LoaiSachs WHERE MaLoai = 5)
    INSERT INTO LoaiSachs(MaLoai, TenLoai) VALUES (5, N'Văn Học Nước Ngoài');

IF NOT EXISTS (SELECT * FROM LoaiSachs WHERE MaLoai = 6)
    INSERT INTO LoaiSachs(MaLoai, TenLoai) VALUES (6, N'Truyện Tranh');

IF NOT EXISTS (SELECT * FROM LoaiSachs WHERE MaLoai = 7)
    INSERT INTO LoaiSachs(MaLoai, TenLoai) VALUES (7, N'Công Nghệ Thông Tin');

IF NOT EXISTS (SELECT * FROM LoaiSachs WHERE MaLoai = 8)
    INSERT INTO LoaiSachs(MaLoai, TenLoai) VALUES (8, N'Tâm Lý Học');

-- Tắt chế độ điền ID thủ công (Trả lại mặc định)
SET IDENTITY_INSERT [dbo].[LoaiSachs] OFF;


-- 2. Chạy vòng lặp sinh 100 cuốn sách ngẫu nhiên
-- Lưu ý: Tên bảng trong log lỗi của cậu là 'Sachs' (có s) nên tớ sửa lại cho khớp
DECLARE @i INT = 1;
DECLARE @MaSach CHAR(6);
DECLARE @TenSach NVARCHAR(150);
DECLARE @NamXB INT;
DECLARE @MaLoai INT;

DECLARE @TuKhoa TABLE (ID INT IDENTITY(1,1), Tu NVARCHAR(50));
INSERT INTO @TuKhoa VALUES (N'Bí kíp'), (N'Nghệ thuật'), (N'Giáo trình'), (N'Tuyệt chiêu'), (N'Đại cương'), (N'Lập trình'), (N'Khám phá'), (N'Hành trình');

DECLARE @ChuDe TABLE (ID INT IDENTITY(1,1), Tu NVARCHAR(50));
INSERT INTO @ChuDe VALUES (N'làm giàu'), (N'nấu ăn ngon'), (N'C# căn bản'), (N'SQL Server'), (N'tán gái'), (N'sống ảo'), (N'đầu tư chứng khoán'), (N'phiêu lưu ký');

WHILE @i <= 100
BEGIN
    -- Tạo Mã Sách: SA0001...
    SET @MaSach = 'SA' + RIGHT('0000' + CAST(@i AS VARCHAR(4)), 4);

    -- Tạo Tên Sách
    DECLARE @RandomTuKhoa NVARCHAR(50) = (SELECT TOP 1 Tu FROM @TuKhoa ORDER BY NEWID());
    DECLARE @RandomChuDe NVARCHAR(50) = (SELECT TOP 1 Tu FROM @ChuDe ORDER BY NEWID());
    SET @TenSach = @RandomTuKhoa + N' ' + @RandomChuDe + N' Tập ' + CAST(@i AS NVARCHAR(10));

    -- Năm XB: 2010 - 2024
    SET @NamXB = FLOOR(RAND()*(2024-2010+1) + 2010);

    -- Mã Loại: 1 - 8 (Giờ bảng LoaiSachs đã có đủ 8 loại nên không lỗi nữa)
    SET @MaLoai = FLOOR(RAND()*(8-1+1) + 1);

    -- Insert vào bảng Sachs (có s)
    IF NOT EXISTS (SELECT * FROM Sachs WHERE MaSach = @MaSach)
    BEGIN
        INSERT INTO Sachs(MaSach, TenSach, NamXB, MaLoai)
        VALUES (@MaSach, @TenSach, @NamXB, @MaLoai);
    END

    SET @i = @i + 1;
END

PRINT N'Đã bơm xong 100 dòng dữ liệu, bao mượt!';

select * from Sachs
select * from LoaiSachs

select * from Sachs sach join LoaiSachs loai on sach.MaLoai = loai.MaLoai