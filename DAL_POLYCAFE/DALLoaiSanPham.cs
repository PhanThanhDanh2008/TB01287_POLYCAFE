﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_POLYCAFE;

namespace DAL_POLYCAFE
{
    public class DALLoaiSanPham
    {
        public List<LoaiSanPham> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<LoaiSanPham> list = new List<LoaiSanPham>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    LoaiSanPham entity = new LoaiSanPham();
                    entity.MaLoai = reader.GetString(0);
                    entity.TenLoai = reader.GetString(1);
                    entity.GhiChu = reader.GetString(2);
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        public List<LoaiSanPham> selectAll()
        {
            String sql = "SELECT * FROM LoaiSanPham";
            return SelectBySql(sql, new List<object>());
        }

        public string generateMaLoaiSanPham()
        {
            string prefix = "LSP";
            string sql = "SELECT MAX(MaLoai) FROM LoaiSanPham";
            List<object> thamSo = new List<object>();
            object result = DBUtil.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(3);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public void insertLoaiSanPham(LoaiSanPham loaiSP)
        {
            try
            {
                string sql = @"INSERT INTO LoaiSanPham (MaLoai, TenLoai, GhiChu) 
                   VALUES (@0, @1, @2)";
                List<object> thamSo = new List<object>();
                thamSo.Add(loaiSP.MaLoai);
                thamSo.Add(loaiSP.TenLoai);
                thamSo.Add(loaiSP.GhiChu);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateLoaiSanPham(LoaiSanPham loaiSP)
        {
            try
            {
                string sql = @"UPDATE LoaiSanPham 
                   SET TenLoai = @1, GhiChu = @2
                   WHERE MaLoai = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(loaiSP.MaLoai);
                thamSo.Add(loaiSP.TenLoai);
                thamSo.Add(loaiSP.GhiChu);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e) { throw; }
        }

        public void deleteLoaiSanPham(string maLoai)
        {
            try
            {
                string sql = "DELETE FROM LoaiSanPham WHERE MaLoai = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maLoai);
                DBUtil.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public List<LoaiSanPham> SearchLoaiSanPham(string searchText)
        {
            string sql = "SELECT * FROM LoaiSanPham WHERE TenLoai LIKE @0";
            List<object> args = new List<object> { $"%{searchText}%" };
            return SelectBySql(sql, args);
        }
    }
}

