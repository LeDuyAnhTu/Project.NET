using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Project.NET.RPT
{
    public partial class rptInHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInHoaDon(string maHD)
        {
            InitializeComponent();
            this.Parameters["maHD"].Value = maHD; 
            this.Parameters["maHD"].Visible = false;
        }

    }
}
