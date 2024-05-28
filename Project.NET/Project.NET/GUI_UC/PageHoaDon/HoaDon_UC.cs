using BUS;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DTO;
using Project.NET.RPT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageHoaDon
{
    public partial class HoaDon_UC : DevExpress.XtraEditors.XtraUserControl
    {
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private HoaDon_BUS db_HD = new HoaDon_BUS();
        private KhachHang_BUS db_KH = new KhachHang_BUS();
        private SanPham_BUS db_SP = new SanPham_BUS();
        private LoaiSP_BUS db_LSP = new LoaiSP_BUS();
        private ChiTietHD_BUS db_ct_HD = new ChiTietHD_BUS();
        List<SanPhamMua_DTO> dsMuaHang = new List<SanPhamMua_DTO>();
        private string maLoai_DangLoc = "";

        public HoaDon_UC()
        {
            InitializeComponent();
        }

        private void dgvGrid_Load(object sender, EventArgs e)
        {
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (dsMuaHang.Count > 0)
                {

                    //In hóa đơn (report) 
                    //ReportPrintTool printTool = new ReportPrintTool(new rptInHoaDon());
                    //printTool.ShowRibbonPreview();

                }
                else
                {
                    throw new Exception("Vui lòng chọn Hoa don de in");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HoaDon_UC_Load(object sender, EventArgs e)
        {
            //
            //Hiển thị danh sách hóa đơn
            //
            dgvGrid.DataSource = db_HD.LayDanhSach();

        }

        private void dgvHoaDon_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //ChiNhánh = cn.tenCN,
            //                SảnPhẩm = sp.tenSP,
            //                SốLượng = kho.soLuong,
            //int[] dong = dgvHoaDon.GetSelectedRows();
            //foreach (int i in dong)
            //{
            //    if (i >= 0)
            //    {
            //        //Lấy sản phẩm được chọn
            //        try
            //        {
            //            int count = 0;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //        txtSoLuong.Text = dgvKhoCN.GetRowCellValue(i, "SốLượng").ToString();
            //    }
            //}
            //dangThaoTac(true);
        }
    }
}
