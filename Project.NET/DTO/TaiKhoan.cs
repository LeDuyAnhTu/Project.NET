/*
 * Date: 14/04/2024
 * Author: Lê Duy Anh Tú
 * Missing: Bắt lỗi
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string tenTK, matKhau, maNV, maQTC;

        public TaiKhoan(string tenTK, string matKhau, string maNV, string maQTC)
        {
            TenTK = tenTK;
            MatKhau = matKhau;
            MaNV = maNV;
            MaQTC = maQTC;
        }

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { 
            get => matKhau; 
            set
            {
                if (value == null)
                {
                    matKhau = string.Empty;
                }
                else
                {
                    // Lấy hashCode loại SHA256 của mật khẩu
                    byte[] buffer = Encoding.UTF8.GetBytes(value);
                    byte[] hash = SHA256.Create().ComputeHash(buffer);
                    matKhau = BitConverter.ToString(hash);
                }
            }
        }
        public string MaNV { get => maNV;
            set
            {
                maNV = value;
            }
        }
        public string MaQTC { get => maQTC; set => maQTC = value; }
    }
}
