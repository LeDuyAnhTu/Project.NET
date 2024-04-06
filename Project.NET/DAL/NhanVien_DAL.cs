using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        private static QLBHXDatabase db = new QLBHXDatabase();
        public IQueryable LayDanhSach()
        {
            IQueryable ds = from nv in db.DB.NhanViens
                            select nv;
            return ds;
        }
    }
}
