go
use master
drop database QLBHX

go
create database QLBHX

go
use QLBHX
go
create table KhuVuc(
maKV char(10) not null,
tenKV nvarchar(50) not null)

go
create table ChiNhanh(
maCN char(10) not null,
tenCN nvarchar(30) not null,
diaChi nvarchar(100) not null,
maKV char(10),
maQL char(10))

go
create table NhanVien(
maNV char(10) not null,
tenNV nvarchar(30) not null,
gioiTinh nvarchar(3) not null,
ngaySinh date not null,
SDT char(10),
CCCD char(11) not null,
luong int,
maVT char(10) not null,
maCN char(10))

go
create table ViTri(
maVT char(10) not null
, tenVT nvarchar(100) not null
)

go
create table CaLam(
maCa char(10) not null,
tenCa nvarchar(30) not null,
gioBD char(10),
gioKT char(10))

go
create table PhanCong(
maPC int not null primary key identity(0,1),
maNV char(10) not null,
ngayDiLam nvarchar(10) not null,
maCa char(10) not null
)

go
create table TaiKhoan(
tenTK char(30) not null,
matKhau char(30) not null,
maNV char(10))

go
create table LoaiSP(
maLoai char(10) not null,
tenLoai nvarchar(30) not null)

go
create table NhaSanXuat(
maNSX char(10) not null,
tenNSX nvarchar(30) not null,
SDTNSX char(10) not null,
diaChi nvarchar(100) not null)

go
create table SanPham(
maSP char(10) not null,
tenSP nvarchar(30) not null,
HSD date not null,
donGia int not null,
soLuongConLai int not null,
maLoai char(10),
maNSX char(10))

go
create table KhachHang(
maKH char(10) not null,
tenKH nvarchar(30) not null,
SDT char(10) not null,
ngaySinh date not null,
diemTichLuy int)

go
create table HoaDon(
maHD char(10) not null,
ngayLap date not null,
maNV char(10) not null,
maKH char(10),
diemDung int,
thanhTien int)

go
create table ChiTietHD(
maHD char(10) not null,
maSP char(10) not null,
soLuong int not null)

go
create table KhoCN(
maCN char(10) not null,
maSP char(10) not null,
soLuong int not null
);

go
create table KhuyenMai(
maKM char(10) not null,
ghiChu nvarchar(250) not null
);

go
create table ChiTietKM(
maKM char(10) not null,
maSP char(10) not null,
soLuong int not null
);

go 
create table ChiTietCC(
maCC char(10) not null,
maNSX char(10) not null,
maSP char(10) not null,
soLuong int not null,
ngayCC date not null
);

------------------------------PRIMARY KEYS------------------------------
go 
alter table KhuVuc
add constraint pk_khuvuc primary key (maKV)
go 
alter table ViTri
add constraint pk_vitri primary key (maVT)
go 
alter table NhanVien
add constraint pk_nhanvien primary key (maNV)
go 
alter table CaLam
add constraint pk_CaLam primary key (maCa)
go 
alter table TaiKhoan
add constraint pk_taikhoan primary key (tenTK)
go 
alter table ChiNhanh
add constraint pk_chinhanh primary key (maCN)
go 
alter table NhaSanXuat
add constraint pk_nhasanxuat primary key (maNSX)
go 
alter table LoaiSP
add constraint pk_loaisp primary key (maLoai)
go 
alter table SanPham
add constraint pk_sanpham primary key (maSP)
go 
alter table HoaDon
add constraint pk_hoadon primary key (maHD)
go 
alter table KhachHang
add constraint pk_khachhang primary key (maKH)
go
alter table KhuyenMai
add constraint pk_khuyenmai primary key (maKM)
go
alter table ChiTietCC
add constraint pk_chitietcc primary key (maCC)
go
alter table ChiTietHD
add constraint pk_chitiethd primary key (maHD,maSP)
go
alter table KhoCN
add constraint pk_KhoCN primary key (maCN,maSP)

------------------------------fOREIGN KEYS------------------------------
go 
alter table ChiNhanh
add constraint fk_chinhanh_khuvuc foreign key (maKV) references KhuVuc(maKV)
go 
alter table ChiNhanh
add constraint fk_chinhanh_quanly foreign key (maQL) references NhanVien(maNV)
go 
alter table NhanVien
add constraint fk_nhanvien_chinhanh foreign key (maCN) references ChiNhanh(maCN)
go 
alter table NhanVien
add constraint fk_nhanvien_vitri foreign key (maVT) references ViTri(maVT)
go 
alter table PhanCong
add constraint fk_phancong_nhanvien foreign key (maNV) references NhanVien(maNV)
go 
alter table PhanCong
add constraint fk_phancong_calam foreign key (maCa) references CaLam(maCa)
go 
alter table TaiKhoan
add constraint fk_taikhoan_nhanvien foreign key (maNV) references NhanVien(maNV)
go 
alter table SanPham
add constraint fk_sanpham_loaisp foreign key (maLoai) references LoaiSP(maLoai)
go 
alter table SanPham
add constraint fk_sanpham_nhasanxuat foreign key (maNSX) references NhaSanXuat(maNSX)
go 
alter table HoaDon
add constraint fk_hoadon_nhanvien foreign key (maNV) references NhanVien(maNV)
go 
alter table HoaDon
add constraint fk_hoadon_khachhang foreign key (maKH) references KhachHang(maKH)
go 
alter table ChiTietHD
add constraint fk_chitiethd_hoadon foreign key (maHD) references HoaDon(maHD)
go 
alter table ChiTietHD
add constraint fk_chitiethd_sanpham foreign key (maSP) references SanPham(maSP)
go 
alter table KhoCN
add constraint fk_khocn_chinhanh foreign key (maCN) references ChiNhanh(maCN)
go
alter table KhoCN
add constraint fk_khocn_sanpham foreign key (maSP) references SanPham(maSP)
go
alter table ChiTietCC
add constraint fk_chitietcc_nhasanxuat foreign key (maNSX) references NhaSanXuat(maNSX)
go
alter table ChiTietCC
add constraint fk_chitietcc_sanpham foreign key (maSP) references SanPham(maSP)
go
alter table ChiTietKM
add constraint fk_chitietkm_khuyenmai foreign key (maKM) references KhuyenMai(maKM)
go
alter table ChiTietKM
add constraint fk_chitietkm_sanpham foreign key (maSP) references SanPham(maSP)

------------------------------UNIQUE KEYS------------------------------
go 
alter table TaiKhoan
add constraint uk_taikhoan unique (maNV)
go
alter table NhanVien
add constraint uk_nhanvien unique (CCCD)
go
alter table CaLam
add constraint uk_calam unique (gioBD,gioKT)
--go
--alter table KhoCn
--add constraint uk_kho unique (maCN,maSP)

------------------------------CHECK KEYS------------------------------
go
alter table NhanVien
add constraint ck_ngaysinh check (year(getdate()) - year(ngaySinh) >= 18)
go
alter table ChiTietHD
add constraint ck_chitiethd_soluong check (soLuong >= 1)
go
alter table ChiTietCC
add constraint ck_chitietcc_soluong check (soLuong >= 1)
go
alter table ChiTietKM
add constraint ck_chitietkm_soluong check (soLuong >= 1)