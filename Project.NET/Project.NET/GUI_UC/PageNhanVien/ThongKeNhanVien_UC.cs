using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
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
            //
            // First loading
            //
            SimpleButton clickedButton = btnTongNhanVienTheoChiNhanh;
            clickedButton.UpdateButtonStyle(lastClickButton);
            lastClickButton = clickedButton;
            nafContent.SelectedPage = navPageTongNhanVienTheoChiNhanh;

            var dataPoints = data.ThongKeNhanVienTheoChiNhanh();

            chartTongNhanVienTheoChiNhanh.SuportCreateChart(dataPoints,
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

                List<ThongKeNhanVien_DTO> dataPoints = null;
                switch (currentButton.Name)
                {
                    case "btnTongNhanVienTheoChiNhanh":
                        nafContent.SelectedPage = navPageTongNhanVienTheoChiNhanh;
                        dataPoints = data.ThongKeNhanVienTheoChiNhanh();
                        lblTongNhanVienTheoChiNhanh.Text = "Thống kê tổng số NV Theo Chi Nhánh";
                        chartTongNhanVienTheoChiNhanh.SuportCreateChart(dataPoints,
                                dp => dp.TenCN, dp => dp.SoLuongNV,
                                ViewType.Bar,
                                "Tổng nhân viên", "Chi nhánh",
                                "Tổng số nhân viên", "Thống kê tổng số NV Theo Chi Nhánh");
                        break;
                    case "btnCoCauNVTheoGioiTinh":
                        nafContent.SelectedPage = navPageCoCauNVTheoGioiTinh;
                        dataPoints = data.ThongKeNhanVienTheoGioiTinh();
                        lblCoCauNVTheoGioiTinh.Text = "Thống kê Nhân viên theo giới tính";
                        chartCoCauNVTheoGioiTinh.SuportCreateChart(dataPoints,
                            d => d.TenCN, d => d.SoLuongNV, d => d.GioiTinh,
                            ViewType.Bar,
                             "Giới tính", "Tổng số nhân viên", "Thống kê Nhân viên theo giới tính");
                        break;
                    case "btnTongNhanVienTheoTuoi":
                        nafContent.SelectedPage = navPageTongNhanVienTheoTuoi;
                        dataPoints = data.ThongKeNhanVienTheoTuoi();
                        lblTongNhanVienTheoTuoi.Text = "Thống kê Nhân viên theo độ tuổi";
                        chartTongNhanVienTheoTuoi.SuportCreateChart(dataPoints,
                                dp => dp.TenCN, dp => dp.SoLuongNV, d => d.KhoangTuoiNV,
                                ViewType.Bar,
                                "Khoảng Tuổi", "Tổng số nhân viên", "Thống kê Nhân viên theo độ tuổi");
                        break;
                    case "btnCoCauNhanVienTheoChucVu":
                        nafContent.SelectedPage = navPageCoCauNhanVienTheoChucVu;
                        dataPoints = data.ThongKeNhanVienTheoViTriChucVuNhanVien();
                        lblCoCauNhanVienTheoChucVu.Text = "Thống kê Nhân viên theo chức vụ";
                        chartCoCauNhanVienTheoChucVu.SuportCreateChart(dataPoints,
                                dp => dp.TenCN, dp => dp.SoLuongNV, d => d.TenChucVu,
                                ViewType.Bar,
                                "Chức vụ", "Tổng số nhân viên", "Thống kê Nhân viên theo chức vụ");
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
