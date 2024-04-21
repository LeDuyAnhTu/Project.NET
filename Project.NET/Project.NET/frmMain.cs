using DevExpress.XtraEditors;
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
            ////
            //// frmMain
            ////
            //Rectangle rect = new Rectangle(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);

            //foreach (Screen screen in Screen.AllScreens)
            //    rect = Rectangle.Union(rect, screen.Bounds);
            //this.Width = rect.Width;
            //this.Height = rect.Height;

            //
            // txtTenDangNhap, txtMatKhau
            //
            int txt_Margin_Vertical = (int)Math.Ceiling(((this.hinh.Size.Height * 0.3) - txtTenDangNhap.Size.Height) / 2);

            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(0, txt_Margin_Vertical, 10, txt_Margin_Vertical);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(0, txt_Margin_Vertical, 10, txt_Margin_Vertical);

            //
            // lblTenDangNhap, lblMatKhau
            //
            int lbl_Width = (int)Math.Ceiling(this.hinh.Size.Width * 0.35);
            int lbl_Height = (int)Math.Ceiling(this.hinh.Size.Height * 0.3);
            int lbl_Margin_Vertical = (int)Math.Ceiling(((this.hinh.Size.Height * 0.3) - lblTenDangNhap.Size.Height) / 2);

            lblTenDangNhap.Size = new Size(lbl_Width, lbl_Height);
            lblMatKhau.Size = lblTenDangNhap.Size;
            lblTenDangNhap.Margin = new Padding(0, lbl_Margin_Vertical, 10, 0);
            lblMatKhau.Margin = new Padding(0, lbl_Margin_Vertical, 10, 0);

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
        }
        /// <summary>
        /// Tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
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
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            nafContent.SelectedPage = navNhanVien;
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
    }
}