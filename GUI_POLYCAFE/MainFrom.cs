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

namespace GUI_POLYCAFE
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            // Kiểm tra quyền truy cập của người dùng
            //CheckPermission();
        }





        private void bÁOCÁODOANHTHUSẢNPHẨMToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoatmain_Click(object sender, EventArgs e)
        {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private Form currentFormChild;
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
            //VaiTroNhanVien();
        }
        //private void CheckPermission()
        //{
        //    if (AuthUtil.IsLogin())
        //    {
        //        hỆTHỐNGToolStripMenuItem.Visible = true;
        //        dANHMỤCToolStripMenuItem.Visible = true;
        //        pHIẾUBÁNHÀNGToolStripMenuItem.Visible = true;
        //        mỤCLỤCToolStripMenuItem.Visible = true;
        //        bÁOCÁOToolStripMenuItem.Visible = true;

              
        //        if (AuthUtil.user.VaiTro == false)
        //        {
        //            VaiTroNhanVien();
        //        }
        //    }
        //    else
        //    {
        //        hỆTHỐNGToolStripMenuItem.Visible = true;
        //        đĂNGXUẤTToolStripMenuItem.Visible = false;
        //        dANHMỤCToolStripMenuItem.Visible = false;
        //        pHIẾUBÁNHÀNGToolStripMenuItem.Visible = false;
        //        mỤCLỤCToolStripMenuItem.Visible = false;
        //        bÁOCÁOToolStripMenuItem.Visible = false;
        //    }
        //}

        // Phương thức để áp dụng quyền cho nhân viên
        private void VaiTroNhanVien()
        {
            // Nhân viên chỉ được phép một số menu nhất định
            qUẢNLÝSẢNPHẨMToolStripMenuItem.Enabled = true;
            qUẢNLÝLOẠISẢNPHẨMToolStripMenuItem.Enabled = true;
            qUẢNLÝPHIẾUBÁNHÀNGToolStripMenuItem.Enabled = true;
            qUẢNLÝCHITIẾTPHIẾUBÁNHÀNGToolStripMenuItem.Enabled = true;
            toolStripTXTTIEMKIEM.Enabled = true;

            // Vô hiệu hóa các menu không cho nhân viên truy cập
            bÁOCÁODOANHTHUSẢNPHẨMToolStripMenuItem.Enabled = false;
            bÁOCÁODOANHTHUNHÂNVIÊNToolStripMenuItem.Enabled = false;
            QLNVToolStripMenuItem.Enabled = false;
            qUẢNLÝTHẺLƯUĐỘNGToolStripMenuItem.Enabled = false;
        }


        private void DOIMATKHAUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMK());
        }

        private void QLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhanVien());
        }

        private void toolStripTXTTIEMKIEM_Click(object sender, EventArgs e)
        {
    

        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void qUẢNLÝTHẺLƯUĐỘNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmtheluudong());
        }

        private void qUẢNLÝPHIẾUBÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmphieubanhangt());
        }

        private void qUẢNLÝSẢNPHẨMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmquanlysanpham());
        }

        private void pHIẾUBÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qUẢNLÝCHITIẾTPHIẾUBÁNHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
