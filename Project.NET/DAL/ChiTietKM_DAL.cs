using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietKM_DAL : BasicMethod<ChiTietKM_DTO>
    {
        /// <summary>
        /// Lấy danh sách chi tiết khuyến mãi
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from ct in db.DBO.ChiTietKMs
                     select ct;
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }

        /// <summary>
        /// Sửa số lượng sản phẩm được khuyến mãi
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ChiTietKM_DTO obj)
        {
            bool result = false;
            try
            {
                ChiTietKM temp = db.DBO.ChiTietKMs.Single(d => d.maKM == obj.MaKM && d.maSP==obj.MaSP);
                temp.soLuong = obj.SoLuong;

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
        /// Thêm chi tiết khuyến mãi mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(ChiTietKM_DTO obj)
        {
            bool result = false;
            try
            {
                ChiTietKM temp = new ChiTietKM()
                {
                    maKM = obj.MaKM,
                    maSP = obj.MaSP,
                    soLuong = obj.SoLuong,
                };
                db.DBO.ChiTietKMs.InsertOnSubmit(temp);
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
        /// Xóa chi tiết khuyến mãi đối với mọi sản phẩm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string maKM)
        {
            bool result = false;
            try
            {
                ChiTietKM temp = db.DBO.ChiTietKMs.Single(d => d.maKM == maKM);

                db.DBO.ChiTietKMs.DeleteOnSubmit(temp);
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
        /// Xóa chi tiết khuyến mãi đối với 1 sản phẩm
        /// </summary>
        /// <param name="maKM"></param>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public bool Xoa(string maKM, string maSP)
        {
            bool result = false;
            try
            {
                ChiTietKM temp = db.DBO.ChiTietKMs.Single(d => d.maKM == maKM && d.maSP == maSP);

                db.DBO.ChiTietKMs.DeleteOnSubmit(temp);
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
