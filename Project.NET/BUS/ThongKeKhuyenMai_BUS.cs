using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeKhuyenMai_BUS
    {
        ThongKeKhuyenMai_DAL data = null;
        public ThongKeKhuyenMai_BUS()
        {
            data = new ThongKeKhuyenMai_DAL();
        }
        public List<ThongKeKhuyenMai_DTO> LayDanhSachThongKeKM()
        {
            try
            {
                return data.LayDanhSachThongKeKM();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Thực hiện thao tác lấy số lượng còn lại của sản phẩm dựa trên mã sản phẩm
        /// </summary>
        /// <param name="maSP">Nếu không tìm thấy sản phẩm, trả về 0</param>
        /// <returns>Trả về số lượng còn lại của sản phẩm</returns>
        public int LaySoLuongConLai(string maSP)
        {

            try
            {
                return data.LaySoLuongConLai(maSP);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Thực hiện thao tác mua hàng
        /// </summary>
        /// <param name="maSP">Nếu tìm thấy sản phẩm</param>
        /// <param name="soLuongMua"> và số lượng mua nhỏ hơn hoặc bằng số lượng còn lại</param>
        /// <exception cref="Exception">Nếu không tìm thấy sản phẩm hoặc số lượng mua lớn hơn số lượng còn lại, ném ra một ngoại lệ</exception>
        public void MuaHang(string maSP, int soLuongMua)
        {
            try
            {
                data.MuaHang(maSP, soLuongMua);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
