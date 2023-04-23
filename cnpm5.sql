use master
create database cnpm5
go
use cnpm5
go

CREATE TABLE HocVien (
    MaHocVien VARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    NgaySinh DATE NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(20) NOT NULL,
    NgheNghiep NVARCHAR(50) NOT NULL
);
INSERT INTO HocVien (MaHocVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, NgheNghiep) VALUES
					('HV001', N'Nguyễn A', N'Nam', '2020-10-01', N'Quận 1, TpHCM', N'0123456789', N'Sinh viên'),
					('HV002', N'Nguyễn B', N'Nữ', '2003-12-30', N'Quận 2, Long An', N'0123456789', N'Nhân viên'),
					('HV003', N'Nguyễn C', N'Nam', '2010-03-21', N'Quận 3, Bình Dương', N'0123456789', N'Công nhân'),
					('HV004', N'Nguyễn D', N'Nữ', '2013-07-15', N'Quận 4, TpHCM', N'0123456789', N'Sinh viên')

CREATE TABLE GiaoVien (
    MaGiaoVien VARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    NgaySinh DATE NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(20) NOT NULL,
    ChucVu NVARCHAR(50) NOT NULL
);
INSERT INTO GiaoVien (MaGiaoVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu) VALUES
					('GV001', N'Trần A', N'Nam', '2020-10-01', N'Quận 1, TpHCM', N'0123456789', N'Giáo viên'),
					('GV002', N'Trần B', N'Nữ', '2003-12-30', N'Quận 2, Long An', N'0123456789', N'Giáo viên'),
					('GV003', N'Trần C', N'Nam', '2010-03-21', N'Quận 3, Bình Dương', N'0123456789', N'Giáo viên'),
					('GV004', N'Trần D', N'Nữ', '2013-07-15', N'Quận 4, TpHCM', N'0123456789', N'Giáo viên')



CREATE TABLE NhanVien (
    MaNhanVien VARCHAR(50) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    NgaySinh DATE NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(20) NOT NULL,
    ChucVu NVARCHAR(50) NOT NULL
);
INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu)
VALUES ('NV001', N'Nguyễn Văn A', N'Nam', '1990-01-01', N'Hà Nội', '0987654321', N'Quản lý');

INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu)
VALUES ('NV002', N'Lê Thị B', N'Nữ', '1995-05-05', N'Hồ Chí Minh', '0123456789', N'Nhân viên');

INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu)
VALUES ('NV003', N'Phạm Văn C', N'Nam', '1988-10-10', N'Đà Nẵng', '0909123456', N'Quản lý');

INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu)
VALUES ('NV004', N'Đặng Thị D', N'Nữ', '1993-03-03', N'Hải Phòng', '0918234567', N'Nhân viên');

INSERT INTO NhanVien (MaNhanVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai, ChucVu)
VALUES ('NV005', N'Trần Văn E', N'Nam', '1992-08-08', N'Cần Thơ', '0987123456', N'Quản lý');


CREATE TABLE PhongHoc(
MaPhongHoc VARCHAR(50) PRIMARY KEY,
TenPhongHoc NVARCHAR(50)
);
INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc) VALUES
					('PH01', N'Phòng 1'),
					('PH02', N'Phòng 2'),
					('PH03', N'Phòng 3'),
					('PH04', N'Phòng 4'),
					('PH05', N'Phòng 5')

CREATE TABLE KhoaHoc (
    MaKhoaHoc VARCHAR(50) PRIMARY KEY,
    TenKhoaHoc NVARCHAR(50) NOT NULL
);
INSERT INTO KhoaHoc (MaKhoaHoc, TenKhoaHoc) VALUES
			('KH01', N'Khóa K01'),
			('KH02', N'Khóa K02'),
			('KH03', N'Khóa K03')

