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

        public string MaLoai
        {
            get => maLoai; set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã loại sản phẩm tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã loại sản phẩm !");
                }
                else
                {
                    maLoai = value;
                }
            }
        }
        public string TenLoai
        {
            get => tenLoai; set
            {
                if (value != null && value.Length > 30)
                {
                    throw new Exception("Tên loại sản phẩm tối đa 30 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập Tên loại sản phẩm !");
                }
                else
                {
                    tenLoai = value;
                }
            }
        }
    }
}
