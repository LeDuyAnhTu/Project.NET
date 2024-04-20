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
        public frmMain()
        {
            InitializeComponent();
            //
            // frmMain
            //
            Rectangle rect = new Rectangle(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);

            foreach (Screen screen in Screen.AllScreens)
                rect = Rectangle.Union(rect, screen.Bounds);
            this.Width = rect.Width;
            this.Height = rect.Height;
            
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Kết quả đăng nhập
            bool result = true;

            if(result)
            {
                nafMain.SelectedPage = napMain;
            }
            else
            {
                //Nhập sai thì thông báo lỗi
            }
        }
    }
}