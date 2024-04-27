using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CaLam_BUS
    {
        private static CaLam_DAL db = new CaLam_DAL();

        /// <summary>
        /// Danh sách ca làm
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
        /// Thêm ca làm mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(CaLam_DTO o)
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
        /// Sửa thông tin ca làm
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(CaLam_DTO o)
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
        /// Xóa ca làm
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
