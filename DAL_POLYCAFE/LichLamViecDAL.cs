using System;
using System.Collections.Generic;
using System.Data;
using DTO_POLYCAFE;

namespace DAL_POLYCAFE
{
    public class LichLamViecDAL
    {
        public List<lichLamViec> LayDanhSachLichLamViec()
        {
            string sql = "SELECT MaLich, MaNhanVien, MaCa, Ngay FROM LichLamViec";
            var list = new List<lichLamViec>();
            using (var reader = DBUtil.Query(sql, new List<object>(), CommandType.Text))
            {
                while (reader.Read())
                {
                    list.Add(new lichLamViec
                    {
                        MaLich = Convert.ToInt32(reader["MaLich"]),
                        MaNhanVien = reader["MaNhanVien"].ToString(),
                        MaCa = reader["MaCa"].ToString(),
                        Ngay = Convert.ToDateTime(reader["Ngay"])
                    });
                }
                reader.Close();
            }
            return list;
        }

        public bool ThemLichLamViec(lichLamViec lich)
        {
            string sql = "INSERT INTO LichLamViec (MaNhanVien, MaCa, Ngay) VALUES (@0, @1, @2)";
            var args = new List<object> { lich.MaNhanVien, lich.MaCa, lich.Ngay };
            try
            {
                DBUtil.Update(sql, args, CommandType.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatLichLamViec(lichLamViec lich)
        {
            string sql = "UPDATE LichLamViec SET MaNhanVien=@1, MaCa=@2, Ngay=@3 WHERE MaLich=@0";
            var args = new List<object> { lich.MaLich, lich.MaNhanVien, lich.MaCa, lich.Ngay };
            try
            {
                DBUtil.Update(sql, args, CommandType.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaLichLamViec(int maLich)
        {
            string sql = "DELETE FROM LichLamViec WHERE MaLich=@0";
            var args = new List<object> { maLich };
            try
            {
                DBUtil.Update(sql, args, CommandType.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public lichLamViec LayLichLamViecTheoMa(int maLich)
        {
            string sql = "SELECT MaLich, MaNhanVien, MaCa, Ngay FROM LichLamViec WHERE MaLich=@0";
            var args = new List<object> { maLich };
            return DBUtil.Value<lichLamViec>(sql, args, CommandType.Text);
        }
    }
}