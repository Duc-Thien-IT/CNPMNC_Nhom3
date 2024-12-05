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
        public string LayVaiTroNV(string tenDN)
        {
            return nhanVienDAL.LayVaiTroNhanVien(tenDN);
        }
        public string TaoMaTuDong()
        {
            return nhanVienDAL.GetNextEmployeeId();
        }

        public string CheckTenNV(string tenNV)
        {
            if (string.IsNullOrWhiteSpace(tenNV))
            {
                return "Tên nhân viên không được để trống.";
            }
            return "";
        }

        public string CheckEmail(string email)
        {
            if (!IsValidEmail(email))
            {
                return "Định dạng email không hợp lệ.";
            }
            return "";
        }

        public string CheckSDT(string sdt)
        {
            if (!IsValidPhoneNumber(sdt))
            {
                return "Định dạng số điện thoại không hợp lệ.";
            }
            return "";
        }

        public string CheckGioiTinh(string gioiTinh)
        {
            if (!IsValidGender(gioiTinh))
            {
                return "Giới tính không hợp lệ. Chỉ chấp nhận 'Nam' hoặc 'Nữ'.";
            }
            return "";
        }

        public string CheckNgaySinh(DateTime ngaySinh)
        {
            if (!IsOver18(ngaySinh))
            {
                return "Nhân viên phải trên 18 tuổi.";
            }
            return "";
        }

        public bool AddNhanVien(string tenNV, string email, string sdt, string diaChi,  string gioiTinh, DateTime ngaySinh)
        {
            

            try
            {
                return nhanVienDAL.AddNhanVien(tenNV, email, sdt, diaChi, gioiTinh, ngaySinh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public bool UpdateNhanVien(string maNV, string tenNV, string email, string sdt, string diaChi, string maTK, string gioiTinh, DateTime ngaySinh)
        {
            string errorMessage = CheckTenNV(tenNV) + CheckEmail(email) + CheckSDT(sdt) + CheckGioiTinh(gioiTinh) + CheckNgaySinh(ngaySinh);
            if (!string.IsNullOrEmpty(errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

            try
            {
                return nhanVienDAL.UpdateNhanVien(maNV, tenNV, email, sdt, diaChi, maTK, gioiTinh, ngaySinh);
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
        public bool UpdateMaTK(string maNV, string maTK)
        {
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(maTK))
            {
                throw new ArgumentException("Mã nhân viên và mã tài khoản không được để trống.");
            }

            try
            {
                return nhanVienDAL.UpdateMaTK(maNV, maTK);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật mã tài khoản cho nhân viên: " + ex.Message);
            }
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return true; // Cho phép số điện thoại trống

            return Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
        }

        private bool IsValidGender(string gioiTinh)
        {
            return gioiTinh == "Nam" || gioiTinh == "Nữ";
        }
        public bool IsMaTKAssigned(string maTK)
        {
            if (string.IsNullOrWhiteSpace(maTK))
            {
                throw new ArgumentException("Mã tài khoản không được để trống.");
            }

            try
            {
                return nhanVienDAL.IsMaTKAssigned(maTK);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra mã tài khoản: " + ex.Message);
            }
        }

        public string GetCurrentMaTK(string maNV)
        {
            if (string.IsNullOrWhiteSpace(maNV))
            {
                throw new ArgumentException("Mã nhân viên không được để trống.");
            }

            try
            {
                return nhanVienDAL.GetCurrentMaTK(maNV);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy mã tài khoản hiện tại: " + ex.Message);
            }
        }
        private bool IsOver18(DateTime ngaySinh)
        {
            return DateTime.Now.AddYears(-18) >= ngaySinh;
        }
    }
}

