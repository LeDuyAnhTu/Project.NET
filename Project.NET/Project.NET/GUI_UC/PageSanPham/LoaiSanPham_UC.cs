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

namespace Project.NET.GUI_UC.PageSanPham
{
    public partial class LoaiSanPham_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Fields
        private LoaiSP_BUS db_Loai = new LoaiSP_BUS();

        //Constructor
        public LoaiSanPham_UC()
        {
            InitializeComponent();
        }

        //Methods
        /// <summary>
        /// Hàm tải lại dữ liệu
        /// </summary>
        public void taiForm()
        {
            //
            //Tạo mã mới
            //
            txtMaLoaiSP.Text = db_Loai.taoMaMoi();

            //
            //Tải dữ liệu danh sách các loại
            //
            dgvGrid.DataSource = db_Loai.LayDanhSach();
           
            //
            //Khởi tạo thao tác
            //
            dangThaoTac(false);
        }
        private void dangThaoTac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }

        //Events
        private void txtTenLoaiSP_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }

        private void LoaiSanPham_UC_Load(object sender, EventArgs e)
        {
            //Tải dữ liệu khi tải user control
            taiForm();
        }

        private void dgvLoaiSanPham_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                int[] cacDong = dgvLoaiSanPham.GetSelectedRows();
                foreach (int i in cacDong)
                {
                    if (i >= 0)
                    {
                        txtMaLoaiSP.Text = dgvLoaiSanPham.GetRowCellValue(i, "MaLoai").ToString();
                        txtTenLoaiSP.Text = dgvLoaiSanPham.GetRowCellValue(i, "TenLoai").ToString();
                    }
                }
                dangThaoTac(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private LoaiSP_DTO layDuLieu()
        {
            try
            {
                LoaiSP_DTO temp = new LoaiSP_DTO(
                    txtMaLoaiSP.Text
                    , txtTenLoaiSP.Text);
                return temp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSP_DTO sp = layDuLieu();
                db_Loai.Them(sp);
                MessageBox.Show("Thêm loại sản phẩm mới thành công!", "Thông báo");
                taiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSP_DTO sp = layDuLieu();
                db_Loai.Sua(sp);
                MessageBox.Show("Sửa thông tin loại sản phẩm thành công !", "Thông báo");
                taiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiSP_DTO loaiSP = layDuLieu();
                DialogResult re = MessageBox.Show("Bạn có muốn xóa thông tin loại sản phẩm " + loaiSP.TenLoai + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    db_Loai.Xoa(loaiSP.MaLoai);
                    MessageBox.Show("Xóa loại sản phẩm thành công!", "Thông báo");
                    taiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            taiForm();
            dangThaoTac(false);
        }

        private void dgvGrid_Click(object sender, EventArgs e)
        {
            int[] dong = dgvLoaiSanPham.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        LoaiSP_DTO km = db_Loai.timLoaiSP_MaLoaiSP(dgvLoaiSanPham.GetRowCellValue(i, "MãSố").ToString().Trim());
                        txtMaLoaiSP.Text = km.MaLoai;
                        txtTenLoaiSP.Text = km.TenLoai;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    dangThaoTac(true);
                }
            }
        }
    }
}
