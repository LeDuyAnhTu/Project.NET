namespace Project.NET.Forms
{
    partial class TaiKhoan_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan_UC));
            this.layoutDataNhanVien = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.groupDanhSachNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.dgvTaiKhoanNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMatKhauTK = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTK = new DevExpress.XtraEditors.TextEdit();
            this.cboNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.groupLayoutNhanVien = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTxtHoTen = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutTxtTenTK = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutCboNhanVien = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutTxtViTriChucVu = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutGroupThaoTacCSDL = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutDGVTaiKhoan = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.txtViTriChucVu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDataNhanVien)).BeginInit();
            this.layoutDataNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhSachNhanVien)).BeginInit();
            this.groupDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLayoutNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtTenTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCboNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtViTriChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupThaoTacCSDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGVTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTriChucVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutDataNhanVien
            // 
            this.layoutDataNhanVien.AllowCustomization = false;
            this.layoutDataNhanVien.Controls.Add(this.groupDanhSachNhanVien);
            this.layoutDataNhanVien.Controls.Add(this.txtMatKhauTK);
            this.layoutDataNhanVien.Controls.Add(this.txtTenTK);
            this.layoutDataNhanVien.Controls.Add(this.cboNhanVien);
            this.layoutDataNhanVien.Controls.Add(this.btnCapNhat);
            this.layoutDataNhanVien.Controls.Add(this.btnLamMoi);
            this.layoutDataNhanVien.Controls.Add(this.txtViTriChucVu);
            this.layoutDataNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDataNhanVien.Location = new System.Drawing.Point(0, 33);
            this.layoutDataNhanVien.Name = "layoutDataNhanVien";
            this.layoutDataNhanVien.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(873, 544, 650, 400);
            this.layoutDataNhanVien.Root = this.groupLayoutNhanVien;
            this.layoutDataNhanVien.Size = new System.Drawing.Size(711, 756);
            this.layoutDataNhanVien.TabIndex = 6;
            // 
            // groupDanhSachNhanVien
            // 
            this.groupDanhSachNhanVien.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupDanhSachNhanVien.CaptionImageOptions.Image")));
            this.groupDanhSachNhanVien.Controls.Add(this.dgvTaiKhoanNhanVien);
            this.groupDanhSachNhanVien.Location = new System.Drawing.Point(12, 352);
            this.groupDanhSachNhanVien.Name = "groupDanhSachNhanVien";
            this.groupDanhSachNhanVien.Size = new System.Drawing.Size(687, 392);
            this.groupDanhSachNhanVien.TabIndex = 22;
            this.groupDanhSachNhanVien.Text = "Danh mục Tài Khoản";
            // 
            // dgvTaiKhoanNhanVien
            // 
            this.dgvTaiKhoanNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanNhanVien.Location = new System.Drawing.Point(2, 33);
            this.dgvTaiKhoanNhanVien.MainView = this.gridView1;
            this.dgvTaiKhoanNhanVien.Name = "dgvTaiKhoanNhanVien";
            this.dgvTaiKhoanNhanVien.Size = new System.Drawing.Size(683, 357);
            this.dgvTaiKhoanNhanVien.TabIndex = 0;
            this.dgvTaiKhoanNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgvTaiKhoanNhanVien;
            this.gridView1.Name = "gridView1";
            // 
            // txtMatKhauTK
            // 
            this.txtMatKhauTK.Location = new System.Drawing.Point(151, 94);
            this.txtMatKhauTK.Name = "txtMatKhauTK";
            this.txtMatKhauTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauTK.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhauTK.Size = new System.Drawing.Size(536, 26);
            this.txtMatKhauTK.StyleController = this.layoutDataNhanVien;
            this.txtMatKhauTK.TabIndex = 4;
            this.txtMatKhauTK.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtMatKhauTK_EditValueChanging);
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(151, 58);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Properties.Appearance.Options.UseFont = true;
            this.txtTenTK.Properties.BeepOnError = true;
            this.txtTenTK.Properties.MaskSettings.Set("mask", "[0-9a-zA-Z]{6,30}");
            this.txtTenTK.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtTenTK.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtTenTK.Properties.ReadOnly = true;
            this.txtTenTK.Properties.UseMaskAsDisplayFormat = true;
            this.txtTenTK.Size = new System.Drawing.Size(536, 26);
            this.txtTenTK.StyleController = this.layoutDataNhanVien;
            this.txtTenTK.TabIndex = 5;
            this.txtTenTK.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTenTK_EditValueChanging);
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Location = new System.Drawing.Point(151, 130);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.Properties.Appearance.Options.UseFont = true;
            this.cboNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhanVien.Properties.NullText = "";
            this.cboNhanVien.Properties.PopupSizeable = false;
            this.cboNhanVien.Size = new System.Drawing.Size(536, 26);
            this.cboNhanVien.StyleController = this.layoutDataNhanVien;
            this.cboNhanVien.TabIndex = 14;
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
            this.btnCapNhat.Location = new System.Drawing.Point(24, 260);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(663, 36);
            this.btnCapNhat.StyleController = this.layoutDataNhanVien;
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
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(663, 36);
            this.btnLamMoi.StyleController = this.layoutDataNhanVien;
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm Mới";
            // 
            // groupLayoutNhanVien
            // 
            this.groupLayoutNhanVien.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupLayoutNhanVien.CaptionImageOptions.Image")));
            this.groupLayoutNhanVien.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.groupLayoutNhanVien.GroupBordersVisible = false;
            this.groupLayoutNhanVien.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6,
            this.layoutGroupThaoTacCSDL,
            this.layoutDGVTaiKhoan});
            this.groupLayoutNhanVien.Name = "Root";
            this.groupLayoutNhanVien.Size = new System.Drawing.Size(711, 756);
            this.groupLayoutNhanVien.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutControlGroup6.CaptionImageOptions.Image")));
            this.layoutControlGroup6.CustomizationFormText = "Thông tin nhân viên";
            this.layoutControlGroup6.ExpandButtonVisible = true;
            this.layoutControlGroup6.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTxtHoTen,
            this.layoutTxtTenTK,
            this.layoutCboNhanVien,
            this.layoutTxtViTriChucVu});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.OptionsItemText.TextToControlDistance = 3;
            this.layoutControlGroup6.Size = new System.Drawing.Size(691, 202);
            this.layoutControlGroup6.Text = "Sửa Thông tin Tài Khoản";
            // 
            // layoutTxtHoTen
            // 
            this.layoutTxtHoTen.Control = this.txtMatKhauTK;
            this.layoutTxtHoTen.CustomizationFormText = "Mật Khẩu:";
            this.layoutTxtHoTen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutTxtHoTen.ImageOptions.Image")));
            this.layoutTxtHoTen.Location = new System.Drawing.Point(0, 36);
            this.layoutTxtHoTen.Name = "layoutTxtHoTen";
            this.layoutTxtHoTen.Size = new System.Drawing.Size(667, 36);
            this.layoutTxtHoTen.Text = "Mật Khẩu:";
            this.layoutTxtHoTen.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutTxtHoTen.TextSize = new System.Drawing.Size(115, 32);
            // 
            // layoutTxtTenTK
            // 
            this.layoutTxtTenTK.Control = this.txtTenTK;
            this.layoutTxtTenTK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutTxtTenTK.ImageOptions.Image")));
            this.layoutTxtTenTK.Location = new System.Drawing.Point(0, 0);
            this.layoutTxtTenTK.Name = "layoutTxtTenTK";
            this.layoutTxtTenTK.Size = new System.Drawing.Size(667, 36);
            this.layoutTxtTenTK.Text = "Tên Tài Khoản:";
            this.layoutTxtTenTK.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutTxtTenTK.TextSize = new System.Drawing.Size(115, 32);
            // 
            // layoutCboNhanVien
            // 
            this.layoutCboNhanVien.Control = this.cboNhanVien;
            this.layoutCboNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutCboNhanVien.ImageOptions.Image")));
            this.layoutCboNhanVien.Location = new System.Drawing.Point(0, 72);
            this.layoutCboNhanVien.Name = "layoutCboNhanVien";
            this.layoutCboNhanVien.Size = new System.Drawing.Size(667, 36);
            this.layoutCboNhanVien.Text = "Nhân Viên:";
            this.layoutCboNhanVien.TextSize = new System.Drawing.Size(115, 32);
            // 
            // layoutTxtViTriChucVu
            // 
            this.layoutTxtViTriChucVu.Control = this.txtViTriChucVu;
            this.layoutTxtViTriChucVu.CustomizationFormText = "Vị Trí (Chức Vụ):";
            this.layoutTxtViTriChucVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutTxtViTriChucVu.ImageOptions.Image")));
            this.layoutTxtViTriChucVu.Location = new System.Drawing.Point(0, 108);
            this.layoutTxtViTriChucVu.Name = "layoutTxtViTriChucVu";
            this.layoutTxtViTriChucVu.Size = new System.Drawing.Size(667, 36);
            this.layoutTxtViTriChucVu.Text = "Vị Trí (Chức Vụ):";
            this.layoutTxtViTriChucVu.TextSize = new System.Drawing.Size(115, 32);
            // 
            // layoutGroupThaoTacCSDL
            // 
            this.layoutGroupThaoTacCSDL.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("layoutGroupThaoTacCSDL.CaptionImageOptions.Image")));
            this.layoutGroupThaoTacCSDL.CustomizationFormText = "Thao tác Cơ Sở Dữ Liệu";
            this.layoutGroupThaoTacCSDL.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem12});
            this.layoutGroupThaoTacCSDL.Location = new System.Drawing.Point(0, 202);
            this.layoutGroupThaoTacCSDL.Name = "layoutGroupThaoTacCSDL";
            this.layoutGroupThaoTacCSDL.OptionsItemText.TextToControlDistance = 3;
            this.layoutGroupThaoTacCSDL.Size = new System.Drawing.Size(691, 138);
            this.layoutGroupThaoTacCSDL.Text = "Thao tác Cơ Sở Dữ Liệu";
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnCapNhat;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem11";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 2;
            this.layoutControlItem7.Size = new System.Drawing.Size(667, 40);
            this.layoutControlItem7.Text = "layoutControlItem11";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnLamMoi;
            this.layoutControlItem12.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem13";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.OptionsTableLayoutItem.RowIndex = 3;
            this.layoutControlItem12.Size = new System.Drawing.Size(667, 40);
            this.layoutControlItem12.Text = "layoutControlItem13";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutDGVTaiKhoan
            // 
            this.layoutDGVTaiKhoan.Control = this.groupDanhSachNhanVien;
            this.layoutDGVTaiKhoan.Location = new System.Drawing.Point(0, 340);
            this.layoutDGVTaiKhoan.Name = "layoutDGVTaiKhoan";
            this.layoutDGVTaiKhoan.Size = new System.Drawing.Size(691, 396);
            this.layoutDGVTaiKhoan.TextSize = new System.Drawing.Size(0, 0);
            this.layoutDGVTaiKhoan.TextVisible = false;
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
            this.labelControl.Size = new System.Drawing.Size(711, 33);
            this.labelControl.TabIndex = 5;
            this.labelControl.Text = "Tài Khoản";
            // 
            // txtViTriChucVu
            // 
            this.txtViTriChucVu.Location = new System.Drawing.Point(151, 166);
            this.txtViTriChucVu.Name = "txtViTriChucVu";
            this.txtViTriChucVu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriChucVu.Properties.Appearance.Options.UseFont = true;
            this.txtViTriChucVu.Properties.ReadOnly = true;
            this.txtViTriChucVu.Size = new System.Drawing.Size(536, 26);
            this.txtViTriChucVu.StyleController = this.layoutDataNhanVien;
            this.txtViTriChucVu.TabIndex = 11;
            // 
            // TaiKhoan_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutDataNhanVien);
            this.Controls.Add(this.labelControl);
            this.Name = "TaiKhoan_UC";
            this.Size = new System.Drawing.Size(711, 789);
            ((System.ComponentModel.ISupportInitialize)(this.layoutDataNhanVien)).EndInit();
            this.layoutDataNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDanhSachNhanVien)).EndInit();
            this.groupDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhauTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupLayoutNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtTenTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCboNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtViTriChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutGroupThaoTacCSDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutDGVTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTriChucVu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraDataLayout.DataLayoutControl layoutDataNhanVien;
        private DevExpress.XtraEditors.GroupControl groupDanhSachNhanVien;
        private DevExpress.XtraGrid.GridControl dgvTaiKhoanNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtMatKhauTK;
        private DevExpress.XtraEditors.TextEdit txtTenTK;
        private DevExpress.XtraLayout.LayoutControlGroup groupLayoutNhanVien;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlItem layoutTxtHoTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutTxtTenTK;
        private DevExpress.XtraLayout.LayoutControlItem layoutTxtViTriChucVu;
        private DevExpress.XtraLayout.LayoutControlItem layoutCboNhanVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutDGVTaiKhoan;
        private DevExpress.XtraEditors.LookUpEdit cboNhanVien;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutGroupThaoTacCSDL;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.TextEdit txtViTriChucVu;
    }
}
