using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class BUSThongKe
    {
        DALThongKe dalThongKe = new DALThongKe();

        public List<TKDoanhThuLoaiSP> getThongKeLoaiSP(string loaiSP, DateTime ngayBD, DateTime ngayKt)
        {
            return dalThongKe.GetDoanhThuTheoLoaiSP(loaiSP, ngayBD, ngayKt);

        }

        public List<TKDoanhThuTheoNhanVien> getThongKeNhanVien(string maNV, DateTime ngayBD, DateTime ngayKt)
        {
            return dalThongKe.GetDoanhThuTheoNhanVien(maNV, ngayBD, ngayKt);

        }
    }
}
