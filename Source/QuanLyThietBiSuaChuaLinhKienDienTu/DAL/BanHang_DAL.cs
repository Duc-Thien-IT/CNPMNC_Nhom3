using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
	public class BanHang_DAL
	{
		private readonly ConnectDB db;

		// Constructor
		public BanHang_DAL()
		{
			db = new ConnectDB();
		}
		public string LayMaHoaDonMoiNhat()
		{
			string maHoaDonMoiNhat = null;

			using (SqlConnection conn = db.GetConnection())
			{
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}

				string query = "SELECT TOP 1 MaHoaDon FROM HoaDon ORDER BY NgayLap DESC";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					object result = cmd.ExecuteScalar();
					if (result != null)
					{
						maHoaDonMoiNhat = result.ToString();
					}
				}
			}

			return maHoaDonMoiNhat;
		}

		public DataTable TimKiemSanPhamTheoTen(string tenSP)
		{
			DataTable dtSanPham = new DataTable();

			using (SqlConnection conn = db.GetConnection())
			{
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}
				string query = "SELECT MaSP, TenSP, Gia, SoLuongTon, ThoiGianBaoHanh FROM SanPham WHERE TenSP LIKE @TenSP AND Xoa = 1";

				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@TenSP", "%" + tenSP + "%");

					using (SqlDataReader reader = command.ExecuteReader())
					{
						dtSanPham.Load(reader); // Nạp dữ liệu từ SqlDataReader vào DataTable
					}
				}
			}

			return dtSanPham;
		}
		public List<KhachHangDTO> LayDanhSachKhachHang()
		{
			List<KhachHangDTO> danhSachKhachHang = new List<KhachHangDTO>();

			using (SqlConnection conn = db.GetConnection())
			{
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}
				string query = "SELECT MaKH, TenKH, SDT FROM KhachHang WHERE Xoa = 1";

				using (SqlCommand command = new SqlCommand(query, conn))
				{

					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							KhachHangDTO khachHang = new KhachHangDTO(
								reader["MaKH"].ToString(),
								reader["TenKH"].ToString(),
								reader["SDT"].ToString()

							);
							danhSachKhachHang.Add(khachHang);
						}
					}
				}
			}

			return danhSachKhachHang;
		}

		public string TaoMaHoaDonMoi()
		{

			// Tiền tố cho mã hóa đơn
			string maHoaDonPrefix = "HD";

			// Lấy số thứ tự mã hóa đơn mới nhất từ cơ sở dữ liệu
			string query = "SELECT TOP 1 MaHoaDon FROM HoaDon WHERE MaHoaDon LIKE @MaHoaDonPrefix ORDER BY MaHoaDon DESC";

			using (SqlConnection conn = db.GetConnection())
			{
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}
				try
				{
					using (SqlCommand command = new SqlCommand(query, conn))
					{
						command.Parameters.AddWithValue("@MaHoaDonPrefix", maHoaDonPrefix + "%");

						var result = command.ExecuteScalar();

						// Nếu không có mã hóa đơn nào, bắt đầu từ 001
						if (result == null)
						{
							return maHoaDonPrefix + "001";
						}
						else
						{
							// Lấy số thứ tự từ mã hóa đơn mới nhất
							string maHoaDonMoi = result.ToString();
							string soThuTuCu = maHoaDonMoi.Substring(maHoaDonPrefix.Length);

							// Tăng số thứ tự lên 1
							int soThuTuMoi = int.Parse(soThuTuCu) + 1;

							// Đảm bảo số thứ tự có 3 chữ số
							string soThuTuMoiString = soThuTuMoi.ToString("D3");

							// Trả về mã hóa đơn mới
							return maHoaDonPrefix + soThuTuMoiString;
						}
					}
				}
				catch (Exception ex)
				{
					// Xử lý lỗi nếu có
					MessageBox.Show("Lỗi khi tạo mã hóa đơn: " + ex.Message);
					return null;
				}
			}
		}

		// Lưu hóa đơn vào bảng HoaDon
		public bool LuuHoaDon(string maHoaDon, DateTime ngayLap, decimal thanhTien, string phuongThucThanhToan, string maNV, string maKH)
		{
			using (SqlConnection conn = db.GetConnection())
			{
				// Nếu GetConnection không mở tự động, thêm dòng sau:
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}
				string query = "INSERT INTO HoaDon (MaHoaDon, NgayLap, ThanhTien, PhuongThucThanhToan, MaNV, MaKH) " +
							   "VALUES (@MaHoaDon, @NgayLap, @ThanhTien, @PhuongThucThanhToan, @MaNV, @MaKH)";

				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
					command.Parameters.AddWithValue("@NgayLap", ngayLap);
					command.Parameters.AddWithValue("@ThanhTien", thanhTien);
					command.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
					command.Parameters.AddWithValue("@MaNV", maNV);
					command.Parameters.AddWithValue("@MaKH", maKH);
					int result = command.ExecuteNonQuery();
					return result > 0; // Nếu insert thành công, trả về true
				}
			}
		}

		// Lưu chi tiết hóa đơn vào bảng ChiTietHoaDon
		public bool LuuChiTietHoaDon(string maSP, string maHD, int soLuong, decimal tongTien)
		{
			using (SqlConnection conn = db.GetConnection())
			{
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}
				string query = "INSERT INTO ChiTietHoaDon (MaSP, MaHoaDon, SoLuong, TongTien) " +
							   "VALUES (@MaSP, @MaHoaDon, @SoLuong, @TongTien)";

				using (SqlCommand command = new SqlCommand(query, conn))
				{
					command.Parameters.AddWithValue("@MaSP", maSP);
					command.Parameters.AddWithValue("@MaHoaDon", maHD);
					command.Parameters.AddWithValue("@SoLuong", soLuong);
					command.Parameters.AddWithValue("@TongTien", tongTien);

					int result = command.ExecuteNonQuery();
					return result > 0; // Nếu insert thành công, trả về true
				}
			}
		}
		public bool CapNhatSoLuongKho(string maSP, int soLuongDaBan)
		{
			try
			{
				// Tạo kết nối từ ConnectDB
				ConnectDB connectDB = new ConnectDB();
				using (SqlConnection connection = connectDB.GetConnection())
				{
					// Kiểm tra kết nối trước khi thực hiện truy vấn
					if (connection.State != System.Data.ConnectionState.Open)
					{
						connection.Open();
					}

					// Trước khi trừ số lượng, kiểm tra xem số lượng tồn có đủ để trừ không
					string checkQuery = "SELECT SoLuongTon FROM SanPham WHERE MaSP = @MaSP";
					using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
					{
						checkCmd.Parameters.AddWithValue("@MaSP", maSP);
						var result = checkCmd.ExecuteScalar();
						if (result != null && Convert.ToInt32(result) < soLuongDaBan)
						{
							MessageBox.Show("Không đủ số lượng trong kho để thực hiện giao dịch.");
							return false;
						}
					}

					// Giảm số lượng sản phẩm trong kho
					string query = "UPDATE SanPham SET SoLuongTon = SoLuongTon - @SoLuongDaBan WHERE MaSP = @MaSP";

					using (SqlCommand cmd = new SqlCommand(query, connection))
					{
						cmd.Parameters.AddWithValue("@SoLuongDaBan", soLuongDaBan);
						cmd.Parameters.AddWithValue("@MaSP", maSP);

						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0; // Nếu cập nhật thành công
					}
				}
			}
			catch (Exception ex)
			{
				// Xử lý lỗi nếu có
				MessageBox.Show("Lỗi: " + ex.Message);
				return false;
			}
		}
		public DataTable LoadDanhSachHoaDon()
		{
			try
			{
				using (SqlConnection conn = db.GetConnection())
				{
					string query = @"SELECT MaHoaDon FROM HoaDon";
					SqlCommand cmd = new SqlCommand(query, conn);

					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);

					return dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tải danh sách hóa đơn: " + ex.Message);
				return null;
			}
		}
		public CombinedInvoiceDTO GetInvoiceDetails(string invoiceID)
		{
			CombinedInvoiceDTO combinedInvoice = new CombinedInvoiceDTO();
			combinedInvoice.Items = new List<InvoiceItemDTO>();

			using (SqlConnection conn = db.GetConnection())
			{
				try
				{
					conn.Open();
					// Lấy thông tin hóa đơn
					string queryInvoice = @"SELECT hd.MaHoaDon, hd.ThanhTien, hd.NgayLap AS NgayThanhToan, nv.TenNV AS TenNhanVien,
                                           kh.TenKH AS TenKhachHang, kh.DiaChi, kh.SDT
                                    FROM HoaDon hd
                                    JOIN KhachHang kh ON hd.MaKH = kh.MaKH
									JOIN NhanVien nv ON hd.MaNV = nv.MaNV
                                    WHERE hd.MaHoaDon = @MaHoaDon";

					using (SqlCommand cmdInvoice = new SqlCommand(queryInvoice, conn))
					{
						cmdInvoice.Parameters.AddWithValue("@MaHoaDon", invoiceID);

						using (SqlDataReader reader = cmdInvoice.ExecuteReader())
						{
							if (reader.Read())
							{
								combinedInvoice.InvoiceDetails = new InvoiceDTO
								{
									MaHoaDon = reader["MaHoaDon"].ToString(),
									ThanhTien = Convert.ToDecimal(reader["ThanhTien"]),
									NgayThanhToan = reader["NgayThanhToan"].ToString(),
									TenKhachHang = reader["TenKhachHang"].ToString(),
									TenNhanVien = reader["TenNhanVien"].ToString(),
									DiaChi = reader["DiaChi"].ToString(),
									SDT = reader["SDT"].ToString()
								};
							}
						}
					}

					// Lấy chi tiết các sản phẩm trong hóa đơn
					string queryItems = @"SELECT sp.TenSP AS TenLinhKien, cthd.SoLuong, sp.Gia, 
                                         (cthd.SoLuong * sp.Gia) AS Tong
                                  FROM ChiTietHoaDon cthd
                                  JOIN SanPham sp ON cthd.MaSP = sp.MaSP
                                  WHERE cthd.MaHoaDon = @MaHoaDon";

					using (SqlCommand cmdItems = new SqlCommand(queryItems, conn))
					{
						cmdItems.Parameters.AddWithValue("@MaHoaDon", invoiceID);

						using (SqlDataReader reader = cmdItems.ExecuteReader())
						{
							while (reader.Read())
							{
								InvoiceItemDTO item = new InvoiceItemDTO
								{
									TenLinhKien = reader["TenLinhKien"].ToString(),
									SoLuong = Convert.ToInt32(reader["SoLuong"]),
									Gia = Convert.ToDecimal(reader["Gia"]),
									Tong = Convert.ToDecimal(reader["Tong"])
								};

								combinedInvoice.Items.Add(item);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi lấy thông tin hóa đơn: " + ex.Message);
				}
			}

			return combinedInvoice;
		}
		public HoaDonSuaChuaDTO LayThongTinHoaDonSuaChua(string maHD)
		{
			HoaDonSuaChuaDTO hoaDonSuaChua = null;

			using (SqlConnection conn = db.GetConnection())
			{
				if (conn.State != System.Data.ConnectionState.Open)
				{
					conn.Open();
				}

				string query = @"
                    SELECT 
                        h.MaHD AS MaHoaDon,
                        h.NgayLap,
                        h.MoTa,
                        h.TongTien,
                        h.PhuongThucThanhToan,
                        k.TenKH AS TenKhachHang,
                        nv.TenNV AS TenNhanVien
                    FROM HoaDonSuaChua h
                    JOIN KhachHang k ON h.MaKH = k.MaKH
                    JOIN NhanVien nv ON h.MaNV = nv.MaNV
                    WHERE h.MaHD = @MaHD";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@MaHD", maHD);

					using (SqlDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							hoaDonSuaChua = new HoaDonSuaChuaDTO
							{
								MaHoaDon = reader["MaHoaDon"].ToString(),
								NgayLap = Convert.ToDateTime(reader["NgayLap"]),
								MoTa = reader["MoTa"].ToString(),
								TongTien = Convert.ToDecimal(reader["TongTien"]),
								PhuongThucThanhToan = reader["PhuongThucThanhToan"].ToString(),
								TenKhachHang = reader["TenKhachHang"].ToString(),
								TenNhanVien = reader["TenNhanVien"].ToString()
							};
						}
					}
				}
			}

			return hoaDonSuaChua;
		}
	}
}