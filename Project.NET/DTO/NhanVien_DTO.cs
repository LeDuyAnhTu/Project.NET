using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string maNV, tenNV, gioiTinh;
        private DateTime ngaySinh;
        private string soDT, cCCD;
        private int luong;
        private string maVT, maCN;

        public NhanVien_DTO(string maNV, string tenNV, string gioiTinh, DateTime ngaySinh, string sDT, string cCCD, int luong, string maVT, string maCN)
        {
            MaNV = maNV;
            TenNV = tenNV;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            CCCD = cCCD;
            Luong = luong;
            MaCN = maCN;
            MaVT = maVT;
        }

        public string MaNV
        {
            get => maNV;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã NV tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã NV !");
                }
                else
                {
                    maNV = value;
                }
            }
        }


        public string TenNV
        {
            get => tenNV;
            set
            {
                if (value != null && value.Length > 30)
                {
                    throw new Exception("Tên NV tối đa 30 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập tên NV !");
                }
                else
                {
                    tenNV = value;
                }
            }
        }


        public string GioiTinh
        {
            get => gioiTinh;
            set
            {
                if (value != null && value.Length != 3)
                {
                    throw new Exception("Giới tính phải có 3 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập giới tính !");
                }
                else
                {
                    gioiTinh = value;
                }
            }
        }


        public DateTime NgaySinh
        {
            get => ngaySinh;
            set
            {
                try
                {
                    // Kiểm tra xem giá trị có phải là ngày tháng hợp lệ không
                    if (value.Year < 1 || value.Year > 9999)
                        throw new ArgumentOutOfRangeException("Năm không hợp lệ!");
                    else if (value.Month < 1 || value.Month > 12)
                        throw new ArgumentOutOfRangeException("Tháng không hợp lệ!");
                    else if (value.Day < 1 || value.Day > 31)
                        throw new ArgumentOutOfRangeException("Ngày không hợp lệ!");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                ngaySinh = value;
            }
        }


        public string SDT
        {
            get => soDT;
            set
            {
                if (value != null && value.Length != 10)
                {
                    throw new Exception("SDT phải có 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập SDT !");
                }
                else
                {
                    soDT = value;
                }
            }
        }


        public string CCCD
        {
            get => cCCD;
            set
            {
                if (value != null && value.Length != 11)
                {
                    throw new Exception("CCCD phải có 11 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập CCCD !");
                }
                else
                {
                    cCCD = value;
                }
            }
        }


        public int Luong
        {
            get => luong;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Lương không thể nhỏ hơn 0!");
                }
                luong = value;
            }
        }


        public string MaCN
        {
            get => maCN;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã CN tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã CN !");
                }
                else
                {
                    maCN = value;
                }
            }
        }

        public string MaVT { get => maVT; set => maVT = value; }
    }
}
