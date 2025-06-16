using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class ThietBiBLL
    {
        private readonly ThietBiDAL thietBiDAL = new ThietBiDAL();

        // Lấy danh sách tất cả thiết bị
        public DataTable LayDanhSachThietBi()
        {
            return thietBiDAL.LayDanhSachThietBi();
        }

        // Thêm thiết bị mới
        public bool ThemThietBi(ThietBiDTO thietBi, out string error)
        {
            error = string.Empty;
            if (string.IsNullOrWhiteSpace(thietBi.TenThietBi))
            {
                error = "Tên thiết bị không được để trống!";
                return false;
            }
            if (thietBi.SoLuong < 0)
            {
                error = "Số lượng phải là số không âm!";
                return false;
            }
            if (!new[] { "Hoạt động", "Hỏng", "Cần bảo trì" }.Contains(thietBi.TinhTrang))
            {
                error = "Tình trạng không hợp lệ!";
                return false;
            }

            try
            {
                return thietBiDAL.ThemThietBi(thietBi);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Sửa thông tin thiết bị
        public bool SuaThietBi(ThietBiDTO thietBi, out string error)
        {
            error = string.Empty;
            if (thietBi.MaThietBi <= 0)
            {
                error = "Mã thiết bị không hợp lệ!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(thietBi.TenThietBi))
            {
                error = "Tên thiết bị không được để trống!";
                return false;
            }
            if (thietBi.SoLuong < 0)
            {
                error = "Số lượng phải là số không âm!";
                return false;
            }
            if (!new[] { "Hoạt động", "Hỏng", "Cần bảo trì" }.Contains(thietBi.TinhTrang))
            {
                error = "Tình trạng không hợp lệ!";
                return false;
            }

            try
            {
                return thietBiDAL.SuaThietBi(thietBi);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Xóa thiết bị
        public bool XoaThietBi(int maThietBi, out string error)
        {
            error = string.Empty;
            if (maThietBi <= 0)
            {
                error = "Mã thiết bị không hợp lệ!";
                return false;
            }

            try
            {
                return thietBiDAL.XoaThietBi(maThietBi);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Tìm kiếm thiết bị theo tên
        public DataTable TimKiemThietBi(string tenThietBi)
        {
            return thietBiDAL.TimKiemThietBi(tenThietBi);
        }
    }
}
