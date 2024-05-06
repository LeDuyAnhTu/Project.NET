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

namespace Project.NET.GUI_UC.PageBanHang
{
    public partial class BanHang_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public BanHang_UC()
        {
            InitializeComponent();
            txtMaHD.Text = "a@12323123";
            txtNgayLapHD.Text = DateTime.Now.ToShortDateString();
            txtMaSP.Text = "a@12323123";
            txtDiemTichLuy.Text = "12312123123";
            txtSoLuongTonKho.Text = "12312";
            txtSoLuongMua.Text = "123123";
            txtTenSP.Text = "Sản phẩm 001";
            txtNhanVienTrucQuay.Text = "Sok Kim Thanh";
            txtDiemDung.Text = "90000";
            cboKhachHang.Text = "Lê Duy Anh Tú";
            cboMaLoaiSP.Text = "loại đồ ăn cao cấp";
            cboKhuyenMai.Text = "Khuyễn mãi 50%";

        }

        private void txtSoLuongConLai_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }

        private void txtDiemDung_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }

        private void txtSoLuongMua_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }
    }
}
