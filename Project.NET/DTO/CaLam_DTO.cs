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

        public string MaCa { get => maCa;
            set
            {
                if(value != null && value.Length > 10)
                {
                    throw new Exception("Mã ca tối đa 10 ký tự !");
                }else if(value == null)
                {
                    throw new Exception("Vui lòng nhập mã ca !");
                }
                else
                {
                    maCa = value;
                }
            }
        }
        public string TenCa { get => tenCa;
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
        public string GioBD { get => gioBD;
            set
            {
                if(value != null)
                {
                    if(!checkTimeFormat(value))
                    {
                        throw new Exception("Giờ bắt đầu không hợp lệ (ví dụ: 16:00 hoặc 1600) ");
                    }else
                    {
                        gioBD = toTimeFormat(value);
                    }
                }
            }
        }
        public string GioKT { get => gioKT;
            set
            {
                if (value != null)
                {
                    if (!checkTimeFormat(value))
                    {
                        throw new Exception("Giờ bắt đầu không hợp lệ (ví dụ: 16:00 hoặc 1600) ");
                    }
                    else
                    {
                        gioBD = toTimeFormat(value);
                    }
                }
                gioKT = value;
            }
        }

        //Methods
        private bool checkTimeFormat(string time)
        {
            bool isTime = true;
            if(time.Length == 5)
            {
                for(int i = 0; i < time.Length; i++)
                {
                    if(i == 2 )
                    {
                        if(time[i] == ':')
                        {
                            continue;
                        }
                        else
                        {
                            isTime = false;
                            break;
                        }
                    }
                    if (!char.IsDigit(time[i]))
                    {
                        isTime = false;
                        break;
                    }
                }
            }else if(time.Length == 4)
            {
                foreach(char item in time)
                {
                    if(!char.IsDigit(item))
                    {
                        isTime = false;
                        break;
                    }
                }
            }
            else
            {
                isTime = false;
            }
            return isTime;
        }
        private string toTimeFormat(string value)
        {
            if(checkTimeFormat(value))
            {
                if(value.Length == 4)
                {
                    return value.Substring(0, 2) + ":" + value.Substring(2,2);
                }
                return value;
            }
            else
            {
                throw new Exception("Giờ bắt đầu không hợp lệ (ví dụ: 16:00 hoặc 1600) ");
            }
        }
    }
}
