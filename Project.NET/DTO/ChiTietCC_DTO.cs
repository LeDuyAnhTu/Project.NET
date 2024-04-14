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
    public class ChiTietCC_DTO
    {
        private string maCC, maNSX, maSP;
        private int soLuong;
        private DateTime ngayCC;

        public ChiTietCC_DTO(string maCC, string maNSX, string maSP, int soLuong, DateTime ngayCC)
        {
            MaCC = maCC;
            MaNSX = maNSX;
            MaSP = maSP;
            SoLuong = soLuong;
            NgayCC = ngayCC;
        }

        public string MaCC { get => maCC; set => maCC = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public DateTime NgayCC { get => ngayCC; set => ngayCC = value; }
    }
}
