using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class BLLCaTruc
    {
        private DALCaTruc dal = new DALCaTruc();

        public List<CaTruc> LayDanhSachCaTruc()
        {
            return dal.LayDanhSachCaTruc();
        }

        public bool ThemCaTruc(CaTruc ca)
        {
            // Có thể kiểm tra hợp lệ dữ liệu ở đây (nếu cần)
            return dal.ThemCaTruc(ca);
        }

        public bool CapNhatCaTruc(CaTruc ca)
        {
            // Có thể kiểm tra hợp lệ dữ liệu ở đây (nếu cần)
            return dal.CapNhatCaTruc(ca);
        }

        public bool XoaCaTruc(string maCa)
        {
            // Có thể kiểm tra ràng buộc xóa ca ở đây (nếu cần)
            return dal.XoaCaTruc(maCa);
        }

        public CaTruc LayCaTrucTheoMa(string maCa)
        {
            return dal.LayCaTrucTheoMa(maCa);
        }
    }
}
