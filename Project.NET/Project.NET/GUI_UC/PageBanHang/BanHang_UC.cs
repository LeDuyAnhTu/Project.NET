using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageBanHang
{
    public partial class BanHang_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public BanHang_UC()
        {
            InitializeComponent();
            // Tạo các control cho form
            var employeeName = new DevExpress.XtraEditors.TextEdit();
            var billId = new DevExpress.XtraEditors.TextEdit();
            var billDate = new DevExpress.XtraEditors.DateEdit();
            var productList = new DevExpress.XtraEditors.LookUpEdit();
            var cart = new DevExpress.XtraEditors.TextEdit();
            var customerName = new DevExpress.XtraEditors.TextEdit();
            var loyaltyPoints = new DevExpress.XtraEditors.TextEdit();
            var totalAmount = new DevExpress.XtraEditors.TextEdit();
            var discount = new DevExpress.XtraEditors.TextEdit();
            var pointsUsed = new DevExpress.XtraEditors.TextEdit();
            var netAmount = new DevExpress.XtraEditors.TextEdit();
            var productType = new DevExpress.XtraEditors.LookUpEdit();

            var payButton = new DevExpress.XtraEditors.SimpleButton();
            var cancelButton = new DevExpress.XtraEditors.SimpleButton();

            // Thiết lập các thuộc tính cho các control
            employeeName.Properties.NullText = "Tên nhân viên trực quầy";
            billId.Properties.NullText = "Mã hóa đơn";
            billDate.DateTime = DateTime.Now;
            productList.Properties.NullText = "Danh sách sản phẩm còn hạn sử dụng";
            cart.Properties.NullText = "Giỏ hàng";
            customerName.Properties.NullText = "Tên khách hàng";
            loyaltyPoints.Properties.NullText = "Số điểm tích lũy";
            totalAmount.Properties.NullText = "Tổng tiền";
            discount.Properties.NullText = "Khuyến mãi";
            pointsUsed.Properties.NullText = "Điểm dùng";
            netAmount.Properties.NullText = "Thành tiền";
            productType.Properties.NullText = "Loại sản phẩm";

            payButton.Text = "Thanh toán";
            cancelButton.Text = "Hủy giỏ hàng";

            // Thêm các control vào form
            this.Controls.Add(employeeName);
            this.Controls.Add(billId);
            this.Controls.Add(billDate);
            this.Controls.Add(productList);
            this.Controls.Add(cart);
            this.Controls.Add(customerName);
            this.Controls.Add(loyaltyPoints);
            this.Controls.Add(totalAmount);
            this.Controls.Add(discount);
            this.Controls.Add(pointsUsed);
            this.Controls.Add(netAmount);
            this.Controls.Add(productType);
            this.Controls.Add(payButton);
            this.Controls.Add(cancelButton);
        }
    }
}
