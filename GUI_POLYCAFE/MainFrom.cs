using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_POLYCAFE
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
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
    }
}
