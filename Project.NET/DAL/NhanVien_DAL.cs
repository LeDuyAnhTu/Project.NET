using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL : BasicMethod<NhanVien_DTO>
    {
        public override IQueryable LayDanhSach()
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
        public override bool Them(NhanVien_DTO nv)
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

                db.DBO.NhanViens.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override bool Sua(NhanVien_DTO nv)
        {
            bool result = false;
            try
            {
                NhanVien temp = db.DBO.NhanViens.Single(d => d.maNV == nv.MaNV);
                temp.tenNV = nv.TenNV;
                temp.gioiTinh = nv.GioiTinh;
                temp.ngaySinh = nv.NgaySinh;
                temp.SDT = nv.SDT;
                temp.CCCD = nv.CCCD;
                temp.luong = nv.Luong;

                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override bool Xoa(string maNV)
        {
            bool result = false;
            try
            {
                NhanVien temp = db.DBO.NhanViens.Single(d => d.maNV == maNV);
                
                db.DBO.NhanViens.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
