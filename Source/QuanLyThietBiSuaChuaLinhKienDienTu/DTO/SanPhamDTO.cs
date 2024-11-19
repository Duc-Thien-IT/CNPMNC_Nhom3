using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }       
        public string TenSP { get; set; }    
        public decimal Gia { get; set; }       
        public int SoLuongTon { get; set; }    
        public int ThoiGianBaoHanh { get; set; } 
        public string MaDanhMuc { get; set; }  
        public bool Xoa { get; set; }

        public SanPhamDTO() { }

        public SanPhamDTO(string maSP, string tenSP, decimal gia, int soLuongTon, int thoiGianBaoHanh, string maDanhMuc, bool xoa)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Gia = gia;
            SoLuongTon = soLuongTon;
            ThoiGianBaoHanh = thoiGianBaoHanh;
            MaDanhMuc = maDanhMuc;
            Xoa = xoa;
        }
    }
}
