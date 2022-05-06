using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.Services;

namespace DoAnKTLT_NguyenCongDanh_21880020.Pages
{
    public class MH_TaoLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        [BindProperty]
        public string Ma { get; set; }
        [BindProperty]
        public string Ten { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {
                LoaiHang lh = new LoaiHang();
                lh.MaLH = Ma;
                lh.TenLH = Ten;
                var kq = XuLy_LoaiHang.ThemLoaiHang(lh);
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
