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
    public class KhuVuc_DTO
    {
        private string maKV, tenKV;

        public KhuVuc_DTO(string maKV, string tenKV)
        {
            MaKV = maKV;
            TenKV = tenKV;
        }

        public string MaKV
        {
            get => maKV;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã KV tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã KV !");
                }
                else
                {
                    maKV = value;
                }
            }
        }
        public string TenKV
        {
            get => tenKV; set
            {
                if (value != null && value.Length > 50)
                {
                    throw new Exception("Tên KV tối đa 50 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập tên KV !");
                }
                else
                {
                    tenKV = value;
                }
            }
        }
    }
}
