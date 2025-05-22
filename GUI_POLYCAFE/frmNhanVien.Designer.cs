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
            this.dataNhanVien = new System.Windows.Forms.DataGridView();
            this.grpthongtin = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbdstop = new System.Windows.Forms.RadioButton();
            this.rbdhoatdong = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbdquanly = new System.Windows.Forms.RadioButton();
            this.rbdnv = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.grpchucnang = new System.Windows.Forms.GroupBox();
            this.btnlamoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.grpthongtin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Location = new System.Drawing.Point(17, 95);
            this.dataNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.RowHeadersWidth = 51;
            this.dataNhanVien.Size = new System.Drawing.Size(1532, 441);
            this.dataNhanVien.TabIndex = 0;
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellClick);
            this.dataNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellContentClick);
            this.dataNhanVien.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellEndEdit);
            this.dataNhanVien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataNhanVien_CellFormatting);
            // 
            // grpthongtin
            // 
            this.grpthongtin.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.grpthongtin.Location = new System.Drawing.Point(17, 544);
            this.grpthongtin.Margin = new System.Windows.Forms.Padding(4);
            this.grpthongtin.Name = "grpthongtin";
            this.grpthongtin.Padding = new System.Windows.Forms.Padding(4);
            this.grpthongtin.Size = new System.Drawing.Size(1183, 279);
            this.grpthongtin.TabIndex = 1;
            this.grpthongtin.TabStop = false;
            this.grpthongtin.Text = "THÔNG TIN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbdstop);
            this.panel2.Controls.Add(this.rbdhoatdong);
            this.panel2.Location = new System.Drawing.Point(696, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 100);
            this.panel2.TabIndex = 19;
            // 
            // rbdstop
            // 
            this.rbdstop.AutoSize = true;
            this.rbdstop.Location = new System.Drawing.Point(188, 37);
            this.rbdstop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbdstop.Name = "rbdstop";
            this.rbdstop.Size = new System.Drawing.Size(90, 20);
            this.rbdstop.TabIndex = 17;
            this.rbdstop.TabStop = true;
            this.rbdstop.Text = "tạm ngưng";
            this.rbdstop.UseVisualStyleBackColor = true;
            // 
            // rbdhoatdong
            // 
            this.rbdhoatdong.AutoSize = true;
            this.rbdhoatdong.Location = new System.Drawing.Point(28, 34);
            this.rbdhoatdong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbdhoatdong.Name = "rbdhoatdong";
            this.rbdhoatdong.Size = new System.Drawing.Size(91, 20);
            this.rbdhoatdong.TabIndex = 16;
            this.rbdhoatdong.TabStop = true;
            this.rbdhoatdong.Text = "Hoạt động";
            this.rbdhoatdong.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbdquanly);
            this.panel1.Controls.Add(this.rbdnv);
            this.panel1.Location = new System.Drawing.Point(696, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 100);
            this.panel1.TabIndex = 18;
            // 
            // rbdquanly
            // 
            this.rbdquanly.AutoSize = true;
            this.rbdquanly.Location = new System.Drawing.Point(188, 37);
            this.rbdquanly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbdquanly.Name = "rbdquanly";
            this.rbdquanly.Size = new System.Drawing.Size(71, 20);
            this.rbdquanly.TabIndex = 17;
            this.rbdquanly.TabStop = true;
            this.rbdquanly.Text = "quản lý";
            this.rbdquanly.UseVisualStyleBackColor = true;
            // 
            // rbdnv
            // 
            this.rbdnv.AutoSize = true;
            this.rbdnv.Location = new System.Drawing.Point(28, 34);
            this.rbdnv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbdnv.Name = "rbdnv";
            this.rbdnv.Size = new System.Drawing.Size(85, 20);
            this.rbdnv.TabIndex = 16;
            this.rbdnv.TabStop = true;
            this.rbdnv.Text = "nhân viên";
            this.rbdnv.UseVisualStyleBackColor = true;
            this.rbdnv.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 167);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "TÌNH TRẠNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "VAI TRÒ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "MẬT KHẨU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "EMAIL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "HỌ VÀ TÊN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "MÃ NHÂN VIÊN";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(699, 23);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(324, 22);
            this.txtmatkhau.TabIndex = 4;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(157, 174);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(324, 22);
            this.txtemail.TabIndex = 2;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(157, 100);
            this.txthovaten.Margin = new System.Windows.Forms.Padding(4);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(324, 22);
            this.txthovaten.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(157, 23);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.ReadOnly = true;
            this.txtmanv.Size = new System.Drawing.Size(324, 22);
            this.txtmanv.TabIndex = 0;
            // 
            // grpchucnang
            // 
            this.grpchucnang.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpchucnang.Controls.Add(this.btnlamoi);
            this.grpchucnang.Controls.Add(this.btnthoat);
            this.grpchucnang.Controls.Add(this.btnsua);
            this.grpchucnang.Controls.Add(this.btnxoa);
            this.grpchucnang.Controls.Add(this.btnthem);
            this.grpchucnang.Location = new System.Drawing.Point(1208, 544);
            this.grpchucnang.Margin = new System.Windows.Forms.Padding(4);
            this.grpchucnang.Name = "grpchucnang";
            this.grpchucnang.Padding = new System.Windows.Forms.Padding(4);
            this.grpchucnang.Size = new System.Drawing.Size(341, 210);
            this.grpchucnang.TabIndex = 2;
            this.grpchucnang.TabStop = false;
            this.grpchucnang.Text = "CHỨC NĂNG";
            // 
            // btnlamoi
            // 
            this.btnlamoi.Location = new System.Drawing.Point(139, 33);
            this.btnlamoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlamoi.Name = "btnlamoi";
            this.btnlamoi.Size = new System.Drawing.Size(75, 54);
            this.btnlamoi.TabIndex = 19;
            this.btnlamoi.Text = "làm mới";
            this.btnlamoi.UseVisualStyleBackColor = true;
            this.btnlamoi.Click += new System.EventHandler(this.btnlamoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(197, 100);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 55);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(81, 100);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 55);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(236, 32);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 55);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(43, 32);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 55);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 846);
            this.Controls.Add(this.grpchucnang);
            this.Controls.Add(this.grpthongtin);
            this.Controls.Add(this.dataNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1581, 893);
            this.MinimumSize = new System.Drawing.Size(1581, 893);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
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

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.GroupBox grpthongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.GroupBox grpchucnang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnlamoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbdquanly;
        private System.Windows.Forms.RadioButton rbdnv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbdstop;
        private System.Windows.Forms.RadioButton rbdhoatdong;
    }
}