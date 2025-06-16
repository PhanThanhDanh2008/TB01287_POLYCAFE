using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_POLYCAFE
{
    public class ThietBiDTO
    {
        public int MaThietBi { get; set; } // Mã thiết bị
        public string TenThietBi { get; set; } // Tên thiết bị
        public int SoLuong { get; set; } // Số lượng
        public string TinhTrang { get; set; } // Tình trạng (Hoạt động, Hỏng, Cần bảo trì)
        public DateTime NgayMua { get; set; } // Ngày mua
        public DateTime? HanBaoHanh { get; set; } // Hạn bảo hành (có thể null)
        public string LichBaoTri { get; set; } // Lịch bảo trì (có thể null)
        public DateTime NgayTao { get; set; } // Ngày tạo bản ghi
        public DateTime NgayCapNhat { get; set; } // Ngày cập nhật bản ghi

        public ThietBiDTO()
        {
            // Khởi tạo mặc định
            TinhTrang = "Hoạt động";
            NgayMua = DateTime.Now;
            NgayTao = DateTime.Now;
            NgayCapNhat = DateTime.Now;
        }
    }
}
