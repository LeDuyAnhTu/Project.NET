using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien_BUS
    {
        private static NhanVien_DAL nv = new NhanVien_DAL();
        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        public IQueryable LayDanhSach()
        {
            try
            {
                return nv.LayDanhSach();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
