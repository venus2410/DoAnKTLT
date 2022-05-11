using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct HangTon
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public int SoLuongTon { get; set; }
        public string HanSD { get; set; }
        public HangTon(string ma,string ten, int sl, string hanSD)
        {
            this.MaMH = ma;
            this.TenMH = ten;
            this.SoLuongTon = sl;
            this.HanSD = hanSD;
        }
    }
}
