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
    public class MH_SuaLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public LoaiHang lh = new LoaiHang();
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string ten { get; set; }
        public void OnGet()
        {
            var kq = XuLy_LoaiHang.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                lh = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            LoaiHang lHSua = new LoaiHang(Id, ten);
            var kq = XuLy_LoaiHang.SuaLoaiHang(lHSua);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemLoaiHang");
            }
            else
            {
                chuoi = kq.Message;
                lh = XuLy_LoaiHang.TimKiemTheoID(Id).Data;
            }
        }
    }
}
