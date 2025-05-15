namespace GUI_POLYCAFE
{
    partial class frmLogin
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
            this.lbldangnhap = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.ckbrememberme = new System.Windows.Forms.CheckBox();
            this.ckbhienthimatkhau = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.llblquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbldangnhap
            // 
            this.lbldangnhap.AutoSize = true;
            this.lbldangnhap.BackColor = System.Drawing.Color.Transparent;
            this.lbldangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbldangnhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldangnhap.Location = new System.Drawing.Point(197, 33);
            this.lbldangnhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldangnhap.Name = "lbldangnhap";
            this.lbldangnhap.Size = new System.Drawing.Size(0, 63);
            this.lbldangnhap.TabIndex = 0;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtusername.Location = new System.Drawing.Point(158, 145);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(310, 27);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtpassword.Location = new System.Drawing.Point(158, 219);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(310, 27);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblusername.Location = new System.Drawing.Point(56, 145);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(102, 25);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpassword.Location = new System.Drawing.Point(56, 219);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(98, 25);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // ckbrememberme
            // 
            this.ckbrememberme.AutoSize = true;
            this.ckbrememberme.BackColor = System.Drawing.Color.Transparent;
            this.ckbrememberme.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbrememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbrememberme.Location = new System.Drawing.Point(155, 277);
            this.ckbrememberme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbrememberme.Name = "ckbrememberme";
            this.ckbrememberme.Size = new System.Drawing.Size(111, 18);
            this.ckbrememberme.TabIndex = 5;
            this.ckbrememberme.Text = "Remember me";
            this.ckbrememberme.UseVisualStyleBackColor = false;
            // 
            // ckbhienthimatkhau
            // 
            this.ckbhienthimatkhau.AutoSize = true;
            this.ckbhienthimatkhau.BackColor = System.Drawing.Color.Transparent;
            this.ckbhienthimatkhau.Font = new System.Drawing.Font("Lucida Sans", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbhienthimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbhienthimatkhau.Location = new System.Drawing.Point(155, 250);
            this.ckbhienthimatkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbhienthimatkhau.Name = "ckbhienthimatkhau";
            this.ckbhienthimatkhau.Size = new System.Drawing.Size(136, 18);
            this.ckbhienthimatkhau.TabIndex = 6;
            this.ckbhienthimatkhau.Text = "hiện thị mật khẩu";
            this.ckbhienthimatkhau.UseVisualStyleBackColor = false;
            this.ckbhienthimatkhau.CheckedChanged += new System.EventHandler(this.ckbhienthimatkhau_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(207, 328);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(56, 19);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(403, 328);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(56, 19);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // llblquenmatkhau
            // 
            this.llblquenmatkhau.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.llblquenmatkhau.AutoSize = true;
            this.llblquenmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.llblquenmatkhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.llblquenmatkhau.Location = new System.Drawing.Point(397, 253);
            this.llblquenmatkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblquenmatkhau.Name = "llblquenmatkhau";
            this.llblquenmatkhau.Size = new System.Drawing.Size(78, 13);
            this.llblquenmatkhau.TabIndex = 9;
            this.llblquenmatkhau.TabStop = true;
            this.llblquenmatkhau.Text = "quên mật khẩu";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::GUI_POLYCAFE.Properties.Resources.Brown_and_Beige_Illustrated_Coffee_Shop_Presentation__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 499);
            this.Controls.Add(this.llblquenmatkhau);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.ckbhienthimatkhau);
            this.Controls.Add(this.ckbrememberme);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lbldangnhap);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(736, 538);
            this.MinimumSize = new System.Drawing.Size(736, 538);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldangnhap;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.CheckBox ckbrememberme;
        private System.Windows.Forms.CheckBox ckbhienthimatkhau;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.LinkLabel llblquenmatkhau;
    }
}

