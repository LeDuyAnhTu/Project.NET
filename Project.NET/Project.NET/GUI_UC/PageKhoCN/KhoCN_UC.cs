using BUS;
using DevExpress.Data.Linq.Helpers;
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

namespace Project.NET.GUI_UC.PageKho
{
    public partial class KhoCN_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properties
        private KhuVuc_BUS db_KV = new KhuVuc_BUS();
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private SanPham_BUS db_SP = new SanPham_BUS();
        private KhoCN_BUS db_Kho = new KhoCN_BUS();

        //Constructor
        public KhoCN_UC()
        {
            InitializeComponent();
        }

        //Methods
        public void taiForm()
        {
            //
            //Danh sách các khu vực
            //
            cboKhuVuc.Properties.DataSource = db_KV.LayDanhSach();
            cboKhuVuc.Properties.ValueMember = "maKV";
            cboKhuVuc.Properties.DisplayMember = "tenKV";
            cboKhuVuc.ItemIndex = 0;

            //
            //Danh sách sản phẩm
            //
            cboSanPham.Properties.DataSource = db_SP.LayDanhSach();
            cboSanPham.Properties.ValueMember = "MãSố";
            cboSanPham.Properties.DisplayMember = "TênSảnPhẩm";
            cboSanPham.ItemIndex = 0;

            //
            //Tạo thao tác ban đầu
            //
            dangThaoTac(false);

            //
            //Số lượng mặc định
            //
            txtSoLuong.Text = "0";

            //
            //Danh sách các sản phẩm trong kho
            //
            dgvKho.DataSource = db_Kho.LayDanhSach_TheoCN(cboChiNhanh.EditValue.ToString().Trim());

        }
        private void dangThaoTac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }
        private KhoCN_DTO layDuLieu()
        {
            KhoCN_DTO kho = null;
            try
            { 
                kho = new KhoCN_DTO(cboChiNhanh.EditValue.ToString().Trim(), cboSanPham.EditValue.ToString().Trim(), Convert.ToInt32(txtSoLuong.Text));
                return kho;
            }
            catch(Exception ex){
                throw ex;
            }
        }

        //Events
        private void Kho_UC_Load(object sender, EventArgs e)
        {
            //Tải dữ liệu lên form
            taiForm();
        }

        private void cboKhuVuc_EditValueChanged(object sender, EventArgs e)
        {
            //
            //Danh sách chi nhánh theo khu vực
            //
            cboChiNhanh.Properties.DataSource = db_CN.LayDanhSach_TheoKV(cboKhuVuc.EditValue.ToString());
            cboChiNhanh.Properties.ValueMember = "maCN";
            cboChiNhanh.Properties.DisplayMember = "tenCN";
            cboChiNhanh.ItemIndex = 0;
        }

        private void cboChiNhanh_EditValueChanged(object sender, EventArgs e)
        {
            //
            //Danh sách các sản phẩm trong kho
            //
            dgvKho.DataSource = db_Kho.LayDanhSach_TheoCN(cboChiNhanh.EditValue.ToString().Trim());
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //ChiNhánh = cn.tenCN,
            //                SảnPhẩm = sp.tenSP,
            //                SốLượng = kho.soLuong,
            int[] dong = gridView1.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    //Lấy sản phẩm được chọn
                    try
                    {
                        int count = 0;
                        while (count < db_SP.LayDanhSach().Count())
                        {
                            cboSanPham.ItemIndex = count;
                            if (cboSanPham.Text == gridView1.GetRowCellValue(i, "SảnPhẩm").ToString())
                                break;
                            count++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    txtSoLuong.Text = gridView1.GetRowCellValue(i, "SốLượng").ToString();
                }
            }
            dangThaoTac(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhoCN_DTO temp = layDuLieu();
                db_Kho.Them(temp);
                MessageBox.Show("Thêm thông tin thành công", "Thông báo");
                taiForm();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn xóa thông tin trên", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(re == DialogResult.Yes)
            {
                try
                {
                    db_Kho.Xoa(cboChiNhanh.EditValue.ToString().Trim(),cboSanPham.EditValue.ToString().Trim());
                    MessageBox.Show("Xóa thông tin thành công", "Thông báo");
                    taiForm();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            taiForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                KhoCN_DTO temp = layDuLieu();
                db_Kho.Sua(temp);
                MessageBox.Show("Sửa thông tin thành công", "Thông báo");
                taiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
