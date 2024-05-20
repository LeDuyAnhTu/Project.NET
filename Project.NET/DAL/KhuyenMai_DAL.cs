using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMai_DAL : BasicMethod<KhuyenMai_DTO>
    {
        /// <summary>
        /// Lấy danh sách các loại khuyến mãi
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from km in db.DBO.KhuyenMais
                     select new
                     {
                         MãSố = km.maKM,
                         GhiChú = km.ghiChu
                     };
            }catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin khuyến mãi
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(KhuyenMai_DTO obj)
        {
            bool result = false;
            try
            {
                KhuyenMai temp = db.DBO.KhuyenMais.Single(d => d.maKM == obj.MaKM);
                temp.ghiChu = obj.GhiChu;
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
        /// Thêm khuyến mãi mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(KhuyenMai_DTO obj)
        {
            bool result = false;
            try
            {
                KhuyenMai temp = new KhuyenMai()
                {
                    maKM = obj.MaKM,
                    ghiChu = obj.GhiChu,
                };
                db.DBO.KhuyenMais.InsertOnSubmit(temp);
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
        /// Xóa 1 khuyến mãi
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            bool result = false;
            try
            {
                KhuyenMai temp = db.DBO.KhuyenMais.Single(d => d.maKM == obj);
                db.DBO.KhuyenMais.DeleteOnSubmit(temp);
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
        /// Tạo mã sản phẩm mới nối tiếp mã sản phẩm cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                //Lấy mã sản phẩm cuối
                IQueryable ds = (from km in db.DBO.KhuyenMais
                                 orderby km.maKM descending
                                 select km.maKM).Take(1);
                string maKM = "";
                foreach (var item in ds)
                {
                    maKM = item.ToString();
                }

                //Lấy số tiếp theo maKM cuối
                string maSo = maKM.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã NV mới
                maKM = "KM" + String.Format("{0:D8}", soMoi);

                return maKM;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "KM00000001";
            }
        }
        /// <summary>
        /// Tìm khuyến mãi theo mã khuyến mãi
        /// </summary>
        /// <param name="maKM"></param>
        /// <returns></returns>
        public KhuyenMai_DTO timKhuyenMai_MaKM(string maKM)
        {
            try
            {
                KhuyenMai temp = db.DBO.KhuyenMais.Single(d => d.maKM.Equals(maKM));
                return new KhuyenMai_DTO(temp.maKM, temp.ghiChu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
