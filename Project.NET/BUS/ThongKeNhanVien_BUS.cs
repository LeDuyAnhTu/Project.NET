using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeNhanVien_BUS
    {
        ThongKeNhanVien_DAL data = new ThongKeNhanVien_DAL();
        public List<ThongKeNhanVien_DTO> ThongKeNhanVienTheoChiNhanh()
        {
            try
            {
                return data.ThongKeNhanVienTheoChiNhanh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
