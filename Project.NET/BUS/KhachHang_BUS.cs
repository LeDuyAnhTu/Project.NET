using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHang_BUS
    {
        private static KhachHang_DAL db = new KhachHang_DAL();
        /// <summary>
        /// Lấy danh sách khách hàng 
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
        /// Lấy danh sách thông tin đơn giản
        /// </summary>
        /// <returns></returns>
        public IQueryable LayDanhSach_Combobox()
        {
            try
            {
                return db.LayDanHSach_Combobox();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm thông tin khách hàng mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(KhachHang_DTO o)
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
        /// Sửa thông tin của khách hàng
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(KhachHang_DTO o)
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
        /// Xóa thông tin khách hàng
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
        /// <summary>
        /// Tìm thông tin khách hàng theo mã khách hàng
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public KhachHang_DTO timKH_TheoMa(string maKH)
        {
            try
            {
                return db.timKH_TheoMa(maKH);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
