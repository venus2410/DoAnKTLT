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
    public class MH_XoaHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public HoaDonXuat hdn = new HoaDonXuat();
        public bool timThay;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public void OnGet()
        {
            var kq = XuLy_HoaDonXuat.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                hdn = kq.Data;
                timThay = true;
                chuoi = $"Bạn chắc chắn muốn xóa hóa đơn có mã số: {hdn.MaHDX}?";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = XuLy_HoaDonXuat.XoaHoaDonXuat(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemHoaDonXuat");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
