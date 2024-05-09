using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeKho_DAL : BasicMethod<ThongKeKho_DTO>
    {
        public List<ThongKeKho_DTO> ThongKeSanPhamTheoLoaiSP_Kho_ChiNhanh(KhoCN khoCN)
        {
            List<ThongKeKho_DTO> list = null;

            try
            {

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

        public override bool Sua(ThongKeKho_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Them(ThongKeKho_DTO obj)
        {
            throw new NotImplementedException();
        }

        public override bool Xoa(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
