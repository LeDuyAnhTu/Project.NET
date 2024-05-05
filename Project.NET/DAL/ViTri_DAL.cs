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
                         MãSố = vt.maVT,
                         TênVịTrí = vt.tenVT
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
        /// <summary>
        /// Tạo mã vị trí mới 
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            string maVT = "VT01";
            try
            {
                //Lấy mã vị trí cuối
                IQueryable ds = (from vt in db.DBO.ViTris
                                 orderby vt.maVT descending
                                 select vt.maVT).Take(1);
                foreach (var item in ds)
                {
                    maVT = item.ToString();
                }

                //Lấy số tiếp theo maVT cuối
                string maSo = maVT.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã vị trí mới
                maVT = "VT" + String.Format("{0:D2}", soMoi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return maVT;
        }
    }
}
