using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct HoaDonXuat
    {
        public string MaHDX { get; set; }
        public string MatHangXuat { get; set; }
        public int SoLuongXuat { get; set; }
        public HoaDonXuat(string ma, string mh, int sl)
        {
            this.MaHDX = ma;
            this.MatHangXuat = mh;
            this.SoLuongXuat = sl;
        }
    }
}
