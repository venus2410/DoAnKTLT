using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.DAL;

namespace DoAnKTLT_NguyenCongDanh_21880020.Services
{
    public class XuLy_HoaDonXuat
    {
        public static bool HopLe(HoaDonXuat HDN)
        {
            if (string.IsNullOrWhiteSpace(HDN.MaHDX) ||
                    string.IsNullOrWhiteSpace(HDN.MatHangXuat) ||
                    HDN.SoLuongXuat < 0) return false;
            return true;
        }
        
        public static ServiceResult<bool> ThemHoaDonXuat(HoaDonXuat HDX)
        {
            try
            {
                if (!HopLe(HDX))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                if (TonTaiMaHDX(DocHoaDonXuat().Data, HDX.MaHDX))
                {
                    return new ServiceResult<bool>(false, false, "Mã hóa đơn đã tồn tại, vui lòng chọn mã mặt hàng khác");
                }
                var SLHangTonCuaMH = XuLy_HangTon.KiemTraTonKhoMaMH(HDX.MatHangXuat).Data;
                if (SLHangTonCuaMH < HDX.SoLuongXuat)
                {
                    return new ServiceResult<bool>(false, false, "Số lượng tồn không đủ");
                }
                DocLuu_HoaDon.LuuHoaDonXuat(HDX);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        //ok
        public static ServiceResult<List<HoaDonXuat>> DocHoaDonXuat()
        {
            try
            {
                List<HoaDonXuat> lst = DocLuu_HoaDon.DocHoaDonXuat();
                return new ServiceResult<List<HoaDonXuat>>(true, lst, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDonXuat>>(true, null, ex.Message);
            }
        }
        //ok
        public static bool TonTaiMaHDX(List<HoaDonXuat> lst, string MaHDX)
        {
            foreach (HoaDonXuat lh in lst)
            {
                if (lh.MaHDX == MaHDX) return true;
            }
            return false;
        }
        public static ServiceResult<List<HoaDonXuat>> TimKiemHoaDonXuat(string noiDungTimKiem)
        {
            try
            {
                List<HoaDonXuat> lstHDN = DocLuu_HoaDon.DocHoaDonXuat();
                if (string.IsNullOrWhiteSpace(noiDungTimKiem))
                {
                    return new ServiceResult<List<HoaDonXuat>>(true, lstHDN, null);
                }
                List<HoaDonXuat> lstKQuaTKiem = new List<HoaDonXuat>();
                foreach (HoaDonXuat HDN in lstHDN)
                {
                    if (HDN.MatHangXuat.Contains(noiDungTimKiem) || HDN.MaHDX.Contains(noiDungTimKiem))
                    {
                        lstKQuaTKiem.Add(HDN);
                    }
                }
                return new ServiceResult<List<HoaDonXuat>>(true, lstKQuaTKiem, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDonXuat>>(false, null, ex.Message);
            }
        }
        public static ServiceResult<List<string>> TimTenTheoID(List<HoaDonXuat> lstHDN)
        {
            if (lstHDN != null)
            {
                List<string> lstTenMH = new List<string>();
                try
                {
                    foreach (HoaDonXuat HDN in lstHDN)
                    {
                        lstTenMH.Add(XuLy_MatHang.TimTenTheoID(HDN.MatHangXuat).Data);
                    }
                    return new ServiceResult<List<string>>(true, lstTenMH, null);
                }
                catch (Exception ex)
                {
                    return new ServiceResult<List<string>>(false, lstTenMH, ex.Message);
                }
            }
            else
            {
                return new ServiceResult<List<string>>(false, null, "Không tìm thấy hóa đơn");
            }
        }
        public static ServiceResult<HoaDonXuat> TimKiemTheoID(string id)
        {
            try
            {
                List<HoaDonXuat> lstHDN = DocLuu_HoaDon.DocHoaDonXuat();
                foreach (HoaDonXuat HDN in lstHDN)
                {
                    if (HDN.MaHDX == id)
                    {
                        return new ServiceResult<HoaDonXuat>(true, HDN, null);
                    }
                }
                return new ServiceResult<HoaDonXuat>(false, new HoaDonXuat(), "Không tìm thấy hóa đơn");
            }
            catch (Exception ex)
            {
                return new ServiceResult<HoaDonXuat>(false, new HoaDonXuat(), ex.Message);
            }
        }
        public static ServiceResult<bool> SuaHoaDonXuat(HoaDonXuat hoaDonXuat)
        {
            try
            {
                if (HopLe(hoaDonXuat))
                {

                    HoaDonXuat hdCu = TimKiemTheoID(hoaDonXuat.MaHDX).Data;
                    int chenhLech,slCu;
                    if (hdCu.MatHangXuat == hoaDonXuat.MatHangXuat)
                    {
                        chenhLech = hoaDonXuat.SoLuongXuat- hdCu.SoLuongXuat;
                        slCu = XuLy_HangTon.KiemTraTonKhoMaMH(hdCu.MatHangXuat).Data;
                    }
                    else
                    {
                        chenhLech = hoaDonXuat.SoLuongXuat;
                        slCu= XuLy_HangTon.KiemTraTonKhoMaMH(hoaDonXuat.MatHangXuat).Data;
                    }
                    if (slCu >= chenhLech)
                    {
                        DocLuu_HoaDon.SuaHoaDonXuat(hoaDonXuat);
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
        public static ServiceResult<bool> XoaHoaDonXuat(string id)
        {
            try
            {
                DocLuu_HoaDon.XoaHoaDonXuat(id);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
