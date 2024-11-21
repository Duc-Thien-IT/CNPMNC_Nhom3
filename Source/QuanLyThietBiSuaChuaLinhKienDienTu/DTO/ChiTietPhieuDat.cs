using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuDat
    {
        public string MaPhieuDat { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuongDat { get; set; }
        public decimal Gia { get; set; }
        public decimal TongTien { get; set; }
    }
}
