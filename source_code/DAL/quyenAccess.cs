using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class quyenAccess:DbAccess
    {
        public string CheckQuyen(int maquyen)
        {
            string info = CheckQuyenData(maquyen);
            return info;
        }
    }
}
