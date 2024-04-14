using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiNhanh
    {
        private string maCN, tenCN, diaChi, maKV, maQL;

        public ChiNhanh(string maCN, string tenCN, string diaChi, string maKV, string maQL)
        {
            MaCN = maCN;
            TenCN = tenCN;
            DiaChi = diaChi;
            MaKV = maKV;
            MaQL = maQL;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaKV { get => maKV; set => maKV = value; }
        public string MaQL { get => maQL; set => maQL = value; }
    }
}
