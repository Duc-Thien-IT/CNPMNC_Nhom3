using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class KhachHang_BLL
    {
        private readonly KhachHang_DAL khachHangDAL;

        public KhachHang_BLL()
        {
            khachHangDAL = new KhachHang_DAL();
        }

        public DataTable GetAllKhachHang()
        {
            try
            {
                return khachHangDAL.getAllKhachHang();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách khách hàng: " + ex.Message);
            }
        }
        public string GetNextCustomerId() { return khachHangDAL.GetNextCustomerId(); }
        public bool AddKhachHang(string maKH, string tenKH,  string sdt, string diaChi)
        {
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(tenKH))
            {
                throw new ArgumentException("Mã khách hàng và tên khách hàng không được để trống.");
            }

           

            if (!IsValidPhoneNumber(sdt))
            {
                throw new ArgumentException("Định dạng số điện thoại không hợp lệ.");
            }

            try
            {
                
                return khachHangDAL.AddKhachHang( tenKH,  sdt, diaChi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        public bool UpdateKhachHang(string maKH, string tenKH,  string sdt, string diaChi)
        {
            if (string.IsNullOrWhiteSpace(maKH) || string.IsNullOrWhiteSpace(tenKH))
            {
                throw new ArgumentException("Mã khách hàng và tên khách hàng không được để trống.");
            }

           

            if (!IsValidPhoneNumber(sdt))
            {
                throw new ArgumentException("Định dạng số điện thoại không hợp lệ.");
            }

            try
            {
                
                return khachHangDAL.UpdateKhachHang(maKH, tenKH,  sdt, diaChi);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật khách hàng: " + ex.Message);
            }
        }

        public bool DeleteKhachHang(string maKH)
        {
            if (string.IsNullOrWhiteSpace(maKH))
            {
                throw new ArgumentException("Vui lòng chọn khách hàng cần xoá.");
            }

            try
            {
                return khachHangDAL.DeleteKhachHang(maKH);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        public DataTable SearchKhachHang(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Từ khóa tìm kiếm không được để trống.");
            }

            try
            {
                return khachHangDAL.SearchKhachHang(searchTerm);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return true; // Cho phép email trống

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return true;

            return Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
        }
        public bool IsExistPhoneNumber(string phoneNumber)
        {
            return khachHangDAL.CheckSDTExists(phoneNumber);
        }
    }
}
