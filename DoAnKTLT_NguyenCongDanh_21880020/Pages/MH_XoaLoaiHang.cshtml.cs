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
    public class MH_XoaLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public LoaiHang lh=new LoaiHang();
        public bool timThay;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        public void OnGet()
        {
            var kq = XuLy_LoaiHang.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                lh = kq.Data;
                timThay = true;
                chuoi = $"Bạn chắc chắn muốn xóa loại hàng: {lh.TenLH}";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = XuLy_LoaiHang.XoaLoaiHang(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemLoaiHang");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
