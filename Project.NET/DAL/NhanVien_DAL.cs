using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        private static QLBHXDataContext db = new QLBHXDataContext();
        public IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from nv in db.NhanViens
                                select new
                                {
                                    Mã_NV = nv.maNV,
                                    Họ_Tên_NV = nv.tenNV 
                                };
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
