using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietCC_BUS
    {
        private static ChiTietCC_DAL db = new ChiTietCC_DAL();

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

        public bool Them(ChiTietCC_DTO o)
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

        public bool Sua(ChiTietCC_DTO o)
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
    }
}
