using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using System.IO;
using Newtonsoft.Json;

namespace DoAnKTLT_NguyenCongDanh_21880020.DAL
{
    public class DocLuu_LoaiHang
    {
        public static string path = Path.GetFullPath("wwwroot/data/loaihang.json");
        public static List<LoaiHang> DocLoaiHang()
        {
            StreamReader stream = new StreamReader(path);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSSP = JsonConvert.DeserializeObject<List<LoaiHang>>(jSonString);
            return dSSP;
        }
        public static void LuuDanhSachLoaiHang(List<LoaiHang> ds)
        {
            StreamWriter writer = new StreamWriter(path);
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        public static void LuuLoaiHang(LoaiHang loaiHang)
        {
            var dSLoaiHang = DocLoaiHang();
            dSLoaiHang.Add(loaiHang);
            LuuDanhSachLoaiHang(dSLoaiHang);
        }
        public static bool SuaLoaiHang(LoaiHang lh)
        {
            List<LoaiHang> lstLH = DocLoaiHang();
            for (int i = 0; i < lstLH.Count; i++)
            {
                if (lstLH[i].MaLH == lh.MaLH)
                {
                    lstLH[i] = lh;
                    LuuDanhSachLoaiHang(lstLH);
                    return true;
                }
            }
            return false;
        }
        public static bool XoaLoaiHang(string id)
        {
            List<LoaiHang> lstLH = DocLoaiHang();
            for (int i = 0; i < lstLH.Count; i++)
            {
                if (lstLH[i].MaLH == id)
                {
                    lstLH.RemoveAt(i);
                    LuuDanhSachLoaiHang(lstLH);
                    return true;
                }
            }
            return false;
        }
    }
}
