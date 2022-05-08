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
                    HangTon ht = new HangTon(mh.MaMH, 0);
                    lstHangTon.Add(ht);
                }
                List<HoaDonNhap> lstHoaDonNhap = new List<HoaDonNhap>();
                foreach(HoaDonNhap hdn in lstHoaDonNhap)
                {
                    for(int i = 0; i < lstHangTon.Count; i++)
                    {
                        if(hdn.MatHangNhap==lstHangTon[i].MaMH)
                        {
                            HangTon hangTon = lstHangTon[i];
                            hangTon.SoLuongTon+= hdn.SoLuongNhap;
                            lstHangTon[i] = hangTon; 
                        }
                    }
                }
                List<HoaDonXuat> lstHoaDonXuat = new List<HoaDonXuat>();
                foreach (HoaDonXuat hdx in lstHoaDonXuat)
                {
                    for (int i = 0; i < lstHangTon.Count; i++)
                    {
                        if (hdx.MatHangXuat == lstHangTon[i].MaMH)
                        {
                            HangTon hangTon = lstHangTon[i];
                            hangTon.SoLuongTon -= hdx.SoLuongXuat;
                            lstHangTon[i] = hangTon;
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

    }
}
