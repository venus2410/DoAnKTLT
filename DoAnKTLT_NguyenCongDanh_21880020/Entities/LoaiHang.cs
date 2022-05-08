using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct LoaiHang
    {
        public string MaLH { get; set; }
        public string TenLH { get; set; }
        public LoaiHang(string ma,string ten)
        {
            this.MaLH = ma;
            this.TenLH = ten;
        }
    }
}
