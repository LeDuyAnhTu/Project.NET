using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeSanPham_DTO
    {
        public string TenLoai { get; set; }
        public int SoLuongSanPham { get; set; }

        public string MaNSX { get; set; }
        
        public string TenNSX { get; set; }

        public DateTime HSD { get; set; }

        public string KhoangGia { get; set; }

        public string SoLuongConLai { get; set; }

        public string TenSP { get; set; }
    }
}
