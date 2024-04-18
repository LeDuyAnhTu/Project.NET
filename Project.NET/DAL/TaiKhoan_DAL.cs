using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoan_DAL : BasicMethod<TaiKhoan_DTO>
    {
        /// <summary>
        /// Lấy danh sách tài khoản
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from tk in db.DBO.TaiKhoans
                     select tk;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin tài khoản
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(TaiKhoan_DTO obj)
        {
            bool result = false;
            try
            {
                TaiKhoan temp = db.DBO.TaiKhoans.Single(d => d.tenTK.Equals(obj.TenTK));
                temp.matKhau = obj.MatKhau;
                temp.maNV = obj.MaNV;

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
        /// Thêm tài khoản mới 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(TaiKhoan_DTO obj)
        {
            bool result = false;
            try
            {
                TaiKhoan temp = new TaiKhoan()
                {
                    tenTK = obj.TenTK,
                    maNV = obj.MaNV,
                    matKhau = obj.MatKhau,
                };

                db.DBO.TaiKhoans.InsertOnSubmit(temp);
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
        /// Xóa tài khoản 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                TaiKhoan temp = db.DBO.TaiKhoans.Single(d => d.tenTK.Equals(obj));

                db.DBO.TaiKhoans.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public TaiKhoan TimTaiKhoan_MaNV(string maNV)
        {
            try
            {
                return db.DBO.TaiKhoans.Single(d=>d.maNV.Equals(maNV));
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
