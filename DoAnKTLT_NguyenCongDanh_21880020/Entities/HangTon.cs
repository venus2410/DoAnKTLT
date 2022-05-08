using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct HangTon
    {
        public string MaMH { get; set; }
        public int SoLuongTon { get; set; }
        public HangTon(string ma, int sl)
        {
            this.MaMH = ma;
            this.SoLuongTon = sl;
        }
    }
}
