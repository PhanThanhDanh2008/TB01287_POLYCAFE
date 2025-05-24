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

namespace GUI_POLYCAFE
{
    public partial class frmtheluudong : Form
    {
        public frmtheluudong()
        {
            InitializeComponent();

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void frmtheluudong_Load(object sender, EventArgs e)
        {
            clearForm();
            LoadDanhSachThe();
        }
        private void LoadDanhSachThe()
        {
        BLLTHELUUDONG bLLTHELUUDONG = new BLLTHELUUDONG();
         dgrDanhSachThe.DataSource = null;
         dgrDanhSachThe.DataSource = bLLTHELUUDONG.GetTheLuuDongList();

        }
        private void clearForm()
        {
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            txtmathe.Clear();
            txtchusohuu.Clear();
            chkAction.Checked = false;

         }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgrDanhSachThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // load dữu lên các control
                
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maThe = txtmathe.Text.Trim();
            string chuSoHuu = txtchusohuu.Text.Trim();

            bool trangThai;

            if (chkAction.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BLLTHELUUDONG bus = new BLLTHELUUDONG();
            string result = bus.InsertTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                clearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maThe = txtmathe.Text.Trim();
            string chuSoHuu = txtchusohuu.Text.Trim();

            bool trangThai;

            if (chkAction.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(chuSoHuu))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }
            TheLuuDong theLuuDong = new TheLuuDong
            {
                MaThe = maThe,
                ChuSoHuu = chuSoHuu,
                TrangThai = trangThai
            };
            BLLTHELUUDONG bus = new BLLTHELUUDONG();
            string result = bus.UpdateTheLuuDong(theLuuDong);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                clearForm();
                LoadDanhSachThe();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maThe = txtmathe.Text.Trim();
            string chuSoHuu = txtchusohuu.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                if (dgrDanhSachThe.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgrDanhSachThe.SelectedRows[0];
                    maThe = selectedRow.Cells["MaThe"].Value.ToString();
                    chuSoHuu = selectedRow.Cells["ChuSoHuu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một thẻ lưu động để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thẻ lưu động {maThe} - {chuSoHuu}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLTHELUUDONG bus = new BLLTHELUUDONG();
                string kq = bus.DeleteTheLuuDong(maThe);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin thẻ lưu động {maThe} - {chuSoHuu} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForm();
                    LoadDanhSachThe();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgrDanhSachThe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgrDanhSachThe.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtmathe.Text = row.Cells["MaThe"].Value.ToString();
            txtchusohuu.Text = row.Cells["ChuSoHuu"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            chkAction.Checked = trangThai;

            // Bật nút "Sửa"
            btnthem.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            // Tắt chỉnh sửa mã thẻ
            txtmathe.Enabled = false;
        }
    }
}
