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
            //navigation page
            //
            this.napLogin.Width = this.nafMain.Width;
            this.napLogin.Height = this.nafMain.Height;
            //
            // pictureBox1
            //
            int padding_vertical = (int)(napLogin.Height - this.pictureBox1.Height);
            this.pictureBox1.Location = new System.Drawing.Point(20, padding_vertical);
            //
            // panelControl1
            //
            this.panelControl1.Padding = new System.Windows.Forms.Padding(12, 25, 12, 0);
            int panel_Height = (this.panelControl1.Padding.Top * 2) 
                + txtTenDangNhap.Size.Height 
                + txtTenDangNhap.Margin.Bottom 
                + txtMatKhau.Size.Height
                + txtMatKhau.Margin.Bottom
                + btnDangNhap.Size.Height;
            int panel_Width = (this.panelControl1.Padding.Left * 2)
                + lblTenDangNhap.Size.Width
                + lblTenDangNhap.Margin.Right 
                + txtTenDangNhap.Size.Width;
            int panel_X = (int)(napLogin.Height - this.panelControl1.Height)/2;
            int panel_Y = this.napLogin.Width - (panel_Width + this.napLogin.Padding.Right);
            this.panelControl1.Size = new System.Drawing.Size(panel_Width, panel_Height);
            this.panelControl1.Location = new System.Drawing.Point(panel_Y, panel_X);

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
    }
}