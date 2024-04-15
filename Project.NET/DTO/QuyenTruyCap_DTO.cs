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
    public class QuyenTruyCap_DTO
    {
        private string maQTC, tenQTC;

        public QuyenTruyCap_DTO(string maQTC, string tenQTC)
        {
            MaQTC = maQTC;
            TenQTC = tenQTC;
        }

        public string MaQTC
        {
            get => maQTC; set
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
                    maQTC = value;
                }
            }
        }
        public string TenQTC
        {
            get => tenQTC; set
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
                    tenQTC = value;
                }
            }
        }
    }
}
