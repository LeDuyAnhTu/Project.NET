using BUS;
using DevExpress.Data.Linq.Helpers;
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

namespace Project.NET.GUI_UC.PageChiNhanh
{
    public partial class ChiNhanh_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Fields
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private KhuVuc_BUS db_KV = new KhuVuc_BUS();
        private NhanVien_BUS db_NV = new NhanVien_BUS();

        //Constructor
        public ChiNhanh_UC()
        {
            InitializeComponent();
        }

        //Methods
        public void taoIDMoi()
        {
            txtMaCN.Text = db_CN.taoMaMoi();
        }
        public void dangThaoTac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }

        //Events
        private void txtTenCN_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese();
        }

        private void txtDiaChi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese();
        }

        private void txtMaCN_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportID();
        }

        private void dgvChiNhanh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] cacDong = dgvChiNhanh.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtMaCN.Text = dgvChiNhanh.GetRowCellValue(i, "MãChiNhánh").ToString();
                    txtTenCN.Text = dgvChiNhanh.GetRowCellValue(i, "TênChiNhánh").ToString();
                    txtDiaChi.Text = dgvChiNhanh.GetRowCellValue(i, "ĐịaChỉ").ToString();
                    //Lấy người quản lý của chi nhánh đã chọn
                    try
                    {
                        int count = 0;
                        while (count < db_NV.LayDanhSach().Count())
                        {
                            cboNhanVien.ItemIndex = count;
                            if (cboNhanVien.Text == dgvChiNhanh.GetRowCellValue(i, "QuảnLý").ToString())
                                break;
                            count++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //Lấy tên khu vực của chi nhánh được chọn
                    try
                    {
                        int count = 0;
                        while (count < db_KV.LayDanhSach().Count())
                        {
                            cboKhuVuc.ItemIndex = count;
                            if (cboKhuVuc.Text == dgvChiNhanh.GetRowCellValue(i, "KhuVực").ToString())
                                break;
                            count++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ChiNhanh_UC_Load(object sender, EventArgs e)
        {
            //
            //Tạo mã chi nhánh mới
            //
            taoIDMoi();

            //
            //Chỉnh trạng thái thao tác
            //
            dangThaoTac(false);

            //
            //Hiển thị danh sách các chi nhánh
            //
            dgvGrid.DataSource = db_CN.LayDanhSach();

            //
            //Hiển thị danh sách các quản lý
            //
            cboNhanVien.Properties.DataSource = db_NV.LayDanhSach_ViTri("VT01");
            cboNhanVien.Properties.DisplayMember = "tenNV";
            cboNhanVien.Properties.ValueMember = "maNV";
            cboNhanVien.ItemIndex = 0;

            //
            //Hiển thị danh sách các khu vực
            //

        }
    }
}
