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
            catch
            {
                throw new Exception("Không tìm thấy file lưu trữ");
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
    }
}
