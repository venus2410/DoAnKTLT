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
    public class MH_ThongKeHangHetHanModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<HangTon> lstHangHetHan = new List<HangTon>();
        public void OnGet()
        {
            var kq = XuLy_HangTon.ThongKeHangHetHan();
            if (kq.IsSuccess)
            {
                lstHangHetHan = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
