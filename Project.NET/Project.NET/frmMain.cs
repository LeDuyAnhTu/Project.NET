using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraTab;
using DevExpress.XtraWaitForm;
using Project.NET.Forms;
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
        /// <summary>
        /// Khởi tạo form
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            btnTaiKhoan.Click += btnTaiKhoan_Click;
            btnNhanVien.Click += btnNhanVien_Click;
            btnKho.Click += btnKho_Click;
            btnSanPham.Click += btnSanPham_Click;
            btnKhuyenMai.Click += btnKhuyenMai_Click;
            btnKhachHang.Click += btnKhachHang_Click;
            btnHoaDon.Click += btnHoaDon_Click;
            btnChiNhanh.Click += btnChiNhanh_Click;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            btnBaoCao.Click += btnBaoCao_Click;
            btnThongKe.Click += btnThongKe_Click;
        }
        private NhanVien_UC nhanvien_uc;
        private TaiKhoan_UC taikhoan_uc;

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
        }
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
            if (taikhoan_uc == null)
            {
                taikhoan_uc = new TaiKhoan_UC();
                taikhoan_uc.Dock = DockStyle.Fill;
                editFormTaiKhoan.Controls.Add(taikhoan_uc);
                //editFormNhanVien.Dock = DockStyle.Fill;
            }

            // Kiểm tra xem EditFormUserControl đã được tạo chưa
            if (editFormTaiKhoan == null)
            {
                tabSuaTTTaiKhoan.Controls.Add(editFormTaiKhoan);
            }
        }

        /// <summary>
        /// Nút đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
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
        }
        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navThongKe;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navBaoCao;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navTaiKhoan;
            // Kiểm tra xem UserControl đã được tạo chưa
            if (taikhoan_uc == null)
            {
                taikhoan_uc = new TaiKhoan_UC();
                taikhoan_uc.Dock = DockStyle.Fill;
                editFormTaiKhoan.Controls.Add(taikhoan_uc);
                //editFormNhanVien.Dock = DockStyle.Fill;
            }

            // Kiểm tra xem EditFormUserControl đã được tạo chưa
            if (editFormTaiKhoan == null)
            {

                tabSuaTTTaiKhoan.Controls.Add(editFormTaiKhoan);
            }

            // Cập nhật thông tin trên UserControl và EditFormUserControl nếu cần
            // ...
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navNhanVien;
            // Kiểm tra xem UserControl đã được tạo chưa
            if (nhanvien_uc == null)
            {
                nhanvien_uc = new NhanVien_UC();
                nhanvien_uc.Dock = DockStyle.Fill;
                editFormNhanVien.Controls.Add(nhanvien_uc);
                //editFormNhanVien.Dock = DockStyle.Fill;
            }

            // Kiểm tra xem EditFormUserControl đã được tạo chưa
            if (editFormNhanVien == null)
            {
             
                tabNhapTTNhanVien.Controls.Add(editFormNhanVien);
            }

            // Cập nhật thông tin trên UserControl và EditFormUserControl nếu cần
            // ...

        }


        private void btnKho_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navKho;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navSanPham;
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navKhuyenMai;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navKhachHang;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navHoaDon;
        }

        private void btnChiNhanh_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navChiNhanh;
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navNhaCungCap;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //ReportPrintTool printTool = new ReportPrintTool(new XtraReport1());
            //printTool.ShowRibbonPreview();
        }
    }
}