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
    public class ghdAccess :DbAccess 
    {
        public DataTable loadGhD2()
        {
            return loadGhD();
        }
        public string themGhD2(string mahv,string malh)
        {
            return themGhD(mahv, malh);
        }
        public string xoaGhD2(string mahv, string malh)
        {
            return xoaGhD(mahv, malh);
        }

    }
}
