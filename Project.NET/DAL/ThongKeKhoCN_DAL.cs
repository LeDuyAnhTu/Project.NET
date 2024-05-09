using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeKhoCN_DAL : BasicMethod<ThongKeKhoCN_DTO>
    {

        /// <summary>
        /// Thống kê sản phẩm theo kho chi nhánh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeTheoKhoChiNhanh()
        {
            List<ThongKeKhoCN_DTO> list = null;

            try
            {
                var query = from cn in db.DBO.ChiNhanhs
                            join k in db.DBO.KhoCNs on cn.maCN equals k.maCN
                            join sp in db.DBO.SanPhams on k.maSP equals sp.maSP
                            select new ThongKeKhoCN_DTO
                            {
                                MaCN = cn.maCN,
                                TenCN = cn.tenCN,
                                MaSP = sp.maSP,
                                TenSP = sp.tenSP,
                                SoLuongTrongKho = k.soLuong
                            };
                list = query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Thống kê giá trị sản phẩm theo kho chi nhánh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeGiaTriSanPhamTheoKhoChiNhanh()
        {
            List<ThongKeKhoCN_DTO> list = null;

            try
            {
                var query = from cn in db.DBO.ChiNhanhs
                            join k in db.DBO.KhoCNs on cn.maCN equals k.maCN
                            join sp in db.DBO.SanPhams on k.maSP equals sp.maSP
                            select new ThongKeKhoCN_DTO
                            {
                                MaCN = cn.maCN,
                                TenCN = cn.tenCN,
                                MaSP = sp.maSP,
                                TenSP = sp.tenSP,
                                SoLuongTrongKho = k.soLuong,
                                DonGia = sp.donGia
                            };
                list = query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Thống kê tồn kho theo chi nhánh
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeTonKhoTheoChiNhanh()
        {
            List<ThongKeKhoCN_DTO> list = null;

            try
            {
                var query = from cn in db.DBO.ChiNhanhs
                            join k in db.DBO.KhoCNs on cn.maCN equals k.maCN
                            group k by new { cn.maCN, cn.tenCN } into g
                            select new ThongKeKhoCN_DTO
                            {
                                MaCN = g.Key.maCN,
                                TenCN = g.Key.tenCN,
                                SoLuongTrongKho = g.Sum(k => k.soLuong)
                            };
                list = query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        /// <summary>
        /// Thống kê sản phẩm theo loại
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<ThongKeKhoCN_DTO> ThongKeSanPhamTheoLoai()
        {
            List<ThongKeKhoCN_DTO> list = null;

            try
            {
                var query = from sp in db.DBO.SanPhams
                            join l in db.DBO.LoaiSPs on sp.maLoai equals l.maLoai
                            group sp by new { l.maLoai, l.tenLoai } into g
                            select new ThongKeKhoCN_DTO
                            {
                                MaLoai = g.Key.maLoai,
                                TenLoai = g.Key.tenLoai,
                                SoLuongTrongKho = g.Sum(sp => sp.soLuongConLai)
                            };
                list = query.ToList();
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

        public override bool Sua(ThongKeKhoCN_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Them(ThongKeKhoCN_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
