using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.DAL;

namespace DoAnKTLT_NguyenCongDanh_21880020.Services
{
    public class XuLy_HoaDonNhap
    {
        //ok
        public static bool HopLe(HoaDonNhap HDN)
        {
            if (string.IsNullOrWhiteSpace(HDN.MaHDN) ||
                    string.IsNullOrWhiteSpace(HDN.MatHangNhap) ||
                    HDN.SoLuongNhap < 0) return false;
            return true;
        }
        //ok
        public static ServiceResult<bool> ThemHoaDonNhap(HoaDonNhap HDN)
        {
            try
            {
                if (!HopLe(HDN))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                if (TonTaiMaHDN(DocHoaDonNhap().Data, HDN.MaHDN))
                {
                    return new ServiceResult<bool>(false, false, "Mã hóa đơn đã tồn tại, vui lòng chọn mã mặt hàng khác");
                }
                DocLuu_HoaDon.LuuHoaDonNhap(HDN);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        //ok
        public static ServiceResult<List<HoaDonNhap>> DocHoaDonNhap()
        {
            try
            {
                List<HoaDonNhap> lst = DocLuu_HoaDon.DocHoaDonNhap();
                return new ServiceResult<List<HoaDonNhap>>(true, lst, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDonNhap>>(true, null, ex.Message);
            }
        }
        //ok
        public static bool TonTaiMaHDN(List<HoaDonNhap> lst, string maHDN)
        {
            foreach (HoaDonNhap lh in lst)
            {
                if (lh.MaHDN == maHDN) return true;
            }
            return false;
        }
        public static ServiceResult<List<HoaDonNhap>> TimKiemHoaDonNhap(string noiDungTimKiem)
        {
            try
            {
                List<HoaDonNhap> lstHDN = DocLuu_HoaDon.DocHoaDonNhap();
                if (string.IsNullOrWhiteSpace(noiDungTimKiem))
                {
                    return new ServiceResult<List<HoaDonNhap>>(true, lstHDN, null);
                }
                List<HoaDonNhap> lstKQuaTKiem = new List<HoaDonNhap>();
                foreach (HoaDonNhap HDN in lstHDN)
                {
                    if (HDN.MatHangNhap.Contains(noiDungTimKiem) || HDN.MaHDN.Contains(noiDungTimKiem))
                    {
                        lstKQuaTKiem.Add(HDN);
                    }
                }
                return new ServiceResult<List<HoaDonNhap>>(true, lstKQuaTKiem, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDonNhap>>(false, null, ex.Message);
            }
        }
        public static ServiceResult<HoaDonNhap> TimKiemTheoID(string id)
        {
            try
            {
                List<HoaDonNhap> lstHDN = DocLuu_HoaDon.DocHoaDonNhap();
                foreach (HoaDonNhap HDN in lstHDN)
                {
                    if (HDN.MaHDN == id)
                    {
                        return new ServiceResult<HoaDonNhap>(true, HDN, null);
                    }
                }
                return new ServiceResult<HoaDonNhap>(false, new HoaDonNhap(), "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<HoaDonNhap>(false, new HoaDonNhap(), ex.Message);
            }
        }

        public static ServiceResult<bool> SuaHoaDonNhap(HoaDonNhap HoaDonNhap)
        {
            try
            {
                if (HopLe(HoaDonNhap))
                {
                    
                    HoaDonNhap hdCu = TimKiemTheoID(HoaDonNhap.MaHDN).Data;
                    int chenhLech;
                    if (hdCu.MatHangNhap == HoaDonNhap.MatHangNhap)
                    {
                        chenhLech = hdCu.SoLuongNhap - HoaDonNhap.SoLuongNhap;
                    }
                    else
                    {
                        chenhLech = hdCu.SoLuongNhap;
                    }
                    if (XuLy_HangTon.KiemTraTonKhoMaMH(HoaDonNhap.MatHangNhap).Data >= chenhLech)
                    {
                        DocLuu_HoaDon.SuaHoaDonNhap(HoaDonNhap);
                        return new ServiceResult<bool>(true, true, null);
                    }
                    else
                    {
                        return new ServiceResult<bool>(false, false, "Số lượng hàng sửa làm tồn kho âm");
                    }
                }
                else
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng nhập dữ liệu hợp lệ");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public static ServiceResult<bool> XoaHoaDonNhap(string id)
        {
            try
            {
                DocLuu_HoaDon.XoaHoaDonNhap(id);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
