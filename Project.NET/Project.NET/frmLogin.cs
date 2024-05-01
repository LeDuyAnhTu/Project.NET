using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Project.NET.GUI_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Project.NET
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Tạo một TextEdit với PasswordChar là '*' 
            txtMatKhau.Properties.PasswordChar = '*';
            EditorButton customButton = new EditorButton();
            customButton.Image = Properties.Resources.eyeOpen;

            txtMatKhau.Properties.Buttons.RemoveAt(0);
            txtMatKhau.Properties.Buttons.Add(customButton);

            //// Đăng ký sự kiện ButtonClick
            txtMatKhau.Properties.ButtonClick += (sender, e) =>
            {
                if (e.Button.Kind == ButtonPredefines.Ellipsis)
                {
                    // Nếu PasswordChar là '*', thì đặt nó thành '\0' để hiện mật khẩu
                    // và thay đổi biểu tượng thành mắt đóng
                    if (txtMatKhau.Properties.PasswordChar == '*')
                    {
                        txtMatKhau.Properties.PasswordChar = '\0';
                        e.Button.Image = Properties.Resources.eyeClosed; // Biểu tượng mắt đóng
                    }
                    // Ngược lại, đặt PasswordChar thành '*' để ẩn mật khẩu
                    // và thay đổi biểu tượng thành mắt mở
                    else
                    {
                        txtMatKhau.Properties.PasswordChar = '*';
                        e.Button.Image = Properties.Resources.eyeOpen; // Biểu tượng mắt mở
                    }
                }
            };
        }
        /// <summary>
        /// Hiệu ứng fade cho việc đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //chặn bấm liên tục vào nút đăng nhập gây lỗi hệ thống
            btnDangNhap.Enabled = false;

            //string connectionString = @"Your Connection String";
            //SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            //string query = "SELECT * FROM TaiKhoan WHERE tenTK=@username AND matKhau=@password";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.Parameters.AddWithValue("@username", txtTenDangNhap.Text);
            //cmd.Parameters.AddWithValue("@password", txtMatKhau.Text);
            //SqlDataReader dr = cmd.ExecuteReader();
            //if (dr.HasRows)
            //{
            //MessageBox.Show("Đăng nhập thành công");

            //Chuyển đến form khác sau khi đăng nhập thành công
            frmMain frmMainn = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            frmMenu frmMenuu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();

            if (frmMainn != null)
            {
                if (frmMenuu == null)
                {
                    this.Close();// dong frmLogin
                    frmMainn.Focus();

                    frmMenuu = new frmMenu();// khởi tạo frmMenuu

                    frmMenuu.MdiParent = frmMainn;// gan frmMenuu vào frmMain

                    frmMenuu.Show();// hiển thị frmMenuu
                }
            }

            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            //}
            //con.Close();
            btnDangNhap.Enabled = true;
        }


    }
}
