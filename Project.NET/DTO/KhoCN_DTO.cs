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
    public class KhoCN_DTO
    {
        private string maCN, maSP;
        private int soLuong;

        public KhoCN_DTO(string maCN, string maSP, int soLuong)
        {
            MaCN = maCN;
            MaSP = maSP;
            SoLuong = soLuong;
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
                if(string.IsNullOrEmpty(value.ToString()))
                {
                    throw new Exception("Vui lòng nhập số lượng");
                }
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Số lượng không thể nhỏ hơn 0!");
                }
                soLuong = value;
            }
        }

    }
}
