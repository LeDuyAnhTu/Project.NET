using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
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

namespace Project.NET.GUI_UC.PageKhuyenMai
{
    public partial class ThongKeKhuyenMai_UC : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKeKhuyenMai_BUS data = null;


        public ThongKeKhuyenMai_UC()
        {
            InitializeComponent();
            data = new ThongKeKhuyenMai_BUS();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                SimpleButton clickedButton = (SimpleButton)sender;
                switch (clickedButton.Name)
                {
                    case "btnTKKhuyenMai":
                        nafContent.SelectedPage = navPageTKKhuyenMai;
                        btnClickTKKhuyenMai();
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
        /// Thống kê theo khuyến mãi
        /// </summary>
        private void btnClickTKKhuyenMai()
        {
            //
            // buoc 1 : tao nguon du lieu
            //
            var statsByKhuyenMai = data.LayDanhSachThongKeKM();
            chartTKKhuyenMai.SuportCreateChart(statsByKhuyenMai, d => d.SoLuongConLaiSauKM, d => d.SoLuongKM, ViewType.Bar,
                "Thống kê Khuyến Mãi", "Số lượng còn lại sau khuyến mãi", "Số lượng Khuyến Mãi", "Số lượng còn lại sau khuyến mãi");
            ////
            //// buoc 2: Cau hinh bieu do cot
            //// 
            //// Cấu hình tiêu đề
            //chartTKKhuyenMai.Titles.Add(new ChartTitle() { Text = "Thống kê khuyến mãi" });

            //// Cấu hình trục X
            //XYDiagram diagram = (XYDiagram)chartTKKhuyenMai.Diagram;
            //diagram.AxisX.Title.Text = "Số lượng còn lại sau khuyến mãi";
            //diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            //// Cấu hình trục Y
            //diagram.AxisY.Title.Text = "Số lượng khuyến mãi";
            //diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            ////
            //// buoc 3: them du lieu vao bieu do
            //// 
            //Series series = new Series("Số lượng khuyến mãi", ViewType.Bar);
            //Series seriesSLConLaiSauKM = new Series("Số lượng còn lại sau khuyến mãi", ViewType.Bar);
            //foreach (ThongKeKhuyenMai_DTO data in statsByKhuyenMai)
            //{
            //    series.Points.Add(new SeriesPoint(data.MaSP, data.SoLuongKM));
            //    seriesSLConLaiSauKM.Points.Add(new SeriesPoint(data.MaSP, data.SoLuongConLaiSauKM));
            //}
            //chartTKKhuyenMai.Series.Add(series);
            //chartTKKhuyenMai.Series.Add(seriesSLConLaiSauKM);
        } 

        public void sql()
        {
            /**
             * -- 0lay danh sach thong ke khuyen mai
SELECT 
    ctkm.maSP AS MaSP,
    COUNT(ctkm.maKM) AS SoLuongKM,
    (sp.soLuongConLai - SUM(ctkm.soLuong)) AS SoLuongConLaiSauKM
FROM 
    ChiTietKM ctkm
JOIN 
    (SELECT maSP, soLuongConLai FROM SanPham) sp ON ctkm.maSP = sp.maSP
GROUP BY 
    ctkm.maSP, sp.soLuongConLai


--delete from KhuyenMai
--delete from ChiTietKM

	-- Thêm vào bảng khuyenMai
--INSERT INTO KhuyenMai(maKM, ghiChu)
--VALUES ('KM01', N'Khuyến mãi cho sản phẩm SP00000001'),
--       ('KM02', N'Khuyến mãi cho sản phẩm SP00000002'),
--       ('KM03', N'Khuyến mãi cho sản phẩm SP00000003'),
--       ('KM04', N'Khuyến mãi cho sản phẩm SP00000004');

--select * from KhuyenMai


---- Thêm vào bảng ChiTietKhuyenMai
--INSERT INTO ChiTietKM(maKM, maSP, soLuong)
--VALUES ('KM01', 'SP00000001', 50),
--       ('KM02', 'SP00000002', 60),
--       ('KM03', 'SP00000003', 70),
--       ('KM04', 'SP00000004', 80);
--select * from ChiTietKM

-- select * from SanPham

 --1Số lượng sản phẩm được khuyến mãi
 SELECT COUNT(DISTINCT maSP) FROM ChiTietKM;

 --2Số lượng khuyến mãi cho mỗi sản phẩm
 SELECT maSP, COUNT(maKM) FROM ChiTietKM GROUP BY maSP;

--3Số lượng sản phẩm còn lại sau khuyến mãi
SELECT SP.tenSP, (SP.soLuongConLai - ISNULL(CTKM.soLuong, 0)) AS soLuongConLaiSauKM
FROM SanPham SP LEFT JOIN ChiTietKM CTKM ON SP.maSP = CTKM.maSP;

--4Sản phẩm được khuyến mãi nhiều nhất
SELECT top 1 maSP, COUNT(maKM) AS soLuongKM
FROM ChiTietKM
GROUP BY maSP
ORDER BY soLuongKM DESC
 
--5Thông tin chi tiết về các khuyến mãi:
SELECT
	KM.maKM,
	KM.ghiChu,
	CTKM.maSP,
	SP.tenSP,
	CTKM.soLuong
FROM
	khuyenMai KM
JOIN
	ChiTietKM CTKM ON KM.maKM = CTKM.maKM
JOIN
	SanPham SP ON CTKM.maSP = SP.maSP;
*/
        }
    }
}
