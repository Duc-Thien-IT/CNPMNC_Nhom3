using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }

        // Constructor
        public KhachHangDTO(string maKH, string tenKH)
        {
            MaKH = maKH;
            TenKH = tenKH;
        }
    }
}
