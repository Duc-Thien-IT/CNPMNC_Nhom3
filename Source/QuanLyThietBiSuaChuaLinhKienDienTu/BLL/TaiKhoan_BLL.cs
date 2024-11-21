using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class TaiKhoan_BLL
    {
        private readonly TaiKhoan_DAL taiKhoanDAL;

        public TaiKhoan_BLL()
        {
            taiKhoanDAL = new TaiKhoan_DAL();
        }

        public DataTable GetAllTaiKhoan()
        {
            try
            {
                return taiKhoanDAL.getAllTaiKhoan();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách tài khoản: " + ex.Message);
            }
        }
        public string getNextAccountId()
        {
            return taiKhoanDAL.GetNextAccountId();
        }
        public bool AddTaiKhoan(string tenDangNhap, string matKhau, string quyen)
        {
            

            if (!IsValidPassword(matKhau))
            {
                throw new ArgumentException("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số.");
            }

            try
            {
                return taiKhoanDAL.AddTaiKhoan( tenDangNhap, matKhau, quyen);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài khoản: " + ex.Message);
            }
        }

        public bool UpdateTaiKhoan(string maTK, string tenDangNhap, string matKhau, string quyen)
        {
            if (string.IsNullOrWhiteSpace(maTK) || string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                throw new ArgumentException("Mã tài khoản, tên đăng nhập và mật khẩu không được để trống.");
            }

            if (!IsValidPassword(matKhau))
            {
                throw new ArgumentException("Mật khẩu phải có ít nhất 8 ký tự, bao gồm chữ hoa, chữ thường và số.");
            }

            try
            {
                return taiKhoanDAL.UpdateTaiKhoan(maTK, tenDangNhap, matKhau, quyen);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tài khoản: " + ex.Message);
            }
        }

        public bool DeleteTaiKhoan(string maTK)
        {
            if (string.IsNullOrWhiteSpace(maTK))
            {
                throw new ArgumentException("Mã tài khoản không được để trống.");
            }

            try
            {
                return taiKhoanDAL.DeleteTaiKhoan(maTK);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tài khoản: " + ex.Message);
            }
        }

        public DataTable SearchTaiKhoan(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Từ khóa tìm kiếm không được để trống.");
            }

            try
            {
                return taiKhoanDAL.SearchTaiKhoan(searchTerm);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm tài khoản: " + ex.Message);
            }
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            // Password must be at least 8 characters long and contain uppercase, lowercase, and digit
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }
    }
}

