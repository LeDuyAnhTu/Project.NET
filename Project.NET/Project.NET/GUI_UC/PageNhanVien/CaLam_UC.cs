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
    public partial class CaLam_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public CaLam_UC()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ten ca lam" + txtTenCaLam.Text +"Gio bat dau" + txtGioBD.Text +"Gio ket thuc"+txtGioKT.Text);
        }

        private void txtTenCaLam_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }
    }
}
