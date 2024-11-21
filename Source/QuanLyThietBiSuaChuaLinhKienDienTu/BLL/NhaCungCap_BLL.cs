using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class NhaCungCap_BLL
    {
        private readonly NhaCungCap_DAL sp;

        public NhaCungCap_BLL()
        {
            sp = new NhaCungCap_DAL();
        }

        public DataTable GetAllSanPham()
        {
            return sp.GetAllSanPham();
        }
        public DataTable GetAllNhaCungCap()
        {
            return sp.GetAllNhaCungCap();
        }
        public bool AddNhaCungCap(string tenNCC, string email, string sdt, string diachi)
        {
            if (string.IsNullOrEmpty(tenNCC))
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return sp.AddNhaCungCap(tenNCC, email, sdt, diachi);
        }

        // Cập nhật sản phẩm
        public bool UpdateNhaCungCap( string maNCC,string tenNCC, string email, string sdt, string diachi)
        {
            if (string.IsNullOrEmpty(tenNCC) )
            {
                throw new ArgumentException("Dữ liệu không hợp lệ.");
            }

            return sp.UpdateNhaCungCap( maNCC,tenNCC,  email, sdt, diachi);
        }


        // Xóa sản phẩm (ẩn sản phẩm bằng cách cập nhật trường Xoa)
        public bool DeleteNhaCungCap(string maNCC)
        {
            if (string.IsNullOrEmpty(maNCC))
            {
                throw new ArgumentException("Mã nhà cung cấp không hợp lệ.");
            }

            return sp.DeleteNhaCungCap(maNCC);
        }

    }
}
