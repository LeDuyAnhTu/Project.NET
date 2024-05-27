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

namespace Project.NET.GUI_UC.PageNhaCungCap
{
    public partial class NhaCungCap_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public NhaCungCap_UC()
        {
            InitializeComponent();
        }

        private void txtTenNSX_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese(30);
        }

        private void txtDiaChi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese(100);
        }
    }
}
