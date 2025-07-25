﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_POLYCAFE;
using DTO_POLYCAFE;

namespace BLL_POLYCAFE
{
    public class BLLPhieuBanHang
    {
        DALPhieuBanHang dalPhieuBanHang = new DALPhieuBanHang();

        public List<PhieuBanHang> GetListPhieuBanHang(string maThe)
        {
            return dalPhieuBanHang.selectAll(maThe);
        }

        public List<PhieuBanHang> SearchPhieuBanHang(string keyword)
        {
            try
            {
                return dalPhieuBanHang.SearchByKeyword(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm phiếu bán hàng: " + ex.Message);
            }
        }

        public string InsertPhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                pbh.MaPhieu = dalPhieuBanHang.generateMaPhieu();
                if (string.IsNullOrEmpty(pbh.MaPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.insertPhieuBanHang(pbh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdatePhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                if (string.IsNullOrEmpty(pbh.MaPhieu))
                {
                    return "Mã phiếu không hợp lệ.";
                }

                dalPhieuBanHang.updateNhanVien(pbh);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeletePhieuBanHang(string maPhieu)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.deletePhieuBanHang(maPhieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}