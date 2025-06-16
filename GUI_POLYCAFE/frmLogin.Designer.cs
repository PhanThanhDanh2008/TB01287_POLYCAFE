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
            this.lblusername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblpassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ckbhienthimatkhau = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblusername.Location = new System.Drawing.Point(56, 150);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(80, 23);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblpassword.Location = new System.Drawing.Point(56, 225);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(75, 23);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.BorderRadius = 10;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.Location = new System.Drawing.Point(158, 145);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtusername.PlaceholderText = "Nhập tên đăng nhập";
            this.txtusername.SelectedText = "";
            this.txtusername.Size = new System.Drawing.Size(310, 35);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 10;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.Location = new System.Drawing.Point(158, 220);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtpassword.PlaceholderText = "Nhập mật khẩu";
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(310, 35);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // ckbhienthimatkhau
            // 
            this.ckbhienthimatkhau.AutoSize = true;
            this.ckbhienthimatkhau.BackColor = System.Drawing.Color.Transparent;
            this.ckbhienthimatkhau.CheckedState.BorderRadius = 0;
            this.ckbhienthimatkhau.CheckedState.BorderThickness = 0;
            this.ckbhienthimatkhau.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbhienthimatkhau.CheckMarkColor = System.Drawing.Color.Gainsboro;
            this.ckbhienthimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ckbhienthimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckbhienthimatkhau.Location = new System.Drawing.Point(155, 300);
            this.ckbhienthimatkhau.Name = "ckbhienthimatkhau";
            this.ckbhienthimatkhau.Size = new System.Drawing.Size(128, 19);
            this.ckbhienthimatkhau.TabIndex = 6;
            this.ckbhienthimatkhau.Text = "Hiển thị mật khẩu";
            this.ckbhienthimatkhau.UncheckedState.BorderRadius = 0;
            this.ckbhienthimatkhau.UncheckedState.BorderThickness = 0;
            this.ckbhienthimatkhau.UseVisualStyleBackColor = false;
            this.ckbhienthimatkhau.CheckedChanged += new System.EventHandler(this.ckbhienthimatkhau_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 10;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(153)))));
            this.btnlogin.Location = new System.Drawing.Point(155, 350);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(120, 40);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BorderRadius = 10;
            this.btnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnexit.Location = new System.Drawing.Point(348, 350);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(120, 40);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "EXIT";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = global::GUI_POLYCAFE.Properties.Resources.Brown_and_Beige_Illustrated_Coffee_Shop_Presentation__1_;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.btnexit);
            this.mainPanel.Controls.Add(this.btnlogin);
            this.mainPanel.Controls.Add(this.ckbhienthimatkhau);
            this.mainPanel.Controls.Add(this.lblpassword);
            this.mainPanel.Controls.Add(this.lblusername);
            this.mainPanel.Controls.Add(this.txtpassword);
            this.mainPanel.Controls.Add(this.txtusername);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.Transparent;
            this.mainPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Enabled = true;
            this.mainPanel.Size = new System.Drawing.Size(720, 499);
            this.mainPanel.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 499);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(736, 538);
            this.MinimumSize = new System.Drawing.Size(736, 538);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblusername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2CheckBox ckbhienthimatkhau;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private Guna.UI2.WinForms.Guna2GradientPanel mainPanel;
    }
}

