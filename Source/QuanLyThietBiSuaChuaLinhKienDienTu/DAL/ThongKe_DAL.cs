using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DAL
{
    public class ThongKe_DAL
    {
        private ConnectDB db = new ConnectDB();

        // Phương thức lấy hóa đơn theo thời gian và loại hóa đơn
        public List<HoaDonDTO> LayHoaDonTheoThoiGian(DateTime startDate, DateTime endDate, string loaiHoaDon)
        {
            List<HoaDonDTO> danhSachHoaDon = new List<HoaDonDTO>();

            string query = "";

            // Kiểm tra loại hóa đơn và chọn bảng tương ứng
            if (loaiHoaDon == "HoaDon")
            {
                query = "SELECT MaHoaDon, NgayLap, ThanhTien, PhuongThucThanhToan, MaNV, MaKH FROM HoaDon WHERE NgayLap >= @StartDate AND NgayLap <= @EndDate";
            }
            else if (loaiHoaDon == "SuaChua")
            {
                query = "SELECT MaHD AS MaHoaDon, NgayLap, TongTien AS ThanhTien, PhuongThucThanhToan, MaNV, MaKH FROM HoaDonSuaChua WHERE NgayLap >= @StartDate AND NgayLap <= @EndDate";
            }
            else if (loaiHoaDon == "DoiTra")
            {
                query = "SELECT MaHD AS MaHoaDon, NgayLap, TongTien AS ThanhTien, PhuongThucThanhToan, MaNV, MaKH FROM HoaDonSuaChua WHERE NgayLap >= @StartDate AND NgayLap <= @EndDate";
                // Thêm logic cho loại hóa đơn đổi trả nếu cần
            }

            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HoaDonDTO hoaDon = new HoaDonDTO
                            {
                                MaHoaDon = reader["MaHoaDon"].ToString(),
                                NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                                ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
                                PhuongThucThanhToan = reader["PhuongThucThanhToan"].ToString(),
                                MaNV = reader["MaNV"].ToString(),
                                MaKH = reader["MaKH"].ToString()
                            };

                            danhSachHoaDon.Add(hoaDon);
                        }
                    }
                }
            }

            return danhSachHoaDon;
        }
        public int LayTongSoDonHang(DateTime startDate, DateTime endDate, string loaiHoaDon)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "";

                if (loaiHoaDon == "SuaChua"|| loaiHoaDon == "DoiTra")
                {
                    query = "SELECT COUNT(*) FROM HoaDonSuaChua WHERE NgayLap BETWEEN @StartDate AND @EndDate";
                }
                else
                {
                    query = "SELECT COUNT(*) FROM HoaDon WHERE NgayLap BETWEEN @StartDate AND @EndDate";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        public decimal LayTongDoanhThu(DateTime startDate, DateTime endDate, string loaiHoaDon)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "";

                if (loaiHoaDon == "SuaChua" || loaiHoaDon == "DoiTra")
                {
                    query = "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDonSuaChua WHERE NgayLap BETWEEN @StartDate AND @EndDate";
                }
                else
                {
                    query = "SELECT ISNULL(SUM(ThanhTien), 0) FROM HoaDon WHERE NgayLap BETWEEN @StartDate AND @EndDate";
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

    }
}
