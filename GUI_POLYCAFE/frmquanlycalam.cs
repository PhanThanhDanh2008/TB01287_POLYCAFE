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

namespace GUI_POLYCAFE
{
    public partial class frmquanlycalam : Form
    {
        public frmquanlycalam()
        {
            InitializeComponent();
        }
        private LichLamViecBLL lichBLL = new LichLamViecBLL();
        private BLLCaTruc caBLL = new BLLCaTruc();
        private BLLNHANVIEN nhanVienBLL = new BLLNHANVIEN();

        private void frmquanlycalam_Load(object sender, EventArgs e)
        {
            LoadCaLamViec();
            LoadNhanVien();
            LoadDanhSachLichLamViec();
        }

        private void LoadCaLamViec()
        {
            var caList = caBLL.LayDanhSachCaTruc();
            cmbcalam.DataSource = caList;
            cmbcalam.DisplayMember = "TenCa";
            cmbcalam.ValueMember = "MaCa";
        }
        private void LoadNhanVien()
        {
            var nhanVienList = nhanVienBLL.GetNhanVienList();
            cbxNhanVien.DataSource = nhanVienList;
            cbxNhanVien.DisplayMember = "HoTen";
            cbxNhanVien.ValueMember = "MaNhanVien";
        }
        private void LoadDanhSachLichLamViec()
        {
            var lichList = lichBLL.LayDanhSachLichLamViec();
            var caList = caBLL.LayDanhSachCaTruc();
            var nhanVienList = nhanVienBLL.GetNhanVienList();

            var combinedData = (from lich in lichList
                                join ca in caList on lich.MaCa equals ca.MaCa
                                join nv in nhanVienList on lich.MaNhanVien equals nv.MaNhanVien
                                select new
                                {
                                    STT = lichList.IndexOf(lich) + 1,
                                    MaLich = lich.MaLich,
                                    MaNV = lich.MaNhanVien,
                                    TenNV = nv.HoTen,
                                    MaCa = lich.MaCa,
                                    TenCa = ca.TenCa,
                                    NgayLamViec = lich.Ngay.ToString("dd/MM/yyyy")
                                }).ToList();

            dgrLichLamViec.DataSource = combinedData;

            // Ẩn cột không cần hiển thị nếu có
            if (dgrLichLamViec.Columns.Contains("MaLich") && dgrLichLamViec.Columns["MaLich"].Visible)
                dgrLichLamViec.Columns["MaLich"].Visible = false;
            if (dgrLichLamViec.Columns.Contains("MaNV") && dgrLichLamViec.Columns["MaNV"].Visible)
                dgrLichLamViec.Columns["MaNV"].Visible = false;
            if (dgrLichLamViec.Columns.Contains("MaCa") && dgrLichLamViec.Columns["MaCa"].Visible)
                dgrLichLamViec.Columns["MaCa"].Visible = false;
        }

    }

}
