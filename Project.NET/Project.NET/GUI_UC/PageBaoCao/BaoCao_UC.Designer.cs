namespace Project.NET.GUI_UC
{
    partial class BaoCao_UC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBaoCaoBanHangTheoNgay = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnBaoCaoBanHangTheoNgay
            // 
            this.btnBaoCaoBanHangTheoNgay.Location = new System.Drawing.Point(62, 64);
            this.btnBaoCaoBanHangTheoNgay.Name = "btnBaoCaoBanHangTheoNgay";
            this.btnBaoCaoBanHangTheoNgay.Size = new System.Drawing.Size(255, 41);
            this.btnBaoCaoBanHangTheoNgay.TabIndex = 2;
            this.btnBaoCaoBanHangTheoNgay.Text = "Xuất báo cáo doanh thu theo ngày";
            this.btnBaoCaoBanHangTheoNgay.Click += new System.EventHandler(this.btnBaoCaoBanHangTheoNgay_Click);
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.Options.UseFont = true;
            this.labelControl.Appearance.Options.UseForeColor = true;
            this.labelControl.Appearance.Options.UseTextOptions = true;
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelControl.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl.LineVisible = true;
            this.labelControl.Location = new System.Drawing.Point(0, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(391, 33);
            this.labelControl.TabIndex = 4;
            this.labelControl.Text = "Báo Cáo Doanh Thu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(62, 111);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(255, 41);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Xuất báo cáo doanh thu của từng nhân viên";
            // 
            // BaoCao_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.btnBaoCaoBanHangTheoNgay);
            this.Name = "BaoCao_UC";
            this.Size = new System.Drawing.Size(391, 216);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnBaoCaoBanHangTheoNgay;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
