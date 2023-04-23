using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DAL
{
    public class hvAccess:DbAccess
    {
        public string themHV2(HocVien hv)
        {
            return themHV(hv);
        }
        public string LayMaCuoi2()
        {
            return LayMaCuoi();
        }
        public DataTable LoadHV2()
        {
            return loadHV();
        }
        public DataTable LoadHVT2(string mahv)
        {
            return loadHVT(mahv);
        }
        public DataTable LoadTHV2(string hoten)
        {
            return loadTHV(hoten);
        }
        public string TimHocVien2(string mahv)
        {
            if (mahv == "")
            {
                return "vui lòng nhập mã học viên để tìm kiếm";
            }
            return TimHocVien(mahv);
        }
        public string capNhatHV2(HocVien hv)
        {
            return capNhatHV(hv);
        }
        public string xoaHV2(string mahv)
        { 
            return xoaHV(mahv);
        }
        public string TimHocVienT2(string tenhv)
        {
            return TimHocVienT(tenhv);
        }
    }
}
