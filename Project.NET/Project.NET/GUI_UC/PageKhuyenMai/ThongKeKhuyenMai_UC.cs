using BUS;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
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

            //
            // buoc 2: Cau hinh bieu do cot
            // 
            // Cấu hình tiêu đề
            chartTKKhuyenMai.Titles.Add(new ChartTitle() { Text = "Thống kê khuyến mãi" });

            // Cấu hình trục X
            XYDiagram diagram = (XYDiagram)chartTKKhuyenMai.Diagram;
            diagram.AxisX.Title.Text = "Mã sản phẩm";
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Cấu hình trục Y
            diagram.AxisY.Title.Text = "Số lượng khuyến mãi";
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            //
            // buoc 3: them du lieu vao bieu do
            // 
            Series series = new Series("Số lượng khuyến mãi", ViewType.Bar);
            Series seriesSLConLaiSauKM = new Series("Số lượng còn lại sau khuyến mãi", ViewType.Bar);
            foreach (ThongKeKhuyenMai_DTO data in statsByKhuyenMai)
            {
                series.Points.Add(new SeriesPoint(data.MaSP, data.SoLuongKM));
                seriesSLConLaiSauKM.Points.Add(new SeriesPoint(data.MaSP, data.SoLuongConLaiSauKM));
            }
            chartTKKhuyenMai.Series.Add(series);
            chartTKKhuyenMai.Series.Add(seriesSLConLaiSauKM);
        } 
    }
}
