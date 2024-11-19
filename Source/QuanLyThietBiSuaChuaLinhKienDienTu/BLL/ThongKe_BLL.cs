using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ThongKe_BLL
    {
        private readonly ThongKe_DAL tk;
        public ThongKe_BLL()
        {
            tk = new ThongKe_DAL();
        }
        public List<HoaDonDTO> LayHoaDonTheoThoiGian(DateTime startDate, DateTime endDate, string loaiHoaDon)
        {
            return tk.LayHoaDonTheoThoiGian(startDate, endDate, loaiHoaDon);
        }
        public int LayTongSoDonHang(DateTime startDate, DateTime endDate, string loaiHoaDon)
        {
            return tk.LayTongSoDonHang(startDate, endDate,loaiHoaDon);
        }
        public decimal LayTongDoanhThu(DateTime startDate, DateTime endDate, string loaiHoaDon)
        {
            return tk.LayTongDoanhThu(startDate, endDate, loaiHoaDon);
        }
    }
}
