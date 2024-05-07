using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using Project.NET.RP;
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
    public partial class BaoCao_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public BaoCao_UC()
        {
            InitializeComponent();
        }

        private void btnBaoCaoBanHangTheoNgay_Click(object sender, EventArgs e)
        {
            ReportPrintTool printTool = new ReportPrintTool(new BanHangTheoNgay_RP());
            printTool.ShowRibbonPreview();
        }
    }
}
