﻿using BUS;
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
        //Fields
        private CaLam_BUS db_CL = new CaLam_BUS();
        private NhanVien_BUS db_NV = new NhanVien_BUS();
        private ChiNhanh_BUS db_CN = new ChiNhanh_BUS();
        private ViTri_BUS db_VT = new ViTri_BUS();
        private PhanCong_BUS db_PC = new PhanCong_BUS();
        private CheckEdit[] dsNgayDiLam;

        //Constructors
        public PhanCong_UC()
        {
            InitializeComponent();
            dsNgayDiLam = new CheckEdit[] { ckThuHai, ckThuBa, ckThuTu, ckThuNam, ckThuSau, ckThuBay, ckChuNhat };
        }

        //Methods
        /// <summary>
        /// Hiển thị dữ liệu trong hệ thống
        /// </summary>
        public void taiForm()
        {
            //
            //Danh sách chi nhánh
            //
            cboChiNhanh.Properties.DataSource = db_CN.LayDanhSach();
            cboChiNhanh.Properties.ValueMember = "MãChiNhánh";
            cboChiNhanh.Properties.DisplayMember = "TênChiNhánh";

            //
            //Danh sách nhân viên
            //
            cboNhanVien.Properties.DataSource = db_NV.LayDanhSach();
            cboNhanVien.Properties.ValueMember = "MãSố";
            cboNhanVien.Properties.DisplayMember = "MãSố";
            cboNhanVien.ItemIndex = 0;

            //
            //Danh sách ca làm việc
            //
            cboCaLamViec.Properties.DataSource = db_CL.LayDanhSach();
            cboCaLamViec.Properties.ValueMember = "maCa";
            cboCaLamViec.Properties.DisplayMember = "tenCa";
            cboCaLamViec.ItemIndex = 0;

            //cboChiNhanh.ItemIndex = 0;
            //cboChiNhanh.ItemIndex = 1;
            //cboChiNhanh.ItemIndex = 0;
            //cboNhanVien.ItemIndex = 1;
            //cboNhanVien.ItemIndex = 0;
            //cboCaLamViec.ItemIndex = 1;
            //cboCaLamViec.ItemIndex = 0;
        }
        /// <summary>
        /// Lấy danh sách ngày làm việc của nhân viên theo ca làm và mã nhân viên 
        /// </summary>
        /// <param name="maNV"></param>
        /// <param name="maCa"></param>
        public void ngayLamViecTheoMaNV(string maNV, string maCa)
        {
            try
            {
                int[] ds = db_PC.timNgayDiLamTheoMaNV(maNV, maCa);
                int count = 0;
                foreach (CheckEdit item in dsNgayDiLam)
                {
                    item.Checked = ds[count] == 1;
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Hiện thị giờ làm việc của ca làm theo mã ca
        /// </summary>
        /// <param name="maCa"></param>
        public void gioLamViecTheoMaCa(string maCa)
        {
            try
            {
                CaLam_DTO cl = db_CL.giolamViec(cboCaLamViec.EditValue.ToString().Trim());
                txtGioBD.Text = cl.GioBD.ToString().Trim();
                txtGioKT.Text = cl.GioKT.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Lấy dữ liệu Phân công
        /// </summary>
        /// <returns></returns>
        public List<PhanCong_DTO> layDuNgayLamViec()
        {
            List<PhanCong_DTO> dsPhanCong = new List<PhanCong_DTO>();
            try
            {
                foreach (CheckEdit item in dsNgayDiLam)
                {
                    if (item.Checked)
                    {
                        dsPhanCong.Add(new PhanCong_DTO(cboNhanVien.EditValue.ToString().Trim(), item.Text, cboCaLamViec.EditValue.ToString().Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dsPhanCong;
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
            //Danh sách chi nhánh
            //
            cboChiNhanh.Properties.DataSource = db_CN.LayDanhSach();
            cboChiNhanh.Properties.ValueMember = "MãChiNhánh";
            cboChiNhanh.Properties.DisplayMember = "TênChiNhánh";
            cboChiNhanh.ItemIndex = 0;

            //
            //Danh sách nhân viên
            //
            cboNhanVien.Properties.DataSource = db_NV.LayDanhSach();
            cboNhanVien.Properties.ValueMember = "MãSố";
            cboNhanVien.Properties.DisplayMember = "MãSố";
            cboNhanVien.ItemIndex = 0;

            //
            //Danh sách ca làm việc
            //
            cboCaLamViec.Properties.DataSource = db_CL.LayDanhSach();
            cboCaLamViec.Properties.ValueMember = "maCa";
            cboCaLamViec.Properties.DisplayMember = "tenCa";
            cboCaLamViec.ItemIndex = 0;

            //
            //Danh sách phân công
            //
            //dgvPhanCongCaLamNhanVien.DataSource = db_PC.LayDanhSach();

        }
        /// <summary>
        /// Tải lại form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi1_Click(object sender, EventArgs e)
        {
            cboNhanVien.ItemIndex = 0;
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
                    cboCaLamViec.ItemIndex = 1;
                    cboCaLamViec.ItemIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Hiển thị thời gian làm việc của ca được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCaLamViec_EditValueChanged(object sender, EventArgs e)
        {
            string maNV = cboNhanVien.EditValue.ToString();
            string maCa = cboCaLamViec.EditValue.ToString();
            if (maNV != null && maCa != null)
            {
                ngayLamViecTheoMaNV(maNV, maCa);
                gioLamViecTheoMaCa(maCa);
            }
        }
        /// <summary>
        /// Lọc nhân viên theo chi nhánh đã chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboChiNhanh_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit edit = (LookUpEdit)sender;
            string maCN = edit.EditValue.ToString();
            cboNhanVien.Properties.DataSource = db_NV.LayDanhSach_ChiNhanh_NhanVien(maCN);
        }
        /// <summary>
        /// Cập nhật thông tin phân công
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                //Xóa bảng phân công cũ
                db_PC.Xoa(cboNhanVien.EditValue.ToString().Trim(), cboCaLamViec.EditValue.ToString().Trim());
                //Thêm phân công mới theo ca hiện tại cho nhân viên txtHoTen
                foreach (CheckEdit ngay in dsNgayDiLam)
                {
                    if (ngay.Checked)
                    {
                        PhanCong_DTO pc_temp = new PhanCong_DTO(cboNhanVien.EditValue.ToString().Trim(), ngay.Text, cboCaLamViec.EditValue.ToString().Trim());
                        db_PC.Them(pc_temp);
                    }
                }
                //Thông báo
                MessageBox.Show("Phân công hoàn tất !");

                //Tải lại dữ liệu (làm mới form)
                taiForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        /// <summary>
        /// Xóa thông tin phân công của nhân viên đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult luaChon = MessageBox.Show("Bạn có muốn hủy phân công " + cboCaLamViec.Text.Trim() + " của nhân viên " + txtHoTen.Text.Trim() + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (luaChon == DialogResult.Yes)
            {
                try
                {
                    //Xóa bảng phân công cũ
                    db_PC.Xoa(cboNhanVien.EditValue.ToString().Trim(), cboCaLamViec.EditValue.ToString().Trim());

                    //Thông báo
                    MessageBox.Show("Phân công hoàn tất !");

                    //Tải lại dữ liệu (làm mới form)
                    taiForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }
    }
}
