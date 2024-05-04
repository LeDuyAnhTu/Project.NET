using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using Project.NET.ExtensionMethods;
using Project.NET.Forms;
using Project.NET.GUI_UC.PageKho;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace Project.NET.GUI_UC.PageSanPham
{
    public partial class ThongKeSanPham_UC : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKeSanPham_BUS db = new ThongKeSanPham_BUS();
        // Nút bấm menu navbar cuối cùng được nhấn
        private SimpleButton lastClickButton = null;
        public ThongKeSanPham_UC()
        {
            InitializeComponent();
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
                    case "btnTKLoaiSanPham":
                        nafContent.SelectedPage = navPageTKLoaiSanPham;
                        btnClickStatsByProductType(chartTKLoaiSanPham);
                        break;
                    case "btnTKNSX":
                        nafContent.SelectedPage = navPageTKNSX;
                        btnClickTKSoLuongSpTheoNSX(chartControl2);
                        break;
                    case "btnTKHanSuDung":
                        nafContent.SelectedPage = navPageTKHanSuDung;
                        btnClickTKHanSuDung(chartControl3, db.StatsByExpiryDate());
                        break;
                    case "btnTKDonGia":
                        nafContent.SelectedPage = navPageTKDonGia;
                        btnClickTKSoLuongSPTheoKhoangGia(chartControl4, db.StatsByPrice());
                        break;
                    case "btnTKSoLuongSpConLai":
                        nafContent.SelectedPage = navPageTKSoLuongSpConLai;
                        btnClickTKSoLuongSPConLai(chartControl5, db.StatsByRemainingQuantity());
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
        /*
            SELECT tenLoai, COUNT(maSP) as SoLuongSanPham
FROM SanPham JOIN LoaiSanPham ON SanPham.maLoai = LoaiSanPham.maLoai
GROUP BY tenLoai; 
            */
        /// <summary>
        /// Thống kê theo loại sản phẩm
        /// </summary>
        private void btnClickStatsByProductType(ChartControl chart)
        {

            List<ThongKeSanPham_DTO> dataPoints = db.StatsByProductType(); // Replace this with your data source
            chart.CreateChart(dataPoints,
                dp => dp.TenLoai,
                dp => dp.SoLuongSanPham,
                ViewType.Bar,
                "Series Số lượng sản phẩm",
                "Loại sản phẩm",
                "Số lượng sản phẩm",
                "Thống kê sản phẩm theo loại");

        }
        /*
            SELECT NhaSanXuat.tenNSX, COUNT(maSP) as SoLuongSanPham
FROM SanPham
inner join NhaSanXuat on NhaSanXuat.maNSX = SanPham.maNSX
GROUP BY NhaSanXuat.tenNSX; 

SELECT maNSX, COUNT(maSP) as SoLuongSanPham
FROM SanPham
GROUP BY maNSX; 
            */
        /// <summary>
        /// Thống kê số lượng sp theo nhà sản xuất
        /// </summary>
        private void btnClickTKSoLuongSpTheoNSX(ChartControl chart)
        {

            List<ThongKeSanPham_DTO> dataPoints = db.StatsByManufacturer(); // Replace this with your data source
            chart.CreateChart(dataPoints,
                dp => dp.TenNSX,
                dp => dp.SoLuongSanPham,
                ViewType.Bar,
                "Series Số lượng sản phẩm",
                "Nhà sản xuất",
                "Số lượng sản phẩm",
                "Thống kê SL sản phẩm theo nhà sản xuất");
        }
        /*
             * DECLARE @Today DATETIME;
             * DECLARE @NextMonth DATETIME;

             * SET @Today = GETDATE();
SET @NextMonth = DATEADD(MONTH, 1, @Today);

SELECT sp.HSD AS 'Hạn sử dụng', COUNT(sp.maSP) AS 'Số lượng sản phẩm'
FROM SanPham AS sp
WHERE sp.HSD >= @Today AND sp.HSD <= @NextMonth
GROUP BY sp.HSD;
*/
        /// <summary>
        /// Thống kê theo hạn sử dụng trong tháng tới (1 tháng tiếp theo)
        /// </summary>
        private void btnClickTKHanSuDung(ChartControl chart, List<ThongKeSanPham_DTO> dataPoints)
        {

            chart.CreateChart(dataPoints,
                          dp => dp.HSD,
                          dp => dp.SoLuongSanPham,
                          ViewType.Line,
                          "Series Số lượng sản phẩm",
                          "Hạn sử dụng",
                          "Số lượng sản phẩm",
                          "Thống kê SL sản phẩm sắp hết hạn trong tháng tới");
        }

        /*
           SELECT 
  SUM(CASE WHEN donGia < 100000 THEN 1 ELSE 0 END) as 'Duoi 100.000 VND',
  SUM(CASE WHEN donGia BETWEEN 100000 AND 500000 THEN 1 ELSE 0 END) as '100.000 VND - 500.000 VND',
  SUM(CASE WHEN donGia > 500000 THEN 1 ELSE 0 END) as 'Tren 500.000 VND'
FROM SanPham; 
           */
        /// <summary>
        /// Thống kê theo giá
        /// </summary>
        private void btnClickTKSoLuongSPTheoKhoangGia(ChartControl chart, List<ThongKeSanPham_DTO> dataPoints)
        {

            chart.CreateChart(dataPoints,
                dp => dp.KhoangGia,
                dp => dp.SoLuongSanPham,
                ViewType.Bar,
                "Series Số lượng sản phẩm",
                "Khoảng giá",
                "Số lượng sản phẩm",
                "Thống kê SL sản phẩm theo khoảng giá");

        }
        /*
            SELECT 
   SUM(CASE WHEN soLuongConLai < 10 THEN 1 ELSE 0 END) as 'Duoi 10',
   SUM(CASE WHEN soLuongConLai BETWEEN 10 AND 50 THEN 1 ELSE 0 END) as '10 - 50',
   SUM(CASE WHEN soLuongConLai > 50 THEN 1 ELSE 0 END) as 'Tren 50'
FROM SanPham;
*/
        /// <summary>
        /// Thống kê theo số lượng còn lại
        /// </summary>
        private void btnClickTKSoLuongSPConLai(ChartControl chart, List<ThongKeSanPham_DTO> dataPoints)
        {

            chart.CreateChart(dataPoints,
                dp => dp.SoLuongConLai,
                dp => dp.SoLuongSanPham,
                ViewType.Bar,
                "Series Số lượng sản phẩm còn lại trong kho",
                "Sản phẩm",
                "Số lượng sản phẩm còn lại",
                "Thống kê SL sản phẩm còn lại trong kho");
        }
    }
}
