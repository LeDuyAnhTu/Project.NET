using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanCong_DAL : BasicMethod<PhanCong_DTO>
    {
        /// <summary>
        /// Lấy danh sách phân công ngày làm
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from pc in db.DBO.PhanCongs
                     join cl in db.DBO.CaLams on pc.maCa equals cl.maCa
                     join nv in db.DBO.NhanViens on pc.maNV equals nv.maNV
                     orderby nv.tenNV, cl.tenCa
                     select new
                     {
                         pc.maNV,
                         nv.tenNV,
                         cl.tenCa,
                         pc.ngayDiLam,
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin phân công
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(PhanCong_DTO obj)
        {
            bool result = false;
            try
            {
                PhanCong temp = db.DBO.PhanCongs.Single(d => d.maNV == obj.MaNV);
                temp.maCa = obj.MaCa;
                temp.ngayDiLam = obj.NgayDiLam.ToShortDateString();

                db.DBO.SubmitChanges();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Thêm thông tin phân công
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(PhanCong_DTO obj)
        {
            bool result = false;
            try
            {
                PhanCong temp = new PhanCong()
                {
                    maNV = obj.MaNV,
                    maCa = obj.MaCa,
                    ngayDiLam = obj.NgayDiLam.ToShortDateString(),
                };

                db.DBO.PhanCongs.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa thông tin phân công của 1 nhân viên
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string maNV)
        {
            bool result = false;
            try
            {
                PhanCong temp = db.DBO.PhanCongs.Single(d => d.maNV == maNV);
                db.DBO.PhanCongs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa phân công 1 ca làm của 1 nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="maCa"></param>
        /// <returns></returns>
        public bool Xoa(string maNV, string maCa)
        {
            bool result = false;
            try
            {
                PhanCong temp = db.DBO.PhanCongs.Single(d => d.maNV == maNV && d.maCa == maCa);
                db.DBO.PhanCongs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Tìm lịch phân công của nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="maNV"></param>
        /// <returns></returns>
        public IQueryable timPhanCongTheoMaNV(string maNV)
        {
            IQueryable ds = null;
            try
            {
                ds = from pc in db.DBO.PhanCongs
                     join cl in db.DBO.CaLams on pc.maCa equals cl.maCa
                     join nv in db.DBO.NhanViens on pc.maNV equals nv.maNV
                     where pc.maNV.Equals(maNV)
                     orderby nv.tenNV, cl.tenCa
                     select new
                     {
                         pc.maNV,
                         nv.tenNV,
                         cl.tenCa,
                         pc.ngayDiLam,
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Tìm danh sách các ngày đi làm của nhân viên theo mã nhân viên và mã ca
        /// /// </summary>
        /// <param name="maNV"></param>
        /// <param name="maCa"></param>
        /// <returns></returns>
        public int[] timNgayDiLamTheoMaNV(string maNV, string maCa)
        {
            int[] ds = new int[7];
            try
            {
                var lichLam = from pc in db.DBO.PhanCongs
                               join cl in db.DBO.CaLams on pc.maCa equals cl.maCa
                               join nv in db.DBO.NhanViens on pc.maNV equals nv.maNV
                               where pc.maNV.Equals(maNV) && pc.maCa.Equals(maCa)
                               orderby nv.tenNV, cl.tenCa
                               select new
                               {
                                   pc.maNV,
                                   nv.tenNV,
                                   cl.tenCa,
                                   pc.ngayDiLam,
                               };
                var a = lichLam.ToList();
                foreach(var item in a)
                {
                   switch(item.ngayDiLam)
                    {
                        case "Thứ Hai":
                            ds[0] = 1;
                            break;
                        case "Thứ Ba":
                            ds[1] = 1;
                            break;
                        case "Thứ Tư":
                            ds[2] = 1;
                            break;
                        case "Thứ Năm":
                            ds[3] = 1;
                            break;
                        case "Thứ Sáu":
                            ds[4] = 1;
                            break;
                        case "Thứ Bảy":
                            ds[5] = 1;
                            break;
                        default:
                            ds[6] = 1;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
    }
}
