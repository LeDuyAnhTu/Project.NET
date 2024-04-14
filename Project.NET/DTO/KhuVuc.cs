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
    public class KhuVuc
    {
        private string maKV, tenKV;

        public KhuVuc(string maKV, string tenKV)
        {
            MaKV = maKV;
            TenKV = tenKV;
        }

        public string MaKV { get => maKV;
            set
            {
                if(value != null &&  value.Length > 10)
                {

                }
                maKV = value;
            }
        }
        public string TenKV { get => tenKV; set => tenKV = value; }
    }
}
