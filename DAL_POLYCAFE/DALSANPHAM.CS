using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_POLYCAFE;

namespace DAL_POLYCAFE
{
    public class DALSANPHAM
    {
        public List<SanPham> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<SanPham> list = new List<SanPham>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    SanPham entity = new SanPham();
                    entity.MaSanPham = reader.GetString(0);
                    entity.TenSanPham = reader.GetString(1);
                    entity.DonGia = reader.GetDecimal(2);
                    entity.MaLoai = reader.GetString(3);
                    entity.HinhAnh = reader.GetString(4);
                    entity.TrangThai = reader.GetBoolean(5);
                    entity.TenLoai = reader.GetString(6);

                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<SanPham> selectAll(int trangThai = -1)
        {
            //string sql = "SELECT * FROM SanPham";
            string sql = "SELECT MaSanPham, TenSanPham, DonGia, LoaiSanPham.MaLoai, HinhAnh, TrangThai, TenLoai " +
                "FROM SanPham INNER JOIN LoaiSanPham ON SanPham.MaLoai = LoaiSanPham.MaLoai ";
            List<object> p = new List<object>();
            if (trangThai > -1)
            {
                sql += "WHERE SanPham.TrangThai = @0";
            }

            p.Add(trangThai);


            return SelectBySql(sql, p);
        }


        public SanPham selectById(string id)
        {
            String sql = "SELECT * FROM SanPham WHERE MaSanPham=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<SanPham> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertSanPham(SanPham sp)
        {
            try
            {
                string sql = @"INSERT INTO SanPham (MaSanPham, TenSanPham, DonGia, MaLoai, HinhAnh, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamSo = new List<object>();
                thamSo.Add(sp.MaSanPham);
                thamSo.Add(sp.TenSanPham);
                thamSo.Add(sp.DonGia);
                thamSo.Add(sp.MaLoai);
                thamSo.Add(sp.HinhAnh);
                thamSo.Add(sp.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateSanPham(SanPham sp)
        {
            try
            {
                string sql = @"UPDATE SanPham 
                   SET TenSanPham = @1, DonGia = @2, MaLoai = @3, HinhAnh = @4, TrangThai = @5 
                   WHERE MaSanPham = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(sp.MaSanPham);
                thamSo.Add(sp.TenSanPham);
                thamSo.Add(sp.DonGia);
                thamSo.Add(sp.MaLoai);
                thamSo.Add(sp.HinhAnh);
                thamSo.Add(sp.TrangThai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void deleteSanPham(string maSP)
        {
            try
            {
                string sql = "DELETE FROM SanPham WHERE MaSanPham = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maSP);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public string generateMaSanPham()
        {
            string prefix = "SP";
            string sql = "SELECT MAX(MaSanPham) FROM SanPham";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }
        public List<SanPham> TimKiemSanPham(string maSP = "", string tenSP = "", string maLoai = "", int trangThai = -1)
        {
            try
            {
                string sql = @"SELECT MaSanPham, TenSanPham, DonGia, LoaiSanPham.MaLoai, HinhAnh, TrangThai, TenLoai 
                       FROM SanPham 
                       INNER JOIN LoaiSanPham ON SanPham.MaLoai = LoaiSanPham.MaLoai 
                       WHERE 1=1";
                List<object> thamSo = new List<object>();
                int paramIndex = 0;

                // Kết hợp MaSanPham và TenSanPham với điều kiện OR
                if (!string.IsNullOrEmpty(maSP) || !string.IsNullOrEmpty(tenSP))
                {
                    sql += " AND (";
                    bool hasPreviousCondition = false;

                    if (!string.IsNullOrEmpty(maSP))
                    {
                        sql += " MaSanPham = @" + paramIndex;
                        thamSo.Add(maSP);
                        paramIndex++;
                        hasPreviousCondition = true;
                    }

                    if (!string.IsNullOrEmpty(tenSP))
                    {
                        if (hasPreviousCondition)
                            sql += " OR";
                        sql += " TenSanPham LIKE '%' + @" + paramIndex + " + '%'";
                        thamSo.Add(tenSP);
                        paramIndex++;
                    }

                    sql += ")";
                }

                if (!string.IsNullOrEmpty(maLoai))
                {
                    sql += " AND LoaiSanPham.MaLoai = @" + paramIndex;
                    thamSo.Add(maLoai);
                    paramIndex++;
                }

                if (trangThai > -1)
                {
                    sql += " AND TrangThai = @" + paramIndex;
                    thamSo.Add(trangThai);
                    paramIndex++;
                }

                return SelectBySql(sql, thamSo);
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi khi tìm kiếm sản phẩm: " + e.Message);
            }
        }
    }
}
