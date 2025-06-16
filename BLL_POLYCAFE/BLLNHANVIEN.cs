 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class BLLNHANVIEN
    {
        DAL_NHANVIEN dalNhanVien = new DAL_NHANVIEN();
        public NHANVIEN DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            return dalNhanVien.GetNHANVIEN(username, password);
        }
        public bool ResetMatKhau(string email, string mk)
        {

            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                dalNhanVien.DOIMATKHAU(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<NHANVIEN> GetNhanVienList()
        {
            return dalNhanVien.selectAll();
        }
        public string InsertNhanVien(NHANVIEN nv)
        {
            try
            {
                nv.MaNhanVien = dalNhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNhanVien) || string.IsNullOrEmpty(nv.HoTen) || string.IsNullOrEmpty(nv.Email) || string.IsNullOrEmpty(nv.MatKhau))
                {
                    return "Vui lòng nhập đầy đủ thông tin";
                }
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên khong hop le";
                }
                if (dalNhanVien.CheckEmailExceptId(nv.Email, nv.Email))
                {
                    return "Email đã tồn tại";
                }
                dalNhanVien.insert(nv);
                return string.Empty;

            }
            catch (Exception ex)
            {
                return "Lỗi thêm nhân viên";
            }
        }


        public void UpdateVaiTro(string maNhanVien, bool vaiTro)
        {
            dalNhanVien.updateVaiTro(maNhanVien, vaiTro);
        }

        public void UpdateTrangThai(string maNhanVien, bool trangThai)
        {
            dalNhanVien.updateTrangThai(maNhanVien, trangThai);
        }
        public string UpdateNhanVien(NHANVIEN nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dalNhanVien.update(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string DeleteNhanVien(string maNhanVien)
        {
            try
            {
                if (string.IsNullOrEmpty(maNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                NHANVIEN nv = new NHANVIEN { MaNhanVien = maNhanVien };
                dalNhanVien.delete(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi xóa nhân viên: " + ex.Message;
            }
        }
        public bool CheckEmailExceptId(string email, string maNhanVien)
        {
            return dalNhanVien.CheckEmailExceptId(email, maNhanVien);
        }

        // Tìm kiếm nhân viên theo tên hoặc mã
        public List<NHANVIEN> SearchNhanVien(string keyword)
        {
            try
            {
                return dalNhanVien.SearchByNameOrId(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
            }
        }
    }
}
