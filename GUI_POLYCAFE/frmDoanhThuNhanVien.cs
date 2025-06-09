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
    public partial class frmDoanhThuNhanVien : Form
    {
        public frmDoanhThuNhanVien()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maNV = cbxNhanVien.SelectedValue.ToString();
            DateTime bd = dtpTuNgay.Value.Date;
            DateTime kt = dtpDenNgay.Value.Date;

            BUSThongKe busThongKe = new BUSThongKe();
            List<TKDoanhThuTheoNhanVien> result = busThongKe.getThongKeNhanVien(maNV, bd, kt);
            dgrDanhSachThongKe.DataSource = result;
        }

        private void frmDoanhThuNhanVien_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtpTuNgay.Value = firstDayOfMonth;
            LoadNhanVien();

            btnThongKe_Click(sender, e);
        }
        private void LoadNhanVien()
        {
            try
            {
                BLLNHANVIEN busNhanVien = new BLLNHANVIEN();
                List<NHANVIEN> dsNhanVien = busNhanVien.GetNhanVienList();
                dsNhanVien.Insert(0, new NHANVIEN() { MaNhanVien = string.Empty, HoTen = string.Format("--Tất Cả--") });
                cbxNhanVien.DataSource = dsNhanVien;
                cbxNhanVien.ValueMember = "MaNhanVien";
                cbxNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
