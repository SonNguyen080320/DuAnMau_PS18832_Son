using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_QLBH;

namespace DAL_QLBH
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable DanhSachKH()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachKH";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThemKH";
                cmd.Parameters.AddWithValue("SDT", kh.dienThoai);
                cmd.Parameters.AddWithValue("Ten", kh.tenKH);
                cmd.Parameters.AddWithValue("diachi", kh.diaChi);
                cmd.Parameters.AddWithValue("Phai", kh.gioiTinh);
                cmd.Parameters.AddWithValue("email", kh.email);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool XoaKhachHang(string sdt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_XoaKH";
                cmd.Parameters.AddWithValue("Sdt", sdt);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool CapNhatKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdateKH";
                cmd.Parameters.AddWithValue("SDT", kh.dienThoai);
                cmd.Parameters.AddWithValue("Ten", kh.tenKH);
                cmd.Parameters.AddWithValue("diachi", kh.diaChi);
                cmd.Parameters.AddWithValue("Phai", kh.gioiTinh);
                cmd.Parameters.AddWithValue("email", kh.email);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable TimKiemKhachHang(string sdt)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimKiemKH";
                cmd.Parameters.AddWithValue("SDT", sdt);
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
    }
}
