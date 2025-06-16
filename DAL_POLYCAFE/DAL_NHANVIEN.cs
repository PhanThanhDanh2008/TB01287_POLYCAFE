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
    public class DAL_NHANVIEN
    {
        public NHANVIEN GetNHANVIEN(string email, string password)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE Email = @0 AND MatKhau = @1";
            List<object> thamso = new List<object>();
            thamso.Add(email);
            thamso.Add(password);
            NHANVIEN nv = DBUtil.Value<NHANVIEN>(sql, thamso);
            return nv;

        }
        public void DOIMATKHAU(string mk, string email)
        {
            try
            {
                string sql = "UPDATE NhanVien SET MatKhau = @0 WHERE Email = @1";
                List<object> thamso = new List<object>();
                thamso.Add(mk);
                thamso.Add(email);
                DBUtil.Update(sql, thamso);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insert(NHANVIEN nv)
        {
            try
            {
                string sql = "INSERT INTO NHANVIEN (MaNhanVien, HoTen, Email, MatKhau, VaiTro, TrangThai) VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamso = new List<object>();
                thamso.Add(nv.MaNhanVien);
                thamso.Add(nv.HoTen);
                thamso.Add(nv.Email);
                thamso.Add(nv.MatKhau);
                thamso.Add(nv.VaiTro);
                thamso.Add(nv.TrangThai);
                DBUtil.Update(sql, thamso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void update(NHANVIEN nv)
        {
            try
            {
                string sql = "UPDATE NHANVIEN SET HoTen = @0, Email = @1, MatKhau = @2, VaiTro = @3, TrangThai = @4 WHERE MaNhanVien = @5";
                List<object> thamso = new List<object>();
                thamso.Add(nv.HoTen);      // @0
                thamso.Add(nv.Email);      // @1
                thamso.Add(nv.MatKhau);    // @2
                thamso.Add(nv.VaiTro);     // @3
                thamso.Add(nv.TrangThai);  // @4
                thamso.Add(nv.MaNhanVien); // @5

                // Thêm log để kiểm tra (tùy chọn, dùng Console.WriteLine hoặc log file)
                Console.WriteLine($"Updating VaiTro: {nv.VaiTro}, TrangThai: {nv.TrangThai} for MaNhanVien: {nv.MaNhanVien}");
                DBUtil.Update(sql, thamso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void delete(NHANVIEN nv)
        {
            try
            {
                string sql = "DELETE FROM NHANVIEN WHERE MaNhanVien = @0";
                List<object> thamso = new List<object>();
                thamso.Add(nv.MaNhanVien);
                DBUtil.Update(sql, thamso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<NHANVIEN> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    NHANVIEN entity = new NHANVIEN();
                    entity.MaNhanVien = reader.GetString(0);
                    entity.HoTen = reader.GetString(1);
                    entity.Email = reader.GetString(2);
                    entity.MatKhau = reader.GetString(3);
                    entity.VaiTro = reader.GetBoolean(4);
                    entity.TrangThai = reader.GetBoolean(5);

                    //entity.MaNhanVien = reader["MaNhanVien"].ToString();
                    //entity.HoTen = reader["HoTen"].ToString();
                    //entity.Email = reader["Email"].ToString();
                    //entity.MatKhau = reader["MatKhau"].ToString();
                    //entity.VaiTro= bool.Parse(reader["VaiTro"].ToString());
                    //entity.TrangThai = bool.Parse(reader["TrangThai"].ToString());
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<NHANVIEN> selectAll()
        {
            string sql = "SELECT * FROM NhanVien";
            return selectBySql(sql, new List<object>());
        }

        public NHANVIEN selectById(string id)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNhanVien = @0";
            List<object> thamso = new List<object>();
            thamso.Add(id);
            List<NHANVIEN> list = selectBySql(sql, thamso);
            return list.Count > 0 ? list[0] : null;
        }
        public string generateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MAX(MaNhanVien) FROM NhanVien";
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
        public bool CheckEmailExceptId(string email, string maNhanVien)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0 AND MaNhanVien != @1";
            List<object> thamso = new List<object>();
            thamso.Add(email);
            thamso.Add(maNhanVien);
            object result = DBUtil.ScalarQuery(sql, thamso);
            return Convert.ToInt32(result) > 0;
        }
        public void updateVaiTro(string maNhanVien, bool vaiTro)
        {
            string sql = "UPDATE NhanVien SET VaiTro = @0 WHERE MaNhanVien = @1";
            List<object> thamSo = new List<object>();
            thamSo.Add(vaiTro);
            thamSo.Add(maNhanVien);
            DBUtil.Update(sql, thamSo);
        }

        public void updateTrangThai(string maNhanVien, bool trangThai)
        {
            string sql = "UPDATE NhanVien SET TrangThai = @0 WHERE MaNhanVien = @1";
            List<object> thamSo = new List<object>();
            thamSo.Add(trangThai);
            thamSo.Add(maNhanVien);
            DBUtil.Update(sql, thamSo);
        }
        // tìm kiếm nhân viên theo tên hoặc mã 
        public List<NHANVIEN> SearchByNameOrId(string searchTerm)
        {
            try
            {
                string sql = "SELECT * FROM NhanVien WHERE MaNhanVien LIKE @0 OR HoTen LIKE @1 OR Email LIKE @2";
                List<object> thamSo = new List<object>
        {
            $"%{searchTerm}%",
            $"%{searchTerm}%",
            $"%{searchTerm}%"
        };
                return selectBySql(sql, thamSo);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn tìm kiếm nhân viên: " + ex.Message);
            }
        }


    }
}