CREATE TABLE MonHoc (
    MaMonHoc VARCHAR(50) PRIMARY KEY,
    TenMonHoc NVARCHAR(50) NOT NULL,
    SoBuoi INT NOT NULL,
    HocPhi FLOAT NOT NULL,
    MaKhoaHoc VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaKhoaHoc) REFERENCES KhoaHoc(MaKhoaHoc)
);
INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoBuoi, HocPhi, MaKhoaHoc) VALUES
					('MH001', N'Excel', 15, 5300000, 'KH01'),
					('MH002', N'Word', 25, 8500000, 'KH02'),
					('MH003', N'Access', 10, 4600000, 'KH03'),
					('MH004', N'PowerPoint', 25, 8000000, 'KH02'),
					('MH005', N'MOS', 18, 7500000, 'KH01')


CREATE TABLE LopHoc (
    MaLopHoc VARCHAR(50) PRIMARY KEY,
    TenLopHoc NVARCHAR(50) NOT NULL,
    SiSo INT NOT NULL,
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    MaPhongHoc  VARCHAR(50) NOT NULL REFERENCES PhongHoc(MaPhongHoc),
    CaHoc NVARCHAR(50) NOT NULL,
    MaMonHoc VARCHAR(50) NOT NULL,
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);
ALTER TABLE LopHoc
ADD ChoTrong INT DEFAULT 40;
ALTER TABLE LopHoc
ALTER COLUMN CaHoc INT

INSERT INTO LopHoc (MaLopHoc, TenLopHoc, SiSo, NgayBatDau, NgayKetThuc, MaPhongHoc, CaHoc, MaMonHoc)
VALUES ('LH001', N'Lớp Word sáng', 30, '2023-03-10', '2023-07-10', 'PH05' , 1, 'MH002'),
       ('LH002', N'Lớp Access sáng', 30, '2023-05-10', '2023-10-10', 'PH04' ,2, 'MH003'),
       ('LH003', N'Lớp MOS chiều', 30, '2023-08-10', '2024-02-10', 'PH01' , 3, 'MH005'),
       ('LH004', N'Lớp Powerpoint chiều', 30, '2023-03-10', '2023-07-10', 'PH03' , 4, 'MH004'),
       ('LH005', N'Lớp Excel tối', 30, '2023-03-10', '2023-07-10', 'PH05' , 5, 'MH001');




CREATE TABLE GiangDay (
    MaGiaoVien VARCHAR(50) NOT NULL,
    MaLopHoc VARCHAR(50) NOT NULL,
    PRIMARY KEY (MaGiaoVien, MaLopHoc),
    FOREIGN KEY (MaGiaoVien) REFERENCES GiaoVien(MaGiaoVien),
    FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc),
    UNIQUE (MaLopHoc)
);


CREATE TABLE ghidanh (
    MaHocVien VARCHAR(50) NOT NULL,
    MaLopHoc VARCHAR(50) NOT NULL,
    PRIMARY KEY (MaHocVien, MaLopHoc),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaLopHoc) REFERENCES LopHoc(MaLopHoc)
);



CREATE TABLE ghidanh2 (
    MaHocVien VARCHAR(50) NOT NULL,
    MaMonHoc VARCHAR(50) NOT NULL,
    PRIMARY KEY (MaHocVien, MaMonHoc),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);


CREATE TABLE HP (
    MaHocVien VARCHAR(50) NOT NULL,
    HoTen NVARCHAR(50) NOT NULL,
    HocPhi FLOAT NOT NULL,
    DaDong FLOAT NOT NULL,
    ConNo FLOAT NOT NULL,
    PRIMARY KEY (MaHocVien),
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
);

CREATE TABLE TinhTrangHocPhi (
    MaHocVien VARCHAR(50) NOT NULL,
    TinhTrang NVARCHAR(50) NOT NULL,
    PRIMARY KEY (MaHocVien),
    FOREIGN KEY (MaHocVien) REFERENCES HP(MaHocVien)
);


CREATE TABLE BienLai(
 ID VARCHAR(50) PRIMARY KEY,
 TenNguoiDong NVARCHAR(50),
 MaHocVien VARCHAR(50) REFERENCES HocVien(MaHocVien),
 SoTien FLOAT,
 NgayDong DATE
);

