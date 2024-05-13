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
    public class SanPham_DTO
    {
        private string maSP, tenSP;
        private DateTime hSD;
        private int donGia, soLuongConLai;
        private string maLoai, maNSX;

        public SanPham_DTO(string maSP, string tenSP, DateTime hSD, int donGia, int soLuongConLai, string maLoai, string maNSX)
        {
            MaSP = maSP;
            TenSP = tenSP;
            HSD = hSD;
            DonGia = donGia;
            SoLuongConLai = soLuongConLai;
            MaLoai = maLoai;
            MaNSX = maNSX;
        }

        public string MaSP
        {
            get => maSP; set
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
        public string TenSP
        {
            get => tenSP; set
            {
                if (value != null && value.Length > 30)
                {
                    throw new Exception("tenSP tối đa 30 ký tự !");
                }
                else if (value == null || value == "")
                {
                    throw new Exception("Vui lòng nhập tenSP !");
                }
                else
                {
                    tenSP = value;
                }

            }
        }
        public DateTime HSD
        {
            get => hSD; set
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
                hSD = value;
            }
        }

        public int DonGia
        {
            get => donGia;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Đơn giá không thể nhỏ hơn 0!");
                }
                donGia = value;
            }
        }


        public int SoLuongConLai
        {
            get => soLuongConLai;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Số lượng còn lại không thể nhỏ hơn 0!");
                }

                soLuongConLai = value;
            }
        }


        public string MaLoai
        {
            get => maLoai;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã loại sp tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã loại sp !");
                }
                else
                {
                    maLoai = value;
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
                    throw new Exception("Mã nsx tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã nsx !");
                }
                else
                {
                    maNSX = value;
                }
            }
        }

    }
}
