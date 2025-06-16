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
    public class DALPhieuBanHang
    {
        public string generateMaPhieu()
        {
            string prefix = "PBH";
            string sql = "SELECT MAX(MaPhieu) FROM PhieuBanHang";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(3);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public void insertPhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                string sql = @"INSERT INTO PhieuBanHang (MaPhieu, MaThe, MaNhanVien, NgayTao, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>
                {
                    pbh.MaPhieu,
                    pbh.MaThe,
                    pbh.MaNhanVien,
                    pbh.NgayTao,
                    pbh.TrangThai
                };
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateNhanVien(PhieuBanHang pbh)
        {
            try
            {
                string sql = @"UPDATE PhieuBanHang 
                   SET MaThe = @1, MaNhanVien = @2, NgayTao = @3, TrangThai = @4 
                   WHERE MaPhieu = @0";
                List<object> thamSo = new List<object>
                {
                    pbh.MaPhieu,
                    pbh.MaThe,
                    pbh.MaNhanVien,
                    pbh.NgayTao,
                    pbh.TrangThai
                };
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void deletePhieuBanHang(string maPhieu)
        {
            try
            {
                string sql = "DELETE FROM PhieuBanHang WHERE MaPhieu = @0";
                List<object> thamSo = new List<object> { maPhieu };
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public List<PhieuBanHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhieuBanHang> list = new List<PhieuBanHang>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    PhieuBanHang entity = new PhieuBanHang
                    {
                        MaPhieu = reader.GetString(0),
                        MaThe = reader.GetString(1),
                        ChuSoHuu = reader.GetString(2),
                        MaNhanVien = reader.GetString(3),
                        HoTen = reader.GetString(4),
                        NgayTao = reader.GetDateTime(5),
                        TrangThai = reader.GetBoolean(6)
                    };
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<PhieuBanHang> selectAll(string maThe)
        {
            List<object> param = new List<object>();
            string sql = @"SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai 
                           FROM PhieuBanHang phieu 
                           INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien 
                           INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe";
            if (!string.IsNullOrEmpty(maThe))
            {
                sql += " WHERE the.MaThe = @0";
                param.Add(maThe);
            }

            return SelectBySql(sql, param);
        }

        public List<PhieuBanHang> SearchByKeyword(string searchTerm)
        {
            try
            {
                string sql = @"SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai 
                               FROM PhieuBanHang phieu 
                               INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien 
                               INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe 
                               WHERE phieu.MaPhieu LIKE @0 OR phieu.MaThe LIKE @1 OR the.ChuSoHuu LIKE @2";
                List<object> thamSo = new List<object>
                {
                    $"%{searchTerm}%",
                    $"%{searchTerm}%",
                    $"%{searchTerm}%"
                };
                return SelectBySql(sql, thamSo);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn tìm kiếm phiếu bán hàng: " + ex.Message);
            }
        }
    }
}