using BUS;
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

namespace Project.NET.GUI_UC.PageSanPham
{
    public partial class SanPham_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properties
        private SanPham_BUS db_SP = new SanPham_BUS();
        private LoaiSP_BUS db_LSP = new LoaiSP_BUS();
        private NhaSanXuat_BUS db_NSX = new NhaSanXuat_BUS();

        //Constructor
        public SanPham_UC()
        {
            InitializeComponent();
        }

        //Methods
        public void taiForm()
        {
            //
            //Tạo mã mới
            //
            taoMaMoi();

            //
            //Danh sách loại sản phẩm
            //
            cboMaLoaiSP.Properties.DataSource = db_LSP.LayDanhSach();
            cboMaLoaiSP.Properties.DisplayMember = "TênLoại";
            cboMaLoaiSP.Properties.ValueMember = "MãLoại";
            cboMaLoaiSP.ItemIndex = 0;

            //
            //Danh sách nhà sản xuất
            //
            cboMaNSX.Properties.DataSource = db_NSX.LayDanhSach_Combobox();
            cboMaNSX.Properties.DisplayMember = "Tên";
            cboMaNSX.Properties.ValueMember = "MãSố";
            cboMaNSX.ItemIndex = 0;

            //
            //Hạn sử dụng tối thiểu
            //
            txtHSD.Properties.MinValue = DateTime.Now;
            txtHSD.EditValue = DateTime.Now;

            //
            //Số lượng còn lại tối thiểu
            //
            txtSoLuongConLai.EditValue = 0;

            //
            //Đơn giá tối thiểu
            //
            txtDonGia.Properties.Increment = 200;
            txtDonGia.EditValue = 1000;

            //
            //Danh sách sản phẩm
            //
            dgvGrid.DataSource = db_SP.LayDanhSach();
        }
        private void taoMaMoi()
        {
            txtMaSP.Text = db_SP.taoMaMoi();
        }

        //Events
        private void txtTenSP_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }

        private void SanPham_UC_Load(object sender, EventArgs e)
        {
            taiForm();
        }
    }
}
