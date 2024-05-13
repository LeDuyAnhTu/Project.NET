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

namespace Project.NET.GUI_UC.PageSanPham
{
    public partial class SanPham_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Fields
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

            //
            //Tạo thao tác ban đầu
            //
            dangThaoTac(false);

            //
            //Tên sản phẩm
            //
            txtTenSP.Text = "";
        }
        private void taoMaMoi()
        {
            txtMaSP.Text = db_SP.taoMaMoi();
        }
        private void dangThaoTac(bool check)
        {
            btnThem.Enabled = !check;
            btnCapNhat.Enabled = check;
            btnXoa.Enabled = check;
        }
        private SanPham_DTO layDuLieu()
        {
            try
            {
                SanPham_DTO temp = new SanPham_DTO(
                    txtMaSP.Text
                    , txtTenSP.Text
                    , Convert.ToDateTime(txtHSD.Text)
                    , Convert.ToInt32(txtDonGia.Text)
                    , Convert.ToInt32(txtSoLuongConLai.Text)
                    , cboMaLoaiSP.EditValue.ToString().Trim()
                    , cboMaNSX.EditValue.ToString().Trim());
                return temp;
            }catch(Exception ex)
            {
                throw ex;
            }
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

        private void txtSoLuongConLai_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }

        private void dgvSanPham_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] dong = dgvSanPham.GetSelectedRows();
            foreach(int i in dong)
            {
                if(i >= 0)
                {
                    try
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(dgvSanPham.GetRowCellValue(i, "MãSố").ToString().Trim());
                        txtTenSP.Text = sp.TenSP;
                        txtMaSP.Text = sp.MaSP;
                        txtHSD.Text = sp.HSD.ToShortDateString();
                        txtDonGia.Text = sp.DonGia.ToString();
                        txtSoLuongConLai.Text = sp.SoLuongConLai.ToString();
                        //Hiển thị loại của sản phẩm được chọn
                        try
                        {
                            int count = 0;
                            while (count < db_LSP.LayDanhSach().Count())
                            {
                                cboMaLoaiSP.ItemIndex = count;
                                if (cboMaLoaiSP.Text == dgvSanPham.GetRowCellValue(i, "Loại").ToString())
                                    break;
                                count++;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        //Hiển thị nhà sản xuất của sản phẩm được chọn
                        try
                        {
                            int count = 0;
                            while (count < db_NSX.LayDanhSach().Count())
                            {
                                cboMaNSX.ItemIndex = count;
                                if (cboMaNSX.Text == dgvSanPham.GetRowCellValue(i, "NSX").ToString())
                                    break;
                                count++;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    dangThaoTac(true);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham_DTO sp = layDuLieu();
                db_SP.Them(sp);
                MessageBox.Show("Thêm sản phẩm mới thành công !", "Thông báo");
                taiForm();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham_DTO sp = layDuLieu();
                db_SP.Sua(sp);
                MessageBox.Show("Sửa thông tin sản phẩm thành công !", "Thông báo");
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
                SanPham_DTO sp = layDuLieu();
                DialogResult re = MessageBox.Show("Bạn có muốn xóa thông tin sản phẩm " + sp.TenSP + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    db_SP.Xoa(sp.MaSP);
                    MessageBox.Show("Thêm sản phẩm mới thành công !", "Thông báo");
                    taiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
