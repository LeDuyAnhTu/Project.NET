using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHD_DAL : BasicMethod<ChiTietHD_DTO>
    {
        /// <summary>
        /// Lấy danh sách chi tiết hóa đơn
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {

            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin chi tiết hóa đơn
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ChiTietHD_DTO obj)
        {
            bool result = false;
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Thêm chi tiết hóa đơn mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Them(ChiTietHD_DTO obj)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Xóa chi tiết hóa đơn
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
