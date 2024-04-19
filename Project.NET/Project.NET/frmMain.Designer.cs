namespace Project.NET
{
    partial class frmMain
    {
        private static int frmWitdh = 0;
        private static int frmHeight = 0;
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nafMain = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.napLogin = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.napMain = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.nafContent = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup3 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiDangNhap = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiNhanVien = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiChiNhanh = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiKho = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tbiThongKe = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nafMain)).BeginInit();
            this.nafMain.SuspendLayout();
            this.napLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.napMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nafContent)).BeginInit();
            this.nafContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // nafMain
            // 
            this.nafMain.Controls.Add(this.napLogin);
            this.nafMain.Controls.Add(this.napMain);
            this.nafMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nafMain.Location = new System.Drawing.Point(0, 24);
            this.nafMain.Name = "nafMain";
            this.nafMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.napLogin,
            this.napMain});
            this.nafMain.SelectedPage = this.napLogin;
            this.nafMain.Size = new System.Drawing.Size(1245, 609);
            this.nafMain.TabIndex = 2;
            this.nafMain.Text = "navigationFrame1";
            // 
            // napLogin
            // 
            this.napLogin.Controls.Add(this.panelControl1);
            this.napLogin.Controls.Add(this.pictureBox1);
            this.napLogin.Name = "napLogin";
            this.napLogin.Padding = new System.Windows.Forms.Padding(20, 150, 20, 150);
            this.napLogin.Size = new System.Drawing.Size(1245, 609);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // napMain
            // 
            this.napMain.Caption = "napMain";
            this.napMain.Controls.Add(this.nafContent);
            this.napMain.Controls.Add(this.tileBar1);
            this.napMain.Name = "napMain";
            this.napMain.Size = new System.Drawing.Size(1245, 609);
            // 
            // nafContent
            // 
            this.nafContent.Controls.Add(this.navigationPage1);
            this.nafContent.Controls.Add(this.navigationPage2);
            this.nafContent.Controls.Add(this.navigationPage3);
            this.nafContent.Controls.Add(this.navigationPage4);
            this.nafContent.Controls.Add(this.navigationPage5);
            this.nafContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nafContent.Location = new System.Drawing.Point(206, 0);
            this.nafContent.Name = "nafContent";
            this.nafContent.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5});
            this.nafContent.SelectedPage = this.navigationPage5;
            this.nafContent.Size = new System.Drawing.Size(1039, 609);
            this.nafContent.TabIndex = 5;
            this.nafContent.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(1039, 609);
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(1039, 609);
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "navigationPage3";
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(1039, 609);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "navigationPage4";
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(1039, 609);
            // 
            // navigationPage5
            // 
            this.navigationPage5.Caption = "navigationPage5";
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(1039, 609);
            // 
            // tileBar1
            // 
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(191)))), ((int)(((byte)(51)))));
            this.tileBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup3);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 7;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar1.Size = new System.Drawing.Size(206, 609);
            this.tileBar1.TabIndex = 4;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup3
            // 
            this.tileBarGroup3.Items.Add(this.tbiDangNhap);
            this.tileBarGroup3.Items.Add(this.tbiNhanVien);
            this.tileBarGroup3.Items.Add(this.tbiChiNhanh);
            this.tileBarGroup3.Items.Add(this.tbiKho);
            this.tileBarGroup3.Items.Add(this.tbiThongKe);
            this.tileBarGroup3.Name = "tileBarGroup3";
            // 
            // tbiDangNhap
            // 
            this.tbiDangNhap.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = global::Project.NET.Properties.Resources.assignto_32x32;
            tileItemElement6.Text = "Đăng nhập";
            this.tbiDangNhap.Elements.Add(tileItemElement6);
            this.tbiDangNhap.Id = 2;
            this.tbiDangNhap.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiDangNhap.Name = "tbiDangNhap";
            // 
            // tbiNhanVien
            // 
            this.tbiNhanVien.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageOptions.Image = global::Project.NET.Properties.Resources.usergroup_32x32;
            tileItemElement7.Text = "Nhân viên";
            this.tbiNhanVien.Elements.Add(tileItemElement7);
            this.tbiNhanVien.Id = 3;
            this.tbiNhanVien.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiNhanVien.Name = "tbiNhanVien";
            // 
            // tbiChiNhanh
            // 
            this.tbiChiNhanh.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.ImageOptions.Image = global::Project.NET.Properties.Resources.home_32x32;
            tileItemElement8.Text = "Chi nhánh";
            this.tbiChiNhanh.Elements.Add(tileItemElement8);
            this.tbiChiNhanh.Id = 6;
            this.tbiChiNhanh.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiChiNhanh.Name = "tbiChiNhanh";
            // 
            // tbiKho
            // 
            this.tbiKho.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageOptions.Image = global::Project.NET.Properties.Resources.boproductgroup_32x32;
            tileItemElement9.Text = "Kho";
            this.tbiKho.Elements.Add(tileItemElement9);
            this.tbiKho.Id = 4;
            this.tbiKho.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiKho.Name = "tbiKho";
            // 
            // tbiThongKe
            // 
            this.tbiThongKe.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.ImageOptions.Image = global::Project.NET.Properties.Resources.horizontalgridlinesminor_32x32;
            tileItemElement10.Text = "Thống kê";
            this.tbiThongKe.Elements.Add(tileItemElement10);
            this.tbiThongKe.Id = 5;
            this.tbiThongKe.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiThongKe.Name = "tbiThongKe";
            // 
            // panelControl1
            // 
            this.panelControl1.Location = new System.Drawing.Point(876, 234);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(346, 222);
            this.panelControl1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(136)))), ((int)(((byte)(73)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 633);
            this.Controls.Add(this.nafMain);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hệ thống Bách hóa Xanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nafMain)).EndInit();
            this.nafMain.ResumeLayout(false);
            this.napLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.napMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nafContent)).EndInit();
            this.nafContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup1;
        private DevExpress.XtraBars.Navigation.NavigationFrame nafMain;
        private DevExpress.XtraBars.Navigation.NavigationPage napLogin;
        private DevExpress.XtraBars.Navigation.NavigationPage napMain;
        private DevExpress.XtraBars.Navigation.NavigationFrame nafContent;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup3;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiDangNhap;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiNhanVien;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiChiNhanh;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiKho;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiThongKe;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}