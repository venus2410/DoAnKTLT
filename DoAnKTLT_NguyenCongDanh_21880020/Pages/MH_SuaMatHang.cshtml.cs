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
    public class MH_SuaMatHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public MatHang mh=new MatHang();
        public string maLHChon;
        public List<LoaiHang> lstLH=new List<LoaiHang>();
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        [BindProperty]
        public string ten { get; set; }
        [BindProperty]
        public string hanDung { get; set; }
        [BindProperty]
        public string ctySX { get; set; }
        [BindProperty]
        public string ngaySX { get; set; }
        [BindProperty]
        public string loai { get; set; }
        [BindProperty]
        public int gia { get; set; }
        public void OnGet()
        {
            lstLH = XuLy_LoaiHang.DocLoaiHang().Data;
            var kq = XuLy_MatHang.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                maLHChon = kq.Data.Loai;
                mh = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            MatHang matHang = new MatHang(Id, ten, hanDung, ctySX, ngaySX, loai, gia);
            var kq = XuLy_MatHang.SuaMatHang(matHang);
            if(kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemMatHang");
            }
            else
            {
                chuoi = kq.Message;
                mh= XuLy_MatHang.TimKiemTheoID(Id).Data;
            }
        }
    }
}
