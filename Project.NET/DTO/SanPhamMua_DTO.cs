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
        private int soLuong;

        public SanPhamMua_DTO(string maSP, string tenSP, int soLuong)
        {
            MaSP = maSP;
            TenSP = tenSP;
            SoLuong = soLuong;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
