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
    public partial class frmDoanhThuLoaiSP : Form
    {
        public frmDoanhThuLoaiSP()
        {
            InitializeComponent();
        }

        private void frmDoanhThuLoaiSP_Load(object sender, EventArgs e)
        {
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTuNgay.Value = firstDayOfMonth;
            LoadLoaiSanPham();
            PerformThongKe();
        }

        private void LoadLoaiSanPham()
        {
            try
            {
                BLLLOAISANPHAM bUSLoaiSanPham = new BLLLOAISANPHAM();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();

                dsLoai.Insert(0, new LoaiSanPham { MaLoai = string.Empty, TenLoai = "--Tất Cả--" });
                cbxLoaiSanPham.DataSource = dsLoai;
                cbxLoaiSanPham.ValueMember = "MaLoai";
                cbxLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PerformThongKe()
        {
            btnThongKe_Click(null, null); // Gọi hàm thống kê khi form load
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string loai = cbxLoaiSanPham.SelectedValue.ToString();
            DateTime bd = dtpTuNgay.Value.Date;
            DateTime kt = dtpDenNgay.Value.Date;

            List<TKDoanhThuLoaiSP> result = GetThongKeData(loai, bd, kt);
            DisplayThongKeResult(result, bd, kt);
        }

        private List<TKDoanhThuLoaiSP> GetThongKeData(string loai, DateTime bd, DateTime kt)
        {
            try
            {
                BUSThongKe busThongKe = new BUSThongKe();
                return busThongKe.getThongKeLoaiSP(loai, bd, kt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<TKDoanhThuLoaiSP>();
            }
        }

        private void DisplayThongKeResult(List<TKDoanhThuLoaiSP> result, DateTime bd, DateTime kt)
        {
            dgrDanhSachThongKe.DataSource = result;

            if (result != null && result.Count > 0)
            {
                SetupDataGridViewColumns();
                dgrDanhSachThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgrDanhSachThongKe.DataSource = null;
                MessageBox.Show("Không có dữ liệu để hiển thị cho khoảng thời gian từ " + bd.ToString("dd/MM/yyyy") + " đến " + kt.ToString("dd/MM/yyyy") + ".", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetupDataGridViewColumns()
        {
            if (dgrDanhSachThongKe.Columns.Contains("MaLoai"))
                dgrDanhSachThongKe.Columns["MaLoai"].HeaderText = "Mã Loại";
            if (dgrDanhSachThongKe.Columns.Contains("TenLoai"))
                dgrDanhSachThongKe.Columns["TenLoai"].HeaderText = "Tên Loại";
            if (dgrDanhSachThongKe.Columns.Contains("DoanhThu"))
                dgrDanhSachThongKe.Columns["DoanhThu"].HeaderText = "Doanh Thu (VNĐ)";
            if (dgrDanhSachThongKe.Columns.Contains("SoLuongBan"))
                dgrDanhSachThongKe.Columns["SoLuongBan"].HeaderText = "Số Lượng Bán";
        }
    }
}