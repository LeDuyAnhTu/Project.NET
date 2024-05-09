using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeKhoCN_BUS
    {
        ThongKeKhoCN_DAL data = new ThongKeKhoCN_DAL();
        /// <summary>
        /// Thống kê sản phẩm theo kho chi nhánh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeTheoKhoChiNhanh()
        {
            try
            {
                return data.ThongKeTheoKhoChiNhanh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// Thống kê giá trị sản phẩm theo kho chi nhánh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeGiaTriSanPhamTheoKhoChiNhanh()
        {
            try
            {
                return data.ThongKeGiaTriSanPhamTheoKhoChiNhanh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Thống kê tồn kho theo chi nhánh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeTonKhoTheoChiNhanh()
        {
            try
            {
                return data.ThongKeTonKhoTheoChiNhanh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Thống kê sản phẩm theo loại
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeSanPhamTheoLoai()
        {
            try
            {
                return data.ThongKeSanPhamTheoLoai();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
