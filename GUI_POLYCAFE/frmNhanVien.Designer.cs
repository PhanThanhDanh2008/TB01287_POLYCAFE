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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbtinhtrang = new System.Windows.Forms.ComboBox();
            this.cbbvaitro = new System.Windows.Forms.ComboBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.grpchucnang = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            this.grpthongtin.SuspendLayout();
            this.grpchucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNhanVien.Location = new System.Drawing.Point(17, 95);
            this.dataNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.Size = new System.Drawing.Size(1532, 441);
            this.dataNhanVien.TabIndex = 0;
            // 
            // grpthongtin
            // 
            this.grpthongtin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpthongtin.Controls.Add(this.label7);
            this.grpthongtin.Controls.Add(this.label6);
            this.grpthongtin.Controls.Add(this.label5);
            this.grpthongtin.Controls.Add(this.label4);
            this.grpthongtin.Controls.Add(this.label3);
            this.grpthongtin.Controls.Add(this.label2);
            this.grpthongtin.Controls.Add(this.label1);
            this.grpthongtin.Controls.Add(this.cbbtinhtrang);
            this.grpthongtin.Controls.Add(this.cbbvaitro);
            this.grpthongtin.Controls.Add(this.txtmatkhau);
            this.grpthongtin.Controls.Add(this.txtdiachi);
            this.grpthongtin.Controls.Add(this.txtemail);
            this.grpthongtin.Controls.Add(this.txthovaten);
            this.grpthongtin.Controls.Add(this.txtmanv);
            this.grpthongtin.Location = new System.Drawing.Point(17, 544);
            this.grpthongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpthongtin.Name = "grpthongtin";
            this.grpthongtin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpthongtin.Size = new System.Drawing.Size(1183, 279);
            this.grpthongtin.TabIndex = 1;
            this.grpthongtin.TabStop = false;
            this.grpthongtin.Text = "THÔNG TIN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(573, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "TÌNH TRẠNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 108);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "ĐỊA CHỈ";
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
            // cbbtinhtrang
            // 
            this.cbbtinhtrang.FormattingEnabled = true;
            this.cbbtinhtrang.Location = new System.Drawing.Point(699, 172);
            this.cbbtinhtrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbtinhtrang.Name = "cbbtinhtrang";
            this.cbbtinhtrang.Size = new System.Drawing.Size(324, 24);
            this.cbbtinhtrang.TabIndex = 6;
            // 
            // cbbvaitro
            // 
            this.cbbvaitro.FormattingEnabled = true;
            this.cbbvaitro.Location = new System.Drawing.Point(699, 100);
            this.cbbvaitro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbvaitro.Name = "cbbvaitro";
            this.cbbvaitro.Size = new System.Drawing.Size(324, 24);
            this.cbbvaitro.TabIndex = 5;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(699, 23);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(324, 22);
            this.txtmatkhau.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(157, 246);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(324, 22);
            this.txtdiachi.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(157, 174);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(324, 22);
            this.txtemail.TabIndex = 2;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(157, 100);
            this.txthovaten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(324, 22);
            this.txthovaten.TabIndex = 1;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(157, 23);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(324, 22);
            this.txtmanv.TabIndex = 0;
            // 
            // grpchucnang
            // 
            this.grpchucnang.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpchucnang.Controls.Add(this.btnthoat);
            this.grpchucnang.Controls.Add(this.btnsua);
            this.grpchucnang.Controls.Add(this.btnxoa);
            this.grpchucnang.Controls.Add(this.btnthem);
            this.grpchucnang.Location = new System.Drawing.Point(1208, 544);
            this.grpchucnang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpchucnang.Name = "grpchucnang";
            this.grpchucnang.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpchucnang.Size = new System.Drawing.Size(341, 211);
            this.grpchucnang.TabIndex = 2;
            this.grpchucnang.TabStop = false;
            this.grpchucnang.Text = "CHỨC NĂNG";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(58, 32);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 55);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(236, 32);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 55);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(58, 133);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 55);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(236, 133);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 55);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 855);
            this.Controls.Add(this.grpchucnang);
            this.Controls.Add(this.grpthongtin);
            this.Controls.Add(this.dataNhanVien);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1581, 894);
            this.MinimumSize = new System.Drawing.Size(1581, 894);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            this.grpthongtin.ResumeLayout(false);
            this.grpthongtin.PerformLayout();
            this.grpchucnang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataNhanVien;
        private System.Windows.Forms.GroupBox grpthongtin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbtinhtrang;
        private System.Windows.Forms.ComboBox cbbvaitro;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.GroupBox grpchucnang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
    }
}