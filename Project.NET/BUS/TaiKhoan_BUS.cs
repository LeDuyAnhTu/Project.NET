using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        private static TaiKhoan_DAL db = new TaiKhoan_DAL();
        /// <summary>
        /// Lấy danh sách các tài khoản
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
        /// Thêm tài khoản mới
        /// </summary>
        /// <param name="taiKhoan"></param>
        /// <returns></returns>
        public bool Them(TaiKhoan_DTO taiKhoan)
        {
            bool result = false;

            try
            {
                result = db.Them(taiKhoan);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        /// <summary>
        /// Sửa thông tin tài khoản
        /// </summary>
        /// <param name="taiKhoan"></param>
        /// <returns></returns>
        public bool Sua(TaiKhoan_DTO taiKhoan)
        {
            bool result = false;

            try
            {
                result = db.Sua(taiKhoan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa tài khoản
        /// </summary>
        /// <param name="tenTaiKhoan"></param>
        /// <returns></returns>
        public bool Xoa(string tenTaiKhoan)
        {
            bool result = false;

            try
            {
                result = db.Xoa(tenTaiKhoan);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Tìm tài khoản theo tên tài khoản
        /// </summary>
        /// <param name="tenTK"></param>
        /// <returns></returns>
        public TaiKhoan_DTO timTaiKhoan_TenTK(string tenTK)
        {
            try
            {
                return db.timTaiKhoan_TenTK(tenTK);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
