using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuyenTruyCap_DAL : BasicMethod<QuyenTruyCap_DTO>
    {
        /// <summary>
        /// Lấy danh sách các quyền truy cập
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from qtc in db.DBO.QuyenTruyCaps
                     select qtc;
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa tên quyền truy cập
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(QuyenTruyCap_DTO obj)
        {
            bool result = false;
            try
            {
                QuyenTruyCap temp = db.DBO.QuyenTruyCaps.Single(d => d.maQTC.Equals(obj.MaQTC));
                temp.tenQTC = obj.TenQTC;

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
        /// Thêm quyền truy cập mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(QuyenTruyCap_DTO obj)
        {
            bool result = false;
            try
            {
                QuyenTruyCap temp = new QuyenTruyCap()
                {
                    maQTC = obj.MaQTC,
                    tenQTC = obj.TenQTC,
                };

                db.DBO.QuyenTruyCaps.InsertOnSubmit(temp);
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
        /// Xóa 1 quyền truy cập
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                QuyenTruyCap temp = db.DBO.QuyenTruyCaps.Single(d => d.maQTC.Equals(obj));
                db.DBO.QuyenTruyCaps.DeleteOnSubmit(temp);
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
