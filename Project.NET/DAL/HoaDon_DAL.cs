using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDon_DAL : BasicMethod<HoaDon_DTO>
    {
        /// <summary>
        /// Lấy danh sách hóa đơn
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from hd in db.DBO.HoaDons
                     select hd;
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        /// <summary>
        /// Sửa thông tin hóa đơn
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(HoaDon_DTO obj)
        {
            bool result = false;
            try
            {
                HoaDon temp = db.DBO.HoaDons.Single(d => d.maHD == obj.MaHD);
                temp.maHD = obj.MaHD;
                temp.ngayLap = obj.NgayLap;
                temp.maNV = obj.MaNV;
                temp.maKH = obj.MaKH;
                temp.diemDung = obj.DiemDung;
                temp.thanhTien = obj.ThanhTien;

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
        /// Thêm hóa đơn mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(HoaDon_DTO obj)
        {
            bool result = false;
            try
            {
                HoaDon temp = new HoaDon()
                {
                    maHD=  obj.MaHD,
                    ngayLap = obj.NgayLap,
                    maNV = obj.MaNV,
                    maKH = obj.MaKH,
                    diemDung = obj.DiemDung,
                    thanhTien = obj.ThanhTien,
                };

                db.DBO.HoaDons.InsertOnSubmit(temp);
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
        /// Xóa thông tin của 1 hóa đơn theo mã hd
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                HoaDon temp = db.DBO.HoaDons.Single(d => d.maHD == obj);

                db.DBO.HoaDons.DeleteOnSubmit(temp);
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
