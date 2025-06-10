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
        public static NHANVIEN user;

        public static bool IsLogin()
        {
            // Implementation for checking login status
            return user != null;
        }

        public static void Logout()
        {
            // Implementation for logging out
            user = null;
        }
    }
}
