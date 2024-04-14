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
    public class ChiTietHD
    {
        private string maHD, maSP;
        private int soLuong;

        public ChiTietHD(string maHD, string maSP, int soLuong)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
