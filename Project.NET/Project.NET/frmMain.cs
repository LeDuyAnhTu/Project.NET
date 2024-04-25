using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;
using Project.NET.Forms;
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

namespace Project.NET
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {

        /// <summary>
        /// Khởi tạo form
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            btnTaiKhoan.Click += Button_Click;
            btnNhanVien.Click += Button_Click;
            btnKho.Click += Button_Click;
            btnSanPham.Click += Button_Click;
            btnKhuyenMai.Click += Button_Click;
            btnKhachHang.Click += Button_Click;
            btnHoaDon.Click += Button_Click;
            btnChiNhanh.Click += Button_Click;
            btnNhaCungCap.Click += Button_Click;
            btnBaoCao.Click += Button_Click;
            btnThongKe.Click += Button_Click;
        }
        private UserControl currentControl = null;
        private NhanVien_UC nhanVien_UC = null;
        private ThongKeNhanVien_UC thongKeNhanVien_UC = null;
        private TaiKhoan_UC taiKhoan_UC = null;
        private ThongKeMonth_UC thongKeMonth_UC = null;
        private ThongKeYear_UC thongKeYear_UC = null;
        private BaoCao_UC baoCao_UC = null;
        private PhanCong_UC phanCong_UC = null;
        private CaLam_UC caLam_UC = null;

        /// <summary>
        /// Tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
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
                    case "btnDangNhap":
                        //Kết quả đăng nhập
                        bool result = true;

                        if (result)
                        {
                            nafMain.SelectedPage = napMain;
                        }
                        else
                        {
                            //Nhập sai thì thông báo lỗi
                        }
                        break;
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
                        //LoadUserControl(kho_UC, typeof(Kho_UC), editFormKho);
                        //LoadUserControl(thongKeKho_UC, typeof(ThongKeKho_UC), editFormThongKeKho);
                        break;
                    case "btnSanPham":
                        nafContent.SelectedPage = navNhanVien;

                        break;
                    case "btnKhuyenMai":
                        nafContent.SelectedPage = navNhanVien;


                        break;
                    case "btnKhachHang":
                        nafContent.SelectedPage = navNhanVien;


                        break;
                    case "btnHoaDon":
                        nafContent.SelectedPage = navNhanVien;


                        break;
                    case "btnChiNhanh":
                        nafContent.SelectedPage = navNhanVien;


                        break;
                    case "btnNhaCungCap":
                        nafContent.SelectedPage = navNhanVien;


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


        /// <summary>
        /// Giải phóng tài nguyên khi thoát chương trình
        /// </summary>
        /// <param name="container"></param>
        private void ReleaseAllResources(Control container)
        {
            // Duyệt qua tất cả các controls trong container
            for (int i = container.Controls.Count - 1; i >= 0; i--)
            {
                // Kiểm tra xem control hiện tại có phải là UserControl không
                if (container.Controls[i] is UserControl)
                {
                    UserControl userControl = (UserControl)container.Controls[i];

                    // Gỡ UserControl khỏi container
                    container.Controls.Remove(userControl);

                    // Giải phóng tài nguyên
                    userControl.Dispose();
                }
            }
        }


        /// <summary>
        /// Trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ReleaseAllResources(this);// giai phong tai nguyen
            }
        }
        /// <summary>
        /// Tắt double click ở title bar
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)    //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }
    }
}