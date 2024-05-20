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

namespace Project.NET.GUI_UC.PageKhuyenMai
{
    public partial class KhuyenMai_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public KhuyenMai_UC()
        {
            InitializeComponent();
            txtGhiChu.Properties.LinesCount = 0;
        }

        private void txtGhiChu_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportVietnamese(30);
        }
        //Fields
        KhuyenMai_BUS db_KM = new KhuyenMai_BUS();


        //Methods
        public void taiForm()
        {
            //
            //Tạo mã mới
            //
            taoMaMoi();
            //
            //Danh sách khuyến mãi
            //
            dgvGrid.DataSource = db_KM.LayDanhSach();

            //
            //Tạo thao tác ban đầu
            //
            dangThaoTac(false);

            //
            // Ghi chú
            //
            txtGhiChu.Text = "";
        }
        private void taoMaMoi()
        {
            txtMaKM.Text = db_KM.taoMaMoi();
        }
        private void dangThaoTac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }
        private KhuyenMai_DTO layDuLieu()
        {
            try
            {
                KhuyenMai_DTO temp = new KhuyenMai_DTO(
                    txtMaKM.Text
                    , txtGhiChu.Text);
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
                KhuyenMai_DTO sp = layDuLieu();
                db_KM.Them(sp);
                MessageBox.Show("Thêm khuyến mãi mới thành công !", "Thông báo");
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
                KhuyenMai_DTO sp = layDuLieu();
                db_KM.Sua(sp);
                MessageBox.Show("Sửa thông tin khuyến mãi thành công !", "Thông báo");
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
                KhuyenMai_DTO km = layDuLieu();
                DialogResult re = MessageBox.Show("Bạn có muốn xóa thông tin khuyến mãi " + km.MaKM + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    db_KM.Xoa(km.MaKM);
                    MessageBox.Show("Xóa khuyến mãi mới thành công !", "Thông báo");
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

        private void dgvKhuyenMai_Click(object sender, EventArgs e)
        {
            int[] dong = dgvKhuyenMai.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        KhuyenMai_DTO km = db_KM.timKhuyenMai_MaKM(dgvKhuyenMai.GetRowCellValue(i, "MãSố").ToString().Trim());
                        txtGhiChu.Text = km.GhiChu;
                        txtMaKM.Text = km.MaKM;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    dangThaoTac(true);
                }
            }
        }

        private void KhuyenMai_UC_Load(object sender, EventArgs e)
        {
            taiForm();
        }
    }
}
