using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanCong_BUS
    {
        private static PhanCong_DAL db = new PhanCong_DAL();

        /// <summary>
        /// Lấy Lịch phân công công việc của các nhân viên
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
        /// Thêm lịch làm việc
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(PhanCong_DTO o)
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
        /// Sửa thông tin phân công
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(PhanCong_DTO o)
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
        /// Xóa thông tin phân công công việc theo mã nhân viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Xoa(string maNV)
        {
            bool result = false;

            try
            {
                result = db.Xoa(maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa thông tin phân công theo mã ca và mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="maCa"></param>
        /// <returns></returns>
        public bool Xoa(string maNV, string maCa)
        {
            try
            {
                return db.Xoa(maNV, maCa);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tìm lịch làm việc của nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public IQueryable timPhanCongTheoMaNV(string maNV)
        {
            try
            {
                return db.timPhanCongTheoMaNV(maNV);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tìm các ngày đi làm của nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public int[] timNgayDiLamTheoMaNV(string maNV, string maCa)
        {
            try
            {
                return db.timNgayDiLamTheoMaNV(maNV, maCa);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
