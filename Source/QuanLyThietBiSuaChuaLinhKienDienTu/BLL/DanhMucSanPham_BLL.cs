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
    public class DanhMucSanPham_BLL
    {
        private readonly DanhMucSanPham_DAL dal;

        public DanhMucSanPham_BLL()
        {
            dal = new DanhMucSanPham_DAL();
        }

        public DataTable getAllDanhMucSanPham()
        {
            return dal.getAllDanhMucSanPham();
        }

        public bool addDanhMucSanPham(string maDanhMuc, string tenDanhMuc)
        {
            return dal.AddDanhMucSanPham(maDanhMuc, tenDanhMuc);
        }

        public bool UpdateDanhMucSanPham(string maDanhMuc, string tenDanhMuc)
        {
            return dal.UpdateDanhMucSanPham(maDanhMuc, tenDanhMuc);
        }

        public bool DeleteDanhMucSanPham(string maDanhMuc)
        {
            return dal.DeleteDanhMucSanPham(maDanhMuc);
        }

    }
}
