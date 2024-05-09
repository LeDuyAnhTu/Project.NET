using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using Project.NET.ExtensionMethods;
using Project.NET.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageKho
{
    public partial class ThongKeKhoCN_UC : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKeKhoCN_BUS db = new ThongKeKhoCN_BUS();
        SimpleButton lastClickButton = null;
        public ThongKeKhoCN_UC()
        {
            InitializeComponent();

            btnTKGiaTriKho.Click += Button_Click;
            btnTKSPTheoKhoCN.Click += Button_Click;
            btnTKTonKho.Click += Button_Click;
            btnTKSPTheoLoai.Click += Button_Click;
            
        }
        private void ThongKeKhoCN_UC_Load(object sender, EventArgs e)
        {
            //
            // First loading
            //
            SimpleButton clickedButton = btnTKGiaTriKho;
            clickedButton.UpdateButtonStyle(lastClickButton);
            lastClickButton = clickedButton;
            nafContent.SelectedPage = navPageTKGiaTriKho;
            lblTKGiaTriKho.Text = "Thống kê giá trị kho";
            btnClickStatsByProductValueInBranch(this.chartTKGiaTriKho);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                SimpleButton clickedButton = (SimpleButton)sender;
                clickedButton.UpdateButtonStyle(lastClickButton);
                lastClickButton = clickedButton;
                switch (clickedButton.Name)
                {
                    case "btnTKGiaTriKho":
                        nafContent.SelectedPage = navPageTKGiaTriKho;
                        lblTKGiaTriKho.Text = "Thống kê giá trị kho";
                        btnClickStatsByProductValueInBranch(this.chartTKGiaTriKho);

                        break;
                    case "btnTKSPTheoLoai":
                        nafContent.SelectedPage = navPageTKSPTheoLoai;
                        lblTKSPTheoLoai.Text = "Thống kê theo loại";
                        btnClickStatsByProductType(this.chartTKSPTheoLoai);
                        break;
                    case "btnTKTonKho":
                        nafContent.SelectedPage = navPageTKTonKho;
                        lblTKTonKho.Text = "Thống kê tồn kho";
                        btnClickStatsByInventoryInBranch(this.chartTKTonKho);
                        break;
                    case "btnTKSPTheoKhoCN":
                        nafContent.SelectedPage = navPageTKSPTheoKhoCN;
                        lblTKSPTheoKhoCN.Text = "Thống kê Sản phẩm";
                        btnClickStatsByProductInBranch(this.chartTKSPTheoKhoCN);
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
        /// <summary>
        /// Thong ke san pham theo kho chi nhanh
        /// </summary>
        /// <param name="chart"></param>
        private void btnClickStatsByProductInBranch(ChartControl chart)
        {
            List<ThongKeKhoCN_DTO> dataPoints = db.ThongKeTheoKhoChiNhanh();
            chart.SuportCreateChart(dataPoints,
                dp => dp.TenCN,
                dp => dp.SoLuongTrongKho,
                ViewType.Bar,
                "Series Số lượng sản phẩm",
                "Chi nhánh",
                "Số lượng sản phẩm",
                "Thống kê sản phẩm theo kho chi nhánh");
        }
        /// <summary>
        /// Thong ke gia tri san pham theo kho chi nhanh
        /// </summary>
        /// <param name="chart"></param>
        private void btnClickStatsByProductValueInBranch(ChartControl chart)
        {
            List<ThongKeKhoCN_DTO> dataPoints = db.ThongKeGiaTriSanPhamTheoKhoChiNhanh();
            chart.SuportCreateChart(dataPoints,
                dp => dp.TenCN,
                dp => dp.GiaTri,
                ViewType.Bar,
                "Series Giá trị sản phẩm",
                "Chi nhánh",
                "Giá trị sản phẩm",
                "Thống kê giá trị sản phẩm theo kho chi nhánh");
        }
        /// <summary>
        /// thong ke ton kho theo chi nhanh
        /// </summary>
        /// <param name="chart"></param>
        private void btnClickStatsByInventoryInBranch(ChartControl chart)
        {
            List<ThongKeKhoCN_DTO> dataPoints = db.ThongKeTonKhoTheoChiNhanh();
            chart.SuportCreateChart(dataPoints,
                dp => dp.TenCN,
                dp => dp.SoLuongTrongKho,
                ViewType.Bar,
                "Series Tồn kho",
                "Chi nhánh",
                "Số lượng tồn kho",
                "Thống kê tồn kho theo chi nhánh");
        }
        /// <summary>
        /// Thong ke san pham theo loai
        /// </summary>
        /// <param name="chart"></param>
        private void btnClickStatsByProductType(ChartControl chart)
        {
            List<ThongKeKhoCN_DTO> dataPoints = db.ThongKeSanPhamTheoLoai();
            chart.SuportCreateChart(dataPoints,
                dp => dp.TenLoai,
                dp => dp.SoLuongTrongKho,
                ViewType.Bar,
                "Series Số lượng sản phẩm",
                "Loại sản phẩm",
                "Số lượng sản phẩm",
                "Thống kê sản phẩm theo loại");
        }

       
    }
}
