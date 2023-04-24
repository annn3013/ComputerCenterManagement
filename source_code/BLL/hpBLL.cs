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
    public class hpBLL
    {
        hpAccess a = new hpAccess();
        public DataTable loadHP2()
        {
            return a.loadHP2();
        }
        public DataTable loadHPTK2(string tenhv)
        {
            return a.loadHPTK2(tenhv);
        }
        public DataTable loadHPC2()
        {
            return a.loadHPC2();
        }
        public DataTable loadHPT2()
        {
            return a.loadHPT2();
        }
        public DataTable loadHPD2()
        {
            return a.loadHPD2();
        }
        public DataTable loadHPDu2()
        {
            return a.loadHPDu2();
        }
    }
}
