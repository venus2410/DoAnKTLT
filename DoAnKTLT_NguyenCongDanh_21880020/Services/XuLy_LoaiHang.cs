using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.DAL;

namespace DoAnKTLT_NguyenCongDanh_21880020.Services
{
    public class XuLy_LoaiHang
    {
        public static ServiceResult<bool> ThemLoaiHang(LoaiHang loaiHang)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(loaiHang.MaLH) ||
                    string.IsNullOrWhiteSpace(loaiHang.TenLH))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng không bỏ trống các trường");
                }
                if(TonTaiMaLH(DocLoaiHang().Data, loaiHang.MaLH))
                {
                    return new ServiceResult<bool>(false, false, "Mã loại hàng đã tồn tại");
                }
                
                DocLuu_LoaiHang.LuuLoaiHang(loaiHang);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public static bool TonTaiMaLH(List<LoaiHang> lst,string maLH)
        {
            foreach(LoaiHang lh in lst)
            {
                if (lh.MaLH == maLH) return true;
            }
            return false;
        }
        public static ServiceResult<List<LoaiHang>> DocLoaiHang()
        {
            try
            {
                List<LoaiHang> lst = DocLuu_LoaiHang.DocLoaiHang();
                return new ServiceResult<List<LoaiHang>>(true, lst, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<List<LoaiHang>>(false, null, ex.Message);
            }
        }
        public static ServiceResult<List<LoaiHang>> TimKiemLoaiHang(string noiDung)
        {
            try
            {
                List<LoaiHang> lstLH = DocLuu_LoaiHang.DocLoaiHang();
                if (string.IsNullOrWhiteSpace(noiDung))
                {
                    return new ServiceResult<List<LoaiHang>>(true, lstLH, null);
                }
                List<LoaiHang> lstKQuaTKiem = new List<LoaiHang>();
                foreach (LoaiHang lh in lstLH)
                {
                    if (lh.TenLH.Contains(noiDung)||lh.MaLH.Contains(noiDung))
                    {
                        lstKQuaTKiem.Add(lh);
                    }
                }
                return new ServiceResult<List<LoaiHang>>(true, lstKQuaTKiem, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<LoaiHang>>(false, null, ex.Message);
            }
        }
        public static ServiceResult<LoaiHang> TimKiemTheoID(string id)
        {
            try
            {
                List<LoaiHang> lstLH = DocLuu_LoaiHang.DocLoaiHang();
                foreach (LoaiHang LH in lstLH)
                {
                    if (LH.MaLH == id)
                    {
                        return new ServiceResult<LoaiHang>(true, LH, null);
                    }
                }
                return new ServiceResult<LoaiHang>(false, new LoaiHang(), "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<LoaiHang>(false, new LoaiHang(), ex.Message);
            }
        }
        public static bool HopLe(LoaiHang lh)
        {
            if (string.IsNullOrWhiteSpace(lh.MaLH) ||
                    string.IsNullOrWhiteSpace(lh.TenLH))
                return false;
            return true;
        }
        public static ServiceResult<bool> SuaLoaiHang(LoaiHang lh)
        {
            try
            {
                if (HopLe(lh))
                {
                    DocLuu_LoaiHang.SuaLoaiHang(lh);
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
        public static List<string> TimTenLoaiHang(List<MatHang> lstMaLH)
        {
            List<string> lstKQ = new List<string>();
            foreach(MatHang mh in lstMaLH)
            {
                LoaiHang lh = TimKiemTheoID(mh.Loai).Data;
                lstKQ.Add(lh.TenLH);
            }
            return lstKQ;
        }
        public static ServiceResult<bool> XoaLoaiHang(string id)
        {
            try
            {
                DocLuu_LoaiHang.XoaLoaiHang(id);
                //cap nhat lai mat hang
                List<MatHang> lstMH = XuLy_MatHang.DocMatHang().Data;
                for(int i=0;i<lstMH.Count;i++)
                {
                    if(lstMH[i].Loai==id)
                    {
                        MatHang mh = lstMH[i];
                        mh.Loai = null;
                        XuLy_MatHang.SuaMatHang(mh);
                    }
                }
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
