using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.NET.ExtensionMethods
{
    public static class SimpleButtonExtensions
    {
        // cấu hình style cho nút bấm của hệ thống
        public static void UpdateButtonStyle(this SimpleButton button, SimpleButton lastClickButton)
        {
            // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
            button.Appearance.BackColor = Color.Orange;
            button.Appearance.BorderColor = Color.AliceBlue;
            button.Appearance.ForeColor = Color.White;
            button.Appearance.Font = new Font("Tahoma", 12, FontStyle.Bold);
            button.AppearanceHovered.ForeColor = Color.White;

            //
            // Nếu có nút đã được nhấn và không phải là nút hiện tại
            //
            if (lastClickButton != null && lastClickButton != button)
            {
                // Đặt lại trang thái mặc định cho nút nhấn cuối cùng
                lastClickButton.Appearance.Reset();
                lastClickButton.AppearanceHovered.ForeColor = Color.Orange;
            }
        }
    }
}
