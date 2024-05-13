using BUS;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageNhanVien
{
    public partial class ViTriChucVuNV_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Fields
        private ViTri_BUS db_VT = new ViTri_BUS();

        //Constructor
        public ViTriChucVuNV_UC()
        {
            InitializeComponent();
        }

        //Methods
        /// <summary>
        /// Tải dữ liệu lên form
        /// </summary>
        public void taiForm()
        {
            dgvGrid.DataSource = db_VT.LayDanhSach();
            txtMaVT.Text = db_VT.taoMaMoi();
            txtTenVT.Text = string.Empty;
            dangThaoTac(false);
        }
        /// <summary>
        /// Lấy dữ liệu trên các field
        /// </summary>
        /// <returns></returns>
        public ViTri_DTO layDuLieu()
        {
            ViTri_DTO viTri = null;
            try
            {
                string maVT = txtMaVT.Text.Replace("_", "");
                string tenVT = txtTenVT.Text.Replace("_", "");
                viTri = new ViTri_DTO(maVT, txtTenVT.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }
            return viTri;
        }
        /// <summary>
        /// Mở các nút tùy vào thao tác
        /// true: đang chỉnh sửa, mở nút Cập nhật và nút Xóa, đóng nút Thêm
        /// false: đang thêm, mở nút Thêm, đóng nút Cập nhật và nút Xóa
        /// </summary>
        /// <param name="check"></param>
        private void dangThaoTac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }

        //Events
        private void ViTriChucVuNV_UC_Load(object sender, EventArgs e)
        {
            txtMaVT.Text = db_VT.taoMaMoi();
            dgvGrid.DataSource = db_VT.LayDanhSach();
            dangThaoTac(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu
            ViTri_DTO viTri_Them = layDuLieu();

            //Kiểm tra dữ liệu vừa lấy
            if(viTri_Them != null)
            {
                try
                {
                    //Thêm vị trí mới vào hệ thống
                    db_VT.Them(viTri_Them);

                    //Thông báo thành công
                    MessageBox.Show("Thêm vị trí làm việc mới thành công !", "Thông báo");

                    //Tải lại form
                    taiForm();
                }catch(Exception ex)
                {
                    //Hiển thị thông báo lỗi
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void dgvViTri_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] cacDong = dgvViTri.GetSelectedRows();
            foreach (int i in cacDong)
            {
                if (i >= 0)
                {
                    txtMaVT.Text = dgvViTri.GetRowCellValue(i, "MãSố").ToString();
                    txtTenVT.Text = dgvViTri.GetRowCellValue(i, "TênVịTrí").ToString();
                }
            }
            dangThaoTac(true);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu
            ViTri_DTO viTri_Them = layDuLieu();

            //Kiểm tra dữ liệu vừa lấy
            if (viTri_Them != null)
            {
                try
                {
                    //Sửa thông tin vị trí trong hệ thống
                    db_VT.Sua(viTri_Them);

                    //Thông báo thành công
                    MessageBox.Show("Sửa thông tin vị trí làm việc thành công !", "Thông báo");

                    //Tải lại form
                    taiForm();

                    //Hủy thao tác
                    dangThaoTac(false);
                }
                catch (Exception ex)
                {
                    //Hiển thị thông báo lỗi
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            //Hủy thao tác
            dangThaoTac(false);

            //Tải lại form
            taiForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa vị trí " + txtTenVT.Text.Trim() + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    string maVT = txtMaVT.Text.Replace("_", "");
                    if (db_VT.Xoa(maVT))
                    {
                        MessageBox.Show("Xóa vị trí thành công", "Thông báo");
                        taiForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Lỗi");
                }
            }
        }
    }
}
