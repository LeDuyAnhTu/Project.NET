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
                                select cl;
                return ds;
            }
            catch(Exception ex)
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

            }catch(Exception ex)
            {
                throw ex;
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
                throw ex;
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
    }
}
