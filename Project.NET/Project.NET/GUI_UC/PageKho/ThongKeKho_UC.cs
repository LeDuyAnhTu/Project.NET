using DevExpress.XtraEditors;
using Project.NET.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageKho
{
    public partial class ThongKeKho_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public ThongKeKho_UC()
        {
            InitializeComponent();

            btnTKGiaTriKho.Click += Button_Click;
            btnTKSPTheoLoai.Click += Button_Click;
            btnTKTonKho.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo hoặc lấy UserControl mới dựa trên nút được nhấn
                SimpleButton clickedButton = (SimpleButton)sender;
                switch (clickedButton.Name)
                {
                    case "btnTKGiaTriKho":
                        nafContent.SelectedPage = navPageTKGiaTriKho;
                        break;
                    case "btnTKSPTheoLoai":
                        nafContent.SelectedPage = navPageTKSPTheoLoai;
                        break;
                    case "btnTKTonKho":
                        nafContent.SelectedPage = navPageTKTonKho;
                        break;
                    default:
                        throw new Exception("Unknown button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
