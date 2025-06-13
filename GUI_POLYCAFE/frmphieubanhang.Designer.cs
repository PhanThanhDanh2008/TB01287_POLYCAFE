namespace GUI_POLYCAFE
{
    partial class frmphieubanhang
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dgrDanhSachPhieu = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnlammoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboMaTheLuuDong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rdbPaid = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbConfirmation = new Guna.UI2.WinForms.Guna2RadioButton();
            this.dtpNgayTao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cboNhanVienBH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachPhieu)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1160, 80);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.dgrDanhSachPhieu);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2GroupBox2);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2GroupBox1);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.White;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(0, 80);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1160, 545);
            this.guna2CustomGradientPanel2.TabIndex = 2;
            // 
            // dgrDanhSachPhieu
            // 
            this.dgrDanhSachPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachPhieu.Location = new System.Drawing.Point(12, 12);
            this.dgrDanhSachPhieu.Name = "dgrDanhSachPhieu";
            this.dgrDanhSachPhieu.Size = new System.Drawing.Size(1136, 280);
            this.dgrDanhSachPhieu.TabIndex = 5;
            this.dgrDanhSachPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachPhieu_CellClick_1);
            this.dgrDanhSachPhieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachPhieu_CellDoubleClick);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btnlammoi);
            this.guna2GroupBox2.Controls.Add(this.btnSuaPhieu);
            this.guna2GroupBox2.Controls.Add(this.btnXoaPhieu);
            this.guna2GroupBox2.Controls.Add(this.btnThemPhieu);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(830, 300);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(318, 235);
            this.guna2GroupBox2.TabIndex = 4;
            this.guna2GroupBox2.Text = "Thao Tác";
            // 
            // btnlammoi
            // 
            this.btnlammoi.AutoRoundedCorners = true;
            this.btnlammoi.BackColor = System.Drawing.Color.Transparent;
            this.btnlammoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnlammoi.BorderRadius = 18;
            this.btnlammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlammoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlammoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlammoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlammoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlammoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnlammoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnlammoi.ForeColor = System.Drawing.Color.White;
            this.btnlammoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnlammoi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnlammoi.Image = global::GUI_POLYCAFE.Properties.Resources.refresh;
            this.btnlammoi.Location = new System.Drawing.Point(176, 175);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(99, 38);
            this.btnlammoi.TabIndex = 7;
            this.btnlammoi.Text = "LÀM MỚI";
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnSuaPhieu
            // 
            this.btnSuaPhieu.AutoRoundedCorners = true;
            this.btnSuaPhieu.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaPhieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSuaPhieu.BorderRadius = 18;
            this.btnSuaPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSuaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSuaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnSuaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnSuaPhieu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnSuaPhieu.Image = global::GUI_POLYCAFE.Properties.Resources.service;
            this.btnSuaPhieu.Location = new System.Drawing.Point(44, 175);
            this.btnSuaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhieu.Name = "btnSuaPhieu";
            this.btnSuaPhieu.Size = new System.Drawing.Size(92, 38);
            this.btnSuaPhieu.TabIndex = 6;
            this.btnSuaPhieu.Text = "SỬA";
            this.btnSuaPhieu.Click += new System.EventHandler(this.btnSuaPhieu_Click);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.AutoRoundedCorners = true;
            this.btnXoaPhieu.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaPhieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXoaPhieu.BorderRadius = 18;
            this.btnXoaPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnXoaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoaPhieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnXoaPhieu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnXoaPhieu.Image = global::GUI_POLYCAFE.Properties.Resources.out_of_stock;
            this.btnXoaPhieu.Location = new System.Drawing.Point(187, 85);
            this.btnXoaPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.Size = new System.Drawing.Size(88, 38);
            this.btnXoaPhieu.TabIndex = 5;
            this.btnXoaPhieu.Text = "XÓA";
            this.btnXoaPhieu.Click += new System.EventHandler(this.btnXoaPhieu_Click);
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.AutoRoundedCorners = true;
            this.btnThemPhieu.BackColor = System.Drawing.Color.Transparent;
            this.btnThemPhieu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThemPhieu.BorderRadius = 18;
            this.btnThemPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnThemPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThemPhieu.ForeColor = System.Drawing.Color.White;
            this.btnThemPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnThemPhieu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnThemPhieu.Image = global::GUI_POLYCAFE.Properties.Resources.add_to_cart;
            this.btnThemPhieu.Location = new System.Drawing.Point(44, 85);
            this.btnThemPhieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.Size = new System.Drawing.Size(83, 38);
            this.btnThemPhieu.TabIndex = 4;
            this.btnThemPhieu.Text = "THÊM";
            this.btnThemPhieu.Click += new System.EventHandler(this.btnThemPhieu_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cboMaTheLuuDong);
            this.guna2GroupBox1.Controls.Add(this.rdbPaid);
            this.guna2GroupBox1.Controls.Add(this.rdbConfirmation);
            this.guna2GroupBox1.Controls.Add(this.dtpNgayTao);
            this.guna2GroupBox1.Controls.Add(this.cboNhanVienBH);
            this.guna2GroupBox1.Controls.Add(this.txtMaPhieu);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 300);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(810, 235);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Thông Tin Phiếu";
            // 
            // cboMaTheLuuDong
            // 
            this.cboMaTheLuuDong.AutoRoundedCorners = true;
            this.cboMaTheLuuDong.BackColor = System.Drawing.Color.Transparent;
            this.cboMaTheLuuDong.BorderRadius = 17;
            this.cboMaTheLuuDong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMaTheLuuDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaTheLuuDong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboMaTheLuuDong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaTheLuuDong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMaTheLuuDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboMaTheLuuDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboMaTheLuuDong.ItemHeight = 30;
            this.cboMaTheLuuDong.Location = new System.Drawing.Point(156, 40);
            this.cboMaTheLuuDong.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaTheLuuDong.Name = "cboMaTheLuuDong";
            this.cboMaTheLuuDong.Size = new System.Drawing.Size(250, 36);
            this.cboMaTheLuuDong.TabIndex = 6;
            // 
            // rdbPaid
            // 
            this.rdbPaid.AutoSize = true;
            this.rdbPaid.BackColor = System.Drawing.Color.Transparent;
            this.rdbPaid.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbPaid.CheckedState.BorderThickness = 0;
            this.rdbPaid.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbPaid.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbPaid.CheckedState.InnerOffset = -4;
            this.rdbPaid.ForeColor = System.Drawing.Color.Black;
            this.rdbPaid.Location = new System.Drawing.Point(285, 190);
            this.rdbPaid.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPaid.Name = "rdbPaid";
            this.rdbPaid.Size = new System.Drawing.Size(105, 19);
            this.rdbPaid.TabIndex = 5;
            this.rdbPaid.Text = "Đã Thanh Toán";
            this.rdbPaid.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbPaid.UncheckedState.BorderThickness = 2;
            this.rdbPaid.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbPaid.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbPaid.UseVisualStyleBackColor = false;
            // 
            // rdbConfirmation
            // 
            this.rdbConfirmation.AutoSize = true;
            this.rdbConfirmation.BackColor = System.Drawing.Color.Transparent;
            this.rdbConfirmation.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbConfirmation.CheckedState.BorderThickness = 0;
            this.rdbConfirmation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbConfirmation.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbConfirmation.CheckedState.InnerOffset = -4;
            this.rdbConfirmation.ForeColor = System.Drawing.Color.Black;
            this.rdbConfirmation.Location = new System.Drawing.Point(156, 190);
            this.rdbConfirmation.Margin = new System.Windows.Forms.Padding(2);
            this.rdbConfirmation.Name = "rdbConfirmation";
            this.rdbConfirmation.Size = new System.Drawing.Size(101, 19);
            this.rdbConfirmation.TabIndex = 4;
            this.rdbConfirmation.Text = "Chờ Xác Nhận";
            this.rdbConfirmation.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbConfirmation.UncheckedState.BorderThickness = 2;
            this.rdbConfirmation.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbConfirmation.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbConfirmation.UseVisualStyleBackColor = false;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.AutoRoundedCorners = true;
            this.dtpNgayTao.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayTao.BorderRadius = 17;
            this.dtpNgayTao.Checked = true;
            this.dtpNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayTao.ForeColor = System.Drawing.Color.Black;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayTao.Location = new System.Drawing.Point(513, 115);
            this.dtpNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayTao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(250, 36);
            this.dtpNgayTao.TabIndex = 3;
            this.dtpNgayTao.Value = new System.DateTime(2025, 6, 13, 22, 45, 0, 0);
            // 
            // cboNhanVienBH
            // 
            this.cboNhanVienBH.AutoRoundedCorners = true;
            this.cboNhanVienBH.BackColor = System.Drawing.Color.Transparent;
            this.cboNhanVienBH.BorderRadius = 17;
            this.cboNhanVienBH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNhanVienBH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVienBH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cboNhanVienBH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhanVienBH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboNhanVienBH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboNhanVienBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboNhanVienBH.ItemHeight = 30;
            this.cboNhanVienBH.Location = new System.Drawing.Point(513, 40);
            this.cboNhanVienBH.Margin = new System.Windows.Forms.Padding(2);
            this.cboNhanVienBH.Name = "cboNhanVienBH";
            this.cboNhanVienBH.Size = new System.Drawing.Size(250, 36);
            this.cboNhanVienBH.TabIndex = 2;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.AutoRoundedCorners = true;
            this.txtMaPhieu.BackColor = System.Drawing.Color.Transparent;
            this.txtMaPhieu.BorderRadius = 17;
            this.txtMaPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPhieu.DefaultText = "";
            this.txtMaPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMaPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtMaPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaPhieu.Location = new System.Drawing.Point(156, 115);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.PasswordChar = '\0';
            this.txtMaPhieu.PlaceholderText = "";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.SelectedText = "";
            this.txtMaPhieu.Size = new System.Drawing.Size(250, 37);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // frmphieubanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 625);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmphieubanhang";
            this.Text = "Quản Lý Phiếu Bán Hàng";
            this.Load += new System.EventHandler(this.frmchitietphiet_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachPhieu)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaPhieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboNhanVienBH;
        private Guna.UI2.WinForms.Guna2RadioButton rdbConfirmation;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayTao;
        private Guna.UI2.WinForms.Guna2RadioButton rdbPaid;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button btnlammoi;
        private Guna.UI2.WinForms.Guna2Button btnSuaPhieu;
        private Guna.UI2.WinForms.Guna2Button btnXoaPhieu;
        private Guna.UI2.WinForms.Guna2Button btnThemPhieu;
        private Guna.UI2.WinForms.Guna2ComboBox cboMaTheLuuDong;
        private System.Windows.Forms.DataGridView dgrDanhSachPhieu;
    }
}