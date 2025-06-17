namespace GUI_POLYCAFE
{
    partial class frmQuanLyThietBi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThietBi = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTenThietBi = new System.Windows.Forms.Label();
            this.txtTenThietBi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.cboTinhTrang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgayMua = new System.Windows.Forms.Label();
            this.dtpNgayMua = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblHanBaoHanh = new System.Windows.Forms.Label();
            this.dtpHanBaoHanh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chkHanBaoHanh = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblLichBaoTri = new System.Windows.Forms.Label();
            this.txtLichBaoTri = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietBi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThietBi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietBi.Location = new System.Drawing.Point(20, 135);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.ReadOnly = true;
            this.dgvThietBi.RowHeadersVisible = false;
            this.dgvThietBi.Size = new System.Drawing.Size(1134, 485);
            this.dgvThietBi.TabIndex = 0;
            this.dgvThietBi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThietBi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThietBi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThietBi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThietBi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietBi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThietBi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThietBi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvThietBi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThietBi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThietBi.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvThietBi.ThemeStyle.ReadOnly = true;
            this.dgvThietBi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThietBi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThietBi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvThietBi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvThietBi.ThemeStyle.RowsStyle.Height = 22;
            this.dgvThietBi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThietBi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThietBi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietBi_CellClick);
            // 
            // lblTenThietBi
            // 
            this.lblTenThietBi.AutoSize = true;
            this.lblTenThietBi.Location = new System.Drawing.Point(17, 17);
            this.lblTenThietBi.Name = "lblTenThietBi";
            this.lblTenThietBi.Size = new System.Drawing.Size(68, 13);
            this.lblTenThietBi.TabIndex = 1;
            this.lblTenThietBi.Text = "Tên Thiết Bị:";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.BorderRadius = 5;
            this.txtTenThietBi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenThietBi.DefaultText = "";
            this.txtTenThietBi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenThietBi.Location = new System.Drawing.Point(120, 17);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.PasswordChar = '\0';
            this.txtTenThietBi.PlaceholderText = "";
            this.txtTenThietBi.SelectedText = "";
            this.txtTenThietBi.Size = new System.Drawing.Size(160, 30);
            this.txtTenThietBi.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(20, 60);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(56, 13);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderRadius = 5;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "";
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(120, 57);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(160, 30);
            this.txtSoLuong.TabIndex = 4;
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(307, 20);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(62, 13);
            this.lblTinhTrang.TabIndex = 5;
            this.lblTinhTrang.Text = "Tình Trạng:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.BackColor = System.Drawing.Color.Transparent;
            this.cboTinhTrang.BorderRadius = 5;
            this.cboTinhTrang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FocusedColor = System.Drawing.Color.Empty;
            this.cboTinhTrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTinhTrang.ItemHeight = 30;
            this.cboTinhTrang.Items.AddRange(new object[] {
            "Hoạt động",
            "Hỏng",
            "Cần bảo trì"});
            this.cboTinhTrang.Location = new System.Drawing.Point(391, 15);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(200, 36);
            this.cboTinhTrang.TabIndex = 6;
            // 
            // lblNgayMua
            // 
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Location = new System.Drawing.Point(310, 60);
            this.lblNgayMua.Name = "lblNgayMua";
            this.lblNgayMua.Size = new System.Drawing.Size(59, 13);
            this.lblNgayMua.TabIndex = 7;
            this.lblNgayMua.Text = "Ngày Mua:";
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.BorderRadius = 5;
            this.dtpNgayMua.Checked = true;
            this.dtpNgayMua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMua.Location = new System.Drawing.Point(391, 57);
            this.dtpNgayMua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayMua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(200, 30);
            this.dtpNgayMua.TabIndex = 8;
            this.dtpNgayMua.Value = new System.DateTime(2025, 6, 16, 21, 30, 19, 558);
            // 
            // lblHanBaoHanh
            // 
            this.lblHanBaoHanh.AutoSize = true;
            this.lblHanBaoHanh.Location = new System.Drawing.Point(611, 20);
            this.lblHanBaoHanh.Name = "lblHanBaoHanh";
            this.lblHanBaoHanh.Size = new System.Drawing.Size(81, 13);
            this.lblHanBaoHanh.TabIndex = 9;
            this.lblHanBaoHanh.Text = "Hạn Bảo Hành:";
            // 
            // dtpHanBaoHanh
            // 
            this.dtpHanBaoHanh.BorderRadius = 5;
            this.dtpHanBaoHanh.Checked = true;
            this.dtpHanBaoHanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpHanBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanBaoHanh.Location = new System.Drawing.Point(698, 17);
            this.dtpHanBaoHanh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHanBaoHanh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpHanBaoHanh.Name = "dtpHanBaoHanh";
            this.dtpHanBaoHanh.Size = new System.Drawing.Size(200, 30);
            this.dtpHanBaoHanh.TabIndex = 10;
            this.dtpHanBaoHanh.Value = new System.DateTime(2025, 6, 16, 21, 30, 19, 579);
            // 
            // chkHanBaoHanh
            // 
            this.chkHanBaoHanh.AutoSize = true;
            this.chkHanBaoHanh.CheckedState.BorderRadius = 0;
            this.chkHanBaoHanh.CheckedState.BorderThickness = 0;
            this.chkHanBaoHanh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkHanBaoHanh.Location = new System.Drawing.Point(904, 20);
            this.chkHanBaoHanh.Name = "chkHanBaoHanh";
            this.chkHanBaoHanh.Size = new System.Drawing.Size(72, 17);
            this.chkHanBaoHanh.TabIndex = 11;
            this.chkHanBaoHanh.Text = "Không có";
            this.chkHanBaoHanh.UncheckedState.BorderRadius = 0;
            this.chkHanBaoHanh.UncheckedState.BorderThickness = 0;
            this.chkHanBaoHanh.CheckedChanged += new System.EventHandler(this.chkHanBaoHanh_CheckedChanged);
            // 
            // lblLichBaoTri
            // 
            this.lblLichBaoTri.AutoSize = true;
            this.lblLichBaoTri.Location = new System.Drawing.Point(611, 60);
            this.lblLichBaoTri.Name = "lblLichBaoTri";
            this.lblLichBaoTri.Size = new System.Drawing.Size(67, 13);
            this.lblLichBaoTri.TabIndex = 12;
            this.lblLichBaoTri.Text = "Lịch Bảo Trì:";
            // 
            // txtLichBaoTri
            // 
            this.txtLichBaoTri.BorderRadius = 5;
            this.txtLichBaoTri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLichBaoTri.DefaultText = "";
            this.txtLichBaoTri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLichBaoTri.Location = new System.Drawing.Point(693, 57);
            this.txtLichBaoTri.Name = "txtLichBaoTri";
            this.txtLichBaoTri.PasswordChar = '\0';
            this.txtLichBaoTri.PlaceholderText = "";
            this.txtLichBaoTri.SelectedText = "";
            this.txtLichBaoTri.Size = new System.Drawing.Size(200, 30);
            this.txtLichBaoTri.TabIndex = 13;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(20, 100);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(53, 13);
            this.lblTimKiem.TabIndex = 14;
            this.lblTimKiem.Text = "Tìm Kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(120, 97);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.TabIndex = 15;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 5;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(982, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 30);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 5;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(982, 57);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 5;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(87)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1070, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 5;
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1070, 57);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // frmQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 663);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtLichBaoTri);
            this.Controls.Add(this.lblLichBaoTri);
            this.Controls.Add(this.chkHanBaoHanh);
            this.Controls.Add(this.dtpHanBaoHanh);
            this.Controls.Add(this.lblHanBaoHanh);
            this.Controls.Add(this.dtpNgayMua);
            this.Controls.Add(this.lblNgayMua);
            this.Controls.Add(this.cboTinhTrang);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtTenThietBi);
            this.Controls.Add(this.lblTenThietBi);
            this.Controls.Add(this.dgvThietBi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanLyThietBi";
            this.Text = "Quản Lý Thiết Bị";
            this.Load += new System.EventHandler(this.frmQuanLyThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvThietBi;
        private System.Windows.Forms.Label lblTenThietBi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenThietBi;
        private System.Windows.Forms.Label lblSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTinhTrang;
        private Guna.UI2.WinForms.Guna2ComboBox cboTinhTrang;
        private System.Windows.Forms.Label lblNgayMua;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayMua;
        private System.Windows.Forms.Label lblHanBaoHanh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpHanBaoHanh;
        private Guna.UI2.WinForms.Guna2CheckBox chkHanBaoHanh;
        private System.Windows.Forms.Label lblLichBaoTri;
        private Guna.UI2.WinForms.Guna2TextBox txtLichBaoTri;
        private System.Windows.Forms.Label lblTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
    }
}