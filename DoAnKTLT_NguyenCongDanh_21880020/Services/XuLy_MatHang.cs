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
        public static ServiceResult<bool> XoaMatHang(string id)
        {
            return new ServiceResult<bool>(true, true, null);
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
                    if (mh.TenMH.Contains(noiDungTimKiem))
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
    }
}
