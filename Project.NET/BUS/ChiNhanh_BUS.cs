using DAL;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiNhanh_BUS
    {
        private static ChiNhanh_DAL db = new ChiNhanh_DAL();

        /// <summary>
        /// Lấy danh sách các chi nhánh có trong hệ thống
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
        /// Lấy danh sách các chi nhánh cho combobox
        /// </summary>
        /// <returns></returns>
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
        /// Thêm chi nhánh mới vào hệ thống
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(ChiNhanh_DTO o)
        {
            bool result = false;
            //Thêm them ca lam
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
        /// Sửa thông tin chi nhánh
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(ChiNhanh_DTO o)
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
        /// Xóa thông tin chi nhánh
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Xoa(string id)
        {
            bool result = false;
            //Thêm nhân viên
            try
            {
                result = db.Xoa(id);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("fk_nhanvien_chinhanh"))
                {
                    throw new Exception("Vẫn còn nhân viên làm việc tại chi nhánh này. Vui lòng hãy điều động họ đến các chi nhánh khác trước khi xóa!");
                }
                else
                {
                    throw ex;
                }
            }
            return result;
        }
        /// <summary>
        /// Tạo mã chi nhánh mới
        /// </summary>
        /// <returns></returns>
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
