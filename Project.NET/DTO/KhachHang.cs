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
    public class KhachHang
    {
        private string maKH, tenKH, sDT, ngaySinh, diemTichLuy;

        public KhachHang(string maKH, string tenKH, string sDT, string ngaySinh, string diemTichLuy)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SDT = sDT;
            NgaySinh = ngaySinh;
            DiemTichLuy = diemTichLuy;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
    }
}
