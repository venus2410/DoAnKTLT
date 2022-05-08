using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct HoaDonNhap
    {
        public string MaHDN { get; set; }
        public string MatHangNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public HoaDonNhap(string ma, string mh,int sl)
        {
            this.MaHDN = ma;
            this.MatHangNhap = mh;
            this.SoLuongNhap = sl;
        }
    }
}
