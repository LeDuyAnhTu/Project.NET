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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnDangNhap.Click += btnDangNhap_Click;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
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
            //    MessageBox.Show("Đăng nhập thành công");
            // Chuyển đến form khác sau khi đăng nhập thành công
            frmMenu frm = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            frmMain frmMain = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            frmMenu frmMenu = Application.OpenForms.OfType<frmMenu>().FirstOrDefault();
            if (frm == null)
            {
                if(frmMain != null)
                {
                    if (frmMenu == null)
                    {
                        this.Close();
                        frmMain.Show();

                        frmMenu = new frmMenu();
                        frmMenu.MdiParent = frmMain; 
                        frmMenu.Show();
                    }
                   
                }
            }
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            //}
            //con.Close();
        }
    }
}
