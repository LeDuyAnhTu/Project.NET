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
                ds = from vt in db.DBO.ViTris
                     where vt.maVT != "VT00"
                     select new
                     {
                         vt.maVT,
                         vt.tenVT
                     };
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
        /// <summary>
        /// Tìm vị trí làm việc trong hệ thống theo mã vị trí
        /// </summary>
        /// <param name="maVT"></param>
        /// <returns></returns>
        public ViTri_DTO timTheoMa(string maVT)
        {
            try
            {
                ViTri vt = db.DBO.ViTris.Single(d=>d.maVT.Equals(maVT));
                return new ViTri_DTO(vt.maVT, vt.tenVT);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
