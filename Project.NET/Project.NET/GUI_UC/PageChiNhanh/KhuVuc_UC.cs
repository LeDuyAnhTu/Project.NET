﻿using DevExpress.XtraEditors;
using Project.NET.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.NET.GUI_UC.PageChiNhanh
{
    public partial class KhuVuc_UC : DevExpress.XtraEditors.XtraUserControl
    {
        public KhuVuc_UC()
        {
            InitializeComponent();
        }

        private void txtMaKV_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportID();
        }

        private void txtTenKV_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            edit.SupportVietnamese();
        }
    }
}
