using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_POLYCAFE;

namespace DAL_POLYCAFE
{
    public class DALCaTruc
    {
        public List<CaTruc> LayDanhSachCaTruc()
        {
            string sql = "SELECT MaCa, TenCa, ThoiGianBatDau, ThoiGianKetThuc FROM CaTruc";
            var list = new List<CaTruc>();
            using (var reader = DBUtil.Query(sql, new List<object>(), CommandType.Text))
            {
                while (reader.Read())
                {
                    list.Add(new CaTruc 
                    {
                        MaCa = reader["MaCa"].ToString(),
                        TenCa = reader["TenCa"].ToString(),
                        ThoiGianBatDau = (TimeSpan)reader["ThoiGianBatDau"],
                        ThoiGianKetThuc = (TimeSpan)reader["ThoiGianKetThuc"]
                    });
                }
                reader.Close();
            }
            return list;
        }

        public bool ThemCaTruc(CaTruc    ca)
        {
            string sql = "INSERT INTO CaTruc (MaCa, TenCa, ThoiGianBatDau, ThoiGianKetThuc) VALUES (@0, @1, @2, @3)";
            var args = new List<object> { ca.MaCa, ca.TenCa, ca.ThoiGianBatDau, ca.ThoiGianKetThuc };
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

        public bool CapNhatCaTruc(CaTruc         ca)
        {
            string sql = "UPDATE CaTruc SET TenCa=@1, ThoiGianBatDau=@2, ThoiGianKetThuc=@3 WHERE MaCa=@0";
            var args = new List<object> { ca.MaCa, ca.TenCa, ca.ThoiGianBatDau, ca.ThoiGianKetThuc };
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

        public bool XoaCaTruc(string maCa)
        {
            string sql = "DELETE FROM CaTruc WHERE MaCa=@0";
            var args = new List<object> { maCa };
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
        public CaTruc LayCaTrucTheoMa(string maCa)
        {
            string sql = "SELECT MaCa, TenCa, ThoiGianBatDau, ThoiGianKetThuc FROM CaTruc WHERE MaCa=@0";
            var args = new List<object> { maCa };
            try
            {
                return DBUtil.Value<CaTruc>(sql, args, CommandType.Text);
            }
            catch
            {
                return null;
            }
        } 
    }
}
