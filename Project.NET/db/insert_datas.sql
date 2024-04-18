﻿set dateformat dmy;
---------------------------------------------------------------------
----------------------------- Nhân Viên -----------------------------
---------------------------------------------------------------------
go
insert into ViTri
values ('VT00', N'Admin'),
('VT01', N'Quản lý'),
('VT02', N'Nhân viên thu ngân'),
('VT03', N'Nhân viên trực quầy'),
('VT04', N'Nhân viên giữ xe')

go
insert into KhuVuc
values ('KV00000001',N'TPHCM'),
('KV00000002',N'Hải phòng'),
('KV00000003',N'Hà nội')

go
insert into ChiNhanh
values ('CN00000001', N'Chi nhánh Q1', N'160 Đ. Đề Thám, Phường Cầu Ông Lãnh, Quận 1, Thành phố Hồ Chí Minh', 'KV00000001', null),
('CN00000002', N'Chi nhánh Q2', N'72 Quốc Hương, Ấp Thảo Điền, P. Thảo Điền, Quận 2, TP. HCM', 'KV00000001', null),
('CN00000003', N'Chi nhánh Q3', N'268/16 Lý Thái Tổ, Phường 01, Quận 3, TP. Hồ Chí Minh', 'KV00000001', null)

go
insert into NhanVien(maNV, tenNV, gioiTinh,ngaySinh,SDT,CCCD,maVT,maCN,luong)
values	('NV0', N'admin',N'Nam','1/1/1991','0000000000','00000000000', 'VT00',null,0),
		('NV00000001', N'Bùi Quang Huy',N'Nam','20/10/2003','0321654987','00000000001', 'VT01','CN00000001', 5000000),
		('NV00000002', N'Bùi Hoàng Nam',N'Nam','20/10/2003',null,'00000000002','VT02','CN00000001',3000000),
		('NV00000003', N'Bùi Anh Nghĩa',N'Nam','20/10/2003','0321654987','00000000003','VT02','CN00000001',3000000),
		('NV00000004', N'Bùi Trúc Nhi',N'Nữ','20/10/2003','0321654987','00000000004','VT03','CN00000002',5000000),
		('NV00000005', N'Bùi Yến Mĩ',N'Nữ','20/10/2003',null,'00000000005','VT03','CN00000002',3000000),
		('NV00000006', N'Bùi Nhật Nam', N'Nam','20/10/2003','0321654987','00000000006','VT04','CN00000003',5000000)

go
insert into CaLam
values	('CL01', N'Ca Sáng', '5h30', '14h30'),
		('CL02', N'Ca Chiều', '14h30', '22h')

go
insert into PhanCong
values	('NV00000001', N'Thứ hai', 'CL01'),
		('NV00000001', N'Thứ tư', 'CL01'),
		('NV00000001', N'Thứ sáu', 'CL01'),
		('NV00000001', N'Chủ nhật', 'CL01'),
		('NV00000002', N'Thứ ba', 'CL01'),
		('NV00000002', N'Thứ năm', 'CL01'),
		('NV00000002', N'Thứ bảy', 'CL01'),
		('NV00000003', N'Thứ hai', 'CL02'),
		('NV00000003', N'Thứ ba', 'CL02'),
		('NV00000003', N'Thứ tư', 'CL02'),
		('NV00000003', N'Thứ năm', 'CL02'),
		('NV00000003', N'Thứ sáu', 'CL02'),
		('NV00000003', N'Thứ bảy', 'CL02'),
		('NV00000003', N'Chủ nhật', 'CL02'),
		('NV00000004', N'Thứ hai', 'CL02'),
		('NV00000004', N'Thứ ba', 'CL02'),
		('NV00000004', N'Thứ tư', 'CL02'),
		('NV00000004', N'Thứ năm', 'CL02'),
		('NV00000004', N'Thứ sáu', 'CL02'),
		('NV00000004', N'Thứ bảy', 'CL02'),
		('NV00000004', N'Chủ nhật', 'CL02'),
		('NV00000005', N'Thứ hai', 'CL01'),
		('NV00000005', N'Thứ ba', 'CL01'),
		('NV00000005', N'Thứ tư', 'CL01'),
		('NV00000005', N'Thứ năm', 'CL01'),
		('NV00000005', N'Thứ sáu', 'CL01'),
		('NV00000005', N'Thứ bảy', 'CL01'),
		('NV00000005', N'Chủ nhật', 'CL01'),
		('NV00000006', N'Thứ hai', 'CL02'),
		('NV00000006', N'Thứ tư', 'CL02'),
		('NV00000006', N'Thứ sáu', 'CL02'),
		('NV00000006', N'Chủ nhật', 'CL02')

go
update ChiNhanh
set maQL = 'NV00000001'
where maCN = 'CN00000001'
go
update ChiNhanh
set maQL = 'NV00000004'
where maCN = 'CN00000002'
go
update ChiNhanh
set maQL = 'NV00000006'
where maCN = 'CN00000003'


