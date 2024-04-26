namespace Project.NET.GUI_UC
{
    partial class ThongKeYear_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeYear_UC));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartyear = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.btnThongKeNam = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartDoanhThuNam = new DevExpress.XtraCharts.ChartControl();
            this.txtHoaDonTheoNam = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoaDonTheoNam.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartyear
            // 
            this.chartyear.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.chartyear.Appearance.Options.UseBackColor = true;
            this.chartyear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartyear.Location = new System.Drawing.Point(0, 0);
            this.chartyear.Name = "chartyear";
            // 
            // chartyear.Panel1
            // 
            this.chartyear.Panel1.Controls.Add(this.groupControl1);
            this.chartyear.Panel1.Text = "Panel1";
            // 
            // chartyear.Panel2
            // 
            this.chartyear.Panel2.Controls.Add(this.chartDoanhThuNam);
            this.chartyear.Panel2.Text = "Panel2";
            this.chartyear.Size = new System.Drawing.Size(776, 725);
            this.chartyear.SplitterPosition = 494;
            this.chartyear.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tablePanel6);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(494, 725);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Lọc kết quả tìm kiếm";
            // 
            // tablePanel6
            // 
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.37F)});
            this.tablePanel6.Controls.Add(this.layoutControl3);
            this.tablePanel6.Controls.Add(this.dataGridView1);
            this.tablePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel6.Location = new System.Drawing.Point(2, 23);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 122F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel6.Size = new System.Drawing.Size(490, 700);
            this.tablePanel6.TabIndex = 1;
            this.tablePanel6.UseSkinIndents = true;
            // 
            // layoutControl3
            // 
            this.tablePanel6.SetColumn(this.layoutControl3, 0);
            this.layoutControl3.Controls.Add(this.btnThongKeNam);
            this.layoutControl3.Controls.Add(this.txtHoaDonTheoNam);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(13, 12);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.tablePanel6.SetRow(this.layoutControl3, 0);
            this.layoutControl3.Size = new System.Drawing.Size(464, 118);
            this.layoutControl3.TabIndex = 1;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // btnThongKeNam
            // 
            this.btnThongKeNam.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeNam.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThongKeNam.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeNam.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThongKeNam.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeNam.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThongKeNam.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnThongKeNam.AppearanceDisabled.Options.UseFont = true;
            this.btnThongKeNam.AppearanceDisabled.Options.UseForeColor = true;
            this.btnThongKeNam.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeNam.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeNam.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeNam.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThongKeNam.AppearanceHovered.Options.UseBackColor = true;
            this.btnThongKeNam.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThongKeNam.AppearanceHovered.Options.UseFont = true;
            this.btnThongKeNam.AppearanceHovered.Options.UseForeColor = true;
            this.btnThongKeNam.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThongKeNam.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongKeNam.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThongKeNam.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnThongKeNam.AppearancePressed.Options.UseBackColor = true;
            this.btnThongKeNam.AppearancePressed.Options.UseBorderColor = true;
            this.btnThongKeNam.AppearancePressed.Options.UseFont = true;
            this.btnThongKeNam.AppearancePressed.Options.UseForeColor = true;
            this.btnThongKeNam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThongKeNam.ImageOptions.SvgImage")));
            this.btnThongKeNam.Location = new System.Drawing.Point(12, 70);
            this.btnThongKeNam.Name = "btnThongKeNam";
            this.btnThongKeNam.Size = new System.Drawing.Size(440, 36);
            this.btnThongKeNam.StyleController = this.layoutControl3;
            this.btnThongKeNam.TabIndex = 8;
            this.btnThongKeNam.Text = "Xem thống kê";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem9,
            this.layoutControlItem8});
            this.layoutControlGroup2.Name = "layoutControlGroup1";
            this.layoutControlGroup2.Size = new System.Drawing.Size(464, 118);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 46);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(444, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnThongKeNam;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(444, 40);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtHoaDonTheoNam;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(444, 46);
            this.layoutControlItem8.Text = "Nhập năm";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 13);
            // 
            // dataGridView1
            // 
            this.tablePanel6.SetColumn(this.dataGridView1, 0);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(13, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.tablePanel6.SetRow(this.dataGridView1, 1);
            this.dataGridView1.Size = new System.Drawing.Size(464, 553);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartDoanhThuNam
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartDoanhThuNam.Diagram = xyDiagram1;
            this.chartDoanhThuNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDoanhThuNam.Legend.Title.Text = "";
            this.chartDoanhThuNam.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThuNam.Name = "chartDoanhThuNam";
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            this.chartDoanhThuNam.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartDoanhThuNam.Size = new System.Drawing.Size(272, 725);
            this.chartDoanhThuNam.TabIndex = 0;
            // 
            // txtHoaDonTheoNam
            // 
            this.txtHoaDonTheoNam.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtHoaDonTheoNam.Location = new System.Drawing.Point(12, 28);
            this.txtHoaDonTheoNam.Name = "txtHoaDonTheoNam";
            this.txtHoaDonTheoNam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoaDonTheoNam.Properties.Appearance.Options.UseFont = true;
            this.txtHoaDonTheoNam.Properties.BeepOnError = true;
            this.txtHoaDonTheoNam.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.txtHoaDonTheoNam.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtHoaDonTheoNam.Properties.MaskSettings.Set("mask", "yyyy");
            this.txtHoaDonTheoNam.Properties.UseMaskAsDisplayFormat = true;
            this.txtHoaDonTheoNam.Size = new System.Drawing.Size(440, 26);
            this.txtHoaDonTheoNam.StyleController = this.layoutControl3;
            this.txtHoaDonTheoNam.TabIndex = 9;
            // 
            // ThongKeYear_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartyear);
            this.Name = "ThongKeYear_UC";
            this.Size = new System.Drawing.Size(776, 725);
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
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThuNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoaDonTheoNam.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl chartyear;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.SimpleButton btnThongKeNam;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraCharts.ChartControl chartDoanhThuNam;
        private DevExpress.XtraEditors.TextEdit txtHoaDonTheoNam;
    }
}
