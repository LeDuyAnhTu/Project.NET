using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC
{
    public partial class Login_UC : DevExpress.XtraEditors.XtraUserControl
    {

        //Chuyển đến form khác sau khi đăng nhập thành công
        frmMain frmMainn = Application.OpenForms.OfType<frmMain>().FirstOrDefault();

        //Properties
        private TaiKhoan_BUS db_TK = new TaiKhoan_BUS();
        private string databaseName = "QLBHX";
        private string[] serverNames = new string[] { ".", ".\\sqlexpress" };

        public Login_UC()
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

        //Events
        /// <summary>
        /// Hiệu ứng fade cho việc đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            //chặn bấm liên tục vào nút đăng nhập gây lỗi hệ thống
            btnDangNhap.Enabled = false;
            try
            {
                TaiKhoan_DTO tk = db_TK.timTaiKhoan_TenTK(txtTenDangNhap.Text);
                if (txtMatKhau.Text.Equals(tk.MatKhau.Trim()))
                {
                    WaitFormManager waitFormManager = new WaitFormManager(frmMainn);
                    await waitFormManager.ShowWaitForm(() =>
                    {

                        // Sử dụng Invoke để đảm bảo rằng mã được thực thi trên thread chính
                        this.Invoke((MethodInvoker)delegate
                        {

                            // Gỡ UserControl khỏi container
                            frmMainn.Controls.Remove(this);

                            // Giải phóng tài nguyên
                            this.Dispose();

                            LoadUserControl(null, typeof(Menu_UC), frmMainn);
                        });
                        frmMain.maNV = tk.MaNV;
                        return Task.CompletedTask;
                    });
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
            }
            btnDangNhap.Enabled = true;
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnDangNhap.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        string connectionString = null;
        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
        private void cboServerName_EditValueChanged(object sender, EventArgs e)
        {
            if (cboServerName.Text.Length >= 1) // Kiểm tra nếu ít nhất 1 ký tự đã được nhập
            {
                connectionString = $"data source={cboServerName.Text};initial catalog=;integrated security=True;encrypt=True;trustservercertificate=True;";



                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SELECT name FROM sys.databases", connection))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                cbDatabases.Properties.Items.Clear();
                                while (reader.Read())
                                {
                                    cbDatabases.Properties.Items.Add(reader.GetString(0));
                                }
                            }
                        }
                        MessageBox.Show("Đã lấy được danh sách database name", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnConnect.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi ở đây
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void Login_UC_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Enabled = false;
            txtMatKhau.Enabled = false;
            btnDangNhap.Enabled = false;
            btnConnect.Enabled = false;
            btnConnect.Click += btnConnect_Click;
            btnDangNhap.Click += btnDangNhap_Click;
            bool connected = false;
            foreach (string serverName in serverNames)
            {
                try
                {
                    connectionString = $"data source={serverName};initial catalog={databaseName};integrated security=True;encrypt=True;trustservercertificate=True;";


                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    if (config.ConnectionStrings.ConnectionStrings["QLBHXConnectionString"] != null)
                    {
                        config.ConnectionStrings.ConnectionStrings["QLBHXConnectionString"].ConnectionString = connectionString;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("connectionStrings");

                        // Kiểm tra kết nối
                        using (var connection = new SqlConnection(connectionString))
                        {
                            connection.Open(); // Thử mở kết nối
                            connection.Close();
                        }

                        MessageBox.Show("Cập nhật chuỗi kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenDangNhap.Enabled = true;
                        txtMatKhau.Enabled = true;
                        btnDangNhap.Enabled = true;
                        connected = true;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Chuỗi kết nối 'QLBHXConnectionString' không tồn tại trong file cấu hình.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    //MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (connected)
                    break;
            }
        }
    }
}
