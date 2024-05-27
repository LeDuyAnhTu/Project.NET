namespace Project.NET.GUI_UC.PageChiNhanh
{
    partial class ChiNhanh_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiNhanh_UC));
            this.dataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TieuDeUC = new DevExpress.XtraEditors.LabelControl();
            this.dgvGroup = new DevExpress.XtraEditors.GroupControl();
            this.dgvGrid = new DevExpress.XtraGrid.GridControl();
            this.dgvChiNhanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaCN = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cboNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.cboKhuVuc = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenCN = new DevExpress.XtraEditors.TextEdit();
            this.OUTLINE = new DevExpress.XtraLayout.LayoutControlGroup();
            this.BUTTONS = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutMaCN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutTenCN = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutNhanVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutKhuVuc = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDiaChi = new DevExpress.XtraLayout.LayoutControlItem();
            this.CRUD = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Them = new DevExpress.XtraLayout.LayoutControlItem();
            this.CapNhat = new DevExpress.XtraLayout.LayoutControlItem();
            this.LamMoi = new DevExpress.XtraLayout.LayoutControlItem();
            this.Xoa = new DevExpress.XtraLayout.LayoutControlItem();
            this.LIST = new DevExpress.XtraLayout.LayoutControlItem();
            this.TITLE = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).BeginInit();
            this.dataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.dgvGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhuVuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OUTLINE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMaCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LamMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TITLE)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayout
            // 
            this.dataLayout.AllowCustomization = false;
            this.dataLayout.Controls.Add(this.TieuDeUC);
            this.dataLayout.Controls.Add(this.dgvGroup);
            this.dataLayout.Controls.Add(this.btnThem);
            this.dataLayout.Controls.Add(this.btnCapNhat);
            this.dataLayout.Controls.Add(this.btnLamMoi);
            this.dataLayout.Controls.Add(this.btnXoa);
            this.dataLayout.Controls.Add(this.txtMaCN);
            this.dataLayout.Controls.Add(this.txtDiaChi);
            this.dataLayout.Controls.Add(this.cboNhanVien);
            this.dataLayout.Controls.Add(this.cboKhuVuc);
            this.dataLayout.Controls.Add(this.txtTenCN);
            this.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayout.Location = new System.Drawing.Point(0, 0);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 563, 650, 400);
            this.dataLayout.Root = this.OUTLINE;
            this.dataLayout.Size = new System.Drawing.Size(692, 596);
            this.dataLayout.TabIndex = 6;
            // 
            // TieuDeUC
            // 
            this.TieuDeUC.AllowHtmlString = true;
            this.TieuDeUC.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TieuDeUC.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.TieuDeUC.Appearance.Options.UseFont = true;
            this.TieuDeUC.Appearance.Options.UseForeColor = true;
            this.TieuDeUC.Appearance.Options.UseTextOptions = true;
            this.TieuDeUC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TieuDeUC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.TieuDeUC.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.TieuDeUC.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.TieuDeUC.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.TieuDeUC.LineVisible = true;
            this.TieuDeUC.Location = new System.Drawing.Point(6, 6);
            this.TieuDeUC.Name = "TieuDeUC";
            this.TieuDeUC.Padding = new System.Windows.Forms.Padding(9, 4, 0, 0);
            this.TieuDeUC.Size = new System.Drawing.Size(680, 32);
            this.TieuDeUC.StyleController = this.dataLayout;
            this.TieuDeUC.TabIndex = 24;
            this.TieuDeUC.Text = "Chi Nhánh";
            this.TieuDeUC.ToolTip = "Cập nhật thông tin hóa đơn";
            this.TieuDeUC.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.TieuDeUC.ToolTipTitle = "Trang cập nhật thông tin hóa đơn";
            // 
            // dgvGroup
            // 
            this.dgvGroup.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dgvGroup.CaptionImageOptions.Image")));
            this.dgvGroup.Controls.Add(this.dgvGrid);
            this.dgvGroup.Location = new System.Drawing.Point(6, 318);
            this.dgvGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Size = new System.Drawing.Size(680, 272);
            this.dgvGroup.TabIndex = 22;
            this.dgvGroup.Text = "Danh sách Chi Nhánh";
            // 
            // dgvGrid
            // 
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(2, 35);
            this.dgvGrid.MainView = this.dgvChiNhanh;
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(676, 235);
            this.dgvGrid.TabIndex = 0;
            this.dgvGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiNhanh});
            // 
            // dgvChiNhanh
            // 
            this.dgvChiNhanh.GridControl = this.dgvGrid;
            this.dgvChiNhanh.Name = "dgvChiNhanh";
            this.dgvChiNhanh.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvChiNhanh.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvChiNhanh.OptionsBehavior.Editable = false;
            this.dgvChiNhanh.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dgvChiNhanh_RowCellClick);
            // 
            // btnThem
            // 
            this.btnThem.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThem.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnThem.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThem.AppearanceDisabled.Options.UseBackColor = true;
            this.btnThem.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnThem.AppearanceDisabled.Options.UseFont = true;
            this.btnThem.AppearanceDisabled.Options.UseForeColor = true;
            this.btnThem.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnThem.AppearanceHovered.Options.UseBackColor = true;
            this.btnThem.AppearanceHovered.Options.UseBorderColor = true;
            this.btnThem.AppearanceHovered.Options.UseFont = true;
            this.btnThem.AppearanceHovered.Options.UseForeColor = true;
            this.btnThem.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnThem.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnThem.AppearancePressed.Options.UseBackColor = true;
            this.btnThem.AppearancePressed.Options.UseBorderColor = true;
            this.btnThem.AppearancePressed.Options.UseFont = true;
            this.btnThem.AppearancePressed.Options.UseForeColor = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(12, 232);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(333, 38);
            this.btnThem.StyleController = this.dataLayout;
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapNhat.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCapNhat.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnCapNhat.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnCapNhat.AppearanceDisabled.Options.UseBackColor = true;
            this.btnCapNhat.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnCapNhat.AppearanceDisabled.Options.UseFont = true;
            this.btnCapNhat.AppearanceDisabled.Options.UseForeColor = true;
            this.btnCapNhat.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapNhat.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnCapNhat.AppearanceHovered.Options.UseBackColor = true;
            this.btnCapNhat.AppearanceHovered.Options.UseBorderColor = true;
            this.btnCapNhat.AppearanceHovered.Options.UseFont = true;
            this.btnCapNhat.AppearanceHovered.Options.UseForeColor = true;
            this.btnCapNhat.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapNhat.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnCapNhat.AppearancePressed.Options.UseBackColor = true;
            this.btnCapNhat.AppearancePressed.Options.UseBorderColor = true;
            this.btnCapNhat.AppearancePressed.Options.UseFont = true;
            this.btnCapNhat.AppearancePressed.Options.UseForeColor = true;
            this.btnCapNhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.ImageOptions.Image")));
            this.btnCapNhat.Location = new System.Drawing.Point(347, 232);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(333, 38);
            this.btnCapNhat.StyleController = this.dataLayout;
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLamMoi.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLamMoi.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnLamMoi.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnLamMoi.AppearanceDisabled.Options.UseBackColor = true;
            this.btnLamMoi.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnLamMoi.AppearanceDisabled.Options.UseFont = true;
            this.btnLamMoi.AppearanceDisabled.Options.UseForeColor = true;
            this.btnLamMoi.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLamMoi.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnLamMoi.AppearanceHovered.Options.UseBackColor = true;
            this.btnLamMoi.AppearanceHovered.Options.UseBorderColor = true;
            this.btnLamMoi.AppearanceHovered.Options.UseFont = true;
            this.btnLamMoi.AppearanceHovered.Options.UseForeColor = true;
            this.btnLamMoi.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLamMoi.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnLamMoi.AppearancePressed.Options.UseBackColor = true;
            this.btnLamMoi.AppearancePressed.Options.UseBorderColor = true;
            this.btnLamMoi.AppearancePressed.Options.UseFont = true;
            this.btnLamMoi.AppearancePressed.Options.UseForeColor = true;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(12, 272);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(333, 38);
            this.btnLamMoi.StyleController = this.dataLayout;
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoa.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnXoa.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnXoa.AppearanceDisabled.Options.UseBackColor = true;
            this.btnXoa.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnXoa.AppearanceDisabled.Options.UseFont = true;
            this.btnXoa.AppearanceDisabled.Options.UseForeColor = true;
            this.btnXoa.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnXoa.AppearanceHovered.Options.UseBackColor = true;
            this.btnXoa.AppearanceHovered.Options.UseBorderColor = true;
            this.btnXoa.AppearanceHovered.Options.UseFont = true;
            this.btnXoa.AppearanceHovered.Options.UseForeColor = true;
            this.btnXoa.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnXoa.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnXoa.AppearancePressed.Options.UseBackColor = true;
            this.btnXoa.AppearancePressed.Options.UseBorderColor = true;
            this.btnXoa.AppearancePressed.Options.UseFont = true;
            this.btnXoa.AppearancePressed.Options.UseForeColor = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(347, 272);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(333, 38);
            this.btnXoa.StyleController = this.dataLayout;
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(148, 82);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaCN.Properties.Appearance.Options.UseFont = true;
            this.txtMaCN.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaCN.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtMaCN.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaCN.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtMaCN.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaCN.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtMaCN.Properties.BeepOnError = true;
            this.txtMaCN.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtMaCN.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtMaCN.Properties.MaskSettings.Set("mask", "\\w{10}");
            this.txtMaCN.Properties.ReadOnly = true;
            this.txtMaCN.Properties.UseMaskAsDisplayFormat = true;
            this.txtMaCN.Size = new System.Drawing.Size(532, 26);
            this.txtMaCN.StyleController = this.dataLayout;
            this.txtMaCN.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(483, 116);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
            this.txtDiaChi.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtDiaChi.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtDiaChi.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiaChi.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtDiaChi.Size = new System.Drawing.Size(197, 26);
            this.txtDiaChi.StyleController = this.dataLayout;
            this.txtDiaChi.TabIndex = 25;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Location = new System.Drawing.Point(148, 150);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.Properties.Appearance.Options.UseFont = true;
            this.cboNhanVien.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboNhanVien.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboNhanVien.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.Properties.AppearanceFocused.Options.UseFont = true;
            this.cboNhanVien.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNhanVien.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhanVien.Properties.NullText = "";
            this.cboNhanVien.Properties.PopupSizeable = false;
            this.cboNhanVien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboNhanVien.Size = new System.Drawing.Size(197, 26);
            this.cboNhanVien.StyleController = this.dataLayout;
            this.cboNhanVien.TabIndex = 26;
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.Location = new System.Drawing.Point(483, 150);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuVuc.Properties.Appearance.Options.UseFont = true;
            this.cboKhuVuc.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuVuc.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboKhuVuc.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuVuc.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboKhuVuc.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuVuc.Properties.AppearanceFocused.Options.UseFont = true;
            this.cboKhuVuc.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuVuc.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboKhuVuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhuVuc.Properties.NullText = "";
            this.cboKhuVuc.Properties.PopupSizeable = false;
            this.cboKhuVuc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboKhuVuc.Size = new System.Drawing.Size(197, 26);
            this.cboKhuVuc.StyleController = this.dataLayout;
            this.cboKhuVuc.TabIndex = 27;
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(148, 116);
            this.txtTenCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCN.Properties.Appearance.Options.UseFont = true;
            this.txtTenCN.Size = new System.Drawing.Size(197, 26);
            this.txtTenCN.StyleController = this.dataLayout;
            this.txtTenCN.TabIndex = 10;
            // 
            // OUTLINE
            // 
            this.OUTLINE.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("OUTLINE.CaptionImageOptions.Image")));
            this.OUTLINE.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.OUTLINE.GroupBordersVisible = false;
            this.OUTLINE.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.BUTTONS,
            this.CRUD,
            this.LIST,
            this.TITLE});
            this.OUTLINE.Name = "Root";
            this.OUTLINE.Size = new System.Drawing.Size(692, 596);
            this.OUTLINE.TextVisible = false;
            // 
            // BUTTONS
            // 
            this.BUTTONS.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BUTTONS.CaptionImageOptions.Image")));
            this.BUTTONS.CustomizationFormText = "Cập nhật thông tin Chi Nhánh";
            this.BUTTONS.ExpandButtonVisible = true;
            this.BUTTONS.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutMaCN,
            this.layoutTenCN,
            this.layoutNhanVien,
            this.layoutKhuVuc,
            this.layoutDiaChi});
            this.BUTTONS.Location = new System.Drawing.Point(0, 34);
            this.BUTTONS.Name = "BUTTONS";
            this.BUTTONS.OptionsItemText.TextToControlDistance = 3;
            this.BUTTONS.Size = new System.Drawing.Size(682, 150);
            this.BUTTONS.Text = "Cập nhật thông tin Chi Nhánh";
            // 
            // layoutMaCN
            // 
            this.layoutMaCN.Control = this.txtMaCN;
            this.layoutMaCN.CustomizationFormText = "Mã Chi Nhánh:";
            this.layoutMaCN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutMaCN.ImageOptions.Image")));
            this.layoutMaCN.Location = new System.Drawing.Point(0, 0);
            this.layoutMaCN.Name = "layoutMaCN";
            this.layoutMaCN.Size = new System.Drawing.Size(670, 34);
            this.layoutMaCN.Text = "Mã Chi Nhánh:";
            this.layoutMaCN.TextSize = new System.Drawing.Size(132, 32);
            // 
            // layoutTenCN
            // 
            this.layoutTenCN.Control = this.txtTenCN;
            this.layoutTenCN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutTenCN.ImageOptions.Image")));
            this.layoutTenCN.Location = new System.Drawing.Point(0, 34);
            this.layoutTenCN.Name = "layoutTenCN";
            this.layoutTenCN.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutTenCN.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutTenCN.Size = new System.Drawing.Size(335, 34);
            this.layoutTenCN.Text = "Tên Chi Nhánh:";
            this.layoutTenCN.TextSize = new System.Drawing.Size(132, 32);
            // 
            // layoutNhanVien
            // 
            this.layoutNhanVien.Control = this.cboNhanVien;
            this.layoutNhanVien.CustomizationFormText = "Nhân Viên Quản Lý:";
            this.layoutNhanVien.ImageOptions.Image = global::Project.NET.Properties.Resources.manager32_32;
            this.layoutNhanVien.Location = new System.Drawing.Point(0, 68);
            this.layoutNhanVien.Name = "layoutNhanVien";
            this.layoutNhanVien.Size = new System.Drawing.Size(335, 34);
            this.layoutNhanVien.Text = "Nhân Viên Quản Lý:";
            this.layoutNhanVien.TextSize = new System.Drawing.Size(132, 32);
            // 
            // layoutKhuVuc
            // 
            this.layoutKhuVuc.Control = this.cboKhuVuc;
            this.layoutKhuVuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutKhuVuc.ImageOptions.Image")));
            this.layoutKhuVuc.Location = new System.Drawing.Point(335, 68);
            this.layoutKhuVuc.Name = "layoutKhuVuc";
            this.layoutKhuVuc.Size = new System.Drawing.Size(335, 34);
            this.layoutKhuVuc.Text = "Khu vực:";
            this.layoutKhuVuc.TextSize = new System.Drawing.Size(132, 32);
            // 
            // layoutDiaChi
            // 
            this.layoutDiaChi.Control = this.txtDiaChi;
            this.layoutDiaChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutDiaChi.ImageOptions.Image")));
            this.layoutDiaChi.Location = new System.Drawing.Point(335, 34);
            this.layoutDiaChi.Name = "layoutDiaChi";
            this.layoutDiaChi.Size = new System.Drawing.Size(335, 34);
            this.layoutDiaChi.Text = "Địa Chỉ:";
            this.layoutDiaChi.TextSize = new System.Drawing.Size(132, 32);
            // 
            // CRUD
            // 
            this.CRUD.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CRUD.CaptionImageOptions.Image")));
            this.CRUD.CustomizationFormText = "Thao tác Cơ Sở Dữ Liệu";
            this.CRUD.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Them,
            this.CapNhat,
            this.LamMoi,
            this.Xoa});
            this.CRUD.Location = new System.Drawing.Point(0, 184);
            this.CRUD.Name = "CRUD";
            this.CRUD.OptionsItemText.TextToControlDistance = 3;
            this.CRUD.Size = new System.Drawing.Size(682, 128);
            this.CRUD.Text = "Thao tác Cơ Sở Dữ Liệu";
            // 
            // Them
            // 
            this.Them.Control = this.btnThem;
            this.Them.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Them.CustomizationFormText = "layoutControlItem10";
            this.Them.Location = new System.Drawing.Point(0, 0);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(335, 40);
            this.Them.Text = "layoutControlItem10";
            this.Them.TextSize = new System.Drawing.Size(0, 0);
            this.Them.TextVisible = false;
            // 
            // CapNhat
            // 
            this.CapNhat.Control = this.btnCapNhat;
            this.CapNhat.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CapNhat.CustomizationFormText = "layoutControlItem11";
            this.CapNhat.Location = new System.Drawing.Point(335, 0);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.OptionsTableLayoutItem.RowIndex = 2;
            this.CapNhat.Size = new System.Drawing.Size(335, 40);
            this.CapNhat.Text = "layoutControlItem11";
            this.CapNhat.TextSize = new System.Drawing.Size(0, 0);
            this.CapNhat.TextVisible = false;
            // 
            // LamMoi
            // 
            this.LamMoi.Control = this.btnLamMoi;
            this.LamMoi.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LamMoi.CustomizationFormText = "layoutControlItem13";
            this.LamMoi.Location = new System.Drawing.Point(0, 40);
            this.LamMoi.Name = "LamMoi";
            this.LamMoi.OptionsTableLayoutItem.RowIndex = 3;
            this.LamMoi.Size = new System.Drawing.Size(335, 40);
            this.LamMoi.Text = "layoutControlItem13";
            this.LamMoi.TextSize = new System.Drawing.Size(0, 0);
            this.LamMoi.TextVisible = false;
            // 
            // Xoa
            // 
            this.Xoa.Control = this.btnXoa;
            this.Xoa.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Xoa.CustomizationFormText = "layoutControlItem14";
            this.Xoa.Location = new System.Drawing.Point(335, 40);
            this.Xoa.Name = "Xoa";
            this.Xoa.OptionsTableLayoutItem.RowIndex = 4;
            this.Xoa.Size = new System.Drawing.Size(335, 40);
            this.Xoa.Text = "layoutControlItem14";
            this.Xoa.TextSize = new System.Drawing.Size(0, 0);
            this.Xoa.TextVisible = false;
            // 
            // LIST
            // 
            this.LIST.Control = this.dgvGroup;
            this.LIST.Location = new System.Drawing.Point(0, 312);
            this.LIST.Name = "LIST";
            this.LIST.Size = new System.Drawing.Size(682, 274);
            this.LIST.Text = "DGV Nhân Viên:";
            this.LIST.TextSize = new System.Drawing.Size(0, 0);
            this.LIST.TextVisible = false;
            // 
            // TITLE
            // 
            this.TITLE.Control = this.TieuDeUC;
            this.TITLE.CustomizationFormText = "TieuDeUC";
            this.TITLE.Location = new System.Drawing.Point(0, 0);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(682, 34);
            this.TITLE.Text = "TieuDeUC";
            this.TITLE.TextSize = new System.Drawing.Size(0, 0);
            this.TITLE.TextVisible = false;
            // 
            // ChiNhanh_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayout);
            this.Name = "ChiNhanh_UC";
            this.Size = new System.Drawing.Size(692, 596);
            this.Load += new System.EventHandler(this.ChiNhanh_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).EndInit();
            this.dataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.dgvGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiNhanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhuVuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OUTLINE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutMaCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTenCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LamMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TITLE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayout;
        private DevExpress.XtraEditors.LabelControl TieuDeUC;
        private DevExpress.XtraEditors.GroupControl dgvGroup;
        private DevExpress.XtraGrid.GridControl dgvGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiNhanh;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.TextEdit txtMaCN;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LookUpEdit cboNhanVien;
        private DevExpress.XtraEditors.LookUpEdit cboKhuVuc;
        private DevExpress.XtraLayout.LayoutControlGroup OUTLINE;
        private DevExpress.XtraLayout.LayoutControlGroup BUTTONS;
        private DevExpress.XtraLayout.LayoutControlItem layoutMaCN;
        private DevExpress.XtraLayout.LayoutControlItem layoutTenCN;
        private DevExpress.XtraLayout.LayoutControlItem layoutNhanVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutKhuVuc;
        private DevExpress.XtraLayout.LayoutControlItem layoutDiaChi;
        private DevExpress.XtraLayout.LayoutControlGroup CRUD;
        private DevExpress.XtraLayout.LayoutControlItem Them;
        private DevExpress.XtraLayout.LayoutControlItem CapNhat;
        private DevExpress.XtraLayout.LayoutControlItem LamMoi;
        private DevExpress.XtraLayout.LayoutControlItem Xoa;
        private DevExpress.XtraLayout.LayoutControlItem LIST;
        private DevExpress.XtraLayout.LayoutControlItem TITLE;
        private DevExpress.XtraEditors.TextEdit txtTenCN;
    }
}
