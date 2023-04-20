using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Security.Policy;
using Microsoft.SqlServer.Server;

namespace DAL
{
    public  class blAccess:DbAccess
    {
        public string themBL2(BienLai bl)
        {
            return ThemBL(bl);
        }
        public string xoaBL2(string id)
        {
            return xoaBL(id);
        }
        public string suaBL2(BienLai bl)
        {
            return suaBL(bl);
        }
        public DataTable loadBL2()
        {
            return loadBL();
        }
        public DataTable loadBLT2(string mahv)
        {
            return loadBLT(mahv);
        }
        public string autoBL2()
        {
            return autoBL();
        }
        public string CheckBL2(string mahv)
        {
            return checkBL(mahv);
        }
        public string CheckMBL2(string id)
        {
            return checkMBL(id);
        }
        public DataTable loadBLID2(string id)
        {
            return loadBLID(id);
        }
    }
}
