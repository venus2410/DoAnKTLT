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
    public class MH_TimKiemHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<HoaDonNhap> lstHDN = new List<HoaDonNhap>();
        public List<string> lstTenMH = new List<string>();
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public void OnGet()
        {
            var kq = XuLy_HoaDonNhap.DocHoaDonNhap();
            if (kq.IsSuccess)
            {
                lstHDN = kq.Data;
                lstTenMH = XuLy_HoaDonNhap.TimTenTheoID(lstHDN).Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = XuLy_HoaDonNhap.TimKiemHoaDonNhap(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count > 0)
                {
                    lstHDN = kq.Data;
                    lstTenMH = XuLy_HoaDonNhap.TimTenTheoID(lstHDN).Data;
                }
                else
                {
                    chuoi = "Không tìm thấy hóa đơn";
                }
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
