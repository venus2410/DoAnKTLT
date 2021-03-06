using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnKTLT_NguyenCongDanh_21880020.Entities
{
    public struct MatHang
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string HanDungMH { get; set; } 
        public string CongTySX { get; set; }
        public string NgaySX { get; set; }
        public string Loai { get; set; }
        public int Gia { get; set; }
        public MatHang(string ma,string ten,string hanDung,string ctySX,string ngaySX, string loai, int gia)
        {
            this.MaMH = ma;
            this.TenMH = ten;
            this.HanDungMH = hanDung;
            this.CongTySX = ctySX;
            this.NgaySX = ngaySX;
            this.Loai = loai;
            this.Gia = gia;
        }
    }
}
