using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class LichLamViecBLL
    {
        private LichLamViecDAL dal = new LichLamViecDAL();

        public List<lichLamViec> LayDanhSachLichLamViec()
        {
            return dal.LayDanhSachLichLamViec();
        }

        public bool ThemLichLamViec(lichLamViec lich)
        {
            // Có thể kiểm tra hợp lệ dữ liệu ở đây (nếu cần)
            return dal.ThemLichLamViec(lich);
        }

        public bool CapNhatLichLamViec(lichLamViec lich)
        {
            // Có thể kiểm tra hợp lệ dữ liệu ở đây (nếu cần)
            return dal.CapNhatLichLamViec(lich);
        }

        public bool XoaLichLamViec(int maLich)
        {
            // Có thể kiểm tra ràng buộc xóa ở đây (nếu cần)
            return dal.XoaLichLamViec(maLich);
        }

        public lichLamViec LayLichLamViecTheoMa(int maLich)
        {
            return dal.LayLichLamViecTheoMa(maLich);
        }
    }
}
