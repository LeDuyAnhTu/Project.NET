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
    public class PhanCong_DTO
    {
        private string maNV , maCa, ngayDiLam;

        public PhanCong_DTO(string maNV, string ngayDiLam, string maCa)
        {
            MaNV = maNV;
            NgayDiLam = ngayDiLam;
            MaCa = maCa;
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

        public string NgayDiLam
        {
            get => ngayDiLam;
            set
            {
                ngayDiLam = value;
            }
        }

        public string MaCa
        {
            get => maCa;
            set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã Ca tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã Ca !");
                }
                else
                {
                    maCa = value;
                }
            }
        }

    }
}
