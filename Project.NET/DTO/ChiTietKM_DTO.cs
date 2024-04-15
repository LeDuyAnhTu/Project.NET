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
    public class ChiTietKM_DTO
    {
        private string maKM, maSP;
        private int soLuong;

        public ChiTietKM_DTO(string maKM, string maSP, int soLuong)
        {
            MaKM = maKM;
            MaSP = maSP;
            SoLuong = soLuong;
        }

        public string MaKM
        {
            get => maKM; set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã KM tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã KM !");
                }
                else
                {
                    maKM = value;
                }
            }
        }
        public string MaSP
        {
            get => maSP; set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã maSP tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã maSP !");
                }
                else
                {
                    maSP = value;
                }
            }
        }
        public int SoLuong
        {
            get => soLuong; set
            {
                if (value < 0)
                {
                    throw new Exception("Số lượng không thể âm!");
                }
                else if (value > 999)
                {
                    throw new Exception("Số lượng giới hạn 999");
                }
                soLuong = value;
            }
        }
    }
}
