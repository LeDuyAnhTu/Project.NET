using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuVuc_DAL : BasicMethod<KhuVuc_DTO>
    {
        /// <summary>
        /// Lấy danh sách các khu vực
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from kv in db.DBO.KhuVucs
                     select kv;
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin của 1 khu vực
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(KhuVuc_DTO obj)
        {
            bool result = false;

            try
            {
                KhuVuc temp = db.DBO.KhuVucs.Single(d => d.maKV == obj.MaKV);
                temp.tenKV = obj.TenKV;
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
        /// Thêm khu vực mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(KhuVuc_DTO obj)
        {
            bool result = false;

            try
            {
                KhuVuc temp = new KhuVuc()
                {
                    maKV = obj.MaKV,
                    tenKV = obj.TenKV,
                };
                db.DBO.KhuVucs.InsertOnSubmit(temp);
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
        /// Xóa 1 khu vực khỏi hệ thống
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;

            try
            {
                KhuVuc temp = db.DBO.KhuVucs.Single(d => d.maKV == obj);
                db.DBO.KhuVucs.DeleteOnSubmit(temp);
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
