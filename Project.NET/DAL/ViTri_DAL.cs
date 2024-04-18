using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ViTri_DAL : BasicMethod<ViTri_DTO>
    {
        /// <summary>
        /// Lấy danh sách các vị trí
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from qtc in db.DBO.ViTris
                     select qtc;
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa tên vị trí
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ViTri_DTO obj)
        {
            bool result = false;
            try
            {
                ViTri temp = db.DBO.ViTris.Single(d => d.maVT.Equals(obj.MaVT));
                temp.tenVT = obj.TenVT;

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
        /// Thêm vị trí mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(ViTri_DTO obj)
        {
            bool result = false;
            try
            {
                ViTri temp = new ViTri()
                {
                    maVT = obj.MaVT,
                    tenVT = obj.TenVT,
                };

                db.DBO.ViTris.InsertOnSubmit(temp);
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
        /// Xóa 1 vị trí
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                ViTri temp = db.DBO.ViTris.Single(d => d.maVT.Equals(obj));
                db.DBO.ViTris.DeleteOnSubmit(temp);
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
