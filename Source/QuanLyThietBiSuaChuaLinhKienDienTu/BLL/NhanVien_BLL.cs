using System;
using System.Data;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class NhanVien_BLL
    {
        private readonly NhanVien_DAL nhanVienDAL;

        public NhanVien_BLL()
        {
            nhanVienDAL = new NhanVien_DAL();
        }

        public DataTable GetAllNhanVien()
        {
            try
            {
                return nhanVienDAL.getAllNhanVien();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
        }
        public string taoMaTuDong()
        {
            return nhanVienDAL.GetNextEmployeeId();
        }

        public bool AddNhanVien(string tenNV, string email, string sdt, string diaChi, string maTK)
        {
            if (string.IsNullOrWhiteSpace(tenNV))
            {
                throw new ArgumentException("Tên nhân viên không được để trống.");
            }

            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Định dạng email không hợp lệ.");
            }

            if (!IsValidPhoneNumber(sdt))
            {
                throw new ArgumentException("Định dạng số điện thoại không hợp lệ.");
            }

            try
            {
                return nhanVienDAL.AddNhanVien(tenNV, email, sdt, diaChi, maTK);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public bool UpdateNhanVien(string maNV, string tenNV, string email, string sdt, string diaChi, string maTK)
        {
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(tenNV))
            {
                throw new ArgumentException("Mã nhân viên và tên nhân viên không được để trống.");
            }

            if (!IsValidEmail(email))
            {
                throw new ArgumentException("Định dạng email không hợp lệ.");
            }

            if (!IsValidPhoneNumber(sdt))
            {
                throw new ArgumentException("Định dạng số điện thoại không hợp lệ.");
            }

            try
            {
                return nhanVienDAL.UpdateNhanVien(maNV, tenNV, email, sdt, diaChi, maTK);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật nhân viên: " + ex.Message);
            }
        }

        public bool DeleteNhanVien(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
            {
                throw new ArgumentException("Mã nhân viên không được để trống.");
            }

            try
            {
                return nhanVienDAL.DeleteNhanVien(maNV);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }

        public DataTable SearchNhanVien(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                throw new ArgumentException("Từ khóa tìm kiếm không được để trống.");
            }

            try
            {
                return nhanVienDAL.SearchNhanVien(searchTerm);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm nhân viên: " + ex.Message);
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
                return true; // Cho phép số điện thoại trống

            return Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
        }
    }
}

