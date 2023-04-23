using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class gvAccess:DbAccess
    {
        public string themGV2(GiaoVien gv)
        {
            return themGV(gv);
        }
        public string suaGV2(GiaoVien gv)
        {
            return suaGV(gv);
        }
        public string xoaGV2(string magv)
        {
            return xoaGV(magv);
        }
        public string autoGV2()
        {
            return autoGV();
        }
        public string checkGV2(string magv)
        {
            return checkGV(magv);
        }
        public DataTable loadGV2()
        {
            return loadGV();
        }
        public DataTable loadGVT2(string magv)
        {
            return loadGVT(magv);
        }
        public DataTable loadGVC2(string maPhongHoc, int  caHoc, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return LoadGVC(maPhongHoc, caHoc, ngayBatDau, ngayKetThuc);
        }
        public DataTable loadTGV2(string hoten)
        {
            return loadTGV(hoten);
        }
        public string checkGVT2(string hoten)
        {
            return checkGVT(hoten);
        }
    }
}
