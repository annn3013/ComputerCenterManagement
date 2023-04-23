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
    public class hpAccess:DbAccess
    {
        public DataTable loadHP2()
        {
            return loadHP();
        }
        public DataTable loadHPTK2(string tenhv)
        {
            return loadHPTK(tenhv);
        }
        public DataTable loadHPC2()
        {
            return loadHPC();
        }
        public DataTable loadHPT2()
        {
            return loadHPT();
        }
        public DataTable loadHPD2()
        {
            return loadHPD();
        }
        public DataTable loadHPDu2()
        {
            return loadHPDu();
        }


    }
}
