using BUS;
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
    public partial class TaiKhoan_UC : DevExpress.XtraEditors.XtraUserControl
    {
        //Properties
        private TaiKhoan_BUS db_TK = new TaiKhoan_BUS();
        private ViTri_BUS db_VT = new ViTri_BUS();
        private NhanVien_BUS db_NV = new NhanVien_BUS();

        //Constructors
        public TaiKhoan_UC()
        {
            InitializeComponent();
        }

        //Methods
        private void loadForm()
        {
            dgvTaiKhoanNhanVien.DataSource = db_TK.LayDanhSach();
            gridView1.SelectRow(0);
        }
        private TaiKhoan_DTO layDuLieu()
        {
            TaiKhoan_DTO temp = db_TK.timTaiKhoan_TenTK(txtTenTK.Text);
            temp.MatKhau = txtMatKhauTK.Text;
            return temp;
        }


        //Events
        private void TaiKhoan_UC_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTaiKhoanNhanVien.DataSource = db_TK.LayDanhSach();
                TaiKhoan_DTO tk = db_TK.timTaiKhoan_TenTK(gridView1.GetRowCellValue(0, "TênTàiKhoản").ToString());
                NhanVien_DTO nv = db_NV.timTheoMa(tk.MaNV);
                ViTri_DTO vt = db_VT.timTheoMa(nv.MaVT);

                txtMatKhauTK.Text = tk.MatKhau;
                txtTenTK.Text = tk.TenTK;
                txtViTriCuaHang.Text = vt.TenVT;
                cboNhanVien.Text = nv.TenNV;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                int[] dong = gridView1.GetSelectedRows();
                foreach (int i in dong)
                {
                    if (i >= 0)
                    {
                        TaiKhoan_DTO tk = db_TK.timTaiKhoan_TenTK(gridView1.GetRowCellValue(i, "TênTàiKhoản").ToString());
                        NhanVien_DTO nv = db_NV.timTheoMa(tk.MaNV);
                        ViTri_DTO vt = db_VT.timTheoMa(nv.MaVT);

                        txtMatKhauTK.Text = tk.MatKhau;
                        txtTenTK.Text = tk.TenTK;
                        txtViTriCuaHang.Text = vt.TenVT;
                        cboNhanVien.Text = nv.TenNV;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan_DTO temp_Sua = layDuLieu();
                db_TK.Sua(temp_Sua);
                MessageBox.Show("Cập nhật thành công !", "Thông báo");
                loadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
