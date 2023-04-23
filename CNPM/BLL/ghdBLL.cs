using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public  class ghdBLL
    {
        ghdAccess a  = new ghdAccess();
        public DataTable loadGhD2()
        {
            return a.loadGhD2();
        }
        public string themGhD2(string mahv, string malh)
        {
            return a.themGhD2(mahv, malh);
        }
        public string xoaGhD2(string mahv, string malh)
        {
            return a.xoaGhD2(mahv, malh);
        }
    }
}
