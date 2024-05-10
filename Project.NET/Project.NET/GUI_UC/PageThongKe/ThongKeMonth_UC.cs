using DevExpress.XtraEditors;
using Project.NET.ExtensionMethods;
using System;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraCharts;
namespace Project.NET.GUI_UC
{
    public partial class ThongKeMonth_UC : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKe_BUS data = new ThongKe_BUS();
        public ThongKeMonth_UC()
        {
            InitializeComponent();
        }

        private void txtTKTenSP_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }

        private void btnThongKeThang_Click(object sender, EventArgs e)
        {
            try
            {
                var stats = data.ThongKeDoanhThuTheo_Thang(txtNgayLapHoaDonTu.DateTime, txtNgayLapHoaDonDen.DateTime, txtTKTenSP.Text);
                dgvTongTienMatHang.DataSource = stats;
                chartDoanhThuThang.SuportCreateChart(
                    stats,
                    d => d.Thang,
                    d => d.TongTien,
                    ViewType.Bar,
                    "Doanh Thu theo tháng",
                    "Tháng",
                    "Tổng tiền",
                    "Tình hình kinh doanh theo tháng"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
