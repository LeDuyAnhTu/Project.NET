using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project.NET.ExtensionMethods
{
    public static class EditTextExtensions
    {
        /// <summary>
        /// Xóa kí tự đặc biệt gạch chân ở cuối
        /// </summary>
        /// <param name="edit"></param>
        public static void RemoveTrailingUnderscore(this TextEdit edit)
        {
            // Sự kiện EditValueChanged để loại bỏ kí tự '_' cuối cùng
            edit.EditValueChanged += (sender, e) =>
            {
                if (edit.Text.EndsWith("_"))
                {
                    edit.Text = edit.Text.TrimEnd('_');
                }
            };
        }
        /// <summary>
        /// Hỗ trợ viết tiếng việt, mặc định tối đa 255 kí tự. 
        /// </summary>
        /// <param name="edit"></param>
        public static void SupportVietnamese(this TextEdit edit, int maxLength = 255)
        {
            // Sự kiện EditValueChanging để hạn chế kí tự không phải tiếng việt
            edit.EditValueChanging += (sender, e) =>
            {
                string pattern = @"^[a-zA-Z\u00C0-\u1EF9\s]*$"; // Biểu thức chính quy cho kí tự tiếng Việt
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(e.NewValue.ToString()))
                {
                    e.Cancel = true; // Hủy thay đổi nếu giá trị mới không khớp với biểu thức chính quy
                }
            };

            edit.Properties.MaxLength = maxLength;
        }
        /// <summary>
        /// Hỗ trợ nhập tên tài khoản
        /// </summary>
        /// <param name="edit"></param>
        public static void SupportLoginName(this TextEdit edit)
        {
            // Sự kiện EditValueChanging để hạn chế nhập độ dài
            edit.EditValueChanging += (sender, e) =>
            {
                string pattern = @"^[0-9a-zA-Z]{6,30}$"; //Nhập tên tài khoản
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(e.NewValue.ToString()))
                {
                    e.Cancel = true; // Hủy thay đổi nếu giá trị mới không khớp với biểu thức chính quy
                }
            };
        }
        /// <summary>
        /// Hỗ trợ nhập Mật khẩu
        /// </summary>
        /// <param name="edit"></param>
        public static void SupportPassword(this TextEdit edit)
        {
            // Sự kiện EditValueChanging để hạn chế nhập độ dài
            edit.EditValueChanging += (sender, e) =>
            {
                string pattern = @"^[a-zA-Z\d@$!%*?&]{6,30}$"; //Nhập mật khẩu
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(e.NewValue.ToString()))
                {
                    e.Cancel = true; // Hủy thay đổi nếu giá trị mới không khớp với biểu thức chính quy
                }
            };
            edit.Properties.PasswordChar = '*';
        }

        /// <summary>
        /// Hỗ trợ nhập số lượng
        /// </summary>
        /// <param name="edit"></param>
        public static void SupportNumeric(this TextEdit edit)
        {
            // Sự kiện EditValueChanging để hạn chế nhập  
            edit.EditValueChanging += (sender, e) =>
            {
                string pattern = @"^[0-9]{1,11}$";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(e.NewValue.ToString()) || Convert.ToInt64(e.NewValue) < 0)
                {
                    e.Cancel = true; // Hủy thay đổi nếu giá trị mới không khớp với biểu thức chính quy hoặc là số âm
                }
            };
        }
        /// <summary>
        /// Hỗ trợ nhập số điện thoại
        /// </summary>
        /// <param name="edit"></param>
        public static void SupportSoDienThoai(this TextEdit edit, int maxLength = 10)
        {
            // Sự kiện EditValueChanging để hạn chế nhập  
            edit.EditValueChanging += (sender, e) =>
            {
                string pattern = @"^[0-9]{0,}$";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(e.NewValue.ToString()))
                {
                    e.Cancel = true; // Hủy thay đổi nếu giá trị mới không khớp với biểu thức chính quy
                }
            };
            edit.Properties.MaxLength = maxLength;
        }
    }
}

