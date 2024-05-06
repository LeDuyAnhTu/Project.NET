using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietHD_DAL : BasicMethod<ChiTietHD_DTO>
    {
        /// <summary>
        /// Lấy danh sách chi tiết hóa đơn
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from ct in db.DBO.ChiTietHDs
                     join hd in db.DBO.HoaDons on ct.maHD equals hd.maHD
                     join sp in db.DBO.SanPhams on ct.maSP equals sp.maSP
                     select new
                     {
                         ct.maHD,
                         sp.tenSP,
                         ct.soLuong,
                         ThanhTien = ct.soLuong * sp.donGia,
                     };
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin chi tiết hóa đơn
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ChiTietHD_DTO obj)
        {
            try
            {
                bool result = false;

                ChiTietHD temp = db.DBO.ChiTietHDs.Single(d => d.maHD == obj.MaHD && d.maSP == obj.MaSP);
                temp.soLuong = obj.SoLuong;

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
        /// Thêm chi tiết hóa đơn mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Them(ChiTietHD_DTO obj)
        {
            try
            {
                bool result = false;

                ChiTietHD temp = new ChiTietHD()
                {
                    maHD = obj.MaHD,
                    maSP = obj.MaSP,
                    soLuong = obj.SoLuong,
                };

                db.DBO.ChiTietHDs.InsertOnSubmit(temp);
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
        /// Xóa chi tiết hóa đơn
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Xoa(string obj)
        {
            try
            {
                bool result = false;

                //ChiTietHD temp = db.DBO.ChiTietHDs.Single(d=>d.maHD == obj);
                //db.DBO.ChiTietHDs.DeleteOnSubmit(temp);
                //db.DBO.SubmitChanges();

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
