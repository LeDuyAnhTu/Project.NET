using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaSanXuat_BUS
    {
        private static NhaSanXuat_DAL db = new NhaSanXuat_DAL();
        /// <summary>
        /// Lấy danh sách nhà sản xuất
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
        public IQueryable LayDanhSach_Combobox()
        {
            try
            {
                return db.LayDanhSach_Combobox();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm thông tin nhà sản xuất mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(NhaSanXuat_DTO o)
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
        /// Sửa thông tin nhà sản xuất
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(NhaSanXuat_DTO o)
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
        /// Xóa thông tin nhà sản xuất
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
    }
}
