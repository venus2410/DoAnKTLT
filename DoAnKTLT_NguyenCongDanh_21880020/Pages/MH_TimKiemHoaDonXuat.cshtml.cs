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
    public class MH_TimKiemHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<HoaDonXuat> lstHDX = new List<HoaDonXuat>();
        public List<string> lstTenMH = new List<string>();
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public void OnGet()
        {
            var kq = XuLy_HoaDonXuat.DocHoaDonXuat();
            if (kq.IsSuccess)
            {
                lstHDX = kq.Data;
                lstTenMH = XuLy_HoaDonXuat.TimTenTheoID(lstHDX).Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = XuLy_HoaDonXuat.TimKiemHoaDonXuat(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count > 0)
                {
                    lstHDX = kq.Data;
                    lstTenMH = XuLy_HoaDonXuat.TimTenTheoID(lstHDX).Data;
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
