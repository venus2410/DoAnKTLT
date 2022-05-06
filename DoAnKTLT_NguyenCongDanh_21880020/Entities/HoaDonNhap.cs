using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct HoaDonNhap
    {
        public string MaHDN { get; set; }
        public List<MatHang> DanhSachHDN { get; set; }
    }
}
