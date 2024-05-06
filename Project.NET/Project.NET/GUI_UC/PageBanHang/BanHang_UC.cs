using BUS;
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

namespace Project.NET.GUI_UC.PageBanHang
{
    public partial class BanHang_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properties
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private HoaDon_BUS db_HD = new HoaDon_BUS();
        private KhachHang_BUS db_KH = new KhachHang_BUS();
        private SanPham_BUS db_SP = new SanPham_BUS();
        private LoaiSP_BUS db_LSP = new LoaiSP_BUS();
        List<SanPhamMua_DTO> dsMuaHang = new List<SanPhamMua_DTO>();

        //Constructor
        public BanHang_UC()
        {
            InitializeComponent();
        }

        //Methods
        public void taiForm()
        {
            //
            //Hiển thị tên nhân viên trực quầy
            //
            NhanVien_DTO nv_TrucQuay = db_NV.timTheoMa(frmMain.maNV);
            txtNhanVienTrucQuay.Text = nv_TrucQuay.TenNV;

            //
            //Mã hóa đơn mới
            //
            taoMaMoi();

            //
            //Ngày lập hóa đơn
            //
            txtNgayLapHD.Text = DateTime.Now.ToShortDateString();

            //
            //Danh sách khách hàng
            //
            cboKhachHang.Properties.DataSource = db_KH.LayDanhSach_Combobox();
            cboKhachHang.Properties.DisplayMember = "HọTên";
            cboKhachHang.Properties.ValueMember = "Mã";
            cboKhachHang.ItemIndex = 0;

            //
            //Điểm tích lũy
            //
            KhachHang_DTO kh = db_KH.timKH_TheoMa(cboKhachHang.EditValue.ToString().Trim());
            txtDiemTichLuy.Text = kh.DiemTichLuy.ToString();

            //
            //Danh sách loại sản phẩm
            //
            cboMaLoaiSP.Properties.DataSource = db_LSP.LayDanhSach();
            cboMaLoaiSP.Properties.DisplayMember = "TênLoại";
            cboMaLoaiSP.Properties.ValueMember = "MãLoại";
            cboMaLoaiSP.ItemIndex = 0;

            //
            //Danh sách sản phẩm
            //
            dgvSanPhamGrid.DataSource = db_SP.LayDanhSach();
            SanPham_DTO sp = db_SP.timSanPham_MaSP(dgvSanPham.GetRowCellValue(0, "MãSố").ToString().Trim());
            txtMaSP.Text = sp.MaSP;
            txtTenSP.Text = sp.TenSP;
            txtSoLuongTonKho.Text = sp.SoLuongConLai.ToString().Trim();

            //
            //Số lượng mua
            //
            txtSoLuongMua.Text = "1";

            //
            //Thành tiền
            //
            txtThanhTien1.Text = "0";

            //
            //Tổng tiền
            //
            txtTongTien.Text = "0";


        }
        public void taoMaMoi()
        {
            txtMaHD.Text = db_HD.taoMaMoi();
        }
        public void dangLua(bool check)
        {
            btnChon.Enabled = check;
            btnHuyChon.Enabled = !check;
            btnSua.Enabled = !check;
        }

        //Events
        private void txtSoLuongConLai_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }

        private void txtDiemDung_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }

        private void txtSoLuongMua_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit editText = sender as TextEdit;
            editText.SupportNumeric();
        }

        private void BanHang_UC_Load(object sender, EventArgs e)
        {
            taiForm();
        }

        private void dgvSanPham_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] dong= dgvSanPham.GetSelectedRows();
            foreach(int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(dgvSanPham.GetRowCellValue(i, "MãSố").ToString().Trim());
                        txtMaSP.Text = sp.MaSP;
                        txtTenSP.Text = sp.TenSP;
                        txtSoLuongTonKho.Text = sp.SoLuongConLai.ToString().Trim();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
            //
            //Số lượng mua
            //
            txtSoLuongMua.Text = "1";
            dangLua(true);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuongMua.Text != "" && txtSoLuongTonKho.Text != "")
                {
                    int sl_Mua = Convert.ToInt32(txtSoLuongMua.Text);
                    int sl_Ton = Convert.ToInt32(txtSoLuongTonKho.Text);
                    if(sl_Mua <= 0)
                    {
                        txtSoLuongMua.Text = "0";
                        throw new Exception("Số lượng mua ít nhất là 1");
                    }
                    if (sl_Mua > sl_Ton)
                    {
                        txtSoLuongMua.Text = "0";
                        throw new Exception("Số lượng tồn kho không đủ");
                    }
                }
                SanPhamMua_DTO sp_ChonMua = new SanPhamMua_DTO(txtMaSP.Text, txtTenSP.Text, Convert.ToInt32(txtSoLuongMua.Text));
                dsMuaHang.Add(sp_ChonMua);
                dgvGioHangGrid.DataSource = null;
                dgvGioHangGrid.DataSource = dsMuaHang;
                dgvGioHang.Columns["MaSP"].Caption = "Mã";
                dgvGioHang.Columns["TenSP"].Caption = "Tên sản phẩm";
                dgvGioHang.Columns["SoLuong"].Caption = "Số lượng mua";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvGioHang_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                if (dsMuaHang.Count > 0)
                {
                    int tongTien = 0;
                    foreach (SanPhamMua_DTO item in dsMuaHang)
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(item.MaSP);
                        tongTien += sp.DonGia * item.SoLuong;
                    }
                    txtTongTien.Text = tongTien.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
    }
}
