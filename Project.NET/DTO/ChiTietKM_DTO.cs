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
    public class ChiTietKM_DTO
    {
        private string maKM, maSP;
        private int soLuong;

        public ChiTietKM_DTO(string maKM, string maSP, int soLuong)
        {
            MaKM = maKM;
            MaSP = maSP;
            SoLuong = soLuong;
        }

        public string MaKM { get => maKM; set => maKM = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
