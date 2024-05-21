using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiNhanh_DTO
    {
        private string maCN, tenCN, diaChi, maKV, maQL;

        public ChiNhanh_DTO(string maCN, string tenCN, string diaChi, string maKV, string maQL)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChi = diaChi;
            MaKV = maKV;
            MaQL = maQL;
        }

        public string MaCN
        {
            get => maCN; 
            set
            {
                maCN = value;
            }
        }
        public string TenCN
        {
            get => tenCN; 
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Vui lòng nhập tên chi nhánh");
                }
                tenCN = value;
            }
        }
        public string DiaChi
        {
            get => diaChi; 
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Vui lòng nhập tên địa chỉ");
                }
                diaChi = value;
            }
        }
        public string MaKV
        {
            get => maKV; 
            set
            {
                maKV = value;
            }
        }
        public string MaQL
        {
            get => maQL; 
            set
            {
                maQL = value;
            }
        }
    }
}
