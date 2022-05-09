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
                var SLHangTonCuaMH = KiemTraTonKhoMaMH(HDX.MatHangXuat).Data;
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
        public static ServiceResult<int> KiemTraTonKhoMaMH(string maMH)
        {
            try
            {
                List<HangTon> lstHangTon = XuLy_HangTon.ThongKeHangTon().Data;
                foreach(HangTon ht in lstHangTon)
                {
                    if (ht.MaMH == maMH)
                    {
                        return new ServiceResult<int>(true, ht.SoLuongTon, null);
                    }
                }
                return new ServiceResult<int>(false, 0, "Không tìm thấy mã mặt hàng");
            }
            catch(Exception ex)
            {
                return new ServiceResult<int>(false, 0, ex.Message);
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
                return new ServiceResult<HoaDonXuat>(false, new HoaDonXuat(), "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<HoaDonXuat>(false, new HoaDonXuat(), ex.Message);
            }
        }
        public static ServiceResult<bool> SuaHoaDonXuat(HoaDonXuat HoaDonXuat)
        {
            try
            {
                if (HopLe(HoaDonXuat))
                {
                    DocLuu_HoaDon.SuaHoaDonXuat(HoaDonXuat);
                    return new ServiceResult<bool>(true, true, null);
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
