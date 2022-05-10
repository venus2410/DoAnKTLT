using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.Services;

namespace DoAnKTLT_NguyenCongDanh_21880020.Pages.Shared
{
    public class MH_XoaHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public HoaDonNhap hdn = new HoaDonNhap();
        public bool timThay;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public void OnGet()
        {
            var kq = XuLy_HoaDonNhap.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                hdn = kq.Data;
                timThay = true;
                chuoi = $"Bạn chắc chắn muốn xóa hóa đơn có mã số: {hdn.MaHDN}?";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = XuLy_HoaDonNhap.XoaHoaDonNhap(Id);
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
