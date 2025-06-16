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
    public partial class frmQuanLyThietBi : Form
    {
        public frmQuanLyThietBi()
        {
            InitializeComponent();
        }
        private readonly ThietBiBLL thietBiBLL = new ThietBiBLL();
        private DataTable dt;

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvThietBi.Rows[e.RowIndex];
                txtTenThietBi.Text = row.Cells["TenThietBi"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                cboTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
                dtpNgayMua.Value = Convert.ToDateTime(row.Cells["NgayMua"].Value);
                if (row.Cells["HanBaoHanh"].Value != DBNull.Value)
                {
                    dtpHanBaoHanh.Value = Convert.ToDateTime(row.Cells["HanBaoHanh"].Value);
                    chkHanBaoHanh.Checked = false;
                }
                else
                {
                    chkHanBaoHanh.Checked = true;
                }
                txtLichBaoTri.Text = row.Cells["LichBaoTri"].Value != DBNull.Value ? row.Cells["LichBaoTri"].Value.ToString() : string.Empty;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void frmQuanLyThietBi_Load(object sender, EventArgs e)
        {
            Loadtinhtrang();
            LoadData();
            setupcolumns();
            clear();
            chkHanBaoHanh.CheckedChanged += new EventHandler(chkHanBaoHanh_CheckedChanged);
            txtTimKiem.TextChanged += new EventHandler(txtTimKiem_TextChanged);
        }
        private void setupcolumns()
        {
            if (dgvThietBi.Columns["MaThietBi"] != null) dgvThietBi.Columns["MaThietBi"].HeaderText = "Mã Thiết Bị";
            if (dgvThietBi.Columns["TenThietBi"] != null) dgvThietBi.Columns["TenThietBi"].HeaderText = "Tên Thiết Bị";
            if (dgvThietBi.Columns["SoLuong"] != null) dgvThietBi.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (dgvThietBi.Columns["TinhTrang"] != null) dgvThietBi.Columns["TinhTrang"].HeaderText = "Tình Trạng";
            if (dgvThietBi.Columns["NgayMua"] != null) dgvThietBi.Columns["NgayMua"].HeaderText = "Ngày Mua";
            if (dgvThietBi.Columns["HanBaoHanh"] != null) dgvThietBi.Columns["HanBaoHanh"].HeaderText = "Hạn Bảo Hành";
            if (dgvThietBi.Columns["LichBaoTri"] != null) dgvThietBi.Columns["LichBaoTri"].HeaderText = "Lịch Bảo Trì";
            if (dgvThietBi.Columns["NgayTao"] != null) dgvThietBi.Columns["NgayTao"].HeaderText = "Ngày Tạo";
            if (dgvThietBi.Columns["NgayCapNhat"] != null) dgvThietBi.Columns["NgayCapNhat"].HeaderText = "Ngày Cập Nhật";
            //fill hêt 


        }
        private void Loadtinhtrang()
        {
            cboTinhTrang.Items.Clear();
            cboTinhTrang.Items.AddRange(new object[] { "Hoạt động", "Hỏng", "Cần bảo trì" });
            cboTinhTrang.SelectedIndex = 0; // Mặc định chọn "Hoạt động"
        }
        private void clear()
        {
            txtTenThietBi.Text = string.Empty;
            txtSoLuong.Text = "1";
            cboTinhTrang.SelectedIndex = 0;
            dtpNgayMua.Value = DateTime.Today;
            dtpHanBaoHanh.Value = DateTime.Today;
            chkHanBaoHanh.Checked = false;
            dtpHanBaoHanh.Enabled = true;
            txtLichBaoTri.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            dgvThietBi.ClearSelection();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void LoadData()
        {
            try
            {
                dt = thietBiBLL.LayDanhSachThietBi();
                dgvThietBi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            var thietBi = new ThietBiDTO
            {
                TenThietBi = txtTenThietBi.Text.Trim(),
                SoLuong = int.TryParse(txtSoLuong.Text.Trim(), out int sl) ? sl : 0,
                TinhTrang = cboTinhTrang.SelectedItem.ToString(),
                NgayMua = dtpNgayMua.Value,
                HanBaoHanh = chkHanBaoHanh.Checked ? (DateTime?)null : dtpHanBaoHanh.Value,
                LichBaoTri = txtLichBaoTri.Text.Trim()
            };

            if (thietBiBLL.ThemThietBi(thietBi, out string error))
            {
                LoadData();
                clear();
                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int maThietBi = Convert.ToInt32(dgvThietBi.SelectedRows[0].Cells["MaThietBi"].Value);
                if (thietBiBLL.XoaThietBi(maThietBi, out string error))
                {
                    LoadData();
                    clear();
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var thietBi = new ThietBiDTO
            {
                MaThietBi = Convert.ToInt32(dgvThietBi.SelectedRows[0].Cells["MaThietBi"].Value),
                TenThietBi = txtTenThietBi.Text.Trim(),
                SoLuong = int.TryParse(txtSoLuong.Text.Trim(), out int sl) ? sl : 0,
                TinhTrang = cboTinhTrang.SelectedItem.ToString(),
                NgayMua = dtpNgayMua.Value,
                HanBaoHanh = chkHanBaoHanh.Checked ? (DateTime?)null : dtpHanBaoHanh.Value,
                LichBaoTri = txtLichBaoTri.Text.Trim()
            };

            if (thietBiBLL.SuaThietBi(thietBi, out string error))
            {
                LoadData();
                clear();
                MessageBox.Show("Sửa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void chkHanBaoHanh_CheckedChanged(object sender, EventArgs e)
        {
            dtpHanBaoHanh.Enabled = !chkHanBaoHanh.Checked;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = thietBiBLL.TimKiemThietBi(txtTimKiem.Text.Trim());
                dgvThietBi.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
