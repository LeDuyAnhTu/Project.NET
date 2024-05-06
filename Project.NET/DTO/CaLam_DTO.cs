/*
 * Date: 14/04/2024
 * Author: Lê Duy Anh Tú
 * Missing: bắt lỗi giờ bắt đầu và giờ kết thúc ca
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLam_DTO
    {
        private string maCa, tenCa, gioBD, gioKT;
        
        public CaLam_DTO(string maCa, string tenCa, string gioBD, string gioKT)
        {
            MaCa = maCa;
            TenCa = tenCa;
            GioBD = gioBD;
            GioKT = gioKT;
        }

        public string MaCa
        {
            get => maCa;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã ca tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã ca !");
                }
                else
                {
                    maCa = value;
                }
            }
        }
        public string TenCa
        {
            get => tenCa;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Tên ca tối đa 30 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập tên ca !");
                }
                else
                {
                    tenCa = value;
                }
            }
        }
        public string GioBD
        {
            get => gioBD;
            set
            {
                if (value != null)
                {
                    gioBD = value;
                }
                else
                {
                    throw new Exception("Vui lòng chọn giờ vào ca");
                }
            }
        }
        public string GioKT
        {
            get => gioKT;
            set
            {
                if (value != null)
                {
                    gioKT = value;
                }
                else
                {
                    throw new Exception("Vui lòng chọn giờ tan ca");
                }
            }
        }

    }
}
