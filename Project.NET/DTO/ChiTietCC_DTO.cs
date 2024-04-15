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
    public class ChiTietCC_DTO
    {
        private string maCC, maNSX, maSP;
        private int soLuong;
        private DateTime ngayCC;

        public ChiTietCC_DTO(string maCC, string maNSX, string maSP, int soLuong, DateTime ngayCC)
        {
            MaCC = maCC;
            MaNSX = maNSX;
            MaSP = maSP;
            SoLuong = soLuong;
            NgayCC = ngayCC;
        }


        public string MaCC
        {
            get => maCC;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã CC tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã CC !");
                }
                else
                {
                    maCC = value;
                }
            }
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


        public DateTime NgayCC
        {
            get => ngayCC;
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
                ngayCC = value;
            }
        }

    }
}
