using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace GUI_POLYCAFE
{
    partial class frmDoiMK
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
            this.grpnhapthongtintaikhoan = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txttennhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmanhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbltennhanvien = new System.Windows.Forms.Label();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.grpMK = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ckfrmhienthimatkhau = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtxacnhanmatkhaumoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmatkhaumoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmatkhaucu = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblXacNhanMK = new System.Windows.Forms.Label();
            this.lblMKmoi = new System.Windows.Forms.Label();
            this.lblMKcu = new System.Windows.Forms.Label();
            this.grpfrmDoiMKcongcu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnthoat = new Guna.UI2.WinForms.Guna2Button();
            this.btndoimatkhau = new Guna.UI2.WinForms.Guna2Button();
            this.lblformdoimatkhau = new System.Windows.Forms.Label();
            this.grpnhapthongtintaikhoan.SuspendLayout();
            this.grpMK.SuspendLayout();
            this.grpfrmDoiMKcongcu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpnhapthongtintaikhoan
            // 
            this.grpnhapthongtintaikhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.grpnhapthongtintaikhoan.BorderRadius = 10;
            this.grpnhapthongtintaikhoan.Controls.Add(this.txttennhanvien);
            this.grpnhapthongtintaikhoan.Controls.Add(this.txtmanhanvien);
            this.grpnhapthongtintaikhoan.Controls.Add(this.lbltennhanvien);
            this.grpnhapthongtintaikhoan.Controls.Add(this.lblmanhanvien);
            this.grpnhapthongtintaikhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpnhapthongtintaikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpnhapthongtintaikhoan.Location = new System.Drawing.Point(30, 100);
            this.grpnhapthongtintaikhoan.Name = "grpnhapthongtintaikhoan";
            this.grpnhapthongtintaikhoan.ShadowDecoration.Enabled = true;
            this.grpnhapthongtintaikhoan.Size = new System.Drawing.Size(600, 150);
            this.grpnhapthongtintaikhoan.TabIndex = 2;
            this.grpnhapthongtintaikhoan.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.BorderRadius = 5;
            this.txttennhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhanvien.DefaultText = "";
            this.txttennhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txttennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txttennhanvien.Location = new System.Drawing.Point(180, 90);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.PasswordChar = '\0';
            this.txttennhanvien.PlaceholderText = "";
            this.txttennhanvien.ReadOnly = true;
            this.txttennhanvien.SelectedText = "";
            this.txttennhanvien.Size = new System.Drawing.Size(400, 35);
            this.txttennhanvien.TabIndex = 3;
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.BorderRadius = 5;
            this.txtmanhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmanhanvien.DefaultText = "";
            this.txtmanhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtmanhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmanhanvien.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmanhanvien.Location = new System.Drawing.Point(180, 30);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.PasswordChar = '\0';
            this.txtmanhanvien.PlaceholderText = "";
            this.txtmanhanvien.ReadOnly = true;
            this.txtmanhanvien.SelectedText = "";
            this.txtmanhanvien.Size = new System.Drawing.Size(400, 35);
            this.txtmanhanvien.TabIndex = 2;
            // 
            // lbltennhanvien
            // 
            this.lbltennhanvien.AutoSize = true;
            this.lbltennhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbltennhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lbltennhanvien.Location = new System.Drawing.Point(10, 95);
            this.lbltennhanvien.Name = "lbltennhanvien";
            this.lbltennhanvien.Size = new System.Drawing.Size(150, 21);
            this.lbltennhanvien.TabIndex = 5;
            this.lbltennhanvien.Text = "TÊN NHÂN VIÊN";
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblmanhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblmanhanvien.Location = new System.Drawing.Point(10, 35);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(140, 21);
            this.lblmanhanvien.TabIndex = 4;
            this.lblmanhanvien.Text = "MÃ NHÂN VIÊN";
            // 
            // grpMK
            // 
            this.grpMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.grpMK.BorderRadius = 10;
            this.grpMK.Controls.Add(this.ckfrmhienthimatkhau);
            this.grpMK.Controls.Add(this.txtxacnhanmatkhaumoi);
            this.grpMK.Controls.Add(this.txtmatkhaumoi);
            this.grpMK.Controls.Add(this.txtmatkhaucu);
            this.grpMK.Controls.Add(this.lblXacNhanMK);
            this.grpMK.Controls.Add(this.lblMKmoi);
            this.grpMK.Controls.Add(this.lblMKcu);
            this.grpMK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpMK.Location = new System.Drawing.Point(30, 270);
            this.grpMK.Name = "grpMK";
            this.grpMK.ShadowDecoration.Enabled = true;
            this.grpMK.Size = new System.Drawing.Size(600, 300);
            this.grpMK.TabIndex = 6;
            this.grpMK.Text = "THÔNG TIN MẬT KHẨU";
            // 
            // ckfrmhienthimatkhau
            // 
            this.ckfrmhienthimatkhau.AutoSize = true;
            this.ckfrmhienthimatkhau.CheckedState.BorderThickness = 0;
            this.ckfrmhienthimatkhau.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckfrmhienthimatkhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ckfrmhienthimatkhau.Location = new System.Drawing.Point(180, 250);
            this.ckfrmhienthimatkhau.Name = "ckfrmhienthimatkhau";
            this.ckfrmhienthimatkhau.Size = new System.Drawing.Size(150, 23);
            this.ckfrmhienthimatkhau.TabIndex = 8;
            this.ckfrmhienthimatkhau.Text = "Hiện thị mật khẩu";
            this.ckfrmhienthimatkhau.UncheckedState.BorderThickness = 0;
            this.ckfrmhienthimatkhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtxacnhanmatkhaumoi
            // 
            this.txtxacnhanmatkhaumoi.BorderRadius = 5;
            this.txtxacnhanmatkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtxacnhanmatkhaumoi.DefaultText = "";
            this.txtxacnhanmatkhaumoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtxacnhanmatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtxacnhanmatkhaumoi.Location = new System.Drawing.Point(180, 190);
            this.txtxacnhanmatkhaumoi.Name = "txtxacnhanmatkhaumoi";
            this.txtxacnhanmatkhaumoi.PasswordChar = '\0';
            this.txtxacnhanmatkhaumoi.PlaceholderText = "Nhập lại mật khẩu mới";
            this.txtxacnhanmatkhaumoi.SelectedText = "";
            this.txtxacnhanmatkhaumoi.Size = new System.Drawing.Size(400, 35);
            this.txtxacnhanmatkhaumoi.TabIndex = 6;
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.BorderRadius = 5;
            this.txtmatkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhaumoi.DefaultText = "";
            this.txtmatkhaumoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmatkhaumoi.Location = new System.Drawing.Point(180, 120);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '\0';
            this.txtmatkhaumoi.PlaceholderText = "Nhập mật khẩu mới";
            this.txtmatkhaumoi.SelectedText = "";
            this.txtmatkhaumoi.Size = new System.Drawing.Size(400, 35);
            this.txtmatkhaumoi.TabIndex = 3;
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.BorderRadius = 5;
            this.txtmatkhaucu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhaucu.DefaultText = "";
            this.txtmatkhaucu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhaucu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtmatkhaucu.Location = new System.Drawing.Point(180, 50);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.PasswordChar = '\0';
            this.txtmatkhaucu.PlaceholderText = "Nhập mật khẩu cũ";
            this.txtmatkhaucu.SelectedText = "";
            this.txtmatkhaucu.Size = new System.Drawing.Size(400, 35);
            this.txtmatkhaucu.TabIndex = 2;
            // 
            // lblXacNhanMK
            // 
            this.lblXacNhanMK.AutoSize = true;
            this.lblXacNhanMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblXacNhanMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblXacNhanMK.Location = new System.Drawing.Point(10, 195);
            this.lblXacNhanMK.Name = "lblXacNhanMK";
            this.lblXacNhanMK.Size = new System.Drawing.Size(170, 21);
            this.lblXacNhanMK.TabIndex = 7;
            this.lblXacNhanMK.Text = "XÁC NHẬN MẬT KHẨU";
            // 
            // lblMKmoi
            // 
            this.lblMKmoi.AutoSize = true;
            this.lblMKmoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMKmoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMKmoi.Location = new System.Drawing.Point(10, 125);
            this.lblMKmoi.Name = "lblMKmoi";
            this.lblMKmoi.Size = new System.Drawing.Size(130, 21);
            this.lblMKmoi.TabIndex = 5;
            this.lblMKmoi.Text = "MẬT KHẨU MỚI";
            // 
            // lblMKcu
            // 
            this.lblMKcu.AutoSize = true;
            this.lblMKcu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMKcu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblMKcu.Location = new System.Drawing.Point(10, 55);
            this.lblMKcu.Name = "lblMKcu";
            this.lblMKcu.Size = new System.Drawing.Size(120, 21);
            this.lblMKcu.TabIndex = 4;
            this.lblMKcu.Text = "MẬT KHẨU CŨ";
            // 
            // grpfrmDoiMKcongcu
            // 
            this.grpfrmDoiMKcongcu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.grpfrmDoiMKcongcu.BorderRadius = 10;
            this.grpfrmDoiMKcongcu.Controls.Add(this.btnthoat);
            this.grpfrmDoiMKcongcu.Controls.Add(this.btndoimatkhau);
            this.grpfrmDoiMKcongcu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpfrmDoiMKcongcu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpfrmDoiMKcongcu.Location = new System.Drawing.Point(650, 270);
            this.grpfrmDoiMKcongcu.Name = "grpfrmDoiMKcongcu";
            this.grpfrmDoiMKcongcu.ShadowDecoration.Enabled = true;
            this.grpfrmDoiMKcongcu.Size = new System.Drawing.Size(500, 300);
            this.grpfrmDoiMKcongcu.TabIndex = 6;
            this.grpfrmDoiMKcongcu.Text = "CÔNG CỤ";
            // 
            // btnthoat
            // 
            this.btnthoat.BorderRadius = 8;
            this.btnthoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnthoat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnthoat.ForeColor = System.Drawing.Color.White;
            this.btnthoat.Location = new System.Drawing.Point(100, 180);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(300, 50);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndoimatkhau
            // 
            this.btndoimatkhau.BorderRadius = 8;
            this.btndoimatkhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btndoimatkhau.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btndoimatkhau.ForeColor = System.Drawing.Color.White;
            this.btndoimatkhau.Location = new System.Drawing.Point(100, 100);
            this.btndoimatkhau.Name = "btndoimatkhau";
            this.btndoimatkhau.Size = new System.Drawing.Size(300, 50);
            this.btndoimatkhau.TabIndex = 0;
            this.btndoimatkhau.Text = "Đổi Mật Khẩu";
            this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
            // 
            // lblformdoimatkhau
            // 
            this.lblformdoimatkhau.AutoSize = true;
            this.lblformdoimatkhau.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblformdoimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lblformdoimatkhau.Location = new System.Drawing.Point(400, 30);
            this.lblformdoimatkhau.Name = "lblformdoimatkhau";
            this.lblformdoimatkhau.Size = new System.Drawing.Size(250, 45);
            this.lblformdoimatkhau.TabIndex = 7;
            this.lblformdoimatkhau.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 700);
            this.Controls.Add(this.lblformdoimatkhau);
            this.Controls.Add(this.grpfrmDoiMKcongcu);
            this.Controls.Add(this.grpMK);
            this.Controls.Add(this.grpnhapthongtintaikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDoiMK";
            this.Text = "Đổi Mật Khẩu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoiMK_FormClosing);
            this.Load += new System.EventHandler(this.frmDoiMK_Load);
            this.grpnhapthongtintaikhoan.ResumeLayout(false);
            this.grpnhapthongtintaikhoan.PerformLayout();
            this.grpMK.ResumeLayout(false);
            this.grpMK.PerformLayout();
            this.grpfrmDoiMKcongcu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpnhapthongtintaikhoan;
        private Guna.UI2.WinForms.Guna2TextBox txttennhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txtmanhanvien;
        private System.Windows.Forms.Label lbltennhanvien;
        private System.Windows.Forms.Label lblmanhanvien;
        private Guna.UI2.WinForms.Guna2GroupBox grpMK;
        private Guna.UI2.WinForms.Guna2CheckBox ckfrmhienthimatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtxacnhanmatkhaumoi;
        private Guna.UI2.WinForms.Guna2TextBox txtmatkhaumoi;
        private Guna.UI2.WinForms.Guna2TextBox txtmatkhaucu;
        private System.Windows.Forms.Label lblXacNhanMK;
        private System.Windows.Forms.Label lblMKmoi;
        private System.Windows.Forms.Label lblMKcu;
        private Guna.UI2.WinForms.Guna2GroupBox grpfrmDoiMKcongcu;
        private Guna.UI2.WinForms.Guna2Button btnthoat;
        private Guna.UI2.WinForms.Guna2Button btndoimatkhau;
        private System.Windows.Forms.Label lblformdoimatkhau;
    }
}