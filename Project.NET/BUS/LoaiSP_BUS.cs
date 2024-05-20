using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSP_BUS
    {
        private static LoaiSP_DAL db = new LoaiSP_DAL();
        /// <summary>
        /// Lấy danh sách loại sản phẩm
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
        /// THêm loại mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(LoaiSP_DTO o)
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
        /// Sửa thông tin loại sản phẩm 
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(LoaiSP_DTO o)
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
        /// Xóa thông tin loại sản phẩm 
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tìm loại sản phẩm theo mã loại sản phẩm
        /// </summary>
        /// <param name="maLoai"></param>
        /// <returns></returns>
        public LoaiSP_DTO timLoaiSP_MaLoaiSP(string maLoai)
        {
            try
            {
                return db.timLoaiSP_MaLoaiSP(maLoai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
