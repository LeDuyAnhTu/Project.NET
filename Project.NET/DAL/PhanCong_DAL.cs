using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
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
                     select pc;
            }catch (Exception ex)
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
                PhanCong temp = db.DBO.PhanCongs.Single(d=>d.maNV == obj.MaNV);
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
    }
}
