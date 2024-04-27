using BUS;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DTO;
using Project.NET.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.Forms
{
    public partial class NhanVien_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //
        //Properies
        //
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private ViTri_BUS db_VT = new ViTri_BUS();

        //
        //Constructor
        //
        public NhanVien_UC()
        {
            InitializeComponent(); 
        }

        //
        //Methods
        //
        private void taoIDMoi()
        {
            txtMaNV.Text = db_NV.taoMaMoi();
        }
        private NhanVien_DTO layDuLieu()
        {
            try
            {
                return new NhanVien_DTO(
                    txtMaNV.Text
                    , txtHoTen.Text
                    , txtGioiTinh.Text
                    , txtNgaySinh.DateTime
                    , txtSoDienThoai.Text, txtCCCD.Text
                    , Convert.ToInt32(txtLuongNV.Value)
                    , cboChiNhanh.SelectedText
                    , cboChiNhanh.SelectedText) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        //
        //Events
        //
        /// <summary>
        /// Khi tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NhanVien_UC_Load(object sender, EventArgs e)
        {
            //Tạo ID cho nhân viên mới
            taoIDMoi();

            //
            //dgvNhanVien 
            //
            dgvNhanVien.DataSource = db_NV.LayDanhSach();

            //
            //Combobox chi nhánh
            //
            cboChiNhanh.Properties.DataSource = db_CN.LayDanhSach();
            cboChiNhanh.Properties.ValueMember = "maCN";
            cboChiNhanh.Properties.DisplayMember = "tenCN";
            cboChiNhanh.ItemIndex = 0; //Chọn chi nhánh mặc định
            //
            //Combobox vị trí
            //
            cboViTriChucVuNhanVien.Properties.DataSource = db_VT.LayDanhSach();
            cboViTriChucVuNhanVien.Properties.ValueMember = "maVT";
            cboViTriChucVuNhanVien.Properties.DisplayMember = "tenVT";
            cboViTriChucVuNhanVien.ItemIndex = 1; //Chọn vị trí mặc định

            //
            //Mức lương
            //
            txtLuongNV.Properties.MinValue = 4000000;
            txtLuongNV.Properties.Increment = 500000;

            //
            //Ngày sinh
            //
            txtNgaySinh.DateTime = DateTime.Now.AddYears(-18);
            txtNgaySinh.Properties.MaxValue = DateTime.Now.AddYears(-18);
        }

        /// <summary>
        /// Click vào danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_Click(object sender, EventArgs e)
        {
            int[] cacDong = gridView1.GetSelectedRows();
            foreach (int i in cacDong)
            {
                DataRow data = gridView1.GetDataRow(i);
                MessageBox.Show(data.ToString());
            }
        }
         
        private void txtHoTen_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese(30);
        }
    }
}
