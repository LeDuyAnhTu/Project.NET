using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaSanXuat_DAL : BasicMethod<NhaSanXuat_DTO>
    {
        /// <summary>
        /// Lấy danh sách các nhà sản xuất
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from nsx in db.DBO.NhaSanXuats
                     select nsx;
            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        public IQueryable LayDanhSach_Combobox()
        {
            IQueryable ds = null;
            try
            {
                ds = from nsx in db.DBO.NhaSanXuats
                     select new
                     {
                         MãSố = nsx.maNSX,
                         Tên = nsx.tenNSX,
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin của 1 nhà sản xuất
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(NhaSanXuat_DTO obj)
        {
            bool re = false;
            try
            {
                NhaSanXuat temp = db.DBO.NhaSanXuats.Single(d=>d.maNSX==obj.MaNSX);
                temp.tenNSX = obj.TenNSX;
                temp.SDTNSX = obj.SDTNSX;
                temp.diaChi = obj.DiaChi;
                db.DBO.SubmitChanges();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }
        /// <summary>
        /// Thêm nhà sản xuất mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(NhaSanXuat_DTO obj)
        {
            bool re = false;
            try
            {
                NhaSanXuat temp = new NhaSanXuat()
                {
                    maNSX = obj.MaNSX,
                    tenNSX = obj.TenNSX,
                    SDTNSX = obj.SDTNSX,
                    diaChi = obj.DiaChi,
                };
                db.DBO.NhaSanXuats.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }
        /// <summary>
        /// Xóa 1 nhà sản xuất khỏi hệ thống
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool re = false;
            try
            {
                NhaSanXuat temp = db.DBO.NhaSanXuats.Single(d => d.maNSX == obj);
                db.DBO.NhaSanXuats.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();
                re = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return re;
        }
    }
}
