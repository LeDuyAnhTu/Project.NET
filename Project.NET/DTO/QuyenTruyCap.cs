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
    public class QuyenTruyCap
    {
        private string maQTC, tenQTC;

        public QuyenTruyCap(string maQTC, string tenQTC)
        {
            MaQTC = maQTC;
            TenQTC = tenQTC;
        }

        public string MaQTC { get => maQTC; set => maQTC = value; }
        public string TenQTC { get => tenQTC; set => tenQTC = value; }
    }
}
