namespace Project.NET.GUI_UC.PageThongKe
{
    partial class ThongKeDoanhThuSanPham_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeDoanhThuSanPham_UC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartyear = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThongKeSanPhamTonKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKeSanPhamBanE = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKeSanPhamBanChay = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartyear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartyear.Panel1)).BeginInit();
            this.chartyear.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartyear.Panel2)).BeginInit();
            this.chartyear.Panel2.SuspendLayout();
            this.chartyear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 669);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartyear, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.90909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1146, 669);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartyear
            // 
            this.chartyear.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.chartyear.Appearance.Options.UseBackColor = true;
            this.chartyear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartyear.Location = new System.Drawing.Point(3, 3);
            this.chartyear.Name = "chartyear";
            // 
            // chartyear.Panel1
            // 
            this.chartyear.Panel1.Controls.Add(this.groupControl1);
            this.chartyear.Panel1.Text = "Panel1";
            // 
            // chartyear.Panel2
            // 
            this.chartyear.Panel2.Controls.Add(this.chart);
            this.chartyear.Panel2.Text = "Panel2";
            this.chartyear.Size = new System.Drawing.Size(1140, 602);
            this.chartyear.SplitterPosition = 494;
            this.chartyear.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tablePanel6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(494, 602);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Lọc kết quả tìm kiếm";
            // 
            // tablePanel6
            // 
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.37F)});
            this.tablePanel6.Controls.Add(this.layoutControl3);
            this.tablePanel6.Controls.Add(this.dgvDoanhThu);
            this.tablePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel6.Location = new System.Drawing.Point(2, 16);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 136F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel6.Size = new System.Drawing.Size(490, 584);
            this.tablePanel6.TabIndex = 1;
            this.tablePanel6.UseSkinIndents = true;
            // 
            // layoutControl3
            // 
            this.tablePanel6.SetColumn(this.layoutControl3, 0);
            this.layoutControl3.Controls.Add(this.btnThongKeSanPhamTonKho);
            this.layoutControl3.Controls.Add(this.btnThongKeSanPhamBanE);
            this.layoutControl3.Controls.Add(this.btnThongKeSanPhamBanChay);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(7, 6);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(847, 0, 650, 400);
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.tablePanel6.SetRow(this.layoutControl3, 0);
            this.layoutControl3.Size = new System.Drawing.Size(476, 134);
            this.layoutControl3.TabIndex = 1;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // btnThongKeSanPhamTonKho
            // 
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.Options.UseFont = true;
            this.btnThongKeSanPhamTonKho.AppearanceDisabled.Options.UseForeColor = true;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamTonKho.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.Options.UseFont = true;
            this.btnThongKeSanPhamTonKho.AppearanceHovered.Options.UseForeColor = true;
            this.btnThongKeSanPhamTonKho.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamTonKho.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeSanPhamTonKho.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamTonKho.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnThongKeSanPhamTonKho.AppearancePressed.Options.UseBackColor = true;
            this.btnThongKeSanPhamTonKho.AppearancePressed.Options.UseBorderColor = true;
            this.btnThongKeSanPhamTonKho.AppearancePressed.Options.UseFont = true;
            this.btnThongKeSanPhamTonKho.AppearancePressed.Options.UseForeColor = true;
            this.btnThongKeSanPhamTonKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeSanPhamTonKho.ImageOptions.SvgImage")));
            this.btnThongKeSanPhamTonKho.Location = new System.Drawing.Point(6, 86);
            this.btnThongKeSanPhamTonKho.Name = "btnThongKeSanPhamTonKho";
            this.btnThongKeSanPhamTonKho.Size = new System.Drawing.Size(464, 38);
            this.btnThongKeSanPhamTonKho.StyleController = this.layoutControl3;
            this.btnThongKeSanPhamTonKho.TabIndex = 10;
            this.btnThongKeSanPhamTonKho.Text = "Xem thống kê sản phẩm tồn kho";
            this.btnThongKeSanPhamTonKho.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnThongKeSanPhamBanE
            // 
            this.btnThongKeSanPhamBanE.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamBanE.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.Options.UseFont = true;
            this.btnThongKeSanPhamBanE.AppearanceDisabled.Options.UseForeColor = true;
            this.btnThongKeSanPhamBanE.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamBanE.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeSanPhamBanE.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamBanE.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeSanPhamBanE.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKeSanPhamBanE.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThongKeSanPhamBanE.AppearanceHovered.Options.UseFont = true;
            this.btnThongKeSanPhamBanE.AppearanceHovered.Options.UseForeColor = true;
            this.btnThongKeSanPhamBanE.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamBanE.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeSanPhamBanE.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamBanE.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnThongKeSanPhamBanE.AppearancePressed.Options.UseBackColor = true;
            this.btnThongKeSanPhamBanE.AppearancePressed.Options.UseBorderColor = true;
            this.btnThongKeSanPhamBanE.AppearancePressed.Options.UseFont = true;
            this.btnThongKeSanPhamBanE.AppearancePressed.Options.UseForeColor = true;
            this.btnThongKeSanPhamBanE.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeSanPhamBanE.ImageOptions.SvgImage")));
            this.btnThongKeSanPhamBanE.Location = new System.Drawing.Point(6, 46);
            this.btnThongKeSanPhamBanE.Name = "btnThongKeSanPhamBanE";
            this.btnThongKeSanPhamBanE.Size = new System.Drawing.Size(464, 38);
            this.btnThongKeSanPhamBanE.StyleController = this.layoutControl3;
            this.btnThongKeSanPhamBanE.TabIndex = 9;
            this.btnThongKeSanPhamBanE.Text = "Xem thống kê sản phẩm bán ít";
            this.btnThongKeSanPhamBanE.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnThongKeSanPhamBanChay
            // 
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.Options.UseFont = true;
            this.btnThongKeSanPhamBanChay.AppearanceDisabled.Options.UseForeColor = true;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamBanChay.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.Options.UseFont = true;
            this.btnThongKeSanPhamBanChay.AppearanceHovered.Options.UseForeColor = true;
            this.btnThongKeSanPhamBanChay.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeSanPhamBanChay.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeSanPhamBanChay.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeSanPhamBanChay.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnThongKeSanPhamBanChay.AppearancePressed.Options.UseBackColor = true;
            this.btnThongKeSanPhamBanChay.AppearancePressed.Options.UseBorderColor = true;
            this.btnThongKeSanPhamBanChay.AppearancePressed.Options.UseFont = true;
            this.btnThongKeSanPhamBanChay.AppearancePressed.Options.UseForeColor = true;
            this.btnThongKeSanPhamBanChay.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeSanPhamBanChay.ImageOptions.SvgImage")));
            this.btnThongKeSanPhamBanChay.Location = new System.Drawing.Point(6, 6);
            this.btnThongKeSanPhamBanChay.Name = "btnThongKeSanPhamBanChay";
            this.btnThongKeSanPhamBanChay.Size = new System.Drawing.Size(464, 38);
            this.btnThongKeSanPhamBanChay.StyleController = this.layoutControl3;
            this.btnThongKeSanPhamBanChay.TabIndex = 8;
            this.btnThongKeSanPhamBanChay.Text = "Xem thống kê sản phẩm bán nhiều";
            this.btnThongKeSanPhamBanChay.Click += new System.EventHandler(this.Button_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem9,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(476, 134);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnThongKeSanPhamBanChay;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(466, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnThongKeSanPhamBanE;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(466, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnThongKeSanPhamTonKho;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(466, 44);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.tablePanel6.SetColumn(this.dgvDoanhThu, 0);
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(7, 142);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.tablePanel6.SetRow(this.dgvDoanhThu, 1);
            this.dgvDoanhThu.Size = new System.Drawing.Size(476, 435);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Title.Text = "";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Aspect";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.Size = new System.Drawing.Size(638, 602);
            this.chart.TabIndex = 0;
            // 
            // ThongKeDoanhThuSanPham_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ThongKeDoanhThuSanPham_UC";
            this.Size = new System.Drawing.Size(1146, 669);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartyear.Panel1)).EndInit();
            this.chartyear.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartyear.Panel2)).EndInit();
            this.chartyear.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartyear)).EndInit();
            this.chartyear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SplitContainerControl chartyear;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.SimpleButton btnThongKeSanPhamTonKho;
        private DevExpress.XtraEditors.SimpleButton btnThongKeSanPhamBanE;
        private DevExpress.XtraEditors.SimpleButton btnThongKeSanPhamBanChay;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private DevExpress.XtraCharts.ChartControl chart;
    }
}
