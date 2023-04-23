using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAL
{
    public  class lhAccess:DbAccess
    {
        public string themLH2(LopHoc lh)
        {
            return themLH(lh);
        }
        public string suaLH2( LopHoc lopHoc)
        {
            return suaLH(lopHoc);
        }
        public string xoaLH2(string maLopHoc)
        {
            return xoaLH(maLopHoc);
        }
        public DataTable loadLH2()
        {
            return LoadLH();
        }
        public DataTable loadLHT2(string malh)
        {
            return LoadLHT(malh);
        }
        public string layMa2()
        {
            return LayMaLopHocCuoiCung();
        }
        public string autoLH2()
        {
            return autoLH();
        }
        public DataTable loadLHC2()
        {
            return LoadLHC();
        }
        public DataTable loadLHDK2(string a)
        {
            return loadLHDK(a);
        }
        public string checkLH2(string a)
        {
            return checkLH(a);
        }
    }

}
