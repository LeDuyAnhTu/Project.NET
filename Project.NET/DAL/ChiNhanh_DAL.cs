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
        public override IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from cn in db.DBO.ChiNhanhs
                                select cn;
                return ds;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

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
