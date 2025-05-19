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
using UTIL_OLYCAFE;

namespace GUI_POLYCAFE
{
    public partial class frmDoiMK : Form
    {
        BLLNHANVIEN bllnhanvien = new BLLNHANVIEN();
        public frmDoiMK()
        {
            InitializeComponent();
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtmatkhaumoi.UseSystemPasswordChar = !ckfrmhienthimatkhau.Checked;
            txtmatkhaucu.UseSystemPasswordChar = !ckfrmhienthimatkhau.Checked;
            txtxacnhanmatkhaumoi.UseSystemPasswordChar = !ckfrmhienthimatkhau.Checked;
        }



        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            if(AuthUtil.IsLogin())
            {
                txtmanhanvien.Text = AuthUtil.user.MaNhanVien;
                txttennhanvien.Text = AuthUtil.user.HoTen;
            }
            txtmatkhaucu.UseSystemPasswordChar = true;
            txtmatkhaumoi.UseSystemPasswordChar = true;
            txtxacnhanmatkhaumoi.UseSystemPasswordChar = true;

        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            if (!AuthUtil.user.MatKhau.Equals(txtmatkhaucu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
                return;
            }
            else
            {
                AuthUtil.user.MatKhau = txtmatkhaumoi.Text;
                if (bllnhanvien.ResetMatKhau(AuthUtil.user.Email, txtmatkhaumoi.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            //ĐÓNG FORM ĐỔI MẬT KHẨU
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmDoiMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
