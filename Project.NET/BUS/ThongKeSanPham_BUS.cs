using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeSanPham_BUS
    {
        ThongKeSanPham_DAL db = new ThongKeSanPham_DAL();
        /// <summary>
        /// Thống kê theo loại sản phẩm
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByProductType()
        {

            try
            {
                return db.StatsByProductType();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Thống kê theo nhà sản xuất
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByManufacturer()
        {

            try
            {
                return db.StatsByManufacturer();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Thống kê theo hạn sử dụng
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByExpiryDate()
        {

            try
            {
                return db.StatsByExpiryDate();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Thống kê theo giá
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByPrice()
        {

            try
            {
                return db.StatsByPrice();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// Thống kê theo số lượng còn lại
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByRemainingQuantity()
        {
            try
            {
                return db.StatsByRemainingQuantity();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
