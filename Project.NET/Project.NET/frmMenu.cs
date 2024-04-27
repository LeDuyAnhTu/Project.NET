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

namespace Project.NET
{
    public partial class frmMenu : Form
    {
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

        public frmMenu()
        {
            InitializeComponent();
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            loadingFirstOrDeFaultNavbarMenuButton(); 
        }

        /// <summary>
        /// Tải mặc định menu đầu tiên là menu tài khoản
        /// </summary>
        private void loadingFirstOrDeFaultNavbarMenuButton()
        {
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
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Giải phóng tài nguyên của UserControl hiện tại
                SwitchTab(currentControl);

                // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                SimpleButton clickedButton = (SimpleButton)sender;
                switch (clickedButton.Name)
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
                        break;
                    case "btnKho":
                        nafContent.SelectedPage = navKho;
                        LoadUserControl(kho_UC, typeof(Kho_UC), editFormKho);
                        LoadUserControl(thongKeKho_UC, typeof(ThongKeKho_UC), editFormThongKeKho);
                        break;
                    case "btnSanPham":
                        nafContent.SelectedPage = navSanPham;
                        LoadUserControl(sanPham_UC, typeof(SanPham_UC), editFormSanPham);
                        break;
                    case "btnKhuyenMai":
                        nafContent.SelectedPage = navKhuyenMai;


                        break;
                    case "btnKhachHang":
                        nafContent.SelectedPage = navKhachHang;


                        break;
                    case "btnHoaDon":
                        nafContent.SelectedPage = navHoaDon;


                        break;
                    case "btnChiNhanh":
                        nafContent.SelectedPage = navChiNhanh;


                        break;
                    case "btnNhaCungCap":
                        nafContent.SelectedPage = navNhaCungCap;


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
