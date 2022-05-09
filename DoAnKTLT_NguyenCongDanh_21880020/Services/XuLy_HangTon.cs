using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using DoAnKTLT_NguyenCongDanh_21880020.DAL;

namespace DoAnKTLT_NguyenCongDanh_21880020.Services
{
    public class XuLy_HangTon
    {
        public static ServiceResult<List<HangTon>> ThongKeHangTon()
        {
            try
            {
                List<HangTon> lstHangTon = new List<HangTon>();
                List<MatHang> lstMH = DocLuu_MatHang.DocMatHang();
                foreach(MatHang mh in lstMH)
                {
                    HangTon ht = new HangTon(mh.MaMH,mh.TenMH, 0);
                    lstHangTon.Add(ht);
                }
                List<HoaDonNhap> lstHoaDonNhap = DocLuu_HoaDon.DocHoaDonNhap();
                for(int i=0;i<lstHoaDonNhap.Count;i++)
                {
                    for(int j = 0; j < lstHangTon.Count; j++)
                    {
                        if(lstHoaDonNhap[i].MatHangNhap==lstHangTon[j].MaMH)
                        {
                            HangTon hangTon = lstHangTon[j];
                            int sl = hangTon.SoLuongTon;
                            hangTon.SoLuongTon += lstHoaDonNhap[i].SoLuongNhap;
                            lstHangTon[j] = hangTon; 
                        }
                    }
                }
                List<HoaDonXuat> lstHoaDonXuat = DocLuu_HoaDon.DocHoaDonXuat();
                for (int i = 0; i < lstHoaDonXuat.Count; i++)
                {
                    for (int j = 0; j < lstHangTon.Count; j++)
                    {
                        if (lstHoaDonXuat[i].MatHangXuat == lstHangTon[j].MaMH)
                        {
                            HangTon hangTon = lstHangTon[j];
                            int sl = hangTon.SoLuongTon;
                            hangTon.SoLuongTon -= lstHoaDonXuat[i].SoLuongXuat;
                            lstHangTon[j] = hangTon;
                        }
                    }
                }
                return new ServiceResult<List<HangTon>>(true, lstHangTon, null);
            }
            catch(Exception ex)
            {
                return new ServiceResult<List<HangTon>>(false, null, ex.Message);
            }
        }
        public static ServiceResult<int> KiemTraTonKhoMaMH(string maMH)
        {
            try
            {
                List<HangTon> lstHangTon = XuLy_HangTon.ThongKeHangTon().Data;
                foreach (HangTon ht in lstHangTon)
                {
                    if (ht.MaMH == maMH)
                    {
                        return new ServiceResult<int>(true, ht.SoLuongTon, null);
                    }
                }
                return new ServiceResult<int>(false, 0, "Không tìm thấy mã mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<int>(false, 0, ex.Message);
            }
        }
    }
}
