using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
    public  class khBLL
    {
        khAccess a = new khAccess();
        public string themKH2(KhoaHoc kh)
        {
            if (kh.TenKH == "")
            {
                return "Vui lòng nhập tên khóa học";
            }
            return a.themKH2(kh);
        }
        public string getMaKH2()
        {
            return a.getMaKH2();
        }
        public DataTable LoadKH2()
        {
            
            return a.LoadKH2();
        }
        public string CheckKHT2(string maKhoaHoc)
        {
            return a.CheckKHT2(maKhoaHoc);
        }
        public DataTable LoadKHT2(string maKhoaHoc)
        {
            return a.LoadKHT2(maKhoaHoc);
        }
        public string suaKH2(KhoaHoc b)
        {
            return a.suaKH2(b);
        }
        public string xoaKH2(string makh)
        {
            if (makh == "")
            {
                return "vui lòng chọn khóa học cần xóa";
            }
            return a.xoaKH2(makh);
        }

    }
}

