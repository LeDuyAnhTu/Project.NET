namespace Project.NET.GUI_UC
{
    partial class Login_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_UC));
            this.tableLogin = new DevExpress.Utils.Layout.TablePanel();
            this.layoutLogin = new System.Windows.Forms.TableLayoutPanel();
            this.groupDangNhap = new DevExpress.XtraEditors.GroupControl();
            this.controlsLogin = new DevExpress.XtraLayout.LayoutControl();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.txtMatKhau = new DevExpress.XtraEditors.ButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutTxtTenDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutTxtMatKhau = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutBtnDangNhap = new DevExpress.XtraLayout.LayoutControlItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableLogin)).BeginInit();
            this.tableLogin.SuspendLayout();
            this.layoutLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).BeginInit();
            this.groupDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlsLogin)).BeginInit();
            this.controlsLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtTenDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnDangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLogin
            // 
            this.tableLogin.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(187)))));
            this.tableLogin.Appearance.Options.UseBackColor = true;
            this.tableLogin.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 62.58F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37.42F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F)});
            this.tableLogin.Controls.Add(this.layoutLogin);
            this.tableLogin.Controls.Add(this.pictureBox1);
            this.tableLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLogin.Location = new System.Drawing.Point(0, 0);
            this.tableLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tableLogin.Name = "tableLogin";
            this.tableLogin.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 384.4F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tableLogin.Size = new System.Drawing.Size(828, 551);
            this.tableLogin.TabIndex = 3;
            this.tableLogin.UseSkinIndents = true;
            // 
            // layoutLogin
            // 
            this.tableLogin.SetColumn(this.layoutLogin, 2);
            this.layoutLogin.ColumnCount = 1;
            this.layoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutLogin.Controls.Add(this.groupDangNhap, 0, 1);
            this.layoutLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutLogin.Location = new System.Drawing.Point(500, 83);
            this.layoutLogin.Margin = new System.Windows.Forms.Padding(0);
            this.layoutLogin.Name = "layoutLogin";
            this.tableLogin.SetRow(this.layoutLogin, 1);
            this.layoutLogin.RowCount = 3;
            this.layoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.34375F));
            this.layoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.35417F));
            this.layoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.5625F));
            this.layoutLogin.Size = new System.Drawing.Size(254, 384);
            this.layoutLogin.TabIndex = 5;
            // 
            // groupDangNhap
            // 
            this.groupDangNhap.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDangNhap.Appearance.Options.UseBackColor = true;
            this.groupDangNhap.Appearance.Options.UseFont = true;
            this.groupDangNhap.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.groupDangNhap.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDangNhap.AppearanceCaption.Options.UseBackColor = true;
            this.groupDangNhap.AppearanceCaption.Options.UseFont = true;
            this.groupDangNhap.AutoSize = true;
            this.groupDangNhap.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupDangNhap.CaptionImageOptions.Image")));
            this.groupDangNhap.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupDangNhap.Controls.Add(this.controlsLogin);
            this.groupDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDangNhap.GroupStyle = DevExpress.Utils.GroupStyle.Card;
            this.groupDangNhap.Location = new System.Drawing.Point(3, 107);
            this.groupDangNhap.Name = "groupDangNhap";
            this.groupDangNhap.Padding = new System.Windows.Forms.Padding(3);
            this.groupDangNhap.Size = new System.Drawing.Size(248, 171);
            this.groupDangNhap.TabIndex = 0;
            this.groupDangNhap.Text = "Đăng nhập";
            // 
            // controlsLogin
            // 
            this.controlsLogin.Controls.Add(this.txtTenDangNhap);
            this.controlsLogin.Controls.Add(this.btnDangNhap);
            this.controlsLogin.Controls.Add(this.txtMatKhau);
            this.controlsLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsLogin.Location = new System.Drawing.Point(5, 38);
            this.controlsLogin.Name = "controlsLogin";
            this.controlsLogin.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 184, 650, 400);
            this.controlsLogin.Root = this.Root;
            this.controlsLogin.Size = new System.Drawing.Size(238, 128);
            this.controlsLogin.TabIndex = 0;
            this.controlsLogin.Text = "layoutControl1";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.EditValue = "";
            this.txtTenDangNhap.Location = new System.Drawing.Point(154, 6);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(187)))));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenDangNhap.Properties.BeepOnError = true;
            this.txtTenDangNhap.Properties.UseMaskAsDisplayFormat = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(78, 26);
            this.txtTenDangNhap.StyleController = this.controlsLogin;
            this.txtTenDangNhap.TabIndex = 4;
            this.txtTenDangNhap.ToolTipTitle = "Tên đăng nhập";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.AppearanceDisabled.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDangNhap.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDangNhap.AppearanceDisabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.AppearanceDisabled.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDangNhap.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnDangNhap.AppearanceDisabled.Options.UseBackColor = true;
            this.btnDangNhap.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnDangNhap.AppearanceDisabled.Options.UseFont = true;
            this.btnDangNhap.AppearanceDisabled.Options.UseForeColor = true;
            this.btnDangNhap.AppearanceHovered.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDangNhap.AppearanceHovered.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning;
            this.btnDangNhap.AppearanceHovered.Options.UseBackColor = true;
            this.btnDangNhap.AppearanceHovered.Options.UseBorderColor = true;
            this.btnDangNhap.AppearanceHovered.Options.UseFont = true;
            this.btnDangNhap.AppearanceHovered.Options.UseForeColor = true;
            this.btnDangNhap.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDangNhap.AppearancePressed.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
            this.btnDangNhap.AppearancePressed.Options.UseBackColor = true;
            this.btnDangNhap.AppearancePressed.Options.UseBorderColor = true;
            this.btnDangNhap.AppearancePressed.Options.UseFont = true;
            this.btnDangNhap.AppearancePressed.Options.UseForeColor = true;
            this.btnDangNhap.Location = new System.Drawing.Point(6, 74);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(226, 48);
            this.btnDangNhap.StyleController = this.controlsLogin;
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(154, 40);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(117)))), ((int)(((byte)(187)))));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.Appearance.Options.UseForeColor = true;
            this.txtMatKhau.Properties.BeepOnError = true;
            this.txtMatKhau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Properties.UseMaskAsDisplayFormat = true;
            this.txtMatKhau.Size = new System.Drawing.Size(78, 26);
            this.txtMatKhau.StyleController = this.controlsLogin;
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.ToolTipTitle = "Mật khẩu";
            // 
            // Root
            // 
            this.Root.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Root.AppearanceGroup.Options.UseFont = true;
            this.Root.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Root.AppearanceItemCaption.Options.UseFont = true;
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTxtTenDangNhap,
            this.layoutTxtMatKhau,
            this.layoutBtnDangNhap});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(238, 128);
            this.Root.TextVisible = false;
            // 
            // layoutTxtTenDangNhap
            // 
            this.layoutTxtTenDangNhap.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutTxtTenDangNhap.AppearanceItemCaption.Options.UseFont = true;
            this.layoutTxtTenDangNhap.Control = this.txtTenDangNhap;
            this.layoutTxtTenDangNhap.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutTxtTenDangNhap.CustomizationFormText = "Tên đăng nhập";
            this.layoutTxtTenDangNhap.ImageOptions.Image = global::Project.NET.Properties.Resources.key32_32;
            this.layoutTxtTenDangNhap.Location = new System.Drawing.Point(0, 0);
            this.layoutTxtTenDangNhap.Name = "layoutTxtTenDangNhap";
            this.layoutTxtTenDangNhap.Size = new System.Drawing.Size(228, 34);
            this.layoutTxtTenDangNhap.Text = "Tên đăng nhập";
            this.layoutTxtTenDangNhap.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutTxtTenDangNhap.TextSize = new System.Drawing.Size(144, 32);
            // 
            // layoutTxtMatKhau
            // 
            this.layoutTxtMatKhau.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutTxtMatKhau.AppearanceItemCaption.Options.UseFont = true;
            this.layoutTxtMatKhau.Control = this.txtMatKhau;
            this.layoutTxtMatKhau.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutTxtMatKhau.ImageOptions.Image = global::Project.NET.Properties.Resources.pass32_32;
            this.layoutTxtMatKhau.Location = new System.Drawing.Point(0, 34);
            this.layoutTxtMatKhau.Name = "layoutTxtMatKhau";
            this.layoutTxtMatKhau.Size = new System.Drawing.Size(228, 34);
            this.layoutTxtMatKhau.Text = "Mật khẩu";
            this.layoutTxtMatKhau.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutTxtMatKhau.TextSize = new System.Drawing.Size(144, 32);
            // 
            // layoutBtnDangNhap
            // 
            this.layoutBtnDangNhap.Control = this.btnDangNhap;
            this.layoutBtnDangNhap.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutBtnDangNhap.CustomizationFormText = "Nút đăng nhập";
            this.layoutBtnDangNhap.ImageOptions.Image = global::Project.NET.Properties.Resources.logo;
            this.layoutBtnDangNhap.Location = new System.Drawing.Point(0, 68);
            this.layoutBtnDangNhap.MinSize = new System.Drawing.Size(88, 28);
            this.layoutBtnDangNhap.Name = "layoutBtnDangNhap";
            this.layoutBtnDangNhap.Size = new System.Drawing.Size(228, 50);
            this.layoutBtnDangNhap.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutBtnDangNhap.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutBtnDangNhap.TextSize = new System.Drawing.Size(0, 0);
            this.layoutBtnDangNhap.TextVisible = false;
            // 
            // pictureBox1
            // 
            this.tableLogin.SetColumn(this.pictureBox1, 1);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLogin.SetRow(this.pictureBox1, 1);
            this.pictureBox1.Size = new System.Drawing.Size(424, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login_UC
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLogin);
            this.Name = "Login_UC";
            this.Size = new System.Drawing.Size(828, 551);
            ((System.ComponentModel.ISupportInitialize)(this.tableLogin)).EndInit();
            this.tableLogin.ResumeLayout(false);
            this.layoutLogin.ResumeLayout(false);
            this.layoutLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDangNhap)).EndInit();
            this.groupDangNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlsLogin)).EndInit();
            this.controlsLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtTenDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTxtMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBtnDangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tableLogin;
        private System.Windows.Forms.TableLayoutPanel layoutLogin;
        private DevExpress.XtraEditors.GroupControl groupDangNhap;
        private DevExpress.XtraLayout.LayoutControl controlsLogin;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.ButtonEdit txtMatKhau;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutTxtTenDangNhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutTxtMatKhau;
        private DevExpress.XtraLayout.LayoutControlItem layoutBtnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
