using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiNhanh_DAL : BasicMethod<ChiNhanh_DTO>
    {
        /// <summary>
        /// Lấy danh sách các chi nhánh
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from cn in db.DBO.ChiNhanhs
                                select new
                                {
                                    cn.maCN,
                                    cn.tenCN
                                };
                return ds;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Sửa thông tin của 1 chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ChiNhanh_DTO obj)
        {
            try
            {
                bool result = false;

                ChiNhanh temp = db.DBO.ChiNhanhs.Single(d => d.maCN == obj.MaCN);
                temp.tenCN = obj.TenCN;
                temp.diaChi = obj.DiaChi;
                temp.maKV = obj.MaKV;
                temp.maQL = obj.MaQL;

                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm chi nhánh mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(ChiNhanh_DTO obj)
        {
            try
            {
                bool result = false;

                ChiNhanh temp = new ChiNhanh()
                {
                    maCN = obj.MaCN,
                    tenCN = obj.TenCN,
                    diaChi = obj.DiaChi,
                    maKV = obj.MaKV,
                    maQL = obj.MaQL,
                };

                db.DBO.ChiNhanhs.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Xóa thông tin của 1 chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            try
            {
                bool result = false;

                ChiNhanh temp = db.DBO.ChiNhanhs.Single(d=>d.maCN == obj);

                db.DBO.ChiNhanhs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
