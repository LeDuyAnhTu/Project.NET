using BUS;
using DevExpress.XtraEditors;
using DTO;
using Project.NET.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC
{
    public partial class CaLam_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properties
        private CaLam_BUS db_CL = new CaLam_BUS();

        //Constructors
        public CaLam_UC()
        {
            InitializeComponent();
        }

        //Methods
        /// <summary>
        /// tải lại danh sách và xóa dữ liệu trên các field
        /// </summary>
        public void loadForm()
        {
            //
            //Tạo mã ca mới
            //
            taoIDMoi();

            //
            //danh sách các ca làm hiện có
            //
            dgvPhanCongCaLamNhanVien.DataSource = db_CL.LayDanhSach();

            //
            //Tên ca
            //
            txtTenCaLam.Text = "";

            //
            //Giờ vào ca
            //
            txtGioBD.EditValue = new DateTime(1, 1, 1, 5, 0, 0);

            //
            //Giờ tan ca
            //
            txtGioKT.EditValue = new DateTime(1, 1, 1, 12, 0, 0);

            //
            //Tạo thao tác ban đầu
            //
            dangThaotac(false);
        }
        /// <summary>
        /// Chuyển các dữ liệu trên form thành đối tượng CaLam_DTO
        /// </summary>
        /// <returns></returns>
        public CaLam_DTO layDuLieu()
        {
            try
            {
                return new CaLam_DTO(
                    txtMaCaLam.Text
                    , txtTenCaLam.Text
                    , Convert.ToDateTime(txtGioBD.EditValue).ToShortTimeString()
                    , Convert.ToDateTime(txtGioKT.EditValue).ToShortTimeString()
                    );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Gắn mã ca mới vào field mã ca
        /// </summary>
        private void taoIDMoi()
        {
            txtMaCaLam.Text = db_CL.taoMaMoi();
        }
        private void dangThaotac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }

        //Events
        /// <summary>
        /// Khi tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaLam_UC_Load(object sender, EventArgs e)
        {
            //
            //Danh sách các ca làm
            //
            loadForm();
        }
        /// <summary>
        /// Thực hiện thêm ca làm mới vào database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CaLam_DTO cl_Moi = layDuLieu();
                if (db_CL.Them(cl_Moi))
                    MessageBox.Show("Thêm ca làm mới thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Hiển thị thông tin của ca làm lên các field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            int[] cacDong = gridView1.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtMaCaLam.Text = gridView1.GetRowCellValue(i, "maCa").ToString();
                    txtTenCaLam.Text = gridView1.GetRowCellValue(i, "tenCa").ToString();
                    txtGioBD.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(i, "gioBD").ToString());
                    txtGioKT.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(i, "gioKT").ToString());
                }
            }
            dangThaotac(true);
        }
        /// <summary>
        /// làm mới danh sách ca làm, tạo mã ca mới và xóa dữ liệu tên, giờ vào ca, giờ tan ca
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        /// <summary>
        /// Thực hiện sửa thông tin ca làm đang chọn dựa trên dữ liệu có trên các field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                CaLam_DTO cl_Moi = layDuLieu();
                if (db_CL.Sua(cl_Moi))
                    MessageBox.Show("Sửa thông tin ca làm thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Yêu cầu xác nhận, thực hiện xóa thông tin ca làm khi đã xác nhận
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult luaChon = MessageBox.Show("Bạn có muốn xóa ca làm " + txtMaCaLam.Text.Trim() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(luaChon == DialogResult.Yes)
                {
                    if (db_CL.Xoa(txtMaCaLam.Text))
                        MessageBox.Show("Xóa ca làm thành công !", "Thông báo");
                    loadForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTenCaLam_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }
    }
}
