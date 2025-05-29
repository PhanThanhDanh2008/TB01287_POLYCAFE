using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class BLLsanpham
    {
        DALSANPHAM dalSanpham = new DALSANPHAM();
        public List<SanPham> GetSanPhamList(int trangThai = -1)
        {
            return dalSanpham.selectAll(trangThai);
        }


        public string InsertSanPham(SanPham sp)
        {
            try
            {
                sp.MaSanPham = dalSanpham.generateMaSanPham();
                if (string.IsNullOrEmpty(sp.MaSanPham))
                {
                    return "Mã sản phẩm không hợp lệ.";
                }

                dalSanpham.insertSanPham(sp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateSanPham(SanPham sp)
        {
            try
            {
                if (string.IsNullOrEmpty(sp.MaSanPham))
                {
                    return "Mã sản phẩm không hợp lệ.";
                }

                if (sp.HinhAnh == null)
                {
                    sp.HinhAnh = "";
                }

                dalSanpham.updateSanPham(sp);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteSanPham(string maSP)
        {
            try
            {
                if (string.IsNullOrEmpty(maSP))
                {
                    return "Mã sản phẩm không hợp lệ.";
                }

                dalSanpham.deleteSanPham(maSP);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
