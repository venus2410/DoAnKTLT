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
    public class MH_SuaHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH=XuLy_MatHang.DocMatHang().Data;
        public HoaDonNhap hdBanDau;
        public bool tonTai;
        
        [BindProperty(SupportsGet =true)]
        public string Id{ get; set; }
        [BindProperty]
        public string mhChon { get; set; }
        [BindProperty]
        public int soLuong { get; set; }

        public void OnGet()
        {
            var kq  = XuLy_HoaDonNhap.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                hdBanDau = kq.Data;
                tonTai = true;
            }
            else
            {
                tonTai = false;
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            HoaDonNhap hdn = new HoaDonNhap(Id, mhChon, soLuong);
            var kq = XuLy_HoaDonNhap.SuaHoaDonNhap(hdn);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemHoaDonNhap");
            }
            else
            {
                chuoi = kq.Message;
                hdBanDau = XuLy_HoaDonNhap.TimKiemTheoID(Id).Data;
            }
        }
    }
}
