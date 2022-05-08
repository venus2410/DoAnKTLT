using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using System.IO;
using Newtonsoft.Json;

namespace DoAnKTLT_NguyenCongDanh_21880020.DAL
{
    public struct DocLuu_HoaDonNhap
    {
        public static string path = Path.GetFullPath("wwwroot/data/hoadonnhap.json");
        
        //ok
        public static List<HoaDonNhap> DocHoaDonNhap()
        {
            StreamReader stream = new StreamReader(path);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSHoaDonNhap = JsonConvert.DeserializeObject<List<HoaDonNhap>>(jSonString);
            return dSHoaDonNhap;
        }
        //ok
        public static void LuuDanhSachHoaDonNhap(List<HoaDonNhap> ds)
        {
            StreamWriter writer = new StreamWriter(path);
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        //ok
        public static void LuuHoaDonNhap(HoaDonNhap hoaDonNhap)
        {
            var dSHoaDonNhap = DocHoaDonNhap();
            dSHoaDonNhap.Add(hoaDonNhap);
            LuuDanhSachHoaDonNhap(dSHoaDonNhap);
        }
        //ok
        public static bool SuaHoaDonNhap(HoaDonNhap hoaDonNhap)
        {
            List<HoaDonNhap> lstHDNhap = DocHoaDonNhap();
            for (int i = 0; i < lstHDNhap.Count; i++)
            {
                if (lstHDNhap[i].MaHDN == hoaDonNhap.MaHDN)
                {
                    lstHDNhap[i] = hoaDonNhap;
                    LuuDanhSachHoaDonNhap(lstHDNhap);
                    return true;
                }
            }
            return false;
        }
        //ok
        public static bool XoaHoaDonNhap(string id)
        {
            List<HoaDonNhap> lstHDNhap = DocHoaDonNhap();
            for (int i = 0; i < lstHDNhap.Count; i++)
            {
                if (lstHDNhap[i].MaHDN == id)
                {
                    lstHDNhap.RemoveAt(i);
                    LuuDanhSachHoaDonNhap(lstHDNhap);
                    return true;
                }
            }
            return false;
        }
    }
}
