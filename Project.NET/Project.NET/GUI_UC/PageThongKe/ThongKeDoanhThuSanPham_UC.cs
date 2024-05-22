using BUS;
using DevExpress.Data.Helpers;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using Project.NET.ExtensionMethods;
using Project.NET.Forms;
using Project.NET.GUI_UC.PageBanHang;
using Project.NET.GUI_UC.PageChiNhanh;
using Project.NET.GUI_UC.PageHoaDon;
using Project.NET.GUI_UC.PageKhachHang;
using Project.NET.GUI_UC.PageKho;
using Project.NET.GUI_UC.PageKhuyenMai;
using Project.NET.GUI_UC.PageNhaCungCap;
using Project.NET.GUI_UC.PageNhanVien;
using Project.NET.GUI_UC.PageSanPham;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageThongKe
{
    public partial class ThongKeDoanhThuSanPham_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongKeDoanhThuSanPham_UC()
        {
            InitializeComponent();
        }

        ThongKeSanPham_BUS data = new ThongKeSanPham_BUS();

        //Chuyển đến form khác sau khi đăng nhập thành công
        frmMain frmMainn = Application.OpenForms.OfType<frmMain>().FirstOrDefault();

        // Nút bấm menu navbar cuối cùng được nhấn
        private SimpleButton lastClickButton = null;
        //
        // Reset nguon du lieu
        //
        List<ThongKeSanPhamTonKho_DTO> products_tonkho = new List<ThongKeSanPhamTonKho_DTO>();
        List<ThongKeSanPhamBanNhieu_DTO> products_bannhieu = new List<ThongKeSanPhamBanNhieu_DTO>();
        List<ThongKeSanPhamBanIt_DTO> products_banit = new List<ThongKeSanPhamBanIt_DTO>();

        /// <summary>
        /// Xử lý sự kiện cho các nút bấm trên nav menu buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private async void Button_Click(object sender, EventArgs e)
        {
            try
            {
                WaitFormManager waitFormManager = new WaitFormManager(frmMainn);
                await waitFormManager.ShowWaitForm(() =>
                {

                    // Sử dụng Invoke để đảm bảo rằng mã được thực thi trên thread chính
                    this.Invoke((MethodInvoker)delegate
                    {
                        //
                        // reset chart
                        //
                        chart.ClearCache();
                        chart.Titles.Clear();
                        // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                        SimpleButton currentButton = (SimpleButton)sender;
                        currentButton.UpdateButtonStyle(lastClickButton);

                        //
                        // Cập nhật trạng thái cho nút đang được nhấn
                        //
                        lastClickButton = currentButton;

                        //
                        // Kiểm tra nút được nhấn là nút nào, chuyển tài nguyên tương ứng
                        //
                        switch (currentButton.Name)
                        {
                            case "btnThongKeSanPhamTonKho":

                                products_tonkho = new List<ThongKeSanPhamTonKho_DTO>();
                                products_tonkho = data.ThongkeSanPhamTonKho();
                                products_tonkho.ToList();
                                //
                                // Hien thi du lieu cho datagridview
                                //
                                dgvDoanhThu.DataSource = products_tonkho;

                                chart.SuportCreateChart(
                                        dataPoints: products_tonkho,
                                        argumentSelector: product => product.TenSP,
                                        valueSelector: product => product.SoLuongTonKho,
                                        viewType: ViewType.Bar, // hoặc ViewType.Pie
                                        seriesName: "Sản phẩm",
                                        xAxisTitle: "Sản phẩm",
                                        yAxisTitle: "Tồn kho",
                                        chartTitle: "Thống kê sản phẩm tồn kho");

                                break;
                            case "btnThongKeSanPhamBanE":
                                products_banit = new List<ThongKeSanPhamBanIt_DTO>();
                                products_banit = data.ThongkeTop10SanPhamBanE();
                                //
                                // Hien thi du lieu cho datagridview
                                //
                                dgvDoanhThu.DataSource = products_banit;
                                chart.SuportCreateChart(
                                    dataPoints: products_banit,
                                    argumentSelector: product => product.TenSP,
                                    valueSelector: product => product.TotalSold,
                                    viewType: ViewType.Bar, // hoặc ViewType.Pie
                                    seriesName: "Sản phẩm",
                                    xAxisTitle: "Sản phẩm",
                                    yAxisTitle: "Đã bán",
                                    chartTitle: "Top 10 sản phẩm bán ít nhất"
                                );
                                break;
                            case "btnThongKeSanPhamBanChay":
                                products_bannhieu = new List<ThongKeSanPhamBanNhieu_DTO>();
                                products_bannhieu = data.ThongkeTop10SanPhamBanChay();
                                //
                                // Hien thi du lieu cho datagridview
                                //
                                dgvDoanhThu.DataSource = products_bannhieu;
                                chart.SuportCreateChart(
                                    dataPoints: products_bannhieu,
                                    argumentSelector: product => product.TenSP,
                                    valueSelector: product => product.TotalSold,
                                    viewType: ViewType.Bar, // hoặc ViewType.Pie
                                    seriesName: "Sản phẩm",
                                    xAxisTitle: "Sản phẩm",
                                    yAxisTitle: "Đã bán",
                                    chartTitle: "Top 10 sản phẩm bán chạy nhất"
                                );
                                break;
                            default:
                                throw new Exception("Unknown button.");
                        }

                    });
                    return Task.CompletedTask;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
