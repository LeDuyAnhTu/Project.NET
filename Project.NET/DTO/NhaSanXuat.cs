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
    public class NhaSanXuat
    {
        private string maNSX, tenNSX, sDTNSX, diaChi;

        public NhaSanXuat(string maNSX, string tenNSX, string sDTNSX, string diaChi)
        {
            MaNSX = maNSX;
            TenNSX = tenNSX;
            SDTNSX = sDTNSX;
            DiaChi = diaChi;
        }

        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
        public string SDTNSX { get => sDTNSX; set => sDTNSX = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
