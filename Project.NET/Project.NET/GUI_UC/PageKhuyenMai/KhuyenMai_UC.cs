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
    public partial class KhuyenMai_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public KhuyenMai_UC()
        {
            InitializeComponent();
            txtGhiChu.Properties.LinesCount = 0;
        }

        private void txtTenSP_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editTExt = sender as TextEdit;
            editTExt.Properties.MaxLength = 250;
        }
    }
}
