using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiNhanh_DAL : BasicMethod<ChiNhanh_DTO>
    {
        /// <summary>
        /// Lấy danh sách các chi nhánh
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            try
            {
                IQueryable ds = from cn in db.DBO.ChiNhanhs
                                join nv in db.DBO.NhanViens on cn.maQL equals nv.maNV
                                join kv in db.DBO.KhuVucs on cn.maKV equals kv.maKV
                                select new
                                {
                                    MãChiNhánh = cn.maCN,
                                    TênChiNhánh = cn.tenCN,
                                    ĐịaChỉ = cn.diaChi,
                                    QuảnLý = nv.tenNV,
                                    KhuVực = kv.tenKV,
                                };
                return ds;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách chi nhánh cho các combobox
        /// </summary>
        /// <returns></returns>
        public IQueryable LayDanhSach_Combobox()
        {
            try
            {
                IQueryable ds = from cn in db.DBO.ChiNhanhs
                                select new
                                {
                                    cn.maCN,
                                    cn.tenCN,
                                };
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách chi nhánh theo mã khu vực
        /// </summary>
        /// <param name="maKV"></param>
        /// <returns></returns>
        public IQueryable LayDanhSach_TheoKV(string maKV)
        {
            try
            {
                IQueryable ds = from cn in db.DBO.ChiNhanhs
                                where cn.maKV.Equals(maKV)
                                select new
                                {
                                    cn.maCN,
                                    cn.tenCN,
                                };
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Sửa thông tin của 1 chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(ChiNhanh_DTO obj)
        {
            try
            {
                bool result = false;

                ChiNhanh temp = db.DBO.ChiNhanhs.Single(d => d.maCN == obj.MaCN);
                temp.tenCN = obj.TenCN;
                temp.diaChi = obj.DiaChi;
                temp.maKV = obj.MaKV;
                temp.maQL = obj.MaQL;

                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm chi nhánh mới
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(ChiNhanh_DTO obj)
        {
            try
            {
                bool result = false;

                ChiNhanh temp = new ChiNhanh()
                {
                    maCN = obj.MaCN,
                    tenCN = obj.TenCN,
                    diaChi = obj.DiaChi,
                    maKV = obj.MaKV,
                    maQL = obj.MaQL,
                };

                db.DBO.ChiNhanhs.InsertOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Xóa thông tin của 1 chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string obj)
        {
            try
            {
                bool result = false;

                ChiNhanh temp = db.DBO.ChiNhanhs.Single(d=>d.maCN == obj);

                db.DBO.ChiNhanhs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();

                result = true;
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tạo mã chi nhánh mới nối tiếp mã chi nhánh cuối cùng trong database
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                //Lấy mã nhân viên cuối
                IQueryable ds = (from cn in db.DBO.ChiNhanhs
                                 orderby cn.maCN descending
                                 select cn.maCN).Take(1);
                string maCN = "";
                foreach (var item in ds)
                {
                    maCN = item.ToString();
                }

                //Lấy số tiếp theo msNV cuối
                string maSo = maCN.Substring(2);
                int soMoi = Convert.ToInt32(maSo) + 1;

                //Tạo mã NV mới
                maCN = "CN" + String.Format("{0:D8}", soMoi);

                return maCN;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "CN00000001";
            }
        }
    }
}
