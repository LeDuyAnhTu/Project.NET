using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien_BUS
    {
        private static NhanVien_DAL nv = new NhanVien_DAL();
        private static TaiKhoan_DAL tk = new TaiKhoan_DAL();
        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        public IQueryable LayDanhSach()
        {
            try
            {
                return nv.LayDanhSach();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Them(NhanVien_DTO nhanVien)
        {
            bool result = false;
            //Thêm nhân viên
            try
            {
                result = nv.Them(nhanVien);
            }catch(Exception ex)
            {
                throw ex;
            }
            //Tạo tài khoản cho nhân viên mới
            try
            {
                string tenTK = nhanVien.MaNV;
                result = tk.Them(new TaiKhoan_DTO(tenTK,"123456",nhanVien.MaNV,"2"));
            }catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }

}
