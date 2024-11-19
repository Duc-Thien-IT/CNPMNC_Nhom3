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
}
