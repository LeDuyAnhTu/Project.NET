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
    public class KhoCN
    {
        private string maCN, maSP;
        private int soLuong;

        public KhoCN(string maCN, string maSP, int soLuong)
        {
            MaCN = maCN;
            MaSP = maSP;
            SoLuong = soLuong;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
