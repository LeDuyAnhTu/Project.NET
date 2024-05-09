using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeKhoCN_DTO
    {
        public string MaCN { get; set; }
        public string TenCN { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuongTrongKho { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaTri => SoLuongTrongKho * DonGia;
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MaNSX { get; set; }
    }
}
