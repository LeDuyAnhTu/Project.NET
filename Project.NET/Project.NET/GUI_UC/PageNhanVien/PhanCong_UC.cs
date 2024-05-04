using BUS;
using DevExpress.Utils.VisualEffects;
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

namespace Project.NET.GUI_UC
{
    public partial class PhanCong_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properties
        private CaLam_BUS db_CL = new CaLam_BUS();
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private ViTri_BUS db_VT = new ViTri_BUS();

        //Constructors
        public PhanCong_UC()
        {
            InitializeComponent();
        }

        //Methods
        public void loadForm()
        {

        }

        //Events
        /// <summary>
        /// Thực hiện tải dữ liệu khi tải form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhanCong_UC_Load(object sender, EventArgs e)
        {
            //
            //Danh sách ca làm việc
            //
            cboCaLamViec.Properties.DataSource = db_CL.LayDanhSach();
            cboCaLamViec.Properties.ValueMember = "maCa";
            cboCaLamViec.Properties.DisplayMember = "tenCa";
            cboCaLamViec.ItemIndex = 0;

            //
            //Danh sách nhân viên
            //
            cboNhanVien.Properties.DataSource = db_NV.LayDanhSach();
            cboNhanVien.Properties.ValueMember = "maNV";
            cboNhanVien.Properties.DisplayMember = "maNV";
            cboNhanVien.ItemIndex = 0;
            
            //
            //Danh sách chi nhánh
            //
            cboChiNhanh.Properties.DataSource = db_CN.LayDanhSach();
            cboChiNhanh.Properties.ValueMember = "maCN";
            cboChiNhanh.Properties.DisplayMember = "tenCN";
            cboChiNhanh.ItemIndex = 0;
        }

        private void btnLamMoi1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboNhanVien.EditValue.ToString());
        }
        /// <summary>
        /// Hiện thị thông tin nhân viên được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                NhanVien_DTO nv_Selected = db_NV.timTheoMa(cboNhanVien.EditValue.ToString().Trim());
                if (nv_Selected != null)
                {
                    txtHoTen.Text = nv_Selected.TenNV;
                    txtTenViTriChucVuNhanVien.Text = db_VT.timTheoMa(nv_Selected.MaVT).TenVT;
                    txtGioiTinh.Text = nv_Selected.GioiTinh;
                    txtNgaySinh.Text = (nv_Selected.NgaySinh).ToShortDateString();
                    txtSoDienThoai.Text = nv_Selected.SDT;
                    txtCCCD.Text = nv_Selected.CCCD;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboCaLamViec_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CaLam_DTO nv_Selected = db_CL.timTheoMa(cboCaLamViec.EditValue.ToString().Trim());
                if (nv_Selected != null)
                {
                    txtGioBD.Text = nv_Selected.GioBD;
                    txtGioKT.Text = nv_Selected.GioKT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