ALTER TABLE BienLai
ADD CONSTRAINT FK_BienLai_HP_MaHocVien
FOREIGN KEY (MaHocVien)
REFERENCES HP(MaHocVien);


CREATE TABLE DiemTongHop (
    ID INT PRIMARY KEY IDENTITY(1,1),
    MaHocVien VARCHAR(50) NOT NULL,
    MaMonHoc VARCHAR(50) NOT NULL,
    DiemKiemTra1 FLOAT NOT NULL,
    DiemKiemTra2 FLOAT NOT NULL,
    DiemThi FLOAT NOT NULL,
    DiemTrungBinh AS (DiemKiemTra1 + DiemKiemTra2+ DiemThi*3)/5,
    FOREIGN KEY (MaHocVien) REFERENCES HocVien(MaHocVien),
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc)
);



CREATE TABLE Quyen (
    MaQuyen INT PRIMARY KEY,
    TenQuyen NVARCHAR(50) NOT NULL
);
INSERT INTO Quyen (MaQuyen, TenQuyen) VALUES
    (1, 'Admin'),
    (2, N'Quản lý kế hoạch'),
    (3, N'Nhân viên lễ tân'),
    (4, N'Quản lý nhân sự');



CREATE TABLE TaiKhoan (
    MaTaiKhoan VARCHAR(50) PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50) NOT NULL,
    MatKhau VARCHAR(50) NOT NULL,
    MaQuyen INT NOT NULL,
    FOREIGN KEY (MaQuyen) REFERENCES Quyen(MaQuyen)
);
INSERT INTO TaiKhoan(MaTaiKhoan,TenTaiKhoan,MatKhau,MaQuyen) values
('TK001','NGUYEN VAN A','12345',1),
('TK002','NGUYEN VAN B','12345',2),
('TK003','NGUYEN VAN C','12345',3),
('TK004','NGUYEN VAN D','12345',4);


Go
CREATE TRIGGER trg_ghidanh_insert  
ON ghidanh
AFTER INSERT
AS
BEGIN
    INSERT INTO ghidanh2 (MaHocVien, MaMonHoc)
        SELECT inserted.MaHocVien, LopHoc.MaMonHoc
        FROM inserted
        INNER JOIN LopHoc ON inserted.MaLopHoc = LopHoc.MaLopHoc;
END --trigger tự động nhập ghidanh2 --

 drop trigger trg_ghidanh_delete
 go
CREATE TRIGGER trg_ghidanh_delete --trigger tự động xóa ghidanh2
ON ghidanh
AFTER DELETE
AS
BEGIN
    DELETE ghidanh2
    FROM ghidanh2
    INNER JOIN deleted ON ghidanh2.MaHocVien = deleted.MaHocVien
    INNER JOIN LopHoc ON deleted.MaLopHoc = LopHoc.MaLopHoc
    WHERE ghidanh2.MaMonHoc = LopHoc.MaMonHoc;
END


 drop trigger trig_tinh_hoc_phi
GO
CREATE TRIGGER trig_tinh_hoc_phi  
ON ghidanh2
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaHocVien VARCHAR(50)
    DECLARE @HoTen NVARCHAR(50)
    DECLARE @HocPhi FLOAT
    DECLARE @DaDong FLOAT
    DECLARE @ConNo FLOAT

    IF (SELECT COUNT(*) FROM inserted) > 0
    BEGIN
        SELECT @MaHocVien = MaHocVien FROM inserted

        SELECT @HoTen = Hoten FROM HocVien WHERE MaHocVien = @MaHocVien

        SELECT @HocPhi = SUM(HocPhi)
        FROM MonHoc
        WHERE MaMonHoc IN (SELECT MaMonHoc FROM ghidanh2 WHERE MaHocVien = @MaHocVien)

        SELECT @DaDong = ISNULL(SUM(SoTien), 0)
        FROM BienLai
        WHERE MaHocVien = @MaHocVien

        IF @DaDong IS NULL SET @DaDong = 0

        SELECT @ConNo = @HocPhi - @DaDong

        IF EXISTS(SELECT * FROM HP WHERE MaHocVien = @MaHocVien)
        BEGIN
            UPDATE HP
            SET HocPhi = @HocPhi, DaDong = @DaDong, ConNo = @ConNo
            WHERE MaHocVien = @MaHocVien
        END
        ELSE
        BEGIN
            INSERT INTO HP (MaHocVien,HoTen, HocPhi, DaDong, ConNo)
            VALUES (@MaHocVien,@HoTen, @HocPhi, @DaDong, @ConNo)
        END
    END
