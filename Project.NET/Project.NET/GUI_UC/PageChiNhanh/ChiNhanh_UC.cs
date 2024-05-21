using BUS;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DTO;
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
        

        private void dgvChiNhanh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] cacDong = dgvChiNhanh.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtMaCN.EditValue = dgvChiNhanh.GetRowCellValue(i, "MãChiNhánh").ToString();
                    txtTenCN.EditValue = dgvChiNhanh.GetRowCellValue(i, "TênChiNhánh").ToString();
                    txtDiaChi.EditValue = dgvChiNhanh.GetRowCellValue(i, "ĐịaChỉ").ToString();

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
            dangThaoTac(true);
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
            cboKhuVuc.Properties.DataSource = db_KV.LayDanhSach();
            cboKhuVuc.Properties.DisplayMember = "tenKV";
            cboKhuVuc.Properties.ValueMember = "maKV";
            cboKhuVuc.ItemIndex = 0;
        }
        private ChiNhanh_DTO layDuLieu()
        {
            try
            {
                return new ChiNhanh_DTO(
                    txtMaCN.Text
                    , txtTenCN.Text.Trim()
                    , txtDiaChi.Text.Trim()
                    , cboKhuVuc.EditValue.ToString().Trim()
                    , cboNhanVien.EditValue.ToString().Trim()
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void loadForm()
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
            cboKhuVuc.Properties.DataSource = db_KV.LayDanhSach();
            cboKhuVuc.Properties.DisplayMember = "tenKV";
            cboKhuVuc.Properties.ValueMember = "maKV";
            cboKhuVuc.ItemIndex = 0;

            //
            //Khởi tạo dữ liệu cho các field
            //
            txtDiaChi.Text = "";
            txtTenCN.Text = "";
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
        /// Thực hiện thêm chi nhánh dựa theo dữ liệu đã nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ChiNhanh_DTO CN_Moi = layDuLieu();
                if (db_CN.Them(CN_Moi))
                    MessageBox.Show("Thêm chi nhánh mới thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thực hiện sửa thông tin của chi nhánh đang chọn dựa theo dữ liệu vừa sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                ChiNhanh_DTO CN_Moi = layDuLieu();
                if (db_CN.Sua(CN_Moi))
                    MessageBox.Show("Sửa thông tin chi nhánh thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thực hiện xóa thông tin chi nhánh đang chọn và tài khoản của họ trong hệ thống
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult luaChon = MessageBox.Show("Bạn có muốn xóa nhân viên " + txtMaCN.Text.Trim() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (luaChon == DialogResult.Yes)
                {
                    if (db_CN.Xoa(txtMaCN.Text))
                        MessageBox.Show("Xóa thông tin chi nhánh thành công !", "Thông báo");
                    loadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
