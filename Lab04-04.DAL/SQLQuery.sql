USE Lab0404 -- Nhớ đổi tên DB cho đúng
GO

-- 1. Dọn dẹp dữ liệu cũ (Xóa bảng con trước, bảng cha sau)
DELETE FROM [Orders];
DELETE FROM [Invoices];
DELETE FROM [Products];
GO

-- 2. Tạo 10 Sản phẩm mẫu (Laptop, Chuột, Bàn phím...)
INSERT INTO [Products] ([ProductID], [ProductName], [Unit], [BuyPrice], [SellPrice]) 
VALUES 
(N'P001', N'Laptop Dell XPS 13', N'Cái', 20000000, 25000000),
(N'P002', N'Laptop HP Envy', N'Cái', 18000000, 22000000),
(N'P003', N'Macbook Pro M1', N'Cái', 28000000, 32000000),
(N'P004', N'Chuột Logitech G502', N'Cái', 800000, 1200000),
(N'P005', N'Bàn phím cơ Keychron', N'Cái', 1500000, 2000000),
(N'P006', N'Màn hình Dell UltraSharp', N'Cái', 5000000, 6500000),
(N'P007', N'Tai nghe Sony WH-1000XM4', N'Cái', 4500000, 5500000),
(N'P008', N'Lót chuột Gaming', N'Cái', 50000, 100000),
(N'P009', N'USB Kingston 64GB', N'Cái', 120000, 200000),
(N'P010', N'Ổ cứng SSD Samsung 1TB', N'Cái', 2500000, 3200000);
GO

-- 3. Chạy vòng lặp để tạo 50 Hóa Đơn và Đơn Hàng ngẫu nhiên
DECLARE @i INT = 1;
DECLARE @TotalInvoices INT = 50; -- Muốn nhiều hơn thì sửa số này

WHILE @i <= @TotalInvoices
BEGIN
    -- Tạo mã hóa đơn: HD001, HD002...
    DECLARE @InvoiceNo NVARCHAR(20) = 'HD' + RIGHT('000' + CAST(@i AS NVARCHAR(10)), 3);
    
    -- Tạo ngày ngẫu nhiên trong tháng 10/2019 (để test bộ lọc ngày)
    -- Random ngày từ 1 đến 30
    DECLARE @RandomDay INT = FLOOR(RAND()*(30-1)+1);
    DECLARE @OrderDate DATE = CAST('2019-10-' + CAST(@RandomDay AS NVARCHAR(2)) AS DATE);
    DECLARE @DeliveryDate DATE = DATEADD(day, 2, @OrderDate); -- Giao sau 2 ngày

    -- INSERT Hóa Đơn (INVOICES)
    INSERT INTO [Invoices] ([InvoiceNo], [OrderDate], [DeliveryDate], [Note])
    VALUES (@InvoiceNo, @OrderDate, @DeliveryDate, N'Giao hàng giờ hành chính');

    -- Với mỗi hóa đơn, Random tạo từ 1 đến 4 sản phẩm
    DECLARE @NumProducts INT = FLOOR(RAND()*(4-1)+1); 
    DECLARE @j INT = 1;

    WHILE @j <= @NumProducts
    BEGIN
        -- Random chọn 1 mã sản phẩm từ P001 đến P010
        DECLARE @RandProdIndex INT = FLOOR(RAND()*(10-1)+1);
        DECLARE @ProdID NVARCHAR(20) = 'P' + RIGHT('000' + CAST(@RandProdIndex AS NVARCHAR(10)), 3);
        
        -- Lấy thông tin giá bán và tên từ bảng Products
        DECLARE @Price DECIMAL(18,0);
        DECLARE @ProdName NVARCHAR(100);
        DECLARE @Unit NVARCHAR(20);
        
        SELECT @Price = SellPrice, @ProdName = ProductName, @Unit = Unit 
        FROM [Products] WHERE ProductID = @ProdID;

        -- Random số lượng từ 1 đến 5
        DECLARE @Qty INT = FLOOR(RAND()*(5-1)+1);

        -- INSERT Chi tiết đơn hàng (ORDERS)
        -- Lưu ý: Kiểm tra để tránh trùng khóa chính (InvoiceNo, No) nếu chạy lại script
        IF NOT EXISTS (SELECT * FROM [Orders] WHERE InvoiceNo = @InvoiceNo AND [No] = @j)
        BEGIN
            INSERT INTO [Orders] ([InvoiceNo], [No], [ProductID], [ProductName], [Unit], [Price], [Quantity])
            VALUES (@InvoiceNo, @j, @ProdID, @ProdName, @Unit, @Price, @Qty);
        END

        SET @j = @j + 1;
    END

    SET @i = @i + 1;
END
GO