using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeNhanVien_BUS
    {
        ThongKeNhanVien_DAL data = new ThongKeNhanVien_DAL();
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoChiNhanh()
        {
            try
            {
                return data.ThongKeNhanVienTheoChiNhanh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Thong ke nhan vien chi nhanh theo gioi tinh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoGioiTinh()
        {
            try
            {
                return data.ThongKeNhanVienTheoGioiTinh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// Thong ke nhan vien chi nhanh theo tuoi
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoTuoi()
        {
             
            try
            {
                return data.ThongKeNhanVienTheoTuoi();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        /// <summary>
        /// Thong ke nhan vien chi nhanh theo vi tri chuc vu
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoViTriChucVuNhanVien()
        {
             
            try
            {
                return data.ThongKeNhanVienTheoViTriChucVuNhanVien();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }


}
