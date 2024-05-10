namespace Project.NET.GUI_UC
{
    partial class ThongKeMonth_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeMonth_UC));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.chartmonth = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupLocKetqua = new DevExpress.XtraEditors.GroupControl();
            this.tableLocKetQua = new DevExpress.Utils.Layout.TablePanel();
            this.layoutGroupLocKQ = new DevExpress.XtraLayout.LayoutControl();
            this.txtTKTenSP = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayLapHoaDonTu = new DevExpress.XtraEditors.DateEdit();
            this.txtNgayLapHoaDonDen = new DevExpress.XtraEditors.DateEdit();
            this.btnThongKeThang = new DevExpress.XtraEditors.SimpleButton();
            this.layoutThaoTac = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupThaoTacPanel = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutNgayNhapTu = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutNgayNhapDen = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutTxtTenSP = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutBtnXemTK = new DevExpress.XtraLayout.LayoutControlItem();
            this.dgvTongTienMatHang = new System.Windows.Forms.DataGridView();
            this.chartDoanhThuThang = new DevExpress.XtraCharts.ChartControl();
            this.marginbottom = new System.Windows.Forms.Panel();
            this.marrginbottomtable = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth.Panel1)).BeginInit();
            this.chartmonth.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth.Panel2)).BeginInit();
            this.chartmonth.Panel2.SuspendLayout();
            this.chartmonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupLocKetqua)).BeginInit();
            this.groupLocKetqua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableLocKetQua)).BeginInit();
            this.tableLocKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupLocKQ)).BeginInit();
            this.layoutGroupLocKQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTKTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonTu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonTu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonDen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonDen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutThaoTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThaoTacPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNgayNhapTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNgayNhapDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtTenSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnXemTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongTienMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.marginbottom.SuspendLayout();
            this.marrginbottomtable.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartmonth
            // 
            this.chartmonth.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.chartmonth.Appearance.Options.UseBackColor = true;
            this.chartmonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartmonth.Location = new System.Drawing.Point(3, 3);
            this.chartmonth.Name = "chartmonth";
            // 
            // chartmonth.Panel1
            // 
            this.chartmonth.Panel1.Controls.Add(this.groupLocKetqua);
            this.chartmonth.Panel1.Text = "Panel1";
            // 
            // chartmonth.Panel2
            // 
            this.chartmonth.Panel2.Controls.Add(this.chartDoanhThuThang);
            this.chartmonth.Panel2.Text = "Panel2";
            this.chartmonth.Size = new System.Drawing.Size(746, 575);
            this.chartmonth.SplitterPosition = 494;
            this.chartmonth.TabIndex = 1;
            // 
            // groupLocKetqua
            // 
            this.groupLocKetqua.Controls.Add(this.tableLocKetQua);
            this.groupLocKetqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLocKetqua.Location = new System.Drawing.Point(0, 0);
            this.groupLocKetqua.Name = "groupLocKetqua";
            this.groupLocKetqua.Size = new System.Drawing.Size(494, 575);
            this.groupLocKetqua.TabIndex = 0;
            this.groupLocKetqua.Text = "Lọc kết quả tìm kiếm";
            // 
            // tableLocKetQua
            // 
            this.tableLocKetQua.AutoScroll = true;
            this.tableLocKetQua.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.37F)});
            this.tableLocKetQua.Controls.Add(this.layoutGroupLocKQ);
            this.tableLocKetQua.Controls.Add(this.dgvTongTienMatHang);
            this.tableLocKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLocKetQua.Location = new System.Drawing.Point(2, 16);
            this.tableLocKetQua.Name = "tableLocKetQua";
            this.tableLocKetQua.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 248F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.tableLocKetQua.Size = new System.Drawing.Size(490, 557);
            this.tableLocKetQua.TabIndex = 1;
            this.tableLocKetQua.UseSkinIndents = true;
            // 
            // layoutGroupLocKQ
            // 
            this.tableLocKetQua.SetColumn(this.layoutGroupLocKQ, 0);
            this.layoutGroupLocKQ.Controls.Add(this.txtTKTenSP);
            this.layoutGroupLocKQ.Controls.Add(this.txtNgayLapHoaDonTu);
            this.layoutGroupLocKQ.Controls.Add(this.txtNgayLapHoaDonDen);
            this.layoutGroupLocKQ.Controls.Add(this.btnThongKeThang);
            this.layoutGroupLocKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutGroupLocKQ.Location = new System.Drawing.Point(7, 6);
            this.layoutGroupLocKQ.Name = "layoutGroupLocKQ";
            this.layoutGroupLocKQ.Root = this.layoutThaoTac;
            this.tableLocKetQua.SetRow(this.layoutGroupLocKQ, 0);
            this.layoutGroupLocKQ.Size = new System.Drawing.Size(476, 246);
            this.layoutGroupLocKQ.TabIndex = 1;
            this.layoutGroupLocKQ.Text = "layoutControl2";
            // 
            // txtTKTenSP
            // 
            this.txtTKTenSP.Location = new System.Drawing.Point(12, 42);
            this.txtTKTenSP.Name = "txtTKTenSP";
            this.txtTKTenSP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKTenSP.Properties.Appearance.Options.UseFont = true;
            this.txtTKTenSP.Properties.BeepOnError = true;
            this.txtTKTenSP.Properties.UseMaskAsDisplayFormat = true;
            this.txtTKTenSP.Size = new System.Drawing.Size(452, 26);
            this.txtTKTenSP.StyleController = this.layoutGroupLocKQ;
            this.txtTKTenSP.TabIndex = 4;
            this.txtTKTenSP.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTKTenSP_EditValueChanging);
            // 
            // txtNgayLapHoaDonTu
            // 
            this.txtNgayLapHoaDonTu.EditValue = null;
            this.txtNgayLapHoaDonTu.Location = new System.Drawing.Point(12, 86);
            this.txtNgayLapHoaDonTu.Name = "txtNgayLapHoaDonTu";
            this.txtNgayLapHoaDonTu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLapHoaDonTu.Properties.Appearance.Options.UseFont = true;
            this.txtNgayLapHoaDonTu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLapHoaDonTu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLapHoaDonTu.Size = new System.Drawing.Size(452, 26);
            this.txtNgayLapHoaDonTu.StyleController = this.layoutGroupLocKQ;
            this.txtNgayLapHoaDonTu.TabIndex = 5;
            // 
            // txtNgayLapHoaDonDen
            // 
            this.txtNgayLapHoaDonDen.EditValue = null;
            this.txtNgayLapHoaDonDen.Location = new System.Drawing.Point(12, 130);
            this.txtNgayLapHoaDonDen.Name = "txtNgayLapHoaDonDen";
            this.txtNgayLapHoaDonDen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLapHoaDonDen.Properties.Appearance.Options.UseFont = true;
            this.txtNgayLapHoaDonDen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLapHoaDonDen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayLapHoaDonDen.Size = new System.Drawing.Size(452, 26);
            this.txtNgayLapHoaDonDen.StyleController = this.layoutGroupLocKQ;
            this.txtNgayLapHoaDonDen.TabIndex = 6;
            // 
            // btnThongKeThang
            // 
            this.btnThongKeThang.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeThang.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThongKeThang.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeThang.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThongKeThang.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeThang.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThongKeThang.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnThongKeThang.AppearanceDisabled.Options.UseFont = true;
            this.btnThongKeThang.AppearanceDisabled.Options.UseForeColor = true;
            this.btnThongKeThang.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeThang.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeThang.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeThang.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeThang.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKeThang.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThongKeThang.AppearanceHovered.Options.UseFont = true;
            this.btnThongKeThang.AppearanceHovered.Options.UseForeColor = true;
            this.btnThongKeThang.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeThang.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeThang.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeThang.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnThongKeThang.AppearancePressed.Options.UseBackColor = true;
            this.btnThongKeThang.AppearancePressed.Options.UseBorderColor = true;
            this.btnThongKeThang.AppearancePressed.Options.UseFont = true;
            this.btnThongKeThang.AppearancePressed.Options.UseForeColor = true;
            this.btnThongKeThang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeThang.ImageOptions.SvgImage")));
            this.btnThongKeThang.Location = new System.Drawing.Point(6, 164);
            this.btnThongKeThang.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKeThang.Name = "btnThongKeThang";
            this.btnThongKeThang.Size = new System.Drawing.Size(464, 38);
            this.btnThongKeThang.StyleController = this.layoutGroupLocKQ;
            this.btnThongKeThang.TabIndex = 7;
            this.btnThongKeThang.Text = "Xem thống kê";
            this.btnThongKeThang.Click += new System.EventHandler(this.btnThongKeThang_Click);
            // 
            // layoutThaoTac
            // 
            this.layoutThaoTac.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutThaoTac.GroupBordersVisible = false;
            this.layoutThaoTac.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupThaoTacPanel,
            this.layoutBtnXemTK});
            this.layoutThaoTac.Name = "Root";
            this.layoutThaoTac.Size = new System.Drawing.Size(476, 246);
            this.layoutThaoTac.TextVisible = false;
            // 
            // groupThaoTacPanel
            // 
            this.groupThaoTacPanel.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutNgayNhapTu,
            this.layoutNgayNhapDen,
            this.layoutTxtTenSP});
            this.groupThaoTacPanel.Location = new System.Drawing.Point(0, 0);
            this.groupThaoTacPanel.Name = "groupThaoTacPanel";
            this.groupThaoTacPanel.Size = new System.Drawing.Size(466, 158);
            this.groupThaoTacPanel.Text = "Thao tác nhập thông tin";
            // 
            // layoutNgayNhapTu
            // 
            this.layoutNgayNhapTu.Control = this.txtNgayLapHoaDonTu;
            this.layoutNgayNhapTu.Location = new System.Drawing.Point(0, 44);
            this.layoutNgayNhapTu.Name = "layoutNgayNhapTu";
            this.layoutNgayNhapTu.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutNgayNhapTu.Size = new System.Drawing.Size(454, 44);
            this.layoutNgayNhapTu.Text = "Ngày lập phiếu thanh toán từ";
            this.layoutNgayNhapTu.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutNgayNhapTu.TextSize = new System.Drawing.Size(148, 13);
            // 
            // layoutNgayNhapDen
            // 
            this.layoutNgayNhapDen.Control = this.txtNgayLapHoaDonDen;
            this.layoutNgayNhapDen.CustomizationFormText = "Ngày lập phiếu thanh toán đến";
            this.layoutNgayNhapDen.Location = new System.Drawing.Point(0, 88);
            this.layoutNgayNhapDen.Name = "layoutNgayNhapDen";
            this.layoutNgayNhapDen.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutNgayNhapDen.Size = new System.Drawing.Size(454, 44);
            this.layoutNgayNhapDen.Text = "Ngày lập phiếu thanh toán đến";
            this.layoutNgayNhapDen.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutNgayNhapDen.TextSize = new System.Drawing.Size(148, 13);
            // 
            // layoutTxtTenSP
            // 
            this.layoutTxtTenSP.Control = this.txtTKTenSP;
            this.layoutTxtTenSP.Location = new System.Drawing.Point(0, 0);
            this.layoutTxtTenSP.Name = "layoutTxtTenSP";
            this.layoutTxtTenSP.Size = new System.Drawing.Size(454, 44);
            this.layoutTxtTenSP.Text = "Nhập tên sản phẩm";
            this.layoutTxtTenSP.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutTxtTenSP.TextSize = new System.Drawing.Size(148, 13);
            // 
            // layoutBtnXemTK
            // 
            this.layoutBtnXemTK.Control = this.btnThongKeThang;
            this.layoutBtnXemTK.Location = new System.Drawing.Point(0, 158);
            this.layoutBtnXemTK.Name = "layoutBtnXemTK";
            this.layoutBtnXemTK.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutBtnXemTK.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutBtnXemTK.Size = new System.Drawing.Size(466, 78);
            this.layoutBtnXemTK.TextSize = new System.Drawing.Size(0, 0);
            this.layoutBtnXemTK.TextVisible = false;
            // 
            // dgvTongTienMatHang
            // 
            this.tableLocKetQua.SetColumn(this.dgvTongTienMatHang, 0);
            this.dgvTongTienMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongTienMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTongTienMatHang.Location = new System.Drawing.Point(7, 254);
            this.dgvTongTienMatHang.Name = "dgvTongTienMatHang";
            this.tableLocKetQua.SetRow(this.dgvTongTienMatHang, 1);
            this.dgvTongTienMatHang.Size = new System.Drawing.Size(476, 296);
            this.dgvTongTienMatHang.TabIndex = 0;
            // 
            // chartDoanhThuThang
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartDoanhThuThang.Diagram = xyDiagram1;
            this.chartDoanhThuThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDoanhThuThang.Legend.Title.Text = "";
            this.chartDoanhThuThang.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThuThang.Name = "chartDoanhThuThang";
            series1.Name = "Series 1";
            this.chartDoanhThuThang.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartDoanhThuThang.Size = new System.Drawing.Size(244, 575);
            this.chartDoanhThuThang.TabIndex = 0;
            // 
            // marginbottom
            // 
            this.marginbottom.Controls.Add(this.marrginbottomtable);
            this.marginbottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marginbottom.Location = new System.Drawing.Point(0, 0);
            this.marginbottom.Name = "marginbottom";
            this.marginbottom.Size = new System.Drawing.Size(752, 627);
            this.marginbottom.TabIndex = 2;
            // 
            // marrginbottomtable
            // 
            this.marrginbottomtable.ColumnCount = 1;
            this.marrginbottomtable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.marrginbottomtable.Controls.Add(this.chartmonth, 0, 0);
            this.marrginbottomtable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marrginbottomtable.Location = new System.Drawing.Point(0, 0);
            this.marrginbottomtable.Name = "marrginbottomtable";
            this.marrginbottomtable.RowCount = 2;
            this.marrginbottomtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.7989F));
            this.marrginbottomtable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.201101F));
            this.marrginbottomtable.Size = new System.Drawing.Size(752, 627);
            this.marrginbottomtable.TabIndex = 0;
            // 
            // ThongKeMonth_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.marginbottom);
            this.Name = "ThongKeMonth_UC";
            this.Size = new System.Drawing.Size(752, 627);
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth.Panel1)).EndInit();
            this.chartmonth.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth.Panel2)).EndInit();
            this.chartmonth.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartmonth)).EndInit();
            this.chartmonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupLocKetqua)).EndInit();
            this.groupLocKetqua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableLocKetQua)).EndInit();
            this.tableLocKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupLocKQ)).EndInit();
            this.layoutGroupLocKQ.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTKTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonTu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonTu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonDen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayLapHoaDonDen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutThaoTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThaoTacPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNgayNhapTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNgayNhapDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtTenSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnXemTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongTienMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuThang)).EndInit();
            this.marginbottom.ResumeLayout(false);
            this.marrginbottomtable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl chartmonth;
        private DevExpress.XtraEditors.GroupControl groupLocKetqua;
        private DevExpress.Utils.Layout.TablePanel tableLocKetQua;
        private DevExpress.XtraLayout.LayoutControl layoutGroupLocKQ;
        private DevExpress.XtraEditors.TextEdit txtTKTenSP;
        private DevExpress.XtraEditors.DateEdit txtNgayLapHoaDonTu;
        private DevExpress.XtraEditors.DateEdit txtNgayLapHoaDonDen;
        private DevExpress.XtraEditors.SimpleButton btnThongKeThang;
        private DevExpress.XtraLayout.LayoutControlGroup layoutThaoTac;
        private DevExpress.XtraLayout.LayoutControlGroup groupThaoTacPanel;
        private DevExpress.XtraLayout.LayoutControlItem layoutNgayNhapTu;
        private DevExpress.XtraLayout.LayoutControlItem layoutNgayNhapDen;
        private DevExpress.XtraLayout.LayoutControlItem layoutTxtTenSP;
        private DevExpress.XtraLayout.LayoutControlItem layoutBtnXemTK;
        private System.Windows.Forms.DataGridView dgvTongTienMatHang;
        private DevExpress.XtraCharts.ChartControl chartDoanhThuThang;
        private System.Windows.Forms.Panel marginbottom;
        private System.Windows.Forms.TableLayoutPanel marrginbottomtable;
    }
}
