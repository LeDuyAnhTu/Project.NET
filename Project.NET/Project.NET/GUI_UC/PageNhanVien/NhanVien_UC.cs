using BUS;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
        //Properies
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private ViTri_BUS db_VT = new ViTri_BUS();

        //Constructor
        public NhanVien_UC()
        {
            InitializeComponent(); 
        }

        //Methods
        public void taoIDMoi()
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
                    , txtGioiTinh.Properties.Items[txtGioiTinh.SelectedIndex].Description
                    , txtNgaySinh.DateTime
                    , txtSoDienThoai.Text.Length > 0 ? txtSoDienThoai.Text : null
                    , txtCCCD.Text
                    , Convert.ToInt32(txtLuongNV.Value)
                    , cboViTriChucVuNhanVien.EditValue.ToString().Trim()
                    , cboChiNhanh.EditValue.ToString().Trim());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void loadForm()
        {
            //Tạo ID cho nhân viên mới
            taoIDMoi();

            //
            //Xóa dữ liệu trên các field
            //
            txtHoTen.Text = "";
            txtCCCD.Text = "";
            txtSoDienThoai.Text = "";
            txtNgaySinh.DateTime = txtNgaySinh.Properties.MaxValue;


            //
            //dgvNhanVien 
            //
            dgvControl.DataSource = db_NV.LayDanhSach();

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
            cboViTriChucVuNhanVien.Properties.ValueMember = "MãSố";
            cboViTriChucVuNhanVien.Properties.DisplayMember = "TênVịTrí";
            cboViTriChucVuNhanVien.ItemIndex = 1; //Chọn vị trí mặc định

            //
            //Mức lương
            //
            txtLuongNV.Value = 4000000;

        }

        //Events
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
            //Danh sách nhân viên
            //
            dgvControl.DataSource = db_NV.LayDanhSach();

            //
            //Chi nhánh
            //
            cboChiNhanh.Properties.DataSource = db_CN.LayDanhSach();
            cboChiNhanh.Properties.ValueMember = "maCN";
            cboChiNhanh.Properties.DisplayMember = "tenCN";
            cboChiNhanh.ItemIndex = 0; //Chọn chi nhánh mặc định

            //
            //Vị trí
            //
            cboViTriChucVuNhanVien.Properties.DataSource = db_VT.LayDanhSach();
            cboViTriChucVuNhanVien.Properties.ValueMember = "MãSố";
            cboViTriChucVuNhanVien.Properties.DisplayMember = "TênVịTrí";
            cboViTriChucVuNhanVien.ItemIndex = 1; //Chọn vị trí mặc định

            //
            //Mức lương
            //
            txtLuongNV.Properties.MinValue = 4000000;
            txtLuongNV.Properties.Increment = 500000;
            txtLuongNV.Value = 4000000;

            //
            //Ngày sinh
            //
            txtNgaySinh.DateTime = DateTime.Now.AddYears(-18);
            txtNgaySinh.Properties.MaxValue = DateTime.Now.AddYears(-18);

            //
            //Giới tính
            //
            txtGioiTinh.SelectedIndex = 0;
        }
        /// <summary>
        /// Click vào danh sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            int[] cacDong = dgvNhanVien.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtMaNV.Text = dgvNhanVien.GetRowCellValue(i, "maNV").ToString();
                    txtHoTen.Text = dgvNhanVien.GetRowCellValue(i, "tenNV").ToString();
                    txtGioiTinh.SelectedIndex = txtGioiTinh.Properties.Items[0].Description == dgvNhanVien.GetRowCellValue(i, "gioiTinh").ToString() ? 0 : 1;
                    txtCCCD.Text = dgvNhanVien.GetRowCellValue(i, "CCCD").ToString();
                    txtLuongNV.Text = dgvNhanVien.GetRowCellValue(i, "luong").ToString();

                    txtSoDienThoai.Text = Convert.ToString(dgvNhanVien.GetRowCellValue(i, "SDT"));

                    txtNgaySinh.Text = Convert.ToDateTime(dgvNhanVien.GetRowCellValue(i, "ngaySinh").ToString()).ToShortDateString();

                    //Lấy chi nhánh của nhân viên đang chọn
                    try
                    {
                        int count = 0;
                        while (count < db_CN.LayDanhSach().Count())
                        {
                            cboChiNhanh.ItemIndex = count;
                            if (cboChiNhanh.Text == dgvNhanVien.GetRowCellValue(i, "tenCN").ToString())
                                break;
                            count++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //Lấy vị trí làm việc của nhân viên đang chọn
                    try
                    {
                        int count = 0;
                        while (count < db_VT.LayDanhSach().Count())
                        {
                            cboViTriChucVuNhanVien.ItemIndex = count;
                            if (cboViTriChucVuNhanVien.Text == dgvNhanVien.GetRowCellValue(i, "tenVT").ToString())
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
        /// <summary>
        /// Nút làm mới danh sách dữ liệu đã nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        /// <summary>
        /// Thực hiện thêm nhân viên dựa theo dữ liệu đã nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien_DTO nv_Moi = layDuLieu();
                if (db_NV.Them(nv_Moi))
                    MessageBox.Show("Thêm nhân viên mới thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thực hiện sửa thông tin của nhân viên đang chọn dựa theo dữ liệu vừa sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien_DTO nv_Moi = layDuLieu();
                if (db_NV.Sua(nv_Moi))
                    MessageBox.Show("Sửa thông tin nhân viên thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thực hiện xóa thông tin nhân viên đang chọn và tài khoản của họ trong hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult luaChon = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtMaNV.Text.Trim() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (luaChon == DialogResult.Yes)
                {
                    if (db_NV.Xoa(txtMaNV.Text))
                        MessageBox.Show("Xóa thông tin nhân viên thành công !", "Thông báo");
                    loadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        private void txtHoTen_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese();
        }

        private void txtGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
