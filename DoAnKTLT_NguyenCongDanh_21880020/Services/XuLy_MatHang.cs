using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.DAL;

namespace DoAnKTLT_NguyenCongDanh_21880020.Services
{
    public class XuLy_MatHang
    {
        public static ServiceResult<bool> ThemMatHang(MatHang mh)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mh.MaMH) ||
                    string.IsNullOrWhiteSpace(mh.TenMH) ||
                    string.IsNullOrWhiteSpace(mh.HanDungMH) ||
                    string.IsNullOrWhiteSpace(mh.CongTySX) ||
                    string.IsNullOrWhiteSpace(mh.NgaySX) ||
                    mh.Gia < 0)
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                else
                {
                    DocLuu_MatHang.LuuMatHang(mh);
                    return new ServiceResult<bool>(true, true, null);
                }    
            }
            catch(Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        
    }
}
