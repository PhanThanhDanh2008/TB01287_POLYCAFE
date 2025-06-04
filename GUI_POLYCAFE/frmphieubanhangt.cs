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
using UTIL_OLYCAFE;

namespace GUI_POLYCAFE
{
    public partial class frmphieubanhangt : Form
    {
        private bool isLoadingTheLuuDongData = true;

        public frmphieubanhangt()
        {
            InitializeComponent();
        }
        private void ClearForm(string msThe)
        {
            btnThemPhieu.Enabled = true;
            btnSuaPhieu.Enabled = false;
            btnXoaPhieu.Enabled = true;
            txtMaPhieu.Clear();
            cboNhanVienBH.Enabled = true;
            dtpNgayTao.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdbConfirmation.Enabled = true;
            rdbPaid.Enabled = true;
            dtpNgayTao.Value = DateTime.Now;
            rdbConfirmation.Checked = true;
        }

        private void LoadNhanVien()
        {
            try
            {
                BLLNHANVIEN busNhanVien = new BLLNHANVIEN();
                List<NHANVIEN> dsLoai = busNhanVien.GetNhanVienList();
                if (AuthUtil.user.VaiTro)
                {
                    dsLoai.Insert(0, new NHANVIEN() { MaNhanVien = string.Empty, HoTen = string.Format("--Vui lòng chọn nhân viên--") });
                }
                else
                {
                    dsLoai = dsLoai.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                    cboNhanVienBH.Enabled = false;
                }
                cboNhanVienBH.DataSource = dsLoai;
                cboNhanVienBH.ValueMember = "MaNhanVien";
                cboNhanVienBH.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTheLuuDong()
        {
            BLLTHELUUDONG busTheLuuDong = new BLLTHELUUDONG();
            List<TheLuuDong> lst = busTheLuuDong.GetTheLuuDongList();
            lst.Insert(0, new TheLuuDong() { MaThe = string.Empty, ChuSoHuu = string.Format("--Tất Cả--") });
            cboMaTheLuuDong.DataSource = lst;
            cboMaTheLuuDong.ValueMember = "MaThe";
            cboMaTheLuuDong.DisplayMember = "ChuSoHuu";
            isLoadingTheLuuDongData = false;
        }
        private void LoadDanhSachPhieu(string maThe)
        {
            BLLPhieuBanHang busPhieuBanHang = new BLLPhieuBanHang();
            List<PhieuBanHang> lst = busPhieuBanHang.GetListPhieuBanHang(maThe);
            if (!AuthUtil.user.VaiTro)
            {
                lst = lst.Where(x => x.MaNhanVien == AuthUtil.user.MaNhanVien).ToList();
                cboNhanVienBH.Enabled = false;
            }
            dgrDanhSachPhieu.DataSource = lst;


            DataGridViewImageColumn buttonColumn = new DataGridViewImageColumn();
            buttonColumn.Name = "ThanhToan";
            buttonColumn.HeaderText = "Thanh Toán";
            //buttonColumn.Text = "Thanh Toán";
            //buttonColumn.UseColumnTextForButtonValue = true; // Hiển thị văn bản lên nút
            buttonColumn.Image = Properties.Resources.pay;
            buttonColumn.DefaultCellStyle.BackColor = Color.LightBlue;
            buttonColumn.DefaultCellStyle.ForeColor = Color.DarkBlue;

            buttonColumn.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            if (!dgrDanhSachPhieu.Columns.Contains("ThanhToan"))
            {
                dgrDanhSachPhieu.Columns.Add(buttonColumn);
            }
            dgrDanhSachPhieu.Columns["ThanhToan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgrDanhSachPhieu.RowTemplate.Height = 50;

            dgrDanhSachPhieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmchitietphiet_Load(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");

        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            ClearForm("");
            LoadTheLuuDong();
            LoadNhanVien();
            LoadDanhSachPhieu("");
        }

    }
}
