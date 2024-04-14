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
    public class LoaiSP_DTO
    {
        private string maLoai, tenLoai;

        public LoaiSP_DTO(string maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
