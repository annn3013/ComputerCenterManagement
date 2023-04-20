using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public  class khAccess:DbAccess
    {
        public string themKH2(KhoaHoc kh)
        {
            return themKH(kh);
        }
        public string getMaKH2()
        {
            return getMaKH();
        }
        public DataTable LoadKH2()
        {
            return LoadKH();
        }
        public string CheckKHT2(string maKhoaHoc)
        {
            return CheckKHT(maKhoaHoc);
        }
        public DataTable LoadKHT2(string maKhoaHoc)
        {
            return LoadKHT(maKhoaHoc);
        }
        public string suaKH2(KhoaHoc a)
        {
            return suaKH(a);
        }
        public string xoaKH2(string makh)
        {
            return xoaKH(makh);
        }
    }
}
