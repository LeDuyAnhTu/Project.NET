namespace Project.NET.GUI_UC.PageKhuyenMai
{
    partial class ThongKeKhuyenMai_UC
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.TABLE_UC = new DevExpress.Utils.Layout.TablePanel();
            this.CHARTS = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.nafContent = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageTKKhuyenMai = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.chartTKKhuyenMai = new DevExpress.XtraCharts.ChartControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupFrame = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutChart = new DevExpress.XtraLayout.LayoutControlItem();
            this.BUTTONS = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnTKKhuyenMai = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_UC)).BeginInit();
            this.TABLE_UC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CHARTS)).BeginInit();
            this.CHARTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nafContent)).BeginInit();
            this.nafContent.SuspendLayout();
            this.navPageTKKhuyenMai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTONS)).BeginInit();
            this.BUTTONS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // TABLE_UC
            // 
            this.TABLE_UC.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.TABLE_UC.Controls.Add(this.CHARTS);
            this.TABLE_UC.Controls.Add(this.BUTTONS);
            this.TABLE_UC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABLE_UC.Location = new System.Drawing.Point(0, 0);
            this.TABLE_UC.Name = "TABLE_UC";
            this.TABLE_UC.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 52F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 20F)});
            this.TABLE_UC.Size = new System.Drawing.Size(728, 673);
            this.TABLE_UC.TabIndex = 3;
            this.TABLE_UC.UseSkinIndents = true;
            // 
            // CHARTS
            // 
            this.TABLE_UC.SetColumn(this.CHARTS, 0);
            this.CHARTS.Controls.Add(this.nafContent);
            this.CHARTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CHARTS.Location = new System.Drawing.Point(13, 64);
            this.CHARTS.Name = "CHARTS";
            this.CHARTS.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(993, 414, 650, 400);
            this.CHARTS.Root = this.groupFrame;
            this.TABLE_UC.SetRow(this.CHARTS, 1);
            this.CHARTS.Size = new System.Drawing.Size(702, 596);
            this.CHARTS.TabIndex = 1;
            this.CHARTS.Text = "dataLayoutControl1";
            // 
            // nafContent
            // 
            this.nafContent.Controls.Add(this.navPageTKKhuyenMai);
            this.nafContent.Location = new System.Drawing.Point(12, 12);
            this.nafContent.Name = "nafContent";
            this.nafContent.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPageTKKhuyenMai});
            this.nafContent.SelectedPage = this.navPageTKKhuyenMai;
            this.nafContent.Size = new System.Drawing.Size(678, 572);
            this.nafContent.TabIndex = 4;
            this.nafContent.Text = "navFrameTKNhanVien";
            this.nafContent.TransitionAnimationProperties.FrameCount = 100;
            this.nafContent.TransitionAnimationProperties.FrameInterval = 1000;
            this.nafContent.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // navPageTKKhuyenMai
            // 
            this.navPageTKKhuyenMai.Caption = "navPageTKKhuyenMai";
            this.navPageTKKhuyenMai.Controls.Add(this.chartTKKhuyenMai);
            this.navPageTKKhuyenMai.Controls.Add(this.labelControl1);
            this.navPageTKKhuyenMai.Name = "navPageTKKhuyenMai";
            this.navPageTKKhuyenMai.Size = new System.Drawing.Size(678, 572);
            // 
            // chartTKKhuyenMai
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartTKKhuyenMai.Diagram = xyDiagram2;
            this.chartTKKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTKKhuyenMai.Location = new System.Drawing.Point(0, 25);
            this.chartTKKhuyenMai.Name = "chartTKKhuyenMai";
            series2.Name = "Series 1";
            this.chartTKKhuyenMai.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartTKKhuyenMai.Size = new System.Drawing.Size(678, 547);
            this.chartTKKhuyenMai.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(185, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thống Kê Khuyến Mãi";
            // 
            // groupFrame
            // 
            this.groupFrame.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.groupFrame.GroupBordersVisible = false;
            this.groupFrame.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutChart});
            this.groupFrame.Name = "groupFrame";
            this.groupFrame.Size = new System.Drawing.Size(702, 596);
            this.groupFrame.TextVisible = false;
            // 
            // layoutChart
            // 
            this.layoutChart.Control = this.nafContent;
            this.layoutChart.Location = new System.Drawing.Point(0, 0);
            this.layoutChart.Name = "layoutChart";
            this.layoutChart.Size = new System.Drawing.Size(682, 576);
            this.layoutChart.TextSize = new System.Drawing.Size(0, 0);
            this.layoutChart.TextVisible = false;
            // 
            // BUTTONS
            // 
            this.TABLE_UC.SetColumn(this.BUTTONS, 0);
            this.BUTTONS.Controls.Add(this.btnTKKhuyenMai);
            this.BUTTONS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUTTONS.Location = new System.Drawing.Point(13, 12);
            this.BUTTONS.Name = "BUTTONS";
            this.BUTTONS.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(381, 527, 650, 400);
            this.BUTTONS.Root = this.Root;
            this.TABLE_UC.SetRow(this.BUTTONS, 0);
            this.BUTTONS.Size = new System.Drawing.Size(702, 48);
            this.BUTTONS.TabIndex = 0;
            this.BUTTONS.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(702, 48);
            this.Root.TextVisible = false;
            // 
            // btnTKKhuyenMai
            // 
            this.btnTKKhuyenMai.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTKKhuyenMai.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTKKhuyenMai.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTKKhuyenMai.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnTKKhuyenMai.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnTKKhuyenMai.AppearanceDisabled.Options.UseBackColor = true;
            this.btnTKKhuyenMai.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnTKKhuyenMai.AppearanceDisabled.Options.UseFont = true;
            this.btnTKKhuyenMai.AppearanceDisabled.Options.UseForeColor = true;
            this.btnTKKhuyenMai.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTKKhuyenMai.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTKKhuyenMai.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTKKhuyenMai.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnTKKhuyenMai.AppearanceHovered.Options.UseBackColor = true;
            this.btnTKKhuyenMai.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTKKhuyenMai.AppearanceHovered.Options.UseFont = true;
            this.btnTKKhuyenMai.AppearanceHovered.Options.UseForeColor = true;
            this.btnTKKhuyenMai.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTKKhuyenMai.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTKKhuyenMai.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTKKhuyenMai.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnTKKhuyenMai.AppearancePressed.Options.UseBackColor = true;
            this.btnTKKhuyenMai.AppearancePressed.Options.UseBorderColor = true;
            this.btnTKKhuyenMai.AppearancePressed.Options.UseFont = true;
            this.btnTKKhuyenMai.AppearancePressed.Options.UseForeColor = true;
            this.btnTKKhuyenMai.Location = new System.Drawing.Point(12, 12);
            this.btnTKKhuyenMai.Name = "btnTKKhuyenMai";
            this.btnTKKhuyenMai.Size = new System.Drawing.Size(678, 22);
            this.btnTKKhuyenMai.StyleController = this.BUTTONS;
            this.btnTKKhuyenMai.TabIndex = 4;
            this.btnTKKhuyenMai.Text = "Thống kê Khuyến Mãi ";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnTKKhuyenMai;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(682, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ThongKeKhuyenMai_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TABLE_UC);
            this.Name = "ThongKeKhuyenMai_UC";
            this.Size = new System.Drawing.Size(728, 673);
            ((System.ComponentModel.ISupportInitialize)(this.TABLE_UC)).EndInit();
            this.TABLE_UC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CHARTS)).EndInit();
            this.CHARTS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nafContent)).EndInit();
            this.nafContent.ResumeLayout(false);
            this.navPageTKKhuyenMai.ResumeLayout(false);
            this.navPageTKKhuyenMai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTKKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTONS)).EndInit();
            this.BUTTONS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel TABLE_UC;
        private DevExpress.XtraDataLayout.DataLayoutControl CHARTS;
        private DevExpress.XtraBars.Navigation.NavigationFrame nafContent;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageTKKhuyenMai;
        private DevExpress.XtraCharts.ChartControl chartTKKhuyenMai;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup groupFrame;
        private DevExpress.XtraLayout.LayoutControlItem layoutChart;
        private DevExpress.XtraLayout.LayoutControl BUTTONS;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnTKKhuyenMai;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
