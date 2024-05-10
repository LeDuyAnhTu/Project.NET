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
        private ChiTietHD_BUS db_ct_HD = new ChiTietHD_BUS();
        List<SanPhamMua_DTO> dsMuaHang = new List<SanPhamMua_DTO>();
        private string maLoai_DangLoc = "";

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
            //Điểm dùng
            //
            txtDiemDung.Text = "0";

            //
            //Thành tiền
            //
            txtThanhTien1.Text = "0";

            //
            //Tổng tiền
            //
            txtTongTien.Text = "0";

            //
            //Tạo thao tác ban đầu
            //
            dangLua(true);
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
        public void capNhatGioHang()
        {
            int diemDung = Convert.ToInt32(txtDiemDung.Text);
            int diemTichLuy = Convert.ToInt32(txtDiemTichLuy.Text);
            int tongTien = Convert.ToInt32(txtTongTien.EditValue);
            int soTienGiam = diemDung * 5000;
            int thanhTien = tongTien - soTienGiam;
            if(thanhTien >= 0)
            {
                txtThanhTien1.Text = thanhTien.ToString();
            }
            else
            {
                txtThanhTien1.Text = txtTongTien.Text;
            }
        }
        public HoaDon_DTO layDuLieu()
        {
            try
            {
                int diemDung = Convert.ToInt32(txtDiemDung.EditValue);
                int thanhTien = Convert.ToInt32(txtThanhTien1.EditValue);
                return new HoaDon_DTO(txtMaHD.Text, Convert.ToDateTime(txtNgayLapHD.EditValue), frmMain.maNV, cboKhachHang.EditValue.ToString().Trim(),diemDung, thanhTien);
            }catch(Exception ex)
            {
                throw ex;
            }
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
            int[] dong = dgvSanPham.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(dgvSanPham.GetRowCellValue(i, "MãSố").ToString().Trim());
                        txtMaSP.Text = sp.MaSP;
                        txtTenSP.Text = sp.TenSP;
                        txtSoLuongTonKho.Text = sp.SoLuongConLai.ToString().Trim();
                    }
                    catch (Exception ex)
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
                //Kiểm tra dữ liệu số lượng tồn và số lượng mua
                if (txtSoLuongMua.Text != "" && txtSoLuongTonKho.Text != "")
                {
                    //Chuyển 2 giá trị số lượng về int
                    int sl_Mua = Convert.ToInt32(txtSoLuongMua.Text);
                    int sl_Ton = Convert.ToInt32(txtSoLuongTonKho.Text);
                    bool daChon = false;
                    //Kiểm tra dữ liệu số lượng mua hợp lệ 
                    if (sl_Mua <= 0)
                    {
                        txtSoLuongMua.Text = "1";
                        throw new Exception("Số lượng mua ít nhất là 1");
                    }
                    if (sl_Mua > sl_Ton)
                    {
                        txtSoLuongMua.Text = "1";
                        throw new Exception("Số lượng tồn kho không đủ");
                    }
                    //Kiểm tra sản phẩm đang chọn đã có trong giỏ hàng chưa
                    foreach (SanPhamMua_DTO item in dsMuaHang)
                    {
                        //Nếu có mã sp trong giỏ hàng
                        if (item.MaSP == txtMaSP.Text)
                        {
                            //Kiểm tra tổng số lượng dự kiến sẽ mua
                            int tongSL_Mua = item.SoLuong + sl_Mua;
                            //Nếu số lượng dự kiến lớn hơn số lượng tồn kho thì báo lỗi
                            if (tongSL_Mua > sl_Ton)
                            {
                                txtSoLuongMua.Text = "1";
                                throw new Exception("Số lượng tồn kho không đủ");
                            }
                            else
                            {
                                //Số lượng hợp lí thì tăng số lượng của sản phẩm đã có trong giỏ hàng
                                item.SoLuong = tongSL_Mua;
                                item.ThanhTien = item.DonGia * item.SoLuong;
                                daChon = true;
                                break;
                            }
                        }
                    }
                    //Nếu sản phẩm đang chọn chưa có trong giỏ hàng thì thêm mới vào giỏ hàng
                    if (!daChon)
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(txtMaSP.Text);
                        SanPhamMua_DTO sp_ChonMua = new SanPhamMua_DTO(sp.MaSP, sp.TenSP, sp.DonGia, sl_Mua, sp.DonGia * sl_Mua);
                        dsMuaHang.Add(sp_ChonMua);
                    }
                }
                //Reset datasource để hiển thị các sản phẩm đang chọn mua
                dgvGioHangGrid.DataSource = null;
                dgvGioHangGrid.DataSource = dsMuaHang;
                dgvGioHang.Columns["MaSP"].Caption = "Mã";
                dgvGioHang.Columns["TenSP"].Caption = "Tên sản phẩm";
                dgvGioHang.Columns["SoLuongTrongKho"].Caption = "Số lượng mua";
                dgvGioHang.Columns["DonGia"].Caption = "Đơn giá";
                dgvGioHang.Columns["ThanhTien"].Caption = "Thành tiền";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void cboKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                KhachHang_DTO kh = db_KH.timKH_TheoMa(cboKhachHang.EditValue.ToString().Trim());
                txtDiemTichLuy.Text = kh.DiemTichLuy.ToString();
            }
            catch (Exception ex)
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
                    capNhatGioHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void dgvGioHang_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            int[] dong = dgvGioHang.GetSelectedRows();
            foreach (int i in dong)
            {
                if (i >= 0)
                {
                    try
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(dgvGioHang.GetRowCellValue(i, "MaSP").ToString().Trim());
                        txtMaSP.Text = sp.MaSP;
                        txtTenSP.Text = sp.TenSP;
                        txtSoLuongTonKho.Text = sp.SoLuongConLai.ToString().Trim();
                        txtSoLuongMua.Text = dgvGioHang.GetRowCellValue(i, "SoLuongTrongKho").ToString().Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                }
            }
            dangLua(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int sl_Mua = Convert.ToInt32(txtSoLuongMua.Text);
                int sl_Ton = Convert.ToInt32(txtSoLuongTonKho.Text);

                //Kiểm tra sản phẩm đang chọn đã có trong giỏ hàng chưa
                foreach (SanPhamMua_DTO item in dsMuaHang)
                {
                    //Nếu có mã sp trong giỏ hàng
                    if (item.MaSP == txtMaSP.Text)
                    {
                        //Kiểm tra tổng số lượng dự kiến sẽ mua
                        int tongSL_Mua =sl_Mua;
                        //Nếu số lượng dự kiến lớn hơn số lượng tồn kho thì báo lỗi
                        if (tongSL_Mua > sl_Ton)
                        {
                            txtSoLuongMua.Text = "1";
                            throw new Exception("Số lượng tồn kho không đủ");
                        }
                        else
                        {
                            //Số lượng hợp lí thì tăng số lượng của sản phẩm đã có trong giỏ hàng
                            item.SoLuong = tongSL_Mua;
                            item.ThanhTien = item.DonGia * item.SoLuong;
                            break;
                        }
                    }
                }
                //Reset datasource để hiển thị các sản phẩm đang chọn mua
                dgvGioHangGrid.DataSource = null;
                dgvGioHangGrid.DataSource = dsMuaHang;
                dgvGioHang.Columns["MaSP"].Caption = "Mã";
                dgvGioHang.Columns["TenSP"].Caption = "Tên sản phẩm";
                dgvGioHang.Columns["SoLuongTrongKho"].Caption = "Số lượng mua";
                dgvGioHang.Columns["DonGia"].Caption = "Đơn giá";
                dgvGioHang.Columns["ThanhTien"].Caption = "Thành tiền";
                //Quay lại lựa sản phẩm
                dangLua(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn hủy chọn sản phẩm " + txtTenSP.Text  + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                try
                {
                    foreach(SanPhamMua_DTO item in dsMuaHang)
                    {
                        if(item.MaSP == txtMaSP.Text)
                        {
                            dsMuaHang.Remove(item);
                            break;
                        }
                    }
                    //Reset datasource để hiển thị các sản phẩm đang chọn mua
                    dgvGioHangGrid.DataSource = null;
                    dgvGioHangGrid.DataSource = dsMuaHang;
                    dgvGioHang.Columns["MaSP"].Caption = "Mã";
                    dgvGioHang.Columns["TenSP"].Caption = "Tên sản phẩm";
                    dgvGioHang.Columns["SoLuongTrongKho"].Caption = "Số lượng mua";
                    dgvGioHang.Columns["DonGia"].Caption = "Đơn giá";
                    dgvGioHang.Columns["ThanhTien"].Caption = "Thành tiền";
                    //Quay lại lựa sản phẩm
                    dangLua(true);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnSearchSanPham_Click(object sender, EventArgs e)
        {
            if(maLoai_DangLoc != cboMaLoaiSP.EditValue.ToString().Trim())
            {
                maLoai_DangLoc = cboMaLoaiSP.EditValue.ToString().Trim();
                dgvSanPhamGrid.DataSource = null;
                dgvSanPhamGrid.DataSource = db_SP.LayDanhSach_TheoLoai(maLoai_DangLoc);
            }
            else
            {
                maLoai_DangLoc = "";
                dgvSanPhamGrid.DataSource = null;
                dgvSanPhamGrid.DataSource = db_SP.LayDanhSach();
                cboMaLoaiSP.ItemIndex = 0;
            }
        }

        private void btnHuyGioHang_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn hủy chọn các sản phẩm trên ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.Yes)
            {
                try
                {
                    dsMuaHang.Clear();
                    //Reset datasource để hiển thị các sản phẩm đang chọn mua
                    dgvGioHangGrid.DataSource = null;
                    dgvGioHangGrid.DataSource = dsMuaHang;
                    dgvGioHang.Columns["MaSP"].Caption = "Mã";
                    dgvGioHang.Columns["TenSP"].Caption = "Tên sản phẩm";
                    dgvGioHang.Columns["SoLuongTrongKho"].Caption = "Số lượng mua";
                    dgvGioHang.Columns["DonGia"].Caption = "Đơn giá";
                    dgvGioHang.Columns["ThanhTien"].Caption = "Thành tiền";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void txtDiemDung_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int diemDung = Convert.ToInt32(txtDiemDung.Text);
            //    int diemTichLuy = Convert.ToInt32(txtDiemTichLuy.Text);
            //    if (diemDung > diemTichLuy)
            //    {
            //        throw new Exception("Số điểm cần dùng đã vượt quá số điểm hiện có của khách hàng");
            //    }
            //    int tongTien = Convert.ToInt32(txtTongTien.Text);
            //    int soTienGiam = diemDung * 5000;
            //    int thanhTien = tongTien - soTienGiam;
            //    if (soTienGiam < 0)
            //    {
            //        throw new Exception("Điểm dùng phải lớn hơn hoặc bằng 0");
            //    }
            //    if (tongTien > 0 && thanhTien > 0)
            //    {
            //        txtThanhTien1.Text = thanhTien.ToString().Trim();
            //    }
            //    else
            //    {
            //        if (tongTien <= 0)
            //        {
            //            throw new Exception("Vui lòng chọn mua sản phẩm trước khi áp dụng điểm tích lũy");
            //        }
            //        if (thanhTien < 0)
            //        {
            //            throw new Exception("Đơn hàng của bạn không thể dùng thêm điểm tích lũy nữa");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi");
            //    txtDiemDung.Text = "0";
            //}
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if(dsMuaHang.Count > 0)
                {
                    //Tạo hóa đơn mới
                    HoaDon_DTO hd = layDuLieu();

                    //Thêm hóa đơn
                    db_HD.Them(hd);

                    //Tạo chi tiết giỏ hàng
                    foreach (SanPhamMua_DTO item in dsMuaHang)
                    {
                        ChiTietHD_DTO cthd = new ChiTietHD_DTO(hd.MaHD, item.MaSP, item.SoLuong);
                        db_ct_HD.Them(cthd);
                    }

                    //Cập nhật số lượng tồn kho
                    foreach (SanPhamMua_DTO item in dsMuaHang)
                    {
                        SanPham_DTO sp = db_SP.timSanPham_MaSP(item.MaSP);
                        sp.SoLuongConLai -= item.SoLuong;
                        db_SP.Sua(sp);
                    }


                    /*
                        In hóa đơn (report) 
                    */


                    //Xóa giỏ hàng
                    dsMuaHang.Clear();

                    //Reset datasource để hiển thị các sản phẩm đang chọn mua
                    dgvGioHangGrid.DataSource = null;
                    dgvGioHangGrid.DataSource = dsMuaHang;
                    dgvGioHang.Columns["MaSP"].Caption = "Mã";
                    dgvGioHang.Columns["TenSP"].Caption = "Tên sản phẩm";
                    dgvGioHang.Columns["SoLuongTrongKho"].Caption = "Số lượng mua";
                    dgvGioHang.Columns["DonGia"].Caption = "Đơn giá";
                    dgvGioHang.Columns["ThanhTien"].Caption = "Thành tiền";
                    //Tải lại form
                    taiForm();
                    //Thông báo
                    MessageBox.Show("Thanh toán thành công", "Thông báo");
                }
                else
                {
                    throw new Exception("Vui lòng chọn mua sản phẩm trước khi thanh toán");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
