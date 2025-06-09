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
            btnThongKe_Click(sender, e);

        }
        private void LoadLoaiSanPham()
        {
            try
            {
                BLLLOAISANPHAM bUSLoaiSanPham = new BLLLOAISANPHAM();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();

                dsLoai.Insert(0, new LoaiSanPham() { MaLoai = string.Empty, TenLoai = string.Format("--Tất Cả--") });
                cbxLoaiSanPham.DataSource = dsLoai;
                cbxLoaiSanPham.ValueMember = "MaLoai";
                cbxLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string loai = cbxLoaiSanPham.SelectedValue.ToString();
            DateTime bd = dtpTuNgay.Value.Date;
            DateTime kt = dtpDenNgay.Value.Date;

            BUSThongKe busThongKe = new BUSThongKe();
            List<TKDoanhThuLoaiSP> result = busThongKe.getThongKeLoaiSP(loai, bd, kt);
            dgrDanhSachThongKe.DataSource = result;
        }
    }
}
