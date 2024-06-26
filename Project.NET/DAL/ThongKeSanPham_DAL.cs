﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeSanPham_DAL : BasicMethod<ThongKeSanPham_DTO>
    {

        /// <summary>
        /// Thống kê theo loại sản phẩm
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByProductType()
        {
            List<ThongKeSanPham_DTO> danhsach = null;
            try
            {
                var ds = from sp in db.DBO.SanPhams
                         join lsp in db.DBO.LoaiSPs on sp.maLoai equals lsp.maLoai
                         group sp by lsp.tenLoai into g
                         select new ThongKeSanPham_DTO { TenLoai = g.Key, SoLuongSanPham = g.Count() };

                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return danhsach;
        }

        /// <summary>
        /// Thống kê theo nhà sản xuất
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByManufacturer()
        {
            List<ThongKeSanPham_DTO> danhsach = null;
            try
            {
                var ds = from sp in db.DBO.SanPhams
                         join nsx in db.DBO.NhaSanXuats on sp.maNSX equals nsx.maNSX
                         group nsx by nsx.tenNSX into g
                         select new ThongKeSanPham_DTO { TenNSX = g.Key, SoLuongSanPham = g.Count() };

                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return danhsach;
        }
        /// <summary>
        /// Thống kê theo hạn sử dụng trong tháng tới (1 tháng tiếp theo)
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByExpiryDate()
        {
            List<ThongKeSanPham_DTO> danhsach = null;
            try
            {
                var ds = from sp in db.DBO.SanPhams
                         where sp.HSD >= DateTime.Now && sp.HSD <= DateTime.Now.AddMonths(1)
                         group sp by sp.HSD into g
                         select new ThongKeSanPham_DTO { HSD = g.Key, SoLuongSanPham = g.Count() };
                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return danhsach;
        }
        /// <summary>
        /// Thống kê theo khoảng giá
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByPrice()
        {
            List<ThongKeSanPham_DTO> danhsach = null;
            try
            {
                var ds = from sp in db.DBO.SanPhams
                         group sp by sp.donGia < 100000 ? "Dưới 100.000 VND" :
                             (sp.donGia >= 100000 && sp.donGia <= 500000 ? "100.000 VND - 500.000 VND" : "Trên 500.000 VND") into g
                         select new ThongKeSanPham_DTO { KhoangGia = g.Key, SoLuongSanPham = g.Count() };
                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return danhsach;
        }
        /// <summary>
        /// Thống kê theo số lượng còn lại
        /// </summary>
        /// <returns></returns>
        public List<ThongKeSanPham_DTO> StatsByRemainingQuantity()
        {
            List<ThongKeSanPham_DTO> danhsach = null;
            try
            {
                var ds = from sp in db.DBO.SanPhams
                         group sp by sp.soLuongConLai < 10 ? "Dưới 10" :
                             (sp.soLuongConLai >= 10 && sp.soLuongConLai <= 50 ? "10 - 50" : "Trên 50") into g
                         select new ThongKeSanPham_DTO { SoLuongConLai = g.Key, SoLuongSanPham = g.Count() };
                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return danhsach;
        }

        /// <summary>
        /// Thống kê top 10 sản phẩm bán chạy
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeSanPhamBanNhieu_DTO> ThongkeTop10SanPhamBanChay()
        {
            List<ThongKeSanPhamBanNhieu_DTO> danhsach = null;
            try
            {
                var ds = (from orderDetail in db.DBO.ChiTietHDs
                          group orderDetail by orderDetail.SanPham.tenSP into g
                          select new ThongKeSanPhamBanNhieu_DTO
                          {
                              TenSP = g.Key,
                              TotalSold = g.Sum(x => x.soLuong)
                          }).OrderByDescending(x => x.TotalSold).Take(10);
                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhsach;
        }
        /// <summary>
        /// Thống kê top 10 sản phẩm bán ế
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeSanPhamBanIt_DTO> ThongkeTop10SanPhamBanE()
        {
            List<ThongKeSanPhamBanIt_DTO> danhsach = null;

            try
            {
                var ds = (from orderDetail in db.DBO.ChiTietHDs
                          group orderDetail by orderDetail.SanPham.tenSP into g
                          select new ThongKeSanPhamBanIt_DTO
                          {
                              TenSP = g.Key,
                              TotalSold = g.Sum(x => x.soLuong)
                          }).OrderBy(x => x.TotalSold).Take(10);
                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhsach;
        }
        /// <summary>
        /// Thống kê số lượng tồn kho
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeSanPhamTonKho_DTO> ThongkeSanPhamTonKho()
        {
            List<ThongKeSanPhamTonKho_DTO> danhsach = null;


            try
            {
                var ds = from sanpham in db.DBO.SanPhams
                         select new ThongKeSanPhamTonKho_DTO
                         {
                             MaSP = sanpham.maSP,
                             TenSP = sanpham.tenSP,
                             SoLuongTonKho = sanpham.soLuongConLai
                         };
                danhsach = ds.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return danhsach;
        }



        public override IQueryable LayDanhSach()
        {
            throw new NotImplementedException();
        }

        public override bool Them(ThongKeSanPham_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }

        public override bool Sua(ThongKeSanPham_DTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
