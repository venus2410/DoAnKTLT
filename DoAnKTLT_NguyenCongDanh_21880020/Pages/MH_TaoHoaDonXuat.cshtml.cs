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
    public class MH_TaoHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH = new List<MatHang>();
        [BindProperty]
        public string maHD { get; set; }
        [BindProperty]
        public string mhChon { get; set; }
        [BindProperty]
        public int soLuong { get; set; }
        public void OnGet()
        {
            var kq = XuLy_MatHang.DocMatHang();
            if (kq.IsSuccess)
            {
                lstMH = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            HoaDonXuat hdx = new HoaDonXuat(maHD, mhChon, soLuong);
            var kq = XuLy_HoaDonXuat.ThemHoaDonXuat(hdx);
            if (kq.IsSuccess)
            {
                chuoi = "Thêm thành công";
            }
            else
            {
                chuoi = kq.Message;
            }
            var kq1 = XuLy_MatHang.DocMatHang();
            if (kq1.IsSuccess)
            {
                lstMH = kq1.Data;
            }
            else
            {
                chuoi = kq1.Message;
            }
        }
    }
}
