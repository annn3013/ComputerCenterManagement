using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public  class diemAccess:DbAccess
    {
        public string themDiem2(Diem a)
        {
            return themDiem(a);
        }
        public string suaDiem2(Diem a)
        {
            return suaDiem(a);
        }

        public string xoaDiem2(string a, string b)
        {
            return xoaDiem(a,b);
        }
        public DataTable loadDiem2()
        {
            return loadDiem();
        }
        public DataTable loadDiemT2(string a)
        {
            return loadDiemT(a);
        }
        public string checkDiem2(string mahv)
        {
            return checkDiem(mahv);
        }
        public string checkDiemM2(string mamon)
        {
            return checkDiemM(mamon);
        }
        public DataTable hienDiemT2(string mahv)
        {
            return hienDiemT( mahv);
        }
        public DataTable hienDiemM2(string mamon)
        {
            return hienDiemM(mamon);
        }
        public SqlDataAdapter hienDiemTA2(string mahv)
        {
            return  hienDiemTA(mahv);
        }
    }
}
