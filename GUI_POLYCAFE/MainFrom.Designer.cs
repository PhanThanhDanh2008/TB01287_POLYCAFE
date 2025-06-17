namespace GUI_POLYCAFE
{
    partial class MainFrom
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlmain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProductTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productRevenueReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffRevenueReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStaffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMobileCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReceiptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSalesReceiptMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSalesDetailMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.Location = new System.Drawing.Point(0, 29);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(1174, 663);
            this.pnlmain.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemMenuItem,
            this.productCategoryMenuItem,
            this.reportMenuItem,
            this.directoryMenuItem,
            this.salesReceiptMenuItem,
            this.searchTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1174, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemMenuItem
            // 
            this.systemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordMenuItem,
            this.accountInfoMenuItem,
            this.logoutMenuItem,
            this.exitMenuItem});
            this.systemMenuItem.Name = "systemMenuItem";
            this.systemMenuItem.Size = new System.Drawing.Size(79, 23);
            this.systemMenuItem.Text = "HỆ THỐNG";
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(203, 22);
            this.changePasswordMenuItem.Text = "ĐỔI MẬT KHẨU";
            this.changePasswordMenuItem.Click += new System.EventHandler(this.changePasswordMenuItem_Click);
            // 
            // accountInfoMenuItem
            // 
            this.accountInfoMenuItem.Name = "accountInfoMenuItem";
            this.accountInfoMenuItem.Size = new System.Drawing.Size(203, 22);
            this.accountInfoMenuItem.Text = "THÔNG TIN TÀI KHOẢN";
            this.accountInfoMenuItem.Click += new System.EventHandler(this.accountInfoMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Size = new System.Drawing.Size(203, 22);
            this.logoutMenuItem.Text = "ĐĂNG XUẤT";
            this.logoutMenuItem.Click += new System.EventHandler(this.logoutMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(203, 22);
            this.exitMenuItem.Text = "THOÁT";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // productCategoryMenuItem
            // 
            this.productCategoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageProductMenuItem,
            this.manageProductTypeMenuItem});
            this.productCategoryMenuItem.Name = "productCategoryMenuItem";
            this.productCategoryMenuItem.Size = new System.Drawing.Size(80, 23);
            this.productCategoryMenuItem.Text = "SẢN PHẨM";
            // 
            // manageProductMenuItem
            // 
            this.manageProductMenuItem.Name = "manageProductMenuItem";
            this.manageProductMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageProductMenuItem.Text = "QUẢN LÝ SẢN PHẨM";
            this.manageProductMenuItem.Click += new System.EventHandler(this.manageProductMenuItem_Click);
            // 
            // manageProductTypeMenuItem
            // 
            this.manageProductTypeMenuItem.Name = "manageProductTypeMenuItem";
            this.manageProductTypeMenuItem.Size = new System.Drawing.Size(216, 22);
            this.manageProductTypeMenuItem.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            this.manageProductTypeMenuItem.Click += new System.EventHandler(this.manageProductTypeMenuItem_Click);
            // 
            // reportMenuItem
            // 
            this.reportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productRevenueReportMenuItem,
            this.staffRevenueReportMenuItem});
            this.reportMenuItem.Name = "reportMenuItem";
            this.reportMenuItem.Size = new System.Drawing.Size(71, 23);
            this.reportMenuItem.Text = "BÁO CÁO";
            // 
            // productRevenueReportMenuItem
            // 
            this.productRevenueReportMenuItem.Name = "productRevenueReportMenuItem";
            this.productRevenueReportMenuItem.Size = new System.Drawing.Size(265, 22);
            this.productRevenueReportMenuItem.Text = "BÁO CÁO DOANH THU SẢN PHẨM";
            this.productRevenueReportMenuItem.Click += new System.EventHandler(this.productRevenueReportMenuItem_Click);
            // 
            // staffRevenueReportMenuItem
            // 
            this.staffRevenueReportMenuItem.Name = "staffRevenueReportMenuItem";
            this.staffRevenueReportMenuItem.Size = new System.Drawing.Size(265, 22);
            this.staffRevenueReportMenuItem.Text = "BÁO CÁO DOANH THU NHÂN VIÊN";
            this.staffRevenueReportMenuItem.Click += new System.EventHandler(this.staffRevenueReportMenuItem_Click);
            // 
            // directoryMenuItem
            // 
            this.directoryMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStaffMenuItem,
            this.manageMobileCardMenuItem,
            this.manageDeviceMenuItem});
            this.directoryMenuItem.Name = "directoryMenuItem";
            this.directoryMenuItem.Size = new System.Drawing.Size(71, 23);
            this.directoryMenuItem.Text = "MỤC LỤC";
            // 
            // manageStaffMenuItem
            // 
            this.manageStaffMenuItem.Name = "manageStaffMenuItem";
            this.manageStaffMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageStaffMenuItem.Text = "QUẢN LÝ NHÂN VIÊN";
            this.manageStaffMenuItem.Click += new System.EventHandler(this.manageStaffMenuItem_Click);
            // 
            // manageMobileCardMenuItem
            // 
            this.manageMobileCardMenuItem.Name = "manageMobileCardMenuItem";
            this.manageMobileCardMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageMobileCardMenuItem.Text = "QUẢN LÝ THẺ LƯU ĐỘNG";
            this.manageMobileCardMenuItem.Click += new System.EventHandler(this.manageMobileCardMenuItem_Click);
            // 
            // manageDeviceMenuItem
            // 
            this.manageDeviceMenuItem.Name = "manageDeviceMenuItem";
            this.manageDeviceMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manageDeviceMenuItem.Text = "QUẢN LÝ THIẾT BỊ";
            this.manageDeviceMenuItem.Click += new System.EventHandler(this.manageDeviceMenuItem_Click);
            // 
            // salesReceiptMenuItem
            // 
            this.salesReceiptMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageSalesReceiptMenuItem,
            this.manageSalesDetailMenuItem});
            this.salesReceiptMenuItem.Name = "salesReceiptMenuItem";
            this.salesReceiptMenuItem.Size = new System.Drawing.Size(116, 23);
            this.salesReceiptMenuItem.Text = "PHIẾU BÁN HÀNG";
            this.salesReceiptMenuItem.Click += new System.EventHandler(this.salesReceiptMenuItem_Click);
            // 
            // manageSalesReceiptMenuItem
            // 
            this.manageSalesReceiptMenuItem.Name = "manageSalesReceiptMenuItem";
            this.manageSalesReceiptMenuItem.Size = new System.Drawing.Size(272, 22);
            this.manageSalesReceiptMenuItem.Text = "QUẢN LÝ PHIẾU BÁN HÀNG";
            this.manageSalesReceiptMenuItem.Click += new System.EventHandler(this.manageSalesReceiptMenuItem_Click);
            // 
            // manageSalesDetailMenuItem
            // 
            this.manageSalesDetailMenuItem.Name = "manageSalesDetailMenuItem";
            this.manageSalesDetailMenuItem.Size = new System.Drawing.Size(272, 22);
            this.manageSalesDetailMenuItem.Text = "QUẢN LÝ CHI TIẾT PHIẾU BÁN HÀNG";
            this.manageSalesDetailMenuItem.Click += new System.EventHandler(this.manageSalesDetailMenuItem_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 23);
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 692);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1190, 731);
            this.MinimumSize = new System.Drawing.Size(1190, 731);
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProductTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productRevenueReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffRevenueReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStaffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMobileCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDeviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReceiptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSalesReceiptMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSalesDetailMenuItem;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
    }
}