END 
 drop trigger trig_xoa_mon_hoc
 go
CREATE TRIGGER trig_xoa_mon_hoc
ON ghidanh2
AFTER DELETE
AS
BEGIN
    DECLARE @MaHocVien VARCHAR(50)
    DECLARE @MaMonHoc VARCHAR(50)
    DECLARE @HocPhi FLOAT
    DECLARE @DaDong FLOAT
    DECLARE @ConNo FLOAT

    IF (SELECT COUNT(*) FROM deleted) > 0
    BEGIN
        SELECT @MaHocVien = MaHocVien FROM deleted
        SELECT @MaMonHoc = MaMonHoc FROM deleted

        SELECT @HocPhi = HocPhi
        FROM MonHoc
        WHERE MaMonHoc = @MaMonHoc

        SELECT @DaDong = ISNULL(SUM(SoTien), 0)
        FROM BienLai
        WHERE MaHocVien = @MaHocVien

        IF @DaDong IS NULL SET @DaDong = 0

        SELECT @ConNo = @HocPhi - @DaDong

        UPDATE HP
        SET HocPhi = HocPhi - @HocPhi,
            ConNo = ConNo - @HocPhi
        WHERE MaHocVien = @MaHocVien

        IF @HocPhi = 0
        BEGIN
            DELETE FROM HP WHERE MaHocVien = @MaHocVien
        END
    END
END;


go
CREATE TRIGGER trig_xoa_hp_2
ON HP
AFTER UPDATE
AS
BEGIN
    -- Xóa các bản ghi trong bảng TinhTrangHocPhi trước
    DELETE FROM TinhTrangHocPhi
    WHERE MaHocVien IN (SELECT MaHocVien FROM HP WHERE HocPhi = 0)

    -- Xóa các bản ghi trong bảng HP
    DELETE FROM HP
    WHERE HocPhi = 0
END
  --trigger tự động tính học phí trong bảng HP ghi ghi danh--



go
CREATE TRIGGER trig_xoa_hp
ON HP
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @MaHocVien VARCHAR(50)

    IF (SELECT COUNT(*) FROM deleted) > 0
    BEGIN
        SELECT @MaHocVien = MaHocVien FROM deleted

        -- Xóa bản ghi trong bảng TinhTrangHocPhi có MaHocVien trùng với MaHocVien bị xóa trong bảng HP
        DELETE FROM TinhTrangHocPhi WHERE MaHocVien = @MaHocVien

        -- Tiếp tục xóa bản ghi trong bảng HP
        DELETE FROM HP WHERE MaHocVien = @MaHocVien
    END
END
go
CREATE TRIGGER trig_xoa_tthp
ON TinhTrangHocPhi
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @MaHocVien VARCHAR(50)

    IF (SELECT COUNT(*) FROM deleted) > 0
    BEGIN
        SELECT @MaHocVien = MaHocVien FROM deleted

        -- Xóa bản ghi trong bảng HP có MaHocVien trùng với MaHocVien bị xóa trong bảng TinhTrangHocPhi
        DELETE FROM HP WHERE MaHocVien = @MaHocVien

        -- Tiếp tục xóa bản ghi trong bảng TinhTrangHocPhi
        DELETE FROM TinhTrangHocPhi WHERE MaHocVien = @MaHocVien
    END
END
GO
CREATE TRIGGER trig_cap_nhat_hp2
ON BienLai
AFTER UPDATE
AS
BEGIN
    UPDATE HP
    SET DaDong = HP.DaDong + (i.SoTien - d.SoTien),
        ConNo = HP.ConNo - (i.SoTien - d.SoTien)
    FROM HP
    INNER JOIN inserted i ON HP.MaHocVien = i.MaHocVien
    INNER JOIN deleted d ON HP.MaHocVien = d.MaHocVien
    WHERE HP.MaHocVien = i.MaHocVien;
