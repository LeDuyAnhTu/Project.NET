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
        public IQueryable doanhThu_Thang(DateTime ngayBD, DateTime ngayKT, string tenSP)
        {
            IQueryable ds = null;
            try
            {
                ds = from hd in DBO.HoaDons
                     join cthd in DBO.ChiTietHDs on hd.maHD equals cthd.maHD
                     join sp in DBO.SanPhams on cthd.maSP equals sp.maSP
                     where hd.ngayLap <= ngayKT && hd.ngayLap >= ngayBD && sp.tenSP.Contains(tenSP)
                     orderby hd.ngayLap.Month
                     group hd by new { cthd.maSP, sp.tenSP, hd.ngayLap.Month } into kq
                     select new
                     {
                         Mã_SP = kq.Key.maSP,
                         Tên_SP = kq.Key.tenSP,
                         Tổng_Tiền = kq.Sum(d => d.thanhTien),
                         Tháng = kq.Key.Month
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
