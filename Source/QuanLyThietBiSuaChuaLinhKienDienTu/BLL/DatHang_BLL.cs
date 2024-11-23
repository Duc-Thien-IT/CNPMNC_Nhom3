using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class DatHang_BLL
    {
        private readonly DatHang_DAL dh;
        public DatHang_BLL()
        {
            dh = new DatHang_DAL();
        }

        public DataTable GetAllNhaCungCap()
        {
            return dh.GetAllNhaCungCap();
        }
        public DataTable GetAllPhieuDat()
        {
            return dh.GetAllPhieuDat();
        }
        public DataTable GetAllPhieuDatTheoNgay(DateTime NgayBD, DateTime NgayKT)
        {
            return dh.GetAllPhieuDatTheoNgay(NgayBD, NgayKT);
        }
        public DataTable GetAllChiTietPhieuDat(string MaPhieuDat)
        {
            return dh.GetAllChiTietPhieuDat(MaPhieuDat);
        }
        public DataTable GetAllSanPham(string search)
        {
            return dh.GetAllSanPham(search);
        }

        public string CreateMaPhieuDat()
        {
            return dh.TaoMaPhieuDatMoi();
        }

        public bool AddPhieuDat(string MaDat, string MaNCC, string MaNV)
        {
            if (string.IsNullOrEmpty(MaDat) || string.IsNullOrEmpty(MaNCC) || string.IsNullOrEmpty(MaNV))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return dh.AddPhieuDat(MaDat, MaNCC, MaNV);
        }

        public bool AddChiTietPhieuDat(string MaPhieuDat, string MaSP, int SoLuongDat, decimal DonGia)
        {
            if (string.IsNullOrEmpty(MaPhieuDat) || string.IsNullOrEmpty(MaSP))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return dh.AddChiTietPhieuDat(MaPhieuDat, MaSP, SoLuongDat, DonGia);
        }

        public bool DeletePhieuDat(string MaPD)
        {
            if (string.IsNullOrEmpty(MaPD))
            {
                throw new ArgumentException("Mã phiếu nhập không hợp lệ.");
            }

            return dh.DeletePhieuDatVaChiTiet(MaPD);
        }
        public bool UpdaetThanhTienPhieuDat(string MaPD, decimal thanhTien)
        {
            if (string.IsNullOrEmpty(MaPD))
            {
                throw new ArgumentException("Mã phiếu nhập không hợp lệ.");
            }

            return dh.UpdateThanhTien(MaPD, thanhTien);
        }





    }
}
