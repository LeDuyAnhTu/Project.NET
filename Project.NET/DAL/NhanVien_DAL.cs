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
            IQueryable ds = from nv in db.NhanViens
                            select nv;
            return ds;
        }
    }
}
