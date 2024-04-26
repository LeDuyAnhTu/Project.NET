using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;

namespace Project.NET.GUI_UC
{
    public partial class ThongKeNhanVien_UC : DevExpress.XtraEditors.XtraUserControl
    {
         

        Loading_UC loading_UC;


        public ThongKeNhanVien_UC()
        {
            InitializeComponent();

            // khoi tao loading_uc
            loading_UC = new Loading_UC();
            loading_UC.Dock = DockStyle.Fill;
            loading_UC.Visible = false;

            // them loadinguc vao form
            this.Controls.Add(loading_UC);
            this.Controls.SetChildIndex(loading_UC, 0);
        }
        
       


        private void btnSoGioDiMuonVeSomTheoTG_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageSoGioDMVSTheoTG;
        }


        private void btnTongNVTheoPB_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageTongNhanVienTheoPhongBan;

            //var result = from nv in db.NhanViens
            //             group nv by nv.maCN into g
            //             join vt in db.ChiNhanhs on g.Key equals vt.maCN
            //             select new { StoreName = vt.tenCN, EmployeeCount = g.Count() };

            //// xóa tất cả danh sách cột
            //chartTongNhanVienTheoPhongBan.Series.Clear();

            //Series series = new Series("Tổng nhân viên theo Phòng ban", ViewType.Bar);

            //foreach (var item in result)
            //{
            //    series.Points.Add(new SeriesPoint(item.StoreName, item.EmployeeCount));
            //}

            //chartTongNhanVienTheoPhongBan.Series.Add(series);
        }

        private void btnCoCauNVTheoPB_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageCoCauNhanVienTheoPhongBan;
        }

        private void btnSoGioDMVS_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageSoGioDMVS;
        }

        private void btnCoCauTanXuatDMVS_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageSoGioDMVS;
        }

        private void btnCoCauSoGioDMVS_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageCoCauTanSuatDMVS;
        }

        private void btnTongNVTheoChucVu_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageTongNhanVienTheoChucVu;
        }

        private void btnCoCauNVTheoChucVu_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageCoCauNhanVienTheoChucVu;
        }

        private void btnTanXuatDMVS_Click(object sender, EventArgs e)
        {
            navFrameTKNhanVien.SelectedPage = navPageTongNhanVienTheoPhongBan;
        }

        private void ThongKeNhanVien_UC_Load(object sender, EventArgs e)
        {
            //
            // hien thi man hinh oading
            //
            loading_UC.Visible = true;
            loading_UC.BringToFront();

            //
            // tai du lieu
            //
            firstPageOrDefault();

            //
            // an man hih loading
            //
            loading_UC.Visible = false;
        }
        public void firstPageOrDefault()
        {
            navFrameTKNhanVien.SelectedPage = navPageTongNhanVienTheoPhongBan;

            //var result = from nv in db.NhanViens
            //             group nv by nv.maCN into g
            //             join vt in db.ChiNhanhs on g.Key equals vt.maCN
            //             select new { StoreName = vt.tenCN, EmployeeCount = g.Count() };
            
            //// xóa tất cả danh sách cột
            //chartTongNhanVienTheoPhongBan.Series.Clear();

            //Series series = new Series("Tổng nhân viên theo Phòng ban", ViewType.Bar);

            //foreach (var item in result)
            //{
            //    series.Points.Add(new SeriesPoint(item.StoreName, item.EmployeeCount));
            //}

            //chartTongNhanVienTheoPhongBan.Series.Add(series);
        }
    }
}
