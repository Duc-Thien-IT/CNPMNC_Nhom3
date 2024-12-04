using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BanHang_BLL
    {
        private readonly BanHang_DAL banHangDAL;

        // Constructor
        public BanHang_BLL()
        {
            banHangDAL = new BanHang_DAL();  // Khởi tạo đối tượng DAL
        }

        // Phương thức tìm kiếm sản phẩm theo tên
        public DataTable TimKiemSanPhamTheoTen(string tenSP)
        {
            return banHangDAL.TimKiemSanPhamTheoTen(tenSP);
        }
        public List<KhachHangDTO> LayDanhSachKhachHang()
        {
            return banHangDAL.LayDanhSachKhachHang();
        }
        public string TaoMaHoaDonMoi()
        {
            return banHangDAL.TaoMaHoaDonMoi();
        }
        public bool LuuHoaDon(string maHoaDon, DateTime ngayLap, decimal thanhTien, string phuongThucThanhToan, string maNV, string maKH)
        {
            return banHangDAL.LuuHoaDon(maHoaDon, ngayLap, thanhTien, phuongThucThanhToan, maNV, maKH);
        }
        public bool LuuChiTietHoaDon(string maSP, string maHD, int soLuong, decimal tongTien)
        {
            return banHangDAL.LuuChiTietHoaDon(maSP, maHD, soLuong, tongTien);
        }
        public bool CapNhatSoLuongKho(string maSP, int soLuongDaBan)
        {
            return banHangDAL.CapNhatSoLuongKho(maSP, soLuongDaBan);
        }
        public DataTable LoadDanhSachHoaDon()
        {
            return banHangDAL.LoadDanhSachHoaDon();
        }
        public CombinedInvoiceDTO GetInvoiceDetails(string invoiceID)
        {
            return banHangDAL.GetInvoiceDetails(invoiceID);
        }
        public HoaDonSuaChuaDTO LayThongTinHoaDonSuaChua(string maHD)
        {
            return banHangDAL.LayThongTinHoaDonSuaChua(maHD);
        }
    }
}
