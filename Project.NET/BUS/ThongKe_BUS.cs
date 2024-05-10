using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKe_BUS
    {
        ThongKe_DAL data = new ThongKe_DAL();
        /// <summary>
        /// Nguồn dữ liệu vẽ biểu đồ doanh thu theo tháng
        /// </summary>
        /// <param name="ngayBD"></param>
        /// <param name="ngayKT"></param>
        /// <param name="tenSP"></param>
        /// <returns></returns>
        public List<ThongKe_DTO> ThongKeDoanhThuTheo_Thang(DateTime ngayBD, DateTime ngayKT, string tenSP)
        {
             
            try
            {
                return data.ThongKeDoanhThuTheo_Thang(ngayBD, ngayKT, tenSP);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
             
        }
        /// <summary>
        /// Nguồn dữ liệu doanh thu theo năm
        /// </summary>
        /// <param name="namThongKe"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKe_DTO> ThongKeDoanhThuTheo_Nam(DateTime namThongKe)
        {
             
            try
            {
                return data.ThongKeDoanhThuTheo_Nam(namThongKe);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
