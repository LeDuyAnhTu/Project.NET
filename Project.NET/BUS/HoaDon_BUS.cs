using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        private static HoaDon_DAL db = new HoaDon_DAL();
        /// <summary>
        /// lấy danh sách các hóa đơn
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Thêm hóa đơn mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(HoaDon_DTO o)
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
        /// <summary>
        /// Sửa thông tin hóa đơn
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(HoaDon_DTO o)
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
        /// <summary>
        /// Xóa thông tin hóa đơn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
        public string taoMaMoi()
        {
            try
            {
                return db.taoMaMoi();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
