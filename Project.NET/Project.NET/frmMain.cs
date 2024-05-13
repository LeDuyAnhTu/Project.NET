using Project.NET.GUI_UC;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        //Fields
        public static string maNV = "";
        private string databaseName = "QLBHX";
        private string[] serverNames = new string[] { ".", ".\\sqlexpress" };
        private string filePath = Directory.GetCurrentDirectory() + "\\ct.bin";
        string connectionString = null;

        //Chuyển đến form khác sau khi đăng nhập thành công
        frmMain frmMainn = Application.OpenForms.OfType<frmMain>().FirstOrDefault();

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
            }
            catch (Exception ex)
            {
                using (BinaryWriter binWriter = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
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
        /// <summary>
        /// Khởi tạo form
        /// </summary>
        public frmMain()
        {
            InitializeComponent(); 
        }
        /// <summary>
        /// Tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadUserControl(null, typeof(Login_UC), this);
            int attempt = 1;
            int maxAttempt = 2;
            /*
             * Kết nối với database có trong máy
             * Tạo mới database lên server của máy hiện tại nếu không thể kết nối và thử kết nối lại
             * số lần thử tối đa là 2
             */

            while (!connectingToServer() && attempt <= maxAttempt)
            {
                //Tạo database

                //Tạo dữ liệu ban đầu (nếu cần thiết)

                //Tăng số lần thử
                attempt++;
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
    }
}