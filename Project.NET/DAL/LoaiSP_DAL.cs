﻿using DTO;
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
                     select loai;
            }catch (Exception ex)
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
    }
}