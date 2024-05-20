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
        /// <summary>
        /// Lấy danh sách các nhân viên
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from nv in db.DBO.NhanViens
                                join cn in db.DBO.ChiNhanhs on nv.maCN equals cn.maCN
                                join vt in db.DBO.ViTris on nv.maVT equals vt.maVT
                                where nv.maNV != "NV0"
                                orderby nv.maNV ascending
                                select new
                                {
                                    MãSố = nv.maNV,
                                    HọTên = nv.tenNV,
                                    CănCước = nv.CCCD,
                                    SốĐiệnThoại = nv.SDT,
                                    GiớiTính = nv.gioiTinh,
                                    NgàySinh = nv.ngaySinh,
                                    MứcLương = nv.luong,
                                    ChiNhánh = cn.tenCN,
                                    VịTrí = vt.tenVT
                                };
                return ds;
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
        public IQueryable LayDanhSach_ViTri(string maVT)
        {
            try
            {
                IQueryable ds = from nv in db.DBO.NhanViens
                                join cn in db.DBO.ChiNhanhs on nv.maCN equals cn.maCN
                                join vt in db.DBO.ViTris on nv.maVT equals vt.maVT
                                where nv.maNV != "NV0" && nv.maVT.Equals(maVT)
                                orderby nv.maNV ascending
                                select new
                                {
                                    MãSố = nv.maNV,
                                    HọTên = nv.tenNV,
                                    CănCước = nv.CCCD,
                                    SốĐiệnThoại = nv.SDT,
                                    GiớiTính = nv.gioiTinh,
                                    NgàySinh = nv.ngaySinh,
                                    MứcLương = nv.luong,
                                    ChiNhánh = cn.tenCN,
                                    VịTrí = vt.tenVT
                                };
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm nhân viên mới
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
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
                    maCN = nv.MaCN,
                    maVT = nv.MaVT,
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
        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
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
                temp.maVT = nv.MaVT;
                temp.maCN = nv.MaCN;

                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Xóa nhân viên khỏi hệ thống
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Tạo mã ID tiếp theo ID cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaNVMoi()
        {
            try
            {
                //Lấy mã nhân viên cuối
                IQueryable ds = (from nv in db.DBO.NhanViens
                                 orderby nv.maNV descending
                                 select nv.maNV).Take(1);
                string msNV = "";
                foreach (var item in ds)
                {
                    msNV = item.ToString();
                }

                //Lấy số tiếp theo msNV cuối
                string maSo = msNV.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã NV mới
                msNV = "NV" + String.Format("{0:D8}", soMoi);

                return msNV;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "NV00000001";
            }
        }
        public NhanVien_DTO timTheoMa(string maNV)
        {
            try
            {
                NhanVien nv = db.DBO.NhanViens.Single(d => d.maNV == maNV);
                return new NhanVien_DTO(nv.maNV, nv.tenNV, nv.gioiTinh, nv.ngaySinh, nv.SDT, nv.CCCD, (int)nv.luong, nv.maVT, nv.maCN);
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
                IQueryable ds = from nv in db.DBO.NhanViens
                                where nv.maCN.Equals(maCN)
                                orderby nv.maNV ascending
                                select new
                                {
                                    MãSố = nv.maNV,
                                    HọTên = nv.tenNV,
                                    CănCước = nv.CCCD,
                                    SốĐiệnThoại = nv.SDT,
                                    GiớiTính = nv.gioiTinh,
                                    NgàySinh = nv.ngaySinh,
                                    MứcLương = nv.luong,
                                };
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
