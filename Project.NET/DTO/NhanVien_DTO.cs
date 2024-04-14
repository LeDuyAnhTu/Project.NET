using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNV, tenNV, gioiTinh;
        private DateTime ngaySinh;
        private string soDT, cCCD;
        private int luong;
        private string maCN;

        public NhanVien_DTO(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string soDT, string cCCD, int luong, string maCN)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = soDT;
            CCCD = cCCD;
            Luong = luong;
            MaCN = maCN;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string SDT { get => soDT; set => soDT = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public int Luong { get => luong; set => luong = value; }
        public string MaCN { get => maCN; set => maCN = value; }
    }
}
