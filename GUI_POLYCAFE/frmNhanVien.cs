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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void loaddanhsachNhanvien()
        {
            BLLNHANVIEN bLLNHANVIEN = new BLLNHANVIEN();
            var nhanVienList = bLLNHANVIEN.GetNhanVienList();
            if (nhanVienList == null || !nhanVienList.Any())
            {
                MessageBox.Show("Không có dữ liệu nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataNhanVien.DataSource = null;
                return;
            }
            dataNhanVien.DataSource = nhanVienList;
        }
        private void ConfigureDataGridViewColumns()
        {
            dataNhanVien.AutoGenerateColumns = false;
            dataNhanVien.Columns.Clear(); // Xóa các cột hiện có để tránh trùng lặp

            // Định nghĩa các cột với độ rộng mới
            var columns = new[]
            {
        new { Name = "MaNhanVien", HeaderText = "Mã Nhân Viên", DataPropertyName = "MaNhanVien", ReadOnly = true, Type = typeof(DataGridViewTextBoxColumn), Width = 120 },
        new { Name = "HoTen", HeaderText = "Họ Tên", DataPropertyName = "HoTen", ReadOnly = false, Type = typeof(DataGridViewTextBoxColumn), Width = 250 },
        new { Name = "Email", HeaderText = "Email", DataPropertyName = "Email", ReadOnly = false, Type = typeof(DataGridViewTextBoxColumn), Width = 300 },
        new { Name = "MatKhau", HeaderText = "Mật Khẩu", DataPropertyName = "MatKhau", ReadOnly = false, Type = typeof(DataGridViewTextBoxColumn), Width = 120 },
        new { Name = "VaiTroDisplay", HeaderText = "Vai Trò", DataPropertyName = "", ReadOnly = false, Type = typeof(DataGridViewComboBoxColumn), Width = 150 },
        new { Name = "TrangThaiDisplay", HeaderText = "Trạng Thái", DataPropertyName = "", ReadOnly = false, Type = typeof(DataGridViewComboBoxColumn), Width = 180 }
    };

            foreach (var col in columns)
            {
                if (col.Type == typeof(DataGridViewTextBoxColumn))
                {
                    var column = new DataGridViewTextBoxColumn
                    {
                        Name = col.Name,
                        HeaderText = col.HeaderText,
                        DataPropertyName = col.DataPropertyName,
                        ReadOnly = col.ReadOnly,
                        Width = col.Width // Thiết lập độ rộng
                    };
                    dataNhanVien.Columns.Add(column);
                }
                else if (col.Type == typeof(DataGridViewComboBoxColumn))
                {
                    var column = new DataGridViewComboBoxColumn
                    {
                        Name = col.Name,
                        HeaderText = col.HeaderText,
                        DataPropertyName = col.DataPropertyName,
                        Width = col.Width // Thiết lập độ rộng
                    };

                    if (col.Name == "VaiTroDisplay")
                    {
                        column.Items.AddRange("Nhân Viên", "Quản Lý");
                    }
                    else if (col.Name == "TrangThaiDisplay")
                    {
                        column.Items.AddRange("Đang Hoạt Động", "Tạm Ngưng");
                    }

                    dataNhanVien.Columns.Add(column);
                }
            }
        }
        private void ClearForm()
        {

            txtmanv.Clear();
            txthovaten.Clear();
            txtemail.Clear();
            txtmatkhau.Clear();
            rbdnv.Checked = false;
            txtmanv.Focus();

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loaddanhsachNhanvien();
            ConfigureDataGridViewColumns();
            // Đặt chế độ chọn hàng 
            dataNhanVien.CellFormatting += new DataGridViewCellFormattingEventHandler(dataNhanVien_CellFormatting);
            dataNhanVien.CellEndEdit += new DataGridViewCellEventHandler(dataNhanVien_CellEndEdit);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Bước 1: Lấy dữ liệu từ form
                string maNV = txtmanv.Text.Trim();
                string hoten = txthovaten.Text.Trim();
                string email = txtemail.Text.Trim();
                string matkhau = txtmatkhau.Text.Trim();

                // Lấy VaiTrò từ RadioButton
                bool vaiTro = rbdnv.Checked; // True cho Nhân viên, False cho Quản lý

                // Lấy TrangThai từ RadioButton
                bool trangThai = rbdhoatdong.Checked; // True cho Hoạt động, False cho Tạm ngưng

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matkhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Bước 3: Tạo đối tượng
                NHANVIEN nv = new NHANVIEN
                {
                    MaNhanVien = maNV,
                    HoTen = hoten,
                    Email = email,
                    MatKhau = matkhau,
                    VaiTro = vaiTro,
                    TrangThai = trangThai
                };

                // Gọi DAL để thêm nhân viên vào database
                BLLNHANVIEN bUSNhanVien = new BLLNHANVIEN();
                string result = bUSNhanVien.InsertNhanVien(nv);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loaddanhsachNhanvien(); // Cập nhật lại DataGridView
                    ClearForm();
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

        private void btnlamoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataNhanVien.Rows[e.RowIndex];
                txtmanv.Text = row.Cells["MaNhanVien"].Value?.ToString() ?? "";
                txthovaten.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txtemail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtmatkhau.Text = row.Cells["MatKhau"].Value?.ToString() ?? "";

                NHANVIEN nv = row.DataBoundItem as NHANVIEN;
                if (nv != null)
                {
                    if (nv.VaiTro)
                    {
                        rbdquanly.Checked = true; // true = Quản Lý
                    }
                    else
                    {
                        rbdnv.Checked = true;     // false = Nhân Viên
                    }

                    if (nv.TrangThai)
                    {
                        rbdhoatdong.Checked = true;
                    }
                    else
                    {
                        rbdstop.Checked = true;
                    }
                    btnxoa.Enabled = true;
                }
                else
                {
                    rbdnv.Checked = false;
                    rbdquanly.Checked = false;
                    rbdhoatdong.Checked = false;
                    rbdstop.Checked = false;
                    btnxoa.Enabled = false;
                    MessageBox.Show("Dữ liệu hàng này không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                txtmanv.Enabled = false;
                btnthem.Enabled = false;
                btnsua.Enabled = true;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmanv.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txtmanv.Text.Trim();
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                BLLNHANVIEN bus = new BLLNHANVIEN();
                string result = bus.DeleteNhanVien(maNV);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    loaddanhsachNhanvien();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmanv.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txtmanv.Text.Trim();
            string hoTen = txthovaten.Text.Trim();
            string email = txtemail.Text.Trim();
            string matKhau = txtmatkhau.Text.Trim();
            bool vaiTro;

            if (rbdquanly.Checked || rbdnv.Checked)
            {
                vaiTro = rbdquanly.Checked; // true cho "quản lý", false cho "nhân viên"
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vai trò (nhân viên hoặc quản lý).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool trangThai;
            if (rbdhoatdong.Checked || rbdstop.Checked)
            {
                trangThai = rbdhoatdong.Checked; // true cho "hoạt động", false cho "tạm ngưng"
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạng thái (hoạt động hoặc tạm ngưng).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            NHANVIEN nv = new NHANVIEN
            {
                MaNhanVien = maNV,
                HoTen = hoTen,
                Email = email,
                MatKhau = matKhau,
                VaiTro = vaiTro,
                TrangThai = trangThai
            };
            BLLNHANVIEN bus = new BLLNHANVIEN();
            string result = bus.UpdateNhanVien(nv);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                loaddanhsachNhanvien();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại và quay lại form trước đó và hỏi
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void dataNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataNhanVien.Rows[e.RowIndex];
                NHANVIEN nv = row.DataBoundItem as NHANVIEN;

                if (nv != null)
                {
                    if (dataNhanVien.Columns[e.ColumnIndex].Name == "VaiTroDisplay")
                    {
                        e.Value = nv.VaiTro ? "Quản Lý" : "Nhân Viên"; // Đảo ngược logic cho khớp với radio button
                        e.FormattingApplied = true;
                    }

                    if (dataNhanVien.Columns[e.ColumnIndex].Name == "TrangThaiDisplay")
                    {
                        e.Value = nv.TrangThai ? "Đang Hoạt Động" : "Tạm Ngưng";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dataNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataNhanVien.Rows[e.RowIndex];
                NHANVIEN nv = (NHANVIEN)row.DataBoundItem;
                string maNhanVien = nv.MaNhanVien;

                if (dataNhanVien.Columns[e.ColumnIndex].Name == "VaiTroDisplay")
                {
                    string selectedValue = row.Cells["VaiTroDisplay"].Value?.ToString();
                    bool newVaiTro = selectedValue == "Quản Lý" ? false : true; // "Nhân Viên" = true, "Quản Lý" = false
                    if (nv.VaiTro != newVaiTro)
                    {
                        BLLNHANVIEN busNhanVien = new BLLNHANVIEN();
                        busNhanVien.UpdateVaiTro(maNhanVien, newVaiTro);
                        nv.VaiTro = newVaiTro; // Cập nhật lại đối tượng
                    }
                }

                if (dataNhanVien.Columns[e.ColumnIndex].Name == "TrangThaiDisplay")
                {
                    string selectedValue = row.Cells["TrangThaiDisplay"].Value?.ToString();
                    bool newTrangThai = selectedValue == "Đang Hoạt Động" ? true : false; // "Đang Hoạt Động" = true, "Tạm Ngưng" = false
                    if (nv.TrangThai != newTrangThai)
                    {
                        BLLNHANVIEN busNhanVien = new BLLNHANVIEN();
                        busNhanVien.UpdateTrangThai(maNhanVien, newTrangThai);
                        nv.TrangThai = newTrangThai; // Cập nhật lại đối tượng
                    }
                }

                // Làm mới hiển thị
                dataNhanVien.Refresh();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                BLLNHANVIEN bLLNHANVIEN = new BLLNHANVIEN();
                List<NHANVIEN> searchResults = bLLNHANVIEN.SearchNhanVien(searchValue);
                if (searchResults == null || searchResults.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhân viên nào với thông tin đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataNhanVien.DataSource = null; // Hoặc giữ nguyên danh sách hiện tại
                }
                else
                {
                    dataNhanVien.DataSource = searchResults;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
