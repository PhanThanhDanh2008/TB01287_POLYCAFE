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
    public partial class frmquanlyloaisanpham : Form
    {
        public frmquanlyloaisanpham()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ClearForm()
        {
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = true;
            txtloaimasp.Clear();
            txtghichu.Clear();
            txtloaitensanpham.Clear();
        }
        private void LoadDanhSachLoaiSP()
        {
            BLLLOAISANPHAM busLoaiSp = new BLLLOAISANPHAM();
            dgvloaisanpham.DataSource = null;
            dgvloaisanpham.DataSource = busLoaiSp.GetLoaiSanPhamList();
            dgvloaisanpham.Columns["MaLoai"].HeaderText = "Mã Loại";
            dgvloaisanpham.Columns["TenLoai"].HeaderText = "Tên Loại";
            dgvloaisanpham.Columns["GhiChu"].HeaderText = "Ghi Chú";

            dgvloaisanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmquanlyloaisanpham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string maLoai = txtloaimasp.Text.Trim();
            string tenLoai = txtloaitensanpham.Text.Trim();
            string ghiChu = txtghichu.Text.Trim();


            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin thẻ lưu động.");
                return;
            }

            LoaiSanPham loai = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BLLLOAISANPHAM bus = new BLLLOAISANPHAM();
            string result = bus.InsertLoaiSanPham(loai);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maLoai = txtloaimasp.Text.Trim();
            string tenLoai = txtloaitensanpham.Text.Trim();
            string ghiChu = txtghichu.Text.Trim();
            if (string.IsNullOrEmpty(maLoai))
            {
                if (dgvloaisanpham  .SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvloaisanpham.SelectedRows[0];
                    maLoai = selectedRow.Cells["MaLoai"].Value.ToString();
                    tenLoai = selectedRow.Cells["TenLoai"].Value.ToString();
                    ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thông tin loại sản phẩm cần xóa xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrEmpty(maLoai))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {maLoai} - {tenLoai}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLLOAISANPHAM bus = new BLLLOAISANPHAM();
                string kq = bus.DeleteLoaiSanPham(maLoai);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show($"Xóa thông tin loại sản phẩm {maLoai} - {tenLoai} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSP();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maLoai = txtloaimasp.Text.Trim();
            string tenLoai = txtloaitensanpham.Text.Trim();
            string ghiChu = txtghichu.Text.Trim();
            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin loại sản phẩm.");
                return;
            }
            LoaiSanPham loaiSanPham = new LoaiSanPham
            {
                MaLoai = maLoai,
                TenLoai = tenLoai,
                GhiChu = ghiChu
            };
            BLLLOAISANPHAM   bus = new BLLLOAISANPHAM();
            string result = bus.UpdateLoaiSanPham(loaiSanPham);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadDanhSachLoaiSP();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSP();

        }

        private void dgvloaisanpham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvloaisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validate row index
            if (e.RowIndex < 0 || e.RowIndex >= dgvloaisanpham.Rows.Count)
            {
                return; // Silently ignore invalid clicks (e.g., on headers)
            }

            try
            {
                DataGridViewRow row = dgvloaisanpham.Rows[e.RowIndex];

                // Check if required columns exist and have valid values
                if (row.Cells["MaLoai"]?.Value == null || row.Cells["TenLoai"]?.Value == null || row.Cells["GhiChu"]?.Value == null)
                {
                    MessageBox.Show("Dữ liệu hàng không hợp lệ hoặc thiếu thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Populate form fields with data from the selected row
                txtloaimasp.Text = row.Cells["MaLoai"].Value.ToString();
                txtloaitensanpham.Text = row.Cells["TenLoai"].Value.ToString();
                txtghichu.Text = row.Cells["GhiChu"].Value.ToString();

                // Enable/disable buttons
                btnthem.Enabled = false;  // Disable the "Add" button
                btnsua.Enabled = true;    // Enable the "Edit" button
                btnxoa.Enabled = true;    // Enable the "Delete" button
                txtloaimasp.Enabled = false;  // Disable the product type ID field
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToLower();

            try
            {
                BLLLOAISANPHAM busLoaiSp = new BLLLOAISANPHAM();
                List<LoaiSanPham> resultList;

                if (string.IsNullOrEmpty(searchText))
                {
                    // Nếu ô tìm kiếm trống, tải toàn bộ danh sách
                    resultList = busLoaiSp.GetLoaiSanPhamList();
                }
                else
                {
                    // Tìm kiếm theo TenLoai
                    resultList = busLoaiSp.SearchLoaiSanPham(searchText);
                }

                // Cập nhật DataGridView
                dgvloaisanpham.DataSource = null;
                dgvloaisanpham.DataSource = resultList;

                // Áp dụng lại định dạng cột
                if (resultList.Count > 0)
                {
                    dgvloaisanpham.Columns["MaLoai"].HeaderText = "Mã Loại";
                    dgvloaisanpham.Columns["TenLoai"].HeaderText = "Tên Loại";
                    dgvloaisanpham.Columns["GhiChu"].HeaderText = "Ghi Chú";
                    dgvloaisanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                // Hiển thị thông báo nếu không tìm thấy kết quả
                if (resultList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy loại sản phẩm nào khớp với từ khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
