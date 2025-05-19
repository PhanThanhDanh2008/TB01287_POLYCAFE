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
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
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
    }
}
