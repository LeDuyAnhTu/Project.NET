using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoCN_BUS
    {
        private static KhoCN_DAL db = new KhoCN_DAL();
        /// <summary>
        /// lấy danh sách các sản phẩm trong các kho
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
        /// Lấy danh sách sản phẩm tồn trong kho chi nhánh theo mã chi nhánh
        /// </summary>
        /// <param name="maCN"></param>
        /// <returns></returns>
        public IQueryable LayDanhSach_TheoCN(string maCN)
        {
            try
            {
                return db.LayDanhSach_TheoCN(maCN);
            }catch(Exception ex)
            {
                if(ex.Message.Contains("no elements"))
                {
                    throw new Exception("Kho rỗng");
                }
                throw ex;
            }
        }
        /// <summary>
        /// Thêm thông tin kho mới
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(KhoCN_DTO o)
        {
            bool result = false;

            try
            {
                result = db.Them(o);
            }
            catch (Exception ex)
            {
                //Thêm số lượng nếu sản phẩm đã tồn tại trong kho
                if (ex.Message.Contains("already in use") || ex.Message.Contains("PRIMARY"))
                {
                    throw new Exception("Sản phẩm đã có trong kho");
                }
                else
                {
                    throw ex;
                }
            }

            return result;
        }
        /// <summary>
        /// Sửa thông tin tồn kho
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(KhoCN_DTO o)
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
        /// Xóa thông tin tồn kho
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
        public bool Xoa(string maCN, string maSP)
        {
            try
            {
                return db.Xoa(maCN,maSP);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public KhoCN_DTO timKho_MaCN_MaSP(string maCN, string maSP)
        {
            try
            {
                return db.timKho_MaCN_MaSP(maCN,maSP);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
