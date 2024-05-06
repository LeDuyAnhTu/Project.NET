using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Sản phẩm được chọn mua
    /// </summary>
    public class SanPhamMua_DTO
    {
        private string maSP;
        private string tenSP;
        private int donGia, soLuong, thanhTien;

        public SanPhamMua_DTO(string maSP, string tenSP, int donGia, int soLuong, int thanhTien)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DonGia = donGia;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
