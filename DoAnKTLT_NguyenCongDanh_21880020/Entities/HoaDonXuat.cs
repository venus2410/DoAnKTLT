using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct HoaDonXuat
    {
        public string MaHDX { get; set;  }
        public List<MatHang> DanhSachHDX { get; set; }
    }
}
