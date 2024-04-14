using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL
    {
        private static Database db = new Database();
        public IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from nv in db.DBO.NhanViens
                                select new
                                {
                                    Mã_NV = nv.maNV,
                                    Họ_Tên_NV = nv.tenNV
                                };
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Them(NhanVien_DTO nv)
        {
            bool result = false;
            try
            {
                NhanVien temp = new NhanVien()
                {
                    maNV = nv.MaNV,
                    tenNV = nv.TenNV,
                    gioiTinh = nv.GioiTinh,
                    ngaySinh = nv.NgaySinh,
                    SDT = nv.SDT,
                    CCCD = nv.CCCD,
                    luong = nv.Luong,

                };
                return result;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
