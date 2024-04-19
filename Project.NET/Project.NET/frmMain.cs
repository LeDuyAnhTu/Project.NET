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

namespace Project.NET
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            //MessageBox.Show("Form:\nwidth: " + this.Width + "; height: " + this.Height);
            MessageBox.Show("Navigation Frame:\nwidth: " + this.napLogin.Width + "; height: " + this.napLogin.Height);
            int padding_vertical = (int)(napLogin.Height - 400) / 2;
            this.pictureBox1.Location = new System.Drawing.Point(20, padding_vertical);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (re == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }
    }
}