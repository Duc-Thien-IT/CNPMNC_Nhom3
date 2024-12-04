using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InvoiceDTO
    {
        public string MaHoaDon { get; set; }
        public decimal ThanhTien { get; set; }
        public string NgayThanhToan { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    }

    // DTO for Invoice Item (either an item or a combo)
    public class InvoiceItemDTO
    {
        public string TenLinhKien { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public decimal Tong { get; set; }
    }

    // Combined DTO to encapsulate both Invoice and Items
    public class CombinedInvoiceDTO
    {
        public InvoiceDTO InvoiceDetails { get; set; }
        public List<InvoiceItemDTO> Items { get; set; }  // This will store items (food items and combos)
    }
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal ThanhTien { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }

        // Thêm các trường cho HoaDonSuaChua
        public string LoaiLinhKien { get; set; }
        public string MoTa { get; set; }
        public decimal TongTien { get; set; }

        // Constructor mặc định
        public HoaDonDTO() { }

        // Constructor đầy đủ
        public HoaDonDTO(string maHoaDon, DateTime ngayLap, decimal thanhTien, string phuongThucThanhToan, string maNV, string maKH, string loaiLinhKien, string moTa, decimal tongTien)
        {
            MaHoaDon = maHoaDon;
            NgayLap = ngayLap;
            ThanhTien = thanhTien;
            PhuongThucThanhToan = phuongThucThanhToan;
            MaNV = maNV;
            MaKH = maKH;
            LoaiLinhKien = loaiLinhKien;
            MoTa = moTa;
            TongTien = tongTien;
        }
    }
    public class HoaDonSuaChuaDTO
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public string MoTa { get; set; }
        public decimal TongTien { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }
    }
}
