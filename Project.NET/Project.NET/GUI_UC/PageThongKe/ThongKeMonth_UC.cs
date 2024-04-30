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
    public partial class ThongKeMonth_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongKeMonth_UC()
        {
            InitializeComponent();
        }

        private void txtTKTenSP_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }
    }
}
