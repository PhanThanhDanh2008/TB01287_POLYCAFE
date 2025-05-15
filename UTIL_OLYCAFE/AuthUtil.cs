using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_POLYCAFE;

namespace UTIL_OLYCAFE
{
    public class AuthUtil
    {
        public static NHANVIEN user = null;
        public static bool IsLogin()
        {
            if (user == null)
            {
                return false;
            }
            if(string.IsNullOrEmpty(user.MaNhanVien))
            {
                return false;
            }
            return true;

        }
    }
}
