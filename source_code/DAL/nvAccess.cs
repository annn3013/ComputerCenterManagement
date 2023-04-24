using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.Security.Policy;

namespace DAL
{
    public class nvAccess : DbAccess
    {
        public string themNV2(NhanVien nv)
        {
            return themNV(nv);
        }
        public string xoaNV2(string manv)
        {
            return xoaNV(manv);
        }
        public string suaNV2(NhanVien nv)
        {
            return suaNV(nv);
        }
        public DataTable loadNV2()
        {
            return loadNV();
        }
        public string checkNV2(string manv)
        {
            return checkNV(manv);
        }
        public DataTable loadNVT2(string manv)
        {
            return loadNVT(manv);
        }
        public DataTable loadTNV2(string hoten)
        {
            return loadTNV(hoten);
        }
        public string autoNV2()
        {
            return autoNV();
        }
        public string checkNVT2(string manv)
        {
            return checkNVT(manv);
        }

    }



    
}
