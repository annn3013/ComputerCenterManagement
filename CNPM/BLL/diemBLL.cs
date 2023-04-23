using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public  class diemBLL
    {
        diemAccess c=new diemAccess();
        public string themDiem2(Diem a)
        {
            if (a.MaMH == "")
            {
                return "vui lòng nhập mã môn học";
            }
            if (a.MaHV == "")
            {
                return "vui lòng nhập mã học viên";
            }
            if(a.KT1<0 || a.KT1 > 10)
            {
                return "vui lòng nhập điểm hợp lệ";
            }
            if (a.KT2 < 0 || a.KT2 > 10)
            {
                return "vui lòng nhập điểm hợp lệ";
            }
            if (a.DiemThi < 0 || a.DiemThi > 10)
            {
                return "vui lòng nhập điểm hợp lệ";
            }
            return c.themDiem2(a);
        }
        public string suaDiem2(Diem a)
        {
            if (a.MaMH == "")
            {
                return "vui lòng nhập mã môn học";
            }
            if (a.MaHV == "")
            {
                return "vui lòng nhập mã học viên";
            }
            if (a.KT1 < 0 || a.KT1 > 10)
            {
                return "vui lòng nhập điểm hợp lệ";
            }
            if (a.KT2 < 0 || a.KT2 > 10)
            {
                return "vui lòng nhập điểm hợp lệ";
            }
            if (a.DiemThi < 0 || a.DiemThi > 10)
            {
                return "vui lòng nhập điểm hợp lệ";
            }
            return c.suaDiem2(a);
        }

        public string xoaDiem2(string a, string b)
        {
            if (a == "")
            {
                return "vui lòng nhập mã học viên";
            }
            if (b == "")
            {
                return "vui lòng nhập mã môn học";
            }
            return c.xoaDiem2(a, b);
        }
        public DataTable loadDiem2()
        {
            return c.loadDiem2();
        }
        public DataTable loadDiemT2(string a)
        {
            return c.loadDiemT2(a);
        }
        public string checkDiem2(string mahv)
        {
            if (mahv == "")
            {
                return "vui lòng nhập mã học viên";
            }
            return c.checkDiem2(mahv);
        }
        public string checkDiemM2(string mamon)
        {
            if (mamon == "")
            {
                return "Vui lòng nhập mã môn học";
            }
            return c.checkDiemM2(mamon);
        }
        public DataTable hienDiemT2(string mahv)
        {
            return c.hienDiemT2(mahv);
        }
        public DataTable hienDiemM2(string mamon)
        {
            return c.hienDiemM2(mamon);
        }
        public SqlDataAdapter hienDiemTA2(string mahv)
        {
            return c.hienDiemTA2(mahv);
        }
    }
}