go
insert into KhachHang
values ('KH00000000',N'Khách mới', '0000000000', getdate(), 0)
,('KH00000001',N'Bùi Anh Tuấn', '0123456789', '10/10/2010', 0)
,('KH00000002',N'Bùi Anh Huy', '0123456789', '06/03/2010', 10)
,('KH00000003',N'Bùi Quốc Đạt', '0123456789', '12/11/2010', 3000)


go
insert into TaiKhoan
values ('admin', '124578','NV0')
,('TK00000001', '123456','NV00000001')
,('TK00000002', '123456','NV00000002')
,('TK00000003', '123456','NV00000003')
,('TK00000004', '123456','NV00000004')
,('TK00000005', '123456','NV00000005')
,('TK00000006', '123456','NV00000006')

---------------------------------------------------------------------
----------------------------- Sản phẩm ------------------------------
---------------------------------------------------------------------

go
insert into NhaSanXuat
values ('NSX0000001', N'Vissan', '8435533999', N'420 Nơ Trang Long, P. 13, Quận Bình Thạnh, TP.HCM, Việt Nam'),
('NSX0000002', N'Orion Vina', '0283512312', N'Tầng 22, TTTM Pearl Plaza, 561A Điện Biên Phủ, phường 25, quận Bình Thạnh, TP HCM'),
('NSX0000003', N'Vinamilk', '0285415555', N'Số 10, Đường Tân Trào, Phường Tân Phú, Quận 7, Tp. Hồ Chí Minh')

go
insert into LoaiSP
values ('LS00000001', N'Thịt'),
('LS00000002', N'Sữa'),
('LS00000003', N'Bánh'),
('LS00000004', N'Nước')

go
insert into SanPham
values ('SP00000001', N'Heo 2 Lát', '1/12/2024', 30000, 300, 'LS00000001', 'NSX0000001'),
('SP00000002', N'ChocoPie',  '1/12/2024', 30000, 300, 'LS00000003', 'NSX0000002'),
('SP00000003', N'Sữa tươi Vinamilk',  '1/12/2024', 30000, 300, 'LS00000002', 'NSX0000003'),
('SP00000004', N'Xúc xích dinh dưỡng',  '1/12/2024', 30000, 300, 'LS00000001', null), 
('SP00000005', N'Tiêu đen', '1/12/2024', 20000, 200, 'LS00000002', 'NSX0000003'),
('SP00000006', N'Bánh quy hạt dẻ cười', '1/12/2024', 25000, 150, 'LS00000003', 'NSX0000001'),
('SP00000007', N'Nước ngọt Pepsi', '1/12/2024', 18000, 350, 'LS00000001', 'NSX0000002'),
('SP00000008', N'Thịt bò Úc', '1/12/2024', 35000, 100, 'LS00000002', 'NSX0000002'),
('SP00000009', N'Rau cải thảo', '1/12/2024', 15000, 400, 'LS00000003', 'NSX0000003'),
('SP00000010', N'Kẹo sô cô la Kinder', '1/12/2024', 22000, 250, 'LS00000001', 'NSX0000003'),
('SP00000011', N'Sữa đậu nành', '1/12/2024', 27000, 180, 'LS00000002', 'NSX0000003'),
('SP00000012', N'Bánh mì sandwich thịt', '1/12/2024', 20000, 300, 'LS00000003', 'NSX0000001'),
('SP00000013', N'Nước suối Lavie', '1/12/2024', 12000, 500, 'LS00000001', 'NSX0000002'),
('SP00000014', N'Mì gói Hảo Hảo', '1/12/2024', 8000, 700, 'LS00000002', 'NSX0000002'),
('SP00000015', N'Gà ta', '1/12/2024', 30000, 120, 'LS00000003', 'NSX0000001'),
('SP00000016', N'Kem dừa', '1/12/2024', 25000, 180, 'LS00000001', 'NSX0000002'),
('SP00000017', N'Rượu vang Chile', '1/12/2024', 42000, 90, 'LS00000002', 'NSX0000003'),
('SP00000018', N'Pizza hải sản', '1/12/2024', 28000, 200, 'LS00000003', 'NSX0000002'),
('SP00000019', N'Bột ngọt Ajinomoto', '1/12/2024', 10000, 400, 'LS00000001', 'NSX0000001'),
('SP00000020', N'Cà chua', '1/12/2024', 5000, 600, 'LS00000002', 'NSX0000001');

---------------------------------------------------------------------
------------------------------ Hóa đơn ------------------------------
---------------------------------------------------------------------

go
insert into HoaDon
values ('HD00000001', '18-11-2023', 'NV00000002',null, 0, 0),
('HD00000002', '18-11-2023', 'NV00000004',null, 0, 0),
('HD00000003', '18-11-2023', 'NV00000006',null, 0, 0),
('HD00000004', '15-11-2023', 'NV00000003',null, 0, 0)


go
insert into ChiTietHD
values ('HD00000001','SP00000001',18),
('HD00000001','SP00000002',15),
('HD00000001','SP00000004',17),
('HD00000002','SP00000001',32),
('HD00000002','SP00000003',41),
('HD00000003','SP00000001',59),
('HD00000003','SP00000003',73),
('HD00000003','SP00000004',05)