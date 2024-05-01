namespace Project.NET.GUI_UC.PageKhuyenMai
{
    partial class ChiTietKhuyenMai_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietKhuyenMai_UC));
            this.dataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TieuDeUC = new DevExpress.XtraEditors.LabelControl();
            this.dgvGroup = new DevExpress.XtraEditors.GroupControl();
            this.dgvGrid = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietKM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cboKhuyenMai = new DevExpress.XtraEditors.LookUpEdit();
            this.cboSanPham = new DevExpress.XtraEditors.LookUpEdit();
            this.OUTLINE = new DevExpress.XtraLayout.LayoutControlGroup();
            this.BUTTONS = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutSanPham = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutSoLuong = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutKhuyenMai = new DevExpress.XtraLayout.LayoutControlItem();
            this.CRUD = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Them = new DevExpress.XtraLayout.LayoutControlItem();
            this.CapNhat = new DevExpress.XtraLayout.LayoutControlItem();
            this.LamMoi = new DevExpress.XtraLayout.LayoutControlItem();
            this.Xoa = new DevExpress.XtraLayout.LayoutControlItem();
            this.LIST = new DevExpress.XtraLayout.LayoutControlItem();
            this.TITLE = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).BeginInit();
            this.dataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.dgvGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhuyenMai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OUTLINE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapNhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LamMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TITLE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
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
            this.dataLayout.Controls.Add(this.cboKhuyenMai);
            this.dataLayout.Controls.Add(this.cboSanPham);
            this.dataLayout.Controls.Add(this.txtSoLuong);
            this.dataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayout.Location = new System.Drawing.Point(0, 0);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 563, 650, 400);
            this.dataLayout.Root = this.OUTLINE;
            this.dataLayout.Size = new System.Drawing.Size(886, 694);
            this.dataLayout.TabIndex = 5;
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
            this.TieuDeUC.Location = new System.Drawing.Point(12, 12);
            this.TieuDeUC.Name = "TieuDeUC";
            this.TieuDeUC.Padding = new System.Windows.Forms.Padding(9, 4, 0, 0);
            this.TieuDeUC.Size = new System.Drawing.Size(862, 32);
            this.TieuDeUC.StyleController = this.dataLayout;
            this.TieuDeUC.TabIndex = 24;
            this.TieuDeUC.Text = "Chi Tiết Khuyến Mãi";
            // 
            // dgvGroup
            // 
            this.dgvGroup.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dgvGroup.CaptionImageOptions.Image")));
            this.dgvGroup.Controls.Add(this.dgvGrid);
            this.dgvGroup.Location = new System.Drawing.Point(12, 352);
            this.dgvGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.Size = new System.Drawing.Size(862, 330);
            this.dgvGroup.TabIndex = 22;
            this.dgvGroup.Text = "Danh sách Sản Phẩm Khuyến Mãi";
            // 
            // dgvGrid
            // 
            this.dgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrid.Location = new System.Drawing.Point(2, 33);
            this.dgvGrid.MainView = this.dgvChiTietKM;
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.Size = new System.Drawing.Size(858, 295);
            this.dgvGrid.TabIndex = 0;
            this.dgvGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietKM});
            // 
            // dgvChiTietKM
            // 
            this.dgvChiTietKM.GridControl = this.dgvGrid;
            this.dgvChiTietKM.Name = "dgvChiTietKM";
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
            this.btnThem.Location = new System.Drawing.Point(24, 260);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(416, 36);
            this.btnThem.StyleController = this.dataLayout;
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
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
            this.btnCapNhat.Location = new System.Drawing.Point(444, 260);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(418, 36);
            this.btnCapNhat.StyleController = this.dataLayout;
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập nhật";
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
            this.btnLamMoi.Location = new System.Drawing.Point(24, 300);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(416, 36);
            this.btnLamMoi.StyleController = this.dataLayout;
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm Mới";
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
            this.btnXoa.Location = new System.Drawing.Point(444, 300);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(418, 36);
            this.btnXoa.StyleController = this.dataLayout;
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            // 
            // cboKhuyenMai
            // 
            this.cboKhuyenMai.Location = new System.Drawing.Point(132, 94);
            this.cboKhuyenMai.Name = "cboKhuyenMai";
            this.cboKhuyenMai.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuyenMai.Properties.Appearance.Options.UseFont = true;
            this.cboKhuyenMai.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuyenMai.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboKhuyenMai.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuyenMai.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboKhuyenMai.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuyenMai.Properties.AppearanceFocused.Options.UseFont = true;
            this.cboKhuyenMai.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboKhuyenMai.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboKhuyenMai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhuyenMai.Properties.NullText = "";
            this.cboKhuyenMai.Properties.PopupSizeable = false;
            this.cboKhuyenMai.Size = new System.Drawing.Size(730, 26);
            this.cboKhuyenMai.StyleController = this.dataLayout;
            this.cboKhuyenMai.TabIndex = 26;
            // 
            // cboSanPham
            // 
            this.cboSanPham.Location = new System.Drawing.Point(132, 130);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSanPham.Properties.Appearance.Options.UseFont = true;
            this.cboSanPham.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSanPham.Properties.AppearanceDisabled.Options.UseFont = true;
            this.cboSanPham.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSanPham.Properties.AppearanceFocused.Options.UseFont = true;
            this.cboSanPham.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboSanPham.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.cboSanPham.Properties.BeepOnError = true;
            this.cboSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSanPham.Properties.NullText = "";
            this.cboSanPham.Size = new System.Drawing.Size(730, 26);
            this.cboSanPham.StyleController = this.dataLayout;
            this.cboSanPham.TabIndex = 23;
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
            this.OUTLINE.Size = new System.Drawing.Size(886, 694);
            this.OUTLINE.TextVisible = false;
            // 
            // BUTTONS
            // 
            this.BUTTONS.CaptionImageOptions.Image = global::Project.NET.Properties.Resources.updateKM32_32;
            this.BUTTONS.CustomizationFormText = "Thông tin nhân viên";
            this.BUTTONS.ExpandButtonVisible = true;
            this.BUTTONS.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutSanPham,
            this.layoutSoLuong,
            this.layoutKhuyenMai});
            this.BUTTONS.Location = new System.Drawing.Point(0, 36);
            this.BUTTONS.Name = "BUTTONS";
            this.BUTTONS.OptionsItemText.TextToControlDistance = 3;
            this.BUTTONS.Size = new System.Drawing.Size(866, 166);
            this.BUTTONS.Text = "Cập nhật thông tin Khuyến Mãi - Sản Phẩm";
            // 
            // layoutSanPham
            // 
            this.layoutSanPham.Control = this.cboSanPham;
            this.layoutSanPham.CustomizationFormText = "Sản Phẩm:";
            this.layoutSanPham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutSanPham.ImageOptions.Image")));
            this.layoutSanPham.Location = new System.Drawing.Point(0, 36);
            this.layoutSanPham.Name = "layoutSanPham";
            this.layoutSanPham.Size = new System.Drawing.Size(842, 36);
            this.layoutSanPham.Text = "Sản Phẩm:";
            this.layoutSanPham.TextSize = new System.Drawing.Size(96, 32);
            // 
            // layoutSoLuong
            // 
            this.layoutSoLuong.Control = this.txtSoLuong;
            this.layoutSoLuong.CustomizationFormText = "Số Lượng:";
            this.layoutSoLuong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutSoLuong.ImageOptions.Image")));
            this.layoutSoLuong.Location = new System.Drawing.Point(0, 72);
            this.layoutSoLuong.Name = "layoutSoLuong";
            this.layoutSoLuong.Size = new System.Drawing.Size(842, 36);
            this.layoutSoLuong.Text = "Số Lượng:";
            this.layoutSoLuong.TextSize = new System.Drawing.Size(96, 32);
            // 
            // layoutKhuyenMai
            // 
            this.layoutKhuyenMai.Control = this.cboKhuyenMai;
            this.layoutKhuyenMai.ImageOptions.Image = global::Project.NET.Properties.Resources.coupon32_32;
            this.layoutKhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.layoutKhuyenMai.Name = "layoutKhuyenMai";
            this.layoutKhuyenMai.Size = new System.Drawing.Size(842, 36);
            this.layoutKhuyenMai.Text = "Khuyến mãi:";
            this.layoutKhuyenMai.TextSize = new System.Drawing.Size(96, 32);
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
            this.CRUD.Location = new System.Drawing.Point(0, 202);
            this.CRUD.Name = "CRUD";
            this.CRUD.OptionsItemText.TextToControlDistance = 3;
            this.CRUD.Size = new System.Drawing.Size(866, 138);
            this.CRUD.Text = "Thao tác Cơ Sở Dữ Liệu";
            // 
            // Them
            // 
            this.Them.Control = this.btnThem;
            this.Them.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Them.CustomizationFormText = "layoutControlItem10";
            this.Them.Location = new System.Drawing.Point(0, 0);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(420, 40);
            this.Them.Text = "layoutControlItem10";
            this.Them.TextSize = new System.Drawing.Size(0, 0);
            this.Them.TextVisible = false;
            // 
            // CapNhat
            // 
            this.CapNhat.Control = this.btnCapNhat;
            this.CapNhat.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CapNhat.CustomizationFormText = "layoutControlItem11";
            this.CapNhat.Location = new System.Drawing.Point(420, 0);
            this.CapNhat.Name = "CapNhat";
            this.CapNhat.OptionsTableLayoutItem.RowIndex = 2;
            this.CapNhat.Size = new System.Drawing.Size(422, 40);
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
            this.LamMoi.Size = new System.Drawing.Size(420, 40);
            this.LamMoi.Text = "layoutControlItem13";
            this.LamMoi.TextSize = new System.Drawing.Size(0, 0);
            this.LamMoi.TextVisible = false;
            // 
            // Xoa
            // 
            this.Xoa.Control = this.btnXoa;
            this.Xoa.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Xoa.CustomizationFormText = "layoutControlItem14";
            this.Xoa.Location = new System.Drawing.Point(420, 40);
            this.Xoa.Name = "Xoa";
            this.Xoa.OptionsTableLayoutItem.RowIndex = 4;
            this.Xoa.Size = new System.Drawing.Size(422, 40);
            this.Xoa.Text = "layoutControlItem14";
            this.Xoa.TextSize = new System.Drawing.Size(0, 0);
            this.Xoa.TextVisible = false;
            // 
            // LIST
            // 
            this.LIST.Control = this.dgvGroup;
            this.LIST.Location = new System.Drawing.Point(0, 340);
            this.LIST.Name = "LIST";
            this.LIST.Size = new System.Drawing.Size(866, 334);
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
            this.TITLE.Size = new System.Drawing.Size(866, 36);
            this.TITLE.Text = "TieuDeUC";
            this.TITLE.TextSize = new System.Drawing.Size(0, 0);
            this.TITLE.TextVisible = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(132, 166);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Properties.AppearanceDisabled.Options.UseFont = true;
            this.txtSoLuong.Properties.AppearanceFocused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Properties.AppearanceFocused.Options.UseFont = true;
            this.txtSoLuong.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoLuong.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtSoLuong.Properties.MaskSettings.Set("mask", "d");
            this.txtSoLuong.Size = new System.Drawing.Size(730, 26);
            this.txtSoLuong.StyleController = this.dataLayout;
            this.txtSoLuong.TabIndex = 25;
            this.txtSoLuong.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtSoLuong_EditValueChanging);
            // 
            // ChiTietKhuyenMai_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayout);
            this.Name = "ChiTietKhuyenMai_UC";
            this.Size = new System.Drawing.Size(886, 694);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayout)).EndInit();
            this.dataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.dgvGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhuyenMai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OUTLINE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BUTTONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapNhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LamMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LIST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TITLE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayout;
        private DevExpress.XtraEditors.LabelControl TieuDeUC;
        private DevExpress.XtraEditors.GroupControl dgvGroup;
        private DevExpress.XtraGrid.GridControl dgvGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietKM;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LookUpEdit cboKhuyenMai;
        private DevExpress.XtraLayout.LayoutControlGroup OUTLINE;
        private DevExpress.XtraLayout.LayoutControlGroup BUTTONS;
        private DevExpress.XtraLayout.LayoutControlItem layoutSanPham;
        private DevExpress.XtraLayout.LayoutControlItem layoutSoLuong;
        private DevExpress.XtraLayout.LayoutControlItem layoutKhuyenMai;
        private DevExpress.XtraLayout.LayoutControlGroup CRUD;
        private DevExpress.XtraLayout.LayoutControlItem Them;
        private DevExpress.XtraLayout.LayoutControlItem CapNhat;
        private DevExpress.XtraLayout.LayoutControlItem LamMoi;
        private DevExpress.XtraLayout.LayoutControlItem Xoa;
        private DevExpress.XtraLayout.LayoutControlItem LIST;
        private DevExpress.XtraLayout.LayoutControlItem TITLE;
        private DevExpress.XtraEditors.LookUpEdit cboSanPham;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
    }
}
