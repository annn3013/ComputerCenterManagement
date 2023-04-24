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
    public class phBLL
    {
        phAccess a =    new phAccess();
        public string themPH2(Phong ph)
        {
            return a.themPH2(ph);
        }
        public string suaPH2(Phong ph)
        {
            return a.suaPH2(ph);
        }
        public DataTable loadPH2()
        {
            return a.loadPH2();
        }
    }
}
