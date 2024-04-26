using BUS;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.Forms
{
    public partial class NhanVien_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properies
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private ViTri_BUS db_VT = new ViTri_BUS();

        //Constructor
        public NhanVien_UC()
        {
            InitializeComponent();
        }

        //Methods
        private void taoIDMoi()
        {
            txtMaNV.Text = db_NV.taoMaMoi();
        }
        private NhanVien_DTO layDuLieu()
        {
            try
            {
                return new NhanVien_DTO(
                    txtMaNV.Text
                    , txtHoTen.Text
                    , txtGioiTinh.Text
                    , txtNgaySinh.DateTime
                    , txtSoDienThoai.Text, txtCCCD.Text
                    , Convert.ToInt32(txtLuongNV.Value)
                    , cboChiNhanh.SelectedText
                    , cboChiNhanh.SelectedText) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void NhanVien_UC_Load(object sender, EventArgs e)
        {
            taoIDMoi();
            dgvNhanVien.DataSource = db_NV.LayDanhSach();
        }
    }
}
