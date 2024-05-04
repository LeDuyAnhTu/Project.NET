using Project.NET.Forms;
using Project.NET.GUI_UC.PageKho;
using Project.NET.GUI_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Project.NET.GUI_UC.PageSanPham;
using Project.NET.GUI_UC.PageKhuyenMai;
using BUS;
using DevExpress.Utils;
using Project.NET.GUI_UC.PageKhachHang;
using Project.NET.GUI_UC.PageHoaDon;
using Project.NET.GUI_UC.PageChiNhanh;
using Project.NET.GUI_UC.PageNhaCungCap;
using Project.NET.GUI_UC.PageNhanVien;
using Project.NET.ExtensionMethods;

namespace Project.NET
{
    public partial class frmMenu : Form
    { 
        // Nút bấm menu navbar cuối cùng được nhấn
        private SimpleButton lastClickButton = null;
        
        private UserControl currentControl = null;
        private NhanVien_UC nhanVien_UC = null;
        private ThongKeNhanVien_UC thongKeNhanVien_UC = null;
        private TaiKhoan_UC taiKhoan_UC = null;
        private ThongKeMonth_UC thongKeMonth_UC = null;
        private ThongKeYear_UC thongKeYear_UC = null;
        private BaoCao_UC baoCao_UC = null;
        private PhanCong_UC phanCong_UC = null;
        private CaLam_UC caLam_UC = null;
        private Kho_UC kho_UC = null;
        private ThongKeKho_UC thongKeKho_UC = null;
        private SanPham_UC sanPham_UC = null;
        private LoaiSanPham_UC loaiSanPham_UC = null;
        private ThongKeSanPham_UC thongKeSanPham_UC = null;
        private KhuyenMai_UC khuyenMai_UC = null;
        private ChiTietKhuyenMai_UC chiTietKhuyenMai_UC = null;
        private ThongKeKhuyenMai_UC thongKeKhuyenMai_UC = null;
        private KhachHang_UC khachHang_UC = null;
        private HoaDon_UC hoaDon_UC = null;
        private ChiNhanh_UC chiNhanh_UC = null;
        private NhaCungCap_UC nhaCungCap_UC = null;
        private ViTriChucVuNV_UC viTriChucVuNV_UC = null;
        private HoaDonChiTiet_UC hoaDonChiTiet_UC = null;
        private KhuVuc_UC khuVuc_UC = null;
        private ChiTietCC_UC chiTietCC_UC = null;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        { 
            loadingFirstOrDeFaultNavbarMenuButton();
        }

        /// <summary>
        /// Tải mặc định menu đầu tiên là menu tài khoản và tô đậm nút tài khoản menu navbar
        /// </summary>
        private void loadingFirstOrDeFaultNavbarMenuButton()
        {
            // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
            SimpleButton currentButton = btnTaiKhoan;
            currentButton.UpdateButtonStyle(lastClickButton);
            //
            // Cập nhật trạng thái cho nút đang được nhấn
            //
            lastClickButton = currentButton;

            // Loading default tài khoản tab
            if (taiKhoan_UC == null)
            {
                taiKhoan_UC = new TaiKhoan_UC();
                taiKhoan_UC.Dock = DockStyle.Fill;

                editFormTaiKhoan.Controls.Add(taiKhoan_UC);
            }

            if (editFormTaiKhoan == null)
            {
                tabSuaTTTaiKhoan.Controls.Add(editFormTaiKhoan);
            }
        }
        
