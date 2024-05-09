using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Project.NET.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace Project.NET.GUI_UC
{
    public partial class ThongKeNhanVien_UC : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKeNhanVien_BUS data = new ThongKeNhanVien_BUS();
        // Nút bấm menu navbar cuối cùng được nhấn
        private SimpleButton lastClickButton = null;

        public ThongKeNhanVien_UC()
        {
            InitializeComponent();
        }

        private void ThongKeNhanVien_UC_Load(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navPageTongNhanVienTheoChiNhanh;

            var dataPoints = data.ThongKeNhanVienTheoChiNhanh();

            chartTongNhanVienTheoPhongBan.SuportCreateChart(dataPoints,
                    dp => dp.TenCN,
                    dp => dp.SoLuongNV,
                    ViewType.Bar,
                    "Series Tổng nhân viên theo Chi Nhánh",
                    "Chi nhánh",
                    "Tổng số nhân viên",
                    "Thống kê tổng số NV Theo Chi Nhánh");
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                SimpleButton currentButton = (SimpleButton)sender;

                // Cập nhật UI cho nút đang đc nhấn
                currentButton.UpdateButtonStyle(lastClickButton);

                //
                // Cập nhật trạng thái cho nút đang được nhấn
                //
                lastClickButton = currentButton;
                switch (currentButton.Name)
                {
                    case "btnCoCauNhanVienTheoChucVu":
                        nafContent.SelectedPage = navPageCoCauNhanVienTheoChucVu;
                         
                        break;
                    case "btnTongNhanVienTheoChucVu":
                        nafContent.SelectedPage = navPageTongNhanVienTheoChucVu;
                         
                        break;
                    case "btnCoCauNVTheoCN":
                        nafContent.SelectedPage = navPageCoCauNhanVienTheoChiNhanh;
                         
                        break;
                    case "btnTongNVTheoCN":
                        nafContent.SelectedPage = navPageTongNhanVienTheoChiNhanh;
                        var dataPoints = data.ThongKeNhanVienTheoChiNhanh();

                        chartTongNhanVienTheoPhongBan.SuportCreateChart(dataPoints,
                                dp => dp.TenCN,
                                dp => dp.SoLuongNV,
                                ViewType.Bar,
                                "Series Tổng nhân viên theo Chi Nhánh",
                                "Chi nhánh",
                                "Tổng số nhân viên",
                                "Thống kê tổng số NV Theo Chi Nhánh");
                        break;
                    
                    default:
                        throw new Exception("Unknown button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
