/*
 * Date: 14/04/2024
 * Author: Lê Duy Anh Tú
 * Missing: Bắt lỗi
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaSanXuat_DTO
    {
        private string maNSX, tenNSX, sDTNSX, diaChi;

        public NhaSanXuat_DTO(string maNSX, string tenNSX, string sDTNSX, string diaChi)
        {
            MaNSX = maNSX;
            TenNSX = tenNSX;
            SDTNSX = sDTNSX;
            DiaChi = diaChi;
        }


        public string MaNSX
        {
            get => maNSX;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã NSX tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã NSX !");
                }
                else
                {
                    maNSX = value;
                }
            }
        }


        public string TenNSX
        {
            get => tenNSX;
            set
            {
                if (value != null && value.Length > 30)
                {
                    throw new Exception("Tên NSX tối đa 30 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập tên NSX !");
                }
                else
                {
                    tenNSX = value;
                }
            }
        }

        public string SDTNSX
        {
            get => sDTNSX;
            set
            {
                if (value != null && value.Length != 10)
                {
                    throw new Exception("SDT NSX phải có 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập SDT NSX !");
                }
                else
                {
                    sDTNSX = value;
                }
            }
        }


        public string DiaChi
        {
            get => diaChi;
            set
            {
                if (value != null && value.Length > 100)
                {
                    throw new Exception("Địa chỉ tối đa 100 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập địa chỉ !");
                }
                else
                {
                    diaChi = value;
                }
            }
        }

    }
}
