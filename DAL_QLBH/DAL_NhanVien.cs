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
    public class DAL_NhanVien : DBConnect
    {
        public bool NhanVienDangNhap(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DangNhap";
                cmd.Parameters.AddWithValue("user", nv.email);
                cmd.Parameters.AddWithValue("pass", nv.matKhau);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch (Exception n)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool KiemTraEmail(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_KiemTraEmail";
                cmd.Parameters.AddWithValue("email", email);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }
        public bool TaoMatKhau(string email, string matkhau)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TaoMatKhau";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("matkhau", matkhau);
                if (Convert.ToInt16(cmd.ExecuteScalar()) > 0)
                    return true;
            }
            catch { }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable VaiTroNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_VaiTroNV";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool UpdateMatKhau(string email, string MatKhauCu, string MatKhauMoi, string XacNhanMatKhau)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DoiMatKhau";
                cmd.Parameters.AddWithValue("Email", email);
                cmd.Parameters.AddWithValue("MatKhauCu", MatKhauCu);
                cmd.Parameters.AddWithValue("MatKhauMoi", MatKhauMoi);
                cmd.Parameters.AddWithValue("XacNhanMatKhau", XacNhanMatKhau);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable DanhSachNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DanhSachNV";
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public DataTable TimKiemNhanVien(string tenNV)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TimKiemNV";
                cmd.Parameters.AddWithValue("tenNV", tenNV);
                cmd.Connection = _conn;
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            finally { _conn.Close(); }
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ThemNV";
                cmd.Parameters.AddWithValue("Email", nv.email);
                cmd.Parameters.AddWithValue("TenNV", nv.tenNV);
                cmd.Parameters.AddWithValue("Diachi", nv.diaChi);
                cmd.Parameters.AddWithValue("vaitro", nv.vaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nv.tinhTrang);
                cmd.Parameters.AddWithValue("phai", nv.gioiTinh);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            finally { _conn.Close(); }
            return false;
        }
        public bool XoaNhanVien(string email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_XoaNV";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_UpdateNV";
                cmd.Parameters.AddWithValue("Email", nv.email);
                cmd.Parameters.AddWithValue("TenNV", nv.tenNV);
                cmd.Parameters.AddWithValue("Diachi", nv.diaChi);
                cmd.Parameters.AddWithValue("vaitro", nv.vaiTro);
                cmd.Parameters.AddWithValue("tinhtrang", nv.tinhTrang);
                cmd.Parameters.AddWithValue("phai", nv.gioiTinh);
                cmd.Connection = _conn;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool KiemTraMatKhau(String email)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_KiemTraMk";
                cmd.Parameters.AddWithValue("email", email);
                cmd.Connection = _conn;
                if(Convert.ToInt32(cmd.ExecuteScalar())>0)
                {
                    return true;
                }    
            }
            finally { _conn.Close(); }
            return false;
        }
    }
}