        /// <summary>
        /// Xử lý sự kiện cho các nút bấm trên nav menu buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private async void Button_Click(object sender, EventArgs e)
        {
            try
            {
                WaitFormManager waitFormManager = new WaitFormManager(this);
                await waitFormManager.ShowWaitForm(() =>
                {
                    // Giải phóng tài nguyên của UserControl hiện tại
                    SwitchTab(currentControl);

                    // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                    SimpleButton currentButton = (SimpleButton)sender;
                    currentButton.UpdateButtonStyle(lastClickButton);

                    //
                    // Cập nhật trạng thái cho nút đang được nhấn
                    //
                    lastClickButton = currentButton;

                    //
                    // Kiểm tra nút được nhấn là nút nào, chuyển tài nguyên tương ứng
                    //
                    switch (currentButton.Name)
                    {
                        case "btnTaiKhoan":
                            nafContent.SelectedPage = navTaiKhoan;
                            LoadUserControl(taiKhoan_UC, typeof(TaiKhoan_UC), editFormTaiKhoan);

                            break;
                        case "btnNhanVien":
                            nafContent.SelectedPage = navNhanVien;
                            LoadUserControl(nhanVien_UC, typeof(NhanVien_UC), editFormNhanVien);
                            LoadUserControl(thongKeNhanVien_UC, typeof(ThongKeNhanVien_UC), editFormThongKeNhanVien);
                            LoadUserControl(caLam_UC, typeof(CaLam_UC), editFormCaLam);
                            LoadUserControl(phanCong_UC, typeof(PhanCong_UC), editFormPhanCong);
                            LoadUserControl(viTriChucVuNV_UC, typeof(ViTriChucVuNV_UC), editFormViTriChucVuNV);
                            break;
                        case "btnKho":
                            nafContent.SelectedPage = navKho;
                            LoadUserControl(kho_UC, typeof(Kho_UC), editFormKho);
                            LoadUserControl(thongKeKho_UC, typeof(ThongKeKho_UC), editFormThongKeKho);
                            break;
                        case "btnSanPham":
                            nafContent.SelectedPage = navSanPham;
                            LoadUserControl(sanPham_UC, typeof(SanPham_UC), editFormSanPham);
                            LoadUserControl(loaiSanPham_UC, typeof(LoaiSanPham_UC), editFormLoaiSP);
                            LoadUserControl(thongKeSanPham_UC, typeof(ThongKeSanPham_UC), editFormThongKeSanPham);
                            break;
                        case "btnKhuyenMai":
                            nafContent.SelectedPage = navKhuyenMai;
                            LoadUserControl(khuyenMai_UC, typeof(KhuyenMai_UC), editFormKhuyenMai);
                            LoadUserControl(chiTietKhuyenMai_UC, typeof(ChiTietKhuyenMai_UC), editFormChiTietKhuyenMai);
                            LoadUserControl(thongKeKhuyenMai_UC, typeof(ThongKeKhuyenMai_UC), editFormThongKeKhuyenMai);
                            break;
                        case "btnKhachHang":
                            nafContent.SelectedPage = navKhachHang;
                            LoadUserControl(khachHang_UC, typeof(KhachHang_UC), editFormKhachHang);

                            break;
                        case "btnHoaDon":
                            nafContent.SelectedPage = navHoaDon;
                            LoadUserControl(hoaDon_UC, typeof(HoaDon_UC), editFormHoaDon);
                            LoadUserControl(hoaDonChiTiet_UC, typeof(HoaDonChiTiet_UC), editFormHoaDonChiTiet);
                            break;
                        case "btnChiNhanh":
                            nafContent.SelectedPage = navChiNhanh;
                            LoadUserControl(chiNhanh_UC, typeof(ChiNhanh_UC), editFormChiNhanh);
                            LoadUserControl(khuVuc_UC, typeof(KhuVuc_UC), editFormKhuVuc);
                            break;
                        case "btnNhaCungCap":
                            nafContent.SelectedPage = navNhaCungCap;
                            LoadUserControl(nhaCungCap_UC, typeof(NhaCungCap_UC), editFormNhaCungCap);
                            LoadUserControl(chiTietCC_UC, typeof(ChiTietCC_UC), editFormChiTietCC);
                            break;
                        case "btnBaoCao":
                            nafContent.SelectedPage = navBaoCao;
                            LoadUserControl(baoCao_UC, typeof(BaoCao_UC), editFormBaoCao);
                            break;
                        case "btnThongKe":
                            nafContent.SelectedPage = navThongKe;
                            LoadUserControl(thongKeMonth_UC, typeof(ThongKeMonth_UC), editFormThongKeMonth);
                            LoadUserControl(thongKeYear_UC, typeof(ThongKeYear_UC), editFormThongKeYear);
                            break;
                        default:
                            throw new Exception("Unknown button.");
                    }
                    return Task.CompletedTask;
                });// end waiting

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadUserControl(UserControl userControl, Type type, Control container)
        {
            if (userControl == null)
            {
                userControl = (UserControl)Activator.CreateInstance(type);
                userControl.Dock = DockStyle.Fill;
                container.Dock = DockStyle.Fill;
                container.Controls.Add(userControl);
            }
        }
        private void SwitchTab(UserControl newControl)
        {
            // Dispose the current UserControl if it exists
            if (currentControl != null)
            {
                if (currentControl is IDisposable disposable)
                {
                    disposable.Dispose();
                }
                currentControl = null;
            }

            // Switch to the new UserControl
            currentControl = newControl;
            // (code to switch to the new UserControl)
        }

    }
}
