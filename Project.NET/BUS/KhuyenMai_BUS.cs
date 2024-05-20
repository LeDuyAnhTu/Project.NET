using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhuyenMai_BUS
    {
        private static KhuyenMai_DAL db = new KhuyenMai_DAL();

        public IQueryable LayDanhSach()
        {
            try
            {
                return db.LayDanhSach();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Them(KhuyenMai_DTO o)
        {
            bool result = false;

            try
            {
                result = db.Them(o);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool Sua(KhuyenMai_DTO o)
        {
            bool result = false;

            try
            {
                result = db.Sua(o);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool Xoa(string id)
        {
            bool result = false;

            try
            {
                result = db.Xoa(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Tạo mã khuyến mãi mới nối tiếp mã khuyến mãi cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                return db.taoMaMoi();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public KhuyenMai_DTO timKhuyenMai_MaKM(string maKM)
        {
            try
            {
                return db.timKhuyenMai_MaKM(maKM);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
