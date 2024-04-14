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
    public class KhuyenMai_DTO
    {
        private string maKM, ghiChu;

        public KhuyenMai_DTO(string maKM, string ghiChu)
        {
            MaKM = maKM;
            GhiChu = ghiChu;
        }

        public string MaKM { get => maKM; set => maKM = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
