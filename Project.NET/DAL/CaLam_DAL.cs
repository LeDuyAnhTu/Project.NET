/*
 * Date: 14/04/2024
 * Author: Lê Duy Anh Tú
 * Missing: Bắt lỗi 
 */
using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLam_DAL : BasicMethod<CaLam_DTO>
    {
        /// <summary>
        /// Lấy danh sách ca làm
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from cl in db.DBO.CaLams
                                select new
                                {
                                    cl.maCa,
                                    cl.tenCa,
                                    cl.gioBD,
                                    cl.gioKT
                                };
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Sửa thông tin ca làm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(CaLam_DTO obj)
        {
            try
            {
                bool flg = false;
                CaLam temp = db.DBO.CaLams.Single(d => d.maCa == obj.MaCa);
                temp.tenCa = obj.TenCa;
                temp.gioBD = obj.GioBD;
                temp.gioKT = obj.GioKT;

                db.DBO.SubmitChanges();

                flg = true;
                return flg;

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("contains no elements"))
                {
                    throw new Exception("Ca làm " + obj.MaCa + " không có trong hệ thống");
                }
                else if (ex.Message.Contains("UNIQUE"))
                {
                    throw new Exception("Ca làm " + obj.MaCa + " có giờ làm trùng với ca làm khác trong danh sách");
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Thêm ca làm mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(CaLam_DTO obj)
        {
            try
            {
                bool flg = false;

                CaLam temp = new CaLam()
                {
                    maCa = obj.MaCa,
                    tenCa = obj.TenCa,
                    gioBD = obj.GioBD,
                    gioKT = obj.GioKT,
                };

                db.DBO.CaLams.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();

                flg = true;
                return flg;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY"))
                {
                    throw new Exception("Đã có ca làm mã " + obj.MaCa.Trim() + " trong danh sách");
                }
                else
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// Xóa thông tin ca làm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            try
            {
                bool flg = false;
                CaLam temp = db.DBO.CaLams.Single(d => d.maCa == obj);

                db.DBO.CaLams.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();

                flg = true;
                return flg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tạo mã ca mới nối tiếp mã ca cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                //Lấy mã nhân viên cuối
                IQueryable ds = (from cl in db.DBO.CaLams
                                 orderby cl.maCa descending
                                 select cl.maCa).Take(1);
                string maCa = "";
                foreach (var item in ds)
                {
                    maCa = item.ToString();
                }

                //Lấy số tiếp theo msNV cuối
                string maSo = maCa.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã NV mới
                maCa = "CL" + String.Format("{0:D2}", soMoi);

                return maCa;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "CL01";
            }
        }
        /// <summary>
        /// Lấy giờ bắt đầu và kết thúc ca theo mã ca
        /// </summary>
        /// <param name="maCa"></param>
        /// <returns></returns>
        public string[] gioLamViec(string maCa)
        {
            string[] ds = new string[2];
            try
            {
                var caLam = (from cl in db.DBO.CaLams
                             where cl.maCa.Equals(maCa)
                             select new
                             {
                                 cl.maCa,
                                 cl.tenCa,
                                 cl.gioBD,
                                 cl.gioKT
                             }).ToList();
                foreach(var item in caLam)
                {
                    ds[0] = item.gioBD;
                    ds[1] = item.gioKT;
                }
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
