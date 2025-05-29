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
    public partial class frmquanlysanpham : Form
    {
        public frmquanlysanpham()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            btnthem.Enabled = true;
            btnsua.Enabled = false;
            btnxoa.Enabled = true;
            txtmasp.Clear();
            txttensanpham.Clear();
            txtdongia.Clear();
            rdbdangban.Checked = true;
            pbHinhAnh.Image = null;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmquanlysanpham_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();

        }
        private void LoadLoaiSanPham()
        {
            try
            {
                BLLLOAISANPHAM bUSLoaiSanPham = new BLLLOAISANPHAM();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();
                cbloaisp.DataSource = dsLoai;
                cbloaisp.ValueMember = "MaLoai";
                cbloaisp.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDanhSachSanPham()
        {
            BLLsanpham bUSSanPham = new BLLsanpham();
            dgvsanpham.DataSource = null;
            List<SanPham> lstSP = bUSSanPham.GetSanPhamList();
            dgvsanpham.DataSource = lstSP;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txttensanpham.Text.Trim();
                string donGiaText = txtdongia.Text.Trim();
                string maLoai = cbloaisp.SelectedValue?.ToString();
                bool trangThai = rdbdangban.Checked;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = ""
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BLLsanpham bUSSanPham = new BLLsanpham();
                bUSSanPham.InsertSanPham(sp);

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới form sau khi thêm
                ClearForm();
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsanpham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvsanpham.Rows[e.RowIndex];
            txtmasp.Text = row.Cells["MaSanPham"].Value.ToString();
            txttensanpham.Text = row.Cells["TenSanPham"].Value.ToString();
            txtdongia.Text = row.Cells["DonGia"].Value.ToString();
            cbloaisp.SelectedValue = row.Cells["MaLoai"].Value.ToString();
            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai)
            {
                rdbdangban.Checked = true;
            }
            else
            {
                rdbngungban.Checked = true;
            }
            // Bật nút "Sửa"
            btnthem.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maSP = txtmasp.Text.Trim();
            string tenSP = string.Empty;
            string hinhAnh = string.Empty;

            if (string.IsNullOrEmpty(maSP))
            {
                if (dgvsanpham.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvsanpham.SelectedRows[0];
                    maSP = selectedRow.Cells["MaSanPham"].Value.ToString();
                    tenSP = selectedRow.Cells["TenSanPham"].Value.ToString();
                    hinhAnh = selectedRow.Cells["HinhAnh"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tenSP = txttensanpham.Text.Trim();
            }

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Xóa không thành công.");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {maSP} - {tenSP}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                BLLsanpham bus = new BLLsanpham();
                string kq = bus.DeleteSanPham(maSP);

                if (string.IsNullOrEmpty(kq))
                {

                    MessageBox.Show($"Xóa thông tin sản phẩm {maSP} - {tenSP} thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(kq, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSP = txttensanpham.Text.Trim();
                string donGiaText = txtdongia.Text.Trim();
                string maLoai = cbloaisp.SelectedValue?.ToString();
                bool trangThai = rdbdangban.Checked;
                string maSP = txtmasp.Text.Trim();

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển đổi đơn giá
                if (!decimal.TryParse(donGiaText, out decimal donGia))
                {
                    MessageBox.Show("Đơn giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BLLsanpham bUSSanPham = new BLLsanpham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadLoaiSanPham();
            LoadDanhSachSanPham();
        }

        private void frmquanlysanpham_Resize(object sender, EventArgs e)
        {
            //label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            //label1.Top = 10;
        }
    }
}
