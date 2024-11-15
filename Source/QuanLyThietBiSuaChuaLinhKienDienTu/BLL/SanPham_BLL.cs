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
    public class SanPham_BLL
    {
        private readonly SanPham_DAL sp;

        public SanPham_BLL()
        {
            sp = new SanPham_DAL();
        }

        public DataTable GetAllSanPham()
        {
            return sp.GetAllSanPham(); 
        }

        public bool AddSanPham(string tenSP, decimal gia, int soLuongTon, int thoiGianBaoHanh, string maDanhMuc)
        {
            if (string.IsNullOrEmpty(tenSP) || gia <= 0 || string.IsNullOrEmpty(maDanhMuc))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return sp.AddSanPham(tenSP, gia, soLuongTon, thoiGianBaoHanh, maDanhMuc);
        }

        // Cập nhật sản phẩm
        public bool UpdateSanPham(string maSP, string tenSP, decimal gia, int soLuongTon, int thoiGianBaoHanh, string maDanhMuc)
        {
            if (string.IsNullOrEmpty(tenSP) || gia <= 0 || string.IsNullOrEmpty(maDanhMuc))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return sp.UpdateSanPham(maSP, tenSP, gia, soLuongTon, thoiGianBaoHanh, maDanhMuc);
        }


        // Xóa sản phẩm (ẩn sản phẩm bằng cách cập nhật trường Xoa)
        public bool DeleteSanPham(string maSP)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");
            }

            return sp.DeleteSanPham(maSP);
        }

        // Tìm kiếm sản phẩm theo tên
        public DataTable SearchSanPham(string tenSP)
        {
            if (string.IsNullOrEmpty(tenSP))
            {
                throw new ArgumentException("Tên sản phẩm không hợp lệ.");
            }

            return sp.SearchSanPham(tenSP);
        }

        //Get danh mục sản phẩm
        public DataTable GetAllDanhMuc()
        {
            return sp.GetAllDanhMuc();
        }

        // Lấy chi tiết sản phẩm theo mã
        public DataTable GetSanPhamByMaSP(string maSP)
        {
            if (string.IsNullOrEmpty(maSP))
            {
                throw new ArgumentException("Mã sản phẩm không hợp lệ.");
            }

            return sp.GetSanPhamByMaSP(maSP);
        }


    }
}
