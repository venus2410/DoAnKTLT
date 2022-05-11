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
        public static bool HopLe(MatHang mh)
        {
            if (string.IsNullOrWhiteSpace(mh.MaMH) ||
                    string.IsNullOrWhiteSpace(mh.TenMH) ||
                    string.IsNullOrWhiteSpace(mh.HanDungMH) ||
                    string.IsNullOrWhiteSpace(mh.CongTySX) ||
                    string.IsNullOrWhiteSpace(mh.NgaySX) ||
                    mh.Gia < 0) return false;
            return true;
        }
        public static ServiceResult<bool> ThemMatHang(MatHang mh)
        {
            try
            {
                if (!HopLe(mh))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                if (TonTaiMaMH(DocMatHang().Data,mh.MaMH))
                {
                    return new ServiceResult<bool>(false, false, "Mã mặt hàng đã tồn tại, vui lòng chọn mã mặt hàng khác");
                }
                DocLuu_MatHang.LuuMatHang(mh);
                return new ServiceResult<bool>(true, true, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public static ServiceResult<List<MatHang>> DocMatHang()
        {
            try
            {
                List<MatHang> lst = DocLuu_MatHang.DocMatHang();
                return new ServiceResult<List<MatHang>>(true, lst, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<List<MatHang>>(true, null, ex.Message);
            }
        }
        public static bool TonTaiMaMH(List<MatHang> lst, string maMH)
        {
            foreach (MatHang lh in lst)
            {
                if (lh.MaMH == maMH) return true;
            }
            return false;
        }
        public static ServiceResult<List<MatHang>> TimKiemMatHang(string noiDungTimKiem)
        {
            try
            {
                List<MatHang> lstMH = DocLuu_MatHang.DocMatHang();
                if (string.IsNullOrWhiteSpace(noiDungTimKiem))
                {
                    return new ServiceResult<List<MatHang>>(true, lstMH, null);
                }
                List<MatHang> lstKQuaTKiem = new List<MatHang>();
                foreach (MatHang mh in lstMH)
                {
                    if (mh.TenMH.Contains(noiDungTimKiem)||mh.MaMH.Contains(noiDungTimKiem)
                        ||mh.HanDungMH.Contains(noiDungTimKiem)||mh.CongTySX.Contains(noiDungTimKiem)
                        ||mh.NgaySX.Contains(noiDungTimKiem)||mh.Loai.Contains(noiDungTimKiem))
                    {
                        lstKQuaTKiem.Add(mh);
                    }
                }
                return new ServiceResult<List<MatHang>>(true, lstKQuaTKiem, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<List<MatHang>>(false, null, ex.Message);
            }
        }
        public static ServiceResult<MatHang> TimKiemTheoID(string id)
        {
            try
            {
                List<MatHang> lstMH = DocLuu_MatHang.DocMatHang();
                foreach (MatHang mh in lstMH)
                {
                    if (mh.MaMH==id)
                    {
                        return new ServiceResult<MatHang>(true, mh, null);
                    }
                }
                return new ServiceResult<MatHang>(false, new MatHang(), "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<MatHang>(false, new MatHang(), ex.Message);
            }
        }
        public static ServiceResult<string> TimTenTheoID(string id)
        {
            try
            {
                List<MatHang> lstMH = DocLuu_MatHang.DocMatHang();
                foreach (MatHang mh in lstMH)
                {
                    if (mh.MaMH == id)
                    {
                        return new ServiceResult<string>(true, mh.TenMH, null);
                    }
                }
                return new ServiceResult<string>(false, null, "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<string>(false, null, ex.Message);
            }
        }
        public static ServiceResult<bool> SuaMatHang(MatHang matHang)
        {
            try
            {
                if (HopLe(matHang))
                {
                    DocLuu_MatHang.SuaMatHang(matHang);
                    return new ServiceResult<bool>(true, true, null);
                }
                else
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng nhập dữ liệu hợp lệ");
                }
            }
            catch(Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public static ServiceResult<bool> XoaMatHang(string id)
        {
            try
            {
                //xoa hoa don nhap xuat co mat hang
                List<HoaDonXuat> lstHDX = DocLuu_HoaDon.DocHoaDonXuat();
                foreach (HoaDonXuat hdx in lstHDX)
                {
                    if (hdx.MatHangXuat == id)
                    {
                        XuLy_HoaDonXuat.XoaHoaDonXuat(hdx.MaHDX);
                    }
                }
                List<HoaDonNhap> lstHDN = DocLuu_HoaDon.DocHoaDonNhap();
                foreach(HoaDonNhap hdn in lstHDN)
                {
                    if (hdn.MatHangNhap == id)
                    {
                        XuLy_HoaDonNhap.XoaHoaDonNhap(hdn.MaHDN);
                    }
                }
                
                //xoa mat hang khoi tap tin
                DocLuu_MatHang.XoaMatHang(id);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
