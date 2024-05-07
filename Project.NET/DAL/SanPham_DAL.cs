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
                         ĐơnGiá = sp.donGia,
                         TồnKho = sp.soLuongConLai,
                         NSX = nsx.tenNSX,
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public IQueryable LayDanhSach_TheoLoai(string maLoai)
        {
            IQueryable ds = null;
            try
            {
                ds = from sp in db.DBO.SanPhams
                     join lsp in db.DBO.LoaiSPs on sp.maLoai equals lsp.maLoai
                     join nsx in db.DBO.NhaSanXuats on sp.maNSX equals nsx.maNSX
                     where sp.maLoai.Equals(maLoai)
                     select new
                     {
                         MãSố = sp.maSP,
                         TênSảnPhẩm = sp.tenSP,
                         Loại = lsp.tenLoai,
                         ĐơnGiá = sp.donGia,
                         TồnKho = sp.soLuongConLai,
                         NSX = nsx.tenNSX,
                     };
            }
            catch (Exception ex)
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
        /// <summary>
        /// Tạo mã sản phẩm mới nối tiếp mã sản phẩm cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                //Lấy mã sản phẩm cuối
                IQueryable ds = (from sp in db.DBO.SanPhams
                                 orderby sp.maSP descending
                                 select sp.maSP).Take(1);
                string maSP = "";
                foreach (var item in ds)
                {
                    maSP = item.ToString();
                }

                //Lấy số tiếp theo maSP cuối
                string maSo = maSP.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã NV mới
                maSP = "SP" + String.Format("{0:D8}", soMoi);

                return maSP;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "SP00000001";
            }
        }
        /// <summary>
        /// Tìm sản phẩm theo mã sản phẩm
        /// </summary>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public SanPham_DTO timSanPham_MaSP(string maSP)
        {
            try
            {
                SanPham temp = db.DBO.SanPhams.Single(d => d.maSP.Equals(maSP));
                return new SanPham_DTO(temp.maSP, temp.tenSP, temp.HSD, temp.donGia, temp.soLuongConLai, temp.maLoai, temp.maNSX);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
