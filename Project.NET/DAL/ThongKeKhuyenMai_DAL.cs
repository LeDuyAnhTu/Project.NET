using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeKhuyenMai_DAL : BasicMethod<ThongKeKhuyenMai_DTO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ThongKeKhuyenMai_DTO> LayDanhSachThongKeKM()
        {
            var thongke = from ctkm in db.DBO.ChiTietKMs
                          join sp in db.DBO.SanPhams on ctkm.maSP equals sp.maSP
                          group ctkm by ctkm.maSP into g
                          select new ThongKeKhuyenMai_DTO
                          {
                              MaSP = g.Key,
                              SoLuongKM = g.Count(),
                              SoLuongConLaiSauKM = db.DBO.SanPhams.Single(sp => sp.maSP == g.Key).soLuongConLai - g.Sum(ctkm => ctkm.soLuong)
                          };
            return thongke.ToList();
        }
        /// <summary>
        /// Thực hiện thao tác lấy số lượng còn lại của sản phẩm dựa trên mã sản phẩm
        /// </summary>
        /// <param name="maSP">Nếu không tìm thấy sản phẩm, trả về 0</param>
        /// <returns>Trả về số lượng còn lại của sản phẩm</returns>
        public int LaySoLuongConLai(string maSP)
        {
            int soluongconlai = 0;
            try
            {
                // Lấy sản phẩm từ bảng SanPham dựa trên maSP
                var sanpham = from sp in db.DBO.SanPhams
                              where sp.maSP == maSP
                              select sp;
                if (sanpham != null)
                {
                    foreach (var item in sanpham)
                    {
                        soluongconlai = item.soLuongConLai;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return soluongconlai;// Nếu không tìm thấy sản phẩm, trả về 0
        }

        /// <summary>
        /// Thực hiện thao tác mua hàng
        /// </summary>
        /// <param name="maSP">Nếu tìm thấy sản phẩm</param>
        /// <param name="soLuongMua"> và số lượng mua nhỏ hơn hoặc bằng số lượng còn lại</param>
        /// <exception cref="Exception">Nếu không tìm thấy sản phẩm hoặc số lượng mua lớn hơn số lượng còn lại, ném ra một ngoại lệ</exception>
        public void MuaHang(string maSP, int soLuongMua)
        {
            try
            {
                // Lấy sản phẩm từ bảng SanPham dựa trên maSP
                var sanpham = from sp in db.DBO.SanPhams
                              where sp.maSP == maSP// lấy 1 sản phẩm có thể null mã sp
                              select sp;

                if (sanpham != null)
                {
                    foreach (var item in sanpham)
                    {
                        // Nếu tìm thấy sản phẩm và số lượng mua nhỏ hơn hoặc bằng số lượng còn lại

                        if (soLuongMua <= item.soLuongConLai)
                        {
                            // Cập nhật số lượng còn lại của sản phẩm

                            item.soLuongConLai -= soLuongMua;
                            // Lưu thay đổi vào cơ sở dữ liệu

                            db.DBO.SubmitChanges();
                        }
                    }
                }
                else
                {
                    throw new Exception("Sản phẩm không tồn tại hoặc vượt quá số lượng mua");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public override IQueryable LayDanhSach()
        {
            throw new NotImplementedException();
        }
        public override bool Sua(ThongKeKhuyenMai_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Them(ThongKeKhuyenMai_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
