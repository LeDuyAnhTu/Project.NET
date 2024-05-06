using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPham_DAL : BasicMethod<SanPham_DTO>
    {
        /// <summary>
        /// Lấy danh sách sản phẩm
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from sp in db.DBO.SanPhams
                     join lsp in db.DBO.LoaiSPs on sp.maLoai equals lsp.maLoai
                     join nsx in db.DBO.NhaSanXuats on sp.maNSX equals nsx.maNSX
                     select new
                     {
                        MãSố = sp.maSP,
                        TênSảnPhẩm = sp.tenSP,
                        Loại = lsp.tenLoai,
                        TồnKho = sp.soLuongConLai,
                        NSX = nsx.tenNSX,
                     };
            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin của 1 sản phẩm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(SanPham_DTO obj)
        {
            bool result = false;
            try
            {
                SanPham temp = db.DBO.SanPhams.Single(d => d.maSP.Equals(obj.MaSP));
                temp.tenSP = obj.TenSP;
                temp.HSD = obj.HSD;
                temp.donGia = obj.DonGia;
                temp.soLuongConLai = obj.SoLuongConLai;
                temp.maLoai = obj.MaLoai;
                temp.maNSX = obj.MaNSX;

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
        /// Sửa số lượng còn lại của 1 sản phẩm
        /// </summary>
        /// <param name="maSP"></param>
        /// <param name="soLuong"></param>
        /// <returns></returns>
        public bool Sua(string maSP, int soLuong)
        {
            bool result = false;
            try
            {
                SanPham temp = db.DBO.SanPhams.Single(d => d.maSP.Equals(maSP));
                temp.soLuongConLai = soLuong;

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
        /// Thêm Sản phẩm mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(SanPham_DTO obj)
        {
            bool result = false;
            try
            {
                SanPham temp = new SanPham()
                {
                    maSP = obj.MaSP,
                    tenSP = obj.TenSP,
                    HSD = obj.HSD,
                    donGia = obj.DonGia,
                    soLuongConLai = obj.SoLuongConLai,
                    maLoai = obj.MaLoai,
                    maNSX = obj.MaNSX,
                };

                db.DBO.SanPhams.InsertOnSubmit(temp);
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
        /// Xóa thông tin của 1 sản phẩm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                SanPham temp = db.DBO.SanPhams.Single(d => d.maSP.Equals(obj));

                db.DBO.SanPhams.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
