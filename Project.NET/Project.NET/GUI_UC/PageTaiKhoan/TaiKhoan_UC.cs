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

namespace Project.NET.Forms
{
    public partial class TaiKhoan_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public TaiKhoan_UC()
        {
            InitializeComponent();
        }

        private void txtTenTK_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportLoginName();
        }

        private void txtMatKhauTK_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportPassword();
        }

        
    }
}
