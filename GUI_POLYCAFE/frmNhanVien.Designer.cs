using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace GUI_POLYCAFE
{
    partial class frmNhanVien
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
            this.dataNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grpthongtin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbdstop = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbdhoatdong = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbdquanly = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbdnv = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthovaten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmanv = new Guna.UI2.WinForms.Guna2TextBox();
            this.grpchucnang = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnlamoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnthoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.grpthongtin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AllowUserToAddRows = false;
            this.dataNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataNhanVien.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataNhanVien.Location = new System.Drawing.Point(20, 69);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.RowHeadersVisible = false;
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.Size = new System.Drawing.Size(1130, 337);
            this.dataNhanVien.TabIndex = 0;
            this.dataNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataNhanVien.ThemeStyle.HeaderStyle.Height = 30;
            this.dataNhanVien.ThemeStyle.ReadOnly = false;
            this.dataNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dataNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataNhanVien.ThemeStyle.RowsStyle.Height = 22;
            this.dataNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellClick);
            this.dataNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellContentClick);
            this.dataNhanVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellEndEdit);
            this.dataNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataNhanVien_CellFormatting);
            // 
            // grpthongtin
            // 
            this.grpthongtin.BackColor = System.Drawing.Color.Transparent;
            this.grpthongtin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.grpthongtin.BorderRadius = 10;
            this.grpthongtin.Controls.Add(this.panel2);
            this.grpthongtin.Controls.Add(this.panel1);
            this.grpthongtin.Controls.Add(this.label7);
            this.grpthongtin.Controls.Add(this.label6);
            this.grpthongtin.Controls.Add(this.label5);
            this.grpthongtin.Controls.Add(this.label3);
            this.grpthongtin.Controls.Add(this.label2);
            this.grpthongtin.Controls.Add(this.label1);
            this.grpthongtin.Controls.Add(this.txtmatkhau);
            this.grpthongtin.Controls.Add(this.txtemail);
            this.grpthongtin.Controls.Add(this.txthovaten);
            this.grpthongtin.Controls.Add(this.txtmanv);
            this.grpthongtin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpthongtin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpthongtin.Location = new System.Drawing.Point(20, 412);
            this.grpthongtin.Name = "grpthongtin";
            this.grpthongtin.ShadowDecoration.Enabled = true;
            this.grpthongtin.Size = new System.Drawing.Size(800, 258);
            this.grpthongtin.TabIndex = 1;
            this.grpthongtin.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel2
            // 
            this.panel2.BorderRadius = 5;
            this.panel2.Controls.Add(this.rbdstop);
            this.panel2.Controls.Add(this.rbdhoatdong);
            this.panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel2.Location = new System.Drawing.Point(450, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 60);
            this.panel2.TabIndex = 19;
            // 
            // rbdstop
            // 
            this.rbdstop.AutoSize = true;
            this.rbdstop.CheckedState.BorderThickness = 0;
            this.rbdstop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbdstop.Location = new System.Drawing.Point(180, 20);
            this.rbdstop.Name = "rbdstop";
            this.rbdstop.Size = new System.Drawing.Size(106, 23);
            this.rbdstop.TabIndex = 17;
            this.rbdstop.Text = "Tạm Ngưng";
            this.rbdstop.UncheckedState.BorderThickness = 0;
            // 
            // rbdhoatdong
            // 
            this.rbdhoatdong.AutoSize = true;
            this.rbdhoatdong.CheckedState.BorderThickness = 0;
            this.rbdhoatdong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbdhoatdong.Location = new System.Drawing.Point(20, 20);
            this.rbdhoatdong.Name = "rbdhoatdong";
            this.rbdhoatdong.Size = new System.Drawing.Size(100, 23);
            this.rbdhoatdong.TabIndex = 16;
            this.rbdhoatdong.Text = "Hoạt Động";
            this.rbdhoatdong.UncheckedState.BorderThickness = 0;
            // 
            // panel1
            // 
            this.panel1.BorderRadius = 5;
            this.panel1.Controls.Add(this.rbdquanly);
            this.panel1.Controls.Add(this.rbdnv);
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(450, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 60);
            this.panel1.TabIndex = 18;
            // 
            // rbdquanly
            // 
            this.rbdquanly.AutoSize = true;
            this.rbdquanly.CheckedState.BorderThickness = 0;
            this.rbdquanly.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbdquanly.Location = new System.Drawing.Point(180, 20);
            this.rbdquanly.Name = "rbdquanly";
            this.rbdquanly.Size = new System.Drawing.Size(81, 23);
            this.rbdquanly.TabIndex = 17;
            this.rbdquanly.Text = "Quản Lý";
            this.rbdquanly.UncheckedState.BorderThickness = 0;
            // 
            // rbdnv
            // 
            this.rbdnv.AutoSize = true;
            this.rbdnv.CheckedState.BorderThickness = 0;
            this.rbdnv.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbdnv.Location = new System.Drawing.Point(20, 20);
            this.rbdnv.Name = "rbdnv";
            this.rbdnv.Size = new System.Drawing.Size(95, 23);
            this.rbdnv.TabIndex = 16;
            this.rbdnv.Text = "Nhân Viên";
            this.rbdnv.UncheckedState.BorderThickness = 0;
            this.rbdnv.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(360, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "TRẠNG THÁI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(360, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "VAI TRÒ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(360, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ và Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.BorderRadius = 5;
            this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhau.DefaultText = "";
            this.txtmatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmatkhau.Location = new System.Drawing.Point(450, 20);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '\0';
            this.txtmatkhau.PlaceholderText = "";
            this.txtmatkhau.SelectedText = "";
            this.txtmatkhau.Size = new System.Drawing.Size(330, 30);
            this.txtmatkhau.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.BorderRadius = 5;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.Location = new System.Drawing.Point(100, 165);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(250, 30);
            this.txtemail.TabIndex = 2;
            // 
            // txthovaten
            // 
            this.txthovaten.BorderRadius = 5;
            this.txthovaten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthovaten.DefaultText = "";
            this.txthovaten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthovaten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthovaten.Location = new System.Drawing.Point(100, 95);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.PasswordChar = '\0';
            this.txthovaten.PlaceholderText = "";
            this.txthovaten.SelectedText = "";
            this.txthovaten.Size = new System.Drawing.Size(250, 30);
            this.txthovaten.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.BorderRadius = 5;
            this.txtmanv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanv.DefaultText = "";
            this.txtmanv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtmanv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmanv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmanv.Location = new System.Drawing.Point(100, 30);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.PasswordChar = '\0';
            this.txtmanv.PlaceholderText = "";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.SelectedText = "";
            this.txtmanv.Size = new System.Drawing.Size(250, 30);
            this.txtmanv.TabIndex = 0;
            // 
            // grpchucnang
            // 
            this.grpchucnang.BackColor = System.Drawing.Color.Transparent;
            this.grpchucnang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.grpchucnang.BorderRadius = 8;
            this.grpchucnang.Controls.Add(this.btnlamoi);
            this.grpchucnang.Controls.Add(this.btnthoat);
            this.grpchucnang.Controls.Add(this.btnsua);
            this.grpchucnang.Controls.Add(this.btnxoa);
            this.grpchucnang.Controls.Add(this.btnthem);
            this.grpchucnang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpchucnang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpchucnang.Location = new System.Drawing.Point(830, 412);
            this.grpchucnang.Name = "grpchucnang";
            this.grpchucnang.ShadowDecoration.Enabled = true;
            this.grpchucnang.Size = new System.Drawing.Size(320, 258);
            this.grpchucnang.TabIndex = 2;
            this.grpchucnang.Text = "CHỨC NĂNG";
            // 
            // btnlamoi
            // 
            this.btnlamoi.BorderRadius = 8;
            this.btnlamoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnlamoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlamoi.ForeColor = System.Drawing.Color.White;
            this.btnlamoi.Location = new System.Drawing.Point(31, 201);
            this.btnlamoi.Name = "btnlamoi";
            this.btnlamoi.Size = new System.Drawing.Size(263, 36);
            this.btnlamoi.TabIndex = 19;
            this.btnlamoi.Text = "Làm Mới";
            this.btnlamoi.Click += new System.EventHandler(this.btnlamoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BorderRadius = 8;
            this.btnthoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(31, 117);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(263, 36);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.BorderRadius = 8;
            this.btnsua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(31, 159);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(263, 36);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BorderRadius = 8;
            this.btnxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(79)))));
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(31, 72);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(263, 36);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 8;
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(31, 30);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(263, 36);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(799, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 30);
            this.txtTimKiem.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BorderRadius = 8;
            this.btnTimKiem.FillColor = System.Drawing.Color.Navy;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1055, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 36);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1170, 690);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.grpchucnang);
            this.Controls.Add(this.grpthongtin);
            this.Controls.Add(this.dataNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1186, 729);
            this.Name = "frmNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.grpthongtin.ResumeLayout(false);
            this.grpthongtin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpchucnang.ResumeLayout(false);
            this.ResumeLayout(false);

        } // Added missing closing brace here

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataNhanVien;
        private Guna.UI2.WinForms.Guna2GroupBox grpthongtin;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtmatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txthovaten;
        private Guna.UI2.WinForms.Guna2TextBox txtmanv;
        private Guna.UI2.WinForms.Guna2GroupBox grpchucnang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button btnthoat;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2Button btnlamoi;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2RadioButton rbdquanly;
        private Guna.UI2.WinForms.Guna2RadioButton rbdnv;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private Guna.UI2.WinForms.Guna2RadioButton rbdstop;
        private Guna.UI2.WinForms.Guna2RadioButton rbdhoatdong;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnTimKiem;
    }
}