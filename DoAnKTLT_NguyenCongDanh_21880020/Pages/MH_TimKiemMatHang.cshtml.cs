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
    public class MH_TimKiemMatHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH=new List<MatHang>();
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public void OnGet()
        {
            var kq= XuLy_MatHang.DocMatHang();
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
            var kq = XuLy_MatHang.TimKiemMatHang(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count>0)
                {
                    lstMH = kq.Data;
                }
                else
                {
                    chuoi = "Không tìm thấy mặt hàng";
                }
            }
            else
            {
                chuoi = kq.Message;
            }
        }

    }
}
