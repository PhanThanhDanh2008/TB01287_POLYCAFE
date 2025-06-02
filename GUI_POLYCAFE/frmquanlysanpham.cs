using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private string imagePath = ""; // Biến lưu đường dẫn ảnh

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
            pbHinhAnh.Image?.Dispose();
            pbHinhAnh.Image = null;
            imagePath = ""; // Reset đường dẫn ảnh
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
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            try
            {
                BLLsanpham bUSSanPham = new BLLsanpham();
                dgvsanpham.DataSource = null;
                List<SanPham> lstSP = bUSSanPham.GetSanPhamList();
                dgvsanpham.DataSource = lstSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                    openFileDialog.Title = "Chọn ảnh sản phẩm";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = openFileDialog.FileName;
                        if (File.Exists(selectedPath))
                        {
                            // Kiểm tra xem file có phải là ảnh hợp lệ không
                            try
                            {
                                using (Image img = Image.FromFile(selectedPath))
                                {
                                    imagePath = selectedPath; // Lưu đường dẫn ảnh
                                    pbHinhAnh.Image?.Dispose(); // Giải phóng ảnh cũ nếu có
                                    pbHinhAnh.Image = new Bitmap(img); // Tạo bản sao để tránh khóa file
                                }
                            }
                            catch
                            {
                                MessageBox.Show("File được chọn không phải là ảnh hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("File ảnh không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                // Xử lý ảnh
                string hinhAnh = "";
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string targetFolder = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }
                    string fileName = Path.GetFileName(imagePath);
                    string targetPath = Path.Combine(targetFolder, fileName);
                    if (File.Exists(imagePath))
                    {
                        File.Copy(imagePath, targetPath, true); // Sao chép ảnh
                        hinhAnh = fileName; // Lưu tên file
                    }
                    else
                    {
                        MessageBox.Show("File ảnh không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = hinhAnh
                };

                // Thêm sản phẩm vào cơ sở dữ liệu
                BLLsanpham bUSSanPham = new BLLsanpham();
                string result = bUSSanPham.InsertSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvsanpham.Rows[e.RowIndex];
                    txtmasp.Text = row.Cells["MaSanPham"].Value?.ToString();
                    txttensanpham.Text = row.Cells["TenSanPham"].Value?.ToString();
                    txtdongia.Text = row.Cells["DonGia"].Value?.ToString();
                    cbloaisp.SelectedValue = row.Cells["MaLoai"].Value?.ToString();
                    bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                    rdbdangban.Checked = trangThai;
                    rdbngungban.Checked = !trangThai;

                    // Lưu đường dẫn ảnh hiện tại
                    imagePath = row.Cells["HinhAnh"].Value?.ToString();
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        string fullPath = Path.Combine(Application.StartupPath, "Images", imagePath);
                        if (File.Exists(fullPath))
                        {
                            pbHinhAnh.Image?.Dispose();
                            pbHinhAnh.Image = Image.FromFile(fullPath);
                        }
                        else
                        {
                            pbHinhAnh.Image?.Dispose();
                            pbHinhAnh.Image = null;
                            MessageBox.Show($"Không tìm thấy file ảnh: {fullPath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        pbHinhAnh.Image?.Dispose();
                        pbHinhAnh.Image = null;
                    }

                    // Cập nhật trạng thái nút
                    btnthem.Enabled = false;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maSP = txtmasp.Text.Trim();
                string tenSP = string.Empty;
                string hinhAnh = string.Empty;

                if (string.IsNullOrEmpty(maSP))
                {
                    if (dgvsanpham.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dgvsanpham.SelectedRows[0];
                        maSP = selectedRow.Cells["MaSanPham"].Value?.ToString();
                        tenSP = selectedRow.Cells["TenSanPham"].Value?.ToString();
                        hinhAnh = selectedRow.Cells["HinhAnh"].Value?.ToString();
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
                    MessageBox.Show("Xóa không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrEmpty(tenSP) || string.IsNullOrEmpty(donGiaText) || string.IsNullOrEmpty(maLoai) || string.IsNullOrEmpty(maSP))
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

                // Xử lý ảnh
                string hinhAnh = imagePath; // Giữ nguyên ảnh hiện tại
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    string targetFolder = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }
                    string fileName = Path.GetFileName(imagePath);
                    string targetPath = Path.Combine(targetFolder, fileName);
                    File.Copy(imagePath, targetPath, true); // Sao chép ảnh mới
                    hinhAnh = fileName; // Cập nhật tên file ảnh
                }

                // Tạo đối tượng sản phẩm
                SanPham sp = new SanPham
                {
                    MaSanPham = maSP,
                    TenSanPham = tenSP,
                    DonGia = donGia,
                    MaLoai = maLoai,
                    TrangThai = trangThai,
                    HinhAnh = hinhAnh // Sử dụng ảnh hiện tại hoặc ảnh mới
                };

                // Cập nhật sản phẩm
                BLLsanpham bUSSanPham = new BLLsanpham();
                string result = bUSSanPham.UpdateSanPham(sp);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachSanPham();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txttimkiem.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm hoặc tên sản phẩm để tìm kiếm!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BLLsanpham bUSSanPham = new BLLsanpham();
                // Tìm kiếm theo mã hoặc tên sản phẩm
                List<SanPham> lstSP = bUSSanPham.TimKiemSanPham(keyword, keyword, "", -1);

                dgvsanpham.DataSource = null;
                dgvsanpham.DataSource = lstSP;

                if (lstSP.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm nào phù hợp!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Tìm thấy {lstSP.Count} sản phẩm!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}