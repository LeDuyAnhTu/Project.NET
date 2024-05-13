using DevExpress.Charts.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Project.NET.RP
{
    public partial class InHoaDon_RPT : DevExpress.XtraReports.UI.XtraReport
    {
        private string maHD = "";
        public InHoaDon_RPT(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

    }
}
