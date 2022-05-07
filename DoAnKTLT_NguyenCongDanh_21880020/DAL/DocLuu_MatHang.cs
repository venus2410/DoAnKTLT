using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAnKTLT_NguyenCongDanh_21880020.Entities;
using System.IO;
using Newtonsoft.Json;

namespace DoAnKTLT_NguyenCongDanh_21880020.DAL
{
    public class DocLuu_MatHang
    {
        public static string path = Path.GetFullPath("wwwroot/data/mathang.json");
        public static List<MatHang> DocMatHang()
        {
            StreamReader stream = new StreamReader(path);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSSP = JsonConvert.DeserializeObject<List<MatHang>>(jSonString);
            return dSSP;
        }
        public static void LuuDanhSachMatHang(List<MatHang> ds)
        {
            StreamWriter writer = new StreamWriter(path);
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        public static void LuuMatHang(MatHang mh)
        {
            var dSMatHang = DocMatHang();
            dSMatHang.Add(mh);
            LuuDanhSachMatHang(dSMatHang);
        }
        public static bool SuaMatHang(MatHang mh)
        {
            List<MatHang> lstMH = DocMatHang();
            for(int i=0;i<lstMH.Count;i++)
            {
                if (lstMH[i].MaMH == mh.MaMH)
                {
                    lstMH[i] = mh;
                    LuuDanhSachMatHang(lstMH);
                    return true;
                }
            }
            return false;
        }
    }
}
