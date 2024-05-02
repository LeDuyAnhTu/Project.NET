using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.NET
{
    public partial class frmWaiting : WaitForm
    {
        public frmWaiting()
        {
            InitializeComponent();
            this.manHinhChoMotChut.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.manHinhChoMotChut.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.manHinhChoMotChut.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}