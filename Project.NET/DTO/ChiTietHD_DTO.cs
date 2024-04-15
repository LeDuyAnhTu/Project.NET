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
    public class ChiTietHD_DTO
    {
        private string maHD, maSP;
        private int soLuong;

        public ChiTietHD_DTO(string maHD, string maSP, int soLuong)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
        }


        public string MaHD
        {
            get => maHD;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã HD tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã HD !");
                }
                else
                {
                    maHD = value;
                }
            }
        }


        public string MaSP
        {
            get => maSP;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã SP tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã SP !");
                }
                else
                {
                    maSP = value;
                }
            }
        }


        public int SoLuong
        {
            get => soLuong;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Số lượng không thể nhỏ hơn 0!");
                }
                soLuong = value;
            }
        }

    }
}
