using BUS;
using DevExpress.ClipboardSource.SpreadsheetML;
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

namespace Project.NET.GUI_UC
{
    public partial class ThongKeYear_UC : DevExpress.XtraEditors.XtraUserControl
    {
        ThongKe_BUS data = new ThongKe_BUS();
        public ThongKeYear_UC()
        {
            InitializeComponent();
        }

        private void btnThongKeNam_Click(object sender, EventArgs e)
        {
            try
            {
                var stats = data.ThongKeDoanhThuTheo_Nam(txtHoaDonTheoNam.DateTime);
                dataGridView1.DataSource = stats;
                chartDoanhThuNam.SuportCreateChart(
                    stats,
                    d => d.Thang,
                    d => d.TongTien,
                    ViewType.Bar,
                    "Doanh Thu theo Năm",
                    "Tháng",
                    "Tổng tiền",
                    "Tình hình kinh doanh theo năm"
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
