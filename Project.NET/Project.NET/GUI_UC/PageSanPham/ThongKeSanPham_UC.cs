using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
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
        
        public ThongKeSanPham_UC()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            try
            { 
                // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                SimpleButton clickedButton = (SimpleButton)sender;
                switch (clickedButton.Name)
                {
                    case "btnTKLoaiSanPham":
                        nafContent.SelectedPage = navPageTKLoaiSanPham;
                        btnClickTKLoaiSanPham();
                        break;
                    case "btnTKNSX":
                        nafContent.SelectedPage = navPageTKNSX;
                        btnClickTKNSX();
                        break;
                    case "btnTKHanSuDung":
                        nafContent.SelectedPage = navPageTKHanSuDung;
                        btnClickTKHanSuDung();
                        break;
                    case "btnTKDonGia":
                        nafContent.SelectedPage = navPageTKDonGia;
                        btnClickTKDonGia();
                        break;
                    case "btnTKSoLuongSpConLai":
                        nafContent.SelectedPage = navPageTKSoLuongSpConLai;
                        btnClickTKSoLuongSPConLai();
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
        /// Thống kê theo loại sản phẩm
        /// </summary>
        private void btnClickTKLoaiSanPham()
        {
            /*
            SELECT tenLoai, COUNT(maSP) as SoLuongSanPham
FROM SanPham JOIN LoaiSanPham ON SanPham.maLoai = LoaiSanPham.maLoai
GROUP BY tenLoai; 
            */
            //
            // buoc 1 : tao nguon du lieu
            //
            var statsByProductType = db.StatsByProductType();

            //
            // buoc 2: Cau hinh bieu do cot
            // 
            // Cấu hình tiêu đề
            chartTKLoaiSanPham.Titles.Add(new ChartTitle() { Text = "Thống kê sản phẩm theo loại" });

            // Cấu hình trục X
            XYDiagram diagram = (XYDiagram)chartTKLoaiSanPham.Diagram;
            diagram.AxisX.Title.Text = "Loại sản phẩm";
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Cấu hình trục Y
            diagram.AxisY.Title.Text = "Số lượng sản phẩm";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            //
            // buoc 3: them du lieu vao bieu do
            // 
            Series series = new Series("Số lượng sản phẩm", ViewType.Bar);
            foreach (ThongKeSanPham_DTO data in statsByProductType)
            {
                series.Points.Add(new SeriesPoint(data.TenLoai, data.SoLuongSanPham));
            }
            chartTKLoaiSanPham.Series.Add(series);

        }
        /// <summary>
        /// Thống kê theo nhà sản xuất
        /// </summary>
        private void btnClickTKNSX()
        {
            /*
            SELECT maNSX, COUNT(maSP) as SoLuongSanPham
FROM SanPham
GROUP BY maNSX; 
            */

        }
      
        /// <summary>
        /// Thống kê theo hạn sử dụng
        /// </summary>
        private void btnClickTKHanSuDung()
        {
            /*
             SELECT COUNT(maSP) as SoLuongSanPham
FROM SanPham
WHERE HSD BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 1 MONTH);
*/
        }

        /// <summary>
        /// Thống kê theo giá
        /// </summary>
        private void btnClickTKDonGia()
        {
            /*
            SELECT 
   SUM(CASE WHEN donGia < 100000 THEN 1 ELSE 0 END) as 'Duoi 100.000 VND',
   SUM(CASE WHEN donGia BETWEEN 100000 AND 500000 THEN 1 ELSE 0 END) as '100.000 VND - 500.000 VND',
   SUM(CASE WHEN donGia > 500000 THEN 1 ELSE 0 END) as 'Tren 500.000 VND'
FROM SanPham; 
            */

        }
        /// <summary>
        /// Thống kê theo số lượng còn lại
        /// </summary>
        private void btnClickTKSoLuongSPConLai()
        {
            /*
             SELECT 
    SUM(CASE WHEN soLuongConLai < 10 THEN 1 ELSE 0 END) as 'Duoi 10',
    SUM(CASE WHEN soLuongConLai BETWEEN 10 AND 50 THEN 1 ELSE 0 END) as '10 - 50',
    SUM(CASE WHEN soLuongConLai > 50 THEN 1 ELSE 0 END) as 'Tren 50'
FROM SanPham;
*/

        }

    }
}
