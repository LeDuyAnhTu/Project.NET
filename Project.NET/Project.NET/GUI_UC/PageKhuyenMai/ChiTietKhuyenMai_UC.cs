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

namespace Project.NET.GUI_UC.PageKhuyenMai
{
    public partial class ChiTietKhuyenMai_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public ChiTietKhuyenMai_UC()
        {
            InitializeComponent();
        }

        private void txtSoLuong_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editTExt = sender as TextEdit;
             editTExt.SupportNumeric();
        }
    }
}
