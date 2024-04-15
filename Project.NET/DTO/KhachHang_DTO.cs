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
    public class KhachHang_DTO
    {
        private string maKH, tenKH, sDT;
        DateTime ngaySinh;
        int diemTichLuy;
        public KhachHang_DTO(string maKH, string tenKH, string sDT, DateTime ngaySinh, int diemTichLuy)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SDT = sDT;
            NgaySinh = ngaySinh;
            DiemTichLuy = diemTichLuy;
        }


        public string MaKH
        {
            get => maKH;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã KH tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã KH !");
                }
                else
                {
                    maKH = value;
                }
            }
        }


        public string TenKH
        {
            get => tenKH;
            set
            {
                if (value != null && value.Length > 30)
                {
                    throw new Exception("Tên KH tối đa 30 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập tên KH !");
                }
                else
                {
                    tenKH = value;
                }
            }
        }


        public string SDT
        {
            get => sDT;
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
                    sDT = value;
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
                    else if (value.Month < 1 || value.Month > 12)
                        throw new ArgumentOutOfRangeException("Ngày không hợp lệ!");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                ngaySinh = value;
            }
        }


        public int DiemTichLuy
        {
            get => diemTichLuy;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Điểm tích lũy không thể âm!");
                }
                diemTichLuy = value;
            }
        }

    }
}
