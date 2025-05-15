using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_POLYCAFE;
using DTO_POLYCAFE;
using UTIL_OLYCAFE;

namespace GUI_POLYCAFE
{
    public partial class frmLogin : Form
    {
        BLLNHANVIEN bllnhanvien = new BLLNHANVIEN();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Ẩn mật khẩu mặc định
            txtpassword.UseSystemPasswordChar = true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            NHANVIEN nv = bllnhanvien.DangNhap(username, password);

            if (nv == null)
            {
                MessageBox.Show(this, "Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (nv.TrangThai == false)
                {
                    MessageBox.Show(this, "Tài khoản đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AuthUtil.user = nv;
                MainFrom main = new MainFrom();
                main.Show();
                this.Hide();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void ckbhienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị hoặc ẩn mật khẩu tùy vào checkbox
            txtpassword.UseSystemPasswordChar = !ckbhienthimatkhau.Checked;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            // Có thể xử lý thêm nếu cần, hiện đang không làm gì cả
        }
    }
}
