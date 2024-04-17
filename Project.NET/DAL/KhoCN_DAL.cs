﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoCN_DAL : BasicMethod<KhoCN_DTO>
    {
        /// <summary>
        /// Lấy danh sách kho hàng ở các chi nhánh
        /// </summary>
        /// <returns></returns>
        public override IQueryable LayDanhSach()
        {
            IQueryable ds = null;
            try
            {
                ds = from kho in db.DBO.KhoCNs
                     select kho;
            }catch(Exception ex)
            {
                throw ex;
            }
            return ds;  
        }
        /// <summary>
        /// Lấy danh sách sản phẩm có ở 1 chi nhánh
        /// </summary>
        /// <param name="maCN"></param>
        /// <returns></returns>
        public IQueryable LayDanhSach(string maCN)
        {
            IQueryable ds = null;
            try
            {
                ds = from kho in db.DBO.KhoCNs
                     where kho.maCN == maCN
                     select kho;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        /// <summary>
        /// Sửa thông tin kho của chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Sua(KhoCN_DTO obj)
        {
            bool result = false;
            try
            {
                KhoCN temp = db.DBO.KhoCNs.Single(d => d.maCN == obj.MaCN);
                temp.maSP = obj.MaSP;
                temp.soLuong = obj.SoLuong;

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
        /// Thêm sản phẩm vào kho chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Them(KhoCN_DTO obj)
        {
            bool result = false;
            try
            {
                KhoCN temp = new KhoCN()
                {
                    maCN = obj.MaCN,
                    maSP = obj.MaSP,
                    soLuong = obj.SoLuong,
                };
                db.DBO.KhoCNs.InsertOnSubmit(temp);
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
        /// Xóa thông tin kho của 1 chi nhánh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Xoa(string maCN)
        {
            bool result = false;
            try
            {
                KhoCN temp = db.DBO.KhoCNs.Single(d => d.maCN == maCN);
                db.DBO.KhoCNs.DeleteOnSubmit(temp);
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
        /// Xóa thông tin 1 sản phẩm ra khỏi 1 kho chi nhánh
        /// </summary>
        /// <param name="maCN"></param>
        /// <param name="maSP"></param>
        /// <returns></returns>
        public bool Xoa(string maCN, string maSP)
        {
            bool result = false;
            try
            {
                KhoCN temp = db.DBO.KhoCNs.Single(d => d.maCN == maCN && d.maSP == maSP);
                db.DBO.KhoCNs.DeleteOnSubmit(temp);
                db.DBO.SubmitChanges();
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