END


 -- trigger khi xóa thông tin trong ghidanh2 -- học phí bằng 0 thì xóa luôn nha
 drop trigger trig_cap_nhat_hp
go
CREATE TRIGGER trig_cap_nhat_hp  
ON BienLai
AFTER INSERT 
AS
BEGIN
    UPDATE HP
    SET DaDong = DaDong + inserted.SoTien,
        ConNo = HocPhi - (DaDong + inserted.SoTien)
    FROM HP
    INNER JOIN inserted ON HP.MaHocVien = inserted.MaHocVien
    INNER JOIN ghidanh2 ON HP.MaHocVien = ghidanh2.MaHocVien
    WHERE HP.MaHocVien = inserted.MaHocVien

END --trigger update ĐaDONG bằng biên lai
go 
CREATE TRIGGER trig_xoa_bienlai
ON BienLai
AFTER DELETE
AS
BEGIN
    UPDATE HP
    SET DaDong = DaDong - deleted.SoTien,
        ConNo = HocPhi - (DaDong - deleted.SoTien)
    FROM HP
    INNER JOIN deleted ON HP.MaHocVien = deleted.MaHocVien
    INNER JOIN ghidanh2 ON HP.MaHocVien = ghidanh2.MaHocVien
    WHERE HP.MaHocVien = deleted.MaHocVien
END -- cập nhật số tiền đã đóng khi xóa biên lai
go 
CREATE TRIGGER trg_update_tinhtranghocphi  
ON HP
AFTER INSERT, UPDATE 
AS
BEGIN
    DECLARE @tinhtrang NVARCHAR(50);
    IF (SELECT ConNo FROM inserted) = 0
        SET @tinhtrang = N'Đóng Đủ';
    ELSE IF (SELECT ConNo FROM inserted) = (SELECT HocPhi FROM inserted)
        SET @tinhtrang = N'Chưa Đóng';
    ELSE IF (SELECT ConNo FROM inserted) <0
        SET @tinhtrang = N'Đóng Dư';
    ELSE
        SET @tinhtrang = N'Đóng Thiếu';
    
    INSERT INTO TinhTrangHocPhi (MaHocVien, TinhTrang)
    SELECT i.MaHocVien, @tinhtrang
    FROM inserted AS i
    WHERE NOT EXISTS (
        SELECT * FROM TinhTrangHocPhi
        WHERE TinhTrangHocPhi.MaHocVien = i.MaHocVien
    );
    
    UPDATE TinhTrangHocPhi
    SET TinhTrang = @tinhtrang
    FROM TinhTrangHocPhi AS tt
    INNER JOIN inserted AS i ON tt.MaHocVien = i.MaHocVien;
END; --cập nhật trình trạng học phí 
GO
CREATE TRIGGER trigger_giam_cho_trong
ON ghidanh
AFTER INSERT
AS
BEGIN
  UPDATE LopHoc
  SET ChoTrong = ChoTrong - 1
  FROM LopHoc
  INNER JOIN inserted ON LopHoc.MaLopHoc = inserted.MaLopHoc;
END;
GO

CREATE TRIGGER trigger_tang_cho_trong
ON ghidanh
AFTER DELETE
AS
BEGIN
  UPDATE LopHoc
  SET ChoTrong = ChoTrong + 1
  FROM LopHoc
  INNER JOIN deleted ON LopHoc.MaLopHoc = deleted.MaLopHoc;
END;

 




  go
CREATE PROCEDURE XoaHocVien
    @MaHocVien VARCHAR(50)
