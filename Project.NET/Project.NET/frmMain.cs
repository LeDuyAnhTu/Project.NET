using System;
using System.Linq;
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
            this.IsMdiContainer = true;
        }
        /// <summary>
        /// Tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frm = new frmLogin();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
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