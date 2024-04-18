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
    public class ViTri_DTO
    {
        private string maVT, tenVT;

        public ViTri_DTO(string maVT, string tenVT)
        {
            MaVT = maVT;
            TenVT = tenVT;
        }

        public string MaVT
        {
            get => maVT; set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã QTC tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã QTC !");
                }
                else
                {
                    maVT = value;
                }
            }
        }
        public string TenVT
        {
            get => tenVT; set
            {
                if (value != null && value.Length > 30)
                {
                    throw new Exception("Tên QTC tối đa 30 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập Tên QTC !");
                }
                else
                {
                    tenVT = value;
                }
            }
        }
    }
}
