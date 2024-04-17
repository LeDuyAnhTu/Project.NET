using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMai_DAL : BasicMethod<KhuyenMai_DTO>
    {
        /// <summary>
        /// Lấy danh sách các loại khuyến mãi
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from km in db.DBO.KhuyenMais
                     select km;
            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin khuyến mãi
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(KhuyenMai_DTO obj)
        {
            bool result = false;
            try
            {
                KhuyenMai temp = db.DBO.KhuyenMais.Single(d => d.maKM == obj.MaKM);
                temp.ghiChu = obj.GhiChu;
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
        /// Thêm khuyến mãi mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(KhuyenMai_DTO obj)
        {
            bool result = false;
            try
            {
                KhuyenMai temp = new KhuyenMai()
                {
                    maKM = obj.MaKM,
                    ghiChu = obj.GhiChu,
                };
                db.DBO.KhuyenMais.InsertOnSubmit(temp);
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
        /// Xóa 1 khuyến mãi
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                KhuyenMai temp = db.DBO.KhuyenMais.Single(d => d.maKM == obj);
                db.DBO.KhuyenMais.DeleteOnSubmit(temp);
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
