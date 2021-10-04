using DTO_QLBH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBH
{
    public class DAL_SanPham : DBConnect
    {
        public DataTable TimKiemSanPham(string tenSP)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimKiemSP";
                cmd.Parameters.AddWithValue("tenSP", tenSP);
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable DanhSachSanPham()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachSP";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool XoaSanPham(int maHang)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_XoaSP";
                cmd.Parameters.AddWithValue("mahang", maHang);
                cmd.Connection = _conn;
                if(cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }    
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool ThemSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThemSP";
                cmd.Parameters.AddWithValue("tenSP",sp.tenHang);
                cmd.Parameters.AddWithValue("SoLuong",sp.soLuong);
                cmd.Parameters.AddWithValue("DonGiaNhap",sp.donGiaNhap);
                cmd.Parameters.AddWithValue("DonGiaBan",sp.donGiaBan);
                cmd.Parameters.AddWithValue("HinhAnh",sp.hinhAnh);
                cmd.Parameters.AddWithValue("GhiChu",sp.ghiChu);
                cmd.Parameters.AddWithValue("email",sp.emailNv);
                cmd.Connection = _conn;
                if(cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }    
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool SuaSanPham(DTO_SanPham sp)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateSP";
                cmd.Parameters.AddWithValue("mahang", sp.maHang);
                cmd.Parameters.AddWithValue("tenSP", sp.tenHang);
                cmd.Parameters.AddWithValue("SoLuong", sp.soLuong);
                cmd.Parameters.AddWithValue("DonGiaNhap", sp.donGiaNhap);
                cmd.Parameters.AddWithValue("DonGiaBan", sp.donGiaBan);
                cmd.Parameters.AddWithValue("HinhAnh", sp.hinhAnh);
                cmd.Parameters.AddWithValue("GhiChu", sp.ghiChu);
                cmd.Parameters.AddWithValue("email", sp.emailNv);
                cmd.Connection = _conn;
                if(cmd.ExecuteNonQuery()>0)
                {
                    return true;
                }    
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable thongKeTon()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeTon";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable thongKeSP()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThongKeSP";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }

    }
}
