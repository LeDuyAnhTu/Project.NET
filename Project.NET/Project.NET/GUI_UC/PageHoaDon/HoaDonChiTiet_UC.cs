using BUS;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageHoaDon
{
    public partial class HoaDonChiTiet_UC : DevExpress.XtraEditors.XtraUserControl
    {
        private ChiTietHD_BUS db_ct_HD = new ChiTietHD_BUS();
        public HoaDonChiTiet_UC()
        {
            InitializeComponent();
        }

        private void HoaDonChiTiet_UC_Load(object sender, EventArgs e)
        {
            dgvGrid.DataSource = db_ct_HD.LayDanhSach();
        }
    }
}
