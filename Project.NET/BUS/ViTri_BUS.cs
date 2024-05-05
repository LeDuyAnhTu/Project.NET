using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ViTri_BUS
    {
        private static ViTri_DAL db = new ViTri_DAL();
        /// <summary>
        /// Lấy danh sách các vị trí có trong hệ thống
        /// </summary>
        /// <returns></returns>
        public IQueryable LayDanhSach()
        {
            try
            {
                return db.LayDanhSach();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Thêm vị trí mới vào hệ thống
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Them(ViTri_DTO o)
        {
            bool result = false;

            try
            {
                result = db.Them(o);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        /// <summary>
        /// Sửa thông tin 1 vị trí trong hệ thống
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Sua(ViTri_DTO o)
        {
            bool result = false;

            try
            {
                result = db.Sua(o);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
        /// <summary>
        /// Xóa thông tin vị trí trong hệ thống
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Xoa(string id)
        {
            bool result = false;

            try
            {
                result = db.Xoa(id);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("fk_nhanvien_vitri"))
                {
                    throw new Exception("Hiện đang có nhân viên đảm nhiệm vị trí này");
                }
                else
                {
                    throw ex;
                }
            }
            return result;
        }
        /// <summary>
        /// Tìm thông tin vị trí làm việc theo mã
        /// </summary>
        /// <param name="maVT"></param>
        /// <returns></returns>
        public ViTri_DTO timTheoMa(string maVT)
        {
            try
            {
                return db.timTheoMa(maVT);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Tạo mã vị trí cuối
        /// </summary>
        /// <returns></returns>
        public string taoMaMoi()
        {
            try
            {
                return db.taoMaMoi();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
