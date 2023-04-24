using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class phAccess:DbAccess
    {
        public string themPH2(Phong ph)
        {
            return themPH(ph);
        }
        public string suaPH2(Phong ph)
        {
            return suaPH(ph);
        }
        public DataTable loadPH2()
        {
            return loadPH();
        }
    }
}
