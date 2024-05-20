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
    public partial class HoaDon_UC : DevExpress.XtraEditors.XtraUserControl
    {
        private HoaDon_BUS db_HD = new HoaDon_BUS();
        public HoaDon_UC()
        {
            InitializeComponent();
        }

        private void dgvGrid_Load(object sender, EventArgs e)
        {
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In hoa don");
        }

        private void HoaDon_UC_Load(object sender, EventArgs e)
        {
            //
            //Hiển thị danh sách hóa đơn
            //
            dgvGrid.DataSource = db_HD.LayDanhSach();

        }
    }
}
