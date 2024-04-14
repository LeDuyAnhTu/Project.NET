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
    public class HoaDon_DTO
    {
        private string maHD;
        private DateTime ngayLap;
        private string maNV, maKH;
        private int diemDung, thanhTien;

        public HoaDon_DTO(string maHD, DateTime ngayLap, string maNV, string maKH, int diemDung, int thanhTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            MaNV = maNV;
            MaKH = maKH;
            DiemDung = diemDung;
            ThanhTien = thanhTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public int DiemDung { get => diemDung; set => diemDung = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
