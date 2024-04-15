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
    public class PhanCong_DTO
    {
        private string maNV , maCa;
        private DateTime ngayDiLam;

        public PhanCong_DTO(string maNV, DateTime ngayDiLam, string maCa)
        {
            MaNV = maNV;
            NgayDiLam = ngayDiLam;
            MaCa = maCa;
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

        public DateTime NgayDiLam
        {
            get => ngayDiLam;
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
                ngayDiLam = value;
            }
        }

        public string MaCa
        {
            get => maCa;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã Ca tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã Ca !");
                }
                else
                {
                    maCa = value;
                }
            }
        }

    }
}
