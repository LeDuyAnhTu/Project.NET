using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPham_BUS
    {
        private static SanPham_DAL db = new SanPham_DAL();
        /// <summary>
        /// Lấy danh sách sản phẩm
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
        /// Thêm thông tin sản phẩm mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(SanPham_DTO o)
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
        /// Sửa thông tin sản phẩm
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(SanPham_DTO o)
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
        /// Xóa thông tin sản phẩm
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
        /// Tạo mã sản phẩm mới
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                return db.taoMaMoi();
            } catch (Exception ex)
            {
                throw ex;
            }

        }
        public SanPham_DTO timSanPham_MaSP(string maSP)
        {
            try
            {
                return db.timSanPham_MaSP(maSP);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
