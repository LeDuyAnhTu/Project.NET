using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeNhanVien_DAL : BasicMethod<ThongKeNhanVien_DTO>
    {
        /// <summary>
        /// Thong ke nhan vien chi nhanh theo so luong
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoChiNhanh()
        {
            List<ThongKeNhanVien_DTO> list = null;
            try
            {
                var ds = from nv in db.DBO.NhanViens
                         group nv by nv.maCN into g
                         join vt in db.DBO.ChiNhanhs on g.Key equals vt.maCN
                         select new ThongKeNhanVien_DTO
                         {
                             TenCN = vt.tenCN,
                             SoLuongNV = g.Count()
                         };

                list = ds.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        /// <summary>
        /// Thong ke nhan vien chi nhanh theo gioi tinh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoGioiTinh()
        {
            List<ThongKeNhanVien_DTO> list = null;
            try
            {
                var ds = from nv in db.DBO.NhanViens
                         join cn in db.DBO.ChiNhanhs on nv.maCN equals cn.maCN
                         group nv by new { cn.tenCN, nv.gioiTinh } into gg
                         select new ThongKeNhanVien_DTO
                         {
                             TenCN = gg.Key.tenCN,
                             GioiTinh = gg.Key.gioiTinh,
                             SoLuongNV = gg.Count()
                         };

                list = ds.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Thong ke nhan vien chi nhanh theo tuoi
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoTuoi()
        {
            List<ThongKeNhanVien_DTO> list = null;
            try
            {
                var ds = from nv in db.DBO.NhanViens
                         join cn in db.DBO.ChiNhanhs on nv.maCN equals cn.maCN
                         let age = DateTime.Now.Year - nv.ngaySinh.Year
                         let khoangTuoi = age >= 22 && age <= 30 ? "22-30" :
                                          age >= 31 && age <= 35 ? "31-35" :
                                          age >= 36 && age <= 50 ? "36-50" : "Khác"
                         group nv by new { cn.tenCN, KhoangTuoiNV = khoangTuoi } into gg
                         select new ThongKeNhanVien_DTO
                         {
                             TenCN = gg.Key.tenCN,
                             KhoangTuoiNV = gg.Key.KhoangTuoiNV,
                             SoLuongNV = gg.Count()
                         };


                list = ds.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        /// <summary>
        /// Thong ke nhan vien chi nhanh theo vi tri chuc vu
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoViTriChucVuNhanVien()
        {
            List<ThongKeNhanVien_DTO> list = null;
            try
            {
                var ds = from nv in db.DBO.NhanViens
                         join cn in db.DBO.ChiNhanhs on nv.maCN equals cn.maCN
                         join vt in db.DBO.ViTris on nv.maVT equals vt.maVT
                         group nv by new { cn.tenCN, vt.tenVT } into gg
                         select new ThongKeNhanVien_DTO
                         {
                             TenCN = gg.Key.tenCN,
                             TenChucVu = gg.Key.tenVT,/* vị trí chức vụ nhân viên*/
                             SoLuongNV = gg.Count()
                         };

                list = ds.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }














        public override IQueryable LayDanhSach()
        {
            throw new NotImplementedException();
        }

        public override bool Sua(ThongKeNhanVien_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Them(ThongKeNhanVien_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
