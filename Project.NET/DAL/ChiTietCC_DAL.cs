using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietCC_DAL : BasicMethod<ChiTietCC_DTO>
    {
        /// <summary>
        /// Lấy danh sách chi tiết cung cấp
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from ctcc in db.DBO.ChiTietCCs
                                select ctcc;

            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin chi tiết cung cấp
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ChiTietCC_DTO obj)
        {
            bool result = false;
            try
            {
                ChiTietCC temp = db.DBO.ChiTietCCs.Single(d => d.maCC == obj.MaCC);
                temp.maSP = obj.MaSP;
                temp.maNSX = obj.MaNSX;
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
        /// Thêm chi tiết cung cấp mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(ChiTietCC_DTO obj)
        {
            bool result = false;
            try
            {
                ChiTietCC temp = new ChiTietCC()
                {
                    maCC = obj.MaCC,
                    maNSX = obj.MaNSX,
                    maSP = obj.MaSP,
                    soLuong = obj.SoLuong,
                };

                db.DBO.ChiTietCCs.InsertOnSubmit(temp);
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
        /// Xóa thông tin chi tiết cung cấp
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                ChiTietCC temp = db.DBO.ChiTietCCs.Single(d => d.maCC == obj);

                db.DBO.ChiTietCCs.DeleteOnSubmit(temp);
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
