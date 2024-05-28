using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKe_DAL : Database
    {
        /// <summary>
        /// Nguồn dữ liệu vẽ biểu đồ doanh thu theo tháng
        /// </summary>
        /// <param name="ngayBD"></param>
        /// <param name="ngayKT"></param>
        /// <param name="tenSP"></param>
        /// <returns></returns>
        public List<ThongKe_DTO> ThongKeDoanhThuTheo_Thang(DateTime ngayBD, DateTime ngayKT, string tenSP)
        {
            List<ThongKe_DTO> list = null;
            try
            {
                var ds = from hd in DBO.HoaDons
                         join cthd in DBO.ChiTietHDs on hd.maHD equals cthd.maHD
                         join sp in DBO.SanPhams on cthd.maSP equals sp.maSP
                         where hd.ngayLap.Date <= ngayKT.Date && hd.ngayLap.Date >= ngayBD.Date && sp.tenSP.Contains(tenSP)
                         orderby hd.ngayLap.Year, hd.ngayLap.Month
                         group new { hd, cthd, sp } by new { cthd.maSP, sp.tenSP, Month = hd.ngayLap.Month, Year = hd.ngayLap.Year } into kq
                         select new ThongKe_DTO
                         {
                             MaSP = kq.Key.maSP,
                             TenSP = kq.Key.tenSP,
                             TongTien = kq.Sum(d => d.cthd.soLuong * d.sp.donGia),
                             Thang = kq.Key.Month,
                             Nam = kq.Key.Year
                         };
                list = ds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Nguồn dữ liệu doanh thu theo năm
        /// </summary>
        /// <param name="namThongKe"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKe_DTO> ThongKeDoanhThuTheo_Nam(DateTime namThongKe)
        {
            List<ThongKe_DTO> list = null;
            try
            {
                var ds = from hd in DBO.HoaDons
                         join cthd in DBO.ChiTietHDs on hd.maHD equals cthd.maHD
                         join sp in DBO.SanPhams on cthd.maSP equals sp.maSP
                         where hd.ngayLap.Year == namThongKe.Year
                         orderby hd.ngayLap.Month
                         group new { hd, cthd, sp } by new { cthd.maSP, sp.tenSP, Month = hd.ngayLap.Month } into kq
                         select new ThongKe_DTO
                         {
                             MaSP = kq.Key.maSP,
                             TenSP = kq.Key.tenSP,
                             TongTien = kq.Sum(d => d.cthd.soLuong * d.sp.donGia),
                             Thang = kq.Key.Month,
                             Nam = namThongKe.Year
                         };
                list = ds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

    }
}
