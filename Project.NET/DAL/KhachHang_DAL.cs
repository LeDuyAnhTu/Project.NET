using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHang_DAL : BasicMethod<KhachHang_DTO>
    {
        /// <summary>
        /// Lấy danh sách khách hàng
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from kh in db.DBO.KhachHangs
                     select kh;
            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public IQueryable LayDanHSach_Combobox()
        {
            IQueryable ds = null;
            try
            {
                ds = from kh in db.DBO.KhachHangs
                     select new
                     {
                         Mã = kh.maKH,
                         HọTên = kh.tenKH,
                         SĐT = kh.SDT,
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin khách hàng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(KhachHang_DTO obj)
        {
            bool result = false;
            try
            {
                KhachHang temp = db.DBO.KhachHangs.Single(d => d.maKH == obj.MaKH);
                temp.tenKH = obj.TenKH;
                temp.SDT = obj.SDT;
                temp.ngaySinh = obj.NgaySinh;
                temp.diemTichLuy = obj.DiemTichLuy;

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
        /// Thêm khách hàng mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(KhachHang_DTO obj)
        {
            bool result = false;
            try
            {
                KhachHang temp = new KhachHang()
                {
                    maKH = obj.MaKH,
                    tenKH = obj.TenKH,
                    SDT = obj.SDT,
                    ngaySinh = obj.NgaySinh,
                    diemTichLuy = obj.DiemTichLuy,
                };

                db.DBO.KhachHangs.InsertOnSubmit(temp);
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
        /// Xóa thông tin của 1 khách hàng
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                KhachHang temp = db.DBO.KhachHangs.Single(d => d.maKH == obj);
                db.DBO.KhachHangs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        public KhachHang_DTO timKH_TheoMa(string maKH)
        {
            try{
                KhachHang temp = db.DBO.KhachHangs.Single(d => d.maKH.Equals(maKH));
                return new KhachHang_DTO(temp.maKH, temp.tenKH, temp.SDT, temp.ngaySinh, (int)temp.diemTichLuy);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
