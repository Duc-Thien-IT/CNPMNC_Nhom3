using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class NhapHang_BLL
    {
        private readonly NhapHang_DAL nh;
        public NhapHang_BLL()
        {
            nh = new NhapHang_DAL();
        }

        public DataTable GetAllNhaCungCap()
        {
            return nh.GetAllNhaCungCap();
        }
        public DataTable GetAllSanPham(string search)
        {
            return nh.GetAllSanPham(search);
        }

        public DataTable GetAllPhieuGiao(string maPD)
        {
            return nh.GetAllPhieuGiao(maPD);
        }

        public decimal GetGiaSanPhamTrongPhieuDat(string MaPhieuDat, string MaSanPham)
        {
            return nh.GetGiaSanPhamTrongPhieuDat(MaPhieuDat, MaSanPham);
        }

        public DataTable GetAllChiTietPhieuGiao(string MaPhieuGiao)
        {
            return nh.GetAllChiTietPhieuGiao(MaPhieuGiao);
        }
        public bool AddPhieuNhap(string MaPN, int LanGiao, string MaPhieuDat, string MaNV)
        {
            if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(MaPhieuDat))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return nh.AddPhieuNhap(MaPN, LanGiao, MaPhieuDat, MaNV);
        }
        public bool UpdateSoLuongTonSanPham(string MaSP, int SoLuonDat)
        {
            if (string.IsNullOrEmpty(MaSP))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return nh.UpdateSoLuongTonSanPham(MaSP, SoLuonDat);
        }

        public bool UpdateThanhTienPhieuGiao(string MaPhieuGiao, decimal ThanhTien)
        {
            if (string.IsNullOrEmpty(MaPhieuGiao))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return nh.UpdateThanhTienPhieuGiao(MaPhieuGiao, ThanhTien);
        }
        public DataTable GetAllPhieuGiaoTheoNgay(DateTime NgayBD, DateTime NgayKT)
        {
            return nh.GetAllPhieuGiaoTheoNgay(NgayBD, NgayKT);
        }

        public bool AddChiTietPhieuNhap(string MaPN, string MaSP, int SoLuongGiao, decimal Gia)
        {
            if (string.IsNullOrEmpty(MaPN) || string.IsNullOrEmpty(MaSP))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return nh.AddChiTietPhieuNhap(MaPN, MaSP, SoLuongGiao, Gia);
        }

        public bool DeletePhieuNhap(string MaPN)
        {
            if (string.IsNullOrEmpty(MaPN))
            {
                throw new ArgumentException("Mã phiếu nhập không hợp lệ.");
            }

            return nh.DeletePhieuGiaoVaChiTiet(MaPN);
        }

    }
}
