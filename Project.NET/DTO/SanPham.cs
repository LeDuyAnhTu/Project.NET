/*
 * Date: 14/04/2024
 * Author: Lê Duy Anh Tú
 * Missing: Bắt lỗi
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private string maSP, tenSP;
        private DateTime hSD;
        private int donGia, soLuongConLai;
        private string maLoai, maNSX;

        public SanPham(string maSP, string tenSP, DateTime hSD, int donGia, int soLuongConLai, string maLoai, string maNSX)
        {
            MaSP = maSP;
            TenSP = tenSP;
            HSD = hSD;
            DonGia = donGia;
            SoLuongConLai = soLuongConLai;
            MaLoai = maLoai;
            MaNSX = maNSX;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public DateTime HSD { get => hSD; set => hSD = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuongConLai { get => soLuongConLai; set => soLuongConLai = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
    }
}
