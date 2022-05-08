using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using System.IO;
using Newtonsoft.Json;

namespace DoAnKTLT_NguyenCongDanh_21880020.DAL
{
    public struct DocLuu_HoaDon
    {
        public static string pathHDN = Path.GetFullPath("wwwroot/data/hoadonnhap.json");
        public static string pathHDX = Path.GetFullPath("wwwroot/data/hoadonxuat.json");

        //hoa don nhap
        public static List<HoaDonNhap> DocHoaDonNhap()
        {
            StreamReader stream = new StreamReader(pathHDN);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSHoaDonNhap = JsonConvert.DeserializeObject<List<HoaDonNhap>>(jSonString);
            return dSHoaDonNhap;
        }
        //ok
        public static void LuuDanhSachHoaDonNhap(List<HoaDonNhap> ds)
        {
            StreamWriter writer = new StreamWriter(pathHDN);
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
        //hoa don xuat
        public static List<HoaDonXuat> DocHoaDonXuat()
        {
            StreamReader stream = new StreamReader(pathHDX);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSHoaDonXuat = JsonConvert.DeserializeObject<List<HoaDonXuat>>(jSonString);
            return dSHoaDonXuat;
        }
        //ok
        public static void LuuDanhSachHoaDonXuat(List<HoaDonXuat> ds)
        {
            StreamWriter writer = new StreamWriter(pathHDX);
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        //ok
        public static void LuuHoaDonXuat(HoaDonXuat HoaDonXuat)
        {
            var dSHoaDonXuat = DocHoaDonXuat();
            dSHoaDonXuat.Add(HoaDonXuat);
            LuuDanhSachHoaDonXuat(dSHoaDonXuat);
        }
        //ok
        public static bool SuaHoaDonXuat(HoaDonXuat HoaDonXuat)
        {
            List<HoaDonXuat> lstHDNhap = DocHoaDonXuat();
            for (int i = 0; i < lstHDNhap.Count; i++)
            {
                if (lstHDNhap[i].MaHDX == HoaDonXuat.MaHDX)
                {
                    lstHDNhap[i] = HoaDonXuat;
                    LuuDanhSachHoaDonXuat(lstHDNhap);
                    return true;
                }
            }
            return false;
        }
        //ok
        public static bool XoaHoaDonXuat(string id)
        {
            List<HoaDonXuat> lstHDNhap = DocHoaDonXuat();
            for (int i = 0; i < lstHDNhap.Count; i++)
            {
                if (lstHDNhap[i].MaHDX == id)
                {
                    lstHDNhap.RemoveAt(i);
                    LuuDanhSachHoaDonXuat(lstHDNhap);
                    return true;
                }
            }
            return false;
        }
    }
}
