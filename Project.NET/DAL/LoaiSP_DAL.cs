using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSP_DAL : BasicMethod<LoaiSP_DTO>
    {
        /// <summary>
        /// Lấy danh sách các loại sản phẩm
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from loai in db.DBO.LoaiSPs
                     select new
                     {
                         loai.maLoai,
                         loai.tenLoai,
                     };
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin của 1 loại sản phẩm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(LoaiSP_DTO obj)
        {
            bool result = false;
            try
            {
                LoaiSP temp = db.DBO.LoaiSPs.Single(d => d.maLoai == obj.MaLoai);
                temp.tenLoai = obj.TenLoai;
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Thêm loại sản phẩm mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(LoaiSP_DTO obj)
        {
            bool result = false;
            try
            {
                LoaiSP temp = new LoaiSP()
                {
                    maLoai = obj.MaLoai,
                    tenLoai = obj.TenLoai,
                };
                db.DBO.LoaiSPs.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa thông tin của 1 loại sản phẩm
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                LoaiSP temp = db.DBO.LoaiSPs.Single(d => d.maLoai == obj);
                db.DBO.LoaiSPs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Tạo mã loại sản phẩm mới nối tiếp mã loại cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                //Lấy mã nhân viên cuối
                IQueryable ds = (from loai in db.DBO.LoaiSPs
                                 orderby loai.maLoai descending
                                 select loai.maLoai).Take(1);
                string maLoai = "";
                foreach (var item in ds)
                {
                    maLoai = item.ToString();
                }

                //Lấy số tiếp theo msNV cuối
                string maSo = maLoai.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã NV mới
                maLoai = "LS" + String.Format("{0:D8}", soMoi);

                return maLoai;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Mã mặc định
                return "LS00000001";
            }
        }
        /// <summary>
        /// Tìm loại sản phẩm theo mã loại sản phẩm
        /// </summary>
        /// <param name="maLoai"></param>
        /// <returns></returns>
        public LoaiSP_DTO timLoaiSP_MaLoaiSP(string maLoai)
        {
            try
            {
                LoaiSP temp = db.DBO.LoaiSPs.Single(d => d.maLoai.Equals(maLoai));
                return new LoaiSP_DTO(temp.maLoai, temp.tenLoai);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
