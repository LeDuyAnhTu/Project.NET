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


        public string MaKM
        {
            get => maKM;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã KM tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã KM !");
                }
                else
                {
                    maKM = value;
                }
            }
        }


        public string GhiChu
        {
            get => ghiChu;
            set
            {
                if (value != null && value.Length > 250)
                {
                    throw new Exception("Ghi chú tối đa 250 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập ghi chú !");
                }
                else
                {
                    ghiChu = value;
                }
            }
        }

    }
}
