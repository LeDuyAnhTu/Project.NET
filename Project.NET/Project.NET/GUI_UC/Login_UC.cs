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
using System.IO;
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

        //Fields
        private TaiKhoan_BUS db_TK = new TaiKhoan_BUS();
        private string databaseName = "QLBHX";
        private string[] serverNames = new string[] { ".", ".\\sqlexpress" };
        private string filePath = Directory.GetCurrentDirectory() +"\\ct.bin";
        string connectionString = null;

        //Constructor
        public Login_UC()
        {
            InitializeComponent();

            // Tạo một TextEdit với PasswordChar là '*' 
            txtMatKhau.Properties.PasswordChar = '*';
            EditorButton customButton = new EditorButton();
            lblNhapMatKhau.ImageOptions.Image = Properties.Resources.hide_32x32;
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
                        lblNhapMatKhau.ImageOptions.Image = Properties.Resources.show_32x32;
                    }
                    // Ngược lại, đặt PasswordChar thành '*' để ẩn mật khẩu
                    // và thay đổi biểu tượng thành mắt mở
                    else
                    {
                        txtMatKhau.Properties.PasswordChar = '*';
                        e.Button.Image = Properties.Resources.eyeOpen; // Biểu tượng mắt mở
                        lblNhapMatKhau.ImageOptions.Image = Properties.Resources.hide_32x32;
                    }
                }
            };
        }

        //Methods
        private bool connectingToServer()
        {
            bool connected = false;
            try
            {
                using (BinaryReader binReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.ConnectionStrings.ConnectionStrings["QLBHXConnectionString"].ConnectionString = binReader.ReadString();
                    connected = true;
                }
            }catch(Exception ex)
            {
                using(BinaryWriter binWriter = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
                {
                    string errorMessage = "";
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
                                connected = true;
                            }
                        }
                        catch (Exception e)
                        {
                            errorMessage = e.Message;
                        }
                        if (connected)
                        {
                            break;
                        }
                    }
                    binWriter.Write(connectionString);
                }
            }
            return connected;
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
                Console.WriteLine(ex.Message);
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
        
        private void Login_UC_Load(object sender, EventArgs e)
        { 
            btnDangNhap.Click += btnDangNhap_Click;
            int attempt = 1;
            int maxAttempt = 2;
            /*
             * Kết nối với database có trong máy
             * Tạo mới database lên server của máy hiện tại nếu không thể kết nối và thử kết nối lại
             * số lần thử tối đa là 2
             */

            while (!connectingToServer() && attempt <= maxAttempt) {
                //Tạo database

                //Tạo dữ liệu ban đầu (nếu cần thiết)

                //Tăng số lần thử
                attempt++;
            }
        }
    }
}
