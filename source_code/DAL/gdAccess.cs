using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public  class gdAccess:DbAccess
    {
        public string themGD2(string a, string b)
        {
            return themGD(a, b);
        }
        public string xoaGD2(string a, string b)
        {
            return xoaGD(a, b);
        }
        public DataTable timGD2(string b)
        {
            return timGD(b);
        }
        public DataTable loadGD2()
        {
            return loadGD();
        }

    }
}
