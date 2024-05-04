using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeNhanVien_DAL : BasicMethod<ThongKeNhanVien_DTO>
    {


        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoChiNhanh()
        {
            List<ThongKeNhanVien_DTO> list = null;
            try
            {
                var ds = from nv in db.DBO.NhanViens
                         group nv by nv.maCN into g
                         join vt in db.DBO.ChiNhanhs on g.Key equals vt.maCN
                         select new ThongKeNhanVien_DTO { TenCN = vt.tenCN, SoLuongNV = g.Count() };

                list = ds.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }


        public override IQueryable LayDanhSach()
        {
            throw new NotImplementedException();
        }

        public override bool Sua(ThongKeNhanVien_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Them(ThongKeNhanVien_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