AS
BEGIN
   DELETE FROM DiemTongHop WHERE MaHocVien=@MaHocVien;
    -- Xóa dữ liệu liên quan trong bảng BienLai
    DELETE FROM BienLai WHERE MaHocVien = @MaHocVien;

    -- Xóa dữ liệu liên quan trong bảng HP
    DELETE FROM HP WHERE MaHocVien = @MaHocVien;

    -- Xóa dữ liệu liên quan trong bảng TinhTrangHocPhi
    DELETE FROM TinhTrangHocPhi WHERE MaHocVien = @MaHocVien;

    -- Xóa dữ liệu liên quan trong bảng ghidanh2
    DELETE FROM ghidanh2 WHERE MaHocVien = @MaHocVien;

    -- Xóa dữ liệu liên quan trong bảng ghidanh
    DELETE FROM ghidanh WHERE MaHocVien = @MaHocVien;

    -- Cuối cùng, xóa dữ liệu trong bảng HocVien
    DELETE FROM HocVien WHERE MaHocVien = @MaHocVien;
END


go
CREATE PROCEDURE XoaLopHoc
    @MaLopHoc VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Xóa dữ liệu trong bảng GiangDay trước
    DELETE FROM GiangDay WHERE MaLopHoc = @MaLopHoc;

    -- Xóa dữ liệu trong bảng ghidanh trước
    DELETE FROM ghidanh WHERE MaLopHoc = @MaLopHoc;


    -- Xóa dữ liệu trong bảng DiemTongHop trước
    DELETE FROM DiemTongHop WHERE MaMonHoc IN (SELECT MaMonHoc FROM LopHoc WHERE MaLopHoc = @MaLopHoc);

    -- Xóa dữ liệu trong bảng LopHoc
    DELETE FROM LopHoc WHERE MaLopHoc = @MaLopHoc;


END;

go
CREATE PROCEDURE XoaMonHoc
    @MaMonHoc VARCHAR(50)
AS
BEGIN
    -- Xóa dữ liệu từ bảng DiemTongHop liên quan đến Môn học cần xóa
    DELETE FROM DiemTongHop WHERE MaMonHoc = @MaMonHoc;

    -- Xóa dữ liệu từ bảng Ghidanh2 liên quan đến Môn học cần xóa
    DELETE FROM ghidanh2 WHERE MaMonHoc = @MaMonHoc;

    -- Xóa dữ liệu từ bảng Ghidanh liên quan đến Môn học cần xóa
    DELETE FROM ghidanh WHERE MaLopHoc IN (
        SELECT MaLopHoc FROM LopHoc WHERE MaMonHoc = @MaMonHoc
    );

    -- Xóa dữ liệu từ bảng GiangDay liên quan đến Môn học cần xóa
    DELETE FROM GiangDay WHERE MaLopHoc IN (
        SELECT MaLopHoc FROM LopHoc WHERE MaMonHoc = @MaMonHoc
    );

    -- Xóa dữ liệu từ bảng LopHoc liên quan đến Môn học cần xóa
    DELETE FROM LopHoc WHERE MaMonHoc = @MaMonHoc;

    -- Xóa dữ liệu từ bảng MonHoc
    DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc;
END;

go 
CREATE PROCEDURE XoaGiaoVien
    @MaGiaoVien VARCHAR(50)
AS
BEGIN
    -- Xóa dữ liệu từ bảng GiangDay liên quan đến Giáo viên cần xóa
    DELETE FROM GiangDay WHERE MaGiaoVien = @MaGiaoVien;

    -- Xóa dữ liệu từ bảng GiaoVien
    DELETE FROM GiaoVien WHERE MaGiaoVien = @MaGiaoVien;
END;


CREATE PROCEDURE GetDiemTongHopByMaMonHoc
    @MaMonHoc VARCHAR(50)
AS
BEGIN
    SELECT
        dt.MaMonHoc,
        mh.TenMonHoc,
        dt.MaHocVien,
        hv.HoTen AS TenHocVien,
        dt.DiemKiemTra1,
        dt.DiemKiemTra2,
        dt.DiemThi,
        dt.DiemTrungBinh
    FROM
        DiemTongHop dt
    INNER JOIN
        MonHoc mh ON dt.MaMonHoc = mh.MaMonHoc
    INNER JOIN
        HocVien hv ON dt.MaHocVien = hv.MaHocVien
    WHERE
        dt.MaMonHoc = @MaMonHoc;
END



