using DevExpress.XtraEditors;
using Project.NET.ExtensionMethods;
using Project.NET.Forms;
using Project.NET.GUI_UC.PageChiNhanh;
using Project.NET.GUI_UC.PageHoaDon;
using Project.NET.GUI_UC.PageKhachHang;
using Project.NET.GUI_UC.PageKho;
using Project.NET.GUI_UC.PageKhuyenMai;
using Project.NET.GUI_UC.PageNhaCungCap;
using Project.NET.GUI_UC.PageNhanVien;
using Project.NET.GUI_UC.PageSanPham;
using Project.NET.GUI_UC.PageBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Project.NET.GUI_UC
{
    public partial class Menu_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Fields
        private List<SimpleButton> list_btnQuanLy;
        private List<SimpleButton> list_btnNhanVien;
        private NhanVien_BUS db_NV = new NhanVien_BUS();

        //Chuyển đến form khác sau khi đăng nhập thành công
        frmMain frmMainn = Application.OpenForms.OfType<frmMain>().FirstOrDefault();

        // Nút bấm menu navbar cuối cùng được nhấn
        private SimpleButton lastClickButton = null;

        //Constructor
        public Menu_UC()
        {
            InitializeComponent();
            loadingFirstOrDeFaultNavbarMenuButton();
            list_btnNhanVien = new List<SimpleButton>() { btnKho, btnHoaDon, btnKhachHang, btnBanHang, btnThongKe, btnBaoCao, btnSanPham };
            list_btnQuanLy = new List<SimpleButton>() { btnTaiKhoan, btnNhanVien, btnChiNhanh, btnNhaCungCap, btnKhuyenMai };
            list_btnQuanLy.AddRange(list_btnNhanVien);
        }

        //Methods
        /// <summary>
        /// Khởi động các nút trong danh sách
        /// </summary>
        /// <param name="list">Danh sách các nút</param>
        /// <param name="check">Trạng thái</param>
        private void listButtonsVision(List<SimpleButton> list, bool check)
        {
            foreach(SimpleButton button in list)
            {
                button.Enabled = check;
            }
        }

        //Events
        /// <summary>
        /// Tải mặc định menu đầu tiên là menu tài khoản và tô đậm nút tài khoản menu navbar
        /// </summary>
        private void loadingFirstOrDeFaultNavbarMenuButton()
        {
            // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
            if (btnTaiKhoan != null)
            {
                SimpleButton currentButton = btnTaiKhoan;
                currentButton.UpdateButtonStyle(lastClickButton);
                //
                // Cập nhật trạng thái cho nút đang được nhấn
                //
                lastClickButton = currentButton;

                // Loading default tài khoản tab
                LoadUserControl(null, typeof(TaiKhoan_UC), editFormTaiKhoan);
            }
            else
            {
                MessageBox.Show("Khong biet nut nay!");
            }
        }

        /// <summary>
        /// Xử lý sự kiện cho các nút bấm trên nav menu buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private async void Button_Click(object sender, EventArgs e)
        {
            try
            {
                WaitFormManager waitFormManager = new WaitFormManager(frmMainn);
                await waitFormManager.ShowWaitForm(() => {

                    // Sử dụng Invoke để đảm bảo rằng mã được thực thi trên thread chính
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                        SimpleButton currentButton = (SimpleButton)sender;
                        currentButton.UpdateButtonStyle(lastClickButton);

                        //
                        // Cập nhật trạng thái cho nút đang được nhấn
                        //
                        lastClickButton = currentButton;
                        //
                        // Giải phóng tài nguyên cho NavFrame cũ
                        //
                        ReleaseAllResources(nafContent);
                        //
                        // Kiểm tra nút được nhấn là nút nào, chuyển tài nguyên tương ứng
                        //
                        switch (currentButton.Name)
                        {
                            case "btnTaiKhoan":
                                nafContent.SelectedPage = navTaiKhoan;
                                LoadUserControl(null, typeof(TaiKhoan_UC), editFormTaiKhoan);
                                break;
                            case "btnNhanVien":
                                nafContent.SelectedPage = navNhanVien;
                                LoadUserControl(null, typeof(NhanVien_UC), editFormNhanVien);
                                LoadUserControl(null, typeof(ThongKeNhanVien_UC), editFormThongKeNhanVien);
                                LoadUserControl(null, typeof(CaLam_UC), editFormCaLam);
                                LoadUserControl(null, typeof(PhanCong_UC), editFormPhanCong);
                                LoadUserControl(null, typeof(ViTriChucVuNV_UC), editFormViTriChucVuNV);
                                break;
                            case "btnKho":
                                nafContent.SelectedPage = navKho;
                                LoadUserControl(null, typeof(KhoCN_UC), editFormKho);
                                LoadUserControl(null, typeof(ThongKeKhoCN_UC), editFormThongKeKho);
                                break;
                            case "btnSanPham":
                                nafContent.SelectedPage = navSanPham;
                                LoadUserControl(null, typeof(SanPham_UC), editFormSanPham);
                                LoadUserControl(null, typeof(LoaiSanPham_UC), editFormLoaiSP);
                                LoadUserControl(null, typeof(ThongKeSanPham_UC), editFormThongKeSanPham);
                                break;
                            case "btnKhuyenMai":
                                nafContent.SelectedPage = navKhuyenMai;
                                LoadUserControl(null, typeof(KhuyenMai_UC), editFormKhuyenMai);
                                LoadUserControl(null, typeof(ChiTietKhuyenMai_UC), editFormChiTietKhuyenMai);
                                LoadUserControl(null, typeof(ThongKeKhuyenMai_UC), editFormThongKeKhuyenMai);
                                break;
                            case "btnKhachHang":
                                nafContent.SelectedPage = navKhachHang;
                                LoadUserControl(null, typeof(KhachHang_UC), editFormKhachHang);
                                break;
                            case "btnHoaDon":
                                nafContent.SelectedPage = navHoaDon;
                                LoadUserControl(null, typeof(HoaDon_UC), editFormHoaDon);
                                LoadUserControl(null, typeof(HoaDonChiTiet_UC), editFormHoaDonChiTiet);
                                break;
                            case "btnChiNhanh":
                                nafContent.SelectedPage = navChiNhanh;
                                LoadUserControl(null, typeof(ChiNhanh_UC), editFormChiNhanh);
                                LoadUserControl(null, typeof(KhuVuc_UC), editFormKhuVuc);
                                break;
                            case "btnNhaCungCap":
                                nafContent.SelectedPage = navNhaCungCap;
                                LoadUserControl(null, typeof(NhaCungCap_UC), editFormNhaCungCap);
                                LoadUserControl(null, typeof(ChiTietCC_UC), editFormChiTietCC);
                                break;
                            case "btnBaoCao":
                                nafContent.SelectedPage = navBaoCao;
                                LoadUserControl(null, typeof(BaoCao_UC), editFormBaoCao);
                                break;
                            case "btnThongKe":
                                nafContent.SelectedPage = navThongKe;
                                LoadUserControl(null, typeof(ThongKeMonth_UC), editFormThongKeMonth);
                                LoadUserControl(null, typeof(ThongKeYear_UC), editFormThongKeYear);
                                break;
                            case "btnBanHang":
                                nafContent.SelectedPage = navBanHang;
                                LoadUserControl(null, typeof(BanHang_UC), editFormBanHang);
                                 
                                break;
                            case "btnDangXuat":
                                //Quay lại màn hình login

                                break;
                            default:
                                throw new Exception("Unknown button.");
                        }
                    });
                    return Task.CompletedTask;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadUserControl(UserControl userControl, Type type, Control container)
        {
            ReleaseAllResources(container);
            
            if (userControl == null)
            {
                userControl = (UserControl)Activator.CreateInstance(type);
                userControl.Dock = DockStyle.Fill;
                container.Dock = DockStyle.Fill;
                container.Controls.Add(userControl);
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
        private void editFormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                //Tìm thông tin nhân viên vừa đăng nhập
                NhanVien_DTO nv = db_NV.timTheoMa(frmMain.maNV);
                if (nv != null)
                {
                    //Tắt tất cả các nút
                    listButtonsVision(list_btnQuanLy, false);
                    //Mở các nút mà nhân viên trên được phép sử dụng
                    switch (nv.MaVT.Trim())
                    {
                        case "VT00":
                        case "VT01": //Quản lý
                            listButtonsVision(list_btnQuanLy, true);
                            break;
                        default: //Nhân viên
                            listButtonsVision(list_btnNhanVien, true);
                            break;
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy nhân viên " + frmMain.maNV);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
