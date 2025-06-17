using System;
using System.Windows.Forms;
using UTIL_OLYCAFE;

namespace GUI_POLYCAFE
{
    public partial class MainFrom : Form
    {
        private int vaiTro;
        private Form currentFormChild;

        public MainFrom(int vaiTro)
        {
            InitializeComponent();
            this.vaiTro = vaiTro; // Nhận vaiTro từ form login
            ApplyRoleBasedPermissions();
        }

        private void ApplyRoleBasedPermissions()
        {
            if (vaiTro == 0) // Nhân viên (false)
            {
                manageProductMenuItem.Enabled = false;
                manageProductTypeMenuItem.Enabled = false;
                productRevenueReportMenuItem.Enabled = false;
                staffRevenueReportMenuItem.Enabled = false;
                manageStaffMenuItem.Enabled = false;
                manageMobileCardMenuItem.Enabled = false;
                manageDeviceMenuItem.Enabled = false;
                // Phiếu bán hàng: Nhân viên chỉ xem
                manageSalesReceiptMenuItem.Enabled = true;
                manageSalesDetailMenuItem.Enabled = true;
            }
            else // Quản lý (true)
            {
                // Quản lý có toàn quyền
                manageProductMenuItem.Enabled = true;
                manageProductTypeMenuItem.Enabled = true;
                productRevenueReportMenuItem.Enabled = true;
                staffRevenueReportMenuItem.Enabled = true;
                manageStaffMenuItem.Enabled = true;
                manageMobileCardMenuItem.Enabled = true;
                manageDeviceMenuItem.Enabled = true;
                manageSalesReceiptMenuItem.Enabled = true;
                manageSalesDetailMenuItem.Enabled = true;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(childForm);
            pnlmain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            // Áp dụng quyền khi form tải (đã xử lý trong constructor)
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMK());
        }

        private void manageStaffMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm nếu cần
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void manageMobileCardMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmtheluudong());
        }

        private void manageSalesReceiptMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmphieubanhang());
        }

        private void manageProductMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmquanlysanpham());
        }

        private void salesReceiptMenuItem_Click(object sender, EventArgs e)
        {
            // Có thể không cần xử lý riêng nếu đã có sub-menu
        }

        private void manageSalesDetailMenuItem_Click(object sender, EventArgs e)
        {
            // Xử lý form chi tiết phiếu bán hàng
        }

        private void productRevenueReportMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuLoaiSP());
        }

        private void staffRevenueReportMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuNhanVien());
        }

        private void logoutMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AuthUtil.Logout();
                this.Hide();
                Form loginForm = new frmLogin();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void manageProductTypeMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmquanlyloaisanpham());
        }

        private void manageDeviceMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyThietBi());
        }

        private void accountInfoMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmthongtintaikhoan());
        }
    }
}