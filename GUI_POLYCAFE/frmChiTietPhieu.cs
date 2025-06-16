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
    public partial class frmChiTietPhieu : Form
    {
        private TheLuuDong theLuuDong;
        private PhieuBanHang phieuBanHang;
        private NHANVIEN nhanVien;
        private List<ChiTietPhieu> lstChiTiet;
        private List<SanPham> lstSanPham;
        bool isActive = true;
        public frmChiTietPhieu(TheLuuDong the, PhieuBanHang phieu, NHANVIEN nv)
        {
            InitializeComponent();
            theLuuDong = the;
            phieuBanHang = phieu;
            nhanVien = nv;
            lstChiTiet = new List<ChiTietPhieu>();
            lstSanPham = new List<SanPham>();
            isActive = phieu.TrangThai;
        }

        private void activeTranfer()
        {
            if (isActive)
            {
                btnThemChiTiet.Enabled = false;
                btnXoaChiTiet.Enabled = false;
                txtPhanTram.Enabled = false;
            }
        }

        private void LoadInfo()
        {
            lbChuSoHuu.Text = $"{theLuuDong.MaThe} - {theLuuDong.ChuSoHuu}";
            lbMaPhieu.Text = phieuBanHang.MaPhieu;
            lbNgayLap.Text = phieuBanHang.NgayTao.ToString("dd/MM/yyyy");
        }



        private void loadSanPham()
        {
            BLLsanpham sp = new BLLsanpham();
            lstSanPham = sp.GetSanPhamList(1);
            dgrSanPham.DataSource = lstSanPham;
            dgrSanPham.Columns["MaSanPham"].HeaderText = "Mã Sản Phẩm";
            dgrSanPham.Columns["TenSanPham"].HeaderText = "Tên Sản Phẩm";
            dgrSanPham.Columns["DonGia"].HeaderText = "Đơn Gía";
            dgrSanPham.Columns["TenLoai"].HeaderText = "Loại Sản Phẩm";
            dgrSanPham.Columns["HinhAnh"].HeaderText = "Hình Ảnh";


            dgrSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadChiTietPhieu(string maPhieu)
        {
            BusChiTietPhieu bus = new BusChiTietPhieu();
            lstChiTiet = bus.GetChiTietPhieuList(maPhieu);
            dgrChiTiet.DataSource = lstChiTiet;
            dgrChiTiet.Columns["MaChiTiet"].Visible = false;
            dgrChiTiet.Columns["MaPhieu"].Visible = false;
            dgrChiTiet.Columns["MaSanPham"].Visible = false;
            dgrChiTiet.Columns["TenSanPham"].HeaderText = "Sản Phẩm";
            dgrChiTiet.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgrChiTiet.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgrChiTiet.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgrChiTiet.Columns["SoLuong"].ReadOnly = false;

            dgrChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dgrChiTiet.Columns)
            {
                col.ReadOnly = true;
            }
            dgrChiTiet.Columns["SoLuong"].ReadOnly = false;
        }

        private void dgrSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgrSanPham.Rows[e.RowIndex];

                // Tạo đối tượng từ dữ liệu hàng
                SanPham sanPham = new SanPham
                {
                    MaSanPham = row.Cells["MaSanPham"].Value.ToString(),
                    TenSanPham = row.Cells["TenSanPham"].Value.ToString(),
                    DonGia = Convert.ToInt32(row.Cells["DonGia"].Value)
                };

                transfer(sanPham);
            }
        }

        private void transfer(SanPham sp, int soLuong = 1)
        {
            if (isActive)
            {
                return;
            }
            if (sp != null)
            {
                BusChiTietPhieu bus = new BusChiTietPhieu();
                ChiTietPhieu existingItem = lstChiTiet.FirstOrDefault(item => item.MaSanPham == sp.MaSanPham);
                if (existingItem != null)
                {
                    existingItem.SoLuong += soLuong;
                    string result = bus.UpdateSoLuong(existingItem);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ChiTietPhieu ct = new ChiTietPhieu()
                    {
                        MaPhieu = phieuBanHang.MaPhieu,
                        MaSanPham = sp.MaSanPham,
                        SoLuong = soLuong,
                        DonGia = sp.DonGia,
                    };
                    string result = bus.InsertChiTietPhieu(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                loadChiTietPhieu(phieuBanHang.MaPhieu);

            }
        }

        private void deleteChiTiet()
        {
            if (dgrChiTiet.CurrentRow != null)
            {
                string id = Convert.ToString(dgrChiTiet.CurrentRow.Cells["MaChiTiet"].Value);
                string name = Convert.ToString(dgrChiTiet.CurrentRow.Cells["TenSanPham"].Value);
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phầm {name}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    BusChiTietPhieu bus = new BusChiTietPhieu();
                    string kq = bus.DeleteChiTiet(id); ;
                    if (string.IsNullOrEmpty(kq))
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }
                }
            }
        }

        private void dgrChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (isActive)
            {
                return;
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                BusChiTietPhieu bus = new BusChiTietPhieu();
                ChiTietPhieu ct = lstChiTiet[e.RowIndex];
                int newQuantity;
                if (int.TryParse(dgrChiTiet.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString(), out newQuantity))
                {
                    ct.SoLuong = newQuantity;
                    string result = bus.UpdateSoLuong(ct);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Thêm sản phẩm không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Đảm bảo ko lỗi khi đang edit mà chuyển ô
                    this.BeginInvoke((Action)(() =>
                    {
                        loadChiTietPhieu(phieuBanHang.MaPhieu);
                    }));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            deleteChiTiet();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                return;
            }
            if (dgrSanPham.CurrentRow != null)
            {
                string id = Convert.ToString(dgrSanPham.CurrentRow.Cells["MaSanPham"].Value);
                string ten = Convert.ToString(dgrSanPham.CurrentRow.Cells["TenSanPham"].Value);
                decimal dongia = Convert.ToDecimal(dgrSanPham.CurrentRow.Cells["DonGia"].Value);
                SanPham sanPham = new SanPham
                {
                    MaSanPham = id,
                    TenSanPham = ten,
                    DonGia = dongia
                };

                transfer(sanPham);
            }
        }


        private void loadThanhToan()
        {
            txtTong.Text = "0";
            txtGiamGia.Text = "0";
            txtPhanTram.Text = "0";
            txtThanhTien.Text = "0";
            txtDichVu.Text = "0";
        }

        private void frmChiTietPhieu_Load_1(object sender, EventArgs e)
        {
            loadThanhToan();
            LoadInfo();
            loadSanPham();
            loadChiTietPhieu(phieuBanHang.MaPhieu);
            activeTranfer();
            txtPhanTram.TextChanged += RecalculateDiscountAndTotal;
            txtDichVu.TextChanged += RecalculateDiscountAndTotal;
        }
        private void RecalculateDiscountAndTotal(object sender, EventArgs e)
        {
            // Lấy tổng tiền đã có (giả sử đã lưu vào biến hoặc txtTong)
            if (!decimal.TryParse(txtTong.Text, out decimal total))
                return;

            // Đọc giá trị dịch vụ
            decimal dichVu = 0;
            decimal.TryParse(txtDichVu.Text, out dichVu);

            // Đọc phần trăm giảm giá
            decimal phanTram = 0;
            decimal.TryParse(txtPhanTram.Text, out phanTram);

            // Tính tiền giảm
            decimal giamGia = total * phanTram / 100;
            txtGiamGia.Text = giamGia.ToString("N0");

            // Tính thành tiền: tổng + dịch vụ – giảm giá
            decimal thanhTien = total + dichVu - giamGia;
            txtThanhTien.Text = thanhTien.ToString("N0");
        }
        BusChiTietPhieu bus = new BusChiTietPhieu();
        private void dgrChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgrChiTiet.Rows[e.RowIndex];

            // 2) Lấy mã phiếu từ DataGridView
            //    Giả sử cột MaPhieu có Name = "MaPhieu"
            string maPhieu = row.Cells["MaPhieu"].Value?.ToString() ?? "";
            if (string.IsNullOrEmpty(maPhieu))
            {
                MessageBox.Show("Mã phiếu không hợp lệ.");
                return;
            }

            // 3) Gọi BLL để lấy tổng tiền
            string tongTienStr = bus.CalculateTongTien(maPhieu);
            // Nếu BUS trả về chuỗi lỗi, sẽ có chữ "Lỗi:" ở đầu
            if (tongTienStr.StartsWith("Lỗi:"))
            {
                MessageBox.Show(tongTienStr);
                return;
            }

            // 4) Chuyển về decimal và hiển thị
            if (!decimal.TryParse(tongTienStr, out decimal total))
            {
                MessageBox.Show("Dữ liệu tổng tiền không hợp lệ.");
                return;
            }
            txtTong.Text = total.ToString("N0");

            // 5) Tính các phần còn lại như trước
            decimal dichVu = 0, phanTram = 0;
            decimal.TryParse(txtDichVu.Text, out dichVu);
            decimal.TryParse(txtPhanTram.Text, out phanTram);

            decimal giamGia = total * phanTram / 100;
            decimal thanhTien = total + dichVu - giamGia;

            txtGiamGia.Text = giamGia.ToString("N0");
            txtThanhTien.Text = thanhTien.ToString("N0");
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                MessageBox.Show("Phiếu này đã được thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy tổng tiền, dịch vụ, giảm giá, thành tiền
            if (!decimal.TryParse(txtTong.Text, out decimal tongTien))
            {
                MessageBox.Show("Tổng tiền không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal.TryParse(txtDichVu.Text, out decimal dichVu);
            decimal.TryParse(txtPhanTram.Text, out decimal phanTram);
            decimal giamGia = tongTien * phanTram / 100;
            decimal thanhTien = tongTien + dichVu - giamGia;

            // Xác nhận thanh toán
            DialogResult result = MessageBox.Show(
                $"Tổng tiền: {tongTien:N0}\nDịch vụ: {dichVu:N0}\nGiảm giá: {giamGia:N0}\nThành tiền: {thanhTien:N0}\n\nBạn có chắc chắn muốn thanh toán?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cập nhật trạng thái phiếu bán hàng
                phieuBanHang.TrangThai = true;
                // Gọi BLL để cập nhật trạng thái phiếu
                BLLPhieuBanHang busPhieu = new BLLPhieuBanHang();
                string updateResult = busPhieu.UpdatePhieuBanHang(phieuBanHang);

                if (string.IsNullOrEmpty(updateResult))
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isActive = true;
                    activeTranfer();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại: " + updateResult, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
