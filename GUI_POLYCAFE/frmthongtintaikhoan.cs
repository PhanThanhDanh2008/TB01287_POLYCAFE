using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_OLYCAFE;
using DTO_POLYCAFE;
using Guna.UI2.WinForms;

namespace GUI_POLYCAFE
{
    public partial class frmthongtintaikhoan : Form
    {
        public frmthongtintaikhoan()
        {
            InitializeComponent();
        }

        private void frmthongtintaikhoan_Load(object sender, EventArgs e)
        {
            // Lấy thông tin người dùng từ AuthUtil
            NHANVIEN user = AuthUtil.user;

            if (user != null)
            {
                // Hiển thị thông tin lên các Guna2TextBox
                guna2TextBoxMaNhanVien.Text = user.MaNhanVien;
                guna2TextBoxHoTen.Text = user.HoTen;
                guna2TextBoxEmail.Text = user.Email;
                guna2TextBoxVaiTro.Text = user.VaiTro ? "Quản lý" : "Nhân viên";
                guna2TextBoxTrangThai.Text = user.TrangThai ? "Hoạt động" : "Khóa";

                // Thêm ảnh avatar (nếu có, hiện tại dùng ảnh mặc định)
                // Nếu bạn có ảnh từ database, thay thế bằng đường dẫn ảnh
                // guna2PictureBoxAvatar.Image = Image.FromFile("đường_dẫn_ảnh");
            }
            else
            {
                MessageBox.Show("Không thể tải thông tin tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void guna2ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}