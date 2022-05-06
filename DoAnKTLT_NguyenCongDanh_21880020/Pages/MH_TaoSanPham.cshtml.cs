using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.Services;

namespace WebApplication1.Pages
{
    public class MH_TaoSanPhamModel : PageModel
    {
        public string chuoi=string.Empty;
        public List<LoaiHang> lstLH;
        [BindProperty]
        public string Ma { get; set; }
        [BindProperty]
        public string Ten { get; set; }
        [BindProperty]
        public string HanDung { get; set; }
        [BindProperty]
        public string CongTySX { get; set; }
        [BindProperty]
        public string NgaySX{ get; set; }
        [BindProperty]
        public string Loai { get; set; }
        [BindProperty]
        public int Gia { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {              
            try
            {
                MatHang matHang = new MatHang();
                matHang.MaMH = Ma;
                matHang.TenMH = Ten;
                matHang.HanDungMH = HanDung;
                matHang.CongTySX = CongTySX;
                matHang.NgaySX = NgaySX;
                LoaiHang lH = new LoaiHang();
                lH.MaLH = Loai;
                matHang.Gia = Gia;

                var kq = XuLy_MatHang.ThemMatHang(matHang);
                if (kq.IsSuccess)
                {
                    chuoi = "Luu thanh cong";
                }
                else
                {
                    chuoi = kq.Message;
                }
            }
            catch (Exception ex)
            {
                chuoi = ex.Message;
            }
        }
    }
}
