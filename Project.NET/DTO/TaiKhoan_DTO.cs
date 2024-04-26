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
    public class TaiKhoan_DTO
    {
        private string tenTK, matKhau, maNV;

        public TaiKhoan_DTO(string tenTK, string matKhau, string maNV)
        {
            TenTK = tenTK;
            MatKhau = matKhau;
            MaNV = maNV;
        }

       
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
        public string TenTK
        {
            get => tenTK;
            set
            {
                if (value == null)
                {
                    throw new Exception("Vui lòng nhập tên TK !");
                }
                else
                {
                    tenTK = value;
                }
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

    }
}
