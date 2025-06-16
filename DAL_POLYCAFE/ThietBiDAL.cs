using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_POLYCAFE;

namespace DAL_POLYCAFE
{
    public class ThietBiDAL
    {
        // Lấy danh sách tất cả thiết bị
        public DataTable LayDanhSachThietBi()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM ThietBi";
                List<object> args = new List<object>();
                using (SqlDataReader reader = DBUtil.Query(sql, args))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thiết bị: " + ex.Message);
            }
            return dt;
        }

        // Thêm thiết bị mới
        public bool ThemThietBi(ThietBiDTO thietBi)
        {
            try
            {
                string sql = "INSERT INTO ThietBi (TenThietBi, SoLuong, TinhTrang, NgayMua, HanBaoHanh, LichBaoTri) " +
                             "VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> args = new List<object>
                {
                    thietBi.TenThietBi,
                    thietBi.SoLuong,
                    thietBi.TinhTrang,
                    thietBi.NgayMua,
                    thietBi.HanBaoHanh.HasValue ? (object)thietBi.HanBaoHanh.Value : DBNull.Value,
                    string.IsNullOrEmpty(thietBi.LichBaoTri) ? (object)DBNull.Value : thietBi.LichBaoTri
                };
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thiết bị: " + ex.Message);
            }
        }

        // Sửa thông tin thiết bị
        public bool SuaThietBi(ThietBiDTO thietBi)
        {
            try
            {
                string sql = "UPDATE ThietBi SET TenThietBi = @0, SoLuong = @1, TinhTrang = @2, NgayMua = @3, " +
                             "HanBaoHanh = @4, LichBaoTri = @5 WHERE MaThietBi = @6";
                List<object> args = new List<object>
                {
                    thietBi.TenThietBi,
                    thietBi.SoLuong,
                    thietBi.TinhTrang,
                    thietBi.NgayMua,
                    thietBi.HanBaoHanh.HasValue ? (object)thietBi.HanBaoHanh.Value : DBNull.Value,
                    string.IsNullOrEmpty(thietBi.LichBaoTri) ? (object)DBNull.Value : thietBi.LichBaoTri,
                    thietBi.MaThietBi
                };
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thiết bị: " + ex.Message);
            }
        }

        // Xóa thiết bị
        public bool XoaThietBi(int maThietBi)
        {
            try
            {
                string sql = "DELETE FROM ThietBi WHERE MaThietBi = @0";
                List<object> args = new List<object> { maThietBi };
                DBUtil.Update(sql, args);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thiết bị: " + ex.Message);
            }
        }

        // Tìm kiếm thiết bị theo tên
        public DataTable TimKiemThietBi(string tenThietBi)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM ThietBi WHERE TenThietBi LIKE @0";
                List<object> args = new List<object> { $"%{tenThietBi}%" };
                using (SqlDataReader reader = DBUtil.Query(sql, args))
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm thiết bị: " + ex.Message);
            }
            return dt;
        }

        // Lấy thiết bị theo mã (nếu cần)
        public ThietBiDTO LayThietBiTheoMa(int maThietBi)
        {
            try
            {
                string sql = "SELECT * FROM ThietBi WHERE MaThietBi = @0";
                List<object> args = new List<object> { maThietBi };
                return DBUtil.Value<ThietBiDTO>(sql, args);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thiết bị theo mã: " + ex.Message);
            }
        }
    }
}
