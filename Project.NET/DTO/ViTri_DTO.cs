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
    public class ViTri_DTO
    {
        //Properties
        private string maVT, tenVT;

        //Constructor
        public ViTri_DTO(string maVT, string tenVT)
        {
            MaVT = maVT;
            TenVT = tenVT;
        }

        //Getters & Setters
        public string MaVT
        {
            get => maVT; set
            {
                if (value != null && value.Length > 10)
                {
                    throw new Exception("Mã vị trí tối đa 10 ký tự !");
                }
                else if (value == null)
                {
                    throw new Exception("Vui lòng nhập mã vị trí !");
                }
                else
                {
                    maVT = value;
                }
            }
        }
        public string TenVT
        {
            get => tenVT; set
            {
                if (value != string.Empty && value.Length > 30)
                {
                    throw new Exception("Tên vị trí không được dài quá 30 ký tự !");
                }
                else if (value == string.Empty)
                {
                    throw new Exception("Vui lòng nhập tên vị trí !");
                }
                else
                {
                    tenVT = value;
                }
            }
        }
    }
}
