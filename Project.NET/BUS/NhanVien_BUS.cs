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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách nhân viên theo mã vị trí
        /// </summary>
        /// <param name="maVT"></param>
        /// <returns></returns>
        public IQueryable LayDanhSach_ViTri(string maVT)
        {
            try
            {
                return nv.LayDanhSach_ViTri(maVT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm nhân viên mới vào hệ thống và tạo tài khoản mới cho nhân viên đó
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool Them(NhanVien_DTO nhanVien)
        {
            bool result = false;
            //Thêm nhân viên
            try
            {
                result = nv.Them(nhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Tạo tài khoản cho nhân viên mới
            try
            {
                string tenTK = nhanVien.MaNV;
                // Tài khoản mặc định có tên tài khoản là msNV, mật khẩu là 123456
                result = tk.Them(new TaiKhoan_DTO(tenTK, "123456", nhanVien.MaNV));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Sửa thông tin nhân viên có trong hệ thống
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool Sua(NhanVien_DTO nhanVien)
        {
            bool result = false;
            //Sửa thông tin nhân viên
            try
            {
                result = nv.Sua(nhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public bool Xoa(string maNV)
        {
            bool result = false;
            //Xóa tài khoản của nhân viên
            try
            {
                result = tk.Xoa(tk.TimTaiKhoan_MaNV(maNV).tenTK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //Xóa nhân viên
            try
            {
                result = nv.Xoa(maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Tạo id mới cho nhân viên mới
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            return nv.taoMaNVMoi();
        }
        /// <summary>
        /// Tìm nhân viên trong hệ thống theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public NhanVien_DTO timTheoMa(string maNV)
        {
            try
            {
                return nv.timTheoMa(maNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách các nhân viên theo vị trí
        /// </summary>
        /// <returns></returns>
        public IQueryable LayDanhSach_ChiNhanh_NhanVien(string maCN)
        {
            try
            {

                return nv.LayDanhSach_ChiNhanh_NhanVien(maCN);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
