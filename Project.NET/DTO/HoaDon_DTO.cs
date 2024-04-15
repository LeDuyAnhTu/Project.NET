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
    public class HoaDon_DTO
    {
        private string maHD;
        private DateTime ngayLap;
        private string maNV, maKH;
        private int diemDung, thanhTien;

        public HoaDon_DTO(string maHD, DateTime ngayLap, string maNV, string maKH, int diemDung, int thanhTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            MaNV = maNV;
            MaKH = maKH;
            DiemDung = diemDung;
            ThanhTien = thanhTien;
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


        public DateTime NgayLap
        {
            get => ngayLap;
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
                ngayLap = value;
            }
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


        public int DiemDung
        {
            get => diemDung;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Điểm dùng không thể nhỏ hơn 0!");
                }
                diemDung = value;
            }
        }


        public int ThanhTien
        {
            get => thanhTien;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Thành tiền không thể nhỏ hơn 0!");
                }
                thanhTien = value;
            }
        }

    }
}
