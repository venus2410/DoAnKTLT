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
    public class MH_XoaMatHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public MatHang mh;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        public void OnGet()
        {
            var kq = XuLy_MatHang.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                mh = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = XuLy_MatHang.XoaMatHang(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemMatHang");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
